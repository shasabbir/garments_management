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
    public partial class EnterEmployeeForm : Form
    {
        public EnterEmployeeForm()
        {
            InitializeComponent();
        }
        SqlConnection sq = new SqlConnection("Data Source=DESKTOP-KORGD9I;Initial Catalog=GMS;Persist Security Info=True;User ID=sa;Password=root");

        void clear()
        {
            enterIdTextBox.Text = "";
            enterPasswordTextBox.Text = "";
            enterNameTextBox.Text = "";
            enterNameTextBox.Text = "";
            enterSalaryTextBox.Text = "";
            enterEmailTextBox.Text = "";
            enterPhoneTextBox.Text = "";
            enterAddressTextBox.Text = "";
        }

        private void enterEmployeeEnterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (enterIdTextBox.Text == "" && enterPasswordTextBox.Text == "" && enterNameTextBox.Text == "" && enterSalaryTextBox.Text == "" && enterAddressTextBox.Text == "" && enterPhoneTextBox.Text == "" && enterEmailTextBox.Text == "")
                {
                    MessageBox.Show("Recheck information!");
                }
                else
                {
                    sq.Open();
                    SqlCommand sc = new SqlCommand("insert into emp values('" + enterIdTextBox.Text + "','" + enterPasswordTextBox.Text + "','" + enterNameTextBox.Text + "','" + int.Parse(enterSalaryTextBox.Text) + "', '" + enterEmailTextBox.Text + "','" + enterPhoneTextBox.Text + "','" + enterAddressTextBox.Text + "')", sq);
                    sc.ExecuteNonQuery();
                    MessageBox.Show("Employee entered!");
                    clear();
                    sq.Close();
                }
            }
            catch
            {
                MessageBox.Show("Wrong information!");
                this.Close();
            }
        }
    }
}
