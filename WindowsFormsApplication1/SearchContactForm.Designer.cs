namespace WindowsFormsApplication1
{
    partial class SearchContactForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchContactForm));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddNewContact = new System.Windows.Forms.Button();
            this.btnUpdateModifyContact = new System.Windows.Forms.Button();
            this.btnDeleteContact = new System.Windows.Forms.Button();
            this.contactDataGridView = new System.Windows.Forms.DataGridView();
            this.ContactID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MobileNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblSelectingContact = new System.Windows.Forms.Label();
            this.lblContactTitle = new System.Windows.Forms.Label();
            this.lblSearchFirstNameInst = new System.Windows.Forms.Label();
            this.lblSearchLastNameInst = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btnSearchFirstName = new System.Windows.Forms.Button();
            this.btnSearchLastName = new System.Windows.Forms.Button();
            this.btnResetContactGridview = new System.Windows.Forms.Button();
            this.grpContactDisplayResults = new System.Windows.Forms.GroupBox();
            this.chkLastNameCon = new System.Windows.Forms.CheckBox();
            this.lblDispResuSelctCon = new System.Windows.Forms.Label();
            this.chkFirstNameCon = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.contactDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).BeginInit();
            this.grpContactDisplayResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Yellow;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.Font = new System.Drawing.Font("Wide Latin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(579, 18);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(154, 45);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E X I T";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddNewContact
            // 
            this.btnAddNewContact.BackColor = System.Drawing.Color.Teal;
            this.btnAddNewContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNewContact.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewContact.ForeColor = System.Drawing.Color.Yellow;
            this.btnAddNewContact.Location = new System.Drawing.Point(579, 285);
            this.btnAddNewContact.Name = "btnAddNewContact";
            this.btnAddNewContact.Size = new System.Drawing.Size(154, 51);
            this.btnAddNewContact.TabIndex = 10;
            this.btnAddNewContact.Text = "Add New Contact";
            this.btnAddNewContact.UseVisualStyleBackColor = false;
            this.btnAddNewContact.Click += new System.EventHandler(this.btnAddNewContact_Click);
            // 
            // btnUpdateModifyContact
            // 
            this.btnUpdateModifyContact.BackColor = System.Drawing.Color.Goldenrod;
            this.btnUpdateModifyContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdateModifyContact.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateModifyContact.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnUpdateModifyContact.Location = new System.Drawing.Point(579, 220);
            this.btnUpdateModifyContact.Name = "btnUpdateModifyContact";
            this.btnUpdateModifyContact.Size = new System.Drawing.Size(154, 51);
            this.btnUpdateModifyContact.TabIndex = 11;
            this.btnUpdateModifyContact.Text = "View / Modify Contact";
            this.btnUpdateModifyContact.UseVisualStyleBackColor = false;
            this.btnUpdateModifyContact.Click += new System.EventHandler(this.btnUpdateModifyContact_Click);
            // 
            // btnDeleteContact
            // 
            this.btnDeleteContact.BackColor = System.Drawing.Color.Goldenrod;
            this.btnDeleteContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteContact.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteContact.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnDeleteContact.Location = new System.Drawing.Point(579, 349);
            this.btnDeleteContact.Name = "btnDeleteContact";
            this.btnDeleteContact.Size = new System.Drawing.Size(154, 51);
            this.btnDeleteContact.TabIndex = 12;
            this.btnDeleteContact.Text = "Delete Contact";
            this.btnDeleteContact.UseVisualStyleBackColor = false;
            this.btnDeleteContact.Click += new System.EventHandler(this.btnDeleteContact_Click);
            // 
            // contactDataGridView
            // 
            this.contactDataGridView.AllowUserToAddRows = false;
            this.contactDataGridView.AllowUserToDeleteRows = false;
            this.contactDataGridView.AutoGenerateColumns = false;
            this.contactDataGridView.BackgroundColor = System.Drawing.Color.Pink;
            this.contactDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.contactDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contactDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ContactID,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn10,
            this.MobileNumber});
            this.contactDataGridView.DataSource = this.contactBindingSource;
            this.contactDataGridView.Location = new System.Drawing.Point(26, 203);
            this.contactDataGridView.MultiSelect = false;
            this.contactDataGridView.Name = "contactDataGridView";
            this.contactDataGridView.ReadOnly = true;
            this.contactDataGridView.Size = new System.Drawing.Size(547, 211);
            this.contactDataGridView.TabIndex = 12;
            this.contactDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.contactDataGridView_CellContentClick);
            // 
            // ContactID
            // 
            this.ContactID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ContactID.DataPropertyName = "ContactID";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Maroon;
            this.ContactID.DefaultCellStyle = dataGridViewCellStyle6;
            this.ContactID.HeaderText = "ContactID";
            this.ContactID.Name = "ContactID";
            this.ContactID.ReadOnly = true;
            this.ContactID.Width = 95;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ContactFirstName";
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Maroon;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn2.HeaderText = "First Name    ";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 115;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ContactLastName";
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Maroon;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn3.HeaderText = "Last Name     ";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 115;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ContactPhone";
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Maroon;
            this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn10.HeaderText = "Phone Number";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 119;
            // 
            // MobileNumber
            // 
            this.MobileNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MobileNumber.DataPropertyName = "ContactMobile";
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Maroon;
            this.MobileNumber.DefaultCellStyle = dataGridViewCellStyle10;
            this.MobileNumber.HeaderText = "Mobile Number";
            this.MobileNumber.Name = "MobileNumber";
            this.MobileNumber.ReadOnly = true;
            this.MobileNumber.Width = 125;
            // 
            // contactBindingSource
            // 
            this.contactBindingSource.DataSource = typeof(SharpERBLL.Contact);
            // 
            // lblSelectingContact
            // 
            this.lblSelectingContact.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectingContact.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSelectingContact.Location = new System.Drawing.Point(27, 63);
            this.lblSelectingContact.Name = "lblSelectingContact";
            this.lblSelectingContact.Size = new System.Drawing.Size(519, 134);
            this.lblSelectingContact.TabIndex = 14;
            this.lblSelectingContact.Text = resources.GetString("lblSelectingContact.Text");
            this.lblSelectingContact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblContactTitle
            // 
            this.lblContactTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblContactTitle.Font = new System.Drawing.Font("Goudy Old Style", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactTitle.ForeColor = System.Drawing.Color.Indigo;
            this.lblContactTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblContactTitle.Location = new System.Drawing.Point(24, 12);
            this.lblContactTitle.Name = "lblContactTitle";
            this.lblContactTitle.Size = new System.Drawing.Size(522, 51);
            this.lblContactTitle.TabIndex = 15;
            this.lblContactTitle.Text = "Search Contact Form";
            this.lblContactTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSearchFirstNameInst
            // 
            this.lblSearchFirstNameInst.AutoSize = true;
            this.lblSearchFirstNameInst.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchFirstNameInst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblSearchFirstNameInst.Location = new System.Drawing.Point(26, 431);
            this.lblSearchFirstNameInst.Name = "lblSearchFirstNameInst";
            this.lblSearchFirstNameInst.Size = new System.Drawing.Size(87, 20);
            this.lblSearchFirstNameInst.TabIndex = 16;
            this.lblSearchFirstNameInst.Text = "First Name:";
            // 
            // lblSearchLastNameInst
            // 
            this.lblSearchLastNameInst.AutoSize = true;
            this.lblSearchLastNameInst.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchLastNameInst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblSearchLastNameInst.Location = new System.Drawing.Point(26, 466);
            this.lblSearchLastNameInst.Name = "lblSearchLastNameInst";
            this.lblSearchLastNameInst.Size = new System.Drawing.Size(84, 20);
            this.lblSearchLastNameInst.TabIndex = 17;
            this.lblSearchLastNameInst.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(115, 430);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(123, 26);
            this.txtFirstName.TabIndex = 18;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(114, 464);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(123, 26);
            this.txtLastName.TabIndex = 19;
            // 
            // btnSearchFirstName
            // 
            this.btnSearchFirstName.Location = new System.Drawing.Point(244, 428);
            this.btnSearchFirstName.Name = "btnSearchFirstName";
            this.btnSearchFirstName.Size = new System.Drawing.Size(67, 29);
            this.btnSearchFirstName.TabIndex = 20;
            this.btnSearchFirstName.Text = "Search";
            this.btnSearchFirstName.UseVisualStyleBackColor = true;
            // 
            // btnSearchLastName
            // 
            this.btnSearchLastName.Location = new System.Drawing.Point(244, 463);
            this.btnSearchLastName.Name = "btnSearchLastName";
            this.btnSearchLastName.Size = new System.Drawing.Size(67, 29);
            this.btnSearchLastName.TabIndex = 21;
            this.btnSearchLastName.Text = "Search";
            this.btnSearchLastName.UseVisualStyleBackColor = true;
            // 
            // btnResetContactGridview
            // 
            this.btnResetContactGridview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnResetContactGridview.Font = new System.Drawing.Font("Eras Bold ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetContactGridview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnResetContactGridview.Location = new System.Drawing.Point(317, 428);
            this.btnResetContactGridview.Name = "btnResetContactGridview";
            this.btnResetContactGridview.Size = new System.Drawing.Size(174, 64);
            this.btnResetContactGridview.TabIndex = 22;
            this.btnResetContactGridview.Text = "Clear Results - Show All Contacts";
            this.btnResetContactGridview.UseVisualStyleBackColor = false;
            this.btnResetContactGridview.Click += new System.EventHandler(this.btnResetGridview_Click);
            // 
            // grpContactDisplayResults
            // 
            this.grpContactDisplayResults.BackColor = System.Drawing.Color.Silver;
            this.grpContactDisplayResults.Controls.Add(this.chkFirstNameCon);
            this.grpContactDisplayResults.Controls.Add(this.lblDispResuSelctCon);
            this.grpContactDisplayResults.Controls.Add(this.chkLastNameCon);
            this.grpContactDisplayResults.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpContactDisplayResults.Location = new System.Drawing.Point(579, 431);
            this.grpContactDisplayResults.Name = "grpContactDisplayResults";
            this.grpContactDisplayResults.Size = new System.Drawing.Size(143, 115);
            this.grpContactDisplayResults.TabIndex = 23;
            this.grpContactDisplayResults.TabStop = false;
            this.grpContactDisplayResults.Text = "Display Results";
            // 
            // chkLastNameCon
            // 
            this.chkLastNameCon.AutoSize = true;
            this.chkLastNameCon.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLastNameCon.Location = new System.Drawing.Point(10, 79);
            this.chkLastNameCon.Name = "chkLastNameCon";
            this.chkLastNameCon.Size = new System.Drawing.Size(91, 21);
            this.chkLastNameCon.TabIndex = 1;
            this.chkLastNameCon.Text = "Last Name";
            this.chkLastNameCon.UseVisualStyleBackColor = true;
            // 
            // lblDispResuSelctCon
            // 
            this.lblDispResuSelctCon.AutoSize = true;
            this.lblDispResuSelctCon.Font = new System.Drawing.Font("Eras Bold ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDispResuSelctCon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblDispResuSelctCon.Location = new System.Drawing.Point(6, 34);
            this.lblDispResuSelctCon.Name = "lblDispResuSelctCon";
            this.lblDispResuSelctCon.Size = new System.Drawing.Size(83, 19);
            this.lblDispResuSelctCon.TabIndex = 3;
            this.lblDispResuSelctCon.Text = "SORT BY:";
            // 
            // chkFirstNameCon
            // 
            this.chkFirstNameCon.AutoSize = true;
            this.chkFirstNameCon.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFirstNameCon.Location = new System.Drawing.Point(10, 57);
            this.chkFirstNameCon.Name = "chkFirstNameCon";
            this.chkFirstNameCon.Size = new System.Drawing.Size(93, 21);
            this.chkFirstNameCon.TabIndex = 4;
            this.chkFirstNameCon.Text = "First Name";
            this.chkFirstNameCon.UseVisualStyleBackColor = true;
            // 
            // SearchContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(745, 604);
            this.ControlBox = false;
            this.Controls.Add(this.grpContactDisplayResults);
            this.Controls.Add(this.btnResetContactGridview);
            this.Controls.Add(this.btnSearchLastName);
            this.Controls.Add(this.btnSearchFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblSearchLastNameInst);
            this.Controls.Add(this.lblSearchFirstNameInst);
            this.Controls.Add(this.lblContactTitle);
            this.Controls.Add(this.lblSelectingContact);
            this.Controls.Add(this.contactDataGridView);
            this.Controls.Add(this.btnDeleteContact);
            this.Controls.Add(this.btnUpdateModifyContact);
            this.Controls.Add(this.btnAddNewContact);
            this.Controls.Add(this.btnExit);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SearchContactForm";
            this.Text = "Search Contact Form";
            this.Load += new System.EventHandler(this.SearchContactForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contactDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).EndInit();
            this.grpContactDisplayResults.ResumeLayout(false);
            this.grpContactDisplayResults.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.BindingSource contactBindingSource;
        private System.Windows.Forms.Button btnAddNewContact;
        private System.Windows.Forms.Button btnUpdateModifyContact;
        private System.Windows.Forms.Button btnDeleteContact;
        private System.Windows.Forms.DataGridView contactDataGridView;
        private System.Windows.Forms.Label lblSelectingContact;
        private System.Windows.Forms.Label lblContactTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn MobileNumber;
        private System.Windows.Forms.Label lblSearchFirstNameInst;
        private System.Windows.Forms.Label lblSearchLastNameInst;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnSearchFirstName;
        private System.Windows.Forms.Button btnSearchLastName;
        private System.Windows.Forms.Button btnResetContactGridview;
        private System.Windows.Forms.GroupBox grpContactDisplayResults;
        private System.Windows.Forms.CheckBox chkFirstNameCon;
        private System.Windows.Forms.Label lblDispResuSelctCon;
        private System.Windows.Forms.CheckBox chkLastNameCon;
    }
}