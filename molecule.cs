using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace makeinp
{
	public class molecule
	{
		// ------------------------
		// data
		[XmlIgnore]
		public string RawData
		{
			get;
			protected set;
		}
		[XmlIgnore]
		public List<string> LineDatas
		{
			get;
			protected set;
		}
		[XmlIgnore]
		public List<string[]> Datas
		{
			get;
			protected set;
		}
		[XmlIgnore]
		public bool IsDataExist 
		{
			get;
			protected set;
		}

		// ------------------------
		// constructor(no-opt)
		public molecule()
		{
			this.DataSet("");
		}
		// constructor(input-text)
		public molecule(string text)
		{
			this.DataSet(text);
		}

		// ------------------------
		// data-set
		public void DataSet(string text)
		{
			// raw
			RawData = text;
			LineDatas = new List<string>();
			Datas = new List<string[]>();
			// datas
			if(text != string.Empty) {
				LineDatas.AddRange(text.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries));
				foreach(var line in LineDatas) {
					Datas.Add(LineSplit(line));
				}
				IsDataExist = true;
			}
			else {
				IsDataExist = false;
			}
		}
		// header get
		public string[] GetHeaderLine()
		{
			if(IsDataExist == false || LineDatas.Count <= 0) {
				return new string[]{};
			}
			return Datas[0];
		}
		// get molecular-location
		public string GetLocation()
		{
			if(IsDataExist == false) {
				return "";
			}
			var rst = "";
			if(IsZMatrix() == true) {
				// z-matrix
				var head = GetHeaderLine();
				var symbolIndex = foundItem(head, "Symbol");
				var connectIndexs = foundItems(head, new string[] {
					"NA", "NB", "NC"
				});
				var dataIndexs = foundItems(head, new string[] {
					"Bond", "Angle", "Dihedral"
				});
				var conPrefex = new string[] { "r", "a", "d" };
				var conCounts = new int[] { 1, 1, 1 };
				var idxDict = new Dictionary<string, string>();
				for(var i = 1; i < Datas.Count; i++) {
					// symbol
					rst += Datas[i][symbolIndex] + "\t";
					// connect and preindex
					for(var ci = 0; ci < connectIndexs.Count; ci++ ) {
						var dat = Datas[i][connectIndexs[ci]];
						var con = conPrefex[ci] + conCounts[ci];
						var val = Datas[i][dataIndexs[ci]];
						var isexist = (dat.Trim() != String.Empty);
						if(isexist) {
							rst += dat + " " + con + "\t";
							idxDict.Add(con, val);
							conCounts[ci]++;
						}
					}
					rst += "\n";
				}
				rst += "\n";
				for(var c = 0; c < conCounts.Length; c++) {
					for(var ca = 1; ca < conCounts[c]; ca++) {
						var key = conPrefex[c] + ca;
						rst += key + "\t" + idxDict[key] + "\n";
					}
				}
				return rst;
			}
			else {
				// cartesian
				var head = GetHeaderLine();
				var itemIndexs = foundItems(head, new string[] { "Symbol", "X", "Y", "Z" });
				for(var i = 1; i < Datas.Count; i++) {
					foreach(var ix in itemIndexs) {
						var opt = (Datas[i].Length > ix ? Datas[i][ix] : "");
						rst += opt + "\t";
					}
					rst += "\n";
				}
				return rst;
			}
		}
		// check is-Zmatrix
		public bool IsZMatrix()
		{
			var head = GetHeaderLine();
			var isExistDihedral = head.Any(a => { return a.IndexOf("Dihedral") >= 0; });
			return isExistDihedral;
		}
		// get mode-str
		public string GetTypeStr()
		{
			if(IsDataExist == false) {
				return "";
			}
			else if(IsZMatrix() == true) {
				return "Z-matrix";
			}
			else {
				return "cartesian";
			}
		}

		// --data split
		protected string[] LineSplit(string line)
		{
			return line.Split(new[] { ' ', '\t', ',' }/*, StringSplitOptions.RemoveEmptyEntries*/);
		}
		// item found
		protected int foundItem(string[] strs, string target)
		{
			for(var i = 0; i < strs.Length; i++) {
				if(strs[i] == target) {
					return i;
				}
			}
			return -1;
		}
		protected List<int> foundItems(string[] strs, string[] targets)
		{
			var rsts = new List<int>();
			for(var i = 0; i < strs.Length; i++) {
				foreach(var t in targets) {
					if(strs[i] == t) {
						rsts.Add(i);
					}
				}
			}
			return rsts;
		}

		// ------------------------
		// check variable data
		public static bool IsVariableTextData(string text)
		{
			var test = new molecule(text);
			var head = test.GetHeaderLine();
			var rst = (head.Count() >= 2);
			return rst;
		}
	}
}
