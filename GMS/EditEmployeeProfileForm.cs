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
    public partial class EditEmployeeProfileForm : Form
    {
        string eid;
        public EditEmployeeProfileForm()
        {
            InitializeComponent();
        }
        public EditEmployeeProfileForm(string s)
        {
            eid = s;
            InitializeComponent();
        }
        void clear()
        {
            updateEmployeeNameTextBox.Text = "";
            updateEmployeePasswordTextBox.Text = "";
            updateEmployeeSalaryTextBox.Text = "";
            updateEmployeeEmailTextBox.Text = "";
            updateEmployeePhoneTextBox.Text = "";
            updateEmployeeAddressTextBox.Text = "";
        }
        SqlConnection sq = new SqlConnection("Data Source=DESKTOP-KORGD9I;Initial Catalog=GMS;Persist Security Info=True;User ID=sa;Password=root");
        private void updateEmployeeEnterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (updateEmployeeNameTextBox.Text == "" && updateEmployeePasswordTextBox.Text == "" && updateEmployeeSalaryTextBox.Text == "" && updateEmployeeEmailTextBox.Text == "" && updateEmployeePhoneTextBox.Text == "" && updateEmployeeAddressTextBox.Text == "")
                {
                    MessageBox.Show("Recheck your information");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("UPDATE emp SET name = @name, password = @password, salary = @salary, email = @email, phone = @phone, address = @address WHERE eid = '" + this.eid + "'", sq);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@name", updateEmployeeNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@password", updateEmployeePasswordTextBox.Text);
                    cmd.Parameters.AddWithValue("@salary", updateEmployeeSalaryTextBox.Text);
                    cmd.Parameters.AddWithValue("@email", updateEmployeeEmailTextBox.Text);
                    cmd.Parameters.AddWithValue("@phone", updateEmployeePhoneTextBox.Text);
                    cmd.Parameters.AddWithValue("@address", updateEmployeeAddressTextBox.Text);
                    sq.Open();
                    cmd.ExecuteNonQuery();
                    clear();
                    MessageBox.Show("Details updated!");
                    sq.Close();
                }
            }
            catch
            {
                MessageBox.Show("Wrong Information");
                this.Close();
            }
        }
    }
}
