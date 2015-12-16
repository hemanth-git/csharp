using System;
using System.Configuration;
namespace NumberToWord
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Utilclass objUtclass = new Utilclass ();
			int intInputNumber = objUtclass.convertToIntNumber (objUtclass.readInput (ConfigurationManager.AppSettings.Get("welcome")));

			if (intInputNumber <= 0) {
				Console.WriteLine (ConfigurationManager.AppSettings.Get("inputWarning"));
			}
			else
			{
				objUtclass.pw(((intInputNumber/100000)%100)," lakh , ");
				objUtclass.pw(((intInputNumber/1000)%100)," thousand , ");
				objUtclass.pw(((intInputNumber/100)%10)," hundred , ");
				objUtclass.pw((intInputNumber%100)," ");
			}
			Console.ReadKey ();
		}
	}
}
