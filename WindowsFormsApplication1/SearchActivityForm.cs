﻿// SearchActivityForm.cs UI for SharpER
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
    public partial class SearchActivityForm : Form
    {
        public static ActivityForm activityForm = null;
        public static List<Activity> activityListing;
        public static Activity activity;
        public static int actID = 0;
        public int oldActivity;
        public int newActivity;

        public SearchActivityForm()
        {
            InitializeComponent();
        }

        private void btnUpdateModifyActivity_Click(object sender, EventArgs e)
        {
            ActivityForm modifyForm = new ActivityForm();
            //modifyForm.newActivity = (Activity)activityBindingSource.Current;
            modifyForm.activity = (Activity)activityBindingSource.Current;
            modifyForm.addActivity = false;
            modifyForm.ShowDialog();

            // Refreshes the gridview
            activityListing = ActivityDB.GetAllActivities();
            activityDataGridView.DataSource = activityBindingSource;
            activityBindingSource.DataSource = activityListing;
            activityDataGridView.ClearSelection();
        }

        private void btnAddNewActivity_Click(object sender, EventArgs e)
        {
                activityForm = new ActivityForm();
                activityForm.addActivity = true;
                activityForm.ShowDialog();

                // Refreshes the gridview
                activityListing = ActivityDB.GetAllActivities();
                activityDataGridView.DataSource = activityBindingSource;
                activityBindingSource.DataSource = activityListing;
                activityDataGridView.ClearSelection();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchActivityForm_Load(object sender, EventArgs e)
        {
            // Loads the gridview listing of all activities
            activityListing = ActivityDB.GetAllActivities();
            activityDataGridView.DataSource = activityBindingSource;
            activityBindingSource.DataSource = activityListing;
            activityDataGridView.ClearSelection();
        }

        private void btnDeleteActivity_Click(object sender, EventArgs e)
        {
            Activity delActivity = (Activity)activityBindingSource.Current;
            int actID = delActivity.ActivityID;

            try
            {
                if (MessageBox.Show("Deleting activity on the date " + delActivity.ActivityDate + 
                    " from the database is an action that can NOT be undone!\n\nAre you sure you want to delete this activity?", "CONFIRM DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    ActivityDB.DeleteActivity(actID);
                }

                // Refreshes the gridview
                activityListing = ActivityDB.GetAllActivities();
                activityDataGridView.DataSource = activityBindingSource;
                activityBindingSource.DataSource = activityListing;
                activityDataGridView.ClearSelection();

                List<Contact> activityContactListing = ContactDB.GetAllContacts();
                //contactBindingSource.DataSource = activityContactListing;

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

        private void activityDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            DataGridViewRow row = activityDataGridView.Rows[i];
            DataGridViewCell cell = row.Cells[0];
            int activityRowSelected = (int)cell.Value;
        }

        private void btnResetActivityGridview_Click(object sender, EventArgs e)
        {
            // Loads the gridview list of all activities, or in this case, refreshes it from whatever search they have done and gives them the original gridview listing
            activityListing = ActivityDB.GetAllActivities();
            activityDataGridView.DataSource = activityBindingSource;
            activityBindingSource.DataSource = activityListing;
            activityDataGridView.ClearSelection();
            mtbActivityDate.Clear();
            txtActivityDescription.Clear();
        }
    }
}
