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
    public partial class SearchCompanyForm : Form
    {
        public static CompanyForm companyForm = null;
        public static List<Company> companyListing;
        public static Company company;
        public static int comID = 0;
        public int oldCompany;
        public int newCompany;

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
            companyForm = new CompanyForm();
            companyForm.ShowDialog();
        }

        private void btnUpdateModifyCompany_Click(object sender, EventArgs e)
        {
            CompanyForm modifyForm = new CompanyForm();
            modifyForm.newCompany = (Company)companyBindingSource.Current;
            modifyForm.company = (Company)companyBindingSource.Current;
            modifyForm.companyBindingSource.Clear();
            
            // Refreshes the gridview
            companyListing = CompanyDB.GetAllCompanies();
            companyDataGridView.DataSource = companyBindingSource;
            companyBindingSource.DataSource = companyListing;

        }

        private void SearchCompanyForm_Load(object sender, EventArgs e)
        {
            companyListing = CompanyDB.GetAllCompanies();
            companyDataGridView.DataSource = companyBindingSource;
            companyBindingSource.DataSource = companyListing;
        }
    }
}
