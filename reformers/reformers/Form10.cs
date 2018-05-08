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
    public partial class frmViewDonor : Form
    {
        public frmViewDonor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmData dat = new frmData();
            this.Hide();
            dat.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BindingSource source = new BindingSource();
            source.DataSource = Dataclass.Don;
            dataGridView1.DataSource = source;
            Dataclass.SHOW();
        }
    }
}
