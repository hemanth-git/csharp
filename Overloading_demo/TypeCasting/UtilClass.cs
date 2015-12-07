using System;

namespace TypeCasting
{
	public static class UtilClass
	{
		public static float usingTryParse(string strInput)
		{
			float fltRetVal ;
			if(float.TryParse(strInput, out fltRetVal))
			{
				return fltRetVal;
			}
			string strMessage="Invalid input number enter the correct number";
			strMessage = ReadInputFromUser (strMessage);
			return usingTryParse(strMessage);
		}

		public static int usingTryParse(string strInput ,int dummy ) // over loading the tryParse()
		{
			int fltRetVal ;
			if(int.TryParse(strInput, out fltRetVal))
			{
				return fltRetVal;
			}
			string strMessage="Invalid input number enter the correct number";
			strMessage = ReadInputFromUser (strMessage);
			return usingTryParse(strMessage,12);
		}

		public static float usingParse(string strInput)
		{
			float fltRetVal=0;
			try{
				fltRetVal = float.Parse(strInput);
			}
			catch(Exception)
			{			
				string strMessage = "Invalid input number enter the correct number";
				strMessage = ReadInputFromUser (strMessage);;
				return usingParse (strMessage);
			}
			return fltRetVal;
		}

		public static int usingParse(string strInput,int dummy)  // overloading the usingParse()
		{
			int fltRetVal=0;
			try{
				fltRetVal = int.Parse(strInput);
			}
			catch(Exception)
			{			
				string strMessage = "Invalid input number enter the correct number";
				strMessage = ReadInputFromUser (strMessage);;
				return usingParse (strMessage,123);
			}
			return fltRetVal;
		}

		public static float usingConvert(string strInput)
		{
			float fltRetVal=0;
			try{
				fltRetVal =Convert.ToSingle(strInput);
			}
			catch(Exception) {			
				string strMessage = "Invalid input number enter the correct number";
				strMessage = ReadInputFromUser (strMessage);;
				return usingConvert (strMessage);
			}
			return fltRetVal;
		}
		public static int usingConvert(string strInput, int dummy)  // overloading the usingConvert()
		{
			int intRetVal=0;
			try{
				intRetVal =Convert.ToInt32(strInput);
			}
			catch(Exception) {			
				string strMessage = "Invalid input number enter the correct number";
				strMessage = ReadInputFromUser (strMessage);;
				return usingConvert (strMessage,1);
			}
			return intRetVal;
		}

		public static float AddFloat(float fltOp1,float fltOp2)
		{
			float fltRes;
			fltRes = fltOp1 + fltOp2;
			return fltRes;
		}
		public static int AddIntegers(int intOp1,int intOp2)
		{
			int intRes;
			intRes = intOp1 + intOp2;
			return intRes;
		}
		public static string ReadInputFromUser(string strMessage)
		{
			Console.WriteLine(strMessage);
			string strInput = Console.ReadLine();
			return strInput;
		}
		public static bool IsPosiitive(int intOp1)
		{
			if(intOp1>0){
				return true;
			}
			return false;

		}
	}
}