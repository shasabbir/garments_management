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

namespace GMS
{
    
    public partial class Form1 : Form
    {
        string lAid,empid;

        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection sq = new SqlConnection("Data Source=DESKTOP-KORGD9I;Initial Catalog=GMS;Persist Security Info=True;User ID=sa;Password=root");

        private void button1_Click(object sender, EventArgs e)
        {
            if (userField.Text == "" && passwordField.Text == "")
            {
                MessageBox.Show("You haven't inserted id or password");
            }
            else
            {
                sq.Open();
                SqlCommand cmd = sq.CreateCommand();

                if (userField.Text[0] == 'a')
                {
                    lAid = userField.Text;
                    cmd.CommandText = "SELECT password FROM admin WHERE aid='" + userField.Text + "'";
                    string result = ((string)cmd.ExecuteScalar());
                    if (result == passwordField.Text)
                    {
                        //MessageBox.Show("You Are logged in");
                        AdminForm adminForm = new AdminForm(lAid);
                        adminForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Id or Password");
                    }
                    sq.Close();
                }
                else if (userField.Text[0] == 'e')
                {
                    empid = userField.Text;
                    cmd.CommandText = "SELECT Password FROM emp WHERE eid='" + userField.Text + "'";
                    string result = ((string)cmd.ExecuteScalar());
                    if (result == passwordField.Text)
                    {
                        //MessageBox.Show("You Are logged in");
                        EmployeeForm empform = new EmployeeForm(empid);
                        empform.Show();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Id or Password");
                    }
                    sq.Close();
                }
                else
                {
                    MessageBox.Show("Wrong Id or Password");
                    sq.Close();
                }
            }
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword.Checked)
            {
                passwordField.UseSystemPasswordChar = true;

            }
            else
            {
                passwordField.UseSystemPasswordChar = false;

            }
        }

        private void greetingsLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
