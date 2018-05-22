using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpERBLL;
using SharpERDAL;
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
            ContactForm modifyForm = new ContactForm();
            modifyForm.newContact = (Contact)contactBindingSource.Current;
            modifyForm.contact = (Contact)contactBindingSource.Current;
            modifyForm.contactBindingSource.Clear();
            modifyForm.contactBindingSource.Add(modifyForm.contact);
            modifyForm.ShowDialog();
            

            // Refreshes the gridview
            contactListing = ContactDB.GetAllContacts();
            contactDataGridView.DataSource = contactBindingSource;
            contactBindingSource.DataSource = contactListing;
            contactDataGridView.ClearSelection();
        }

        private void btnAddNewContact_Click(object sender, EventArgs e)
        {
            contactForm = new ContactForm();
            contactForm.addContact = true;
            contactForm.ShowDialog();

            // Refreshes the gridview
            contactListing = ContactDB.GetAllContacts();
            contactDataGridView.DataSource = contactBindingSource;
            contactBindingSource.DataSource = contactListing;
            contactDataGridView.ClearSelection();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchContactForm_Load(object sender, EventArgs e)
        {
            // Loads the gridview list of all contacts
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
                if (MessageBox.Show("Deleting " + delContact.ContactFirstName + " " + delContact.ContactLastName + " from the database is an action that can NOT be undone!\n\nAre you sure you want to delete this contact?", "CONFIRM DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    ContactDB.DeleteContact(conID);
                }

                // Refreshes the gridview
                contactListing = ContactDB.GetAllContacts();
                contactDataGridView.DataSource = contactBindingSource;
                contactBindingSource.DataSource = contactListing;
                contactDataGridView.ClearSelection();
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
            foreach(DataGridViewColumn column in contactDataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }

            //contactDataGridView.Sort(contactDataGridView.Columns[0], ListSortDirection.Ascending);
            //contactDataGridView.Sort(contactDataGridView.Columns[1], ListSortDirection.Ascending);
            //contactDataGridView.Sort(contactDataGridView.Columns[2], ListSortDirection.Ascending);
            
            //int i = e.RowIndex;
            //DataGridViewRow row = contactDataGridView.Rows[i];
            //DataGridViewCell cell = row.Cells[0];
            //int contactRowSelected = (int)cell.Value;
        }
    }
}

    

