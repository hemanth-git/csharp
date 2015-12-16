using System;
using ExceptionLogCat;
namespace Calculator
{
	public static class Operations
	{
		public static int choiceOperation{
			get;
			set;
		}
		public static int intOperandOne {
			get;
			set;
		}
		public static int intOperandTwo {
			get;
			set;
		}
		public static float fltOperandOne {
			get;
			set;
		}
		public static float fltOperandTwo {
			get;
			set;
		}
			
		public static float Sum(float var1, float var2){
			return(var1 + var2);
		}
		public static float Sub(float var1, float var2){
			return(var1-var2);
		}
		public static float Mul(float var1, float var2){
			return(var1*var2); 
		}
		public static float Div(float var1, float var2){
			try{
				return(var1/var2);
			}
			catch(Exception e){
				LogCat.LogCatMsg (e.Message);// log cat to write exception to a file will be available in bin folder
				return 0;
			}
		}


		public static int Sum(int var1, int var2){
			return (var1 + var2);
		}
		public static int Sub(int var1, int var2){
			return(var1-var2);
		}
		public static int Mul(int var1, int var2){
			return(var1*var2);
		}
		public static float Div(int var1, int var2){
			try{
				return(var1/var2);
			}
			catch(Exception e){
				LogCat.LogCatMsg (e.Message);
				return 0;
			}

		}


		public static int ReadInputInt(string strMsg){
			Console.WriteLine (strMsg);
			string tempNum=Console.ReadLine ();
			int returnNum=convertToIntNumber (tempNum);
			return returnNum;
		}
		public static int convertToIntNumber(string strNum){
			int fltNum;
			if(int.TryParse(strNum,out fltNum)){
				return fltNum;
			}
			return ReadInputInt ("re enter a value");
		}

		public static float ReadInputFlt(string strMsg){
			Console.WriteLine (strMsg);
			string tempNum=Console.ReadLine ();
			float returnNum=convertToFltNumber (tempNum);
			return returnNum;
		}
		public static float convertToFltNumber(string strNum){
			float fltNum;
			if(float.TryParse(strNum,out fltNum)){
				return fltNum;
			}
			return ReadInputFlt ("re enter a value");
		}

	}
}