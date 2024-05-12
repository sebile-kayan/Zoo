namespace Denemezoo2
{
	partial class Giris
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label1.Location = new System.Drawing.Point(129, 247);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(642, 29);
			this.label1.TabIndex = 1;
			this.label1.Text = "HAYVANAT BAHÇESİ VERİTABANINA HOŞ GELDİNİZ";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.IndianRed;
			this.button1.ForeColor = System.Drawing.Color.Chartreuse;
			this.button1.Location = new System.Drawing.Point(383, 337);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(237, 32);
			this.button1.TabIndex = 2;
			this.button1.Text = "Bir Sonraki Sayfaya Geç";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Giris
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1005, 545);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Giris";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Giris";
			this.Load += new System.EventHandler(this.Giris_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.ComponentModel.BackgroundWorker backgroundWorker2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
	}
}