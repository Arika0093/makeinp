using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace makeinp
{
	static class program
	{
		/// <summary>
		/// アプリケーションのメイン エントリ ポイントです。
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new main());
		}
	}
}
