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

        public SearchContactForm()
        {
            InitializeComponent();
        }

        private void btnUpdateModifyContact_Click(object sender, EventArgs e)
        {
            int i = contactDataGridView.SelectedRows[0].Index;
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




            contactForm = new ContactForm();
            contactDataGridView.DataSource = contactBindingSource;
            contactBindingSource.DataSource = contactListing;
            contactForm.ShowDialog();
        //    ContactDB.UpdateModifyContact();  Same problem here as below. Am I missing the 
        //                                      ContactID? It does not give me a ContactID to 
        //                                      put in as an argument
        }

        private void btnAddNewContact_Click(object sender, EventArgs e)
        {
            contactForm = new ContactForm();
            contactForm.addContact = true;
            contactForm.ShowDialog();
         //   ContactDB.AddContact();           This is where the method should be called, but
        //                                      why doesn't it accept the method call I creaated
        //                                      in the ContactDB class?
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
        }

        


        private void btnDeleteContact_Click(object sender, EventArgs e)
        {
            int i = contactDataGridView.SelectedRows[0].Index;
            DataGridViewRow row = contactDataGridView.Rows[i];
            DataGridViewCell cell = row.Cells[4];
            int conID = (int)cell.Value;

            // Work on these
    //        MessageBox.Show("Are you sure you want to delete " + ContactID + " which is " +
//              i + "???\n\nThis cannot be undone. Are you sure?", "WARNING - READ CAREFULLY",
//              MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

     //       MessageBox.Show(Convert.ToString(ContactID), Convert.ToString(i));
     //       Form delForm = new ContactForm();
     //       delForm.Tag = conID;
     //       delForm.Show();

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

    }
}
    

