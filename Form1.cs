using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Supermarketinventory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Change the background to #C5FF95
            this.BackColor = Color.FromArgb(0xC5, 0xFF, 0x95);

            // Change the button collor to #074173
            loginbut.BackColor = Color.FromArgb(0x07, 0x41, 0x73);
            clear.BackColor = Color.FromArgb(0x07, 0x41, 0x73);

            // Change the button text collor to white
            loginbut.ForeColor = Color.White;
            clear.ForeColor = Color.White;

            // Change the label color to  #1679AB
            label1.ForeColor = Color.FromArgb(0x16, 0x79, 0xAB);
            label2.ForeColor = Color.FromArgb(0x16, 0x79, 0xAB);
            Login.ForeColor = Color.FromArgb(0x16, 0x79, 0xAB);
            message.ForeColor = Color.FromArgb(0x16, 0x79, 0xAB);

            //login background color to #C5FF95
            Login.BackColor = Color.FromArgb(0xC5, 0xFF, 0x95);

        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vipar\OneDrive\Documents\Supermarketinventory.mdf;Integrated Security=True;Connect Timeout=30");

        private void Form1_Load(object sender, EventArgs e)
        {
            passwd.PasswordChar = '*';
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Show a message box with the message "Are you sure you want to exit?"
            DialogResult dialog = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            // If the user clicks on the Yes button, the application will close
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void loginbut_Click(object sender, EventArgs e)
        {
            if (role.Text == "Select Role")
            {
                MessageBox.Show("Select a Role");
            }
            else if (role.Text != "Select Role" && username.Text == "" && passwd.Text == "")
            {
                MessageBox.Show("Enter Username and Password");
            }
            else if (role.Text != "Select Role" && username.Text == "")
            {
                MessageBox.Show("Enter Username");
            }
            else if (role.Text != "Select Role" && passwd.Text == "")
            {
                MessageBox.Show("Enter Password");
            }
            else if (role.Text == "Admin" && username.Text == "Admin" && passwd.Text == "Admin")
            {
                MessageBox.Show("Login Successful");

                this.Hide();
                Product Prod = new Product();
                Prod.Show();
            }
            else if (role.Text == "Seller")
            {
                string query = "SELECT * FROM SellerTBL WHERE SellerName = '" + username.Text + "' AND SellerPass = '" + passwd.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    // store username inside a txt file in the same directory as the application
                    System.IO.File.WriteAllText("username.txt", username.Text);
                    MessageBox.Show("Login Successful");

                   
                    this.Hide();
                    Selling sell = new Selling();
                    sell.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }
            }

        }

        private void clear_Click(object sender, EventArgs e)
        {
            username.Text = "";
            passwd.Text = "";
            role.Text = "Select Role";
        }
    }
}
