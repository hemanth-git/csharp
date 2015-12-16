
using System;


namespace WindowCalc.Utils
{

	public static class OperationsArt
	{
		public static float OperandOne { get; set; }
		public static float OperandTwo { get; set; }
		public static string Operator { get; set; }
		
		public static void checkOpeator(string op){
			
		}
		public static void setOperandOne(string operOne){
			OperationsArt.OperandOne=float.Parse(operOne);
		}
		public static void setOperandTwo(string operTwo){
			OperationsArt.OperandTwo=float.Parse(operTwo);
		}
		public static void performOperation(){
			
			float strRetValue=0;
            switch (OperationsArt.Operator)
            {
                case "+":
            		strRetValue = MyMathUtil.Sum(OperationsArt.OperandOne,OperationsArt.OperandTwo);
            		
                    break;
                case "-":
                    strRetValue = MyMathUtil.Sub(OperationsArt.OperandOne,OperationsArt.OperandTwo);
                    break;
                case "*":
                    strRetValue = MyMathUtil.Mul(OperationsArt.OperandOne,OperationsArt.OperandTwo);
                    break;
                case "/":
                    strRetValue = MyMathUtil.Div(OperationsArt.OperandOne,OperationsArt.OperandTwo);
                    break;
                default:
                    break;
            }
            OperationsArt.OperandOne=strRetValue;
            
		}
	}
}
