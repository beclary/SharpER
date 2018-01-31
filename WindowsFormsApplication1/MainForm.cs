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

        private void btnContact_Click(object sender, EventArgs e)
        {
            if (contactMainForm == null)
            {
                contactMainForm = new ContactForm();
                contactMainForm.Show();
            }
        }

        private void btnCompany_Click(object sender, EventArgs e)
        {
            if (companyMainForm == null)
            {
                companyMainForm = new CompanyForm();
                companyMainForm.Show();
            }
        }

        private void btnActivity_Click(object sender, EventArgs e)
        {
            if (activityMainForm == null)
            {
                activityMainForm = new ActivityForm();
                activityMainForm.Show();
            }
        }

        private void btnJob_Click(object sender, EventArgs e)
        {
            if (jobMainForm == null)
            {
                jobMainForm = new JobForm();
                jobMainForm.Show();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void contactToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (contactMainForm == null)
            {
                contactMainForm = new ContactForm();
                
                contactMainForm.Show();
            }
        }
    }
}
