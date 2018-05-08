using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reformers
{
    public partial class frmadmin : Form
    {
        public frmadmin()
        {
            InitializeComponent();
        }

        private void frmadmin_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmReformers refo = new frmReformers();
            this.Hide();
            refo.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "maryamnawaz" || textBox1.Text == "zainabwajid") && textBox2.Text == "admin12")
            {

                frmData dat = new frmData();
                this.Hide();
                dat.Show();

            }
            else
            {
                MessageBox.Show("Invalid Login Attempt");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
