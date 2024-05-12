namespace Denemezoo2
{
	partial class FormGosteriYeri
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
			this.lbl1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.DataGrid = new System.Windows.Forms.DataGridView();
			this.txtgyno = new System.Windows.Forms.TextBox();
			this.txtgyad = new System.Windows.Forms.TextBox();
			this.txtgytel = new System.Windows.Forms.TextBox();
			this.txtgykoltuk = new System.Windows.Forms.TextBox();
			this.btngyekle = new System.Windows.Forms.Button();
			this.btngyguncelle = new System.Windows.Forms.Button();
			this.btngysil = new System.Windows.Forms.Button();
			this.btngylistele = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtgygno = new System.Windows.Forms.TextBox();
			this.back = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
			this.SuspendLayout();
			// 
			// lbl1
			// 
			this.lbl1.AutoSize = true;
			this.lbl1.Location = new System.Drawing.Point(97, 75);
			this.lbl1.Name = "lbl1";
			this.lbl1.Size = new System.Drawing.Size(98, 16);
			this.lbl1.TabIndex = 75;
			this.lbl1.Text = "Gösteri Yeri No";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(97, 195);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 16);
			this.label3.TabIndex = 77;
			this.label3.Text = "Telefon";
			// 
			// DataGrid
			// 
			this.DataGrid.AllowUserToAddRows = false;
			this.DataGrid.AllowUserToDeleteRows = false;
			this.DataGrid.BackgroundColor = System.Drawing.Color.DarkSalmon;
			this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGrid.Location = new System.Drawing.Point(289, 84);
			this.DataGrid.Name = "DataGrid";
			this.DataGrid.ReadOnly = true;
			this.DataGrid.RowHeadersWidth = 51;
			this.DataGrid.RowTemplate.Height = 24;
			this.DataGrid.Size = new System.Drawing.Size(686, 298);
			this.DataGrid.TabIndex = 88;
			// 
			// txtgyno
			// 
			this.txtgyno.Location = new System.Drawing.Point(100, 94);
			this.txtgyno.Name = "txtgyno";
			this.txtgyno.Size = new System.Drawing.Size(137, 22);
			this.txtgyno.TabIndex = 80;
			// 
			// txtgyad
			// 
			this.txtgyad.Location = new System.Drawing.Point(100, 156);
			this.txtgyad.Name = "txtgyad";
			this.txtgyad.Size = new System.Drawing.Size(137, 22);
			this.txtgyad.TabIndex = 81;
			// 
			// txtgytel
			// 
			this.txtgytel.Location = new System.Drawing.Point(100, 214);
			this.txtgytel.Name = "txtgytel";
			this.txtgytel.Size = new System.Drawing.Size(137, 22);
			this.txtgytel.TabIndex = 82;
			// 
			// txtgykoltuk
			// 
			this.txtgykoltuk.Location = new System.Drawing.Point(100, 273);
			this.txtgykoltuk.Name = "txtgykoltuk";
			this.txtgykoltuk.Size = new System.Drawing.Size(137, 22);
			this.txtgykoltuk.TabIndex = 83;
			// 
			// btngyekle
			// 
			this.btngyekle.Location = new System.Drawing.Point(195, 408);
			this.btngyekle.Name = "btngyekle";
			this.btngyekle.Size = new System.Drawing.Size(75, 23);
			this.btngyekle.TabIndex = 84;
			this.btngyekle.Text = "EKLE";
			this.btngyekle.UseVisualStyleBackColor = true;
			this.btngyekle.Click += new System.EventHandler(this.btngyekle_Click);
			// 
			// btngyguncelle
			// 
			this.btngyguncelle.Location = new System.Drawing.Point(443, 408);
			this.btngyguncelle.Name = "btngyguncelle";
			this.btngyguncelle.Size = new System.Drawing.Size(131, 23);
			this.btngyguncelle.TabIndex = 85;
			this.btngyguncelle.Text = "GÜNCELLE";
			this.btngyguncelle.UseVisualStyleBackColor = true;
			this.btngyguncelle.Click += new System.EventHandler(this.btngyguncelle_Click);
			// 
			// btngysil
			// 
			this.btngysil.Location = new System.Drawing.Point(322, 408);
			this.btngysil.Name = "btngysil";
			this.btngysil.Size = new System.Drawing.Size(75, 23);
			this.btngysil.TabIndex = 86;
			this.btngysil.Text = "SİL";
			this.btngysil.UseVisualStyleBackColor = true;
			this.btngysil.Click += new System.EventHandler(this.btngysil_Click);
			// 
			// btngylistele
			// 
			this.btngylistele.Location = new System.Drawing.Point(75, 408);
			this.btngylistele.Name = "btngylistele";
			this.btngylistele.Size = new System.Drawing.Size(84, 23);
			this.btngylistele.TabIndex = 87;
			this.btngylistele.Text = "LİSTELE";
			this.btngylistele.UseVisualStyleBackColor = true;
			this.btngylistele.Click += new System.EventHandler(this.btngylistele_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(420, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(188, 29);
			this.label1.TabIndex = 91;
			this.label1.Text = "GÖSTERİ YERİ";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(97, 137);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(43, 16);
			this.label8.TabIndex = 89;
			this.label8.Text = "Adres";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(97, 253);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(109, 16);
			this.label6.TabIndex = 90;
			this.label6.Text = "Koltuk Kapasitesi";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(-121, 279);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(0, 16);
			this.label5.TabIndex = 79;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(97, 315);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(111, 16);
			this.label2.TabIndex = 93;
			this.label2.Text = "Gösteri Numarası";
			// 
			// txtgygno
			// 
			this.txtgygno.Location = new System.Drawing.Point(100, 335);
			this.txtgygno.Name = "txtgygno";
			this.txtgygno.Size = new System.Drawing.Size(137, 22);
			this.txtgygno.TabIndex = 92;
			// 
			// back
			// 
			this.back.Image = global::Denemezoo2.Properties.Resources.geri;
			this.back.Location = new System.Drawing.Point(12, 9);
			this.back.Name = "back";
			this.back.Size = new System.Drawing.Size(75, 63);
			this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.back.TabIndex = 113;
			this.back.TabStop = false;
			this.back.Click += new System.EventHandler(this.back_Click);
			// 
			// FormGosteriYeri
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Moccasin;
			this.ClientSize = new System.Drawing.Size(987, 468);
			this.Controls.Add(this.back);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtgygno);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.DataGrid);
			this.Controls.Add(this.btngylistele);
			this.Controls.Add(this.btngysil);
			this.Controls.Add(this.btngyguncelle);
			this.Controls.Add(this.btngyekle);
			this.Controls.Add(this.txtgykoltuk);
			this.Controls.Add(this.txtgytel);
			this.Controls.Add(this.txtgyad);
			this.Controls.Add(this.txtgyno);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lbl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormGosteriYeri";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormGosteriYeri";
			this.Load += new System.EventHandler(this.FormGosteriYeri_Load);
			((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView DataGrid;
		private System.Windows.Forms.TextBox txtgyno;
		private System.Windows.Forms.TextBox txtgyad;
		private System.Windows.Forms.TextBox txtgytel;
		private System.Windows.Forms.TextBox txtgykoltuk;
		private System.Windows.Forms.Button btngyekle;
		private System.Windows.Forms.Button btngyguncelle;
		private System.Windows.Forms.Button btngysil;
		private System.Windows.Forms.Button btngylistele;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtgygno;
		private System.Windows.Forms.PictureBox back;
	}
}