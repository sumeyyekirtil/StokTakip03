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
	public partial class UrunYonetimi : Form
	{
		public UrunYonetimi()
		{
			InitializeComponent();
		}
		public string KullaniciAdi { get; set; }

		private void button1_Click(object sender, EventArgs e)
		{
			dgvUrun.ColumnCount = 4;
			dgvUrun.Columns[0].Name = " Kategori ";
			dgvUrun.Columns[1].Name = " Ürün Adı ";
			dgvUrun.Columns[2].Name = " Sayı ";
			dgvUrun.Columns[3].Name = " Fiyat ";

			//.selecteddıtem ile tostring özelliği gelir, textbox text özelliği tek. ile açılır!
			dgvUrun.Rows.Add(cbKategori.SelectedItem.ToString(), txtUrunAdi.Text, txtUrunSayi.Text, txtPrice.Text);

			//MessageBox.Show(cbKategori.SelectedItem + " Kategorisine " + txtUrunSayi.Text + " Kilo " + txtPrice.Text + " Fiyat ile " + txtUrunAdi.Text + " Başarıyla Eklendi!");
		}
		private void UrunYonetimi_Load(object sender, EventArgs e)
		{
			//DataTable tablo = new DataTable();
			lblMesaj.Text = " Hoşgeldiniz " + KullaniciAdi; //Login sayfasına kullaniciadi prop oluşturdum.
		}
		private void kategoriYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			KategoriYonetimi kategori = new KategoriYonetimi();
			kategori.ShowDialog();
		}
		private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		private void loginToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Login login = new Login();
			login.ShowDialog();
		}
	}
}
