using System;

namespace TypeCasting
{
	public class AddingFloatNumbers
	{
		public AddingFloatNumbers ()
		{
			string strOp1, strOp2;
			float fltOp1, fltOp2, fltResult;
			Console.WriteLine ("**** using try parse ***********");
			strOp1=UtilClass.ReadInputFromUser("Enter first number");
			fltOp1 = UtilClass.usingTryParse (strOp1);
			strOp2= UtilClass.ReadInputFromUser("Enter second Number");
			fltOp2= UtilClass.usingTryParse (strOp2);
			fltResult = UtilClass.AddFloat (fltOp1, fltOp2);
			Console.WriteLine("Sum of two int number using TryParse is {0}",fltResult);

			Console.WriteLine ("**** using  parse ***********");
			strOp1=UtilClass.ReadInputFromUser("Enter first number");
			fltOp1 =UtilClass. usingParse(strOp1);
			strOp2= UtilClass.ReadInputFromUser("Enter second Number");
			fltOp2 = UtilClass.usingParse(strOp2);
			fltResult = UtilClass.AddFloat (fltOp1, fltOp2);
			Console.WriteLine("Sum of two int number using Parse is {0}",fltResult); 

			Console.WriteLine ("**** using convert ***********");
			strOp1=UtilClass.ReadInputFromUser("Enter first number");
			fltOp1 = UtilClass.usingConvert(strOp1);
			strOp2= UtilClass.ReadInputFromUser("Enter second Number");
			fltOp2 = UtilClass.usingConvert(strOp2);
			fltResult =UtilClass. AddFloat (fltOp1, fltOp2);
			Console.WriteLine("Sum of two int number using Parse is {0}",fltResult); 
			System.Console.WriteLine("Enter any key to Exit!");
			Console.ReadKey();
		}
	}
}

