namespace TeknoKaucukApp
{
	partial class FrmIslevsellik_2
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
			this.lbl_Sonuc = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btn_sonucuGoster
			// 
			this.btn_sonucuGoster.Location = new System.Drawing.Point(12, 12);
			this.btn_sonucuGoster.Name = "btn_sonucuGoster";
			this.btn_sonucuGoster.Size = new System.Drawing.Size(559, 33);
			this.btn_sonucuGoster.TabIndex = 0;
			this.btn_sonucuGoster.Text = "Sonucu Göster";
			this.btn_sonucuGoster.UseVisualStyleBackColor = true;
			this.btn_sonucuGoster.Click += new System.EventHandler(this.btn_sonucuGoster_Click);
			// 
			// lbl_Sonuc
			// 
			this.lbl_Sonuc.AutoSize = true;
			this.lbl_Sonuc.Location = new System.Drawing.Point(34, 68);
			this.lbl_Sonuc.MaximumSize = new System.Drawing.Size(500, 0);
			this.lbl_Sonuc.Name = "lbl_Sonuc";
			this.lbl_Sonuc.Size = new System.Drawing.Size(0, 13);
			this.lbl_Sonuc.TabIndex = 1;
			// 
			// FrmIslevsellik_2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(583, 450);
			this.Controls.Add(this.lbl_Sonuc);
			this.Controls.Add(this.btn_sonucuGoster);
			this.Name = "FrmIslevsellik_2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "İkinci İşlevsellik";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_sonucuGoster;
		private System.Windows.Forms.Label lbl_Sonuc;
	}
}