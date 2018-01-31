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
    public partial class ContactForm : Form
    {
        public ContactForm()
        {
            InitializeComponent();
        }

        private void ContactForm_Load(object sender, EventArgs e)
        {
            Binding a = contactZipCodeTextBox.DataBindings["Text"];
            a.Format += FormatZipCode;
            a.Parse += UnformatZipCode;

            Binding b = contactPhoneTextBox.DataBindings["Text"];
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

                if (s.Length == 10)
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
            if (contactBindingSource.Count > 0)
            {
                return
                    IsPresent(contactFirstNameTextBox, "First Name") &&
                    IsPresent(contactLastNameTextBox, "Last Name") &&
                    IsPresent(contactTitleTextBox, "Title") &&
                    IsPresent(contactDepartmentTextBox, "Department") &&
                    IsPresent(contactAddressTextBox, "Address") &&
                    IsPresent(contactCityTextBox, "City") &&
                    IsPresent(contactStateComboBox, "State") &&
                    IsPresent(contactZipCodeTextBox, "Zip Code") &&
                    IsPresent(contactContactedViaComboBox, "Contacted via") &&
                    IsPresent(contactPhoneTextBox, "Phone number") &&
                    IsPresent(contactMobileTextBox, "Mobile number") &&
                    IsPresent(contactEmailTextBox, "Email");
            }
            else
                return true;
        }

    private void toolStripButtonContactExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm.contactMainForm = null;
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            openToolStripButton.Enabled = false;
        }

    }
}
