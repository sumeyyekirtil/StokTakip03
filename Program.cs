using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakip03
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Login());
		}
	}
}
//private void button1_Click(object sender, EventArgs e)
//{
//	MessageBox.Show(cbKategoriler.SelectedItem + "Kategorisine " + txtUrunAdi.Text + "Ürünü Eklendi!");
//}
