namespace DampLoader
{
	// Token: 0x02000009 RID: 9
	public partial class SpeedFN : global::System.Windows.Forms.Form
	{
		// Token: 0x0600001C RID: 28 RVA: 0x00002416 File Offset: 0x00000616
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002438 File Offset: 0x00000638
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.name = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.dragger = new global::Siticone.UI.WinForms.SiticoneGradientPanel();
			this.minimize = new global::Siticone.UI.WinForms.SiticoneCircleButton();
			this.close = new global::Siticone.UI.WinForms.SiticoneCircleButton();
			this.fullscreen = new global::Siticone.UI.WinForms.SiticoneCircleButton();
			this.HWID = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.siticoneLabel4 = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.siticoneLabel3 = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.siticoneLabel2 = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.siticoneLabel1 = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.gunaButton1 = new global::Guna.UI.WinForms.GunaButton();
			this.gunaButton2 = new global::Guna.UI.WinForms.GunaButton();
			this.gunaButton3 = new global::Guna.UI.WinForms.GunaButton();
			this.siticoneLabel6 = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.siticoneLabel7 = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.siticoneLabel8 = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.siticoneDragControl1 = new global::Siticone.UI.WinForms.SiticoneDragControl(this.components);
			this.dragger.SuspendLayout();
			base.SuspendLayout();
			this.name.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.name.BackColor = global::System.Drawing.Color.Transparent;
			this.name.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 15f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.name.ForeColor = global::System.Drawing.Color.WhiteSmoke;
			this.name.Location = new global::System.Drawing.Point(161, 12);
			this.name.Name = "name";
			this.name.Size = new global::System.Drawing.Size(87, 27);
			this.name.TabIndex = 0;
			this.name.Text = "SpeedFN";
			this.dragger.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.dragger.Controls.Add(this.minimize);
			this.dragger.Controls.Add(this.name);
			this.dragger.Controls.Add(this.close);
			this.dragger.Controls.Add(this.fullscreen);
			this.dragger.Location = new global::System.Drawing.Point(1, 1);
			this.dragger.Name = "dragger";
			this.dragger.ShadowDecoration.Parent = this.dragger;
			this.dragger.Size = new global::System.Drawing.Size(403, 45);
			this.dragger.TabIndex = 1;
			this.minimize.CheckedState.Parent = this.minimize;
			this.minimize.CustomImages.Parent = this.minimize;
			this.minimize.FillColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.minimize.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.minimize.ForeColor = global::System.Drawing.Color.White;
			this.minimize.HoveredState.Parent = this.minimize;
			this.minimize.Location = new global::System.Drawing.Point(335, 11);
			this.minimize.Name = "minimize";
			this.minimize.ShadowDecoration.Mode = global::Siticone.UI.WinForms.Enums.ShadowMode.Circle;
			this.minimize.ShadowDecoration.Parent = this.minimize;
			this.minimize.Size = new global::System.Drawing.Size(15, 15);
			this.minimize.TabIndex = 5;
			this.minimize.Click += new global::System.EventHandler(this.minimize_Click);
			this.close.CheckedState.Parent = this.close;
			this.close.CustomImages.Parent = this.close;
			this.close.FillColor = global::System.Drawing.Color.Red;
			this.close.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.close.ForeColor = global::System.Drawing.Color.White;
			this.close.HoveredState.Parent = this.close;
			this.close.Location = new global::System.Drawing.Point(377, 11);
			this.close.Name = "close";
			this.close.ShadowDecoration.Mode = global::Siticone.UI.WinForms.Enums.ShadowMode.Circle;
			this.close.ShadowDecoration.Parent = this.close;
			this.close.Size = new global::System.Drawing.Size(15, 15);
			this.close.TabIndex = 3;
			this.close.Click += new global::System.EventHandler(this.close_Click_1);
			this.fullscreen.CheckedState.Parent = this.fullscreen;
			this.fullscreen.CustomImages.Parent = this.fullscreen;
			this.fullscreen.FillColor = global::System.Drawing.Color.FromArgb(255, 128, 0);
			this.fullscreen.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.fullscreen.ForeColor = global::System.Drawing.Color.White;
			this.fullscreen.HoveredState.Parent = this.fullscreen;
			this.fullscreen.ImageSize = new global::System.Drawing.Size(15, 15);
			this.fullscreen.Location = new global::System.Drawing.Point(356, 11);
			this.fullscreen.Name = "fullscreen";
			this.fullscreen.ShadowDecoration.Mode = global::Siticone.UI.WinForms.Enums.ShadowMode.Circle;
			this.fullscreen.ShadowDecoration.Parent = this.fullscreen;
			this.fullscreen.Size = new global::System.Drawing.Size(15, 15);
			this.fullscreen.TabIndex = 4;
			this.fullscreen.Click += new global::System.EventHandler(this.fullscreen_Click);
			this.HWID.BackColor = global::System.Drawing.Color.Transparent;
			this.HWID.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 13f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.HWID.ForeColor = global::System.Drawing.Color.WhiteSmoke;
			this.HWID.Location = new global::System.Drawing.Point(142, 95);
			this.HWID.Name = "HWID";
			this.HWID.Size = new global::System.Drawing.Size(45, 22);
			this.HWID.TabIndex = 13;
			this.HWID.Text = "-------";
			this.HWID.Click += new global::System.EventHandler(this.HWID_Click);
			this.siticoneLabel4.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneLabel4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 13f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneLabel4.ForeColor = global::System.Drawing.Color.WhiteSmoke;
			this.siticoneLabel4.Location = new global::System.Drawing.Point(32, 151);
			this.siticoneLabel4.Name = "siticoneLabel4";
			this.siticoneLabel4.Size = new global::System.Drawing.Size(341, 22);
			this.siticoneLabel4.TabIndex = 12;
			this.siticoneLabel4.Text = "Supported Windows 10 versions: 1809 - 1909";
			this.siticoneLabel3.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneLabel3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 13f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneLabel3.ForeColor = global::System.Drawing.Color.WhiteSmoke;
			this.siticoneLabel3.Location = new global::System.Drawing.Point(103, 123);
			this.siticoneLabel3.Name = "siticoneLabel3";
			this.siticoneLabel3.Size = new global::System.Drawing.Size(212, 22);
			this.siticoneLabel3.TabIndex = 11;
			this.siticoneLabel3.Text = "Spoof before, inject in-game";
			this.siticoneLabel2.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneLabel2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 13f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneLabel2.ForeColor = global::System.Drawing.Color.WhiteSmoke;
			this.siticoneLabel2.Location = new global::System.Drawing.Point(82, 95);
			this.siticoneLabel2.Name = "siticoneLabel2";
			this.siticoneLabel2.Size = new global::System.Drawing.Size(54, 22);
			this.siticoneLabel2.TabIndex = 10;
			this.siticoneLabel2.Text = "HWID:";
			this.siticoneLabel1.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneLabel1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 13f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneLabel1.ForeColor = global::System.Drawing.Color.WhiteSmoke;
			this.siticoneLabel1.Location = new global::System.Drawing.Point(173, 61);
			this.siticoneLabel1.Name = "siticoneLabel1";
			this.siticoneLabel1.Size = new global::System.Drawing.Size(62, 22);
			this.siticoneLabel1.TabIndex = 9;
			this.siticoneLabel1.Text = "Discord";
			this.siticoneLabel1.Click += new global::System.EventHandler(this.siticoneLabel1_Click);
			this.gunaButton1.AnimationHoverSpeed = 0.07f;
			this.gunaButton1.AnimationSpeed = 0.03f;
			this.gunaButton1.BaseColor = global::System.Drawing.Color.FromArgb(100, 88, 255);
			this.gunaButton1.BorderColor = global::System.Drawing.Color.Black;
			this.gunaButton1.DialogResult = global::System.Windows.Forms.DialogResult.None;
			this.gunaButton1.FocusedColor = global::System.Drawing.Color.Empty;
			this.gunaButton1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.gunaButton1.ForeColor = global::System.Drawing.Color.White;
			this.gunaButton1.Image = null;
			this.gunaButton1.ImageSize = new global::System.Drawing.Size(20, 20);
			this.gunaButton1.Location = new global::System.Drawing.Point(32, 198);
			this.gunaButton1.Name = "gunaButton1";
			this.gunaButton1.OnHoverBaseColor = global::System.Drawing.Color.FromArgb(151, 143, 255);
			this.gunaButton1.OnHoverBorderColor = global::System.Drawing.Color.Black;
			this.gunaButton1.OnHoverForeColor = global::System.Drawing.Color.White;
			this.gunaButton1.OnHoverImage = null;
			this.gunaButton1.OnPressedColor = global::System.Drawing.Color.Black;
			this.gunaButton1.Size = new global::System.Drawing.Size(93, 30);
			this.gunaButton1.TabIndex = 14;
			this.gunaButton1.Click += new global::System.EventHandler(this.gunaButton1_Click);
			this.gunaButton2.AnimationHoverSpeed = 0.07f;
			this.gunaButton2.AnimationSpeed = 0.03f;
			this.gunaButton2.BaseColor = global::System.Drawing.Color.FromArgb(100, 88, 255);
			this.gunaButton2.BorderColor = global::System.Drawing.Color.Black;
			this.gunaButton2.DialogResult = global::System.Windows.Forms.DialogResult.None;
			this.gunaButton2.FocusedColor = global::System.Drawing.Color.Empty;
			this.gunaButton2.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.gunaButton2.ForeColor = global::System.Drawing.Color.White;
			this.gunaButton2.Image = null;
			this.gunaButton2.ImageSize = new global::System.Drawing.Size(20, 20);
			this.gunaButton2.Location = new global::System.Drawing.Point(160, 198);
			this.gunaButton2.Name = "gunaButton2";
			this.gunaButton2.OnHoverBaseColor = global::System.Drawing.Color.FromArgb(151, 143, 255);
			this.gunaButton2.OnHoverBorderColor = global::System.Drawing.Color.Black;
			this.gunaButton2.OnHoverForeColor = global::System.Drawing.Color.White;
			this.gunaButton2.OnHoverImage = null;
			this.gunaButton2.OnPressedColor = global::System.Drawing.Color.Black;
			this.gunaButton2.Size = new global::System.Drawing.Size(93, 30);
			this.gunaButton2.TabIndex = 15;
			this.gunaButton2.Click += new global::System.EventHandler(this.gunaButton2_Click);
			this.gunaButton3.AnimationHoverSpeed = 0.07f;
			this.gunaButton3.AnimationSpeed = 0.03f;
			this.gunaButton3.BaseColor = global::System.Drawing.Color.FromArgb(100, 88, 255);
			this.gunaButton3.BorderColor = global::System.Drawing.Color.Black;
			this.gunaButton3.DialogResult = global::System.Windows.Forms.DialogResult.None;
			this.gunaButton3.FocusedColor = global::System.Drawing.Color.Empty;
			this.gunaButton3.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.gunaButton3.ForeColor = global::System.Drawing.Color.White;
			this.gunaButton3.Image = null;
			this.gunaButton3.ImageSize = new global::System.Drawing.Size(20, 20);
			this.gunaButton3.Location = new global::System.Drawing.Point(291, 198);
			this.gunaButton3.Name = "gunaButton3";
			this.gunaButton3.OnHoverBaseColor = global::System.Drawing.Color.FromArgb(151, 143, 255);
			this.gunaButton3.OnHoverBorderColor = global::System.Drawing.Color.Black;
			this.gunaButton3.OnHoverForeColor = global::System.Drawing.Color.White;
			this.gunaButton3.OnHoverImage = null;
			this.gunaButton3.OnPressedColor = global::System.Drawing.Color.Black;
			this.gunaButton3.Size = new global::System.Drawing.Size(93, 30);
			this.gunaButton3.TabIndex = 16;
			this.gunaButton3.Click += new global::System.EventHandler(this.gunaButton3_Click);
			this.siticoneLabel6.BackColor = global::System.Drawing.Color.FromArgb(100, 88, 255);
			this.siticoneLabel6.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 13f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneLabel6.ForeColor = global::System.Drawing.Color.WhiteSmoke;
			this.siticoneLabel6.Location = new global::System.Drawing.Point(49, 202);
			this.siticoneLabel6.Name = "siticoneLabel6";
			this.siticoneLabel6.Size = new global::System.Drawing.Size(56, 22);
			this.siticoneLabel6.TabIndex = 17;
			this.siticoneLabel6.Text = "Cheats";
			this.siticoneLabel7.BackColor = global::System.Drawing.Color.FromArgb(100, 88, 255);
			this.siticoneLabel7.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 13f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneLabel7.ForeColor = global::System.Drawing.Color.WhiteSmoke;
			this.siticoneLabel7.Location = new global::System.Drawing.Point(182, 202);
			this.siticoneLabel7.Name = "siticoneLabel7";
			this.siticoneLabel7.Size = new global::System.Drawing.Size(46, 22);
			this.siticoneLabel7.TabIndex = 18;
			this.siticoneLabel7.Text = "Spoof";
			this.siticoneLabel8.BackColor = global::System.Drawing.Color.FromArgb(100, 88, 255);
			this.siticoneLabel8.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 13f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneLabel8.ForeColor = global::System.Drawing.Color.WhiteSmoke;
			this.siticoneLabel8.Location = new global::System.Drawing.Point(315, 202);
			this.siticoneLabel8.Name = "siticoneLabel8";
			this.siticoneLabel8.Size = new global::System.Drawing.Size(46, 22);
			this.siticoneLabel8.TabIndex = 19;
			this.siticoneLabel8.Text = "Clean";
			this.siticoneDragControl1.TargetControl = this.dragger;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			base.ClientSize = new global::System.Drawing.Size(405, 240);
			base.Controls.Add(this.siticoneLabel8);
			base.Controls.Add(this.siticoneLabel7);
			base.Controls.Add(this.siticoneLabel6);
			base.Controls.Add(this.gunaButton3);
			base.Controls.Add(this.gunaButton2);
			base.Controls.Add(this.gunaButton1);
			base.Controls.Add(this.HWID);
			base.Controls.Add(this.siticoneLabel4);
			base.Controls.Add(this.siticoneLabel3);
			base.Controls.Add(this.siticoneLabel2);
			base.Controls.Add(this.siticoneLabel1);
			base.Controls.Add(this.dragger);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "SpeedFN";
			this.Text = "SpeedFN";
			base.Load += new global::System.EventHandler(this.SpeedFN_Load);
			this.dragger.ResumeLayout(false);
			this.dragger.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000004 RID: 4
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000005 RID: 5
		private global::Siticone.UI.WinForms.SiticoneLabel name;

		// Token: 0x04000006 RID: 6
		private global::Siticone.UI.WinForms.SiticoneGradientPanel dragger;

		// Token: 0x04000007 RID: 7
		private global::Siticone.UI.WinForms.SiticoneCircleButton minimize;

		// Token: 0x04000008 RID: 8
		private global::Siticone.UI.WinForms.SiticoneCircleButton close;

		// Token: 0x04000009 RID: 9
		private global::Siticone.UI.WinForms.SiticoneCircleButton fullscreen;

		// Token: 0x0400000A RID: 10
		private global::Siticone.UI.WinForms.SiticoneLabel HWID;

		// Token: 0x0400000B RID: 11
		private global::Siticone.UI.WinForms.SiticoneLabel siticoneLabel4;

		// Token: 0x0400000C RID: 12
		private global::Siticone.UI.WinForms.SiticoneLabel siticoneLabel3;

		// Token: 0x0400000D RID: 13
		private global::Siticone.UI.WinForms.SiticoneLabel siticoneLabel2;

		// Token: 0x0400000E RID: 14
		private global::Siticone.UI.WinForms.SiticoneLabel siticoneLabel1;

		// Token: 0x0400000F RID: 15
		private global::Guna.UI.WinForms.GunaButton gunaButton1;

		// Token: 0x04000010 RID: 16
		private global::Guna.UI.WinForms.GunaButton gunaButton2;

		// Token: 0x04000011 RID: 17
		private global::Guna.UI.WinForms.GunaButton gunaButton3;

		// Token: 0x04000012 RID: 18
		private global::Siticone.UI.WinForms.SiticoneLabel siticoneLabel6;

		// Token: 0x04000013 RID: 19
		private global::Siticone.UI.WinForms.SiticoneLabel siticoneLabel7;

		// Token: 0x04000014 RID: 20
		private global::Siticone.UI.WinForms.SiticoneLabel siticoneLabel8;

		// Token: 0x04000015 RID: 21
		private global::Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;
	}
}
