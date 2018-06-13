// ActivityForm.cs for SharpER
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
    public partial class ActivityForm : Form
    {

        public static List<Contact> activityContactListing;
        public static ContactForm actContForm = null;
        public static ContactForm contForm = null;

        public static List<Job> jobContactListing;
        public static JobForm actJobForm = null;
        public static JobForm jobForm = null;

        public static List<Activity> actList;
        public Activity activity;
        public Activity newActivity;
        public bool addActivity;


        public ActivityForm()
        {
            InitializeComponent();
        }

        private bool IsPresent(Control control, string name)
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
                else
                    return true;
            }
            else if (control.GetType().ToString() == "System.Windows.Forms.ComboBox")
            {
                ComboBox comboBox = (ComboBox)control;
                if (comboBox.SelectedIndex == -1)
                {
                    MessageBox.Show(name + " is a required field.", "ENTRY ERROR");
                    comboBox.Focus();
                    return false;
                }
                else
                    return true;
            }
            return true;
        }

        private bool IsDataValid()
        {
            return
                IsPresent(activityDescriptionTextBox, "Description") &&
                IsPresent(activityDateDateTimePicker, "Date");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActivityForm_Load(object sender, EventArgs e)
        {
            List<Contact> contactListing = ContactDB.GetAllContacts();
            contactBindingSource.Clear();
            contactBindingSource.DataSource = contactListing;

            List<Job> jobListing = JobDB.GetAllJobs();
            jobBindingSource.DataSource = jobListing;

            // Bindings need to be set, so I have to test here to see if it was an
            // ADD or MODIFY
            if (addActivity == true) // This is the ADD
            {
                activity = new Activity();
                activityBindingSource.Clear();
                activityBindingSource.Add(activity);
            }
            else // This is the MODIFY
            {
                // Set activity to the row held by the activityBindingSource.Current
                // (whatever the user clicked in the grid)

                //activity = (Activity)activityBindingSource.Current; (((( Not Needed ))))
                // (Cast from Object to real type)

                // Create a new (empty) activity: newActivity
                newActivity = new Activity();

                // Copy field by field data in activity (i.e. newActivity.ActivityID = activity.ActivityID)
                newActivity.ActivityID = activity.ActivityID;
                newActivity.ActivityDate = activity.ActivityDate;
                newActivity.ActivityDescription = activity.ActivityDescription;
                newActivity.ActivityTravel = activity.ActivityTravel;
                newActivity.ActivityContactID = activity.ActivityContactID;
                newActivity.ActivityJobID = activity.ActivityJobID;
                newActivity.ActivityNotes = activity.ActivityNotes;

                // Set binding (see p.285)
                activityBindingSource.Clear();
                activityBindingSource.Add(newActivity);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsDataValid())
            {
                if (addActivity)
                {
                    try
                    {
                        ActivityDB.AddActivity(activity);
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
                        if (!ActivityDB.UpdateModifyActivity(activity, newActivity))
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

        private void btnAddNewContact_Click(object sender, EventArgs e)
        {
            actContForm = new ContactForm();
            actContForm.addContact = true;
            actContForm.ShowDialog();

            // Refreshes the contact list which will be reflected in the comboBox
            List<Contact> activityContactListing = ContactDB.GetAllContacts();
            contactBindingSource.DataSource = activityContactListing;

            // Makes the comboBox UNSELECTED so the user will have to pick a selection
            activityContactIDComboBox.SelectedIndex = -1;

            // Makes the label for the user to select a contact name VISIBLE
            lblContactReminder.Visible = true;
        }

        private void btnAddJob_Click(object sender, EventArgs e)
        {
            actJobForm = new JobForm();
            actJobForm.addJob = true;
            actJobForm.ShowDialog();

            // Refreshes the job list which will be reflected in the comboBox
            List<Job> activityJobListing = JobDB.GetAllJobs();
            jobBindingSource.DataSource = activityJobListing;

            // Makes the comboBox UNSELECTED so the user will have to pick a selection
            activityJobIDComboBox.SelectedIndex = -1;

            // Makes the label for the user to select a job position VISIBLE
            lblJobReminder.Visible = true; 
        }

        private void activityJobIDComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (activityJobIDComboBox.SelectedIndex != -1) // comboBox is NOT empty
            {
                lblJobReminder.Visible = false;  // They made a selection; therefore, the label disappears
            }
            else
            {
                lblJobReminder.Visible = true; // They have not yet made a selection after returning to the form; therefore, the label IS visible 
            }
        }

        private void activityContactIDComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (activityContactIDComboBox.SelectedIndex != -1)  // comboBox is NOT empty
            {
                lblContactReminder.Visible = false; // They made a selection; therefore, the label disappears
            }
            else
            {
                lblContactReminder.Visible = true;  // They have not yet made a selection after returning to the form; therefore, the label IS visible 
            }
        }

        private void activityTravelComboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }
    }
}

