using System;

namespace TypeCasting
{
	public class AddingIntegers
	{
		public AddingIntegers ()
		{
			string strOp1, strOp2;
			int intOp1, intOp2, intResult;

			Console.WriteLine ("**** using try parse ***********");
			strOp1=UtilClass.ReadInputFromUser("Enter first number");
			intOp1 = UtilClass.usingTryParse (strOp1,1);
			strOp2= UtilClass.ReadInputFromUser("Enter second Number");
			intOp2= UtilClass.usingTryParse (strOp2,1);
			intResult = UtilClass.AddIntegers (intOp1, intOp2);
			Console.WriteLine("Sum of two int number using TryParse is {0}",intResult);

			Console.WriteLine ("**** using  parse ***********");
			strOp1=UtilClass.ReadInputFromUser("Enter first number");
			intOp1 =UtilClass. usingParse(strOp1,1);
			strOp2= UtilClass.ReadInputFromUser("Enter second Number");
			intOp2 = UtilClass.usingParse(strOp2,1);
			intResult = UtilClass.AddIntegers (intOp1, intOp2);
			Console.WriteLine("Sum of two int number using Parse is {0}",intResult); 

			Console.WriteLine ("**** using convert ***********");
			strOp1=UtilClass.ReadInputFromUser("Enter first number");
			intOp1 = UtilClass.usingConvert(strOp1,1);
			strOp2= UtilClass.ReadInputFromUser("Enter second Number");
			intOp2 = UtilClass.usingConvert(strOp2,1);
			intResult =UtilClass. AddIntegers (intOp1, intOp2);
			Console.WriteLine("Sum of two int number using Parse is {0}",intResult); 
			System.Console.WriteLine("Enter any key to Exit!");
			Console.ReadKey();
		}
	}
}

