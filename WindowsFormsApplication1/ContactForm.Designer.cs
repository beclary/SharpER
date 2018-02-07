﻿namespace WindowsFormsApplication1
{
    partial class ContactForm
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
            System.Windows.Forms.Label contactAddressLabel;
            System.Windows.Forms.Label contactCityLabel;
            System.Windows.Forms.Label contactContactedViaLabel;
            System.Windows.Forms.Label contactDepartmentLabel;
            System.Windows.Forms.Label contactEmailLabel;
            System.Windows.Forms.Label contactFaxLabel;
            System.Windows.Forms.Label contactFirstNameLabel;
            System.Windows.Forms.Label contactIDLabel;
            System.Windows.Forms.Label contactLastNameLabel;
            System.Windows.Forms.Label contactMobileLabel;
            System.Windows.Forms.Label contactNotesLabel;
            System.Windows.Forms.Label contactPhoneLabel;
            System.Windows.Forms.Label contactStateLabel;
            System.Windows.Forms.Label contactTitleLabel;
            System.Windows.Forms.Label contactZipCodeLabel;
            this.contactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactAddressTextBox = new System.Windows.Forms.TextBox();
            this.contactCityTextBox = new System.Windows.Forms.TextBox();
            this.contactContactedViaComboBox = new System.Windows.Forms.ComboBox();
            this.contactDepartmentTextBox = new System.Windows.Forms.TextBox();
            this.contactEmailTextBox = new System.Windows.Forms.TextBox();
            this.contactFaxTextBox = new System.Windows.Forms.TextBox();
            this.contactFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.contactIDTextBox = new System.Windows.Forms.TextBox();
            this.contactLastNameTextBox = new System.Windows.Forms.TextBox();
            this.contactMobileTextBox = new System.Windows.Forms.TextBox();
            this.contactNotesTextBox = new System.Windows.Forms.TextBox();
            this.contactPhoneTextBox = new System.Windows.Forms.TextBox();
            this.contactStateComboBox = new System.Windows.Forms.ComboBox();
            this.contactTitleTextBox = new System.Windows.Forms.TextBox();
            this.contactZipCodeTextBox = new System.Windows.Forms.TextBox();
            this.lblContactInfoTitle = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            contactAddressLabel = new System.Windows.Forms.Label();
            contactCityLabel = new System.Windows.Forms.Label();
            contactContactedViaLabel = new System.Windows.Forms.Label();
            contactDepartmentLabel = new System.Windows.Forms.Label();
            contactEmailLabel = new System.Windows.Forms.Label();
            contactFaxLabel = new System.Windows.Forms.Label();
            contactFirstNameLabel = new System.Windows.Forms.Label();
            contactIDLabel = new System.Windows.Forms.Label();
            contactLastNameLabel = new System.Windows.Forms.Label();
            contactMobileLabel = new System.Windows.Forms.Label();
            contactNotesLabel = new System.Windows.Forms.Label();
            contactPhoneLabel = new System.Windows.Forms.Label();
            contactStateLabel = new System.Windows.Forms.Label();
            contactTitleLabel = new System.Windows.Forms.Label();
            contactZipCodeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contactAddressLabel
            // 
            contactAddressLabel.AutoSize = true;
            contactAddressLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contactAddressLabel.ForeColor = System.Drawing.Color.DarkBlue;
            contactAddressLabel.Location = new System.Drawing.Point(89, 235);
            contactAddressLabel.Name = "contactAddressLabel";
            contactAddressLabel.Size = new System.Drawing.Size(66, 19);
            contactAddressLabel.TabIndex = 1;
            contactAddressLabel.Text = "Address:";
            // 
            // contactCityLabel
            // 
            contactCityLabel.AutoSize = true;
            contactCityLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contactCityLabel.ForeColor = System.Drawing.Color.DarkBlue;
            contactCityLabel.Location = new System.Drawing.Point(115, 267);
            contactCityLabel.Name = "contactCityLabel";
            contactCityLabel.Size = new System.Drawing.Size(40, 19);
            contactCityLabel.TabIndex = 3;
            contactCityLabel.Text = "City:";
            // 
            // contactContactedViaLabel
            // 
            contactContactedViaLabel.AutoSize = true;
            contactContactedViaLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contactContactedViaLabel.ForeColor = System.Drawing.Color.DarkBlue;
            contactContactedViaLabel.Location = new System.Drawing.Point(51, 299);
            contactContactedViaLabel.Name = "contactContactedViaLabel";
            contactContactedViaLabel.Size = new System.Drawing.Size(104, 19);
            contactContactedViaLabel.TabIndex = 5;
            contactContactedViaLabel.Text = "Contacted Via:";
            // 
            // contactDepartmentLabel
            // 
            contactDepartmentLabel.AutoSize = true;
            contactDepartmentLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contactDepartmentLabel.ForeColor = System.Drawing.Color.DarkBlue;
            contactDepartmentLabel.Location = new System.Drawing.Point(68, 203);
            contactDepartmentLabel.Name = "contactDepartmentLabel";
            contactDepartmentLabel.Size = new System.Drawing.Size(87, 19);
            contactDepartmentLabel.TabIndex = 7;
            contactDepartmentLabel.Text = "Department:";
            // 
            // contactEmailLabel
            // 
            contactEmailLabel.AutoSize = true;
            contactEmailLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contactEmailLabel.ForeColor = System.Drawing.Color.DarkBlue;
            contactEmailLabel.Location = new System.Drawing.Point(107, 395);
            contactEmailLabel.Name = "contactEmailLabel";
            contactEmailLabel.Size = new System.Drawing.Size(48, 19);
            contactEmailLabel.TabIndex = 9;
            contactEmailLabel.Text = "Email:";
            // 
            // contactFaxLabel
            // 
            contactFaxLabel.AutoSize = true;
            contactFaxLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contactFaxLabel.ForeColor = System.Drawing.Color.DarkBlue;
            contactFaxLabel.Location = new System.Drawing.Point(117, 363);
            contactFaxLabel.Name = "contactFaxLabel";
            contactFaxLabel.Size = new System.Drawing.Size(38, 19);
            contactFaxLabel.TabIndex = 11;
            contactFaxLabel.Text = "Fax:";
            // 
            // contactFirstNameLabel
            // 
            contactFirstNameLabel.AutoSize = true;
            contactFirstNameLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contactFirstNameLabel.ForeColor = System.Drawing.Color.DarkBlue;
            contactFirstNameLabel.Location = new System.Drawing.Point(69, 107);
            contactFirstNameLabel.Name = "contactFirstNameLabel";
            contactFirstNameLabel.Size = new System.Drawing.Size(86, 19);
            contactFirstNameLabel.TabIndex = 13;
            contactFirstNameLabel.Text = "First Name:";
            // 
            // contactIDLabel
            // 
            contactIDLabel.AutoSize = true;
            contactIDLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contactIDLabel.ForeColor = System.Drawing.Color.DarkBlue;
            contactIDLabel.Location = new System.Drawing.Point(467, 109);
            contactIDLabel.Name = "contactIDLabel";
            contactIDLabel.Size = new System.Drawing.Size(85, 19);
            contactIDLabel.TabIndex = 15;
            contactIDLabel.Text = "Contact ID:";
            // 
            // contactLastNameLabel
            // 
            contactLastNameLabel.AutoSize = true;
            contactLastNameLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contactLastNameLabel.ForeColor = System.Drawing.Color.DarkBlue;
            contactLastNameLabel.Location = new System.Drawing.Point(73, 139);
            contactLastNameLabel.Name = "contactLastNameLabel";
            contactLastNameLabel.Size = new System.Drawing.Size(82, 19);
            contactLastNameLabel.TabIndex = 17;
            contactLastNameLabel.Text = "Last Name:";
            // 
            // contactMobileLabel
            // 
            contactMobileLabel.AutoSize = true;
            contactMobileLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contactMobileLabel.ForeColor = System.Drawing.Color.DarkBlue;
            contactMobileLabel.Location = new System.Drawing.Point(314, 333);
            contactMobileLabel.Name = "contactMobileLabel";
            contactMobileLabel.Size = new System.Drawing.Size(56, 19);
            contactMobileLabel.TabIndex = 19;
            contactMobileLabel.Text = "Mobile:";
            // 
            // contactNotesLabel
            // 
            contactNotesLabel.AutoSize = true;
            contactNotesLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contactNotesLabel.ForeColor = System.Drawing.Color.DarkBlue;
            contactNotesLabel.Location = new System.Drawing.Point(103, 427);
            contactNotesLabel.Name = "contactNotesLabel";
            contactNotesLabel.Size = new System.Drawing.Size(52, 19);
            contactNotesLabel.TabIndex = 21;
            contactNotesLabel.Text = "Notes:";
            // 
            // contactPhoneLabel
            // 
            contactPhoneLabel.AutoSize = true;
            contactPhoneLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contactPhoneLabel.ForeColor = System.Drawing.Color.DarkBlue;
            contactPhoneLabel.Location = new System.Drawing.Point(104, 331);
            contactPhoneLabel.Name = "contactPhoneLabel";
            contactPhoneLabel.Size = new System.Drawing.Size(51, 19);
            contactPhoneLabel.TabIndex = 23;
            contactPhoneLabel.Text = "Phone:";
            // 
            // contactStateLabel
            // 
            contactStateLabel.AutoSize = true;
            contactStateLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contactStateLabel.ForeColor = System.Drawing.Color.DarkBlue;
            contactStateLabel.Location = new System.Drawing.Point(314, 267);
            contactStateLabel.Name = "contactStateLabel";
            contactStateLabel.Size = new System.Drawing.Size(50, 19);
            contactStateLabel.TabIndex = 25;
            contactStateLabel.Text = "State:";
            // 
            // contactTitleLabel
            // 
            contactTitleLabel.AutoSize = true;
            contactTitleLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contactTitleLabel.ForeColor = System.Drawing.Color.DarkBlue;
            contactTitleLabel.Location = new System.Drawing.Point(110, 171);
            contactTitleLabel.Name = "contactTitleLabel";
            contactTitleLabel.Size = new System.Drawing.Size(45, 19);
            contactTitleLabel.TabIndex = 27;
            contactTitleLabel.Text = "Title:";
            // 
            // contactZipCodeLabel
            // 
            contactZipCodeLabel.AutoSize = true;
            contactZipCodeLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contactZipCodeLabel.ForeColor = System.Drawing.Color.DarkBlue;
            contactZipCodeLabel.Location = new System.Drawing.Point(498, 267);
            contactZipCodeLabel.Name = "contactZipCodeLabel";
            contactZipCodeLabel.Size = new System.Drawing.Size(71, 19);
            contactZipCodeLabel.TabIndex = 29;
            contactZipCodeLabel.Text = "Zip Code:";
            // 
            // contactBindingSource
            // 
            this.contactBindingSource.DataSource = typeof(SharpERBLL.Contact);
            // 
            // contactAddressTextBox
            // 
            this.contactAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactBindingSource, "ContactAddress", true));
            this.contactAddressTextBox.Location = new System.Drawing.Point(161, 233);
            this.contactAddressTextBox.Name = "contactAddressTextBox";
            this.contactAddressTextBox.Size = new System.Drawing.Size(301, 26);
            this.contactAddressTextBox.TabIndex = 5;
            // 
            // contactCityTextBox
            // 
            this.contactCityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactBindingSource, "ContactCity", true));
            this.contactCityTextBox.Location = new System.Drawing.Point(161, 265);
            this.contactCityTextBox.Name = "contactCityTextBox";
            this.contactCityTextBox.Size = new System.Drawing.Size(145, 26);
            this.contactCityTextBox.TabIndex = 6;
            // 
            // contactContactedViaComboBox
            // 
            this.contactContactedViaComboBox.BackColor = System.Drawing.Color.LightGray;
            this.contactContactedViaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactBindingSource, "ContactContactedVia", true));
            this.contactContactedViaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.contactContactedViaComboBox.FormattingEnabled = true;
            this.contactContactedViaComboBox.Items.AddRange(new object[] {
            "Email",
            "In Person",
            "Letter",
            "Phone",
            "Text"});
            this.contactContactedViaComboBox.Location = new System.Drawing.Point(161, 297);
            this.contactContactedViaComboBox.Name = "contactContactedViaComboBox";
            this.contactContactedViaComboBox.Size = new System.Drawing.Size(145, 26);
            this.contactContactedViaComboBox.Sorted = true;
            this.contactContactedViaComboBox.TabIndex = 9;
            // 
            // contactDepartmentTextBox
            // 
            this.contactDepartmentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactBindingSource, "ContactDepartment", true));
            this.contactDepartmentTextBox.Location = new System.Drawing.Point(161, 201);
            this.contactDepartmentTextBox.Name = "contactDepartmentTextBox";
            this.contactDepartmentTextBox.Size = new System.Drawing.Size(301, 26);
            this.contactDepartmentTextBox.TabIndex = 4;
            // 
            // contactEmailTextBox
            // 
            this.contactEmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactBindingSource, "ContactEmail", true));
            this.contactEmailTextBox.Location = new System.Drawing.Point(161, 393);
            this.contactEmailTextBox.Name = "contactEmailTextBox";
            this.contactEmailTextBox.Size = new System.Drawing.Size(401, 26);
            this.contactEmailTextBox.TabIndex = 13;
            // 
            // contactFaxTextBox
            // 
            this.contactFaxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactBindingSource, "ContactFax", true));
            this.contactFaxTextBox.Location = new System.Drawing.Point(161, 361);
            this.contactFaxTextBox.Name = "contactFaxTextBox";
            this.contactFaxTextBox.Size = new System.Drawing.Size(145, 26);
            this.contactFaxTextBox.TabIndex = 12;
            // 
            // contactFirstNameTextBox
            // 
            this.contactFirstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactBindingSource, "ContactFirstName", true));
            this.contactFirstNameTextBox.Location = new System.Drawing.Point(161, 105);
            this.contactFirstNameTextBox.Name = "contactFirstNameTextBox";
            this.contactFirstNameTextBox.Size = new System.Drawing.Size(301, 26);
            this.contactFirstNameTextBox.TabIndex = 1;
            // 
            // contactIDTextBox
            // 
            this.contactIDTextBox.BackColor = System.Drawing.Color.LightGray;
            this.contactIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactBindingSource, "ContactID", true));
            this.contactIDTextBox.Location = new System.Drawing.Point(558, 107);
            this.contactIDTextBox.Name = "contactIDTextBox";
            this.contactIDTextBox.Size = new System.Drawing.Size(117, 26);
            this.contactIDTextBox.TabIndex = 16;
            // 
            // contactLastNameTextBox
            // 
            this.contactLastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactBindingSource, "ContactLastName", true));
            this.contactLastNameTextBox.Location = new System.Drawing.Point(161, 137);
            this.contactLastNameTextBox.Name = "contactLastNameTextBox";
            this.contactLastNameTextBox.Size = new System.Drawing.Size(301, 26);
            this.contactLastNameTextBox.TabIndex = 2;
            // 
            // contactMobileTextBox
            // 
            this.contactMobileTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactBindingSource, "ContactMobile", true));
            this.contactMobileTextBox.Location = new System.Drawing.Point(376, 331);
            this.contactMobileTextBox.Name = "contactMobileTextBox";
            this.contactMobileTextBox.Size = new System.Drawing.Size(145, 26);
            this.contactMobileTextBox.TabIndex = 11;
            // 
            // contactNotesTextBox
            // 
            this.contactNotesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactBindingSource, "ContactNotes", true));
            this.contactNotesTextBox.Location = new System.Drawing.Point(161, 425);
            this.contactNotesTextBox.Multiline = true;
            this.contactNotesTextBox.Name = "contactNotesTextBox";
            this.contactNotesTextBox.Size = new System.Drawing.Size(454, 78);
            this.contactNotesTextBox.TabIndex = 14;
            // 
            // contactPhoneTextBox
            // 
            this.contactPhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactBindingSource, "ContactPhone", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "(000) 000-0000"));
            this.contactPhoneTextBox.Location = new System.Drawing.Point(161, 329);
            this.contactPhoneTextBox.Name = "contactPhoneTextBox";
            this.contactPhoneTextBox.Size = new System.Drawing.Size(145, 26);
            this.contactPhoneTextBox.TabIndex = 10;
            // 
            // contactStateComboBox
            // 
            this.contactStateComboBox.BackColor = System.Drawing.Color.LightGray;
            this.contactStateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactBindingSource, "ContactState", true));
            this.contactStateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.contactStateComboBox.FormattingEnabled = true;
            this.contactStateComboBox.Items.AddRange(new object[] {
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
            this.contactStateComboBox.Location = new System.Drawing.Point(370, 265);
            this.contactStateComboBox.Name = "contactStateComboBox";
            this.contactStateComboBox.Size = new System.Drawing.Size(122, 26);
            this.contactStateComboBox.Sorted = true;
            this.contactStateComboBox.TabIndex = 7;
            // 
            // contactTitleTextBox
            // 
            this.contactTitleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactBindingSource, "ContactTitle", true));
            this.contactTitleTextBox.Location = new System.Drawing.Point(161, 169);
            this.contactTitleTextBox.Name = "contactTitleTextBox";
            this.contactTitleTextBox.Size = new System.Drawing.Size(301, 26);
            this.contactTitleTextBox.TabIndex = 3;
            // 
            // contactZipCodeTextBox
            // 
            this.contactZipCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactBindingSource, "ContactZipCode", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "00000-0000"));
            this.contactZipCodeTextBox.Location = new System.Drawing.Point(575, 265);
            this.contactZipCodeTextBox.Name = "contactZipCodeTextBox";
            this.contactZipCodeTextBox.Size = new System.Drawing.Size(100, 26);
            this.contactZipCodeTextBox.TabIndex = 8;
            // 
            // lblContactInfoTitle
            // 
            this.lblContactInfoTitle.AutoSize = true;
            this.lblContactInfoTitle.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactInfoTitle.ForeColor = System.Drawing.Color.Crimson;
            this.lblContactInfoTitle.Location = new System.Drawing.Point(4, 45);
            this.lblContactInfoTitle.Name = "lblContactInfoTitle";
            this.lblContactInfoTitle.Size = new System.Drawing.Size(274, 43);
            this.lblContactInfoTitle.TabIndex = 37;
            this.lblContactInfoTitle.Text = "Contact Information";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.HotPink;
            this.btnSave.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnSave.Location = new System.Drawing.Point(395, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 43);
            this.btnSave.TabIndex = 38;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.HotPink;
            this.btnCancel.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnCancel.Location = new System.Drawing.Point(623, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 43);
            this.btnCancel.TabIndex = 39;
            this.btnCancel.Text = "Exit";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.HotPink;
            this.btnClear.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnClear.Location = new System.Drawing.Point(508, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 43);
            this.btnClear.TabIndex = 40;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(732, 535);
            this.ControlBox = false;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblContactInfoTitle);
            this.Controls.Add(contactAddressLabel);
            this.Controls.Add(this.contactAddressTextBox);
            this.Controls.Add(contactCityLabel);
            this.Controls.Add(this.contactCityTextBox);
            this.Controls.Add(contactContactedViaLabel);
            this.Controls.Add(this.contactContactedViaComboBox);
            this.Controls.Add(contactDepartmentLabel);
            this.Controls.Add(this.contactDepartmentTextBox);
            this.Controls.Add(contactEmailLabel);
            this.Controls.Add(this.contactEmailTextBox);
            this.Controls.Add(contactFaxLabel);
            this.Controls.Add(this.contactFaxTextBox);
            this.Controls.Add(contactFirstNameLabel);
            this.Controls.Add(this.contactFirstNameTextBox);
            this.Controls.Add(contactIDLabel);
            this.Controls.Add(this.contactIDTextBox);
            this.Controls.Add(contactLastNameLabel);
            this.Controls.Add(this.contactLastNameTextBox);
            this.Controls.Add(contactMobileLabel);
            this.Controls.Add(this.contactMobileTextBox);
            this.Controls.Add(contactNotesLabel);
            this.Controls.Add(this.contactNotesTextBox);
            this.Controls.Add(contactPhoneLabel);
            this.Controls.Add(this.contactPhoneTextBox);
            this.Controls.Add(contactStateLabel);
            this.Controls.Add(this.contactStateComboBox);
            this.Controls.Add(contactTitleLabel);
            this.Controls.Add(this.contactTitleTextBox);
            this.Controls.Add(contactZipCodeLabel);
            this.Controls.Add(this.contactZipCodeTextBox);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ContactForm";
            this.Text = "Contact";
            this.Load += new System.EventHandler(this.ContactForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource contactBindingSource;
        private System.Windows.Forms.TextBox contactAddressTextBox;
        private System.Windows.Forms.TextBox contactCityTextBox;
        private System.Windows.Forms.ComboBox contactContactedViaComboBox;
        private System.Windows.Forms.TextBox contactDepartmentTextBox;
        private System.Windows.Forms.TextBox contactEmailTextBox;
        private System.Windows.Forms.TextBox contactFaxTextBox;
        private System.Windows.Forms.TextBox contactFirstNameTextBox;
        private System.Windows.Forms.TextBox contactIDTextBox;
        private System.Windows.Forms.TextBox contactLastNameTextBox;
        private System.Windows.Forms.TextBox contactMobileTextBox;
        private System.Windows.Forms.TextBox contactNotesTextBox;
        private System.Windows.Forms.TextBox contactPhoneTextBox;
        private System.Windows.Forms.ComboBox contactStateComboBox;
        private System.Windows.Forms.TextBox contactTitleTextBox;
        private System.Windows.Forms.TextBox contactZipCodeTextBox;
        private System.Windows.Forms.Label lblContactInfoTitle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClear;
    }
}