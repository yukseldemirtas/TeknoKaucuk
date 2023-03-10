namespace TeknoKaucukApp
{
	partial class FrmIslevsellik_5
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
			this.txt_sira = new System.Windows.Forms.TextBox();
			this.btn_sonucuGoster = new System.Windows.Forms.Button();
			this.lbl_sonuc = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txt_sira
			// 
			this.txt_sira.Location = new System.Drawing.Point(15, 25);
			this.txt_sira.Name = "txt_sira";
			this.txt_sira.Size = new System.Drawing.Size(556, 20);
			this.txt_sira.TabIndex = 0;
			this.txt_sira.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sira_KeyPress);
			// 
			// btn_sonucuGoster
			// 
			this.btn_sonucuGoster.Location = new System.Drawing.Point(15, 51);
			this.btn_sonucuGoster.Name = "btn_sonucuGoster";
			this.btn_sonucuGoster.Size = new System.Drawing.Size(556, 23);
			this.btn_sonucuGoster.TabIndex = 1;
			this.btn_sonucuGoster.Text = "Sonucu Göster";
			this.btn_sonucuGoster.UseVisualStyleBackColor = true;
			this.btn_sonucuGoster.Click += new System.EventHandler(this.btn_sonucuGoster_Click);
			// 
			// lbl_sonuc
			// 
			this.lbl_sonuc.AutoSize = true;
			this.lbl_sonuc.Location = new System.Drawing.Point(273, 110);
			this.lbl_sonuc.Name = "lbl_sonuc";
			this.lbl_sonuc.Size = new System.Drawing.Size(35, 13);
			this.lbl_sonuc.TabIndex = 2;
			this.lbl_sonuc.Text = "label1";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(248, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Fibonacci değerini öğrenmek istediğiniz sayıyı giriniz";
			// 
			// FrmIslevsellik_5
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(583, 180);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lbl_sonuc);
			this.Controls.Add(this.btn_sonucuGoster);
			this.Controls.Add(this.txt_sira);
			this.Name = "FrmIslevsellik_5";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Beşinci İşlevsellik";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txt_sira;
		private System.Windows.Forms.Button btn_sonucuGoster;
		private System.Windows.Forms.Label lbl_sonuc;
		private System.Windows.Forms.Label label1;
	}
}