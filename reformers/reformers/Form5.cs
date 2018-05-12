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
using System.IO;

namespace reformers
{
    public partial class frmViewWorker : Form
    {
        public frmViewWorker()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmRegister r = new frmRegister();
            r.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
           // dialog.Filter = "|*.docs";
            dialog.Multiselect = false;
           // dialog.ShowDialog();
            dialog.InitialDirectory = "C://Desktop";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (dialog.CheckFileExists)
                {
                    string path = System.IO.Path.GetFullPath(dialog.FileName);
                    label1.Text = path;
                }
            }
            else
            {
                MessageBox.Show("Please Upload document.");
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {
           
        }

        private void eventLog1_EntryWritten(object sender, System.Diagnostics.EntryWrittenEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
       
    }
}
