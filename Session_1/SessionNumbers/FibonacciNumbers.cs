using System;
namespace SessionNumbers
{
class FibonacciNumbers{

		int val;
		public FibonacciNumbers(int val){
			this.val = val;
		}
		public void generateFibSeries(){
		for (int i = 0; i < val; i++) {
				Console.WriteLine(fib (i));
		}
		}
		public int fib(int n)
		{
			if (n == 0) {
				return 0;
			} else if (n == 1) {
				return 1;
			} else {
				return (fib (n - 1) + fib (n - 2));
			} 
		} 
}

}
