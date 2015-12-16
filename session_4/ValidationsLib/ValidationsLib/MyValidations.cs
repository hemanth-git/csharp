using System;
using System.Configuration;
namespace ValidationsLib
{
	public static class MyValidations
	{
		/// <summary>
		/// Validates the string if null or empty or only white spaces
		/// </summary>
		/// <returns><c>true</c>, if string was validated, <c>false</c> otherwise.</returns>
		/// <param name="strInput">String input.</param>

		public static bool ValidateString(string strInput){
			if (string.IsNullOrEmpty (strInput) || string.IsNullOrWhiteSpace (strInput)) {
				return false;
			} else {
				return true;
			}
		}

		/// <summary>
		/// Validates to integer.
		/// </summary>
		/// <param name="strInt">String int.</param>
		public static void ValidateToInteger(string strInt){
			convertToIntNumber (strInt);
		}

		/// <summary>
		/// Validates to integer.
		/// </summary>
		/// <param name="strInt">String int.</param>
		public static void ValidateToFloat(string strInt){
			convertToFltNumber (strInt);
		}

		/// <summary>
		/// Converts to int from string.
		/// </summary>
		/// <returns>The to int number.</returns>
		/// <param name="strNum">String number.</param>
		public static int convertToIntNumber(string strNum){
			int intNum;
			if(int.TryParse(strNum,out intNum)){
				return intNum;
			}
			return errorParseInt(ConfigurationManager.AppSettings.Get("intError"));
		}

		/// <summary>
		/// Converts to float from string.
		/// </summary>
		/// <returns>The to flt number.</returns>
		/// <param name="strNum">String number.</param>
		public static float convertToFltNumber(string strNum){
			float fltNum;
			if(float.TryParse(strNum,out fltNum)){
				return fltNum;
			}
			return errorParseFlt(ConfigurationManager.AppSettings.Get("floatError"));
		}

		/// <summary>
		/// Errors the parse int.
		/// </summary>
		/// <returns>The parse int.</returns>
		/// <param name="message">Message.</param>
		private static int errorParseInt(string message){
			Console.WriteLine (message);
			string tempNum=Console.ReadLine ();
			int returnNum=convertToIntNumber (tempNum);
			return returnNum;
		}

		/// <summary>
		/// Errors the parse float.
		/// </summary>
		/// <returns>The parse flt.</returns>
		/// <param name="message">Message.</param>
		private static float errorParseFlt(string message){
			Console.WriteLine (message);
			string tempNum=Console.ReadLine ();
			float returnNum=convertToIntNumber (tempNum);
			return returnNum;
		}

	}
}

