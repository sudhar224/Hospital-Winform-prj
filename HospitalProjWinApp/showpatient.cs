using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace HospitalProjWinApp
{
	public partial class showpatient : Form
	{
		//static string connectionString = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
		public showpatient()
		{
			InitializeComponent();
		}
	
		

		private void button1_Click(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection("Data Source = DESKTOP-7TUTM2S\\SQLEXPRESS; Initial Catalog = Hospital; Integrated Security = true;");
			
			con.Open();
			SqlCommand cmd = new SqlCommand("sp_showpatient", con);
			cmd.CommandType = CommandType.StoredProcedure;

			SqlDataAdapter sda = new SqlDataAdapter(cmd);
			DataSet ds = new DataSet();
			sda.Fill(ds);

			dataGridView1.DataSource = ds.Tables[0];
			con.Close();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Home homeobj = new Home();
			homeobj.Show();
			this.Hide();
		}
	}
}
