using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

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
            //dataGridView1.ReadOnly = false;
            //dataGridView1.Columns[0].Visible = false;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void deleteRowToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
            }  
        }

        private void frmViewDonor_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.NGO;
        }
    }
}
