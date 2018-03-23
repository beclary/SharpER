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

        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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
        }

        private void companyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            companyMainForm = new CompanyForm();
            companyMainForm.ShowDialog();
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

        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is an application that will be used by me to do job searches and record the different contacts that I make through job searches, the companies I am interested in working for, jobs that may be offered through said companies, or other companies or businesses, and the different activities I undertake to obtain, process and receive from various companies, jobs and contacts.\n\nThis will be used throughout the remainder of my course here as well as my job searching when my program here is completed. I hope to keep this throughout the remainder of my working career to keep and maintain any job related information.", "APPLICATION INFORMATION");
        }

        private void developerInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This application was developed by Bruce Clary, while studying computer programming at South Carolina Vocational Rehabilitation, Information Technology and Training Center in Columbia, South Carolina.\n\nBruce is a hard-working fellow who aspires to be useful as a computer programmer someday. As far as the field of developing, as a result of having two beautiful teenage daughters,he has \"developed\" a shiny head of silver-gray hair.\nHis contact information is as follows:\n\n\tBruce Clary\n\t400 Forest Lane Drive\n\tGaffney, South Carolina 29340\n\tMobile: 864.300.7714\n\tEmail: bruce.clary72z@gmail.com", "DEVELOPER INFORMATION");
        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Latest version: 1.1", "SharpER Version Information");
        }
    }
}
