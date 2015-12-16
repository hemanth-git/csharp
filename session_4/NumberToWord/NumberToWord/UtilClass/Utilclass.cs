using System;

namespace NumberToWord
{
	public class Utilclass
	{
		public void pw(int n,String ch)
		{
			string[]  ones={" "," one"," two"," three"," four"," five"," six"," seven"," eight"," Nine"," ten"," eleven"," twelve"," thirteen"," fourteen","fifteen"," sixteen"," seventeen"," eighteen"," nineteen"};

			string[] tens={" "," "," twenty"," thirty"," forty"," fifty"," sixty","seventy"," eighty"," ninety"};

			if(n>19) 
			{ 
				Console.Write(tens[n/10]+" "+ones[n%10]);
			}
			else {
				Console.Write (ones[n]);
			}
			if(n>0){
				Console.Write (ch);
			}
		}
		public string readInput(string message){
			Console.WriteLine (message);
			string choice=Console.ReadLine ();
			return choice;
		}
		public int convertToIntNumber(string strNum){
			int intNUm;
			if(int.TryParse(strNum,out intNUm)){
				return intNUm;
			}
			return -1;
		}
	}
}

