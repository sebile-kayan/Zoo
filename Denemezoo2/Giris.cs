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
	public partial class Giris : Form
	{
		public Giris()
		{
			InitializeComponent();
		}

		private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
		{

		}

		private void Giris_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			Yonlen yislem = new Yonlen();
			yislem.Show();
			this.Hide();	
		}
	}
}
