using System;
using System.IO;
using System.Text;
namespace FileOperations
{
	public class UtilFileOperations
	{
		public string FileName {
			get;
			set;
		}
		public string TargetPath {
			get;
			set;
		}

		public string _destFile;
		public UtilFileOperations(string fileName,string targetPath){
			this.FileName = fileName;
			this.TargetPath = targetPath;
			this._destFile= Path.Combine (this.TargetPath,this.FileName);
			DirectoryInfo objDi = new DirectoryInfo(this.TargetPath);
			FileInfo objFi = new FileInfo (_destFile);	
			string strEntry;
			try {


				if (!objDi.Exists) {
					objDi.Create();
				} 
				strEntry = enterDetails ();
				using (StreamWriter sw = objFi.AppendText()) 
				{
					sw.WriteLine(strEntry);
				}


				StringBuilder strReadFileData= new StringBuilder();
				string temp;
				using (StreamReader sr = objFi.OpenText()){
					while ((temp=sr.ReadLine())!=null) {
						strReadFileData.AppendLine(temp);
					}
				}
				Console.WriteLine (strReadFileData.ToString());
			} catch (Exception ex) {
				Console.WriteLine (ex.Message);
			}
			Console.ReadKey ();
		}

		public string enterDetails(){
			StringBuilder sb = new StringBuilder ();
			Console.WriteLine ("enter name:");
			sb.Append(Console.ReadLine ()).Append(",");
			Console.WriteLine ("enter designation:");
			sb.Append(Console.ReadLine ()).Append(",");
			Console.WriteLine ("enter salary:");
			sb.Append(Console.ReadLine ()).Append(",");
			Console.WriteLine ("enter phone:");
			sb.Append(Console.ReadLine ());
			return sb.ToString ();
		}

	}
}

