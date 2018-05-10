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
        public static List<Activity> actList;
        public Activity activity;
        public Activity newActivity;
        public bool addActivity;

        public ActivityForm()
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
            if (activityBindingSource.Count > 0)
            {
                return
                    IsPresent(activityDateDateTimePicker, "Date");
            }
            else
            {
                return true;
            }
        }

        private void toolStripButtonActivityExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm.activityMainForm = null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ActivityForm_Load(object sender, EventArgs e)
        {
            List<Contact> contactListing = ContactDB.GetAllContacts();
            activityContactIDComboBox.DataSource = contactBindingSource;
            contactBindingSource.DataSource = contactListing;

            List<Job> jobListing = JobDB.GetAllJobs();
            ActivityJobIDComboBox.DataSource = jobBindingSource;
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
                activity = (Activity)activityBindingSource.Current;
                // (Cast from Object to real type)

                // Create a new (empty) activity: newActivity
                newActivity = new Activity();

                // Copy field by field data in activity
                // (i.e. newActivity.ActivityID = activity.ActivityID)
                newActivity.ActivityID = activity.ActivityID;
                newActivity.ActivityDate = activity.ActivityDate;
                newActivity.ActivityDescription = activity.ActivityDescription;
                newActivity.ActivityTravel = activity.ActivityTravel;
                newActivity.ActivityJobID = activity.ActivityJobID;
                newActivity.ActivityContactID = activity.ActivityContactID;
                newActivity.ActivityCompanyID = activity.ActivityCompanyID;
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
                        if (!ActivityDB.UpdateModifyActivity(activity, newActivity))
                        {
                            MessageBox.Show("Another user has updated or deleted that activity", "DATABASE ERROR");
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            activity = newActivity;
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

        private void activityContactIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (activityContactIDComboBox.SelectedIndex != -1)
            {
                this.activityContactIDTextBox.Text = activityContactIDComboBox.SelectedValue.ToString();
            }
        }

        private void ActivityJobIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ActivityJobIDComboBox.SelectedIndex != -1)
            {
                this.activityJobIDTextBox.Text = ActivityJobIDComboBox.SelectedValue.ToString();
            }
        }
    }
}
