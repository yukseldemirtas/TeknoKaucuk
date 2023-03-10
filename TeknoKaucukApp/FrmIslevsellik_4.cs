using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TeknoKaucukApp
{
	public partial class FrmIslevsellik_4 : Form
	{
		public FrmIslevsellik_4()
		{
			InitializeComponent();
		}

		private void btn_dosyaSec_Click(object sender, EventArgs e)
		{
			try
			{
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					var icerik = string.Join(" ", File.ReadAllLines(openFileDialog.FileName));
					var arr = icerik.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Select(x => Convert.ToDecimal(x)).OrderByDescending(x => x).ToList();
					var sonuc = string.Join(" > ", arr);
					lbl_Sonuc.Text = sonuc;
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Seçtiğiniz metin dosyası içeriğini kontrol ediniz, sayı harici metin veya özel karakter içeriyor olabilir.");
			}
		
		}
	}
}
