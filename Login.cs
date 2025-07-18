﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StokTakip03
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}
		private void button1_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtKAdi.Text))
			{
				MessageBox.Show("Kullanıcı Adı ve Şifre Boş Geçilemez!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else if (string.IsNullOrEmpty(txtSifre.Text))
			{
				MessageBox.Show("Kullanıcı Adı ve Şifre Boş Geçilemez!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Question);
			}
			else
			{
				//dgvLogin.ColumnCount = 2;
				//dgvLogin.Columns[0].Name = "Kullanıcı Adı";
				//dgvLogin.Columns[1].Name = "Kullanıcı Şifre";

				//dgvLogin.Rows.Add(txtKAdi.SelectedText.ToString());
				//dgvLogin.Rows.Add(txtSifre.SelectedText.ToString());
				//MessageBox.Show(txtKAdi.SelectedText + " Adlı Kullanıcı Girişi Onaylandı! ", txtSifre.Text);

				string veritabanindakiKullanici = "Admin", veritabanindakiSifre = "12345";
				if (txtKAdi.Text == veritabanindakiKullanici && txtSifre.Text == veritabanindakiSifre)
				{
					this.Hide();//bu formu gizle 
					UrunYonetimi urunYonetimi = new UrunYonetimi();
					urunYonetimi.ShowDialog();
				}
				else
				{
					MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);//giriş başarısızsa uyarı penceresi göster
				}
			}
		}
		private void button2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		//private void Login_Load(object sender, EventArgs e)
		//{
		//}

		private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void girişToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Login login = new Login();
			login.ShowDialog();
		}

		private void kategoriYonetimiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			KategoriYonetimi kategori = new KategoriYonetimi();
			kategori.ShowDialog();
		}

		private void ürünYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			UrunYonetimi urun = new UrunYonetimi();
			urun.ShowDialog();
		}
	}
}