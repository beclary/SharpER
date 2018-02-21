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
    public partial class SearchJobForm : Form
    {
        public static Form searchJobForm = null;

        public SearchJobForm()
        {
            InitializeComponent();
        }

        private void btnAddNewJob_Click(object sender, EventArgs e)
        {
            searchJobForm = new JobForm();
            searchJobForm.ShowDialog();
        }

        private void btnUpdateModifyJob_Click(object sender, EventArgs e)
        {
            searchJobForm = new JobForm();
            searchJobForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
