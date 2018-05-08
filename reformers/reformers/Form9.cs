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
    public partial class frmViewVolunteer : Form
    {
        public frmViewVolunteer()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            BindingSource source = new BindingSource();
            source.DataSource = Dataclass.Vol;
            dataGridView1.DataSource = source;
            Dataclass.SHOWALL();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmData dat = new frmData();
            this.Hide();
            dat.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
