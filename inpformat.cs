using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace makeinp
{
	// data-derivery class
	public class makeinpdata
	{
		// varidate [main]
		public molecule inputdata;
		public bool isusecheckfile;
		public string chklocation;
		public string name
		{
			get
			{
				var nm = _name;
				var basis = (this.basis + this.star).Replace("-", "").Replace("*", "s").Replace("+", "p");
				nm = nm.Replace("[$theory]", this.theory);
				nm = nm.Replace("[$basis]", basis);
				nm = nm.Replace("[$method]", this.theory + "-" + basis);
				if(this.symbols != null) {
					foreach(var key in this.symbols.Keys) {
						var formatstr = $"{this.symbols[key]:00}";
						nm = nm.Replace($"[${key}]", formatstr);
					}
				}
				return nm;
			}
			set
			{
				_name = value;
			}
		}
		private string _name;

		public string location;
		public int nproc;
		public bool no_assgn;
		public int mem;
		public string mem_unit;
		public string theory, basis, star;
		public bool istest;
		public bool isnosymm;
		public int charge;
		public int spin;
		public bool genfile_opt;
		public bool genfile_freq;
		public bool genfile_irc;
		public bool genfile_nbo;
		public bool genfile_td;
		public bool genfile_ct;
		public bool no_scf_output = false;
		// import-datas
		[XmlIgnore]
		public Dictionary<string, int> symbols = null;
		// SCF
		public string scf;
		// IOP
		public string iop;
		// OPT
		[XmlIgnore]
		public List<string> lockpos;
		public string opt_fc;
		public int optcyc;
		public bool istransition;
		// FREQ
		public string freq_mode;
		public bool freq_containopt;
		// IRC
		public string ircforcemode;
		public int ircmaxpoint;
		public bool ircisgendualfile;
		// TD
		public string td_calctype;
		public int td_nstate;
		public string td_density;
		// Custom
		public string ct_string;

		// constructor
		public makeinpdata()
		{
			this.nproc = 1;
			this.no_assgn = true;
			this.mem = 64;
			this.mem_unit = "MW";
			this.theory = "HF";
			this.basis = "6-31G";
			this.star = "*";
			this.istest = true;
			this.spin = 1;
			this.lockpos = new List<string>();
			this.scf = "maxcycle=100";
			this.iop = "1/8=10,2/9=111,3/24=0,6/6=1,6/8=2,6/9=2";
			// opt
			this.optcyc = 60;
			this.opt_fc = "";
			// freq
			this.freq_mode = "NoRaman";
			this.freq_containopt = true;
			// irc
			this.ircforcemode = "calcfc";
			this.ircmaxpoint = 50;
			this.ircisgendualfile = true;
		}
		// function
		public string GetMethodName()
		{
			return theory + "/" + basis + star + " test sleazy" + (isnosymm ? " nosymm" : "");
		}
	}

	// based
	public abstract class inpformat
	{
		// variable
		public string baseString = "";
		public string editString = "";
		public string IdentifyName { get; protected set; }
		public string OptionName { get; protected set; }
		public string Extension { get; protected set; }
		// constructor
		public inpformat()
		{
			Extension = ".inp";
		}
		// function
		public string valueset(string tg, params string[] ps)
		{
			if(ps.Length <= 1 && ps[0].IndexOf('=') < 0) {
				return tg + "=" + ps[0];
			}
			else if(ps.Length >= 1) {
				var rst = tg + "(";
				for(var i = 0; i < ps.Length; i++) {
					if(ps[i] != string.Empty) {
						if(i != 0) {
							rst += ",";
						}
						rst += ps[i];
					}
				}
				rst += ")";
				return rst;
			}
			else {
				return tg;	// ERROR?
			}
		}
		public string getscrfilepath(makeinpdata md, setting st)
		{
			var rst = st.scrDir + st.scrName;
			rst = rst.Replace("%user%", st.usrName);
			rst = rst.Replace("%name%", this.genscrfilename(md));
			rst = rst.Replace("%option%", this.OptionName);
			rst = rst.Replace("%ext%", this.Extension);
			return rst;
		}
		public string getmethodabst(makeinpdata md)
		{
			return md.GetMethodName().Split(new[] { ' ', ',', '\t' })[0];
		}
		public string output(makeinpdata md, setting st)
		{
			var rst = "";
			rst += output_before(ref md, ref st);
			rst +=
				"!-- This inputfile generate by 'makeinp' Ver:0.9.5 --!\n" +
				"$RunGauss\n" +
				(md.no_assgn ? "!" : "") + valueset("%nproc", md.nproc.ToString()) + "\n" +
				valueset("%mem", md.mem.ToString() + md.mem_unit) + "\n" +
				valueset("%chk", getscrfilepath(md, st)) + "\n" +
				"#p " + md.GetMethodName() + "\n" +
				this.output_addition(md, st) +
				(!md.no_scf_output ? valueset("scf", md.scf.Split(',')) + "\n" : "") +
				valueset("iop", md.iop.Split(',')) + "\n" +
				(md.isusecheckfile ? "guess=read geom=check \n" : "") +
				"\n" +
				genfilename(md) + " " + getmethodabst(md) + "\n" +
				"\n" +
				md.charge + " " + md.spin + "\n" +
				(!md.isusecheckfile ? md.inputdata.GetLocation(md.lockpos.ToArray()) : "");
			rst += output_after(ref md, ref st);
			rst += "\n";
			return rst;
		}
		public bool writefile(makeinpdata md, setting st)
		{
			var filename = outputPath(md);
			var output = this.output(md, st);
			var wfile = new StreamWriter(filename);
			wfile.Write(output);
			wfile.Close();
			return true;
		}
		public string outputPath(makeinpdata md)
		{
			return md.location + "/" + this.genfilename(md) + OptionName + Extension;
		}
		public bool isExistGenerateFile(makeinpdata md)
		{
			return File.Exists(outputPath(md));
		}
		public virtual string output_before(ref makeinpdata md, ref setting st)
		{
			return "";
		}
		public virtual string output_after(ref makeinpdata md, ref setting st)
		{
			return "";
		}
		public abstract bool generateCheck(makeinpdata md);
		public abstract string genfilename(makeinpdata md);
		public abstract string genscrfilename(makeinpdata md);
		public abstract string output_addition(makeinpdata md, setting st);
	}

	// optimize
	public class optformat : inpformat
	{
		// variable
		// constructor
		public optformat()
		{
			IdentifyName = "optimize";
			OptionName = "";
		}
		// function
		public override bool generateCheck(makeinpdata md)
		{
			return md.genfile_opt;
		}
		public override string genfilename(makeinpdata md)
		{
			return md.name;
		}
		public override string genscrfilename(makeinpdata md)
		{
			return md.name;
		}
		public override string output_addition(makeinpdata md, setting st)
		{
			var rst =
				valueset("pop", "reg") + "\n" +
				valueset("opt",
					"maxcycle=" + md.optcyc,
					md.opt_fc,
					(md.istransition ? "ts,noeigentest" : ""),
					md.inputdata.GetTypeStr()
				) + "\n" +
				(md.freq_containopt ? valueset("freq", md.freq_mode) + "\n" : "") +
				"";
			return rst;
		}
	}

	// freq
	public class freqformat : inpformat
	{
		// variable
		// constructor
		public freqformat()
		{
			IdentifyName = "frequency";
			OptionName = "";
		}
		// function
		public override string output_before(ref makeinpdata md, ref setting st)
		{
			// no use-matrix
			if(md.genfile_opt) {
				md.isusecheckfile = true;
				md.chklocation = getscrfilepath(md, st);
			}
			return "";
		}
		public override bool generateCheck(makeinpdata md)
		{
			return md.genfile_freq && !md.freq_containopt;
		}
		public override string genfilename(makeinpdata md)
		{
			return md.name + "_freq";
		}
		public override string genscrfilename(makeinpdata md)
		{
			return md.name;
		}
		public override string output_addition(makeinpdata md, setting st)
		{
			var rst =
				valueset("pop", "reg") + "\n" +
				valueset("freq", md.freq_mode) + "\n" +
				"";
			return rst;
		}
	}

	// IRC
	public class ircformat : inpformat
	{
		// variable
		// constructor
		public ircformat()
		{
			IdentifyName = "IRC";
			OptionName = "";
			//OptionName = "_ib";
		}
		// function
		public override string output_before(ref makeinpdata md, ref setting st)
		{
			// no use-matrix
			md.isusecheckfile = true;
			md.chklocation = getscrfilepath(md, st);
			return "";
		}
		public override bool generateCheck(makeinpdata md)
		{
			return md.genfile_irc && !md.ircisgendualfile;
		}
		public override string genfilename(makeinpdata md)
		{
			return md.name + "_ib";
		}
		public override string genscrfilename(makeinpdata md)
		{
			return md.name + "_ib";
		}
		public override string output_addition(makeinpdata md, setting st)
		{
			var rst =
				valueset("pop", "none") + "\n" +
				valueset("irc", "maxpoints=" + md.ircmaxpoint, md.ircforcemode) + "\n" +
				"";
			return rst;
		}
	}

	// IRC(forward)
	public class ircfformat : ircformat
	{
		public ircfformat()
		{
			IdentifyName = "IRC(forward)";
			OptionName = "";
			//OptionName = "_if";
		}
		public override bool generateCheck(makeinpdata md)
		{
			return md.genfile_irc && md.ircisgendualfile;
		}
		public override string genfilename(makeinpdata md)
		{
			return md.name + "_if";
		}
		public override string genscrfilename(makeinpdata md)
		{
			return md.name + "_if";
		}
		public override string output_addition(makeinpdata md, setting st)
		{
			var rst =
				valueset("pop", "none") + "\n" +
				valueset("irc", "maxpoints=" + md.ircmaxpoint, md.ircforcemode, "forward") + "\n" +
				"";
			return rst;
		}
	}

	// IRC(forward)
	public class ircrformat : ircformat
	{
		public ircrformat()
		{
			IdentifyName = "IRC(reverse)";
			OptionName = "";
			//OptionName = "_ir";
		}
		public override bool generateCheck(makeinpdata md)
		{
			return md.genfile_irc && md.ircisgendualfile;
		}
		public override string genfilename(makeinpdata md)
		{
			return md.name + "_ir";
		}
		public override string genscrfilename(makeinpdata md)
		{
			return md.name + "_ir";
		}
		public override string output_addition(makeinpdata md, setting st)
		{
			var rst =
				valueset("pop", "none") + "\n" +
				valueset("irc", "maxpoints=" + md.ircmaxpoint, md.ircforcemode, "reverse") + "\n" +
				"";
			return rst;
		}
	}

	// freq
	public class tdformat : inpformat
	{
		// variable
		// constructor
		public tdformat()
		{
			IdentifyName = "TD";
			OptionName = "";
		}
		// function
		public override string output_before(ref makeinpdata md, ref setting st)
		{
			md.no_scf_output = true;
			return "";
		}
		public override bool generateCheck(makeinpdata md)
		{
			return md.genfile_td;
		}
		public override string genfilename(makeinpdata md)
		{
			return md.name + "_td";
		}
		public override string genscrfilename(makeinpdata md)
		{
			return md.name;
		}
		public override string output_addition(makeinpdata md, setting st)
		{
			var rst =
				valueset("TD", md.td_calctype, "Nstate=" + md.td_nstate) + "\n" +
				valueset("density", md.td_density) + "\n" +
				valueset("pop", "reg") + "\n" +
				"";
			return rst;
		}
	}

	// nbo
	public class nboformat : inpformat
	{
		// variable
		// constructor
		public nboformat()
		{
			IdentifyName = "NBO";
			OptionName = "";
		}
		// function
		public override string output_before(ref makeinpdata md, ref setting st)
		{
			// no use-matrix
			md.isusecheckfile = true;
			md.chklocation = getscrfilepath(md, st);
			return "";
		}
		public override string output_after(ref makeinpdata md, ref setting st)
		{
			return "\n" + "$nbo bndidx $end" + "\n";
		}
		public override bool generateCheck(makeinpdata md)
		{
			return md.genfile_nbo;
		}
		public override string genfilename(makeinpdata md)
		{
			return md.name + "_nbo";
		}
		public override string genscrfilename(makeinpdata md)
		{
			return md.name;
		}
		public override string output_addition(makeinpdata md, setting st)
		{
			var rst =
				valueset("pop", "nboread") + "\n" +
				"";
			return rst;
		}
	}
	
	// custom
	public class ctformat : inpformat
	{
		// variable
		// constructor
		public ctformat()
		{
			IdentifyName = "Custom";
			OptionName = "";
		}
		// function
		public override string output_before(ref makeinpdata md, ref setting st)
		{
			md.no_scf_output = true;
			md.isusecheckfile = false;
			return "";
		}
		public override bool generateCheck(makeinpdata md)
		{
			return md.genfile_ct;
		}
		public override string genfilename(makeinpdata md)
		{
			return md.name;
		}
		public override string genscrfilename(makeinpdata md)
		{
			return md.name;
		}
		public override string output_addition(makeinpdata md, setting st)
		{
			return (md.ct_string.Length > 0 ? md.ct_string + "\n" : "");
		}
	}

}
