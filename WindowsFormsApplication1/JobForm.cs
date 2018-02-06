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
    public partial class JobForm : Form
    {
        public JobForm()
        {
            InitializeComponent();
        }

        private void lblJobInfoTitle_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonJobExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm.jobMainForm = null;
        }

        private void toolStripButtonJobSearchButton_Click(object sender, EventArgs e)
        {

        }
    }
}
