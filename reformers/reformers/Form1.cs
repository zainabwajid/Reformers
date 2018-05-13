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
    public partial class frmReformers : Form
    {
        public frmReformers()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.NGO;
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmRegister r = new frmRegister();
            this.Hide();
            r.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmProjects pro = new frmProjects();
            this.Hide();
            pro.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmadmin adm = new frmadmin();
            this.Hide();
            adm.Show();
        }
    }
}
