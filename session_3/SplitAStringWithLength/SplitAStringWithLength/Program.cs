using System;

namespace SplitAStringWithLength
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("enter string a");
			string strFirst=Console.ReadLine ();
			Console.WriteLine ("enter a length");
			string len=Console.ReadLine ();
			int lengthIn;
			if (int.TryParse (len, out lengthIn)) {
			}
			else{
				Console.WriteLine ("Invalid length");
			}
			if(lengthIn<=strFirst.Length){
				generateSubStrings (strFirst, lengthIn);
			}
			Console.ReadKey ();
		}
		public static void generateSubStrings(string str,int len){
			if (len <= str.Length) {
				string strTemp = str.Substring (0,len);
				Console.WriteLine (strTemp);
				str=str.Substring (len);
				generateSubStrings (str, len);
			}
		}
	}
}
