using System;

namespace TypeCasting
{
	public class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("********** Adding integer values ************");
			AddingIntegers addInt = new AddingIntegers ();

			Console.WriteLine ("********** Adding Float values ************");
			AddingFloatNumbers addFloat = new AddingFloatNumbers ();
			Console.WriteLine ("********** Finding the sign of number ************");
			SignNumberDemo signDemo = new SignNumberDemo ();
		}
	}
}
