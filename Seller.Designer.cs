namespace Supermarketinventory
{
    partial class Seller
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
            SellerPhoneTB = new TextBox();
            SellerAgeTB = new TextBox();
            SellerNameTB = new TextBox();
            SellerIDTB = new TextBox();
            SellerDGV = new DataGridView();
            delete = new Button();
            edit = new Button();
            Add = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            catagory = new Button();
            product = new Button();
            label6 = new Label();
            panel1 = new Panel();
            SellerPassTB = new TextBox();
            logout = new Button();
            ((System.ComponentModel.ISupportInitialize)SellerDGV).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // SellerPhoneTB
            // 
            SellerPhoneTB.Location = new Point(114, 210);
            SellerPhoneTB.Name = "SellerPhoneTB";
            SellerPhoneTB.Size = new Size(125, 27);
            SellerPhoneTB.TabIndex = 14;
            // 
            // SellerAgeTB
            // 
            SellerAgeTB.Location = new Point(114, 171);
            SellerAgeTB.Name = "SellerAgeTB";
            SellerAgeTB.Size = new Size(125, 27);
            SellerAgeTB.TabIndex = 13;
            // 
            // SellerNameTB
            // 
            SellerNameTB.Location = new Point(114, 127);
            SellerNameTB.Name = "SellerNameTB";
            SellerNameTB.Size = new Size(125, 27);
            SellerNameTB.TabIndex = 12;
            // 
            // SellerIDTB
            // 
            SellerIDTB.Location = new Point(114, 88);
            SellerIDTB.Name = "SellerIDTB";
            SellerIDTB.Size = new Size(125, 27);
            SellerIDTB.TabIndex = 11;
            // 
            // SellerDGV
            // 
            SellerDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SellerDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SellerDGV.Location = new Point(328, 45);
            SellerDGV.Name = "SellerDGV";
            SellerDGV.RowHeadersWidth = 51;
            SellerDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SellerDGV.Size = new Size(575, 431);
            SellerDGV.TabIndex = 10;
            SellerDGV.CellClick += SellerDGV_CellClick;
            // 
            // delete
            // 
            delete.Location = new Point(223, 303);
            delete.Name = "delete";
            delete.Size = new Size(94, 29);
            delete.TabIndex = 9;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // edit
            // 
            edit.Location = new Point(123, 303);
            edit.Name = "edit";
            edit.Size = new Size(94, 29);
            edit.TabIndex = 7;
            edit.Text = "Edit";
            edit.UseVisualStyleBackColor = true;
            edit.Click += edit_Click;
            // 
            // Add
            // 
            Add.Location = new Point(23, 303);
            Add.Name = "Add";
            Add.Size = new Size(94, 29);
            Add.TabIndex = 8;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 213);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 4;
            label5.Text = "Phone:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 174);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 3;
            label4.Text = "Age:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 130);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 2;
            label3.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 95);
            label2.Name = "label2";
            label2.Size = new Size(27, 20);
            label2.TabIndex = 1;
            label2.Text = "ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(399, 11);
            label1.Name = "label1";
            label1.Size = new Size(160, 31);
            label1.TabIndex = 0;
            label1.Text = "Manage Seller";
            // 
            // catagory
            // 
            catagory.Location = new Point(57, 142);
            catagory.Name = "catagory";
            catagory.Size = new Size(94, 29);
            catagory.TabIndex = 3;
            catagory.Text = "Category";
            catagory.UseVisualStyleBackColor = true;
            catagory.Click += catagory_Click;
            // 
            // product
            // 
            product.Location = new Point(57, 107);
            product.Name = "product";
            product.Size = new Size(94, 29);
            product.TabIndex = 5;
            product.Text = "Products";
            product.UseVisualStyleBackColor = true;
            product.Click += product_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 254);
            label6.Name = "label6";
            label6.Size = new Size(79, 20);
            label6.TabIndex = 5;
            label6.Text = "Passsword:";
            // 
            // panel1
            // 
            panel1.Controls.Add(SellerPassTB);
            panel1.Controls.Add(SellerPhoneTB);
            panel1.Controls.Add(SellerAgeTB);
            panel1.Controls.Add(SellerNameTB);
            panel1.Controls.Add(SellerIDTB);
            panel1.Controls.Add(SellerDGV);
            panel1.Controls.Add(delete);
            panel1.Controls.Add(edit);
            panel1.Controls.Add(Add);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(227, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(903, 479);
            panel1.TabIndex = 4;
            // 
            // SellerPassTB
            // 
            SellerPassTB.Location = new Point(114, 251);
            SellerPassTB.Name = "SellerPassTB";
            SellerPassTB.Size = new Size(125, 27);
            SellerPassTB.TabIndex = 17;
            // 
            // logout
            // 
            logout.Location = new Point(57, 462);
            logout.Name = "logout";
            logout.Size = new Size(94, 29);
            logout.TabIndex = 6;
            logout.Text = "Logout";
            logout.UseVisualStyleBackColor = true;
            logout.Click += logout_Click;
            // 
            // Seller
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 503);
            Controls.Add(logout);
            Controls.Add(catagory);
            Controls.Add(product);
            Controls.Add(panel1);
            Name = "Seller";
            Text = "seller";
            Load += Seller_Load;
            ((System.ComponentModel.ISupportInitialize)SellerDGV).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox SellerPhoneTB;
        private TextBox SellerAgeTB;
        private TextBox SellerNameTB;
        private TextBox SellerIDTB;
        private DataGridView SellerDGV;
        private Button delete;
        private Button edit;
        private Button Add;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button catagory;
        private Button product;
        private Label label6;
        private Panel panel1;
        private TextBox SellerPassTB;
        private Button logout;
    }
}