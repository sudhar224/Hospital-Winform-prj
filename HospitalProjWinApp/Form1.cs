using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
namespace HospitalProjWinApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void txt_uname_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		static string connectionString = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
		SqlConnection con = new SqlConnection(connectionString);
		private void button3_Click(object sender, EventArgs e)
		{
			try
			{
				con.Open();
				SqlCommand cmd = new SqlCommand("sp_insertdata", con);
				cmd.CommandType = CommandType.StoredProcedure;

				SqlParameter p1 = new SqlParameter("@name",SqlDbType.VarChar);
				cmd.Parameters.Add(p1).Value = txt_patientname.Text.Trim();
				SqlParameter p2 = new SqlParameter("@age", SqlDbType.Int);
				cmd.Parameters.Add(p2).Value = txt_age.Text.Trim();

				int a = cmd.ExecuteNonQuery();

				if(a > 0)
				{
					MessageBox.Show("patient added");
				}
				else
				{
					MessageBox.Show("patient not added");
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show("exception error");
				con.Close();
			}

		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Home homeobj = new Home();
			homeobj.Show();
			this.Hide();
		}
	}
}
