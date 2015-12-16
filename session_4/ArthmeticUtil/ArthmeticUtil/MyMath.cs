using System;
using ValidationsLib;
namespace ArthmeticUtil
{
	public static class MyMath
	{
		/// <summary>
		/// Sums the integer.
		/// </summary>
		/// <param name="intOne">Int one.</param>
		/// <param name="intTwo">Int two.</param>
		public static int SumInt(string intOne, string intTwo){
			return Operate.Sum (MyValidations.convertToIntNumber (intOne), MyValidations.convertToIntNumber (intTwo));
		}
		/// <summary>
		/// Sums the float.
		/// </summary>
		/// <param name="intOne">Int one.</param>
		/// <param name="intTwo">Int two.</param>
		public static float SumFloat(string intOne, string intTwo){
			return Operate.Sum (MyValidations.convertToFltNumber (intOne), MyValidations.convertToFltNumber (intTwo));
		}
		/// <summary>
		/// Subs the integer.
		/// </summary>
		/// <param name="intOne">Int one.</param>
		/// <param name="intTwo">Int two.</param>
		public static int SubInt(string intOne, string intTwo){
			return Operate.Sub (MyValidations.convertToIntNumber (intOne), MyValidations.convertToIntNumber (intTwo));
		}
		/// <summary>
		/// Subs the float.
		/// </summary>
		/// <param name="intOne">Int one.</param>
		/// <param name="intTwo">Int two.</param>
		public static float SubFlt(string intOne, string intTwo){
			return Operate.Sub (MyValidations.convertToFltNumber (intOne), MyValidations.convertToFltNumber (intTwo));
		}
		/// <summary>
		/// Muls the integer.
		/// </summary>
		/// <param name="intOne">Int one.</param>
		/// <param name="intTwo">Int two.</param>
		public static int MulInt(string intOne, string intTwo){
			return Operate.Mul (MyValidations.convertToIntNumber (intOne), MyValidations.convertToIntNumber (intTwo));
		}
		/// <summary>
		/// Muls the float.
		/// </summary>
		/// <param name="intOne">Int one.</param>
		/// <param name="intTwo">Int two.</param>
		public static float MulFlt(string intOne, string intTwo){
			return Operate.Mul (MyValidations.convertToFltNumber (intOne), MyValidations.convertToFltNumber (intTwo));
		}
		/// <summary>
		/// Divs the integer.
		/// </summary>
		/// <param name="intOne">Int one.</param>
		/// <param name="intTwo">Int two.</param>
		public static float DivInt(string intOne, string intTwo){
			return Operate.Div (MyValidations.convertToIntNumber (intOne), MyValidations.convertToIntNumber (intTwo));
		}
		/// <summary>
		/// Divs the float.
		/// </summary>
		/// <param name="intOne">Int one.</param>
		/// <param name="intTwo">Int two.</param>
		public static float DivFlt(string intOne, string intTwo){
			return Operate.Div (MyValidations.convertToFltNumber (intOne), MyValidations.convertToFltNumber (intTwo));
		}
	}
}

