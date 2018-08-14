namespace WindowsFormsApplication1
{
    partial class SearchCompanyForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchCompanyForm));
            this.btnExit = new System.Windows.Forms.Button();
            this.companyDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblCompanyTitle = new System.Windows.Forms.Label();
            this.lblSelectingCompany = new System.Windows.Forms.Label();
            this.btnDeleteCompany = new System.Windows.Forms.Button();
            this.btnUpdateModifyCompany = new System.Windows.Forms.Button();
            this.btnAddNewCompany = new System.Windows.Forms.Button();
            this.btnResetCompanyGridview = new System.Windows.Forms.Button();
            this.btnSearchCompanyCity = new System.Windows.Forms.Button();
            this.btnSearchCompanyName = new System.Windows.Forms.Button();
            this.txtCompanyCity = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lblSearchCompanyCityInstructions = new System.Windows.Forms.Label();
            this.lblSearchCompanyNameInstructions = new System.Windows.Forms.Label();
            this.grpCompanySearchResults = new System.Windows.Forms.GroupBox();
            this.chkFirstNameCom = new System.Windows.Forms.CheckBox();
            this.lblDispResuSelctCom = new System.Windows.Forms.Label();
            this.chkLastNameCom = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            this.grpCompanySearchResults.SuspendLayout();
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
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "E X I T";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // companyDataGridView
            // 
            this.companyDataGridView.AllowUserToAddRows = false;
            this.companyDataGridView.AllowUserToDeleteRows = false;
            this.companyDataGridView.AutoGenerateColumns = false;
            this.companyDataGridView.BackgroundColor = System.Drawing.Color.Pink;
            this.companyDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.companyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.companyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.CompanyName,
            this.CompanyAddress,
            this.CompanyCity,
            this.CompanyPhone});
            this.companyDataGridView.DataSource = this.companyBindingSource;
            this.companyDataGridView.Location = new System.Drawing.Point(26, 203);
            this.companyDataGridView.MultiSelect = false;
            this.companyDataGridView.Name = "companyDataGridView";
            this.companyDataGridView.ReadOnly = true;
            this.companyDataGridView.Size = new System.Drawing.Size(547, 211);
            this.companyDataGridView.TabIndex = 19;
            this.companyDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.companyDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CompanyID";
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Maroon;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTextBoxColumn1.HeaderText = "Company ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 105;
            // 
            // CompanyName
            // 
            this.CompanyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CompanyName.DataPropertyName = "CompanyName";
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Maroon;
            this.CompanyName.DefaultCellStyle = dataGridViewCellStyle12;
            this.CompanyName.HeaderText = "Name";
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.ReadOnly = true;
            this.CompanyName.Width = 66;
            // 
            // CompanyAddress
            // 
            this.CompanyAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CompanyAddress.DataPropertyName = "CompanyAddress";
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Maroon;
            this.CompanyAddress.DefaultCellStyle = dataGridViewCellStyle13;
            this.CompanyAddress.HeaderText = "Address";
            this.CompanyAddress.Name = "CompanyAddress";
            this.CompanyAddress.ReadOnly = true;
            this.CompanyAddress.Width = 83;
            // 
            // CompanyCity
            // 
            this.CompanyCity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CompanyCity.DataPropertyName = "CompanyCity";
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Maroon;
            this.CompanyCity.DefaultCellStyle = dataGridViewCellStyle14;
            this.CompanyCity.HeaderText = "City";
            this.CompanyCity.Name = "CompanyCity";
            this.CompanyCity.ReadOnly = true;
            this.CompanyCity.Width = 57;
            // 
            // CompanyPhone
            // 
            this.CompanyPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CompanyPhone.DataPropertyName = "CompanyPhone";
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Maroon;
            this.CompanyPhone.DefaultCellStyle = dataGridViewCellStyle15;
            this.CompanyPhone.HeaderText = "Phone";
            this.CompanyPhone.Name = "CompanyPhone";
            this.CompanyPhone.ReadOnly = true;
            this.CompanyPhone.Width = 68;
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(SharpERBLL.Company);
            // 
            // lblCompanyTitle
            // 
            this.lblCompanyTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblCompanyTitle.Font = new System.Drawing.Font("Goudy Old Style", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyTitle.ForeColor = System.Drawing.Color.Indigo;
            this.lblCompanyTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCompanyTitle.Location = new System.Drawing.Point(24, 12);
            this.lblCompanyTitle.Name = "lblCompanyTitle";
            this.lblCompanyTitle.Size = new System.Drawing.Size(522, 51);
            this.lblCompanyTitle.TabIndex = 21;
            this.lblCompanyTitle.Text = "Search Company Form";
            this.lblCompanyTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSelectingCompany
            // 
            this.lblSelectingCompany.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectingCompany.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSelectingCompany.Location = new System.Drawing.Point(27, 63);
            this.lblSelectingCompany.Name = "lblSelectingCompany";
            this.lblSelectingCompany.Size = new System.Drawing.Size(519, 134);
            this.lblSelectingCompany.TabIndex = 20;
            this.lblSelectingCompany.Text = resources.GetString("lblSelectingCompany.Text");
            this.lblSelectingCompany.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDeleteCompany
            // 
            this.btnDeleteCompany.BackColor = System.Drawing.Color.Goldenrod;
            this.btnDeleteCompany.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteCompany.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCompany.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnDeleteCompany.Location = new System.Drawing.Point(579, 262);
            this.btnDeleteCompany.Name = "btnDeleteCompany";
            this.btnDeleteCompany.Size = new System.Drawing.Size(154, 51);
            this.btnDeleteCompany.TabIndex = 24;
            this.btnDeleteCompany.Text = "Delete Company";
            this.btnDeleteCompany.UseVisualStyleBackColor = false;
            this.btnDeleteCompany.Click += new System.EventHandler(this.btnDeleteCompany_Click);
            // 
            // btnUpdateModifyCompany
            // 
            this.btnUpdateModifyCompany.BackColor = System.Drawing.Color.Goldenrod;
            this.btnUpdateModifyCompany.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdateModifyCompany.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateModifyCompany.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnUpdateModifyCompany.Location = new System.Drawing.Point(579, 205);
            this.btnUpdateModifyCompany.Name = "btnUpdateModifyCompany";
            this.btnUpdateModifyCompany.Size = new System.Drawing.Size(154, 51);
            this.btnUpdateModifyCompany.TabIndex = 23;
            this.btnUpdateModifyCompany.Text = "View / Modify Company";
            this.btnUpdateModifyCompany.UseVisualStyleBackColor = false;
            this.btnUpdateModifyCompany.Click += new System.EventHandler(this.btnUpdateModifyCompany_Click);
            // 
            // btnAddNewCompany
            // 
            this.btnAddNewCompany.BackColor = System.Drawing.Color.Teal;
            this.btnAddNewCompany.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNewCompany.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCompany.ForeColor = System.Drawing.Color.Yellow;
            this.btnAddNewCompany.Location = new System.Drawing.Point(579, 319);
            this.btnAddNewCompany.Name = "btnAddNewCompany";
            this.btnAddNewCompany.Size = new System.Drawing.Size(154, 51);
            this.btnAddNewCompany.TabIndex = 22;
            this.btnAddNewCompany.Text = "Add New Company";
            this.btnAddNewCompany.UseVisualStyleBackColor = false;
            this.btnAddNewCompany.Click += new System.EventHandler(this.btnAddNewCompany_Click);
            // 
            // btnResetCompanyGridview
            // 
            this.btnResetCompanyGridview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnResetCompanyGridview.Font = new System.Drawing.Font("Eras Bold ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetCompanyGridview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnResetCompanyGridview.Location = new System.Drawing.Point(293, 440);
            this.btnResetCompanyGridview.Name = "btnResetCompanyGridview";
            this.btnResetCompanyGridview.Size = new System.Drawing.Size(198, 78);
            this.btnResetCompanyGridview.TabIndex = 31;
            this.btnResetCompanyGridview.Text = "Clear Results - Show All Companies";
            this.btnResetCompanyGridview.UseVisualStyleBackColor = false;
            this.btnResetCompanyGridview.Click += new System.EventHandler(this.btnResetCompanyGridview_Click);
            // 
            // btnSearchCompanyCity
            // 
            this.btnSearchCompanyCity.Location = new System.Drawing.Point(220, 483);
            this.btnSearchCompanyCity.Name = "btnSearchCompanyCity";
            this.btnSearchCompanyCity.Size = new System.Drawing.Size(67, 29);
            this.btnSearchCompanyCity.TabIndex = 30;
            this.btnSearchCompanyCity.Text = "Search";
            this.btnSearchCompanyCity.UseVisualStyleBackColor = true;
            // 
            // btnSearchCompanyName
            // 
            this.btnSearchCompanyName.Location = new System.Drawing.Point(220, 448);
            this.btnSearchCompanyName.Name = "btnSearchCompanyName";
            this.btnSearchCompanyName.Size = new System.Drawing.Size(67, 29);
            this.btnSearchCompanyName.TabIndex = 29;
            this.btnSearchCompanyName.Text = "Search";
            this.btnSearchCompanyName.UseVisualStyleBackColor = true;
            // 
            // txtCompanyCity
            // 
            this.txtCompanyCity.Location = new System.Drawing.Point(90, 484);
            this.txtCompanyCity.Name = "txtCompanyCity";
            this.txtCompanyCity.Size = new System.Drawing.Size(123, 26);
            this.txtCompanyCity.TabIndex = 28;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(91, 450);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(123, 26);
            this.txtCompanyName.TabIndex = 27;
            // 
            // lblSearchCompanyCityInstructions
            // 
            this.lblSearchCompanyCityInstructions.AutoSize = true;
            this.lblSearchCompanyCityInstructions.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchCompanyCityInstructions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblSearchCompanyCityInstructions.Location = new System.Drawing.Point(45, 486);
            this.lblSearchCompanyCityInstructions.Name = "lblSearchCompanyCityInstructions";
            this.lblSearchCompanyCityInstructions.Size = new System.Drawing.Size(39, 20);
            this.lblSearchCompanyCityInstructions.TabIndex = 26;
            this.lblSearchCompanyCityInstructions.Text = "City:";
            // 
            // lblSearchCompanyNameInstructions
            // 
            this.lblSearchCompanyNameInstructions.AutoSize = true;
            this.lblSearchCompanyNameInstructions.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchCompanyNameInstructions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblSearchCompanyNameInstructions.Location = new System.Drawing.Point(30, 451);
            this.lblSearchCompanyNameInstructions.Name = "lblSearchCompanyNameInstructions";
            this.lblSearchCompanyNameInstructions.Size = new System.Drawing.Size(54, 20);
            this.lblSearchCompanyNameInstructions.TabIndex = 25;
            this.lblSearchCompanyNameInstructions.Text = "Name:";
            // 
            // grpCompanySearchResults
            // 
            this.grpCompanySearchResults.BackColor = System.Drawing.Color.Silver;
            this.grpCompanySearchResults.Controls.Add(this.chkFirstNameCom);
            this.grpCompanySearchResults.Controls.Add(this.lblDispResuSelctCom);
            this.grpCompanySearchResults.Controls.Add(this.chkLastNameCom);
            this.grpCompanySearchResults.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCompanySearchResults.Location = new System.Drawing.Point(579, 440);
            this.grpCompanySearchResults.Name = "grpCompanySearchResults";
            this.grpCompanySearchResults.Size = new System.Drawing.Size(143, 115);
            this.grpCompanySearchResults.TabIndex = 32;
            this.grpCompanySearchResults.TabStop = false;
            this.grpCompanySearchResults.Text = "Display Results";
            // 
            // chkFirstNameCom
            // 
            this.chkFirstNameCom.AutoSize = true;
            this.chkFirstNameCom.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFirstNameCom.Location = new System.Drawing.Point(10, 57);
            this.chkFirstNameCom.Name = "chkFirstNameCom";
            this.chkFirstNameCom.Size = new System.Drawing.Size(93, 21);
            this.chkFirstNameCom.TabIndex = 4;
            this.chkFirstNameCom.Text = "First Name";
            this.chkFirstNameCom.UseVisualStyleBackColor = true;
            // 
            // lblDispResuSelctCom
            // 
            this.lblDispResuSelctCom.AutoSize = true;
            this.lblDispResuSelctCom.Font = new System.Drawing.Font("Eras Bold ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDispResuSelctCom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblDispResuSelctCom.Location = new System.Drawing.Point(6, 34);
            this.lblDispResuSelctCom.Name = "lblDispResuSelctCom";
            this.lblDispResuSelctCom.Size = new System.Drawing.Size(83, 19);
            this.lblDispResuSelctCom.TabIndex = 3;
            this.lblDispResuSelctCom.Text = "SORT BY:";
            // 
            // chkLastNameCom
            // 
            this.chkLastNameCom.AutoSize = true;
            this.chkLastNameCom.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLastNameCom.Location = new System.Drawing.Point(10, 79);
            this.chkLastNameCom.Name = "chkLastNameCom";
            this.chkLastNameCom.Size = new System.Drawing.Size(91, 21);
            this.chkLastNameCom.TabIndex = 1;
            this.chkLastNameCom.Text = "Last Name";
            this.chkLastNameCom.UseVisualStyleBackColor = true;
            // 
            // SearchCompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(745, 606);
            this.ControlBox = false;
            this.Controls.Add(this.grpCompanySearchResults);
            this.Controls.Add(this.btnResetCompanyGridview);
            this.Controls.Add(this.btnSearchCompanyCity);
            this.Controls.Add(this.btnSearchCompanyName);
            this.Controls.Add(this.txtCompanyCity);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.lblSearchCompanyCityInstructions);
            this.Controls.Add(this.lblSearchCompanyNameInstructions);
            this.Controls.Add(this.btnDeleteCompany);
            this.Controls.Add(this.btnUpdateModifyCompany);
            this.Controls.Add(this.btnAddNewCompany);
            this.Controls.Add(this.lblCompanyTitle);
            this.Controls.Add(this.lblSelectingCompany);
            this.Controls.Add(this.companyDataGridView);
            this.Controls.Add(this.btnExit);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SearchCompanyForm";
            this.Text = "Search Company Form";
            this.Load += new System.EventHandler(this.SearchCompanyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companyDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            this.grpCompanySearchResults.ResumeLayout(false);
            this.grpCompanySearchResults.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.DataGridView companyDataGridView;
        private System.Windows.Forms.Label lblCompanyTitle;
        private System.Windows.Forms.Label lblSelectingCompany;
        private System.Windows.Forms.Button btnDeleteCompany;
        private System.Windows.Forms.Button btnUpdateModifyCompany;
        private System.Windows.Forms.Button btnAddNewCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private new System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyPhone;
        private System.Windows.Forms.Button btnResetCompanyGridview;
        private System.Windows.Forms.Button btnSearchCompanyCity;
        private System.Windows.Forms.Button btnSearchCompanyName;
        private System.Windows.Forms.TextBox txtCompanyCity;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label lblSearchCompanyCityInstructions;
        private System.Windows.Forms.Label lblSearchCompanyNameInstructions;
        private System.Windows.Forms.GroupBox grpCompanySearchResults;
        private System.Windows.Forms.CheckBox chkFirstNameCom;
        private System.Windows.Forms.Label lblDispResuSelctCom;
        private System.Windows.Forms.CheckBox chkLastNameCom;
    }
}