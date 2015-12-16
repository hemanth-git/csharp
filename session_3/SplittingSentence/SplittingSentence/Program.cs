using System;

namespace SplittingSentence
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("enter any sentence");
			string sentence=Console.ReadLine ();
			string[] strArr = sentence.Split (new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);// to remove empty entries

			for (int i = 0; i < strArr.Length; i++) {
				Console.Write ("{0} ",i);
				Console.WriteLine (strArr[i]);
			}
			Console.ReadKey ();
		}
	}
}

