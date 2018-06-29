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

        public static List<Contact> jobContactListing;
        public static ContactForm jobContForm = null;
        public static ContactForm contForm = null;

        public static List<Company> jobCompanyListing;
        public static CompanyForm jobCompForm = null;
        public static CompanyForm compForm = null;

        public JobForm()
        {
            InitializeComponent();
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
                return IsPresent(jobAppliedDateTimePicker, "Date") &&
                    IsPresent(jobPositionTextBox, "Position");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void JobForm_Load(object sender, EventArgs e)
        {
            List<Contact> contactListing = ContactDB.GetAllContacts();
            contactBindingSource.Clear();
            contactBindingSource.DataSource = contactListing;

            List<Company> companyListing = CompanyDB.GetAllCompanies();
            companyBindingSource.Clear();
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
                //job = (Job)jobBindingSource.Current;

                newJob = new Job();

                newJob.JobID = job.JobID;
                newJob.JobPosition = job.JobPosition;
                newJob.JobApplied = job.JobApplied;
                newJob.JobPay = job.JobPay;
                newJob.JobContactID = job.JobContactID;
                newJob.JobCompanyID = job.JobCompanyID;
                newJob.JobNotes = job.JobNotes;

                jobBindingSource.Clear();
                jobBindingSource.(newJob);
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
                    }
                    catch (SqlException xsept)
                    {
                        MessageBox.Show(xsept.Message, xsept.GetType().ToString());
                    }
                    catch (Exception xsept)
                    {
                        MessageBox.Show(xsept.Message, xsept.GetType().ToString());
                    }
                    finally
                    {
                        this.Close();
                    }
                }
                else
                {
                    try
                    {
                        if (!JobDB.UpdateModifyJob(job, newJob))
                        {
                            MessageBox.Show("Another user has updated or deleted that activity", "DATABASE ERROR");
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
                    finally
                    {
                        this.Close();
                    }
                }
            }
        }

        private void btnAddNewContactJobForm_Click(object sender, EventArgs e)
        {
            jobContForm = new ContactForm();
            jobContForm.addContact = true;
            jobContForm.ShowDialog();


            // Refreshes the contact list which will be reflected in the comboBox
            List<Contact> jobContactListing = ContactDB.GetAllContacts();
            contactBindingSource.DataSource = jobContactListing;

            // Makes the coboBox UNSELECTED so the user will have to pick a selection
            contactFirstNameComboBox.SelectedIndex = -1;

            // Makes the label for the user to select a job position VISIBLE
            lblContactReminderJobForm.Visible = true;
        }

        private void btnAddNewCompanyJobForm_Click(object sender, EventArgs e)
        {
            jobCompForm = new CompanyForm();
            jobCompForm.addCompany = true;
            jobCompForm.ShowDialog();

            // Refreshes the company list which will be reflected in the comboBox
            List<Company> jobCompanyListing = CompanyDB.GetAllCompanies();
            companyBindingSource.DataSource = jobCompanyListing;

            // Makes the comboBox UNSELECTED so the user will have to pick a selection
            companyNameComboBox.SelectedIndex = -1;

            // Makes the label for the user to select a company VISIBLE
            lblCompanyReminderJobForm.Visible = true;
        }

        private void companyNameComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (companyNameComboBox.SelectedIndex != -1)    // comboBox is NOT empty
            {
                lblCompanyReminderJobForm.Visible = false;   // They made a selection; therefore, the label disappears
            }
            else
            {
                lblCompanyReminderJobForm.Visible = true;  // They have not yet made a selection after returning to the form; therefore, the label IS visible 
            }
        }

        private void contactFirstNameComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (contactFirstNameComboBox.SelectedIndex != -1)   // comboBox is NOT empty 
            {
                lblContactReminderJobForm.Visible = false;   // They made a selection; therefore, the label disappears
            }
            else
            {
                lblContactReminderJobForm.Visible = true;  // They have not yet made a selection after returning to the form; therefore, the label IS visible 
            }
        }
    }
}
