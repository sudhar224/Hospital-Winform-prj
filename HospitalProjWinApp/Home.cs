using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace HospitalProjWinApp
{
	public partial class Home : Form
	{
		public Home()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form1 addpatientobj = new Form1();
			addpatientobj.Show();
			this.Hide();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			addDoctor doctoraddobj = new addDoctor();
			doctoraddobj.Show(); 
			this.Hide();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			showpatient patientshowobj = new showpatient();
			patientshowobj.Show();
			this.Hide();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			showdoctor doctorshowobj = new showdoctor();
			doctorshowobj.Show();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Login loginobj = new Login();
			loginobj.Show();
			this.Hide();
		}
	}
}
