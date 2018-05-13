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
    public partial class frmData : Form
    {
        public frmData()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmViewVolunteer vol = new frmViewVolunteer();
            this.Hide();
            vol.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmViewDonor don = new frmViewDonor();
            this.Hide();
            don.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmReformers refo = new frmReformers();
            this.Hide();
            refo.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            frmSuggestion s = new frmSuggestion();
            s.Show();
            this.Hide();
        }

        private void frmData_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.NGO;
        }
    }
}
