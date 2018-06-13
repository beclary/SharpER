// CompanyForm.cs UI for SharpER
// Bruce Clary

using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class CompanyForm : Form
    {
        public static List<Company> comList;
        public Company company;
        public Company newCompany;
        public bool addCompany;

        public CompanyForm()
        {
            InitializeComponent();
        }

        private bool IsInt64 (string s)
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

        private bool IsPresent (Control control, string name)
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
            if (companyBindingSource.Count > 0)
            {
                return
                    IsPresent(companyNameTextBox, "Name");
            }
            else
            {
                return true;
            }
        }

        private void toolStripButtonCompanyExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm.companyMainForm = null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CompanyForm_Load(object sender, EventArgs e)
        {
            // Bindings need to be set, so I have to test here to see if it was an
            // ADD or a MODIFY
            if (addCompany == true) // This is the ADD
            {
                company = new Company();
                companyBindingSource.Clear();
                companyBindingSource.Add(company);
            }
            else // This is the MODIFY
            {
                // Set company to the row held by the companyBindingSource.Current (whatever
                // the user clicked in the grid)
                company = (Company)companyBindingSource.Current; // Cast from Object to real type

                // Create a new (empty) company: newCompany
                newCompany = new Company();

                // Copy field by field data in company (i.e. newCompany.CompanyID = company.CompanyID)
                newCompany.CompanyID = company.CompanyID;
                newCompany.CompanyName = company.CompanyName;
                newCompany.CompanyAddress = company.CompanyAddress;
                newCompany.CompanyCity = company.CompanyCity;
                newCompany.CompanyState = company.CompanyState;
                newCompany.CompanyZipCode = company.CompanyZipCode;
                newCompany.CompanyPhone = company.CompanyPhone;
                newCompany.CompanyFax = company.CompanyFax;
                newCompany.CompanyWebsite = company.CompanyWebsite;
                newCompany.CompanyNotes = company.CompanyNotes;

                // Set binding (see p.285)
                companyBindingSource.Clear();
                companyBindingSource.Add(newCompany);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsDataValid())
            {
                if (addCompany)
                {
                    try
                    {
                        CompanyDB.AddCompany(company);
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
                    try
                    {
                        if (!CompanyDB.UpdateModifyCompany(company, newCompany))
                        {
                            MessageBox.Show("Another user has updated or deleted that company", "DATABASE ERROR");
                            //this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            company = newCompany;
                            //this.DialogResult = DialogResult.OK;
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
                this.Close();
            }
        }
    }
}
