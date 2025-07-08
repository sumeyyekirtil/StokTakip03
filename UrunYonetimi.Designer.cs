namespace StokTakip03
{
	partial class UrunYonetimi
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunYonetimi));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.ürünYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.label6 = new System.Windows.Forms.Label();
			this.urunFoto = new System.Windows.Forms.PictureBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cbKategori = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.txtUrunSayi = new System.Windows.Forms.TextBox();
			this.txtUrunAdi = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.lblMesaj = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.urunFoto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünYönetimiToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(804, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// ürünYönetimiToolStripMenuItem
			// 
			this.ürünYönetimiToolStripMenuItem.Name = "ürünYönetimiToolStripMenuItem";
			this.ürünYönetimiToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
			this.ürünYönetimiToolStripMenuItem.Text = "Ürün Yönetimi";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblMesaj);
			this.groupBox1.Controls.Add(this.dataGridView1);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.listBox1);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.urunFoto);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.cbKategori);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Controls.Add(this.txtPrice);
			this.groupBox1.Controls.Add(this.txtUrunSayi);
			this.groupBox1.Controls.Add(this.txtUrunAdi);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(23, 31);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(759, 455);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Ürün Bilgileri";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(236, 96);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(77, 16);
			this.label7.TabIndex = 15;
			this.label7.Text = "Ürün Resmi";
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 16;
			this.listBox1.Items.AddRange(new object[] {
            "Meyve",
            "Sebze",
            "Atıştırmalık",
            "Şarküteri",
            "Hijyen",
            "Deterjan"});
			this.listBox1.Location = new System.Drawing.Point(523, 51);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(190, 164);
			this.listBox1.TabIndex = 14;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(19, 301);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(96, 16);
			this.label6.TabIndex = 13;
			this.label6.Text = "Ürün Özellikleri";
			// 
			// urunFoto
			// 
			this.urunFoto.Image = ((System.Drawing.Image)(resources.GetObject("urunFoto.Image")));
			this.urunFoto.Location = new System.Drawing.Point(239, 123);
			this.urunFoto.Name = "urunFoto";
			this.urunFoto.Size = new System.Drawing.Size(103, 92);
			this.urunFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.urunFoto.TabIndex = 11;
			this.urunFoto.TabStop = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(236, 52);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(96, 16);
			this.label5.TabIndex = 10;
			this.label5.Text = "Kategori Bilgisi";
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
			this.cbKategori.Location = new System.Drawing.Point(360, 49);
			this.cbKategori.Name = "cbKategori";
			this.cbKategori.Size = new System.Drawing.Size(121, 24);
			this.cbKategori.TabIndex = 9;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(406, 165);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 50);
			this.button1.TabIndex = 8;
			this.button1.Text = "Kaydet";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(19, 199);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 16);
			this.label4.TabIndex = 7;
			this.label4.Text = "Aktif";
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(108, 195);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(57, 20);
			this.checkBox1.TabIndex = 6;
			this.checkBox1.Text = "Aktif ";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(108, 138);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(100, 22);
			this.txtPrice.TabIndex = 5;
			// 
			// txtUrunSayi
			// 
			this.txtUrunSayi.Location = new System.Drawing.Point(108, 96);
			this.txtUrunSayi.Name = "txtUrunSayi";
			this.txtUrunSayi.Size = new System.Drawing.Size(100, 22);
			this.txtUrunSayi.TabIndex = 4;
			// 
			// txtUrunAdi
			// 
			this.txtUrunAdi.Location = new System.Drawing.Point(108, 49);
			this.txtUrunAdi.Name = "txtUrunAdi";
			this.txtUrunAdi.Size = new System.Drawing.Size(100, 22);
			this.txtUrunAdi.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(19, 141);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(39, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Fiyatı";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(19, 99);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Sayısı";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(19, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ürün Adı";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(121, 276);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(592, 150);
			this.dataGridView1.TabIndex = 16;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// lblMesaj
			// 
			this.lblMesaj.AutoSize = true;
			this.lblMesaj.Location = new System.Drawing.Point(118, 18);
			this.lblMesaj.Name = "lblMesaj";
			this.lblMesaj.Size = new System.Drawing.Size(79, 16);
			this.lblMesaj.TabIndex = 17;
			this.lblMesaj.Text = "Kullanıcı Adı";
			// 
			// UrunYonetimi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(804, 510);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "UrunYonetimi";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "UrunYonetimi";
			this.Load += new System.EventHandler(this.UrunYonetimi_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.urunFoto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem ürünYönetimiToolStripMenuItem;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.TextBox txtUrunSayi;
		private System.Windows.Forms.TextBox txtUrunAdi;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox urunFoto;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cbKategori;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label lblMesaj;
	}
}