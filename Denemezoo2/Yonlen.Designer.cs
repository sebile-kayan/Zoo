namespace Denemezoo2
{
	partial class Yonlen
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
			this.secgosteriyeri = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.secbilet = new System.Windows.Forms.Button();
			this.secegitmen = new System.Windows.Forms.Button();
			this.sechayvan = new System.Windows.Forms.Button();
			this.secgosteri = new System.Windows.Forms.Button();
			this.back = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
			this.SuspendLayout();
			// 
			// secgosteriyeri
			// 
			this.secgosteriyeri.Location = new System.Drawing.Point(506, 247);
			this.secgosteriyeri.Name = "secgosteriyeri";
			this.secgosteriyeri.Size = new System.Drawing.Size(86, 50);
			this.secgosteriyeri.TabIndex = 11;
			this.secgosteriyeri.Text = "GÖSTERİ YERİ";
			this.secgosteriyeri.UseVisualStyleBackColor = true;
			this.secgosteriyeri.Click += new System.EventHandler(this.secgosteriyeri_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Modern No. 20", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label1.Location = new System.Drawing.Point(96, 147);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(614, 34);
			this.label1.TabIndex = 10;
			this.label1.Text = "İşlem Yapmak İstediğiniz Varlığı Seçiniz.";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// secbilet
			// 
			this.secbilet.Location = new System.Drawing.Point(670, 247);
			this.secbilet.Name = "secbilet";
			this.secbilet.Size = new System.Drawing.Size(86, 50);
			this.secbilet.TabIndex = 9;
			this.secbilet.Text = "BİLET";
			this.secbilet.UseVisualStyleBackColor = true;
			this.secbilet.Click += new System.EventHandler(this.secbilet_Click);
			// 
			// secegitmen
			// 
			this.secegitmen.Location = new System.Drawing.Point(214, 247);
			this.secegitmen.Name = "secegitmen";
			this.secegitmen.Size = new System.Drawing.Size(104, 50);
			this.secegitmen.TabIndex = 8;
			this.secegitmen.Text = "EĞİTMEN";
			this.secegitmen.UseVisualStyleBackColor = true;
			this.secegitmen.Click += new System.EventHandler(this.secegitmen_Click);
			// 
			// sechayvan
			// 
			this.sechayvan.Location = new System.Drawing.Point(45, 247);
			this.sechayvan.Name = "sechayvan";
			this.sechayvan.Size = new System.Drawing.Size(110, 50);
			this.sechayvan.TabIndex = 7;
			this.sechayvan.Text = "HAYVAN";
			this.sechayvan.UseVisualStyleBackColor = true;
			this.sechayvan.Click += new System.EventHandler(this.sechayvan_Click);
			// 
			// secgosteri
			// 
			this.secgosteri.Location = new System.Drawing.Point(362, 247);
			this.secgosteri.Name = "secgosteri";
			this.secgosteri.Size = new System.Drawing.Size(107, 50);
			this.secgosteri.TabIndex = 6;
			this.secgosteri.Text = "GÖSTERİ";
			this.secgosteri.UseVisualStyleBackColor = true;
			this.secgosteri.Click += new System.EventHandler(this.secgosteri_Click);
			// 
			// back
			// 
			this.back.Image = global::Denemezoo2.Properties.Resources.geri;
			this.back.Location = new System.Drawing.Point(12, 12);
			this.back.Name = "back";
			this.back.Size = new System.Drawing.Size(48, 45);
			this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.back.TabIndex = 114;
			this.back.TabStop = false;
			this.back.Click += new System.EventHandler(this.back_Click);
			// 
			// Yonlen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Moccasin;
			this.ClientSize = new System.Drawing.Size(987, 468);
			this.Controls.Add(this.back);
			this.Controls.Add(this.secgosteriyeri);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.secbilet);
			this.Controls.Add(this.secegitmen);
			this.Controls.Add(this.sechayvan);
			this.Controls.Add(this.secgosteri);
			this.Name = "Yonlen";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Yonlen";
			this.Load += new System.EventHandler(this.Yonlen_Load);
			((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button secgosteriyeri;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button secbilet;
		private System.Windows.Forms.Button secegitmen;
		private System.Windows.Forms.Button sechayvan;
		private System.Windows.Forms.Button secgosteri;
		private System.Windows.Forms.PictureBox back;
	}
}