using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class CompanyForm : Form
    {
        public CompanyForm()
        {
            InitializeComponent();
        }

        private void lblCompanyInfoTitle_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonCompanyExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm.companyMainForm = null;
        }

        private void CompanyForm_Load(object sender, EventArgs e)
        {
        }

        //private bool CloseProgram()
        //{
        //    if (MessageBox.Show("Are you sure you want to quit?", "LEAVING SO SOON ???????", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
        //    {
        //        this.Close();
        //        return true;
        //    }
        //    else
        //        return false;
        //}


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            companyNameTextBox.Clear();
            companyAddressTextBox.Clear();
            companyCityTextBox.Clear();
            companyStateComboBox.SelectedIndex = -1;
            companyZipCodeMaskedTextBox.Clear();
            companyPhoneMaskedTextBox.Clear();
            companyFaxMaskedTextBox.Clear();
            companyWebsiteTextBox.Clear();
            companyNotesTextBox.Clear();
            companyPhoneMaskedTextBox.Clear();
        }

        private void companyIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
