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
 /*           Binding a = companyZipCodeTextBox.DataBindings["Text"];
            a.Format += FormatZipCode;
            a.Parse += UnformatZipCode;

            Binding b = companyPhoneMaskedTextBox.DataBindings["Text"];
            b.Format += FormatPhoneNumber;
            b.Parse += UnformatPhoneNumber;
        }
        private bool IsInt64(string s)
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

        private void FormatZipCode(object sender, ConvertEventArgs e)
        {
            if (e.Value.GetType().ToString() == "System.String")
            {
                string s = e.Value.ToString();
                if (IsInt64(s))
                {
                    if (s.Length == 9)
                    {
                        e.Value = s.Substring(0, 5) + "-" + s.Substring(5, 4);
                    }
                }
            }
        }

        private void FormatPhoneNumber(object sender, ConvertEventArgs e)
        {
            if (e.Value.GetType().ToString() == "System.String")
            {
                string s = e.Value.ToString();

                if (s.Length == 14)
                {
                    s = s.Replace("(", "");
                    s = s.Replace(") ", "");
                    s = s.Replace("-", "");

                    e.Value =
                        s.Substring(0, 3) + "-" +
                        s.Substring(3, 3) + "-" +
                        s.Substring(6, 4);
                }
            }
        }

        private void UnformatZipCode(object sender, ConvertEventArgs e)
        {
            if (e.Value.GetType().ToString() == "System.String")
            {
                string s = e.Value.ToString();
                e.Value = s.Replace("-", "");
            }
        }

        private void UnformatPhoneNumber(object sender, ConvertEventArgs e)
        {
            if (e.Value.GetType().ToString() == "System.String")
            {
                string s = e.Value.ToString();
                e.Value = s.Replace(".", "");
            }
        }
        private bool IsPresent(Control control, string name)
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
            else if (control.GetType().ToString() == "System.Windows.Forms.ComboBox")
            {
                ComboBox comboBox = (ComboBox)control;
                if (comboBox.SelectedIndex == -1)
                {
                    MessageBox.Show(name + " is a required field.", "ENTRY ERROR");
                    comboBox.Focus();
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
                    IsPresent(companyNameTextBox, "Name") &&
                    IsPresent(companyAddressTextBox, "Address") &&
                    IsPresent(companyCityTextBox, "City") &&
                    IsPresent(companyStateComboBox, "State") &&
                    IsPresent(companyZipCodeTextBox, "Zip Code") &&
                    IsPresent(companyPhoneMaskedTextBox, "Phone number");
            }
            else
                return true;
 */       }

        private bool CloseProgram()
        {
            if (MessageBox.Show("Are you sure you want to quit?", "LEAVING SO SOON ???????", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
                return true;
            }
            else
                return false;
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            CloseProgram();
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
