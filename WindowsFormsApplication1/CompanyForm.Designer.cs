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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyForm));
            this.lblCompanyInfoTitle = new System.Windows.Forms.Label();
            this.companyAddressTextBox = new System.Windows.Forms.TextBox();
            this.companyCityTextBox = new System.Windows.Forms.TextBox();
            this.companyFaxTextBox = new System.Windows.Forms.TextBox();
            this.companyIDTextBox = new System.Windows.Forms.TextBox();
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.companyNotesTextBox = new System.Windows.Forms.TextBox();
            this.companyPhoneTextBox = new System.Windows.Forms.TextBox();
            this.companyStateComboBox = new System.Windows.Forms.ComboBox();
            this.companyWebsiteTextBox = new System.Windows.Forms.TextBox();
            this.companyZipCodeTextBox = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelCompanyIDLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxCompanyIDTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.companyBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonCompanySearchButton = new System.Windows.Forms.ToolStripButton();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
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
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingNavigator)).BeginInit();
            this.companyBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // companyAddressTextBox
            // 
            this.companyAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "CompanyAddress", true));
            this.companyAddressTextBox.Location = new System.Drawing.Point(117, 141);
            this.companyAddressTextBox.Name = "companyAddressTextBox";
            this.companyAddressTextBox.Size = new System.Drawing.Size(299, 26);
            this.companyAddressTextBox.TabIndex = 68;
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
            // companyCityTextBox
            // 
            this.companyCityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "CompanyCity", true));
            this.companyCityTextBox.Location = new System.Drawing.Point(117, 173);
            this.companyCityTextBox.Name = "companyCityTextBox";
            this.companyCityTextBox.Size = new System.Drawing.Size(175, 26);
            this.companyCityTextBox.TabIndex = 70;
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
            // companyFaxTextBox
            // 
            this.companyFaxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "CompanyFax", true));
            this.companyFaxTextBox.Location = new System.Drawing.Point(117, 237);
            this.companyFaxTextBox.Name = "companyFaxTextBox";
            this.companyFaxTextBox.Size = new System.Drawing.Size(145, 26);
            this.companyFaxTextBox.TabIndex = 72;
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
            // companyNameTextBox
            // 
            this.companyNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "CompanyName", true));
            this.companyNameTextBox.Location = new System.Drawing.Point(117, 109);
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.Size = new System.Drawing.Size(299, 26);
            this.companyNameTextBox.TabIndex = 76;
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
            // companyNotesTextBox
            // 
            this.companyNotesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "CompanyNotes", true));
            this.companyNotesTextBox.Location = new System.Drawing.Point(117, 301);
            this.companyNotesTextBox.Multiline = true;
            this.companyNotesTextBox.Name = "companyNotesTextBox";
            this.companyNotesTextBox.Size = new System.Drawing.Size(454, 78);
            this.companyNotesTextBox.TabIndex = 78;
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
            // companyPhoneTextBox
            // 
            this.companyPhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "CompanyPhone", true));
            this.companyPhoneTextBox.Location = new System.Drawing.Point(117, 205);
            this.companyPhoneTextBox.Name = "companyPhoneTextBox";
            this.companyPhoneTextBox.Size = new System.Drawing.Size(145, 26);
            this.companyPhoneTextBox.TabIndex = 80;
            // 
            // companyStateLabel
            // 
            companyStateLabel.AutoSize = true;
            companyStateLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            companyStateLabel.ForeColor = System.Drawing.Color.DarkBlue;
            companyStateLabel.Location = new System.Drawing.Point(310, 177);
            companyStateLabel.Name = "companyStateLabel";
            companyStateLabel.Size = new System.Drawing.Size(50, 19);
            companyStateLabel.TabIndex = 81;
            companyStateLabel.Text = "State:";
            // 
            // companyStateComboBox
            // 
            this.companyStateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "CompanyState", true));
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
            this.companyStateComboBox.Location = new System.Drawing.Point(361, 174);
            this.companyStateComboBox.Name = "companyStateComboBox";
            this.companyStateComboBox.Size = new System.Drawing.Size(55, 26);
            this.companyStateComboBox.TabIndex = 82;
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
            // companyWebsiteTextBox
            // 
            this.companyWebsiteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "CompanyWebsite", true));
            this.companyWebsiteTextBox.Location = new System.Drawing.Point(117, 269);
            this.companyWebsiteTextBox.Name = "companyWebsiteTextBox";
            this.companyWebsiteTextBox.Size = new System.Drawing.Size(401, 26);
            this.companyWebsiteTextBox.TabIndex = 84;
            // 
            // companyZipCodeLabel
            // 
            companyZipCodeLabel.AutoSize = true;
            companyZipCodeLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            companyZipCodeLabel.ForeColor = System.Drawing.Color.DarkBlue;
            companyZipCodeLabel.Location = new System.Drawing.Point(447, 176);
            companyZipCodeLabel.Name = "companyZipCodeLabel";
            companyZipCodeLabel.Size = new System.Drawing.Size(71, 19);
            companyZipCodeLabel.TabIndex = 85;
            companyZipCodeLabel.Text = "Zip Code:";
            // 
            // companyZipCodeTextBox
            // 
            this.companyZipCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "CompanyZipCode", true));
            this.companyZipCodeTextBox.Location = new System.Drawing.Point(519, 173);
            this.companyZipCodeTextBox.Name = "companyZipCodeTextBox";
            this.companyZipCodeTextBox.Size = new System.Drawing.Size(121, 26);
            this.companyZipCodeTextBox.TabIndex = 86;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightGray;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelCompanyIDLabel,
            this.toolStripTextBoxCompanyIDTextBox,
            this.toolStripButtonCompanySearchButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(732, 25);
            this.toolStrip1.TabIndex = 87;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabelCompanyIDLabel
            // 
            this.toolStripLabelCompanyIDLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabelCompanyIDLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.toolStripLabelCompanyIDLabel.Name = "toolStripLabelCompanyIDLabel";
            this.toolStripLabelCompanyIDLabel.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabelCompanyIDLabel.Text = "Company ID:";
            // 
            // toolStripTextBoxCompanyIDTextBox
            // 
            this.toolStripTextBoxCompanyIDTextBox.Name = "toolStripTextBoxCompanyIDTextBox";
            this.toolStripTextBoxCompanyIDTextBox.Size = new System.Drawing.Size(100, 25);
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // companyBindingNavigator
            // 
            this.companyBindingNavigator.AddNewItem = null;
            this.companyBindingNavigator.BindingSource = this.companyBindingSource;
            this.companyBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.companyBindingNavigator.DeleteItem = null;
            this.companyBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.cutToolStripButton,
            this.toolStripSeparator2,
            this.printToolStripButton,
            this.toolStripSeparator});
            this.companyBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.companyBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.companyBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.companyBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.companyBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.companyBindingNavigator.Name = "companyBindingNavigator";
            this.companyBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.companyBindingNavigator.Size = new System.Drawing.Size(732, 25);
            this.companyBindingNavigator.TabIndex = 67;
            this.companyBindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonCompanySearchButton
            // 
            this.toolStripButtonCompanySearchButton.BackColor = System.Drawing.Color.SandyBrown;
            this.toolStripButtonCompanySearchButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCompanySearchButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonCompanySearchButton.ForeColor = System.Drawing.Color.DarkRed;
            this.toolStripButtonCompanySearchButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCompanySearchButton.Image")));
            this.toolStripButtonCompanySearchButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCompanySearchButton.Name = "toolStripButtonCompanySearchButton";
            this.toolStripButtonCompanySearchButton.Size = new System.Drawing.Size(52, 22);
            this.toolStripButtonCompanySearchButton.Text = "Search";
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(SharpERBLL.Company);
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
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "&New";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = global::WindowsFormsApplication1.Properties.Resources.deletered1;
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.cutToolStripButton.Text = "C&ut";
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printToolStripButton.Text = "&Print";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // CompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(732, 535);
            this.Controls.Add(this.toolStrip1);
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
            this.Controls.Add(this.companyBindingNavigator);
            this.Controls.Add(this.lblCompanyInfoTitle);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CompanyForm";
            this.Text = "Company";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingNavigator)).EndInit();
            this.companyBindingNavigator.ResumeLayout(false);
            this.companyBindingNavigator.PerformLayout();
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
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabelCompanyIDLabel;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxCompanyIDTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButtonCompanySearchButton;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingNavigator companyBindingNavigator;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
    }
}