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

namespace HospitalProjWinApp
{
	public partial class addDoctor : Form
	{
		public addDoctor()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection("Data Source = DESKTOP-7TUTM2S\\SQLEXPRESS; Initial Catalog = Hospital; Integrated Security = true;");
			con.Open();
			SqlCommand cmd = new SqlCommand("sp_doctordata", con);
			cmd.CommandType = CommandType.StoredProcedure;
			SqlParameter p1 = new SqlParameter("@doctorname", SqlDbType.VarChar);
			cmd.Parameters.Add(p1).Value = txt_docname.Text.Trim();
			SqlParameter p2 = new SqlParameter("@age", SqlDbType.Int);
			cmd.Parameters.Add(p2).Value = txt_age.Text.Trim();
			int i = cmd.ExecuteNonQuery();
			if(i>0)
			{
				MessageBox.Show("doctorName added");
			}
			else
			{
				MessageBox.Show("Not added");
			}

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
