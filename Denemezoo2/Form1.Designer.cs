namespace Denemezoo2
{
	partial class Form1
	{
		/// <summary>
		///Gerekli tasarımcı değişkeni.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///Kullanılan tüm kaynakları temizleyin.
		/// </summary>
		///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer üretilen kod

		/// <summary>
		/// Tasarımcı desteği için gerekli metot - bu metodun 
		///içeriğini kod düzenleyici ile değiştirmeyin.
		/// </summary>
		private void InitializeComponent()
		{
			this.txthysegitmennum = new System.Windows.Forms.TextBox();
			this.labella = new System.Windows.Forms.Label();
			this.DataGrid = new System.Windows.Forms.DataGridView();
			this.btnhlistele = new System.Windows.Forms.Button();
			this.btnhsil = new System.Windows.Forms.Button();
			this.btnhguncelle = new System.Windows.Forms.Button();
			this.btnhekle = new System.Windows.Forms.Button();
			this.txthysyas = new System.Windows.Forms.TextBox();
			this.txthyscins = new System.Windows.Forms.TextBox();
			this.txthyscinsiyet = new System.Windows.Forms.TextBox();
			this.txthysad = new System.Windows.Forms.TextBox();
			this.txthysid = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.back = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
			this.SuspendLayout();
			// 
			// txthysegitmennum
			// 
			this.txthysegitmennum.Location = new System.Drawing.Point(105, 366);
			this.txthysegitmennum.Name = "txthysegitmennum";
			this.txthysegitmennum.Size = new System.Drawing.Size(137, 22);
			this.txthysegitmennum.TabIndex = 33;
			// 
			// labella
			// 
			this.labella.AutoSize = true;
			this.labella.Location = new System.Drawing.Point(102, 347);
			this.labella.Name = "labella";
			this.labella.Size = new System.Drawing.Size(74, 16);
			this.labella.TabIndex = 32;
			this.labella.Text = "Eğitmen no";
			// 
			// DataGrid
			// 
			this.DataGrid.AllowUserToAddRows = false;
			this.DataGrid.AllowUserToDeleteRows = false;
			this.DataGrid.BackgroundColor = System.Drawing.Color.DarkSalmon;
			this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGrid.Location = new System.Drawing.Point(316, 56);
			this.DataGrid.Name = "DataGrid";
			this.DataGrid.ReadOnly = true;
			this.DataGrid.RowHeadersWidth = 51;
			this.DataGrid.RowTemplate.Height = 24;
			this.DataGrid.Size = new System.Drawing.Size(632, 307);
			this.DataGrid.TabIndex = 31;
			// 
			// btnhlistele
			// 
			this.btnhlistele.Location = new System.Drawing.Point(37, 415);
			this.btnhlistele.Name = "btnhlistele";
			this.btnhlistele.Size = new System.Drawing.Size(84, 23);
			this.btnhlistele.TabIndex = 30;
			this.btnhlistele.Text = "LİSTELE";
			this.btnhlistele.UseVisualStyleBackColor = true;
			this.btnhlistele.Click += new System.EventHandler(this.btnhlistele_Click);
			// 
			// btnhsil
			// 
			this.btnhsil.Location = new System.Drawing.Point(284, 415);
			this.btnhsil.Name = "btnhsil";
			this.btnhsil.Size = new System.Drawing.Size(75, 23);
			this.btnhsil.TabIndex = 29;
			this.btnhsil.Text = "SİL";
			this.btnhsil.UseVisualStyleBackColor = true;
			this.btnhsil.Click += new System.EventHandler(this.btnhsil_Click);
			// 
			// btnhguncelle
			// 
			this.btnhguncelle.Location = new System.Drawing.Point(405, 415);
			this.btnhguncelle.Name = "btnhguncelle";
			this.btnhguncelle.Size = new System.Drawing.Size(131, 23);
			this.btnhguncelle.TabIndex = 28;
			this.btnhguncelle.Text = "GÜNCELLE";
			this.btnhguncelle.UseVisualStyleBackColor = true;
			this.btnhguncelle.Click += new System.EventHandler(this.btnhguncelle_Click);
			// 
			// btnhekle
			// 
			this.btnhekle.Location = new System.Drawing.Point(157, 415);
			this.btnhekle.Name = "btnhekle";
			this.btnhekle.Size = new System.Drawing.Size(75, 23);
			this.btnhekle.TabIndex = 27;
			this.btnhekle.Text = "EKLE";
			this.btnhekle.UseVisualStyleBackColor = true;
			this.btnhekle.Click += new System.EventHandler(this.btnhekle_Click);
			// 
			// txthysyas
			// 
			this.txthysyas.Location = new System.Drawing.Point(105, 293);
			this.txthysyas.Name = "txthysyas";
			this.txthysyas.Size = new System.Drawing.Size(137, 22);
			this.txthysyas.TabIndex = 26;
			// 
			// txthyscins
			// 
			this.txthyscins.Location = new System.Drawing.Point(105, 230);
			this.txthyscins.Name = "txthyscins";
			this.txthyscins.Size = new System.Drawing.Size(137, 22);
			this.txthyscins.TabIndex = 25;
			// 
			// txthyscinsiyet
			// 
			this.txthyscinsiyet.Location = new System.Drawing.Point(105, 161);
			this.txthyscinsiyet.Name = "txthyscinsiyet";
			this.txthyscinsiyet.Size = new System.Drawing.Size(137, 22);
			this.txthyscinsiyet.TabIndex = 24;
			// 
			// txthysad
			// 
			this.txthysad.Location = new System.Drawing.Point(105, 103);
			this.txthysad.Name = "txthysad";
			this.txthysad.Size = new System.Drawing.Size(137, 22);
			this.txthysad.TabIndex = 23;
			// 
			// txthysid
			// 
			this.txthysid.Location = new System.Drawing.Point(105, 41);
			this.txthysid.Name = "txthysid";
			this.txthysid.Size = new System.Drawing.Size(137, 22);
			this.txthysid.TabIndex = 22;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(-119, 281);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(31, 16);
			this.label5.TabIndex = 21;
			this.label5.Text = "Yaş";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(-119, 224);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(36, 16);
			this.label4.TabIndex = 20;
			this.label4.Text = "Cinsi";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(102, 142);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 16);
			this.label3.TabIndex = 19;
			this.label3.Text = "Cinsiyet";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(-119, 106);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(27, 16);
			this.label2.TabIndex = 18;
			this.label2.Text = "Adı";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(102, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 16);
			this.label1.TabIndex = 17;
			this.label1.Text = "Hayvan İD";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(102, 273);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(31, 16);
			this.label6.TabIndex = 36;
			this.label6.Text = "Yaş";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(102, 216);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(36, 16);
			this.label7.TabIndex = 35;
			this.label7.Text = "Cinsi";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(102, 84);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(27, 16);
			this.label8.TabIndex = 34;
			this.label8.Text = "Adı";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label9.Location = new System.Drawing.Point(484, 11);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(116, 29);
			this.label9.TabIndex = 58;
			this.label9.Text = "HAYVAN";
			// 
			// back
			// 
			this.back.Image = global::Denemezoo2.Properties.Resources.geri;
			this.back.Location = new System.Drawing.Point(12, 19);
			this.back.Name = "back";
			this.back.Size = new System.Drawing.Size(62, 50);
			this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.back.TabIndex = 59;
			this.back.TabStop = false;
			this.back.Click += new System.EventHandler(this.back_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Moccasin;
			this.ClientSize = new System.Drawing.Size(987, 468);
			this.Controls.Add(this.back);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txthysegitmennum);
			this.Controls.Add(this.labella);
			this.Controls.Add(this.DataGrid);
			this.Controls.Add(this.btnhlistele);
			this.Controls.Add(this.btnhsil);
			this.Controls.Add(this.btnhguncelle);
			this.Controls.Add(this.btnhekle);
			this.Controls.Add(this.txthysyas);
			this.Controls.Add(this.txthyscins);
			this.Controls.Add(this.txthyscinsiyet);
			this.Controls.Add(this.txthysad);
			this.Controls.Add(this.txthysid);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txthysegitmennum;
		private System.Windows.Forms.Label labella;
		private System.Windows.Forms.DataGridView DataGrid;
		private System.Windows.Forms.Button btnhlistele;
		private System.Windows.Forms.Button btnhsil;
		private System.Windows.Forms.Button btnhguncelle;
		private System.Windows.Forms.Button btnhekle;
		private System.Windows.Forms.TextBox txthysyas;
		private System.Windows.Forms.TextBox txthyscins;
		private System.Windows.Forms.TextBox txthyscinsiyet;
		private System.Windows.Forms.TextBox txthysad;
		private System.Windows.Forms.TextBox txthysid;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.PictureBox back;
	}
}

