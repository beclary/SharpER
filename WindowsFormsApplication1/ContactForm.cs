using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
    public partial class ContactForm : Form
    {
        public static List<Contact> conList;
        public Contact contact;
        public Contact newContact;
        public bool addContact;

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
            //if (control.GetType().ToString() == "System.Windows.Forms.TextBox")
            //{
            //    TextBox textBox = (TextBox)control;
            //    if (textBox.Text == "")
            //    {
            //        MessageBox.Show(name + " is a required field.", "ENTRY ERROR");
            //        textBox.Focus();
            //        return false;
            //    }
            //}
   //         else 
            if (control.GetType().ToString() == "System.Windows.Forms.ComboBox")
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
                    IsPresent(contactFaxMaskedTextBox, "Fax number") &&
                    IsPresent(contactEmailTextBox, "Email") &&
                    IsPresent(contactNotesTextBox, "Notes");
            }
            else
                return true;
        }

        private void toolStripButtonContactExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm.contactMainForm = null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Method for clearing the updates or modifications the user makes
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

        private void ContactForm_Load(object sender, EventArgs e)
        {
            // Bindings need to be set, so I have to test here to see if it was an 
            // ADD or a MODIFY
            if (addContact == true)
            {
                contact = new Contact();
                contactBindingSource.Add(contact);
            }
            else
            {
                contact = new Contact();
         //       contactBindingSource.DataSource 
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsDataValid())
            {
                if (addContact)
                {
                    contact.ContactState = contactStateComboBox.Text.ToString();
                    contact.ContactContactedVia = contactContactedViaComboBox.Text.ToString();
                    contact.ContactID = ContactDB.AddContact(contact);
                    this.DialogResult = DialogResult.OK;

                    //contact = new Contact();
                    //this.PopulateContactData(contact);
                    //try
                    //{
                    //}
                    //catch (SqlException xsept)
                    //{
                    //    MessageBox.Show(xsept.Message, xsept.GetType().ToString());
                    //}
                    //catch (Exception xsept)
                    //{
                    //    MessageBox.Show(xsept.Message, xsept.GetType().ToString());
                    //}
                }
                else
                {
                    newContact = new Contact();
                    newContact.ContactID = contact.ContactID;
                    this.PopulateContactData(newContact);
                    try
                    {
                        if (!ContactDB.UpdateModifyContact(contact, newContact))
                        {
                            MessageBox.Show("Another user has updated or deleted that contact",
                                "Database Error");
                            this.DialogResult = DialogResult.Retry;
                        }
                        else
                        {
                            contact = newContact;
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
            }
        }

        private void PopulateContactData (Contact contact)
        {
            contact.ContactFirstName = contactFirstNameTextBox.Text;
            contact.ContactLastName = contactLastNameTextBox.Text;
            contact.ContactTitle = contactTitleTextBox.Text;
            contact.ContactDepartment = contactDepartmentTextBox.Text;
            contact.ContactAddress = contactAddressTextBox.Text;
            contact.ContactCity = contactCityTextBox.Text;
            contact.ContactState = contactStateComboBox.SelectedValue.ToString();
            contact.ContactZipCode = contactZipCodeMaskedTextBox.ToString();
            contact.ContactContactedVia = contactContactedViaComboBox.SelectedValue.ToString();
            contact.ContactPhone = contactPhoneMaskedTextBox.ToString();
            contact.ContactMobile = contactMobileMaskedTextBox.ToString();
            contact.ContactFax = contactFaxMaskedTextBox.ToString();
            contact.ContactEmail = contactEmailTextBox.Text;
            contact.ContactNotes = contactNotesTextBox.Text;
        }

        private void contactStateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

