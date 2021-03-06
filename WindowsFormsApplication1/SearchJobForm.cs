﻿// SearchJobForm.cs for SharpER
// Bruce Clary

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
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class SearchJobForm : Form
    {
        public static JobForm jobForm = null;
        public static List<Job> jobListing;
        public static Job job;
        public static int jobID = 0;
        public int oldJob;
        public int newJob;

        public SearchJobForm()
        {
            InitializeComponent();
        }

        private void SearchJobForm_Load(object sender, EventArgs e)
        {
            // Loads the gridview listing of all jobs.
            jobListing = JobDB.GetAllJobs();
            jobDataGridView.DataSource = jobBindingSource;
            jobBindingSource.DataSource = jobListing;
            jobDataGridView.ClearSelection();
        }

        private void btnUpdateModifyJob_Click(object sender, EventArgs e)
        {
            JobForm modifyForm = new JobForm();
            modifyForm.newJob = (Job)jobBindingSource.Current;
            modifyForm.job = (Job)jobBindingSource.Current;
            modifyForm.jobBindingSource.Clear();
            modifyForm.ShowDialog();

            // Refreshes the gridview
            jobListing = JobDB.GetAllJobs();
            jobDataGridView.DataSource = jobBindingSource;
            jobBindingSource.DataSource = jobListing;
            jobDataGridView.ClearSelection();
        }

        private void btnAddNewJob_Click(object sender, EventArgs e)
        {
            jobForm = new JobForm();
            jobForm.addJob = true;
            jobForm.ShowDialog();

            // Refreshes the gridview
            jobListing = JobDB.GetAllJobs();
            jobDataGridView.DataSource = jobBindingSource;
            jobBindingSource.DataSource = jobListing;
            jobDataGridView.ClearSelection();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteJob_Click(object sender, EventArgs e)
        {
            Job delJob = (Job)jobBindingSource.Current;
            jobID = delJob.JobID;

            try
            {
                if (MessageBox.Show("Deleting the job with the position of " + delJob.JobPosition +
                    " from the database is an action that can NOT be undone!\n\nAre you sure you want to delete this job?", "CONFIRM DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    JobDB.DeleteJob(jobID);
                }

                // Refreshes the gridview
                jobListing = JobDB.GetAllJobs();
                jobDataGridView.DataSource = jobBindingSource;
                jobBindingSource.DataSource = jobListing;
                jobDataGridView.ClearSelection();

                List<Job> activityJobListing = JobDB.GetAllJobs();
            }
            catch (SqlException xsept)
            {
                throw xsept;
            }
            catch (Exception xsept)
            {
                throw xsept;
            }
        }

        private void jobDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            DataGridViewRow row = jobDataGridView.Rows[i];
            DataGridViewCell cell = row.Cells[0];
            int companyRowSelected = (int)cell.Value;
        }

        private void btnResetJobGridview_Click(object sender, EventArgs e)
        {
            // Loads the gridview list of all jobs, or in this case, refreshes it from whatever seacrh they have done and gives them the original gridview listing
            jobListing = JobDB.GetAllJobs();
            jobDataGridView.DataSource = jobBindingSource;
            jobBindingSource.DataSource = jobListing;
            jobDataGridView.ClearSelection();
        }
    }
}
