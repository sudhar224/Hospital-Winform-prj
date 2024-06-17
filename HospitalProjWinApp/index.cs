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
using System.Configuration;
using System.Linq.Expressions;

namespace HospitalProjWinApp

{
	public partial class index : Form
	{


		public index()
		{
			InitializeComponent();
		}

		static string connectionString = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
		SqlConnection con = new SqlConnection(connectionString);

		
		private void button1_Click(object sender, EventArgs e)
		{
			try { 

			con.Open();
				SqlCommand cmd = new SqlCommand("sp_indexpage", con);
				cmd.CommandType = CommandType.StoredProcedure;

				SqlParameter p1 = new SqlParameter("@name",SqlDbType.VarChar);
				cmd.Parameters.Add(p1).Value = txt_name.Text.Trim();

				SqlParameter p2 = new SqlParameter("@password", SqlDbType.VarChar);
				cmd.Parameters.Add(p2).Value = txt_pwd.Text.Trim();

				SqlDataAdapter sda = new SqlDataAdapter(cmd);
				DataSet ds = new DataSet();
				sda.Fill(ds);

				int a = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
				if(a>0)
				{
					MessageBox.Show("login success");
					showdoctor add = new showdoctor();
					add.Show();
					this.Hide();
				}
				else
				{
					MessageBox.Show("login fail");

					this.Close();
				}

			}
			catch(Exception ex)
			{
				MessageBox.Show("An error occurred: " + ex.Message);
				con.Close();
			}
			
			
		}
		


		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void txt_name_TextChanged(object sender, EventArgs e)
		{

		}

		private void txt_pwd_TextChanged(object sender, EventArgs e)
		{

		}

	}
}
