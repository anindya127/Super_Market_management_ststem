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
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();

            // Change the background to #C5FF95
            this.BackColor = Color.FromArgb(0xC5, 0xFF, 0x95);

            // Change the button collor to #074173
            catagory.BackColor = Color.FromArgb(0x07, 0x41, 0x73);
            seller.BackColor = Color.FromArgb(0x07, 0x41, 0x73);
            Add.BackColor = Color.FromArgb(0x07, 0x41, 0x73);
            edit.BackColor = Color.FromArgb(0x07, 0x41, 0x73);
            delete.BackColor = Color.FromArgb(0x07, 0x41, 0x73);
            refresh.BackColor = Color.FromArgb(0x07, 0x41, 0x73);
            logout.BackColor = Color.FromArgb(0x07, 0x41, 0x73);

            // Change the font color of the buttons to white
            catagory.ForeColor = Color.White;
            seller.ForeColor = Color.White;
            Add.ForeColor = Color.White;
            edit.ForeColor = Color.White;
            delete.ForeColor = Color.White;
            refresh.ForeColor = Color.White;
            logout.ForeColor = Color.White;

            // Change the label color to  #1679AB
            label1.ForeColor = Color.FromArgb(0x16, 0x79, 0xAB);
            label2.ForeColor = Color.FromArgb(0x16, 0x79, 0xAB);
            label3.ForeColor = Color.FromArgb(0x16, 0x79, 0xAB);
            label4.ForeColor = Color.FromArgb(0x16, 0x79, 0xAB);
            label5.ForeColor = Color.FromArgb(0x16, 0x79, 0xAB);
            label6.ForeColor = Color.FromArgb(0x16, 0x79, 0xAB);

            // Change the datagridview collor to white
            ProductDGV.BackgroundColor = Color.White;


        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vipar\OneDrive\Documents\Supermarketinventory.mdf;Integrated Security=True;Connect Timeout=30");

        private void fillcombo()
        {

            string query = "SELECT CatName from CatgoryTBL";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr;
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("CatName", typeof(string));
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                CatCB.ValueMember = "CatName";
                CatCB.DataSource = dt;
                con.Close();
            }
            catch
            {

            }
        }

        private void filecombo2()
        {
            con.Open();
            string query = "SELECT ProdCat from ProducTBL";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr;
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("ProdCat", typeof(string));
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                CatDB2.ValueMember = "ProdCat";
                CatDB2.DataSource = dt;
                con.Close();
            }
            catch
            {

            }

        }

        private void populate()
        {
            con.Open();
            string query = "SELECT * FROM ProducTBL";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProductDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Product_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void catagory_Click(object sender, EventArgs e)
        {
            this.Hide();
            Catagory cat = new Catagory();
            cat.Show();
        }

        private void seller_Click(object sender, EventArgs e)
        {
            this.Hide();
            Seller sell = new Seller();
            sell.Show();
        }

        private void CatCB_Click(object sender, EventArgs e)
        {
            fillcombo();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = $"INSERT INTO ProducTBL values({ProdIdTB.Text},'{ProdNameTB.Text}','{ProdQtyTB.Text}','{ProdPriceTB.Text}','{CatCB.SelectedValue}')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Added Successfully");
                con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ProdIdTB.Text = "";
            ProdNameTB.Text = "";
            ProdQtyTB.Text = "";
            ProdPriceTB.Text = "";
        }

        private void ProductDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fillcombo();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = ProductDGV.Rows[e.RowIndex];
                ProdIdTB.Text = row.Cells[0].Value.ToString();
                ProdNameTB.Text = row.Cells[1].Value.ToString();
                ProdQtyTB.Text = row.Cells[2].Value.ToString();
                ProdPriceTB.Text = row.Cells[3].Value.ToString();
                CatCB.SelectedValue = row.Cells[4].Value.ToString();
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProdIdTB.Text == "" || ProdNameTB.Text == "" || ProdQtyTB.Text == "" || ProdPriceTB.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    con.Open();
                    string query = $"UPDATE ProducTBL set ProdName='{ProdNameTB.Text}',ProdQty='{ProdQtyTB.Text}',ProdPri='{ProdPriceTB.Text}',ProdCat='{CatCB.SelectedValue}' WHERE ProdId={ProdIdTB.Text};";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Updated Successfully");
                    con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ProdIdTB.Text = "";
            ProdNameTB.Text = "";
            ProdQtyTB.Text = "";
            ProdPriceTB.Text = "";
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProdIdTB.Text == "")
                {
                    MessageBox.Show("Select The Product to Delete");
                }
                else
                {
                    con.Open();
                    string query = "DELETE FROM ProducTBL WHERE ProdId=" + ProdIdTB.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Deleted Successfully");
                    con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ProdIdTB.Text = "";
            ProdNameTB.Text = "";
            ProdQtyTB.Text = "";
            ProdPriceTB.Text = "";
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            populate();
            //reset the CatCB and CatDB2 default text
            CatCB.Text = "Select Catagory";
            CatDB2.Text = "Select Catagory";
        }

        private void CatDB2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // filter the data from the database by the selected category
                con.Open();
                string query = $"SELECT * FROM ProducTBL WHERE ProdCat='{CatDB2.SelectedValue}'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                ProductDGV.DataSource = ds.Tables[0];
                con.Close();

            }
            catch
            {

            }
        }

        private void CatDB2_Click(object sender, EventArgs e)
        {
            filecombo2();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }
    }
}
