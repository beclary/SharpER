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

namespace WindowsFormsApplication1
{
    public partial class SearchCompanyForm : Form
    {
        public static Form searchCompanyForm = null;

        public SearchCompanyForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNewCompany_Click(object sender, EventArgs e)
        {
            searchCompanyForm = new CompanyForm();
            searchCompanyForm.ShowDialog();
        }

        private void btnUpdateModifyCompany_Click(object sender, EventArgs e)
        {
            searchCompanyForm = new CompanyForm();
            searchCompanyForm.ShowDialog();
        }
    }
}
