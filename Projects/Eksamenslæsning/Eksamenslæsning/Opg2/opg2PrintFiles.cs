using System;
using System.IO;

namespace Eksamenslæsning
{
	public class opg2PrintFiles
	{
		public opg2PrintFiles()
		{
		}

		public void Directory()
		{
			DirectoryInfo root = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
			Console.WriteLine("Files in the folder \"MyDocuments\"");

			foreach (FileInfo file in root.GetFiles())
			{
				Console.WriteLine($"{file} fylder {file.Length} bytes");
			}

			foreach (DirectoryInfo directory in root.GetDirectories())
			{
				try
				{
					int numberOfFilesAndFolders = directory.GetDirectories().Length + directory.GetFiles().Length;
					Console.WriteLine($"Folders: {directory.Name} Total files: {numberOfFilesAndFolders}");
				}
				catch (UnauthorizedAccessException e)
				{
					Console.WriteLine(e.Message);
				}
			}
		}
	}
}
