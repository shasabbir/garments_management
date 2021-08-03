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
    public partial class EnterProductForm : Form
    {
        public EnterProductForm()
        {
            InitializeComponent();
        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }
        void clear()
        {
            productEnterIdTextBox.Text = "";
            productEnterNameTextBox.Text = "";
            productEnterUnitPriceTextBox.Text = "";
            productEnterInventoryTextBox.Text = "";
            productEnterNeedTextBox.Text = "";
        }
        SqlConnection sq = new SqlConnection("Data Source=DESKTOP-KORGD9I;Initial Catalog=GMS;Persist Security Info=True;User ID=sa;Password=root");
        private void enterProductEnterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (productEnterIdTextBox.Text == "" && productEnterNameTextBox.Text == "" && productEnterUnitPriceTextBox.Text == "" && productEnterInventoryTextBox.Text == "" && productEnterNeedTextBox.Text == "" )
                {
                    MessageBox.Show("Recheck information!");

                }
                else
                {
                    if(productEnterIdTextBox.Text[0] != 'p')
                    {
                        MessageBox.Show("Product ID must start with 'p'");
                        
                    }
                    else
                    {
                        sq.Open();
                        SqlCommand sc = new SqlCommand("insert into p_table values('" + productEnterIdTextBox.Text + "','" + productEnterNameTextBox.Text + "','" + int.Parse(productEnterUnitPriceTextBox.Text) + "','" + int.Parse(productEnterInventoryTextBox.Text) + "', '" + int.Parse(productEnterNeedTextBox.Text) + "')", sq);
                        sc.ExecuteNonQuery();
                        MessageBox.Show("Product entered!");
                        clear();
                        sq.Close();
                    }
                    
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
