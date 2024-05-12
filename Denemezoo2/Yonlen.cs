using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Denemezoo2
{
	public partial class Yonlen : Form
	{
		public Yonlen()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void sechayvan_Click(object sender, EventArgs e)
		{
			Form1 hislem = new Form1();
			hislem.Show();
			this.Hide();
		}

		private void secegitmen_Click(object sender, EventArgs e)
		{
			Formegitmen eislem = new Formegitmen();
			eislem.Show();
			this.Hide();
		}

		private void secgosteri_Click(object sender, EventArgs e)
		{
			FormGosteri gislem = new FormGosteri();
			gislem.Show();
			this.Hide();
		}

		private void secgosteriyeri_Click(object sender, EventArgs e)
		{
			FormGosteriYeri gyislem = new FormGosteriYeri();
			gyislem.Show();
			this.Hide();
		}

		private void secbilet_Click(object sender, EventArgs e)
		{
			FormBilet Bislem = new FormBilet();
			Bislem.Show();
			this.Hide();
		}

		private void Yonlen_Load(object sender, EventArgs e)
		{

		}

		private void back_Click(object sender, EventArgs e)
		{
			Giris gislem = new Giris();
			gislem.Show();
			this.Hide();
		}
	}
	
	}

