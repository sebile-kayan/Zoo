using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Denemezoo2
{
	public partial class Formegitmen : Form
	{
		SqlCommand komut;

		public Formegitmen()
		{
			InitializeComponent();
		}


		static string constring = ("Data Source=DESKTOP-OSNDT9I\\SQLEXPRESS;Initial Catalog=Denemezoo2;Integrated Security=True;");
		SqlConnection baglan = new SqlConnection(constring);



		
		public void Kayitgetire()
		{
			string getir = "Select * from Egitmen";
			SqlCommand komut = new SqlCommand(getir, baglan);
			SqlDataAdapter ad = new SqlDataAdapter(komut);
			DataTable dt = new DataTable();
			ad.Fill(dt);
			DataGrid.DataSource = dt;
			baglan.Close();
		}

	

		
	
		private void Formegitmen_Load(object sender, EventArgs e)
		{

		}

		private void btneekle_Click(object sender, EventArgs e)
		{

			try
			{
				if (baglan.State == ConnectionState.Closed)
				{
					baglan.Open();
					string kayit = "INSERT INTO Egitmen (egitmenno, egitmenad, egitmentel,egitmenyas) VALUES (@no, @ad, @tel, @yas)";
					SqlCommand komut = new SqlCommand(kayit, baglan);
					komut.Parameters.AddWithValue("@no", txteno.Text);
					komut.Parameters.AddWithValue("@ad", txtead.Text);
					komut.Parameters.AddWithValue("@tel", txtetel.Text);
					komut.Parameters.AddWithValue("@yas", txteyas.Text);

					komut.ExecuteNonQuery();

					MessageBox.Show("Kayıt ekleme başarılı");
					Kayitgetire();
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);

			}
		}

		private void btnesil_Click(object sender, EventArgs e)
		{
			string sorgu = "DELETE FROM Egitmen WHERE egitmenno=@no";
			komut = new SqlCommand(sorgu, baglan);
			komut.Parameters.AddWithValue("@no", txteno.Text);
			baglan.Open();
			komut.ExecuteNonQuery();
			baglan.Close();
			Kayitgetire();
		}

		private void btneguncelle_Click(object sender, EventArgs e)
		{
			string sorgu = "UPDATE Egitmen SET egitmenno=@no,egitmenad=@ad,egitmentel=@tel,egitmenyas=@yas WHERE egitmenno=@no";
			komut = new SqlCommand(sorgu, baglan);
			komut.Parameters.AddWithValue("@no", txteno.Text);
			komut.Parameters.AddWithValue("@ad", txtead.Text);
			komut.Parameters.AddWithValue("@tel", txtetel.Text);
			komut.Parameters.AddWithValue("@yas", txteyas.Text);
			baglan.Open();
			komut.ExecuteNonQuery();
			baglan.Close();
			Kayitgetire();
		}

		private void btnelistele_Click(object sender, EventArgs e)
		{
			Kayitgetire();
		}

		private void back_Click(object sender, EventArgs e)
		{
			Yonlen Bislem = new Yonlen();
			Bislem.Show();
			this.Hide();
		}
	}
}
