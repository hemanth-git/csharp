using System;
using System.IO;
using System.Text;
namespace ExceptionLogCat
{
	public static class  LogCat
	{
		public  static string FileName {
			get;
			set;
		}
		public static string TargetPath {
			get;
			set;
		}
		public static string _destFile;
		/// <summary>
		/// Logs the exception  message to the LogCat.txt file in Bin.
		/// </summary>
		/// <param name="messageLog">Message log.</param>
		public static void LogCatMsg (string messageLog)
		{

			string CurrentPath = System.IO.Directory.GetCurrentDirectory();
			LogCat.FileName = "Logcat.txt";
			DirectoryInfo objDi = new DirectoryInfo(CurrentPath);
			LogCat.TargetPath = objDi.Parent.FullName;
			LogCat._destFile = Path.Combine (TargetPath,FileName);
			FileInfo objFi = new FileInfo (_destFile);	
			string strEntry;
			try {
				if (!objDi.Exists) {
					objDi.Create();
				} 
				strEntry = messageLog;
				using (StreamWriter sw = objFi.AppendText()) 
				{
					sw.WriteLine(strEntry);
				}
			} catch (Exception ex) {
				Console.WriteLine (ex.Message);
			}
			Console.ReadKey ();
		}

	}
}

