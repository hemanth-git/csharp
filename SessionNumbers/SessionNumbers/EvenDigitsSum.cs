using System;

namespace SessionNumbers
{
	class SumEvenDigits{

		long val;
		public SumEvenDigits(long argNumber){
			this.val = argNumber;
		}
		public long calSum(){
			long i = val;
			long temp;
			long sum = 0;
			while (i != 0) {
				temp = i % 10;
				if(temp%2==0){
					sum += temp;
				}
				i=i / 10;
			}
			return sum;
		}

	}
}
