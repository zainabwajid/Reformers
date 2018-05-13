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
    public partial class frmQueries : Form
    {
        public frmQueries()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                      

            
            if (textBox1.Text == "")
            {
                MessageBox.Show("You must enter your name!");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("You must enter your email!");
            }
            else if (richTextBox1.Text == "")
            {
                MessageBox.Show("You must add some suggestion/query");
            }

            else if (textBox2.Text.Contains("@") == false || textBox2.Text.Contains(".com") == false)
            {
                MessageBox.Show("email must be in right format");
            }
            else
            {
                Suggestions s = new Suggestions();
                s.Suggestion = richTextBox1.Text;
                s.Yourname = textBox1.Text;
                s.Email2 = textBox2.Text;
                Dataclass.ADDsuggestion(s);
                MessageBox.Show("Sent");
                richTextBox1.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";
                frmProjects r = new frmProjects();
                this.Hide();
                r.Show();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void frmQueries_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.NGO;
        }
    }
}
