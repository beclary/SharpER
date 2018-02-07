namespace WindowsFormsApplication1
{
    partial class CompanyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label companyAddressLabel;
            System.Windows.Forms.Label companyCityLabel;
            System.Windows.Forms.Label companyFaxLabel;
            System.Windows.Forms.Label companyIDLabel;
            System.Windows.Forms.Label companyNameLabel;
            System.Windows.Forms.Label companyNotesLabel;
            System.Windows.Forms.Label companyPhoneLabel;
            System.Windows.Forms.Label companyStateLabel;
            System.Windows.Forms.Label companyWebsiteLabel;
            System.Windows.Forms.Label companyZipCodeLabel;
            this.lblCompanyInfoTitle = new System.Windows.Forms.Label();
            this.companyAddressTextBox = new System.Windows.Forms.TextBox();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyCityTextBox = new System.Windows.Forms.TextBox();
            this.companyFaxTextBox = new System.Windows.Forms.TextBox();
            this.companyIDTextBox = new System.Windows.Forms.TextBox();
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.companyNotesTextBox = new System.Windows.Forms.TextBox();
            this.companyPhoneTextBox = new System.Windows.Forms.TextBox();
            this.companyStateComboBox = new System.Windows.Forms.ComboBox();
            this.companyWebsiteTextBox = new System.Windows.Forms.TextBox();
            this.companyZipCodeTextBox = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            companyAddressLabel = new System.Windows.Forms.Label();
            companyCityLabel = new System.Windows.Forms.Label();
            companyFaxLabel = new System.Windows.Forms.Label();
            companyIDLabel = new System.Windows.Forms.Label();
            companyNameLabel = new System.Windows.Forms.Label();
            companyNotesLabel = new System.Windows.Forms.Label();
            companyPhoneLabel = new System.Windows.Forms.Label();
            companyStateLabel = new System.Windows.Forms.Label();
            companyWebsiteLabel = new System.Windows.Forms.Label();
            companyZipCodeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // companyAddressLabel
            // 
            companyAddressLabel.AutoSize = true;
            companyAddressLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            companyAddressLabel.ForeColor = System.Drawing.Color.DarkBlue;
            companyAddressLabel.Location = new System.Drawing.Point(49, 144);
            companyAddressLabel.Name = "companyAddressLabel";
            companyAddressLabel.Size = new System.Drawing.Size(66, 19);
            companyAddressLabel.TabIndex = 67;
            companyAddressLabel.Text = "Address:";
            // 
            // companyCityLabel
            // 
            companyCityLabel.AutoSize = true;
            companyCityLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            companyCityLabel.ForeColor = System.Drawing.Color.DarkBlue;
            companyCityLabel.Location = new System.Drawing.Point(75, 176);
            companyCityLabel.Name = "companyCityLabel";
            companyCityLabel.Size = new System.Drawing.Size(40, 19);
            companyCityLabel.TabIndex = 69;
            companyCityLabel.Text = "City:";
            // 
            // companyFaxLabel
            // 
            companyFaxLabel.AutoSize = true;
            companyFaxLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            companyFaxLabel.ForeColor = System.Drawing.Color.DarkBlue;
            companyFaxLabel.Location = new System.Drawing.Point(76, 240);
            companyFaxLabel.Name = "companyFaxLabel";
            companyFaxLabel.Size = new System.Drawing.Size(38, 19);
            companyFaxLabel.TabIndex = 71;
            companyFaxLabel.Text = "Fax:";
            // 
            // companyIDLabel
            // 
            companyIDLabel.AutoSize = true;
            companyIDLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            companyIDLabel.ForeColor = System.Drawing.Color.DarkBlue;
            companyIDLabel.Location = new System.Drawing.Point(433, 113);
            companyIDLabel.Name = "companyIDLabel";
            companyIDLabel.Size = new System.Drawing.Size(90, 19);
            companyIDLabel.TabIndex = 73;
            companyIDLabel.Text = "Company ID:";
            // 
            // companyNameLabel
            // 
            companyNameLabel.AutoSize = true;
            companyNameLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            companyNameLabel.ForeColor = System.Drawing.Color.DarkBlue;
            companyNameLabel.Location = new System.Drawing.Point(66, 112);
            companyNameLabel.Name = "companyNameLabel";
            companyNameLabel.Size = new System.Drawing.Size(50, 19);
            companyNameLabel.TabIndex = 75;
            companyNameLabel.Text = "Name:";
            // 
            // companyNotesLabel
            // 
            companyNotesLabel.AutoSize = true;
            companyNotesLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            companyNotesLabel.ForeColor = System.Drawing.Color.DarkBlue;
            companyNotesLabel.Location = new System.Drawing.Point(64, 304);
            companyNotesLabel.Name = "companyNotesLabel";
            companyNotesLabel.Size = new System.Drawing.Size(52, 19);
            companyNotesLabel.TabIndex = 77;
            companyNotesLabel.Text = "Notes:";
            // 
            // companyPhoneLabel
            // 
            companyPhoneLabel.AutoSize = true;
            companyPhoneLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            companyPhoneLabel.ForeColor = System.Drawing.Color.DarkBlue;
            companyPhoneLabel.Location = new System.Drawing.Point(64, 208);
            companyPhoneLabel.Name = "companyPhoneLabel";
            companyPhoneLabel.Size = new System.Drawing.Size(51, 19);
            companyPhoneLabel.TabIndex = 79;
            companyPhoneLabel.Text = "Phone:";
            // 
            // companyStateLabel
            // 
            companyStateLabel.AutoSize = true;
            companyStateLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            companyStateLabel.ForeColor = System.Drawing.Color.DarkBlue;
            companyStateLabel.Location = new System.Drawing.Point(277, 176);
            companyStateLabel.Name = "companyStateLabel";
            companyStateLabel.Size = new System.Drawing.Size(50, 19);
            companyStateLabel.TabIndex = 81;
            companyStateLabel.Text = "State:";
            // 
            // companyWebsiteLabel
            // 
            companyWebsiteLabel.AutoSize = true;
            companyWebsiteLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            companyWebsiteLabel.ForeColor = System.Drawing.Color.DarkBlue;
            companyWebsiteLabel.Location = new System.Drawing.Point(49, 272);
            companyWebsiteLabel.Name = "companyWebsiteLabel";
            companyWebsiteLabel.Size = new System.Drawing.Size(67, 19);
            companyWebsiteLabel.TabIndex = 83;
            companyWebsiteLabel.Text = "Website:";
            // 
            // companyZipCodeLabel
            // 
            companyZipCodeLabel.AutoSize = true;
            companyZipCodeLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            companyZipCodeLabel.ForeColor = System.Drawing.Color.DarkBlue;
            companyZipCodeLabel.Location = new System.Drawing.Point(465, 176);
            companyZipCodeLabel.Name = "companyZipCodeLabel";
            companyZipCodeLabel.Size = new System.Drawing.Size(71, 19);
            companyZipCodeLabel.TabIndex = 85;
            companyZipCodeLabel.Text = "Zip Code:";
            // 
            // lblCompanyInfoTitle
            // 
            this.lblCompanyInfoTitle.AutoSize = true;
            this.lblCompanyInfoTitle.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyInfoTitle.ForeColor = System.Drawing.Color.Green;
            this.lblCompanyInfoTitle.Location = new System.Drawing.Point(1, 50);
            this.lblCompanyInfoTitle.Name = "lblCompanyInfoTitle";
            this.lblCompanyInfoTitle.Size = new System.Drawing.Size(291, 43);
            this.lblCompanyInfoTitle.TabIndex = 66;
            this.lblCompanyInfoTitle.Text = "Company Information";
            this.lblCompanyInfoTitle.Click += new System.EventHandler(this.lblCompanyInfoTitle_Click);
            // 
            // companyAddressTextBox
            // 
            this.companyAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "CompanyAddress", true));
            this.companyAddressTextBox.Location = new System.Drawing.Point(117, 141);
            this.companyAddressTextBox.Name = "companyAddressTextBox";
            this.companyAddressTextBox.Size = new System.Drawing.Size(299, 26);
            this.companyAddressTextBox.TabIndex = 1;
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(SharpERBLL.Company);
            // 
            // companyCityTextBox
            // 
            this.companyCityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "CompanyCity", true));
            this.companyCityTextBox.Location = new System.Drawing.Point(117, 173);
            this.companyCityTextBox.Name = "companyCityTextBox";
            this.companyCityTextBox.Size = new System.Drawing.Size(145, 26);
            this.companyCityTextBox.TabIndex = 2;
            // 
            // companyFaxTextBox
            // 
            this.companyFaxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "CompanyFax", true));
            this.companyFaxTextBox.Location = new System.Drawing.Point(117, 237);
            this.companyFaxTextBox.Name = "companyFaxTextBox";
            this.companyFaxTextBox.Size = new System.Drawing.Size(145, 26);
            this.companyFaxTextBox.TabIndex = 6;
            // 
            // companyIDTextBox
            // 
            this.companyIDTextBox.BackColor = System.Drawing.Color.LightGray;
            this.companyIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "CompanyID", true));
            this.companyIDTextBox.Location = new System.Drawing.Point(523, 110);
            this.companyIDTextBox.Name = "companyIDTextBox";
            this.companyIDTextBox.ReadOnly = true;
            this.companyIDTextBox.Size = new System.Drawing.Size(117, 26);
            this.companyIDTextBox.TabIndex = 74;
            // 
            // companyNameTextBox
            // 
            this.companyNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "CompanyName", true));
            this.companyNameTextBox.Location = new System.Drawing.Point(117, 109);
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.Size = new System.Drawing.Size(299, 26);
            this.companyNameTextBox.TabIndex = 0;
            // 
            // companyNotesTextBox
            // 
            this.companyNotesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "CompanyNotes", true));
            this.companyNotesTextBox.Location = new System.Drawing.Point(117, 301);
            this.companyNotesTextBox.Multiline = true;
            this.companyNotesTextBox.Name = "companyNotesTextBox";
            this.companyNotesTextBox.Size = new System.Drawing.Size(454, 78);
            this.companyNotesTextBox.TabIndex = 8;
            // 
            // companyPhoneTextBox
            // 
            this.companyPhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "CompanyPhone", true));
            this.companyPhoneTextBox.Location = new System.Drawing.Point(117, 205);
            this.companyPhoneTextBox.Name = "companyPhoneTextBox";
            this.companyPhoneTextBox.Size = new System.Drawing.Size(145, 26);
            this.companyPhoneTextBox.TabIndex = 5;
            // 
            // companyStateComboBox
            // 
            this.companyStateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "CompanyState", true));
            this.companyStateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.companyBindingSource, "CompanyState", true));
            this.companyStateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.companyStateComboBox.FormattingEnabled = true;
            this.companyStateComboBox.Items.AddRange(new object[] {
            "Alabama",
            "Alaska",
            "Arizona",
            "Arkansas",
            "California",
            "Colorado",
            "Connecticut",
            "Delaware",
            "Florida",
            "Georgia",
            "Hawaii",
            "Idaho",
            "Illinois",
            "Indiana",
            "Iowa",
            "Kansas",
            "Kentucky",
            "Louisana",
            "Maine",
            "Maryland",
            "Massachusetts",
            "Michigan",
            "Minnesota",
            "Mississippi",
            "Missouri",
            "Montana",
            "Nebraska",
            "Nevada",
            "New Hampshire",
            "New Jersey",
            "New Mexico",
            "New York",
            "North Carolina",
            "North Dakota",
            "Ohio",
            "Oklahoma",
            "Oregon",
            "Pennsylvania",
            "Rhode Island",
            "South Carolina",
            "South Dakota",
            "Tennessee",
            "Texas",
            "Utah",
            "Vermont",
            "Virginia",
            "Washington",
            "West Virginia",
            "Wisconsin",
            "Wyoming"});
            this.companyStateComboBox.Location = new System.Drawing.Point(333, 174);
            this.companyStateComboBox.Name = "companyStateComboBox";
            this.companyStateComboBox.Size = new System.Drawing.Size(126, 26);
            this.companyStateComboBox.Sorted = true;
            this.companyStateComboBox.TabIndex = 3;
            // 
            // companyWebsiteTextBox
            // 
            this.companyWebsiteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "CompanyWebsite", true));
            this.companyWebsiteTextBox.Location = new System.Drawing.Point(117, 269);
            this.companyWebsiteTextBox.Name = "companyWebsiteTextBox";
            this.companyWebsiteTextBox.Size = new System.Drawing.Size(401, 26);
            this.companyWebsiteTextBox.TabIndex = 7;
            // 
            // companyZipCodeTextBox
            // 
            this.companyZipCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "CompanyZipCode", true));
            this.companyZipCodeTextBox.Location = new System.Drawing.Point(542, 173);
            this.companyZipCodeTextBox.Name = "companyZipCodeTextBox";
            this.companyZipCodeTextBox.Size = new System.Drawing.Size(98, 26);
            this.companyZipCodeTextBox.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.HotPink;
            this.btnSave.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnSave.Location = new System.Drawing.Point(379, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 43);
            this.btnSave.TabIndex = 88;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.HotPink;
            this.btnClear.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnClear.Location = new System.Drawing.Point(500, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 43);
            this.btnClear.TabIndex = 87;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.HotPink;
            this.btnCancel.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnCancel.Location = new System.Drawing.Point(620, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 43);
            this.btnCancel.TabIndex = 86;
            this.btnCancel.Text = "Exit";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // CompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(732, 535);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(companyAddressLabel);
            this.Controls.Add(this.companyAddressTextBox);
            this.Controls.Add(companyCityLabel);
            this.Controls.Add(this.companyCityTextBox);
            this.Controls.Add(companyFaxLabel);
            this.Controls.Add(this.companyFaxTextBox);
            this.Controls.Add(companyIDLabel);
            this.Controls.Add(this.companyIDTextBox);
            this.Controls.Add(companyNameLabel);
            this.Controls.Add(this.companyNameTextBox);
            this.Controls.Add(companyNotesLabel);
            this.Controls.Add(this.companyNotesTextBox);
            this.Controls.Add(companyPhoneLabel);
            this.Controls.Add(this.companyPhoneTextBox);
            this.Controls.Add(companyStateLabel);
            this.Controls.Add(this.companyStateComboBox);
            this.Controls.Add(companyWebsiteLabel);
            this.Controls.Add(this.companyWebsiteTextBox);
            this.Controls.Add(companyZipCodeLabel);
            this.Controls.Add(this.companyZipCodeTextBox);
            this.Controls.Add(this.lblCompanyInfoTitle);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CompanyForm";
            this.Text = "Company";
            this.Load += new System.EventHandler(this.CompanyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCompanyInfoTitle;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.TextBox companyAddressTextBox;
        private System.Windows.Forms.TextBox companyCityTextBox;
        private System.Windows.Forms.TextBox companyFaxTextBox;
        private System.Windows.Forms.TextBox companyIDTextBox;
        private System.Windows.Forms.TextBox companyNameTextBox;
        private System.Windows.Forms.TextBox companyNotesTextBox;
        private System.Windows.Forms.TextBox companyPhoneTextBox;
        private System.Windows.Forms.ComboBox companyStateComboBox;
        private System.Windows.Forms.TextBox companyWebsiteTextBox;
        private System.Windows.Forms.TextBox companyZipCodeTextBox;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancel;
    }
}