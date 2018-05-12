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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true && checkBox2.Checked == false && checkBox3.Checked == false)
            {
                frmViewWorker w = new frmViewWorker();
                w.Show();
                this.Hide();
            }
            else if (checkBox1.Checked == false && checkBox2.Checked == true && checkBox3.Checked == false)
            {
                frmVolunteer v = new frmVolunteer();
                v.Show();
                this.Hide();
            }
            if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == true)
            {
                frmDonor d = new frmDonor();
                d.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmReformers r = new frmReformers();
            r.Show();
            this.Hide();
        }
    }
}
