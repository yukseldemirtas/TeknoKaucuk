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
	public partial class FrmIslevsellik_5 : Form
	{
		public FrmIslevsellik_5()
		{
			InitializeComponent();
		}

		private void btn_sonucuGoster_Click(object sender, EventArgs e)
		{
			if (txt_sira.Text == "")
			{
				MessageBox.Show("Lütfen hesaplanacak bir değer giriniz", "Uyarı");
				return;
			}
			int girilenSira = int.Parse(txt_sira.Text);
			int fibonacciSayisi = 0, oncekiSayi = 0, sonrakiSayi = 1;
			girilenSira--;

			if (girilenSira == 1) fibonacciSayisi = 1;

			for (int sira = 2; sira <= girilenSira; sira++)
			{
				fibonacciSayisi = oncekiSayi + sonrakiSayi;
				oncekiSayi = sonrakiSayi;
				sonrakiSayi = fibonacciSayisi;
			}
			lbl_sonuc.Text = fibonacciSayisi.ToString();
		}

		private void txt_sira_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}
	}
}
