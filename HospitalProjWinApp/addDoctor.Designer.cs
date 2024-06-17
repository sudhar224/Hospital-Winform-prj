namespace HospitalProjWinApp
{
	partial class addDoctor
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.name = new System.Windows.Forms.Label();
			this.age = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_docname = new System.Windows.Forms.TextBox();
			this.txt_age = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// name
			// 
			this.name.AutoSize = true;
			this.name.Location = new System.Drawing.Point(301, 96);
			this.name.Name = "name";
			this.name.Size = new System.Drawing.Size(70, 13);
			this.name.TabIndex = 0;
			this.name.Text = "Doctor Name\r\n";
			// 
			// age
			// 
			this.age.AutoSize = true;
			this.age.Location = new System.Drawing.Point(325, 150);
			this.age.Name = "age";
			this.age.Size = new System.Drawing.Size(26, 13);
			this.age.TabIndex = 1;
			this.age.Text = "Age";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.LightCoral;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label3.Location = new System.Drawing.Point(404, 29);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(119, 25);
			this.label3.TabIndex = 2;
			this.label3.Text = "Add Doctor";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txt_docname
			// 
			this.txt_docname.Location = new System.Drawing.Point(395, 93);
			this.txt_docname.Name = "txt_docname";
			this.txt_docname.Size = new System.Drawing.Size(178, 20);
			this.txt_docname.TabIndex = 3;
			// 
			// txt_age
			// 
			this.txt_age.Location = new System.Drawing.Point(395, 143);
			this.txt_age.Name = "txt_age";
			this.txt_age.Size = new System.Drawing.Size(178, 20);
			this.txt_age.TabIndex = 4;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(395, 191);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "Submit";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(514, 191);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 6;
			this.button2.Text = "Cancel";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkLabel1.Location = new System.Drawing.Point(649, 29);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(45, 20);
			this.linkLabel1.TabIndex = 7;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Back";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// addDoctor
			// 
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Coral;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txt_age);
			this.Controls.Add(this.txt_docname);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.age);
			this.Controls.Add(this.name);
			this.Name = "addDoctor";
			this.Text = "addDoctor";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label name;
		private System.Windows.Forms.Label age;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_docname;
		private System.Windows.Forms.TextBox txt_age;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.LinkLabel linkLabel1;
	}
}