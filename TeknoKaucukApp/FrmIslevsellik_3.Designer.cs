namespace TeknoKaucukApp
{
	partial class FrmIslevsellik_3
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btn_sonucuGoster = new System.Windows.Forms.Button();
			this.txt_sayi = new System.Windows.Forms.TextBox();
			this.lbl_sonuc = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.grbSonuc = new System.Windows.Forms.GroupBox();
			this.grbSonuc.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_sonucuGoster
			// 
			this.btn_sonucuGoster.Location = new System.Drawing.Point(12, 67);
			this.btn_sonucuGoster.Name = "btn_sonucuGoster";
			this.btn_sonucuGoster.Size = new System.Drawing.Size(563, 23);
			this.btn_sonucuGoster.TabIndex = 0;
			this.btn_sonucuGoster.Text = "Çarpım Tablosunu Göster";
			this.btn_sonucuGoster.UseVisualStyleBackColor = true;
			this.btn_sonucuGoster.Click += new System.EventHandler(this.btn_sonucuGoster_Click);
			// 
			// txt_sayi
			// 
			this.txt_sayi.Location = new System.Drawing.Point(12, 41);
			this.txt_sayi.Name = "txt_sayi";
			this.txt_sayi.Size = new System.Drawing.Size(563, 20);
			this.txt_sayi.TabIndex = 1;
			this.txt_sayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sayi_KeyPress);
			this.txt_sayi.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_sayi_KeyUp);
			// 
			// lbl_sonuc
			// 
			this.lbl_sonuc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbl_sonuc.Location = new System.Drawing.Point(3, 16);
			this.lbl_sonuc.Name = "lbl_sonuc";
			this.lbl_sonuc.Size = new System.Drawing.Size(554, 323);
			this.lbl_sonuc.TabIndex = 2;
			this.lbl_sonuc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(338, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Çarpım tablosunu görmek istediğiniz 1 ile 15 arasında bir tam sayı giriniz";
			// 
			// grbSonuc
			// 
			this.grbSonuc.Controls.Add(this.lbl_sonuc);
			this.grbSonuc.Location = new System.Drawing.Point(15, 96);
			this.grbSonuc.Name = "grbSonuc";
			this.grbSonuc.Size = new System.Drawing.Size(560, 342);
			this.grbSonuc.TabIndex = 4;
			this.grbSonuc.TabStop = false;
			// 
			// FrmIslevsellik_3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(587, 450);
			this.Controls.Add(this.grbSonuc);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txt_sayi);
			this.Controls.Add(this.btn_sonucuGoster);
			this.Name = "FrmIslevsellik_3";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Üçüncü İşlevsellik";
			this.Load += new System.EventHandler(this.FrmIslevsellik_3_Load);
			this.grbSonuc.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_sonucuGoster;
		private System.Windows.Forms.TextBox txt_sayi;
		private System.Windows.Forms.Label lbl_sonuc;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox grbSonuc;
	}
}