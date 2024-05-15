namespace Supermarketinventory
{
    partial class Selling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Selling));
            logout = new Button();
            refresh = new Button();
            ProdPrice = new TextBox();
            ProdQty = new TextBox();
            ProdName = new TextBox();
            BillID = new TextBox();
            BillDVG = new DataGridView();
            Add_prod = new Button();
            print = new Button();
            Add = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            prodqit = new DataGridView();
            Date = new Label();
            totalllb = new Label();
            Seller_name = new Label();
            label7 = new Label();
            SelsmemoDGV = new DataGridView();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)BillDVG).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)prodqit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SelsmemoDGV).BeginInit();
            SuspendLayout();
            // 
            // logout
            // 
            logout.Location = new Point(33, 586);
            logout.Name = "logout";
            logout.Size = new Size(94, 29);
            logout.TabIndex = 6;
            logout.Text = "Log out";
            logout.UseVisualStyleBackColor = true;
            logout.Click += logout_Click;
            // 
            // refresh
            // 
            refresh.Location = new Point(113, 235);
            refresh.Name = "refresh";
            refresh.Size = new Size(94, 29);
            refresh.TabIndex = 16;
            refresh.Text = "Refresh";
            refresh.UseVisualStyleBackColor = true;
            refresh.Click += refresh_Click;
            // 
            // ProdPrice
            // 
            ProdPrice.Location = new Point(113, 117);
            ProdPrice.Name = "ProdPrice";
            ProdPrice.Size = new Size(125, 27);
            ProdPrice.TabIndex = 14;
            // 
            // ProdQty
            // 
            ProdQty.Location = new Point(113, 156);
            ProdQty.Name = "ProdQty";
            ProdQty.Size = new Size(125, 27);
            ProdQty.TabIndex = 13;
            // 
            // ProdName
            // 
            ProdName.Location = new Point(113, 73);
            ProdName.Name = "ProdName";
            ProdName.Size = new Size(125, 27);
            ProdName.TabIndex = 12;
            // 
            // BillID
            // 
            BillID.Location = new Point(463, 318);
            BillID.Name = "BillID";
            BillID.Size = new Size(125, 27);
            BillID.TabIndex = 11;
            // 
            // BillDVG
            // 
            BillDVG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BillDVG.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            BillDVG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BillDVG.Location = new Point(399, 351);
            BillDVG.Name = "BillDVG";
            BillDVG.RowHeadersWidth = 51;
            BillDVG.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BillDVG.Size = new Size(575, 189);
            BillDVG.TabIndex = 10;
            // 
            // Add_prod
            // 
            Add_prod.Location = new Point(81, 189);
            Add_prod.Name = "Add_prod";
            Add_prod.Size = new Size(184, 29);
            Add_prod.TabIndex = 9;
            Add_prod.Text = "Add Products";
            Add_prod.UseVisualStyleBackColor = true;
            Add_prod.Click += Add_prod_Click;
            // 
            // print
            // 
            print.Location = new Point(880, 557);
            print.Name = "print";
            print.Size = new Size(94, 29);
            print.TabIndex = 7;
            print.Text = "Print";
            print.UseVisualStyleBackColor = true;
            print.Click += print_Click;
            // 
            // Add
            // 
            Add.Location = new Point(399, 557);
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
            label5.Location = new Point(23, 124);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 4;
            label5.Text = "Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 163);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 3;
            label4.Text = "Quantity:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 76);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 2;
            label3.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(405, 325);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 1;
            label2.Text = "Bill ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(399, 11);
            label1.Name = "label1";
            label1.Size = new Size(83, 31);
            label1.TabIndex = 0;
            label1.Text = "Selling";
            // 
            // panel1
            // 
            panel1.Controls.Add(label6);
            panel1.Controls.Add(prodqit);
            panel1.Controls.Add(Date);
            panel1.Controls.Add(totalllb);
            panel1.Controls.Add(Seller_name);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(SelsmemoDGV);
            panel1.Controls.Add(refresh);
            panel1.Controls.Add(ProdPrice);
            panel1.Controls.Add(ProdQty);
            panel1.Controls.Add(ProdName);
            panel1.Controls.Add(BillID);
            panel1.Controls.Add(BillDVG);
            panel1.Controls.Add(Add_prod);
            panel1.Controls.Add(print);
            panel1.Controls.Add(Add);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(133, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(997, 603);
            panel1.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(582, 267);
            label6.Name = "label6";
            label6.Size = new Size(162, 31);
            label6.TabIndex = 23;
            label6.Text = "Total Amount: ";
            // 
            // prodqit
            // 
            prodqit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            prodqit.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            prodqit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            prodqit.Location = new Point(23, 279);
            prodqit.Name = "prodqit";
            prodqit.RowHeadersWidth = 51;
            prodqit.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            prodqit.Size = new Size(304, 321);
            prodqit.TabIndex = 22;
            prodqit.CellClick += prodqit_CellClick;
            prodqit.CellContentClick += prodqit_CellContentClick;
            // 
            // Date
            // 
            Date.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Date.Location = new Point(627, 11);
            Date.Name = "Date";
            Date.Size = new Size(326, 31);
            Date.TabIndex = 21;
            Date.Text = "Date";
            // 
            // totalllb
            // 
            totalllb.AutoSize = true;
            totalllb.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalllb.Location = new Point(750, 267);
            totalllb.Name = "totalllb";
            totalllb.Size = new Size(26, 31);
            totalllb.TabIndex = 20;
            totalllb.Text = "0";
            // 
            // Seller_name
            // 
            Seller_name.AutoSize = true;
            Seller_name.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Seller_name.Location = new Point(35, 11);
            Seller_name.Name = "Seller_name";
            Seller_name.Size = new Size(137, 31);
            Seller_name.TabIndex = 19;
            Seller_name.Text = "Seller Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(627, 317);
            label7.Name = "label7";
            label7.Size = new Size(101, 31);
            label7.TabIndex = 18;
            label7.Text = "Sells List";
            // 
            // SelsmemoDGV
            // 
            SelsmemoDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SelsmemoDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            SelsmemoDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SelsmemoDGV.Location = new Point(399, 88);
            SelsmemoDGV.Name = "SelsmemoDGV";
            SelsmemoDGV.RowHeadersWidth = 51;
            SelsmemoDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SelsmemoDGV.Size = new Size(575, 176);
            SelsmemoDGV.TabIndex = 17;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // Selling
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 627);
            Controls.Add(logout);
            Controls.Add(panel1);
            Name = "Selling";
            Text = "Selling";
            Load += Selling_Load;
            ((System.ComponentModel.ISupportInitialize)BillDVG).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)prodqit).EndInit();
            ((System.ComponentModel.ISupportInitialize)SelsmemoDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button logout;
        private Button refresh;
        private TextBox ProdPrice;
        private TextBox ProdQty;
        private TextBox ProdName;
        private TextBox BillID;
        private DataGridView BillDVG;
        private Button Add_prod;
        private Button print;
        private Button Add;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Label totalllb;
        private Label Seller_name;
        private Label label7;
        private DataGridView SelsmemoDGV;
        private DataGridView prodqit;
        private Label Date;
        private Label label6;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}