using System;

namespace StringOccurences
{
	class MainClass
	{
		public static int count=0;

		public static void Main (string[] args)
		{
			Console.WriteLine ("enter string 1");
			string strFirst=Console.ReadLine ();
			Console.WriteLine ("enter string 2");
			string strSecond=Console.ReadLine ();
			checkAllCharacters (strFirst.ToCharArray(),strSecond.ToCharArray(),0,0);
			if (strSecond.IndexOf (strFirst) != -1) {

				checkRepeatiton (strFirst, strSecond);
				Console.WriteLine (count);
			} else {
				Console.WriteLine ("repetition not found");
			}
			Console.ReadKey ();
		}

		public static void checkRepeatiton (string strFirst,string strSecond){

			int index = strSecond.IndexOf (strFirst);
			if (index != -1) {
				count++;
				strSecond=strSecond.Substring (index+strFirst.Length);
				checkRepeatiton (strFirst,strSecond);
			}
		}
		public static void checkAllCharacters (char[] str1, char[] str2,int i,int j	){
			if (i < str1.Length && Array.IndexOf(str2,str1[i])!=-1){
				i++;
				checkAllCharacters (str1, str2, i, j);
			}

		}
	}
}
