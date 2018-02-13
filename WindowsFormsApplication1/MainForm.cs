using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MainForm : Form
    {
        public static Form contactMainForm = null;
        public static Form companyMainForm = null;
        public static Form activityMainForm = null;
        public static Form jobMainForm = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }


        private void contactToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            contactMainForm = new ContactForm();
            contactMainForm.ShowDialog();
        }


        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void activityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activityMainForm = new ActivityForm();
            activityMainForm.ShowDialog();
        }

        private void jobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jobMainForm = new JobForm();
            jobMainForm.ShowDialog();
            this.Close();
        }

        private void companyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            companyMainForm = new CompanyForm();
            companyMainForm.ShowDialog();
        }

        private void tablesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
