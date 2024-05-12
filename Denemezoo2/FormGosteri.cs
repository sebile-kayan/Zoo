using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Denemezoo2
{
	public partial class FormGosteri : Form
	{
		SqlCommand komut;
		public FormGosteri()
		{
			InitializeComponent();
		}


		static string constring = ("Data Source=DESKTOP-OSNDT9I\\SQLEXPRESS;Initial Catalog=Denemezoo2;Integrated Security=True;");
		SqlConnection baglan = new SqlConnection(constring);

		private void FormGosteri_Load(object sender, EventArgs e)
		{

		}

		public void Kayitgetirg()
		{
			string getir = "Select * from Gosteri";
			SqlCommand komut = new SqlCommand(getir, baglan);
			SqlDataAdapter ad = new SqlDataAdapter(komut);
			DataTable dt = new DataTable();
			ad.Fill(dt);
			DataGrid.DataSource = dt;
			baglan.Close();
		}

		private void btnglistele_Click(object sender, EventArgs e)
		{

			Kayitgetirg();
		}

		private void btngekle_Click(object sender, EventArgs e)
		{

			try
			{
				if (baglan.State == ConnectionState.Closed)
				{
					baglan.Open();
					string kayit = "INSERT INTO Gosteri (gosterino, gosteriadi, gosterisaati,gosteritarihi) VALUES (@no, @ad, @saat, @tarih)";
					SqlCommand komut = new SqlCommand(kayit, baglan);
					komut.Parameters.AddWithValue("@no", txtgno.Text);
					komut.Parameters.AddWithValue("@ad", txtgad.Text);
					komut.Parameters.AddWithValue("@saat", txtgsaat.Text);
					komut.Parameters.AddWithValue("@tarih", txtgtarih.Text);

					komut.ExecuteNonQuery();

					MessageBox.Show("Kayıt ekleme başarılı");
					Kayitgetirg();
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);

			}
		}

		private void btngsil_Click(object sender, EventArgs e)
		{
			string sorgu = "DELETE FROM Gosteri WHERE gosterino=@no";
			komut = new SqlCommand(sorgu, baglan);
			komut.Parameters.AddWithValue("@no", txtgno.Text);
			baglan.Open();
			komut.ExecuteNonQuery();
			baglan.Close();
			Kayitgetirg();
		}

		private void btngguncelle_Click(object sender, EventArgs e)
		{
			string sorgu = "UPDATE Gosteri SET gosterino=@no,gosteriadi=@ad,gosterisaati=@saat,gosteritarihi=@tarih WHERE gosterino=@no";
			komut = new SqlCommand(sorgu, baglan);
			komut.Parameters.AddWithValue("@no", txtgno.Text);
			komut.Parameters.AddWithValue("@ad", txtgad.Text);
			komut.Parameters.AddWithValue("@saat", txtgsaat.Text);
			komut.Parameters.AddWithValue("@tarih", txtgtarih.Text);
			baglan.Open();
			komut.ExecuteNonQuery();
			baglan.Close();
			Kayitgetirg();
		}

		private void back_Click(object sender, EventArgs e)
		{
			Yonlen Bislem = new Yonlen();
			Bislem.Show();
			this.Hide();
		}
	}
}
