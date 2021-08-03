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
    public partial class EditAdminProfileForm : Form
    {
        string aid;
        public EditAdminProfileForm()
        {
            InitializeComponent();
        }
        public EditAdminProfileForm(string s)
        {
            aid = s;
            InitializeComponent();
        }
        void clear()
        {
            updateAdminNameTextBox.Text = "";
            updateAdminPasswordTextBox.Text = "";
            updateAdminSalaryTextBox.Text = "";
            updateAdminEmailTextBox.Text = "";
            updateAdminPhoneTextBox.Text = "";
            updateAdminAddressTextBox.Text = "";
        }
        SqlConnection sq = new SqlConnection("Data Source=DESKTOP-KORGD9I;Initial Catalog=GMS;Persist Security Info=True;User ID=sa;Password=root");
        private void updateAdminEnterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (updateAdminNameTextBox.Text == "" && updateAdminPasswordTextBox.Text == "" && updateAdminSalaryTextBox.Text == "" && updateAdminEmailTextBox.Text == "" && updateAdminPhoneTextBox.Text == "" && updateAdminAddressTextBox.Text == "")
                {
                    MessageBox.Show("Recheck your information");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("UPDATE admin SET name = @name, password = @password, salary = @salary, email = @email, phone = @phone, address = @address WHERE aid = '" + this.aid + "'", sq);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@name", updateAdminNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@password", updateAdminPasswordTextBox.Text);
                    cmd.Parameters.AddWithValue("@salary", int.Parse(updateAdminSalaryTextBox.Text));
                    cmd.Parameters.AddWithValue("@email", updateAdminEmailTextBox.Text);
                    cmd.Parameters.AddWithValue("@phone", updateAdminPhoneTextBox.Text);
                    cmd.Parameters.AddWithValue("@address", updateAdminAddressTextBox.Text);
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
