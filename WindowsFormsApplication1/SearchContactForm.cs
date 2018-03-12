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

        //        contact = ContactDB.UpdateModifyContact(oldContact, newContact);
                //      MessageBox.Show("Contact ID is: " + conID.ToString(), "ERROR", MessageBoxButtons.OK);
                ContactForm view = new ContactForm();
                view.PopulateContactDataForViewing(contact);

                view.ShowDialog();

                //contactDataGridView.DataSource = contactBindingSource;
                //contactBindingSource.DataSource = contact;

//              contactListing = ContactDB.GetSpecificContactInfo(oldContact, newContact);
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
            finally
            {

            }



            contactForm = new ContactForm();
            contactDataGridView.DataSource = contactBindingSource;
            contactBindingSource.DataSource = contactListing;
            contactForm.ShowDialog();
            
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
                ContactDB.DeleteContact(conID);

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

                contact = ContactDB.GetSpecificContactInfo(conID);
          //      MessageBox.Show("Contact ID is: " + conID.ToString(), "ERROR", MessageBoxButtons.OK);
                ContactForm view = new ContactForm();
                view.PopulateContactDataForViewing(contact);

                view.ShowDialog();

                //contactDataGridView.DataSource = contactBindingSource;
                //contactBindingSource.DataSource = contact;

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
            finally
            {
                
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
    

