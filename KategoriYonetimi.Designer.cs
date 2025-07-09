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
			this.components = new System.ComponentModel.Container();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.kategoriYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnLogin = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnÇıkış = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.btnKayıt = new System.Windows.Forms.Button();
			this.cbKategori = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.richDetay = new System.Windows.Forms.RichTextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.seçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.kopyalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.yapıştırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.kesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ürünYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategoriYönetimiToolStripMenuItem,
            this.ürünYönetimiToolStripMenuItem});
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
			this.btnLogin.Location = new System.Drawing.Point(660, 364);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(109, 58);
			this.btnLogin.TabIndex = 1;
			this.btnLogin.Text = "Giriş Sayfası";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
			this.groupBox1.Controls.Add(this.richDetay);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.btnÇıkış);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.btnKayıt);
			this.groupBox1.Controls.Add(this.cbKategori);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 47);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(630, 391);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Kategori Bilgileri";
			// 
			// btnÇıkış
			// 
			this.btnÇıkış.Location = new System.Drawing.Point(505, 317);
			this.btnÇıkış.Name = "btnÇıkış";
			this.btnÇıkış.Size = new System.Drawing.Size(98, 58);
			this.btnÇıkış.TabIndex = 12;
			this.btnÇıkış.Text = "Çıkış";
			this.btnÇıkış.UseVisualStyleBackColor = true;
			this.btnÇıkış.Click += new System.EventHandler(this.btnÇıkış_Click);
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
			// btnKayıt
			// 
			this.btnKayıt.Location = new System.Drawing.Point(505, 238);
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
			this.cbKategori.Size = new System.Drawing.Size(316, 24);
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
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(168, 146);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(316, 22);
			this.textBox1.TabIndex = 13;
			this.textBox1.Text = "Lütfen Detay Bilginizi Alt Alana Giriniz!";
			// 
			// richDetay
			// 
			this.richDetay.Location = new System.Drawing.Point(22, 200);
			this.richDetay.Name = "richDetay";
			this.richDetay.Size = new System.Drawing.Size(462, 175);
			this.richDetay.TabIndex = 14;
			this.richDetay.Text = "";
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seçToolStripMenuItem,
            this.kopyalaToolStripMenuItem,
            this.yapıştırToolStripMenuItem,
            this.silToolStripMenuItem,
            this.kesToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(133, 124);
			// 
			// seçToolStripMenuItem
			// 
			this.seçToolStripMenuItem.Name = "seçToolStripMenuItem";
			this.seçToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
			this.seçToolStripMenuItem.Text = "Seç";
			this.seçToolStripMenuItem.Click += new System.EventHandler(this.seçToolStripMenuItem_Click);
			// 
			// kopyalaToolStripMenuItem
			// 
			this.kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
			this.kopyalaToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
			this.kopyalaToolStripMenuItem.Text = "Kopyala";
			this.kopyalaToolStripMenuItem.Click += new System.EventHandler(this.kopyalaToolStripMenuItem_Click);
			// 
			// yapıştırToolStripMenuItem
			// 
			this.yapıştırToolStripMenuItem.Name = "yapıştırToolStripMenuItem";
			this.yapıştırToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
			this.yapıştırToolStripMenuItem.Text = "Yapıştır";
			this.yapıştırToolStripMenuItem.Click += new System.EventHandler(this.yapıştırToolStripMenuItem_Click);
			// 
			// silToolStripMenuItem
			// 
			this.silToolStripMenuItem.Name = "silToolStripMenuItem";
			this.silToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
			this.silToolStripMenuItem.Text = "Sil";
			this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
			// 
			// kesToolStripMenuItem
			// 
			this.kesToolStripMenuItem.Name = "kesToolStripMenuItem";
			this.kesToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
			this.kesToolStripMenuItem.Text = "Kes";
			this.kesToolStripMenuItem.Click += new System.EventHandler(this.kesToolStripMenuItem_Click);
			// 
			// ürünYönetimiToolStripMenuItem
			// 
			this.ürünYönetimiToolStripMenuItem.Name = "ürünYönetimiToolStripMenuItem";
			this.ürünYönetimiToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
			this.ürünYönetimiToolStripMenuItem.Text = "Ürün Yönetimi";
			this.ürünYönetimiToolStripMenuItem.Click += new System.EventHandler(this.ürünYönetimiToolStripMenuItem_Click);
			// 
			// KategoriYonetimi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.HighlightText;
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
			this.contextMenuStrip1.ResumeLayout(false);
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
		private System.Windows.Forms.Button btnÇıkış;
		private System.Windows.Forms.RichTextBox richDetay;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem seçToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem yapıştırToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem kesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ürünYönetimiToolStripMenuItem;
	}
}