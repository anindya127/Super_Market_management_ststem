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
using DGVPrinterHelper;
using System.Reflection;

namespace Supermarketinventory
{
    public partial class Selling : Form
    {

        int sum;
        public Selling()
        {
            InitializeComponent();

            // Change the background to #C5FF95
            this.BackColor = Color.FromArgb(0xC5, 0xFF, 0x95);

            // Change the button collor to #074173
            Add_prod.BackColor = Color.FromArgb(0x07, 0x41, 0x73);
            refresh.BackColor = Color.FromArgb(0x07, 0x41, 0x73);
            Add.BackColor = Color.FromArgb(0x07, 0x41, 0x73);
            print.BackColor = Color.FromArgb(0x07, 0x41, 0x73);
            logout.BackColor = Color.FromArgb(0x07, 0x41, 0x73);

            // Change the button text collor to white
            Add_prod.ForeColor = Color.White;
            refresh.ForeColor = Color.White;
            Add.ForeColor = Color.White;
            print.ForeColor = Color.White;
            logout.ForeColor = Color.White;

            // Change the label color to  #1679AB
            label1.ForeColor = Color.FromArgb(0x16, 0x79, 0xAB);
            label2.ForeColor = Color.FromArgb(0x16, 0x79, 0xAB);
            label3.ForeColor = Color.FromArgb(0x16, 0x79, 0xAB);
            label4.ForeColor = Color.FromArgb(0x16, 0x79, 0xAB);
            label5.ForeColor = Color.FromArgb(0x16, 0x79, 0xAB);
            label6.ForeColor = Color.FromArgb(0x16, 0x79, 0xAB);
            label7.ForeColor = Color.FromArgb(0x16, 0x79, 0xAB);
            Seller_name.ForeColor = Color.FromArgb(0x16, 0x79, 0xAB);
            Date.ForeColor = Color.FromArgb(0x16, 0x79, 0xAB);
            totalllb.ForeColor = Color.FromArgb(0x16, 0x79, 0xAB);

            // Change the datagridview collor to white
            prodqit.BackgroundColor = Color.White;
            SelsmemoDGV.BackgroundColor = Color.White;
            BillDVG.BackgroundColor = Color.White;
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vipar\OneDrive\Documents\Supermarketinventory.mdf;Integrated Security=True;Connect Timeout=30");

        private void Selling_Load(object sender, EventArgs e)
        {

            // show the username from username.txt inside Seller_name 
            Seller_name.Text = System.IO.File.ReadAllText("username.txt");
            // show the date and time in the Date_time label
            Date.Text = DateTime.Now.ToLongDateString();

            Populate1();
            populate2();
            populate3();

            printDocument1.PrintPage += printDocument1_PrintPage;


        }

        private void Populate1()
        {
            // show ProdName and ProdQty from ProducTBL
            con.Open();
            string query = "SELECT ProdName, ProdQty, ProdPri from ProducTBL";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            prodqit.DataSource = ds.Tables[0];
            con.Close();
        }

        private void populate2()
        {
            con.Open();
            // sellect all from ProdTBL
            string query = "SELECT * from ProdTBL";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            SelsmemoDGV.DataSource = ds.Tables[0];
            con.Close();

        }

        private void populate3()
        {
            // show all from BillTBL
            con.Open();
            string query = "SELECT * from BillTBL";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BillDVG.DataSource = ds.Tables[0];
            con.Close();
        }

        private void prodqit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void print_Click(object sender, EventArgs e)
        {
            try
            {
                // Show the print preview dialog
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    // Print the document
                    printDocument1.Print();
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that might occur during printing
                MessageBox.Show("An error occurred while printing: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void prodqit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.prodqit.Rows[e.RowIndex];
                // show the ProdName and ProdQty in the ProdName and ProdQty textboxes
                ProdName.Text = row.Cells["ProdName"].Value.ToString();
                ProdPrice.Text = row.Cells["ProdPri"].Value.ToString();
            }
        }

        private void Add_prod_Click(object sender, EventArgs e)
        {
            int total = Convert.ToInt32(ProdQty.Text) * Convert.ToInt32(ProdPrice.Text);

            int prodid = 0;
            con.Open();
            string query = "SELECT * from ProdTBL";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                prodid = Convert.ToInt32(dr["Id"].ToString());
            }
            con.Close();
            prodid++;

            con.Open();
            // insert into ProdTBL
            string query2 = "INSERT INTO ProdTBL values(" + prodid + ",'" + ProdName.Text + "'," + ProdPrice.Text + "," + ProdQty.Text + "," + total + ")";
            SqlCommand cmd2 = new SqlCommand(query2, con);
            cmd2.ExecuteNonQuery();
            con.Close();
            populate2();

            int sum = 0;
            for (int i = 0; i < SelsmemoDGV.Rows.Count; i++)
            {
                sum += Convert.ToInt32(SelsmemoDGV.Rows[i].Cells[4].Value);
            }
            totalllb.Text = sum.ToString();

            ProdName.Text = "";
            ProdQty.Text = "";
            ProdPrice.Text = "";

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            // clear ProdTBL
            sum = 0;
            totalllb.Text = sum.ToString();
            con.Open();
            string query = "DELETE from ProdTBL";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            populate2();

            ProdName.Text = "";
            ProdQty.Text = "";
            ProdPrice.Text = "";
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                // insert into BillTBL
                string query = "INSERT INTO BillTBL values(" + BillID.Text + ",'" + Seller_name.Text + "','" + Date.Text + "'," + totalllb.Text + ")";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Bill Added Successfully");
                con.Close();
                populate3();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            BillID.Text = "";
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                if (BillDVG.SelectedRows.Count >= 0)
                {
                    // Draw the title
                    e.Graphics.DrawString("Supermarket", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(230));

                    // Draw bill details
                    int startY = 100; // Starting Y position for bill details
                    int lineHeight = 30; // Line height between bill details
                    var selectedRow = BillDVG.SelectedRows[0]; // Get the selected row
                    e.Graphics.DrawString("Bill ID: " + selectedRow.Cells[0].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Black, new Point(100, startY));
                    e.Graphics.DrawString("Seller Name: " + selectedRow.Cells[1].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Black, new Point(100, startY + lineHeight));
                    e.Graphics.DrawString("Date: " + selectedRow.Cells[2].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Black, new Point(100, startY + 2 * lineHeight));
                    e.Graphics.DrawString("Total Amount: " + selectedRow.Cells[3].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Black, new Point(100, startY + 3 * lineHeight));
                }
                else
                {
                    // If no row is selected, draw a message indicating that
                    e.Graphics.DrawString("No bill selected", new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Black, new Point(100, 100));
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that might occur during printing
                MessageBox.Show("An error occurred while printing: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            populate3();
            // go back to the login page
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }
    }

}
