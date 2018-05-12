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
    public partial class frmDonor : Form
    {
        public frmDonor()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmRegister r = new frmRegister();
            r.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            
            Donor d = new Donor();
            d.Name = textBox1.Text;
            d.Contact = textBox2.Text;
            d.Email1 = textBox3.Text;
            d.Cnic1 = textBox4.Text;
            d.Age1 = textBox5.Text;
            d.Gender1 = textBox6.Text;
            d.Profession1 = textBox7.Text;
            d.Address1 = textBox8.Text;
            if (checkBox1.Checked == true)
            {
                d.Donate = "Easy Paisa";
            }
            else if (checkBox2.Checked == true)
            {
                d.Donate = "Money Order";
            }
            else if (checkBox3.Checked == true)
            {
                d.Donate = "Receive cash from doorstep";
            }
            else if (checkBox4.Checked == true)
            {
                d.Donate = "Courier goods";
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;


            Random random = new Random();
            int a = random.Next(100, 1000000);
            d.Id1 = a;
            
                
           

            Dataclass.ADDdonor(d);

        

           

            MessageBox.Show("Thankyou for registration!");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
        
        }
    }
}
