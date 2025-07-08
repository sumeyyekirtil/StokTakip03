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
			this.label2 = new System.Windows.Forms.Label();
			this.richDetay = new System.Windows.Forms.RichTextBox();
			this.btnKayıt = new System.Windows.Forms.Button();
			this.cbKategori = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnÇıkış = new System.Windows.Forms.Button();
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
			this.menuStrip1.Size = new System.Drawing.Size(792, 28);
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
			this.groupBox1.Controls.Add(this.btnÇıkış);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.richDetay);
			this.groupBox1.Controls.Add(this.btnKayıt);
			this.groupBox1.Controls.Add(this.cbKategori);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(47, 33);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(577, 387);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Kategori Bilgileri";
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
			// richDetay
			// 
			this.richDetay.Location = new System.Drawing.Point(168, 143);
			this.richDetay.Name = "richDetay";
			this.richDetay.Size = new System.Drawing.Size(274, 229);
			this.richDetay.TabIndex = 10;
			this.richDetay.Text = "";
			// 
			// btnKayıt
			// 
			this.btnKayıt.Location = new System.Drawing.Point(461, 241);
			this.btnKayıt.Name = "btnKayıt";
			this.btnKayıt.Size = new System.Drawing.Size(98, 58);
			this.btnKayıt.TabIndex = 9;
			this.btnKayıt.Text = "Kaydet";
			this.btnKayıt.UseVisualStyleBackColor = true;
			this.btnKayıt.Click += new System.EventHandler(this.btnKayıt_Click);
			// 
			// cbKategori
			// 
			this.cbKategori.FormattingEnabled = true;
			this.cbKategori.Items.AddRange(new object[] {
            "Meyve",
            "Sebze",
            "Şarküteri",
            "Temizlik",
            "Atıştırmalık",
            "Hijyen"});
			this.cbKategori.Location = new System.Drawing.Point(168, 46);
			this.cbKategori.Name = "cbKategori";
			this.cbKategori.Size = new System.Drawing.Size(184, 24);
			this.cbKategori.TabIndex = 2;
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
			// btnÇıkış
			// 
			this.btnÇıkış.Location = new System.Drawing.Point(461, 317);
			this.btnÇıkış.Name = "btnÇıkış";
			this.btnÇıkış.Size = new System.Drawing.Size(98, 58);
			this.btnÇıkış.TabIndex = 12;
			this.btnÇıkış.Text = "Çıkış";
			this.btnÇıkış.UseVisualStyleBackColor = true;
			this.btnÇıkış.Click += new System.EventHandler(this.btnÇıkış_Click);
			// 
			// KategoriYonetimi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(792, 450);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "KategoriYonetimi";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
		private System.Windows.Forms.ComboBox cbKategori;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnKayıt;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RichTextBox richDetay;
		private System.Windows.Forms.Button btnÇıkış;
	}
}