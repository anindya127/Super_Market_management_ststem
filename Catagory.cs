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
    public partial class Catagory : Form
    {
        public Catagory()
        {
            InitializeComponent();

            // Change the background to #C5FF95
            this.BackColor = Color.FromArgb(0xC5, 0xFF, 0x95);

            // Change the button collor to #074173
            Add.BackColor = Color.FromArgb(0x07, 0x41, 0x73);
            delete.BackColor = Color.FromArgb(0x07, 0x41, 0x73);
            edit.BackColor = Color.FromArgb(0x07, 0x41, 0x73);
            product.BackColor = Color.FromArgb(0x07, 0x41, 0x73);
            seller.BackColor = Color.FromArgb(0x07, 0x41, 0x73);
            logout.BackColor = Color.FromArgb(0x07, 0x41, 0x73);

            // Change the button text collor to white
            Add.ForeColor = Color.White;
            delete.ForeColor = Color.White;
            edit.ForeColor = Color.White;
            product.ForeColor = Color.White;
            seller.ForeColor = Color.White;
            logout.ForeColor = Color.White;

            // Change the label color to  #1679AB
            label1.ForeColor = Color.FromArgb(0x16, 0x79, 0xAB);
            label2.ForeColor = Color.FromArgb(0x16, 0x79, 0xAB);
            label3.ForeColor = Color.FromArgb(0x16, 0x79, 0xAB);
            label4.ForeColor = Color.FromArgb(0x16, 0x79, 0xAB);

            // Change the datagridview collor to white
            CatDGV.BackgroundColor = Color.White;

        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vipar\OneDrive\Documents\Supermarketinventory.mdf;Integrated Security=True;Connect Timeout=30");

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO CatgoryTBL values(" + CatidTB.Text + ",'" + CatNameTB.Text + "','" + CatDescTB.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Catagory Added Successfully");
                con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            CatidTB.Text = "";
            CatNameTB.Text = "";
            CatDescTB.Text = "";
        }

        private void populate()
        {
            con.Open();
            string query = "SELECT * FROM CatgoryTBL";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CatDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void Catagory_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void CatDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatidTB.Text == "")
                {
                    MessageBox.Show("Select The Catagory to Delete");
                }
                else
                {
                    con.Open();
                    string query = "DELETE FROM CatgoryTBL WHERE Catid=" + CatidTB.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Catagory Deleted Successfully");
                    con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            CatidTB.Text = "";
            CatNameTB.Text = "";
            CatDescTB.Text = "";

        }

        private void CatDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = CatDGV.Rows[e.RowIndex];
                CatidTB.Text = row.Cells[0].Value.ToString();
                CatNameTB.Text = row.Cells[1].Value.ToString();
                CatDescTB.Text = row.Cells[2].Value.ToString();
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatidTB.Text == "" || CatNameTB.Text == "" || CatDescTB.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    con.Open();
                    string query = "UPDATE CatgoryTBL set CatName='" + CatNameTB.Text + "',CatDasc='" + CatDescTB.Text + "' WHERE Catid=" + CatidTB.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Catagory Updated Successfully");
                    con.Close();
                    populate();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            CatidTB.Text = "";
            CatNameTB.Text = "";
            CatDescTB.Text = "";
        }

        private void product_Click(object sender, EventArgs e)
        {
            this.Hide();
            Product product = new Product();
            product.Show();
        }

        private void seller_Click(object sender, EventArgs e)
        {
            this.Hide();
            Seller seller = new Seller();
            seller.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }
    }
}
