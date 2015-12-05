using System;

namespace SessionNumbers
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// sum of even and odd digits
			Console.WriteLine ("Enter a number to Cal Sum of Odd and Even numbers");
			long inputNumber = Convert.ToInt64(Console.ReadLine());
			SumOddDigits odd = new SumOddDigits (inputNumber);
			long oddSum = odd.calSumOdd ();
			Console.WriteLine("Odd sum is: {0}",oddSum);
			SumEvenDigits even = new SumEvenDigits (inputNumber);
			long evenSum = even.calSum ();
			Console.WriteLine("Even sum is: {0}",evenSum);

			// fibonacci series
			Console.WriteLine ("Enter a number to generate a fibonacci series");
			int inputNvalue = Convert.ToInt32(Console.ReadLine());
			FibonacciNumbers fib = new FibonacciNumbers (inputNvalue);
			fib.generateFibSeries ();

			//isPrime number
			Console.WriteLine ("Enter a number to check isPrime");
			int inputPrimeVal = Convert.ToInt32(Console.ReadLine());
			PrimeNumber primeNum = new PrimeNumber (inputPrimeVal);
			if (primeNum.isPrime ()) {
				Console.WriteLine ("{0} : Number is a Prime Num",inputPrimeVal);
			} else {
				Console.WriteLine ("{0} : Number is not a Prime Num",inputPrimeVal);
			}
			Console.ReadLine ();

		}
	}
}
