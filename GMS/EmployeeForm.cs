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
    public partial class EmployeeForm : Form
    {
        string empid;
        public EmployeeForm()
        {
            InitializeComponent();
        }
        public EmployeeForm(string s)
        {
            empid = s;
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void showProductList_Click(object sender, EventArgs e)
        {
            showMe("SELECT * FROM p_table");
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private void enterProduct_Click(object sender, EventArgs e)
        {
            EnterProductForm ep = new EnterProductForm();
            ep.Show();
        }

        private void enterIdLabel_Click(object sender, EventArgs e)
        {

        }
        SqlConnection sq = new SqlConnection("Data Source=DESKTOP-KORGD9I;Initial Catalog=GMS;Persist Security Info=True;User ID=sa;Password=root");


        void showMe(string s)
        {

            SqlCommand sc = new SqlCommand(s, sq);
            SqlDataAdapter sa = new SqlDataAdapter(sc);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            adminTextBox.DataSource = dt;

        }

        

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            //string adminTextBox = textBox1.Text;
        }

        private void findProduct_Click(object sender, EventArgs e)
        {
            showMe("select * from p_table where P_ID = '" + textBox1.Text + "'");
        }

        private void deleteProduct_Click(object sender, EventArgs e)
        {
            sq.Open();
            SqlCommand sc = new SqlCommand("delete p_table where P_ID = '" + textBox1.Text + "'", sq);
            sc.ExecuteNonQuery();
            MessageBox.Show("Product deleted");
            sq.Close();
        }

        private void updateProductBtn_Click(object sender, EventArgs e)
        {
            UpdateProductForm up = new UpdateProductForm(textBox1.Text);
            up.Show();
        }

        private void editProfileBtn_Click(object sender, EventArgs e)
        {
            EditEmployeeProfileForm ea = new EditEmployeeProfileForm(empid);
            ea.Show();
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            showMe("select * from emp where eid = '" + empid + "'");
        }
    }   
}
