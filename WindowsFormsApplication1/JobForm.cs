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
    public partial class JobForm : Form
    {
        public JobForm()
        {
            InitializeComponent();
        }

        private void lblJobInfoTitle_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonJobExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm.jobMainForm = null;
        }

        private void toolStripButtonJobSearchButton_Click(object sender, EventArgs e)
        {

        }

        private void JobForm_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            jobPositionTextBox.Clear();
            jobAppliedDateTimePicker.Format = DateTimePickerFormat.Custom;
            jobAppliedDateTimePicker.Value = DateTime.Now;
            // jobAppliedDateTimePicker.CustomFormat = "";
            jobPayTextBox.Clear();
            jobNotesTextBox.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }


        //private bool CloseProgram()
        //{
        //    if (MessageBox.Show("Are you sure you want to quit?", "LEAVING???????", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
        //    {
        //        this.Close();
        //        return true;
        //    }
        //    else
        //        return false;
        //}

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
