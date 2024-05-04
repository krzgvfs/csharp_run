using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace HelloWordl	// Conjunto de classes
{	
	internal class Program	// Classe principal
	{	
		static void Main(string[] args)	// Método principal
		{
			ExecutarComandoPowerShell();
		}


		public static void ExecutarComandoPowerShell()
		{
			string caminhoDoScript = "C:\\Users\\resux94\\source\\repos\\HelloWordl\\HelloWordl\\Scripts\\searchbar.ps1";

			var starInfo = new ProcessStartInfo {
				FileName = "powershell.exe",
				Arguments = $"-NoProfile -ExecutionPolicy Bypass -File \"{caminhoDoScript}\"",
				UseShellExecute = false
			};
			Process.Start(starInfo);
		}
	}
}
