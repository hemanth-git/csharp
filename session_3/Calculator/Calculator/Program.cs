using System;

namespace Calculator
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("*********** cal operations************\n");
			Operations.choiceOperation=Operations.ReadInputInt ("enter your choice\n 1. Integer\n2. Float");
			IOoperations iop = new IOoperations ();
			iop.recursionInput ();
		}
	}
}
