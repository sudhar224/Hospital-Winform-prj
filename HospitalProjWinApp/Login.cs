using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalProjWinApp
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (txt_uname.Text == "a" && txt_pwd.Text == "b")
			{
				MessageBox.Show("Login success");
				Home homeobj = new Home();
				homeobj.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Invaild username or pwd");

			}
		
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
