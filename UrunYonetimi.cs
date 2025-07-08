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
			MessageBox.Show(cbKategori.SelectedItem + " Kategorisine " + txtUrunSayi.Text + " Kilo " + txtPrice.Text + " Fiyat ile " + txtUrunAdi.Text + " Başarıyla Eklendi!");

			//DataTable tablo = new DataTable();
			dataGridView1.ColumnCount = 3;
			dataGridView1.Columns[0].Name = " Ürün Adı ";
			dataGridView1.Columns[1].Name = " Sayı ";
			dataGridView1.Columns[2].Name = " Fiyat ";

			dataGridView1.Rows.Add(txtUrunAdi.SelectedText.ToString() , txtUrunSayi.SelectedText.ToString(), txtPrice.SelectedText.ToString());
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			//dataGridView1.ColumnCount = 3;
			//dataGridView1.Columns[0].Name = " Ürün Adı ";
			//dataGridView1.Columns[1].Name = " Sayı ";
			//dataGridView1.Columns[2].Name = " Fiyat ";

			//dataGridView1.Rows.Add(txtUrunAdi.SelectedText.ToString());
			//dataGridView1.Rows.Add(txtUrunSayi.SelectedText.ToString());
			//dataGridView1.Rows.Add(txtPrice.SelectedText.ToString());
		}

		private void UrunYonetimi_Load(object sender, EventArgs e)
		{
			//DataTable tablo = new DataTable();
			lblMesaj.Text = " Hoşgeldiniz " + KullaniciAdi; //Login sayfasına kullaniciadi prop oluşturdum.
		}
	}
}
