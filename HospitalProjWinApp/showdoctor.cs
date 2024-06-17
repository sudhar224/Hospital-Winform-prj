using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalProjWinApp
{
	public partial class showdoctor : Form
	{
		public showdoctor()
		{
			InitializeComponent();
		}

		//static string connectionString = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
		//SqlConnection con = new SqlConnection(connectionString);
		private void button1_Click(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection("Data Source = DESKTOP-7TUTM2S\\SQLEXPRESS; Initial Catalog = Hospital; Integrated Security = true;");
			con.Open();
			SqlCommand cmd = new SqlCommand("sp_showdata", con);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataSet ds = new DataSet();

			da.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Home homeobj = new Home();
			homeobj.Show();
			this.Hide();
		}
	}
}
