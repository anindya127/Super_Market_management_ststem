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

namespace Supermarketinventory
{
    public partial class Seller : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vipar\OneDrive\Documents\Supermarketinventory.mdf;Integrated Security=True;Connect Timeout=30");
        public Seller()
        {
            InitializeComponent();

            // Change the background to #C5FF95
            this.BackColor = Color.FromArgb(0xC5, 0xFF, 0x95);

            // Change the button collor to #074173
            Add.BackColor = Color.FromArgb(0x07, 0x41, 0x73);
            delete.BackColor = Color.FromArgb(0x07, 0x41, 0x73);
            edit.BackColor = Color.FromArgb(0x07, 0x41, 0x73);
            product.BackColor = Color.FromArgb(0x07, 0x41, 0x73);
            catagory.BackColor = Color.FromArgb(0x07, 0x41, 0x73);
            logout.BackColor = Color.FromArgb(0x07, 0x41, 0x73);

            // Change the button text collor to white
            Add.ForeColor = Color.White;
            delete.ForeColor = Color.White;
            edit.ForeColor = Color.White;
            product.ForeColor = Color.White;
            catagory.ForeColor = Color.White;
            logout.ForeColor = Color.White;

            // Change the label color to  #1679AB
            label1.ForeColor = Color.FromArgb(0x16, 0x79, 0xAB);
            label2.ForeColor = Color.FromArgb(0x16, 0x79, 0xAB);
            label3.ForeColor = Color.FromArgb(0x16, 0x79, 0xAB);
            label4.ForeColor = Color.FromArgb(0x16, 0x79, 0xAB);
            label5.ForeColor = Color.FromArgb(0x16, 0x79, 0xAB);
            label6.ForeColor = Color.FromArgb(0x16, 0x79, 0xAB);

            // Change the datagridview collor to white
            SellerDGV.BackgroundColor = Color.White;
        }

        private void populate()
        {
            con.Open();
            string query = "SELECT * FROM SellerTBL";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            SellerDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void Seller_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void Add_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                string query = "insert into SellerTBL values(" + SellerIDTB.Text + ",'" + SellerNameTB.Text + "','" + SellerAgeTB.Text + "','" + SellerPhoneTB.Text + "','" + SellerPassTB.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Seller Added Successfully");
                con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            SellerIDTB.Text = "";
            SellerNameTB.Text = "";
            SellerAgeTB.Text = "";
            SellerPhoneTB.Text = "";
            SellerPassTB.Text = "";
        }

        private void SellerDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.SellerDGV.Rows[e.RowIndex];
                SellerIDTB.Text = row.Cells[0].Value.ToString();
                SellerNameTB.Text = row.Cells[1].Value.ToString();
                SellerAgeTB.Text = row.Cells[2].Value.ToString();
                SellerPhoneTB.Text = row.Cells[3].Value.ToString();
                SellerPassTB.Text = row.Cells[4].Value.ToString();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {

                if (SellerIDTB.Text == "")
                {
                    MessageBox.Show("Select The Seller to Delete");
                }
                else
                {
                    con.Open();
                    string query = "delete from SellerTBL where SellerID=" + SellerIDTB.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Deleted Successfully");
                    con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            SellerIDTB.Text = "";
            SellerNameTB.Text = "";
            SellerAgeTB.Text = "";
            SellerPhoneTB.Text = "";
            SellerPassTB.Text = "";
        }

        private void edit_Click(object sender, EventArgs e)
        {
            try
            {

                if (SellerIDTB.Text == "" || SellerNameTB.Text == "" || SellerAgeTB.Text == "" || SellerPhoneTB.Text == "" || SellerPassTB.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    con.Open();
                    string query = "update SellerTBL set SellerName='" + SellerNameTB.Text + "',SellerAge='" + SellerAgeTB.Text + "',SellerPhone='" + SellerPhoneTB.Text + "',SellerPass='" + SellerPassTB.Text + "' where SellerID=" + SellerIDTB.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Updated Successfully");
                    con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            SellerIDTB.Text = "";
            SellerNameTB.Text = "";
            SellerAgeTB.Text = "";
            SellerPhoneTB.Text = "";
            SellerPassTB.Text = "";
        }

        private void product_Click(object sender, EventArgs e)
        {
            this.Hide();
            Product prod = new Product();
            prod.Show();
        }

        private void catagory_Click(object sender, EventArgs e)
        {
            this.Hide();
            Catagory cat = new Catagory();
            cat.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }
    }
}
