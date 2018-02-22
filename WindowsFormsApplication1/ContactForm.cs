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
    public partial class ContactForm : Form
    {
        public ContactForm()
        {
            InitializeComponent();
        }

        private bool IsInt64(string s)
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
            }
            return true;
        }

        private bool IsDataValid()
        {
            if (contactBindingSource.Count > 0)
            {
                return
                    IsPresent(contactFirstNameTextBox, "First Name") &&
                    IsPresent(contactLastNameTextBox, "Last Name") &&
                    IsPresent(contactTitleTextBox, "Title") &&
                    IsPresent(contactDepartmentTextBox, "Department") &&
                    IsPresent(contactAddressTextBox, "Address") &&
                    IsPresent(contactCityTextBox, "City") &&
                    IsPresent(contactStateComboBox, "State") &&
                    IsPresent(contactZipCodeMaskedTextBox, "Zip Code") &&
                    IsPresent(contactContactedViaComboBox, "Contacted via") &&
                    IsPresent(contactPhoneMaskedTextBox, "Phone number") &&
                    IsPresent(contactMobileMaskedTextBox, "Mobile number") &&
                    IsPresent(contactEmailTextBox, "Email");
            }
            else
                return true;
        }

    private void toolStripButtonContactExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm.contactMainForm = null;
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private bool CloseProgram()
        {
            if (MessageBox.Show("Are you sure you want to quit?", "LEAVING???????", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
                return true;
            }
            else
                return false;
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            CloseProgram();
        }

        // Method for populating the textboxes with the data
        private void DisplayContact()
        {
            
        }

        // method for clearing the updates or modifications the user makes
        private void btnClear_Click(object sender, EventArgs e)
        {
            contactFirstNameTextBox.Clear();
            contactLastNameTextBox.Clear();
            contactTitleTextBox.Clear();
            contactDepartmentTextBox.Clear();
            contactAddressTextBox.Clear();
            contactCityTextBox.Clear();
            contactStateComboBox.SelectedIndex = -1;
            contactZipCodeMaskedTextBox.Clear();
            contactContactedViaComboBox.SelectedIndex = -1;
            contactPhoneMaskedTextBox.Clear();
            contactMobileMaskedTextBox.Clear();
            contactFaxMaskedTextBox.Clear();
            contactEmailTextBox.Clear();
            contactNotesTextBox.Clear();
        }
    }
}
