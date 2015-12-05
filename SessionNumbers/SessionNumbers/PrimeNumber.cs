using System;
namespace SessionNumbers
{
	class PrimeNumber{
		int val;
		public PrimeNumber(int val){
			this.val = val;
		}
		public bool isPrime(){
			if (val == 2) {
				return true;
			}
			if (val % 2 == 0) {
				return false;
			}
			for (int i = 3; i <= Math.Sqrt (val); i += 2)
				if (val % i == 0) {
					return false;
				}
			return true;
		}
	}

}