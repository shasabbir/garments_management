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
    public partial class AdminForm : Form
    {
        string lAid;
        public AdminForm()
        {
            InitializeComponent();
        }
        public AdminForm(string s)
        {
            lAid = s;
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void showProductList_Click(object sender, EventArgs e)
        {
            showMe("SELECT * FROM p_table");
        }

        private void AdminForm_Load(object sender, EventArgs e)
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

        private void adminList_Click(object sender, EventArgs e)
        {
            /*sq.Open();
            SqlCommand cmd = sq.CreateCommand();



            cmd.CommandText = "SELECT * FROM admin";
            string result = ((string)cmd.ExecuteScalar());

            sq.Close();*/
            showMe("SELECT * FROM admin");


        }

        void showMe(string s)
        {

            SqlCommand sc = new SqlCommand(s, sq);
            SqlDataAdapter sa = new SqlDataAdapter(sc);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            adminTextBox.DataSource = dt;

        }

        private void empList_Click(object sender, EventArgs e)
        {
            showMe("SELECT * FROM emp");
        }

        private void enterEmployee_Click(object sender, EventArgs e)
        {
            EnterEmployeeForm ee = new EnterEmployeeForm();
            ee.Show();
        }

        private void deleteEmployee_Click(object sender, EventArgs e)
        {
            sq.Open();
            SqlCommand sc = new SqlCommand("delete emp where eid = '"+ textBox1.Text+ "'",sq);
            sc.ExecuteNonQuery();
            MessageBox.Show("Employee deleted");
            sq.Close();
        }

        private void findEmployee_Click(object sender, EventArgs e)
        {
            
            showMe("select * from emp where eid = '" + textBox1.Text + "'");
        }

        private void updateEmployeeBtn_Click(object sender, EventArgs e)
        {
            UpdateEmployee ue = new UpdateEmployee(textBox1.Text);
            
            ue.Show();
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
            EditAdminProfileForm ea = new EditAdminProfileForm(lAid);
            ea.Show();
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            showMe("select * from admin where aid = '" + lAid + "'");
        }

        private void adminTextBox_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }   
}
