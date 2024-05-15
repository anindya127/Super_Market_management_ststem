namespace Supermarketinventory
{
    partial class Catagory
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
            product = new Button();
            panel1 = new Panel();
            CatDescTB = new TextBox();
            CatNameTB = new TextBox();
            CatidTB = new TextBox();
            CatDGV = new DataGridView();
            delete = new Button();
            edit = new Button();
            Add = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            seller = new Button();
            logout = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CatDGV).BeginInit();
            SuspendLayout();
            // 
            // product
            // 
            product.Location = new Point(57, 107);
            product.Name = "product";
            product.Size = new Size(94, 29);
            product.TabIndex = 9;
            product.Text = "Products";
            product.UseVisualStyleBackColor = true;
            product.Click += product_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(CatDescTB);
            panel1.Controls.Add(CatNameTB);
            panel1.Controls.Add(CatidTB);
            panel1.Controls.Add(CatDGV);
            panel1.Controls.Add(delete);
            panel1.Controls.Add(edit);
            panel1.Controls.Add(Add);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(227, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(903, 479);
            panel1.TabIndex = 8;
            // 
            // CatDescTB
            // 
            CatDescTB.Location = new Point(114, 171);
            CatDescTB.Name = "CatDescTB";
            CatDescTB.Size = new Size(125, 27);
            CatDescTB.TabIndex = 13;
            // 
            // CatNameTB
            // 
            CatNameTB.Location = new Point(114, 127);
            CatNameTB.Name = "CatNameTB";
            CatNameTB.Size = new Size(125, 27);
            CatNameTB.TabIndex = 12;
            // 
            // CatidTB
            // 
            CatidTB.Location = new Point(114, 88);
            CatidTB.Name = "CatidTB";
            CatidTB.Size = new Size(125, 27);
            CatidTB.TabIndex = 11;
            // 
            // CatDGV
            // 
            CatDGV.Anchor = AnchorStyles.None;
            CatDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CatDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            CatDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CatDGV.Location = new Point(328, 45);
            CatDGV.Name = "CatDGV";
            CatDGV.RowHeadersWidth = 51;
            CatDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CatDGV.Size = new Size(575, 431);
            CatDGV.TabIndex = 10;
            CatDGV.CellClick += CatDGV_CellClick;
            CatDGV.CellContentClick += CatDGV_CellContentClick;
            // 
            // delete
            // 
            delete.Location = new Point(214, 223);
            delete.Name = "delete";
            delete.Size = new Size(94, 29);
            delete.TabIndex = 9;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // edit
            // 
            edit.Location = new Point(114, 223);
            edit.Name = "edit";
            edit.Size = new Size(94, 29);
            edit.TabIndex = 7;
            edit.Text = "Edit";
            edit.UseVisualStyleBackColor = true;
            edit.Click += edit_Click;
            // 
            // Add
            // 
            Add.Location = new Point(14, 223);
            Add.Name = "Add";
            Add.Size = new Size(94, 29);
            Add.TabIndex = 8;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 174);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 3;
            label4.Text = "Description:";
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
            label1.Size = new Size(213, 31);
            label1.TabIndex = 0;
            label1.Text = "Manage Categories";
            // 
            // seller
            // 
            seller.Location = new Point(57, 142);
            seller.Name = "seller";
            seller.Size = new Size(94, 29);
            seller.TabIndex = 7;
            seller.Text = "Seller";
            seller.UseVisualStyleBackColor = true;
            seller.Click += seller_Click;
            // 
            // logout
            // 
            logout.Location = new Point(57, 459);
            logout.Name = "logout";
            logout.Size = new Size(94, 29);
            logout.TabIndex = 10;
            logout.Text = "Logout";
            logout.UseVisualStyleBackColor = true;
            logout.Click += logout_Click;
            // 
            // Catagory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 503);
            Controls.Add(logout);
            Controls.Add(seller);
            Controls.Add(product);
            Controls.Add(panel1);
            Name = "Catagory";
            Text = "Category";
            Load += Catagory_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CatDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button product;
        private Panel panel1;
        private TextBox CatDescTB;
        private TextBox CatNameTB;
        private TextBox CatidTB;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView CatDGV;
        private Button delete;
        private Button edit;
        private Button Add;
        private Button seller;
        private Button logout;
    }
}