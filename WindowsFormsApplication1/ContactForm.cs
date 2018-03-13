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
            if (contactBindingSource.Count > 0)
            {
                return
                    IsPresent(contactFirstNameTextBox, "First Name") &&
                    IsPresent(contactLastNameTextBox, "Last Name");
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


        private void ContactForm_Load(object sender, EventArgs e)
        {
            // Bindings need to be set, so I have to test here to see if it was an 
            // ADD or a MODIFY
            if (addContact == true)
            {
                contact = new Contact();
                contactBindingSource.Clear();
                contactBindingSource.Add(contact);
            }
            else // this is the MODIFY
            {
                // Set contact to row held by bindingSource.Current (whatever the user clicked
                // in grid
                contact = (Contact)contactBindingSource.Current; // cast from Object to real type

                // Create new (empty) contact: newContact
                newContact = new Contact();

                // Copy field by field data in contact (i.e.: newContact.ContactID = contact.ContactID)
                newContact.ContactID = contact.ContactID;
                newContact.ContactFirstName = contact.ContactFirstName;
                newContact.ContactLastName = contact.ContactLastName;
                newContact.ContactTitle = contact.ContactTitle;
                newContact.ContactDepartment = contact.ContactDepartment;
                newContact.ContactAddress = contact.ContactAddress;
                newContact.ContactCity = contact.ContactCity;
                newContact.ContactState = contact.ContactState;
                newContact.ContactZipCode = contact.ContactZipCode;
                newContact.ContactContactedVia = contact.ContactContactedVia;
                newContact.ContactPhone = contact.ContactPhone;
                newContact.ContactMobile = contact.ContactMobile;
                newContact.ContactFax = contact.ContactFax;
                newContact.ContactEmail = contact.ContactEmail;
                newContact.ContactNotes = contact.ContactNotes;

                // Set Binding (see p. 285)
                contactBindingSource.Clear();
                contactBindingSource.Add(newContact);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsDataValid())
            {
                if (addContact)
                {

                    //contact = new Contact();
                    //this.PopulateContactDataForViewing(contact);
                    try
                    {
                        ContactDB.AddContact(contact);
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
                    //newContact = new Contact();
                    //newContact.ContactID = contact.ContactID;
                    //this.PopulateContactDataForViewing(newContact);
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
                            //ContactDB.UpdateModifyContact(contact, newContact);
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
                //MessageBox.Show("Data was saved. YeeHaa", "SUCCESS");
                this.Close();
            }
        }


        private void contactStateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

