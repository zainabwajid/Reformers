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
    public partial class frmVolunteer : Form
    {
        public frmVolunteer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmRegister r = new frmRegister();
            r.Show();
            this.Hide();
        }

        private void frmVolunteer_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.NGO;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 5)
            {
                MessageBox.Show("Enter your name having length greater than 5");
            }
            else if (textBox2.Text.Length < 11 && textBox2.Text.Length > 11)
            {
                MessageBox.Show("Enter your valid contact number");
            }
            else if (!textBox3.Text.Contains("@gmail.com"))
            {
                MessageBox.Show("Enter your valid Email Adress");
            }
            else if (textBox4.Text.Length < 13 && textBox4.Text.Length > 13)
            {
                MessageBox.Show("Enter your valid CNIC number");
            }
            else if (textBox6.Text != "Male" && textBox6.Text != "Female")
            {
                MessageBox.Show("Enter A valid Gender");
            }
            else if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "")
            {
                MessageBox.Show("please fill All the feilds");
            }
           
            else
            {
                Volunteer v = new Volunteer();
                v.Username = textBox1.Text;
                v.Contactno = textBox2.Text;
                v.Email = textBox3.Text;
                v.Cnic = textBox4.Text;
                v.Age = textBox5.Text;
                v.Gender = textBox6.Text;
                v.Profession = textBox7.Text;
                v.Address = textBox8.Text;
                v.Skill = textBox9.Text;
                v.Join = richTextBox1.Text;

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                richTextBox1.Text = "";

                Random random = new Random();
                int a = random.Next(100, 1000000);
                v.Id = a;
                Dataclass.ADDvolunteer(v);


                MessageBox.Show("Thankyou for registration!");

                
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
