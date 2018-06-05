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

        private void btnUpdateModifyCompany_Click(object sender, EventArgs e)
        {
            CompanyForm modifyForm = new CompanyForm();
            modifyForm.newCompany = (Company)companyBindingSource.Current;
            modifyForm.company = (Company)companyBindingSource.Current;
            modifyForm.companyBindingSource.Clear();
            modifyForm.companyBindingSource.Add(modifyForm.company);
            modifyForm.ShowDialog();

            // Refreshes the gridview
            companyListing = CompanyDB.GetAllCompanies();
            companyDataGridView.DataSource = companyBindingSource;
            companyBindingSource.DataSource = companyListing;
            companyDataGridView.ClearSelection();
        }

        private void btnAddNewCompany_Click(object sender, EventArgs e)
        {
            companyForm = new CompanyForm();
            companyForm.addCompany = true;
            companyForm.ShowDialog();

            // Refreshes the gridview
            companyListing = CompanyDB.GetAllCompanies();
            companyDataGridView.DataSource = companyBindingSource;
            companyBindingSource.DataSource = companyListing;
            companyDataGridView.ClearSelection();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchCompanyForm_Load(object sender, EventArgs e)
        {
            // Loads the gridview list of all companies
            companyListing = CompanyDB.GetAllCompanies();
            companyDataGridView.DataSource = companyBindingSource;
            companyBindingSource.DataSource = companyListing;
            companyDataGridView.ClearSelection();
        }

        private void btnDeleteCompany_Click(object sender, EventArgs e)
        {
            Company delCompany = (Company)companyBindingSource.Current;
            int comID = delCompany.CompanyID;

            try
            {
                if (MessageBox.Show("Deleting " + delCompany.CompanyName + " from the database is an action that can NOT be undone! \n\nAre you sure you want to delete this company?", "CONFIRM DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    CompanyDB.DeleteCompany(comID);
                }

                // Refreshes the gridview
                companyListing = CompanyDB.GetAllCompanies();
                companyDataGridView.DataSource = companyBindingSource;
                companyBindingSource.DataSource = companyListing;
                companyDataGridView.ClearSelection();

                // Refreshes the Company gridview from what the Job table had in it
                List<Company> jobCompanyListing = CompanyDB.GetAllCompanies();
                companyBindingSource.DataSource = jobCompanyListing;
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

        private void companyDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            DataGridViewRow row = companyDataGridView.Rows[i];
            DataGridViewCell cell = row.Cells[0];
            int companyRowSelected = (int)cell.Value;
        }
    }
}
