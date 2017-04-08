using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows;
using System.Windows.Forms;

namespace makeinp
{
	// data-derivery class
	public class makeinpdata
	{
		// varidate [main]
		public molecule inputdata;
		public bool isusecheckfile;
		public string chklocation;
		public string name;
		public string location;
		public int nproc;
		public bool no_assgn;
		public int mem;
		public string mem_unit;
		public string theory, basis, star;
		public bool istest;
		public int charge;
		public int spin;
		public bool genfile_opt;
		public bool genfile_freq;
		public bool genfile_irc;
		// SCF
		public string scfcond;
		public int scfmax;
		// IOP
		public string iop;
		// OPT
		public int optcyc;
		public bool istransition;
		// FREQ

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
			this.scfcond = "sleazy";
			this.scfmax = 100;
			this.iop = "1/8=10,2/9=111,3/24=0,6/6=1,6/8=2,6/9=2";
			this.optcyc = 60;
		}
		// function
		public string GetMethodName()
		{
			return theory + "/" + basis + star + (istest ? " test" : "");
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
			if(ps.Length >= 2) {
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
			else if(ps.Length >= 1) {
				return tg + "=" + ps[0];
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
			output_before(ref md, ref st);
			var rst =
				"!-- This inputfile generate by 'makeinp' --!\n" +
				"$RunGauss\n" +
				(md.no_assgn ? "!" : "") + valueset("%nproc", md.nproc.ToString()) + "\n" +
				valueset("%mem", md.mem.ToString() + md.mem_unit) + "\n" +
				valueset("%chk", getscrfilepath(md, st)) + "\n" +
				"#p " + md.GetMethodName() + "\n" +
				this.output_addition(md, st) +
				valueset("iop", md.iop.Split(',')) + "\n" +
				valueset("scf", md.scfcond, "maxcycle=" + md.scfmax) + "\n" +
				(md.isusecheckfile ? "guess=read geom=check \n" : "") + 
				"\n" +
				genfilename(md) + " " + getmethodabst(md) + "\n" +
				"\n" +
				md.charge + " " + md.spin + "\n" +
				(!md.isusecheckfile ? md.inputdata.GetLocation() : "") +
				"\n";
			return rst;
		}
		public bool writefile(makeinpdata md, setting st)
		{
			var filename = md.location + "/" + this.genfilename(md) + OptionName + Extension;
			var output = this.output(md, st);
			var wfile = new StreamWriter(filename);
			wfile.Write(output);
			wfile.Close();
			return true;
		}
		public virtual void output_before(ref makeinpdata md, ref setting st)
		{
			return;
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
					(md.istransition ? "ts,noeigentest,calcfc" : ""),
					md.inputdata.GetTypeStr()
				) + "\n" +
				"";
			return rst;
		}
	}

	// optimize
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
		public override void output_before(ref makeinpdata md, ref setting st)
		{
			// no use-matrix
			md.isusecheckfile = true;
			md.chklocation = getscrfilepath(md, st);
			return;
		}
		public override bool generateCheck(makeinpdata md)
		{
			return md.genfile_freq;
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
				valueset("freq", "noraman") + "\n" +
				"";
			return rst;
		}
	}
}
