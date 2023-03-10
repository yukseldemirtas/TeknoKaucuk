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
	public partial class FrmIslevsellik_2 : Form
	{
		public FrmIslevsellik_2()
		{
			InitializeComponent();
		}

		private void btn_sonucuGoster_Click(object sender, EventArgs e)
		{
			string sonuc = "";
			lbl_Sonuc.Text = string.Empty;
			for (int i = 1; i <= 200; i++)
			{
				if (i % 3 == 0 && i % 5 == 0)
				{
					if (i <= 100) sonuc += "zigzag, ";
					else sonuc += "zagzig, ";
				}
				else if (i % 3 == 0) sonuc += "zig, ";
				else if (i % 5 == 0) sonuc += "zag, ";
				else sonuc += i + ", ";
			}
			lbl_Sonuc.Text = sonuc;
		}
	}
}
