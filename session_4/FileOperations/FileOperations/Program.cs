using System;
using System.IO;
namespace FileOperations
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			string fileName = "employees.csv";
			string targetPath =  @"D:\TestFolder";

			UtilFileOperations objUtil= new UtilFileOperations(fileName,targetPath);

		}


	}
}
