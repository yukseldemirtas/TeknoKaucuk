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
	public partial class FrmHomePage : Form
	{
		public FrmHomePage()
		{
			InitializeComponent();
		}

		private void btn_islevsellik_1_Click(object sender, EventArgs e)
		{
			FrmIslevsellik_1 frmIslevsellik_1 = new FrmIslevsellik_1();
			frmIslevsellik_1.ShowDialog();
		}

		private void btn_islevsellik_2_Click(object sender, EventArgs e)
		{
			FrmIslevsellik_2 frmIslevsellik_2 = new FrmIslevsellik_2();
			frmIslevsellik_2.ShowDialog();
		}

		private void btn_islevsellik_3_Click(object sender, EventArgs e)
		{
			FrmIslevsellik_3 frmIslevsellik_3 = new FrmIslevsellik_3();
			frmIslevsellik_3.ShowDialog();
		}

		private void btn_islevsellik_4_Click(object sender, EventArgs e)
		{
			FrmIslevsellik_4 frmIslevsellik_4 = new FrmIslevsellik_4();
			frmIslevsellik_4.ShowDialog();
		}

		private void btn_islevsellik_5_Click(object sender, EventArgs e)
		{
			FrmIslevsellik_5 frmIslevsellik_5 = new FrmIslevsellik_5();
			frmIslevsellik_5.ShowDialog();
		}
	}
}
