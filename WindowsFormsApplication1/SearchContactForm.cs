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

namespace WindowsFormsApplication1
{
    public partial class SearchContactForm : Form
    {
        public static Form searchContactForm = null;


        public SearchContactForm()
        {
            InitializeComponent();
        }

        private void btnUpdateModifyContact_Click(object sender, EventArgs e)
        {
            searchContactForm = new ContactForm();
            searchContactForm.ShowDialog();
        //    ContactDB.UpdateModifyContact();  Same problem here as below. Am I missing the 
        //                                      ContactID? It does not give me a ContactID to 
        //                                      put in as an argument
        }

        private void btnAddNewContact_Click(object sender, EventArgs e)
        {
            searchContactForm = new ContactForm();
            searchContactForm.ShowDialog();
        //    ContactDB.AddContact();           This is where the method should be called, but
        //                                      why doesn't it accept the method call I creaated
        //                                      in the ContactDB class?
        }
    }
}
