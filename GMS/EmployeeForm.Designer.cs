
namespace GMS
{
    partial class EmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            this.productList = new System.Windows.Forms.Button();
            this.adminTextBox = new System.Windows.Forms.DataGridView();
            this.enterProduct = new System.Windows.Forms.Button();
            this.findProduct = new System.Windows.Forms.Button();
            this.deleteProduct = new System.Windows.Forms.Button();
            this.profileBtn = new System.Windows.Forms.Button();
            this.listLabel = new System.Windows.Forms.Label();
            this.productLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.editProfileBtn = new System.Windows.Forms.Button();
            this.enterIdLabel = new System.Windows.Forms.Label();
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
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(907, 541);
            this.Controls.Add(this.updateProductBtn);
            this.Controls.Add(this.enterIdLabel);
            this.Controls.Add(this.editProfileBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.productLabel);
            this.Controls.Add(this.listLabel);
            this.Controls.Add(this.profileBtn);
            this.Controls.Add(this.deleteProduct);
            this.Controls.Add(this.findProduct);
            this.Controls.Add(this.enterProduct);
            this.Controls.Add(this.adminTextBox);
            this.Controls.Add(this.productList);
            this.MaximumSize = new System.Drawing.Size(925, 588);
            this.MinimumSize = new System.Drawing.Size(925, 588);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adminTextBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button productList;
        private System.Windows.Forms.DataGridView adminTextBox;
        private System.Windows.Forms.Button enterProduct;
        private System.Windows.Forms.Button findProduct;
        private System.Windows.Forms.Button deleteProduct;
        private System.Windows.Forms.Button profileBtn;
        private System.Windows.Forms.Label listLabel;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.Button editProfileBtn;
        private System.Windows.Forms.Label enterIdLabel;
        private System.Windows.Forms.Button updateProductBtn;
        private System.Windows.Forms.TextBox textBox1;
    }
}