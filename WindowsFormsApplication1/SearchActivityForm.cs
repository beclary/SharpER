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
    public partial class SearchActivityForm : Form
    {
        public static Form activityForm = null;
        public static List<Activity> activityListing;

        public SearchActivityForm()
        {
            InitializeComponent();
        }

        private void SearchActivityForm_Load(object sender, EventArgs e)
        {
            activityListing = ActivityDB.GetAllActivities();
            activityDataGridView.DataSource = activityBindingSource;
            activityBindingSource.DataSource = activityListing;
        }

        private void btnAddNewActivity_Click(object sender, EventArgs e)
        {
            activityForm = new ActivityForm();
            activityForm.ShowDialog();
        }

        private void btnUpdateModifyActivity_Click(object sender, EventArgs e)
        {
            activityForm = new ActivityForm();
            activityForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
