using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpERDAL;
using SharpERBLL;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class SearchContactForm : Form
    {
        public static ContactForm contactForm = null;
        public static List<Contact> contactListing;
        public static Contact contact;
        public static int conID = 0;
        public int oldContact;
        public int newContact;

        public SearchContactForm()
        {
            InitializeComponent();
        }

        private void btnUpdateModifyContact_Click(object sender, EventArgs e)
        {
            Contact modifyContact = (Contact)contactBindingSource.Current;
            Contact newContact = new Contact();
            int conID = modifyContact.ContactID;

            try
            {
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

                // Set Binding
                contactBindingSource.Add(contact);
                contactBindingSource.Clear();



                //      MessageBox.Show("Contact ID is: " + conID.ToString(), "ERROR", MessageBoxButtons.OK);
                //ContactForm view = new ContactForm();
                //view.PopulateContactDataForViewing(contact);

                //view.ShowDialog();


                ContactDB.UpdateModifyContact(contact, newContact);
                // Refreshes the list
                contactListing = ContactDB.GetAllContacts();
                contactDataGridView.DataSource = contactBindingSource;
                contactBindingSource.DataSource = contactListing;



            }
            catch (SqlException xsept)
            {
                throw xsept;
            }
            catch (Exception xsept)
            {
                throw xsept;
            }
            finally
            {

            }



            //contactForm = new ContactForm();
            //contactDataGridView.DataSource = contactBindingSource;
            //contactBindingSource.DataSource = contactListing;
            //contactForm.ShowDialog();
            
        }

        private void btnAddNewContact_Click(object sender, EventArgs e)
        {
            contactForm = new ContactForm();
            contactForm.addContact = true;
            contactForm.ShowDialog();

            contactListing = ContactDB.GetAllContacts();
            contactDataGridView.DataSource = contactBindingSource;
            contactBindingSource.DataSource = contactListing;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchContactForm_Load(object sender, EventArgs e)
        {
            contactListing = ContactDB.GetAllContacts();
            contactDataGridView.DataSource = contactBindingSource;
            contactBindingSource.DataSource = contactListing;
            contactDataGridView.ClearSelection();
        }

        


        private void btnDeleteContact_Click(object sender, EventArgs e)
        {
            Contact delContact = (Contact)contactBindingSource.Current;
            int conID = delContact.ContactID;

            try
            {
                ContactDB.DeleteContact(conID);

                // Refreshes the list
                contactListing = ContactDB.GetAllContacts();
                contactDataGridView.DataSource = contactBindingSource;
                contactBindingSource.DataSource = contactListing;


            }
            catch (SqlException xsept)
            {
                throw xsept;
            }
            catch (Exception xsept)
            {
                throw xsept;
            }

        }

        private void contactDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            DataGridViewRow row = contactDataGridView.Rows[i];
            DataGridViewCell cell = row.Cells[4];
            int contactRowSelected = (int)cell.Value;
      //      contactDataGridView
        }

        private void btnViewContactInfo_Click(object sender, EventArgs e)
        {
            int i = -1;

            if (contactDataGridView.SelectedRows.Count <= 0)
            {
                MessageBox.Show("You must make a selection in order to view, update / " +
                    "modify, or delete a customer", "ERROR", MessageBoxButtons.OK);
                return;
            }
            else
            {
                i = contactDataGridView.SelectedRows[0].Index;
            }
            DataGridViewRow row = contactDataGridView.Rows[i];
            DataGridViewCell cell = row.Cells[4];
            int conID = (int)cell.Value;

            try
            {

                contact = (Contact)contactBindingSource.Current;
                contactBindingSource.Add(contact);
                contactBindingSource.Clear();
                //      MessageBox.Show("Contact ID is: " + conID.ToString(), "ERROR", MessageBoxButtons.OK);
                //      ContactForm view = new ContactForm();
                //      view.PopulateContactDataForViewing(contact);

                //      contact.ShowDialog();

                //contactDataGridView.DataSource = contactBindingSource;
                //contactBindingSource.DataSource = contact;

                contactListing = ContactDB.GetAllContacts();
                contactDataGridView.DataSource = contactBindingSource;
                contactBindingSource.DataSource = contactListing;
                //contactDataGridView.ClearSelection();



            }
            catch (SqlException xsept)
            {
                throw xsept;
            }
            catch (Exception xsept)
            {
                throw xsept;
            }

        



        /*        int i = contactDataGridView.SelectedRows[0].Index;
    DataGridViewRow row = contactDataGridView.Rows[i];
    DataGridViewCell cell = row.Cells[4];
    int conID = (int)cell.Value;

    MessageBox.Show(Convert.ToString(ContactID), Convert.ToString(i));
    Form modifyForm = new ContactForm();
    modifyForm.Tag = conID;
    modifyForm.Show();

    try
    {
//             ContactDB.UpdateModifyContact(conID)

//           contactListing = ContactDB.UpdateModifyContact(conID);
        contactDataGridView.DataSource = contactBindingSource;
        contactBindingSource.DataSource = contactListing;


    }
    catch (SqlException xsept)
    {
        throw xsept;
    }
    catch (Exception xsept)
    {
        throw xsept;
    }
    finally
    {

    }

*/



        }
    }
}
    

