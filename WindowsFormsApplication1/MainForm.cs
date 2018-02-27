using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpERBLL;
using SharpERDAL;

namespace WindowsFormsApplication1
{
    public partial class MainForm : Form
    {
        public static Form contactMainForm = null;
        public static Form companyMainForm = null;
        public static Form activityMainForm = null;
        public static Form jobMainForm = null;
        public static Form searchContactForm = null;
        public static Form searchCompanyForm = null;
        public static Form searchActivityForm = null;
        public static Form searchJobForm = null;

        List<Contact> contactList;


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
            contactList = new List<Contact>();
        }


        /*       private void contactToolStripMenuItem_Click_1(object sender, EventArgs e)
               {
                   contactMainForm = new ContactForm();
                   contactMainForm.ShowDialog();
               }
       */

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
        }

        private void companyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            companyMainForm = new CompanyForm();
            companyMainForm.ShowDialog();
        }

        private void tablesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contactMainForm = new SearchContactForm();
            contactMainForm.ShowDialog();
        }

        private void companyToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            companyMainForm = new SearchCompanyForm();
            companyMainForm.ShowDialog();
        }

        private void activityToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            activityMainForm = new SearchActivityForm();
            activityMainForm.ShowDialog();
        }

        private void jobToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            jobMainForm = new SearchJobForm();
            jobMainForm.ShowDialog();
        }
    }
}
