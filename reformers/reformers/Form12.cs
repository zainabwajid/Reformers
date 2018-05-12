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
    public partial class frmSuggestion : Form
    {
        public frmSuggestion()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            source.DataSource = Dataclass.Sug;
            dataGridView1.DataSource = source;
            Dataclass.SHOWall();
            
        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }
    }
}
