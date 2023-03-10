namespace TeknoKaucukApp
{
	partial class FrmIslevsellik_4
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
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.btn_dosyaSec = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lbl_Sonuc = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog1";
			this.openFileDialog.Filter = "Text Files|*.txt";
			// 
			// btn_dosyaSec
			// 
			this.btn_dosyaSec.Location = new System.Drawing.Point(15, 34);
			this.btn_dosyaSec.Name = "btn_dosyaSec";
			this.btn_dosyaSec.Size = new System.Drawing.Size(559, 23);
			this.btn_dosyaSec.TabIndex = 0;
			this.btn_dosyaSec.Text = "Dosya Seç";
			this.btn_dosyaSec.UseVisualStyleBackColor = true;
			this.btn_dosyaSec.Click += new System.EventHandler(this.btn_dosyaSec_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(312, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Büyükten küçüğe sıralama yapılacak olan metin dosyasını seçiniz";
			// 
			// lbl_Sonuc
			// 
			this.lbl_Sonuc.AutoSize = true;
			this.lbl_Sonuc.Location = new System.Drawing.Point(37, 69);
			this.lbl_Sonuc.MaximumSize = new System.Drawing.Size(500, 0);
			this.lbl_Sonuc.Name = "lbl_Sonuc";
			this.lbl_Sonuc.Size = new System.Drawing.Size(0, 13);
			this.lbl_Sonuc.TabIndex = 3;
			// 
			// FrmIslevsellik_4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(586, 483);
			this.Controls.Add(this.lbl_Sonuc);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_dosyaSec);
			this.Name = "FrmIslevsellik_4";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Dördüncü İşlevsellik";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.Button btn_dosyaSec;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbl_Sonuc;
	}
}