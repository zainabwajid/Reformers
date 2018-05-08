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

        }

        private void button1_Click(object sender, EventArgs e)
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
            v.Join = textBox10.Text;

            Random random = new Random();
            int a = random.Next(100, 1000000);
            v.Id = a;
            Dataclass.ADDvolunteer(v);
            

            MessageBox.Show("Thankyou for registration!");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
