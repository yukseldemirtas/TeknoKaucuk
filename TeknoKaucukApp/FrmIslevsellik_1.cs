using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknoKaucukApp
{
	public partial class FrmIslevsellik_1 : Form
	{
		public FrmIslevsellik_1()
		{
			InitializeComponent();
		}

		private void btn_sonucuGoster_Click(object sender, EventArgs e)
		{
			decimal sonuc = 0;
			if (string.IsNullOrEmpty(txt_sayi_1.Text) || string.IsNullOrEmpty(txt_sayi_2.Text) || string.IsNullOrEmpty(txt_sayi_3.Text))
			{
				MessageBox.Show("Lütfen tüm değerleri doldurunuz", "Uyarı");
				return;
			}
			sonuc = (decimal.Parse(txt_sayi_1.Text) + decimal.Parse(txt_sayi_2.Text)) * decimal.Parse(txt_sayi_3.Text);
			txt_sonuc.Text = sonuc.ToString();
		}

		private void txt_sayi_KeyPress(object sender, KeyPressEventArgs e)
		{
			char ayrac = ',';
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ayrac))
			{
				e.Handled = true;
			}
			if ((e.KeyChar == ayrac) && ((sender as TextBox).Text.IndexOf(ayrac) > -1))
			{
				e.Handled = true;
			}

		}

		private void FrmIslevsellik_1_Load(object sender, EventArgs e)
		{

		}
	}
}
