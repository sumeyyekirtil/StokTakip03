using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
				MessageBox.Show("Kullanıcı Adı ve Şifre Boş Geçilemez!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Question);
			}
			else if (string.IsNullOrEmpty(txtSifre.Text))
			{
				MessageBox.Show("Kullanıcı Adı ve Şifre Boş Geçilemez!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Question);
			}
			else
			{
				string veritabanindakiKullanici = "Admin", veritabanindakiSifre = "12345";
				if (txtKAdi.Text == veritabanindakiKullanici && txtSifre.Text == veritabanindakiSifre)
				{
					this.Hide();//bu formu gizle 
					Login login = new Login();
					login.ShowDialog();
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
	}
}
