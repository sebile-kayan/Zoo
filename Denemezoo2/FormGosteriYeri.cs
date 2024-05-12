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
	public partial class FormGosteriYeri : Form
	{
		SqlCommand komut;
		public FormGosteriYeri()
		{
			InitializeComponent();
		}

		static string constring = ("Data Source=DESKTOP-OSNDT9I\\SQLEXPRESS;Initial Catalog=Denemezoo2;Integrated Security=True;");
		SqlConnection baglan = new SqlConnection(constring);
		private void FormGosteriYeri_Load(object sender, EventArgs e)
		{

		}
		public void Kayitgetirgy()
		{
			string getir = "Select * from GosteriYeri";
			SqlCommand komut = new SqlCommand(getir, baglan);
			SqlDataAdapter ad = new SqlDataAdapter(komut);
			DataTable dt = new DataTable();
			ad.Fill(dt);
			DataGrid.DataSource = dt;
			baglan.Close();
		}

		private void btngylistele_Click(object sender, EventArgs e)
		{

			Kayitgetirgy();
		}

		private void btngyekle_Click(object sender, EventArgs e)
		{
			try
			{
				if (baglan.State == ConnectionState.Closed)
				{
					baglan.Open();
					string kayit = "INSERT INTO GosteriYeri (yernumarasi, gosteriadres, gosteritel,koltukkapasitesi,gosterinum) VALUES (@no, @adres, @tel, @kapasitesi,@gnum)";
					SqlCommand komut = new SqlCommand(kayit, baglan);
					komut.Parameters.AddWithValue("@no", txtgyno.Text);
					komut.Parameters.AddWithValue("@adres", txtgyad.Text);
					komut.Parameters.AddWithValue("@tel", txtgytel.Text);
					komut.Parameters.AddWithValue("@kapasitesi", txtgykoltuk.Text);
					komut.Parameters.AddWithValue("@gnum", txtgygno.Text);

					komut.ExecuteNonQuery();

					MessageBox.Show("Kayıt ekleme başarılı");
					Kayitgetirgy();
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);

			}
		}

		private void btngysil_Click(object sender, EventArgs e)
		{
			string sorgu = "DELETE FROM GosteriYeri WHERE yernumarasi=@no";
			komut = new SqlCommand(sorgu, baglan);
			komut.Parameters.AddWithValue("@no", txtgyno.Text);
			baglan.Open();
			komut.ExecuteNonQuery();
			baglan.Close();
			Kayitgetirgy();
		}

		private void btngyguncelle_Click(object sender, EventArgs e)
		{
			string sorgu = "UPDATE GosteriYeri SET yernumarasi=@no,gosteriadres=@adres,gosteritel=@tel,koltukkapasitesi=@kapasitesi,gosterinum=@gnum WHERE yernumarasi=@no";
			komut = new SqlCommand(sorgu, baglan);
			komut.Parameters.AddWithValue("@no", txtgyno.Text);
			komut.Parameters.AddWithValue("@adres", txtgyad.Text);
			komut.Parameters.AddWithValue("@tel", txtgytel.Text);
			komut.Parameters.AddWithValue("@kapasitesi", txtgykoltuk.Text);
			komut.Parameters.AddWithValue("@gnum", txtgygno.Text);
			baglan.Open();
			komut.ExecuteNonQuery();
			baglan.Close();
			Kayitgetirgy();
		}

		private void back_Click(object sender, EventArgs e)
		{
			Yonlen Bislem = new Yonlen();
			Bislem.Show();
			this.Hide();
		}
	}
}
