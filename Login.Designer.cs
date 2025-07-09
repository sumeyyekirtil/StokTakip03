namespace StokTakip03
{
	partial class Login
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button2 = new System.Windows.Forms.Button();
			this.txtSifre = new System.Windows.Forms.TextBox();
			this.txtKAdi = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.girişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.kategoriYonetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ürünYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.DarkCyan;
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.txtSifre);
			this.groupBox1.Controls.Add(this.txtKAdi);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(211, 95);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(284, 183);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Kullanıcı Giriş Ekranı";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(26, 124);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(94, 37);
			this.button2.TabIndex = 5;
			this.button2.Text = "Çıkış";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// txtSifre
			// 
			this.txtSifre.Location = new System.Drawing.Point(147, 71);
			this.txtSifre.Name = "txtSifre";
			this.txtSifre.Size = new System.Drawing.Size(100, 22);
			this.txtSifre.TabIndex = 4;
			// 
			// txtKAdi
			// 
			this.txtKAdi.Location = new System.Drawing.Point(147, 36);
			this.txtKAdi.Name = "txtKAdi";
			this.txtKAdi.Size = new System.Drawing.Size(100, 22);
			this.txtKAdi.TabIndex = 3;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(147, 124);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 37);
			this.button1.TabIndex = 0;
			this.button1.Text = "Giriş";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(23, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Kullanıcı Adı";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(23, 74);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Kullanıcı Sifre";
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.girişToolStripMenuItem,
            this.kategoriYonetimiToolStripMenuItem,
            this.ürünYönetimiToolStripMenuItem,
            this.çıkışToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(725, 28);
			this.menuStrip1.TabIndex = 6;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// girişToolStripMenuItem
			// 
			this.girişToolStripMenuItem.Name = "girişToolStripMenuItem";
			this.girişToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
			this.girişToolStripMenuItem.Text = "Giriş";
			this.girişToolStripMenuItem.Click += new System.EventHandler(this.girişToolStripMenuItem_Click);
			// 
			// kategoriYonetimiToolStripMenuItem
			// 
			this.kategoriYonetimiToolStripMenuItem.Name = "kategoriYonetimiToolStripMenuItem";
			this.kategoriYonetimiToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
			this.kategoriYonetimiToolStripMenuItem.Text = "Kategori Yönetimi";
			this.kategoriYonetimiToolStripMenuItem.Click += new System.EventHandler(this.kategoriYonetimiToolStripMenuItem_Click);
			// 
			// çıkışToolStripMenuItem
			// 
			this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
			this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
			this.çıkışToolStripMenuItem.Text = "Çıkış";
			this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
			// 
			// ürünYönetimiToolStripMenuItem
			// 
			this.ürünYönetimiToolStripMenuItem.Name = "ürünYönetimiToolStripMenuItem";
			this.ürünYönetimiToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
			this.ürünYönetimiToolStripMenuItem.Text = "Ürün Yönetimi";
			this.ürünYönetimiToolStripMenuItem.Click += new System.EventHandler(this.ürünYönetimiToolStripMenuItem_Click);
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(725, 377);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.Load += new System.EventHandler(this.Login_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtSifre;
		private System.Windows.Forms.TextBox txtKAdi;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem girişToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem kategoriYonetimiToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ToolStripMenuItem ürünYönetimiToolStripMenuItem;
	}
}