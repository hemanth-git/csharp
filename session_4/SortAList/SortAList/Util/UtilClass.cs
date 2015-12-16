using System;
using System.Collections.Generic;
using System.Configuration;
namespace SortAList
{
	public class UtilClass
	{

		public List<string> listNames {
			get;
			set;
		}
		public string[] arrayNames {
			get;
			set;
		}

		public string readInput(string message){
			Console.WriteLine (message);
			string choice=Console.ReadLine ();
			return choice;
		}
		public void enterChoices(){
			checkChoice(readInput(ConfigurationManager.AppSettings.Get("messageList")));
		}
		public void checkChoice(string choice){
			if (choice == "1") {
				addEntryToArray ();
				enterChoices ();
			} else if (choice == "2") {
				displayList ();
				enterChoices();
			} else if (choice == "3") {
				Environment.Exit (-1);
			} else {
				Console.WriteLine (ConfigurationManager.AppSettings.Get("message"));
				enterChoices();
			}
		}
		public void displayList(){
			arrayNames = listNames.ToArray ();
			Array.Sort(arrayNames);
			if(arrayNames.Length>0){
				for (int i = 0; i < arrayNames.Length; i++) {
					Console.WriteLine ("{0}. {1}",i+1,arrayNames[i]);
				}
			} else {
				Console.WriteLine (ConfigurationManager.AppSettings.Get("messageWarining"));
			}
		}
		string strEntryName= string.Empty;
		public void addEntryToArray (){
			strEntryName=readInput (ConfigurationManager.AppSettings.Get("messageDisplay"));
			try {
				strEntryName=(char.ToUpper(strEntryName[0])) + strEntryName.Substring(1);
				listNames.Add (strEntryName);				
			} catch (Exception ex) {
				Console.WriteLine (ex.Message);
			}
		}

		public int convertToIntNumber(string strNum){
			int intNUm;
			if(int.TryParse(strNum,out intNUm)){
				return intNUm;
			}
			return -1;
		}

	}
}

