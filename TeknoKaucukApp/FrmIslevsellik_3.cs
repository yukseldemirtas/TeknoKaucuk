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
	public partial class FrmIslevsellik_3 : Form
	{
		public FrmIslevsellik_3()
		{
			InitializeComponent();
		}

		private void btn_sonucuGoster_Click(object sender, EventArgs e)
		{
			if (txt_sayi.Text == "")
			{
				MessageBox.Show("Lütfen listelenecek bir değer giriniz", "Uyarı");
				return;
			}
			lbl_sonuc.Text = string.Empty;
			int sayi = int.Parse(txt_sayi.Text);
			for (int i = 0; i <= sayi; i++)
			{
				for (int j = 0; j <= sayi; j++)
				{
					int hesaplananSayi = 0;
					if (i == 0 && j == 0)
					{
						hesaplananSayi = 0;
					}
					else if (i == 0 && j != 0)
					{
						hesaplananSayi = j;

					}
					else if (i != 0 && j == 0)
					{
						hesaplananSayi = i;
					}
					else
					{
						hesaplananSayi = i * j;
					}
					string format = "{0," + (8 - hesaplananSayi.ToString().Length) + "}";
					lbl_sonuc.Text += string.Format(format, hesaplananSayi);
				}
				lbl_sonuc.Text += "\r\n";
			}
		}

		private void txt_sayi_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void txt_sayi_KeyUp(object sender, KeyEventArgs e)
		{
			if (txt_sayi.Text != "" && int.Parse(txt_sayi.Text) > 15)
			{
				txt_sayi.Text = "15";
			}
		}

		private void FrmIslevsellik_3_Load(object sender, EventArgs e)
		{

		}
	}
}
