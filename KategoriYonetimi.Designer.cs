namespace StokTakip03
{
	partial class KategoriYonetimi
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.kategoriYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnLogin = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategoriYönetimiToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// kategoriYönetimiToolStripMenuItem
			// 
			this.kategoriYönetimiToolStripMenuItem.Name = "kategoriYönetimiToolStripMenuItem";
			this.kategoriYönetimiToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
			this.kategoriYönetimiToolStripMenuItem.Text = "Kategori Yönetimi";
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(648, 350);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(109, 58);
			this.btnLogin.TabIndex = 1;
			this.btnLogin.Text = "Giriş Sayfası";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.richTextBox1);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(47, 87);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(577, 333);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Kategori Bilgileri";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(19, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Kategori Sınıfı";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Meyve",
            "Sebze",
            "Şarküteri",
            "Temizlik",
            "Atıştırmalık",
            "Hijyen"});
			this.comboBox1.Location = new System.Drawing.Point(150, 46);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 24);
			this.comboBox1.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(459, 263);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(98, 58);
			this.button1.TabIndex = 9;
			this.button1.Text = "Kaydet";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(191, 146);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(223, 149);
			this.richTextBox1.TabIndex = 10;
			this.richTextBox1.Text = "";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(19, 146);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(143, 16);
			this.label2.TabIndex = 11;
			this.label2.Text = "Kategori Detay Bilgileri";
			// 
			// KategoriYonetimi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "KategoriYonetimi";
			this.Text = "KategoriYonetimi";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem kategoriYönetimiToolStripMenuItem;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RichTextBox richTextBox1;
	}
}