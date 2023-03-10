namespace TeknoKaucukApp
{
	partial class FrmIslevsellik_1
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
			this.txt_sayi_1 = new System.Windows.Forms.TextBox();
			this.txt_sayi_2 = new System.Windows.Forms.TextBox();
			this.txt_sayi_3 = new System.Windows.Forms.TextBox();
			this.btn_sonucuGoster = new System.Windows.Forms.Button();
			this.txt_sonuc = new System.Windows.Forms.TextBox();
			this.lbl_sayi_1_1 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txt_sayi_1
			// 
			this.txt_sayi_1.Location = new System.Drawing.Point(44, 76);
			this.txt_sayi_1.Name = "txt_sayi_1";
			this.txt_sayi_1.Size = new System.Drawing.Size(100, 20);
			this.txt_sayi_1.TabIndex = 0;
			this.txt_sayi_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sayi_KeyPress);
			// 
			// txt_sayi_2
			// 
			this.txt_sayi_2.Location = new System.Drawing.Point(169, 76);
			this.txt_sayi_2.Name = "txt_sayi_2";
			this.txt_sayi_2.Size = new System.Drawing.Size(100, 20);
			this.txt_sayi_2.TabIndex = 1;
			this.txt_sayi_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sayi_KeyPress);
			// 
			// txt_sayi_3
			// 
			this.txt_sayi_3.Location = new System.Drawing.Point(309, 76);
			this.txt_sayi_3.Name = "txt_sayi_3";
			this.txt_sayi_3.Size = new System.Drawing.Size(100, 20);
			this.txt_sayi_3.TabIndex = 2;
			this.txt_sayi_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sayi_KeyPress);
			// 
			// btn_sonucuGoster
			// 
			this.btn_sonucuGoster.Location = new System.Drawing.Point(217, 146);
			this.btn_sonucuGoster.Name = "btn_sonucuGoster";
			this.btn_sonucuGoster.Size = new System.Drawing.Size(147, 23);
			this.btn_sonucuGoster.TabIndex = 3;
			this.btn_sonucuGoster.Text = "Sonucu Göster";
			this.btn_sonucuGoster.UseVisualStyleBackColor = true;
			this.btn_sonucuGoster.Click += new System.EventHandler(this.btn_sonucuGoster_Click);
			// 
			// txt_sonuc
			// 
			this.txt_sonuc.Location = new System.Drawing.Point(434, 78);
			this.txt_sonuc.Name = "txt_sonuc";
			this.txt_sonuc.ReadOnly = true;
			this.txt_sonuc.Size = new System.Drawing.Size(100, 20);
			this.txt_sonuc.TabIndex = 4;
			// 
			// lbl_sayi_1_1
			// 
			this.lbl_sayi_1_1.AutoSize = true;
			this.lbl_sayi_1_1.Location = new System.Drawing.Point(28, 79);
			this.lbl_sayi_1_1.Name = "lbl_sayi_1_1";
			this.lbl_sayi_1_1.Size = new System.Drawing.Size(10, 13);
			this.lbl_sayi_1_1.TabIndex = 5;
			this.lbl_sayi_1_1.Text = "(";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(150, 79);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(13, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "+";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(275, 79);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(10, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = ")";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(291, 81);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(12, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "x";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(415, 81);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(13, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "=";
			// 
			// FrmIslevsellik_1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(580, 248);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lbl_sayi_1_1);
			this.Controls.Add(this.txt_sonuc);
			this.Controls.Add(this.btn_sonucuGoster);
			this.Controls.Add(this.txt_sayi_3);
			this.Controls.Add(this.txt_sayi_2);
			this.Controls.Add(this.txt_sayi_1);
			this.Name = "FrmIslevsellik_1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Birinci İşlevsellik";
			this.Load += new System.EventHandler(this.FrmIslevsellik_1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txt_sayi_1;
		private System.Windows.Forms.TextBox txt_sayi_2;
		private System.Windows.Forms.TextBox txt_sayi_3;
		private System.Windows.Forms.Button btn_sonucuGoster;
		private System.Windows.Forms.TextBox txt_sonuc;
		private System.Windows.Forms.Label lbl_sayi_1_1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
	}
}