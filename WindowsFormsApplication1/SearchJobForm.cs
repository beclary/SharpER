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
    public partial class SearchJobForm : Form
    {
        public static Form jobForm = null;
        public static List<Job> jobListing;

        public SearchJobForm()
        {
            InitializeComponent();
        }

        private void btnAddNewJob_Click(object sender, EventArgs e)
        {
            jobForm = new JobForm();
            jobForm.ShowDialog();
        }

        private void btnUpdateModifyJob_Click(object sender, EventArgs e)
        {
            jobForm = new JobForm();
            jobForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SearchJobForm_Load(object sender, EventArgs e)
        {
            jobListing = JobDB.GetAllJobs();
            jobDataGridView.DataSource = jobBindingSource;
            jobBindingSource.DataSource = jobListing;
        }
    }
}
