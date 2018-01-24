namespace WindowsFormsApplication1
{
    partial class frmContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContact));
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslblContactID = new System.Windows.Forms.ToolStripLabel();
            this.tstbCustomerIDField = new System.Windows.Forms.ToolStripTextBox();
            this.lblContactID = new System.Windows.Forms.Label();
            this.lblContactFax = new System.Windows.Forms.Label();
            this.lblContactName = new System.Windows.Forms.Label();
            this.lblContactTitle = new System.Windows.Forms.Label();
            this.lblContactDepartment = new System.Windows.Forms.Label();
            this.lblContactAddress = new System.Windows.Forms.Label();
            this.lblContactCity = new System.Windows.Forms.Label();
            this.lblContactState = new System.Windows.Forms.Label();
            this.lblContactZipCode = new System.Windows.Forms.Label();
            this.lblContactPhone = new System.Windows.Forms.Label();
            this.lblContactMobile = new System.Windows.Forms.Label();
            this.lblContactEmail = new System.Windows.Forms.Label();
            this.lblContactContactedVia = new System.Windows.Forms.Label();
            this.lblContactNotes = new System.Windows.Forms.Label();
            this.txtContactID = new System.Windows.Forms.TextBox();
            this.txtContactPhone = new System.Windows.Forms.TextBox();
            this.txtContactFax = new System.Windows.Forms.TextBox();
            this.txtContactMobile = new System.Windows.Forms.TextBox();
            this.txtContactEmail = new System.Windows.Forms.TextBox();
            this.txtContactCity = new System.Windows.Forms.TextBox();
            this.txtContactAddress = new System.Windows.Forms.TextBox();
            this.txtContactDepartment = new System.Windows.Forms.TextBox();
            this.txtContactTitle = new System.Windows.Forms.TextBox();
            this.txtContactName = new System.Windows.Forms.TextBox();
            this.txtContactZipCode = new System.Windows.Forms.TextBox();
            this.txtContactNotes = new System.Windows.Forms.TextBox();
            this.lblContactInfoTitle = new System.Windows.Forms.Label();
            this.cmbContactState = new System.Windows.Forms.ComboBox();
            this.cmbContactContactedVia = new System.Windows.Forms.ComboBox();
            this.tsbtnSearchCustomerID = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tsbtnContactExit = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
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
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.saveToolStripButton,
            this.printToolStripButton,
            this.toolStripSeparator,
            this.tsbtnContactExit});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(732, 27);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightGray;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblContactID,
            this.tstbCustomerIDField,
            this.tsbtnSearchCustomerID});
            this.toolStrip1.Location = new System.Drawing.Point(0, 27);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(732, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tslblContactID
            // 
            this.tslblContactID.BackColor = System.Drawing.Color.LightBlue;
            this.tslblContactID.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tslblContactID.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslblContactID.ForeColor = System.Drawing.Color.DarkRed;
            this.tslblContactID.Name = "tslblContactID";
            this.tslblContactID.Size = new System.Drawing.Size(75, 22);
            this.tslblContactID.Text = "Contact ID:";
            // 
            // tstbCustomerIDField
            // 
            this.tstbCustomerIDField.BackColor = System.Drawing.Color.LemonChiffon;
            this.tstbCustomerIDField.Name = "tstbCustomerIDField";
            this.tstbCustomerIDField.Size = new System.Drawing.Size(100, 25);
            // 
            // lblContactID
            // 
            this.lblContactID.AutoSize = true;
            this.lblContactID.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactID.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblContactID.Location = new System.Drawing.Point(391, 113);
            this.lblContactID.Name = "lblContactID";
            this.lblContactID.Size = new System.Drawing.Size(85, 19);
            this.lblContactID.TabIndex = 3;
            this.lblContactID.Text = "Contact ID:";
            // 
            // lblContactFax
            // 
            this.lblContactFax.AutoSize = true;
            this.lblContactFax.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactFax.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblContactFax.Location = new System.Drawing.Point(81, 336);
            this.lblContactFax.Name = "lblContactFax";
            this.lblContactFax.Size = new System.Drawing.Size(38, 19);
            this.lblContactFax.TabIndex = 4;
            this.lblContactFax.Text = "Fax:";
            // 
            // lblContactName
            // 
            this.lblContactName.AutoSize = true;
            this.lblContactName.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactName.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblContactName.Location = new System.Drawing.Point(69, 112);
            this.lblContactName.Name = "lblContactName";
            this.lblContactName.Size = new System.Drawing.Size(50, 19);
            this.lblContactName.TabIndex = 5;
            this.lblContactName.Text = "Name:";
            // 
            // lblContactTitle
            // 
            this.lblContactTitle.AutoSize = true;
            this.lblContactTitle.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblContactTitle.Location = new System.Drawing.Point(74, 144);
            this.lblContactTitle.Name = "lblContactTitle";
            this.lblContactTitle.Size = new System.Drawing.Size(45, 19);
            this.lblContactTitle.TabIndex = 6;
            this.lblContactTitle.Text = "Title:";
            // 
            // lblContactDepartment
            // 
            this.lblContactDepartment.AutoSize = true;
            this.lblContactDepartment.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactDepartment.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblContactDepartment.Location = new System.Drawing.Point(32, 176);
            this.lblContactDepartment.Name = "lblContactDepartment";
            this.lblContactDepartment.Size = new System.Drawing.Size(87, 19);
            this.lblContactDepartment.TabIndex = 7;
            this.lblContactDepartment.Text = "Department:";
            // 
            // lblContactAddress
            // 
            this.lblContactAddress.AutoSize = true;
            this.lblContactAddress.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactAddress.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblContactAddress.Location = new System.Drawing.Point(53, 208);
            this.lblContactAddress.Name = "lblContactAddress";
            this.lblContactAddress.Size = new System.Drawing.Size(66, 19);
            this.lblContactAddress.TabIndex = 8;
            this.lblContactAddress.Text = "Address:";
            // 
            // lblContactCity
            // 
            this.lblContactCity.AutoSize = true;
            this.lblContactCity.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactCity.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblContactCity.Location = new System.Drawing.Point(79, 240);
            this.lblContactCity.Name = "lblContactCity";
            this.lblContactCity.Size = new System.Drawing.Size(40, 19);
            this.lblContactCity.TabIndex = 9;
            this.lblContactCity.Text = "City:";
            // 
            // lblContactState
            // 
            this.lblContactState.AutoSize = true;
            this.lblContactState.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactState.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblContactState.Location = new System.Drawing.Point(291, 240);
            this.lblContactState.Name = "lblContactState";
            this.lblContactState.Size = new System.Drawing.Size(50, 19);
            this.lblContactState.TabIndex = 10;
            this.lblContactState.Text = "State:";
            // 
            // lblContactZipCode
            // 
            this.lblContactZipCode.AutoSize = true;
            this.lblContactZipCode.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactZipCode.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblContactZipCode.Location = new System.Drawing.Point(393, 240);
            this.lblContactZipCode.Name = "lblContactZipCode";
            this.lblContactZipCode.Size = new System.Drawing.Size(71, 19);
            this.lblContactZipCode.TabIndex = 11;
            this.lblContactZipCode.Text = "Zip Code:";
            // 
            // lblContactPhone
            // 
            this.lblContactPhone.AutoSize = true;
            this.lblContactPhone.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactPhone.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblContactPhone.Location = new System.Drawing.Point(68, 272);
            this.lblContactPhone.Name = "lblContactPhone";
            this.lblContactPhone.Size = new System.Drawing.Size(51, 19);
            this.lblContactPhone.TabIndex = 12;
            this.lblContactPhone.Text = "Phone:";
            this.lblContactPhone.Click += new System.EventHandler(this.lblMobile_Click);
            // 
            // lblContactMobile
            // 
            this.lblContactMobile.AutoSize = true;
            this.lblContactMobile.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactMobile.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblContactMobile.Location = new System.Drawing.Point(63, 304);
            this.lblContactMobile.Name = "lblContactMobile";
            this.lblContactMobile.Size = new System.Drawing.Size(56, 19);
            this.lblContactMobile.TabIndex = 13;
            this.lblContactMobile.Text = "Mobile:";
            // 
            // lblContactEmail
            // 
            this.lblContactEmail.AutoSize = true;
            this.lblContactEmail.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactEmail.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblContactEmail.Location = new System.Drawing.Point(71, 368);
            this.lblContactEmail.Name = "lblContactEmail";
            this.lblContactEmail.Size = new System.Drawing.Size(48, 19);
            this.lblContactEmail.TabIndex = 14;
            this.lblContactEmail.Text = "Email:";
            // 
            // lblContactContactedVia
            // 
            this.lblContactContactedVia.AutoSize = true;
            this.lblContactContactedVia.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactContactedVia.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblContactContactedVia.Location = new System.Drawing.Point(15, 400);
            this.lblContactContactedVia.Name = "lblContactContactedVia";
            this.lblContactContactedVia.Size = new System.Drawing.Size(104, 19);
            this.lblContactContactedVia.TabIndex = 15;
            this.lblContactContactedVia.Text = "Contacted Via:";
            // 
            // lblContactNotes
            // 
            this.lblContactNotes.AutoSize = true;
            this.lblContactNotes.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNotes.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblContactNotes.Location = new System.Drawing.Point(67, 432);
            this.lblContactNotes.Name = "lblContactNotes";
            this.lblContactNotes.Size = new System.Drawing.Size(52, 19);
            this.lblContactNotes.TabIndex = 16;
            this.lblContactNotes.Text = "Notes:";
            // 
            // txtContactID
            // 
            this.txtContactID.BackColor = System.Drawing.Color.LightGray;
            this.txtContactID.Location = new System.Drawing.Point(478, 110);
            this.txtContactID.Name = "txtContactID";
            this.txtContactID.ReadOnly = true;
            this.txtContactID.Size = new System.Drawing.Size(100, 26);
            this.txtContactID.TabIndex = 17;
            // 
            // txtContactPhone
            // 
            this.txtContactPhone.Location = new System.Drawing.Point(124, 270);
            this.txtContactPhone.Name = "txtContactPhone";
            this.txtContactPhone.Size = new System.Drawing.Size(128, 26);
            this.txtContactPhone.TabIndex = 23;
            // 
            // txtContactFax
            // 
            this.txtContactFax.Location = new System.Drawing.Point(124, 334);
            this.txtContactFax.Name = "txtContactFax";
            this.txtContactFax.Size = new System.Drawing.Size(128, 26);
            this.txtContactFax.TabIndex = 25;
            // 
            // txtContactMobile
            // 
            this.txtContactMobile.Location = new System.Drawing.Point(124, 302);
            this.txtContactMobile.Name = "txtContactMobile";
            this.txtContactMobile.Size = new System.Drawing.Size(128, 26);
            this.txtContactMobile.TabIndex = 24;
            // 
            // txtContactEmail
            // 
            this.txtContactEmail.Location = new System.Drawing.Point(124, 366);
            this.txtContactEmail.Name = "txtContactEmail";
            this.txtContactEmail.Size = new System.Drawing.Size(261, 26);
            this.txtContactEmail.TabIndex = 26;
            // 
            // txtContactCity
            // 
            this.txtContactCity.Location = new System.Drawing.Point(124, 238);
            this.txtContactCity.Name = "txtContactCity";
            this.txtContactCity.Size = new System.Drawing.Size(161, 26);
            this.txtContactCity.TabIndex = 32;
            // 
            // txtContactAddress
            // 
            this.txtContactAddress.Location = new System.Drawing.Point(124, 206);
            this.txtContactAddress.Name = "txtContactAddress";
            this.txtContactAddress.Size = new System.Drawing.Size(263, 26);
            this.txtContactAddress.TabIndex = 31;
            // 
            // txtContactDepartment
            // 
            this.txtContactDepartment.Location = new System.Drawing.Point(124, 174);
            this.txtContactDepartment.Name = "txtContactDepartment";
            this.txtContactDepartment.Size = new System.Drawing.Size(261, 26);
            this.txtContactDepartment.TabIndex = 30;
            // 
            // txtContactTitle
            // 
            this.txtContactTitle.Location = new System.Drawing.Point(124, 142);
            this.txtContactTitle.Name = "txtContactTitle";
            this.txtContactTitle.Size = new System.Drawing.Size(261, 26);
            this.txtContactTitle.TabIndex = 29;
            // 
            // txtContactName
            // 
            this.txtContactName.Location = new System.Drawing.Point(124, 110);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(261, 26);
            this.txtContactName.TabIndex = 28;
            // 
            // txtContactZipCode
            // 
            this.txtContactZipCode.Location = new System.Drawing.Point(466, 238);
            this.txtContactZipCode.Name = "txtContactZipCode";
            this.txtContactZipCode.Size = new System.Drawing.Size(112, 26);
            this.txtContactZipCode.TabIndex = 34;
            // 
            // txtContactNotes
            // 
            this.txtContactNotes.Location = new System.Drawing.Point(124, 430);
            this.txtContactNotes.Multiline = true;
            this.txtContactNotes.Name = "txtContactNotes";
            this.txtContactNotes.Size = new System.Drawing.Size(454, 78);
            this.txtContactNotes.TabIndex = 33;
            // 
            // lblContactInfoTitle
            // 
            this.lblContactInfoTitle.AutoSize = true;
            this.lblContactInfoTitle.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactInfoTitle.ForeColor = System.Drawing.Color.Crimson;
            this.lblContactInfoTitle.Location = new System.Drawing.Point(12, 57);
            this.lblContactInfoTitle.Name = "lblContactInfoTitle";
            this.lblContactInfoTitle.Size = new System.Drawing.Size(274, 43);
            this.lblContactInfoTitle.TabIndex = 36;
            this.lblContactInfoTitle.Text = "Contact Information";
            // 
            // cmbContactState
            // 
            this.cmbContactState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbContactState.FormattingEnabled = true;
            this.cmbContactState.Items.AddRange(new object[] {
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
            "Louisiana",
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
            this.cmbContactState.Location = new System.Drawing.Point(342, 237);
            this.cmbContactState.Name = "cmbContactState";
            this.cmbContactState.Size = new System.Drawing.Size(45, 26);
            this.cmbContactState.TabIndex = 37;
            // 
            // cmbContactContactedVia
            // 
            this.cmbContactContactedVia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbContactContactedVia.FormattingEnabled = true;
            this.cmbContactContactedVia.Items.AddRange(new object[] {
            "Phone",
            "Text",
            "Email",
            "Person",
            "Letter"});
            this.cmbContactContactedVia.Location = new System.Drawing.Point(124, 398);
            this.cmbContactContactedVia.Name = "cmbContactContactedVia";
            this.cmbContactContactedVia.Size = new System.Drawing.Size(128, 26);
            this.cmbContactContactedVia.TabIndex = 38;
            // 
            // tsbtnSearchCustomerID
            // 
            this.tsbtnSearchCustomerID.BackColor = System.Drawing.Color.SandyBrown;
            this.tsbtnSearchCustomerID.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnSearchCustomerID.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnSearchCustomerID.ForeColor = System.Drawing.Color.DarkRed;
            this.tsbtnSearchCustomerID.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSearchCustomerID.Image")));
            this.tsbtnSearchCustomerID.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSearchCustomerID.Name = "tsbtnSearchCustomerID";
            this.tsbtnSearchCustomerID.Size = new System.Drawing.Size(52, 22);
            this.tsbtnSearchCustomerID.Text = "Search";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Enabled = false;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 24);
            this.saveToolStripButton.Text = "&Save";
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(23, 24);
            this.printToolStripButton.Text = "&Print";
            // 
            // tsbtnContactExit
            // 
            this.tsbtnContactExit.BackColor = System.Drawing.Color.Cyan;
            this.tsbtnContactExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnContactExit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnContactExit.ForeColor = System.Drawing.Color.Red;
            this.tsbtnContactExit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnContactExit.Image")));
            this.tsbtnContactExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnContactExit.Name = "tsbtnContactExit";
            this.tsbtnContactExit.Size = new System.Drawing.Size(39, 24);
            this.tsbtnContactExit.Text = "Exit";
            // 
            // frmContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(732, 535);
            this.Controls.Add(this.cmbContactContactedVia);
            this.Controls.Add(this.cmbContactState);
            this.Controls.Add(this.lblContactInfoTitle);
            this.Controls.Add(this.txtContactZipCode);
            this.Controls.Add(this.txtContactNotes);
            this.Controls.Add(this.txtContactCity);
            this.Controls.Add(this.txtContactAddress);
            this.Controls.Add(this.txtContactDepartment);
            this.Controls.Add(this.txtContactTitle);
            this.Controls.Add(this.txtContactName);
            this.Controls.Add(this.txtContactEmail);
            this.Controls.Add(this.txtContactFax);
            this.Controls.Add(this.txtContactMobile);
            this.Controls.Add(this.txtContactPhone);
            this.Controls.Add(this.txtContactID);
            this.Controls.Add(this.lblContactNotes);
            this.Controls.Add(this.lblContactContactedVia);
            this.Controls.Add(this.lblContactEmail);
            this.Controls.Add(this.lblContactMobile);
            this.Controls.Add(this.lblContactPhone);
            this.Controls.Add(this.lblContactZipCode);
            this.Controls.Add(this.lblContactState);
            this.Controls.Add(this.lblContactCity);
            this.Controls.Add(this.lblContactAddress);
            this.Controls.Add(this.lblContactDepartment);
            this.Controls.Add(this.lblContactTitle);
            this.Controls.Add(this.lblContactName);
            this.Controls.Add(this.lblContactFax);
            this.Controls.Add(this.lblContactID);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.bindingNavigator1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmContact";
            this.Text = "Contact";
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslblContactID;
        private System.Windows.Forms.ToolStripButton tsbtnContactExit;
        private System.Windows.Forms.ToolStripTextBox tstbCustomerIDField;
        private System.Windows.Forms.ToolStripButton tsbtnSearchCustomerID;
        private System.Windows.Forms.Label lblContactID;
        private System.Windows.Forms.Label lblContactFax;
        private System.Windows.Forms.Label lblContactName;
        private System.Windows.Forms.Label lblContactTitle;
        private System.Windows.Forms.Label lblContactDepartment;
        private System.Windows.Forms.Label lblContactAddress;
        private System.Windows.Forms.Label lblContactCity;
        private System.Windows.Forms.Label lblContactState;
        private System.Windows.Forms.Label lblContactZipCode;
        private System.Windows.Forms.Label lblContactPhone;
        private System.Windows.Forms.Label lblContactMobile;
        private System.Windows.Forms.Label lblContactEmail;
        private System.Windows.Forms.Label lblContactContactedVia;
        private System.Windows.Forms.Label lblContactNotes;
        private System.Windows.Forms.TextBox txtContactID;
        private System.Windows.Forms.TextBox txtContactPhone;
        private System.Windows.Forms.TextBox txtContactFax;
        private System.Windows.Forms.TextBox txtContactMobile;
        private System.Windows.Forms.TextBox txtContactEmail;
        private System.Windows.Forms.TextBox txtContactCity;
        private System.Windows.Forms.TextBox txtContactAddress;
        private System.Windows.Forms.TextBox txtContactDepartment;
        private System.Windows.Forms.TextBox txtContactTitle;
        private System.Windows.Forms.TextBox txtContactName;
        private System.Windows.Forms.TextBox txtContactZipCode;
        private System.Windows.Forms.TextBox txtContactNotes;
        private System.Windows.Forms.Label lblContactInfoTitle;
        private System.Windows.Forms.ComboBox cmbContactState;
        private System.Windows.Forms.ComboBox cmbContactContactedVia;
    }
}