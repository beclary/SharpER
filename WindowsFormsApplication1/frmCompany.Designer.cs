namespace WindowsFormsApplication1
{
    partial class frmCompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompany));
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslblCompanyIDField = new System.Windows.Forms.ToolStripLabel();
            this.tstbCompanyID = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.cmbCompanyState = new System.Windows.Forms.ComboBox();
            this.lblCompanyInfoTitle = new System.Windows.Forms.Label();
            this.txtCompanyZipCode = new System.Windows.Forms.TextBox();
            this.txtCompanyNotes = new System.Windows.Forms.TextBox();
            this.txtCompanyCity = new System.Windows.Forms.TextBox();
            this.txtCompanyAddress = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtCompanyWebsite = new System.Windows.Forms.TextBox();
            this.txtCompanyFax = new System.Windows.Forms.TextBox();
            this.txtCompanyPhone = new System.Windows.Forms.TextBox();
            this.txtCompanyID = new System.Windows.Forms.TextBox();
            this.lblCompanyNotes = new System.Windows.Forms.Label();
            this.lblCompanyWebsite = new System.Windows.Forms.Label();
            this.lblCompanyPhone = new System.Windows.Forms.Label();
            this.lblCompanyZipCode = new System.Windows.Forms.Label();
            this.lblCompanyState = new System.Windows.Forms.Label();
            this.lblCompanyCity = new System.Windows.Forms.Label();
            this.lblCompanyAddress = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblCompanyFax = new System.Windows.Forms.Label();
            this.lblCompanyID = new System.Windows.Forms.Label();
            this.tsbtnExit = new System.Windows.Forms.ToolStripButton();
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
            this.tsbtnExit});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(751, 27);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
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
            this.tslblCompanyIDField,
            this.tstbCompanyID,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 27);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(751, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tslblCompanyIDField
            // 
            this.tslblCompanyIDField.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tslblCompanyIDField.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslblCompanyIDField.Name = "tslblCompanyIDField";
            this.tslblCompanyIDField.Size = new System.Drawing.Size(86, 22);
            this.tslblCompanyIDField.Text = "Company ID:";
            // 
            // tstbCompanyID
            // 
            this.tstbCompanyID.Name = "tstbCompanyID";
            this.tstbCompanyID.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.BackColor = System.Drawing.Color.SandyBrown;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.ForeColor = System.Drawing.Color.DarkRed;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton1.Text = "Search";
            // 
            // cmbCompanyState
            // 
            this.cmbCompanyState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCompanyState.FormattingEnabled = true;
            this.cmbCompanyState.Items.AddRange(new object[] {
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
            this.cmbCompanyState.Location = new System.Drawing.Point(339, 173);
            this.cmbCompanyState.Name = "cmbCompanyState";
            this.cmbCompanyState.Size = new System.Drawing.Size(45, 26);
            this.cmbCompanyState.TabIndex = 66;
            // 
            // lblCompanyInfoTitle
            // 
            this.lblCompanyInfoTitle.AutoSize = true;
            this.lblCompanyInfoTitle.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyInfoTitle.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblCompanyInfoTitle.Location = new System.Drawing.Point(9, 57);
            this.lblCompanyInfoTitle.Name = "lblCompanyInfoTitle";
            this.lblCompanyInfoTitle.Size = new System.Drawing.Size(291, 43);
            this.lblCompanyInfoTitle.TabIndex = 65;
            this.lblCompanyInfoTitle.Text = "Company Information";
            // 
            // txtCompanyZipCode
            // 
            this.txtCompanyZipCode.Location = new System.Drawing.Point(463, 174);
            this.txtCompanyZipCode.Name = "txtCompanyZipCode";
            this.txtCompanyZipCode.Size = new System.Drawing.Size(112, 26);
            this.txtCompanyZipCode.TabIndex = 64;
            // 
            // txtCompanyNotes
            // 
            this.txtCompanyNotes.Location = new System.Drawing.Point(121, 302);
            this.txtCompanyNotes.Multiline = true;
            this.txtCompanyNotes.Name = "txtCompanyNotes";
            this.txtCompanyNotes.Size = new System.Drawing.Size(454, 78);
            this.txtCompanyNotes.TabIndex = 63;
            // 
            // txtCompanyCity
            // 
            this.txtCompanyCity.Location = new System.Drawing.Point(121, 174);
            this.txtCompanyCity.Name = "txtCompanyCity";
            this.txtCompanyCity.Size = new System.Drawing.Size(161, 26);
            this.txtCompanyCity.TabIndex = 62;
            // 
            // txtCompanyAddress
            // 
            this.txtCompanyAddress.Location = new System.Drawing.Point(121, 142);
            this.txtCompanyAddress.Name = "txtCompanyAddress";
            this.txtCompanyAddress.Size = new System.Drawing.Size(263, 26);
            this.txtCompanyAddress.TabIndex = 61;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(121, 110);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(261, 26);
            this.txtCompanyName.TabIndex = 58;
            // 
            // txtCompanyWebsite
            // 
            this.txtCompanyWebsite.Location = new System.Drawing.Point(121, 270);
            this.txtCompanyWebsite.Name = "txtCompanyWebsite";
            this.txtCompanyWebsite.Size = new System.Drawing.Size(261, 26);
            this.txtCompanyWebsite.TabIndex = 57;
            // 
            // txtCompanyFax
            // 
            this.txtCompanyFax.Location = new System.Drawing.Point(121, 238);
            this.txtCompanyFax.Name = "txtCompanyFax";
            this.txtCompanyFax.Size = new System.Drawing.Size(128, 26);
            this.txtCompanyFax.TabIndex = 56;
            // 
            // txtCompanyPhone
            // 
            this.txtCompanyPhone.Location = new System.Drawing.Point(121, 206);
            this.txtCompanyPhone.Name = "txtCompanyPhone";
            this.txtCompanyPhone.Size = new System.Drawing.Size(128, 26);
            this.txtCompanyPhone.TabIndex = 54;
            // 
            // txtCompanyID
            // 
            this.txtCompanyID.BackColor = System.Drawing.Color.LightGray;
            this.txtCompanyID.Location = new System.Drawing.Point(475, 110);
            this.txtCompanyID.Name = "txtCompanyID";
            this.txtCompanyID.ReadOnly = true;
            this.txtCompanyID.Size = new System.Drawing.Size(100, 26);
            this.txtCompanyID.TabIndex = 53;
            // 
            // lblCompanyNotes
            // 
            this.lblCompanyNotes.AutoSize = true;
            this.lblCompanyNotes.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyNotes.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblCompanyNotes.Location = new System.Drawing.Point(64, 304);
            this.lblCompanyNotes.Name = "lblCompanyNotes";
            this.lblCompanyNotes.Size = new System.Drawing.Size(52, 19);
            this.lblCompanyNotes.TabIndex = 52;
            this.lblCompanyNotes.Text = "Notes:";
            // 
            // lblCompanyWebsite
            // 
            this.lblCompanyWebsite.AutoSize = true;
            this.lblCompanyWebsite.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyWebsite.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblCompanyWebsite.Location = new System.Drawing.Point(49, 272);
            this.lblCompanyWebsite.Name = "lblCompanyWebsite";
            this.lblCompanyWebsite.Size = new System.Drawing.Size(67, 19);
            this.lblCompanyWebsite.TabIndex = 50;
            this.lblCompanyWebsite.Text = "Website:";
            // 
            // lblCompanyPhone
            // 
            this.lblCompanyPhone.AutoSize = true;
            this.lblCompanyPhone.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyPhone.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblCompanyPhone.Location = new System.Drawing.Point(65, 208);
            this.lblCompanyPhone.Name = "lblCompanyPhone";
            this.lblCompanyPhone.Size = new System.Drawing.Size(51, 19);
            this.lblCompanyPhone.TabIndex = 48;
            this.lblCompanyPhone.Text = "Phone:";
            // 
            // lblCompanyZipCode
            // 
            this.lblCompanyZipCode.AutoSize = true;
            this.lblCompanyZipCode.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyZipCode.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblCompanyZipCode.Location = new System.Drawing.Point(390, 176);
            this.lblCompanyZipCode.Name = "lblCompanyZipCode";
            this.lblCompanyZipCode.Size = new System.Drawing.Size(71, 19);
            this.lblCompanyZipCode.TabIndex = 47;
            this.lblCompanyZipCode.Text = "Zip Code:";
            // 
            // lblCompanyState
            // 
            this.lblCompanyState.AutoSize = true;
            this.lblCompanyState.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyState.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblCompanyState.Location = new System.Drawing.Point(288, 176);
            this.lblCompanyState.Name = "lblCompanyState";
            this.lblCompanyState.Size = new System.Drawing.Size(50, 19);
            this.lblCompanyState.TabIndex = 46;
            this.lblCompanyState.Text = "State:";
            // 
            // lblCompanyCity
            // 
            this.lblCompanyCity.AutoSize = true;
            this.lblCompanyCity.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyCity.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblCompanyCity.Location = new System.Drawing.Point(76, 176);
            this.lblCompanyCity.Name = "lblCompanyCity";
            this.lblCompanyCity.Size = new System.Drawing.Size(40, 19);
            this.lblCompanyCity.TabIndex = 45;
            this.lblCompanyCity.Text = "City:";
            // 
            // lblCompanyAddress
            // 
            this.lblCompanyAddress.AutoSize = true;
            this.lblCompanyAddress.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyAddress.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblCompanyAddress.Location = new System.Drawing.Point(50, 144);
            this.lblCompanyAddress.Name = "lblCompanyAddress";
            this.lblCompanyAddress.Size = new System.Drawing.Size(66, 19);
            this.lblCompanyAddress.TabIndex = 44;
            this.lblCompanyAddress.Text = "Address:";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblCompanyName.Location = new System.Drawing.Point(66, 112);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(50, 19);
            this.lblCompanyName.TabIndex = 41;
            this.lblCompanyName.Text = "Name:";
            // 
            // lblCompanyFax
            // 
            this.lblCompanyFax.AutoSize = true;
            this.lblCompanyFax.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyFax.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblCompanyFax.Location = new System.Drawing.Point(78, 240);
            this.lblCompanyFax.Name = "lblCompanyFax";
            this.lblCompanyFax.Size = new System.Drawing.Size(38, 19);
            this.lblCompanyFax.TabIndex = 40;
            this.lblCompanyFax.Text = "Fax:";
            // 
            // lblCompanyID
            // 
            this.lblCompanyID.AutoSize = true;
            this.lblCompanyID.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyID.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblCompanyID.Location = new System.Drawing.Point(388, 113);
            this.lblCompanyID.Name = "lblCompanyID";
            this.lblCompanyID.Size = new System.Drawing.Size(90, 19);
            this.lblCompanyID.TabIndex = 39;
            this.lblCompanyID.Text = "Company ID:";
            // 
            // tsbtnExit
            // 
            this.tsbtnExit.BackColor = System.Drawing.Color.Cyan;
            this.tsbtnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnExit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnExit.ForeColor = System.Drawing.Color.Red;
            this.tsbtnExit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnExit.Image")));
            this.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnExit.Name = "tsbtnExit";
            this.tsbtnExit.Size = new System.Drawing.Size(39, 24);
            this.tsbtnExit.Text = "Exit";
            // 
            // frmCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(751, 531);
            this.Controls.Add(this.cmbCompanyState);
            this.Controls.Add(this.lblCompanyInfoTitle);
            this.Controls.Add(this.txtCompanyZipCode);
            this.Controls.Add(this.txtCompanyNotes);
            this.Controls.Add(this.txtCompanyCity);
            this.Controls.Add(this.txtCompanyAddress);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.txtCompanyWebsite);
            this.Controls.Add(this.txtCompanyFax);
            this.Controls.Add(this.txtCompanyPhone);
            this.Controls.Add(this.txtCompanyID);
            this.Controls.Add(this.lblCompanyNotes);
            this.Controls.Add(this.lblCompanyWebsite);
            this.Controls.Add(this.lblCompanyPhone);
            this.Controls.Add(this.lblCompanyZipCode);
            this.Controls.Add(this.lblCompanyState);
            this.Controls.Add(this.lblCompanyCity);
            this.Controls.Add(this.lblCompanyAddress);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.lblCompanyFax);
            this.Controls.Add(this.lblCompanyID);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.bindingNavigator1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCompany";
            this.Text = "frmCompany";
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
        private System.Windows.Forms.ToolStripLabel tslblCompanyIDField;
        private System.Windows.Forms.ToolStripTextBox tstbCompanyID;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ComboBox cmbCompanyState;
        private System.Windows.Forms.Label lblCompanyInfoTitle;
        private System.Windows.Forms.TextBox txtCompanyZipCode;
        private System.Windows.Forms.TextBox txtCompanyNotes;
        private System.Windows.Forms.TextBox txtCompanyCity;
        private System.Windows.Forms.TextBox txtCompanyAddress;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtCompanyWebsite;
        private System.Windows.Forms.TextBox txtCompanyFax;
        private System.Windows.Forms.TextBox txtCompanyPhone;
        private System.Windows.Forms.TextBox txtCompanyID;
        private System.Windows.Forms.Label lblCompanyNotes;
        private System.Windows.Forms.Label lblCompanyWebsite;
        private System.Windows.Forms.Label lblCompanyPhone;
        private System.Windows.Forms.Label lblCompanyZipCode;
        private System.Windows.Forms.Label lblCompanyState;
        private System.Windows.Forms.Label lblCompanyCity;
        private System.Windows.Forms.Label lblCompanyAddress;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblCompanyFax;
        private System.Windows.Forms.Label lblCompanyID;
        private System.Windows.Forms.ToolStripButton tsbtnExit;
    }
}