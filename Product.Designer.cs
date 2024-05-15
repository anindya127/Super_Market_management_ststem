namespace Supermarketinventory
{
    partial class Product
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
            panel1 = new Panel();
            refresh = new Button();
            CatDB2 = new ComboBox();
            ProdPriceTB = new TextBox();
            ProdQtyTB = new TextBox();
            ProdNameTB = new TextBox();
            ProdIdTB = new TextBox();
            ProductDGV = new DataGridView();
            delete = new Button();
            edit = new Button();
            Add = new Button();
            CatCB = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            seller = new Button();
            catagory = new Button();
            logout = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductDGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(refresh);
            panel1.Controls.Add(CatDB2);
            panel1.Controls.Add(ProdPriceTB);
            panel1.Controls.Add(ProdQtyTB);
            panel1.Controls.Add(ProdNameTB);
            panel1.Controls.Add(ProdIdTB);
            panel1.Controls.Add(ProductDGV);
            panel1.Controls.Add(delete);
            panel1.Controls.Add(edit);
            panel1.Controls.Add(Add);
            panel1.Controls.Add(CatCB);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(209, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(903, 479);
            panel1.TabIndex = 0;
            // 
            // refresh
            // 
            refresh.Location = new Point(806, 10);
            refresh.Name = "refresh";
            refresh.Size = new Size(94, 29);
            refresh.TabIndex = 16;
            refresh.Text = "Refresh";
            refresh.UseVisualStyleBackColor = true;
            refresh.Click += refresh_Click;
            // 
            // CatDB2
            // 
            CatDB2.FormattingEnabled = true;
            CatDB2.Location = new Point(649, 11);
            CatDB2.Name = "CatDB2";
            CatDB2.Size = new Size(151, 28);
            CatDB2.TabIndex = 15;
            CatDB2.Text = "Select Category";
            CatDB2.SelectedIndexChanged += CatDB2_SelectedIndexChanged;
            CatDB2.Click += CatDB2_Click;
            // 
            // ProdPriceTB
            // 
            ProdPriceTB.Location = new Point(114, 210);
            ProdPriceTB.Name = "ProdPriceTB";
            ProdPriceTB.Size = new Size(125, 27);
            ProdPriceTB.TabIndex = 14;
            // 
            // ProdQtyTB
            // 
            ProdQtyTB.Location = new Point(114, 171);
            ProdQtyTB.Name = "ProdQtyTB";
            ProdQtyTB.Size = new Size(125, 27);
            ProdQtyTB.TabIndex = 13;
            // 
            // ProdNameTB
            // 
            ProdNameTB.Location = new Point(114, 127);
            ProdNameTB.Name = "ProdNameTB";
            ProdNameTB.Size = new Size(125, 27);
            ProdNameTB.TabIndex = 12;
            // 
            // ProdIdTB
            // 
            ProdIdTB.Location = new Point(114, 88);
            ProdIdTB.Name = "ProdIdTB";
            ProdIdTB.Size = new Size(125, 27);
            ProdIdTB.TabIndex = 11;
            ProdIdTB.TextChanged += textBox1_TextChanged;
            // 
            // ProductDGV
            // 
            ProductDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            ProductDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductDGV.Location = new Point(328, 45);
            ProductDGV.Name = "ProductDGV";
            ProductDGV.RowHeadersWidth = 51;
            ProductDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductDGV.Size = new Size(575, 431);
            ProductDGV.TabIndex = 10;
            ProductDGV.CellClick += ProductDGV_CellClick;
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
            // CatCB
            // 
            CatCB.FormattingEnabled = true;
            CatCB.Location = new Point(114, 251);
            CatCB.Name = "CatCB";
            CatCB.Size = new Size(151, 28);
            CatCB.TabIndex = 6;
            CatCB.Text = "Select Category";
            CatCB.Click += CatCB_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 254);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 5;
            label6.Text = "Category:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 213);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 4;
            label5.Text = "Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 174);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 3;
            label4.Text = "Quantity:";
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
            label1.Size = new Size(184, 31);
            label1.TabIndex = 0;
            label1.Text = "Manage Product";
            label1.Click += label1_Click;
            // 
            // seller
            // 
            seller.Location = new Point(39, 107);
            seller.Name = "seller";
            seller.Size = new Size(94, 29);
            seller.TabIndex = 1;
            seller.Text = "Seller";
            seller.UseVisualStyleBackColor = true;
            seller.Click += seller_Click;
            // 
            // catagory
            // 
            catagory.Location = new Point(39, 142);
            catagory.Name = "catagory";
            catagory.Size = new Size(94, 29);
            catagory.TabIndex = 0;
            catagory.Text = "Category";
            catagory.UseVisualStyleBackColor = true;
            catagory.Click += catagory_Click;
            // 
            // logout
            // 
            logout.Location = new Point(39, 459);
            logout.Name = "logout";
            logout.Size = new Size(94, 29);
            logout.TabIndex = 2;
            logout.Text = "Logout";
            logout.UseVisualStyleBackColor = true;
            logout.Click += logout_Click;
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 503);
            Controls.Add(logout);
            Controls.Add(catagory);
            Controls.Add(seller);
            Controls.Add(panel1);
            Name = "Product";
            Text = "Product";
            Load += Product_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProductDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button seller;
        private Button catagory;
        private Label label1;
        private Button delete;
        private Button edit;
        private Button Add;
        private ComboBox CatCB;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView ProductDGV;
        private TextBox ProdNameTB;
        private TextBox ProdIdTB;
        private TextBox ProdPriceTB;
        private TextBox ProdQtyTB;
        private Button refresh;
        private ComboBox CatDB2;
        private Button logout;
    }
}