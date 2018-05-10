// JobForm.cs for SharpER
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
using System.Data.SqlClient;
using SharpERBLL;
using SharpERDAL;


namespace WindowsFormsApplication1
{
    public partial class JobForm : Form
    {
        public static List<Job> jobList;
        public Job job;
        public Job newJob;
        public bool addJob;

        public JobForm()
        {
            InitializeComponent();
        }

        private bool IsInt64 (string s)
        {
            try
            {
                Convert.ToInt64(s);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private bool IsPresent (Control control, string name)
        {
            if (control.GetType().ToString() == "System.Windows.Forms.TextBox")
            {
                TextBox textBox = (TextBox)control;
                if (textBox.Text == "")
                {
                    MessageBox.Show(name + " is a required field.", "ENTRY ERROR");
                    textBox.Focus();
                    return false;
                }
            }
            return true;
        }

        private bool IsDataValid()
        {
            if (jobBindingSource.Count > 0)
            {
                return IsPresent(jobAppliedDateTimePicker, "Date");
            }
            else
            {
                return true;
            }
        }

        private void toolStripButtonJobExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm.jobMainForm = null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void JobForm_Load(object sender, EventArgs e)
        {
            List<Contact> contactListing = ContactDB.GetAllContacts();
            contactFirstNameComboBox.DataSource = contactBindingSource;
            contactBindingSource.DataSource = contactListing;

            List<Company> companyListing = CompanyDB.GetAllCompanies();
            companyNameComboBox.DataSource = companyBindingSource;
            companyBindingSource.DataSource = companyListing;


            // Bindings need to be set, so I have to test here to see if it was an ADD or a MODIFY
            if (addJob == true) // This is the ADD
            {
                job = new Job();
                jobBindingSource.Clear();
                jobBindingSource.Add(job);
            }
            else  // This is the MODIFY
            {
                // Set Job to the row held by the jobBindingSource.Current
                // (wherever the user clicked in the grid)
                job = (Job)jobBindingSource.Current;

                newJob = new Job();

                newJob.JobID = job.JobID;
                newJob.JobPosition = job.JobPosition;
                newJob.JobApplied = job.JobApplied;
                newJob.JobPay = job.JobPay;
                newJob.JobContactID = job.JobContactID;
                newJob.JobCompanyID = job.JobCompanyID;
                newJob.JobNotes = job.JobNotes;

                jobBindingSource.Clear();
                jobBindingSource.Add(newJob);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsDataValid())
            {
                if (addJob)
                {
                    try
                    {
                        JobDB.AddJob(job);
                        this.DialogResult = DialogResult.OK;
                    }
                    catch (SqlException xsept)
                    {
                        MessageBox.Show(xsept.Message, xsept.GetType().ToString());
                    }
                    catch (Exception xsept)
                    {
                        MessageBox.Show(xsept.Message, xsept.GetType().ToString());
                    }
                }
                else
                {
                    try
                    {
                        if (!JobDB.UpdateModifyJob(job, newJob))
                        {
                            MessageBox.Show("Another user has updated or deleted that activity", "DATABASE ERROR");
                            this.DialogResult = DialogResult.Retry;
                        }
                        else
                        {
                            job = newJob;
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    catch (SqlException xsept)
                    {
                        MessageBox.Show(xsept.Message, xsept.GetType().ToString());
                    }
                    catch (Exception xsept)
                    {
                        MessageBox.Show(xsept.Message, xsept.GetType().ToString());
                    }
                }
                this.Close();
            }
        }

        private void companyNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (companyNameComboBox.SelectedIndex != -1)
            {
                this.jobCompanyIDTextBox.Text = companyNameComboBox.SelectedValue.ToString();
            }
        }

        private void contactFirstNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (contactFirstNameComboBox.SelectedIndex != -1)
            {
                this.jobContactIDTextBox.Text = contactFirstNameComboBox.SelectedValue.ToString();
            }
        }

    }
}
