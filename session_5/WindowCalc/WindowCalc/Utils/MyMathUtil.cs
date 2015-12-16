
using System;

namespace WindowCalc.Utils
{

	public static class MyMathUtil
	{
		public static int Sum(int intOne,int intTwo){
			return intOne + intTwo;
		}
		public static float Sum(float intOne,float intTwo){
			return intOne + intTwo;
		}
		public static int Sub(int intOne,int intTwo){
			return intOne - intTwo;
		}
		public static float Sub(float intOne,float intTwo){
			return intOne - intTwo;
		}
		public static int Mul(int intOne,int intTwo){
			return intOne * intTwo;
		}
		public static float Mul(float intOne,float intTwo){
			return intOne * intTwo;
		}
		public static float Div(int intOne,int intTwo){
			try {
				return intOne/intTwo;
			} catch (Exception ex) {
				throw ex;
			}
		}
		public static float Div(float intOne,float intTwo){
			try {
				return intOne/intTwo;
			} catch (Exception ex) {
				throw ex;
			}
		}
	}
}
