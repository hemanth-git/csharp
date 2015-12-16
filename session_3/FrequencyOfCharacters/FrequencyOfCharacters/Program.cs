using System;

namespace FrequencyOfCharacters
{
	class MainClass
	{
		public static int _max=0, _min=100;
		public static char _charMax,_charMin;
		public static void Main (string[] args)
		{
			Console.WriteLine ("enter a string to check the maximum frequency of chracters:");
			string strInput=Console.ReadLine ();
			checkMaxmumFreq (strInput);
		}
		public static void checkMaxmumFreq (string strInput){
			var charArr = strInput.ToCharArray ();
			Array.Sort (charArr);
			try{
				checkFirst (charArr,0,0,charArr[0]);
				Console.WriteLine ("Maximum occurences are : {0} is {1} times",_charMax,_max);
				Console.WriteLine ("Minimum occurences are : {0} is {1} times",_charMin,_min);
			}
			catch(Exception e){
				Console.WriteLine (e.Message);
			}
			Console.ReadKey ();
		}
		public static void checkFirst(char[] charArr,int  i,int counter,char temp){

			if (i <= charArr.Length ) {
				if (i<charArr.Length && temp == charArr [i]) {
					counter += 1;

				}else {

					validateMax (temp,counter);
					validateMin (temp,counter);
					counter = 1;
					if (i < charArr.Length) {
						temp = charArr [i];
					}
				}
				i++;
				checkFirst (charArr, i,counter,temp);
			}
		}
		public static void validateMax (char tempMax,int counter){
			if (_max < counter) {
				_max = counter;
				_charMax = tempMax;
			}

		}
		public static void validateMin (char tempMin,int counter){
			if (_min > counter) {
				_min = counter;
				_charMin = tempMin;
			}
		}
	}
}
