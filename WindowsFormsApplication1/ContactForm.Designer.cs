namespace WindowsFormsApplication1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactForm));
            this.contactAddressTextBox = new System.Windows.Forms.TextBox();
            this.contactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactCityTextBox = new System.Windows.Forms.TextBox();
            this.contactContactedViaComboBox = new System.Windows.Forms.ComboBox();
            this.contactDepartmentTextBox = new System.Windows.Forms.TextBox();
            this.contactEmailTextBox = new System.Windows.Forms.TextBox();
            this.contactFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.contactIDTextBox = new System.Windows.Forms.TextBox();
            this.contactLastNameTextBox = new System.Windows.Forms.TextBox();
            this.contactNotesTextBox = new System.Windows.Forms.TextBox();
            this.contactStateComboBox = new System.Windows.Forms.ComboBox();
            this.contactBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.contactTitleTextBox = new System.Windows.Forms.TextBox();
            this.lblContactInfoTitle = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.contactPhoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.contactMobileMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.contactFaxMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.contactZipCodeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonContactID = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonContactLastName = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
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
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contactAddressLabel
            // 
            contactAddressLabel.AutoSize = true;
            contactAddressLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contactAddressLabel.ForeColor = System.Drawing.Color.DarkBlue;
            contactAddressLabel.Location = new System.Drawing.Point(89, 263);
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
            contactCityLabel.Location = new System.Drawing.Point(115, 295);
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
            contactContactedViaLabel.Location = new System.Drawing.Point(51, 326);
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
            contactDepartmentLabel.Location = new System.Drawing.Point(68, 231);
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
            contactEmailLabel.Location = new System.Drawing.Point(107, 423);
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
            contactFaxLabel.Location = new System.Drawing.Point(117, 391);
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
            contactFirstNameLabel.Location = new System.Drawing.Point(69, 135);
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
            contactIDLabel.Location = new System.Drawing.Point(467, 134);
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
            contactLastNameLabel.Location = new System.Drawing.Point(73, 167);
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
            contactMobileLabel.Location = new System.Drawing.Point(314, 361);
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
            contactNotesLabel.Location = new System.Drawing.Point(103, 455);
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
            contactPhoneLabel.Location = new System.Drawing.Point(104, 359);
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
            contactStateLabel.Location = new System.Drawing.Point(314, 295);
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
            contactTitleLabel.Location = new System.Drawing.Point(110, 199);
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
            contactZipCodeLabel.Location = new System.Drawing.Point(498, 295);
            contactZipCodeLabel.Name = "contactZipCodeLabel";
            contactZipCodeLabel.Size = new System.Drawing.Size(71, 19);
            contactZipCodeLabel.TabIndex = 29;
            contactZipCodeLabel.Text = "Zip Code:";
            // 
            // contactAddressTextBox
            // 
            this.contactAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactBindingSource, "ContactAddress", true));
            this.contactAddressTextBox.Location = new System.Drawing.Point(161, 260);
            this.contactAddressTextBox.Name = "contactAddressTextBox";
            this.contactAddressTextBox.Size = new System.Drawing.Size(300, 26);
            this.contactAddressTextBox.TabIndex = 5;
            // 
            // contactBindingSource
            // 
            this.contactBindingSource.DataSource = typeof(SharpERBLL.Contact);
            // 
            // contactCityTextBox
            // 
            this.contactCityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactBindingSource, "ContactCity", true));
            this.contactCityTextBox.Location = new System.Drawing.Point(161, 292);
            this.contactCityTextBox.Name = "contactCityTextBox";
            this.contactCityTextBox.Size = new System.Drawing.Size(145, 26);
            this.contactCityTextBox.TabIndex = 6;
            // 
            // contactContactedViaComboBox
            // 
            this.contactContactedViaComboBox.BackColor = System.Drawing.Color.LightGray;
            this.contactContactedViaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactBindingSource, "ContactContactedVia", true));
            this.contactContactedViaComboBox.DisplayMember = "Text";
            this.contactContactedViaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.contactContactedViaComboBox.FormattingEnabled = true;
            this.contactContactedViaComboBox.Items.AddRange(new object[] {
            "Email",
            "In Person",
            "Letter",
            "Myself",
            "Phone",
            "Text"});
            this.contactContactedViaComboBox.Location = new System.Drawing.Point(161, 324);
            this.contactContactedViaComboBox.Name = "contactContactedViaComboBox";
            this.contactContactedViaComboBox.Size = new System.Drawing.Size(117, 26);
            this.contactContactedViaComboBox.Sorted = true;
            this.contactContactedViaComboBox.TabIndex = 9;
            this.contactContactedViaComboBox.ValueMember = "Text";
            // 
            // contactDepartmentTextBox
            // 
            this.contactDepartmentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactBindingSource, "ContactDepartment", true));
            this.contactDepartmentTextBox.Location = new System.Drawing.Point(161, 228);
            this.contactDepartmentTextBox.Name = "contactDepartmentTextBox";
            this.contactDepartmentTextBox.Size = new System.Drawing.Size(300, 26);
            this.contactDepartmentTextBox.TabIndex = 4;
            // 
            // contactEmailTextBox
            // 
            this.contactEmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactBindingSource, "ContactEmail", true));
            this.contactEmailTextBox.Location = new System.Drawing.Point(161, 420);
            this.contactEmailTextBox.Name = "contactEmailTextBox";
            this.contactEmailTextBox.Size = new System.Drawing.Size(300, 26);
            this.contactEmailTextBox.TabIndex = 13;
            // 
            // contactFirstNameTextBox
            // 
            this.contactFirstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactBindingSource, "ContactFirstName", true));
            this.contactFirstNameTextBox.Location = new System.Drawing.Point(161, 132);
            this.contactFirstNameTextBox.Name = "contactFirstNameTextBox";
            this.contactFirstNameTextBox.Size = new System.Drawing.Size(117, 26);
            this.contactFirstNameTextBox.TabIndex = 1;
            // 
            // contactIDTextBox
            // 
            this.contactIDTextBox.BackColor = System.Drawing.Color.LightGray;
            this.contactIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactBindingSource, "ContactID", true));
            this.contactIDTextBox.Location = new System.Drawing.Point(558, 132);
            this.contactIDTextBox.Name = "contactIDTextBox";
            this.contactIDTextBox.ReadOnly = true;
            this.contactIDTextBox.Size = new System.Drawing.Size(117, 26);
            this.contactIDTextBox.TabIndex = 15;
            // 
            // contactLastNameTextBox
            // 
            this.contactLastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactBindingSource, "ContactLastName", true));
            this.contactLastNameTextBox.Location = new System.Drawing.Point(161, 164);
            this.contactLastNameTextBox.Name = "contactLastNameTextBox";
            this.contactLastNameTextBox.Size = new System.Drawing.Size(117, 26);
            this.contactLastNameTextBox.TabIndex = 2;
            // 
            // contactNotesTextBox
            // 
            this.contactNotesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactBindingSource, "ContactNotes", true));
            this.contactNotesTextBox.Location = new System.Drawing.Point(161, 452);
            this.contactNotesTextBox.Multiline = true;
            this.contactNotesTextBox.Name = "contactNotesTextBox";
            this.contactNotesTextBox.Size = new System.Drawing.Size(454, 78);
            this.contactNotesTextBox.TabIndex = 14;
            // 
            // contactStateComboBox
            // 
            this.contactStateComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.contactStateComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
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
            this.contactStateComboBox.Location = new System.Drawing.Point(370, 292);
            this.contactStateComboBox.Name = "contactStateComboBox";
            this.contactStateComboBox.Size = new System.Drawing.Size(117, 26);
            this.contactStateComboBox.Sorted = true;
            this.contactStateComboBox.TabIndex = 7;
            // 
            // contactBindingSource1
            // 
            this.contactBindingSource1.DataSource = typeof(SharpERBLL.Contact);
            // 
            // contactTitleTextBox
            // 
            this.contactTitleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactBindingSource, "ContactTitle", true));
            this.contactTitleTextBox.Location = new System.Drawing.Point(161, 196);
            this.contactTitleTextBox.Name = "contactTitleTextBox";
            this.contactTitleTextBox.Size = new System.Drawing.Size(300, 26);
            this.contactTitleTextBox.TabIndex = 3;
            // 
            // lblContactInfoTitle
            // 
            this.lblContactInfoTitle.AutoSize = true;
            this.lblContactInfoTitle.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactInfoTitle.ForeColor = System.Drawing.Color.Crimson;
            this.lblContactInfoTitle.Location = new System.Drawing.Point(1, 77);
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
            this.btnSave.Location = new System.Drawing.Point(437, 39);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 43);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.HotPink;
            this.btnCancel.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnCancel.Location = new System.Drawing.Point(558, 39);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(162, 43);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel / Exit";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // contactPhoneMaskedTextBox
            // 
            this.contactPhoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactBindingSource, "ContactPhone", true));
            this.contactPhoneMaskedTextBox.Location = new System.Drawing.Point(161, 356);
            this.contactPhoneMaskedTextBox.Mask = "(999) 000-0000";
            this.contactPhoneMaskedTextBox.Name = "contactPhoneMaskedTextBox";
            this.contactPhoneMaskedTextBox.Size = new System.Drawing.Size(117, 26);
            this.contactPhoneMaskedTextBox.TabIndex = 10;
            // 
            // contactMobileMaskedTextBox
            // 
            this.contactMobileMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactBindingSource, "ContactMobile", true));
            this.contactMobileMaskedTextBox.Location = new System.Drawing.Point(370, 358);
            this.contactMobileMaskedTextBox.Mask = "(999) 000-0000";
            this.contactMobileMaskedTextBox.Name = "contactMobileMaskedTextBox";
            this.contactMobileMaskedTextBox.Size = new System.Drawing.Size(117, 26);
            this.contactMobileMaskedTextBox.TabIndex = 11;
            // 
            // contactFaxMaskedTextBox
            // 
            this.contactFaxMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactBindingSource, "ContactFax", true));
            this.contactFaxMaskedTextBox.Location = new System.Drawing.Point(161, 388);
            this.contactFaxMaskedTextBox.Mask = "(999) 000-0000";
            this.contactFaxMaskedTextBox.Name = "contactFaxMaskedTextBox";
            this.contactFaxMaskedTextBox.Size = new System.Drawing.Size(117, 26);
            this.contactFaxMaskedTextBox.TabIndex = 12;
            // 
            // contactZipCodeMaskedTextBox
            // 
            this.contactZipCodeMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactBindingSource, "ContactZipCode", true));
            this.contactZipCodeMaskedTextBox.Location = new System.Drawing.Point(575, 292);
            this.contactZipCodeMaskedTextBox.Mask = "00000-9999";
            this.contactZipCodeMaskedTextBox.Name = "contactZipCodeMaskedTextBox";
            this.contactZipCodeMaskedTextBox.Size = new System.Drawing.Size(100, 26);
            this.contactZipCodeMaskedTextBox.TabIndex = 8;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripTextBox1,
            this.toolStripSeparator2,
            this.toolStripButtonContactID,
            this.toolStripSeparator1,
            this.toolStripButtonContactLastName,
            this.toolStripSeparator3});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(732, 25);
            this.bindingNavigator1.TabIndex = 38;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            this.toolStripTextBox1.ToolTipText = "ENTER HERE the Contact ID or Contact Last Name";
            // 
            // toolStripButtonContactID
            // 
            this.toolStripButtonContactID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStripButtonContactID.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonContactID.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonContactID.ForeColor = System.Drawing.Color.Black;
            this.toolStripButtonContactID.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonContactID.Name = "toolStripButtonContactID";
            this.toolStripButtonContactID.Size = new System.Drawing.Size(75, 22);
            this.toolStripButtonContactID.Text = "Contact ID";
            // 
            // toolStripButtonContactLastName
            // 
            this.toolStripButtonContactLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStripButtonContactLastName.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonContactLastName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonContactLastName.ForeColor = System.Drawing.Color.Black;
            this.toolStripButtonContactLastName.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonContactLastName.Name = "toolStripButtonContactLastName";
            this.toolStripButtonContactLastName.Size = new System.Drawing.Size(76, 22);
            this.toolStripButtonContactLastName.Text = "Last Name";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(732, 570);
            this.ControlBox = false;
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.contactZipCodeMaskedTextBox);
            this.Controls.Add(this.contactFaxMaskedTextBox);
            this.Controls.Add(this.contactMobileMaskedTextBox);
            this.Controls.Add(this.contactPhoneMaskedTextBox);
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
            this.Controls.Add(contactFirstNameLabel);
            this.Controls.Add(this.contactFirstNameTextBox);
            this.Controls.Add(contactIDLabel);
            this.Controls.Add(this.contactIDTextBox);
            this.Controls.Add(contactLastNameLabel);
            this.Controls.Add(this.contactLastNameTextBox);
            this.Controls.Add(contactMobileLabel);
            this.Controls.Add(contactNotesLabel);
            this.Controls.Add(this.contactNotesTextBox);
            this.Controls.Add(contactPhoneLabel);
            this.Controls.Add(contactStateLabel);
            this.Controls.Add(this.contactStateComboBox);
            this.Controls.Add(contactTitleLabel);
            this.Controls.Add(this.contactTitleTextBox);
            this.Controls.Add(contactZipCodeLabel);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ContactForm";
            this.Text = "Contact";
            this.Load += new System.EventHandler(this.ContactForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox contactAddressTextBox;
        private System.Windows.Forms.TextBox contactCityTextBox;
        private System.Windows.Forms.ComboBox contactContactedViaComboBox;
        private System.Windows.Forms.TextBox contactDepartmentTextBox;
        private System.Windows.Forms.TextBox contactEmailTextBox;
        private System.Windows.Forms.TextBox contactFirstNameTextBox;
        private System.Windows.Forms.TextBox contactIDTextBox;
        private System.Windows.Forms.TextBox contactLastNameTextBox;
        private System.Windows.Forms.TextBox contactNotesTextBox;
        private System.Windows.Forms.ComboBox contactStateComboBox;
        private System.Windows.Forms.TextBox contactTitleTextBox;
        private System.Windows.Forms.Label lblContactInfoTitle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.MaskedTextBox contactPhoneMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox contactMobileMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox contactFaxMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox contactZipCodeMaskedTextBox;
        private System.Windows.Forms.BindingSource contactBindingSource1;
        public System.Windows.Forms.BindingSource contactBindingSource;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripButtonContactID;
        private System.Windows.Forms.ToolStripButton toolStripButtonContactLastName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}