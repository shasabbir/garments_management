
namespace GMS
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.productList = new System.Windows.Forms.Button();
            this.empList = new System.Windows.Forms.Button();
            this.adminList = new System.Windows.Forms.Button();
            this.adminTextBox = new System.Windows.Forms.DataGridView();
            this.enterProduct = new System.Windows.Forms.Button();
            this.findProduct = new System.Windows.Forms.Button();
            this.deleteProduct = new System.Windows.Forms.Button();
            this.enterEmployee = new System.Windows.Forms.Button();
            this.findEmployee = new System.Windows.Forms.Button();
            this.deleteEmployee = new System.Windows.Forms.Button();
            this.profileBtn = new System.Windows.Forms.Button();
            this.listLabel = new System.Windows.Forms.Label();
            this.employeeLabel = new System.Windows.Forms.Label();
            this.productLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.editProfileBtn = new System.Windows.Forms.Button();
            this.enterIdLabel = new System.Windows.Forms.Label();
            this.updateEmployeeBtn = new System.Windows.Forms.Button();
            this.updateProductBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.adminTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // productList
            // 
            this.productList.Location = new System.Drawing.Point(12, 97);
            this.productList.Name = "productList";
            this.productList.Size = new System.Drawing.Size(111, 35);
            this.productList.TabIndex = 1;
            this.productList.Text = "Product List";
            this.productList.UseVisualStyleBackColor = true;
            this.productList.Click += new System.EventHandler(this.showProductList_Click);
            // 
            // empList
            // 
            this.empList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.empList.Location = new System.Drawing.Point(12, 138);
            this.empList.Name = "empList";
            this.empList.Size = new System.Drawing.Size(111, 39);
            this.empList.TabIndex = 3;
            this.empList.Text = "Employee List";
            this.empList.UseVisualStyleBackColor = true;
            this.empList.Click += new System.EventHandler(this.empList_Click);
            // 
            // adminList
            // 
            this.adminList.Location = new System.Drawing.Point(12, 53);
            this.adminList.Name = "adminList";
            this.adminList.Size = new System.Drawing.Size(111, 38);
            this.adminList.TabIndex = 4;
            this.adminList.Text = "Admin List";
            this.adminList.UseVisualStyleBackColor = true;
            this.adminList.Click += new System.EventHandler(this.adminList_Click);
            // 
            // adminTextBox
            // 
            this.adminTextBox.AllowUserToOrderColumns = true;
            this.adminTextBox.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.adminTextBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminTextBox.Location = new System.Drawing.Point(12, 284);
            this.adminTextBox.Name = "adminTextBox";
            this.adminTextBox.RowHeadersWidth = 51;
            this.adminTextBox.RowTemplate.Height = 29;
            this.adminTextBox.Size = new System.Drawing.Size(883, 245);
            this.adminTextBox.TabIndex = 5;
            this.adminTextBox.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.adminTextBox_CellContentClick);
            // 
            // enterProduct
            // 
            this.enterProduct.Location = new System.Drawing.Point(300, 53);
            this.enterProduct.Name = "enterProduct";
            this.enterProduct.Size = new System.Drawing.Size(134, 37);
            this.enterProduct.TabIndex = 6;
            this.enterProduct.Text = "Enter Product";
            this.enterProduct.UseVisualStyleBackColor = true;
            this.enterProduct.Click += new System.EventHandler(this.enterProduct_Click);
            // 
            // findProduct
            // 
            this.findProduct.Location = new System.Drawing.Point(300, 97);
            this.findProduct.Name = "findProduct";
            this.findProduct.Size = new System.Drawing.Size(134, 36);
            this.findProduct.TabIndex = 7;
            this.findProduct.Text = "Find Product";
            this.findProduct.UseVisualStyleBackColor = true;
            this.findProduct.Click += new System.EventHandler(this.findProduct_Click);
            // 
            // deleteProduct
            // 
            this.deleteProduct.Location = new System.Drawing.Point(300, 139);
            this.deleteProduct.Name = "deleteProduct";
            this.deleteProduct.Size = new System.Drawing.Size(134, 39);
            this.deleteProduct.TabIndex = 9;
            this.deleteProduct.Text = "Delete";
            this.deleteProduct.UseVisualStyleBackColor = true;
            this.deleteProduct.Click += new System.EventHandler(this.deleteProduct_Click);
            // 
            // enterEmployee
            // 
            this.enterEmployee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enterEmployee.Location = new System.Drawing.Point(145, 54);
            this.enterEmployee.Name = "enterEmployee";
            this.enterEmployee.Size = new System.Drawing.Size(134, 37);
            this.enterEmployee.TabIndex = 10;
            this.enterEmployee.Text = "Enter Employee";
            this.enterEmployee.UseVisualStyleBackColor = true;
            this.enterEmployee.Click += new System.EventHandler(this.enterEmployee_Click);
            // 
            // findEmployee
            // 
            this.findEmployee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.findEmployee.Location = new System.Drawing.Point(145, 97);
            this.findEmployee.Name = "findEmployee";
            this.findEmployee.Size = new System.Drawing.Size(134, 35);
            this.findEmployee.TabIndex = 11;
            this.findEmployee.Text = "Find Employee";
            this.findEmployee.UseVisualStyleBackColor = true;
            this.findEmployee.Click += new System.EventHandler(this.findEmployee_Click);
            // 
            // deleteEmployee
            // 
            this.deleteEmployee.Location = new System.Drawing.Point(145, 138);
            this.deleteEmployee.Name = "deleteEmployee";
            this.deleteEmployee.Size = new System.Drawing.Size(134, 39);
            this.deleteEmployee.TabIndex = 13;
            this.deleteEmployee.Text = "Delete";
            this.deleteEmployee.UseVisualStyleBackColor = true;
            this.deleteEmployee.Click += new System.EventHandler(this.deleteEmployee_Click);
            // 
            // profileBtn
            // 
            this.profileBtn.Location = new System.Drawing.Point(722, 53);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Size = new System.Drawing.Size(173, 30);
            this.profileBtn.TabIndex = 14;
            this.profileBtn.Text = "Profile";
            this.profileBtn.UseVisualStyleBackColor = true;
            this.profileBtn.Click += new System.EventHandler(this.profileBtn_Click);
            // 
            // listLabel
            // 
            this.listLabel.AutoSize = true;
            this.listLabel.BackColor = System.Drawing.Color.Transparent;
            this.listLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listLabel.Location = new System.Drawing.Point(38, 9);
            this.listLabel.Name = "listLabel";
            this.listLabel.Size = new System.Drawing.Size(52, 25);
            this.listLabel.TabIndex = 15;
            this.listLabel.Text = "Lists";
            // 
            // employeeLabel
            // 
            this.employeeLabel.AutoSize = true;
            this.employeeLabel.BackColor = System.Drawing.Color.Transparent;
            this.employeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.employeeLabel.Location = new System.Drawing.Point(159, 9);
            this.employeeLabel.Name = "employeeLabel";
            this.employeeLabel.Size = new System.Drawing.Size(99, 25);
            this.employeeLabel.TabIndex = 16;
            this.employeeLabel.Text = "Employee";
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.BackColor = System.Drawing.Color.Transparent;
            this.productLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productLabel.Location = new System.Drawing.Point(340, 9);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(79, 25);
            this.productLabel.TabIndex = 17;
            this.productLabel.Text = "Product";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(572, 166);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 42);
            this.textBox1.TabIndex = 18;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // editProfileBtn
            // 
            this.editProfileBtn.Location = new System.Drawing.Point(722, 96);
            this.editProfileBtn.Name = "editProfileBtn";
            this.editProfileBtn.Size = new System.Drawing.Size(173, 30);
            this.editProfileBtn.TabIndex = 19;
            this.editProfileBtn.Text = "Edit Profile";
            this.editProfileBtn.UseVisualStyleBackColor = true;
            this.editProfileBtn.Click += new System.EventHandler(this.editProfileBtn_Click);
            // 
            // enterIdLabel
            // 
            this.enterIdLabel.AutoSize = true;
            this.enterIdLabel.BackColor = System.Drawing.Color.Transparent;
            this.enterIdLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enterIdLabel.Location = new System.Drawing.Point(457, 166);
            this.enterIdLabel.Name = "enterIdLabel";
            this.enterIdLabel.Size = new System.Drawing.Size(90, 28);
            this.enterIdLabel.TabIndex = 20;
            this.enterIdLabel.Text = "Enter ID :";
            this.enterIdLabel.Click += new System.EventHandler(this.enterIdLabel_Click);
            // 
            // updateEmployeeBtn
            // 
            this.updateEmployeeBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateEmployeeBtn.Location = new System.Drawing.Point(145, 183);
            this.updateEmployeeBtn.Name = "updateEmployeeBtn";
            this.updateEmployeeBtn.Size = new System.Drawing.Size(134, 39);
            this.updateEmployeeBtn.TabIndex = 21;
            this.updateEmployeeBtn.Text = "Update Employee";
            this.updateEmployeeBtn.UseVisualStyleBackColor = true;
            this.updateEmployeeBtn.Click += new System.EventHandler(this.updateEmployeeBtn_Click);
            // 
            // updateProductBtn
            // 
            this.updateProductBtn.Location = new System.Drawing.Point(300, 184);
            this.updateProductBtn.Name = "updateProductBtn";
            this.updateProductBtn.Size = new System.Drawing.Size(134, 39);
            this.updateProductBtn.TabIndex = 22;
            this.updateProductBtn.Text = "Update Product";
            this.updateProductBtn.UseVisualStyleBackColor = true;
            this.updateProductBtn.Click += new System.EventHandler(this.updateProductBtn_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(907, 541);
            this.Controls.Add(this.updateProductBtn);
            this.Controls.Add(this.updateEmployeeBtn);
            this.Controls.Add(this.enterIdLabel);
            this.Controls.Add(this.editProfileBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.productLabel);
            this.Controls.Add(this.employeeLabel);
            this.Controls.Add(this.listLabel);
            this.Controls.Add(this.profileBtn);
            this.Controls.Add(this.deleteEmployee);
            this.Controls.Add(this.findEmployee);
            this.Controls.Add(this.enterEmployee);
            this.Controls.Add(this.deleteProduct);
            this.Controls.Add(this.findProduct);
            this.Controls.Add(this.enterProduct);
            this.Controls.Add(this.adminTextBox);
            this.Controls.Add(this.adminList);
            this.Controls.Add(this.empList);
            this.Controls.Add(this.productList);
            this.MaximumSize = new System.Drawing.Size(925, 588);
            this.MinimumSize = new System.Drawing.Size(925, 588);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adminTextBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button productList;
        private System.Windows.Forms.Button empList;
        private System.Windows.Forms.Button adminList;
        private System.Windows.Forms.DataGridView adminTextBox;
        private System.Windows.Forms.Button enterProduct;
        private System.Windows.Forms.Button findProduct;
        private System.Windows.Forms.Button deleteProduct;
        private System.Windows.Forms.Button enterEmployee;
        private System.Windows.Forms.Button findEmployee;
        private System.Windows.Forms.Button deleteEmployee;
        private System.Windows.Forms.Button profileBtn;
        private System.Windows.Forms.Label listLabel;
        private System.Windows.Forms.Label employeeLabel;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.Button editProfileBtn;
        private System.Windows.Forms.Label enterIdLabel;
        private System.Windows.Forms.Button updateEmployeeBtn;
        private System.Windows.Forms.Button updateProductBtn;
        private System.Windows.Forms.TextBox textBox1;
    }
}