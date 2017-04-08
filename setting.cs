using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace makeinp
{
	public class setting
	{
		// app
		public bool isFirstLaunch;
		// user
		public string usrName;
		public string fileName;
		public string scrDir;
		public string scrName;
		// history
		public makeinpdata latestData;

		// constructor
		public setting()
		{
			GetDefaultSetting(this);
		}

		// static-function
		public static setting GetDefaultSetting(setting def = null)
		{
			if(def == null) {
				def = new setting();
			}
			def.isFirstLaunch = true;
			def.usrName = "";
			def.fileName = "%name%%option%.%ext%";
			def.scrDir = "/home/%user%/g09.scr/";
			def.scrName = "%name%.chk";
			def.latestData = new makeinpdata();
			return def;
		}
	}
}
