using System;

namespace Calculator
{
	public class IOoperations
	{
		private int intNum1,intNum2;
		private float fltNum1,fltNum2;
		public void TakeVariables(){
			if(Operations.choiceOperation==1){
			Operations.intOperandOne=Operations.ReadInputInt("Enter Your first Operand");
				intNum1 = Operations.intOperandOne;
				Operations.intOperandTwo=Operations.ReadInputInt("Enter Your second Operand");
				intNum2=Operations.intOperandTwo;
			}
			else{
			Operations.fltOperandOne=Operations.ReadInputFlt("Enter Your first Operand");
				fltNum1 = Operations.fltOperandOne;
				Operations.fltOperandTwo=Operations.ReadInputFlt("Enter Your second Operand");
				fltNum2 = Operations.fltOperandTwo;
			}
		}


			public void recursionInput (){
				Console.WriteLine ("Enter your choice\n");
				Console.WriteLine ("1.Sum\n2.Sub\n3.Mul\n4.Div\n5.Exit");
				string choice=Console.ReadLine();

				if (choice == "1") {
					TakeVariables ();
					if (Operations.choiceOperation == 1) {
					Console.WriteLine (Operations.Sum (intNum1,intNum2));
					} else {
					Console.WriteLine (Operations.Sum (fltNum1,fltNum2));
					}
					recursionInput ();
				} else if (choice == "2") {
					TakeVariables ();
					if (Operations.choiceOperation == 1) {
					Console.WriteLine (Operations.Sub (intNum1,intNum2));
					} else {
					Console.WriteLine (Operations.Sub (fltNum1,fltNum2));
					}
					recursionInput ();
				} else if (choice == "3") {
					TakeVariables ();
					if (Operations.choiceOperation == 1) {
					Console.WriteLine (Operations.Mul (intNum1,intNum2));
					} else {
					Console.WriteLine (Operations.Mul (fltNum1,fltNum2));
					}
					recursionInput ();
				} else if (choice == "4") {
					TakeVariables ();
					if (Operations.choiceOperation == 1) {
					Console.WriteLine (Operations.Div (intNum1,intNum2));
					} else {
					Console.WriteLine (Operations.Div (fltNum1,fltNum2));
					}
					recursionInput ();
				} else if (choice == "5") {
					Environment.Exit (-1);
				} else {
					Console.WriteLine ("In correct choice");
					recursionInput ();
				}
			}

	}
}

