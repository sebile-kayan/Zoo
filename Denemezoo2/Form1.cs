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
	public partial class Form1 : Form
	{
		SqlCommand komut;

		public Form1()
		{
			InitializeComponent();
		}


		static string constring = ("Data Source=DESKTOP-OSNDT9I\\SQLEXPRESS;Initial Catalog=Denemezoo2;Integrated Security=True;");
		SqlConnection baglan = new SqlConnection(constring);



		private void Form1_Load(object sender, EventArgs e)
		{

		}

		public void Kayitgetir()
		{
			string getir = "Select * from Hayvan";
			SqlCommand komut = new SqlCommand(getir,baglan);
			SqlDataAdapter ad = new SqlDataAdapter(komut);
			DataTable dt=new DataTable();
			ad.Fill(dt);
			DataGrid.DataSource = dt;

			baglan.Close();
		}

		private void btnhekle_Click(object sender, EventArgs e)
		{
			try
			{
				if(baglan.State==ConnectionState.Closed)
				{
					baglan.Open();
					string kayit= "INSERT INTO Hayvan (hayvankodu, hayvanadi, hayvanyas,cinsi,cinsiyet,egitmennum) VALUES (@kodu, @ad, @yas, @cins, @cinsiyet, @hegitmennum)";
					SqlCommand komut = new SqlCommand(kayit, baglan);
					komut.Parameters.AddWithValue("@kodu", txthysid.Text);
					komut.Parameters.AddWithValue("@ad", txthysad.Text);
					komut.Parameters.AddWithValue("@cinsiyet", txthyscinsiyet.Text);
					komut.Parameters.AddWithValue("@cins", txthyscins.Text);
					komut.Parameters.AddWithValue("@yas", txthysyas.Text);
					komut.Parameters.AddWithValue("@hegitmennum", txthysegitmennum.Text);

					komut.ExecuteNonQuery();

					MessageBox.Show("Kayıt ekleme başarılı");
					Kayitgetir();
				}

			}
			catch(Exception ex)
			{MessageBox.Show(ex.Message);

			}
		}

		private void btnhlistele_Click(object sender, EventArgs e)
		{
			Kayitgetir();	
		}

		private void btnhsil_Click(object sender, EventArgs e)
		{

			string sorgu = "DELETE FROM Hayvan WHERE hayvankodu=@kodu";
			komut = new SqlCommand(sorgu, baglan);
			komut.Parameters.AddWithValue("@kodu", txthysid.Text);
			baglan.Open();
			komut.ExecuteNonQuery();
			baglan.Close();
			Kayitgetir();
		}

		private void btnhguncelle_Click(object sender, EventArgs e)
		{
			string sorgu = "UPDATE Hayvan SET hayvankodu=@kodu,hayvanadi=@ad,hayvanyas=@yas,cinsi=@cins,cinsiyet=@cinsiyet WHERE hayvankodu=@kodu";
			komut = new SqlCommand(sorgu, baglan);
			komut.Parameters.AddWithValue("@kodu", txthysid.Text);
			komut.Parameters.AddWithValue("@ad", txthysad.Text);
			komut.Parameters.AddWithValue("@cinsiyet", txthyscinsiyet.Text);
			komut.Parameters.AddWithValue("@cins", txthyscins.Text);
			komut.Parameters.AddWithValue("@yas", txthysyas.Text);
			baglan.Open();
			komut.ExecuteNonQuery();
			baglan.Close();
			Kayitgetir();
		}

		private void back_Click(object sender, EventArgs e)
		{
			Yonlen Bislem = new Yonlen();
			Bislem.Show();
			this.Hide();
		}
	}
}
