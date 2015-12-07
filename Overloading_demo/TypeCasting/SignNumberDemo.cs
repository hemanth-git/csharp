using System;

namespace TypeCasting
{
	public class SignNumberDemo
	{
		public SignNumberDemo ()
		{
			string strOp;
			int intOp;
			bool boolResult;
		
			Console.WriteLine ("*....Using TryParse.....*");
			strOp=UtilClass.ReadInputFromUser("Enter the number to check wether it is posititive or not:");
			intOp =UtilClass.usingTryParse (strOp,1);				
			boolResult = UtilClass.IsPosiitive(intOp);
			if (boolResult) {
				Console.WriteLine ("The entered Number is positive");
			} else {
				Console.WriteLine ("The entered Number is negative");
			}

			Console.WriteLine ("*....Using Parse.....*");
			strOp=UtilClass.ReadInputFromUser("Enter the number to check wether it is posititive or not:");
			intOp =UtilClass. usingParse(strOp,1);
			boolResult = UtilClass.IsPosiitive(intOp);
			if (boolResult) {
				Console.WriteLine ("The entered Number is positive");
			} else {
				Console.WriteLine ("The entered Number is negative");
			}

			Console.WriteLine ("*....Using Convert.....*");
			strOp=UtilClass.ReadInputFromUser("Enter the number to check weather it is positive or not:");
			intOp =UtilClass. usingConvert(strOp,1);
			boolResult = UtilClass.IsPosiitive(intOp);
			if (boolResult) {
				Console.WriteLine ("The entered Number is positive");
			} else {
				Console.WriteLine ("The entered Number is negative");
			}
			System.Console.WriteLine("Enter any key to Exit!");
			Console.ReadKey();

		}			
	}    			
}		
