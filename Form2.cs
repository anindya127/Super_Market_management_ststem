using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarketinventory
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            // Change the background to #C5FF95
            this.BackColor = Color.FromArgb(0xC5, 0xFF, 0x95);

            // Change the label color to  #1679AB
            label1.ForeColor = Color.FromArgb(0x16, 0x79, 0xAB);
            label2.ForeColor = Color.FromArgb(0x16, 0x79, 0xAB);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            

            timer1.Start();

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        int StartPoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            StartPoint += 1;
            progressBar1.Value = StartPoint;
            if (progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                Form1 log = new Form1();
                log.Show();
                this.Hide();
            }
        }
    }
}
