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
	public partial class KategoriYonetimi : Form
	{
		public KategoriYonetimi()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{ 
			Login login = new Login();
			login.ShowDialog();
		}

		private void btnKayıt_Click(object sender, EventArgs e)
		{
			MessageBox.Show(cbKategori.SelectedText + " Kategorisine " + richDetay.Text + " Kaydedildi! ");
		}

		private void btnÇıkış_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
