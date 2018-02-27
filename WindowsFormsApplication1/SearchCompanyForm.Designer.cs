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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchCompanyForm));
            this.btnViewCompanyInfo = new System.Windows.Forms.Button();
            this.btnDeleteCompany = new System.Windows.Forms.Button();
            this.btnUpdateModifyCompany = new System.Windows.Forms.Button();
            this.btnAddNewCompany = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyDataGridView = new System.Windows.Forms.DataGridView();
            this.lblCompanyTitle = new System.Windows.Forms.Label();
            this.lblSelectingCompany = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnViewCompanyInfo
            // 
            this.btnViewCompanyInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnViewCompanyInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnViewCompanyInfo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCompanyInfo.ForeColor = System.Drawing.Color.Maroon;
            this.btnViewCompanyInfo.Location = new System.Drawing.Point(597, 321);
            this.btnViewCompanyInfo.Name = "btnViewCompanyInfo";
            this.btnViewCompanyInfo.Size = new System.Drawing.Size(128, 41);
            this.btnViewCompanyInfo.TabIndex = 18;
            this.btnViewCompanyInfo.Text = "View Company Info";
            this.btnViewCompanyInfo.UseVisualStyleBackColor = false;
            // 
            // btnDeleteCompany
            // 
            this.btnDeleteCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDeleteCompany.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteCompany.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCompany.ForeColor = System.Drawing.Color.Maroon;
            this.btnDeleteCompany.Location = new System.Drawing.Point(597, 389);
            this.btnDeleteCompany.Name = "btnDeleteCompany";
            this.btnDeleteCompany.Size = new System.Drawing.Size(128, 41);
            this.btnDeleteCompany.TabIndex = 17;
            this.btnDeleteCompany.Text = "Delete Company";
            this.btnDeleteCompany.UseVisualStyleBackColor = false;
            // 
            // btnUpdateModifyCompany
            // 
            this.btnUpdateModifyCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUpdateModifyCompany.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdateModifyCompany.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateModifyCompany.ForeColor = System.Drawing.Color.Maroon;
            this.btnUpdateModifyCompany.Location = new System.Drawing.Point(597, 253);
            this.btnUpdateModifyCompany.Name = "btnUpdateModifyCompany";
            this.btnUpdateModifyCompany.Size = new System.Drawing.Size(128, 41);
            this.btnUpdateModifyCompany.TabIndex = 16;
            this.btnUpdateModifyCompany.Text = "Update / Modify Company";
            this.btnUpdateModifyCompany.UseVisualStyleBackColor = false;
            this.btnUpdateModifyCompany.Click += new System.EventHandler(this.btnUpdateModifyCompany_Click);
            // 
            // btnAddNewCompany
            // 
            this.btnAddNewCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAddNewCompany.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNewCompany.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCompany.ForeColor = System.Drawing.Color.Maroon;
            this.btnAddNewCompany.Location = new System.Drawing.Point(597, 185);
            this.btnAddNewCompany.Name = "btnAddNewCompany";
            this.btnAddNewCompany.Size = new System.Drawing.Size(128, 41);
            this.btnAddNewCompany.TabIndex = 15;
            this.btnAddNewCompany.Text = "Add New Company";
            this.btnAddNewCompany.UseVisualStyleBackColor = false;
            this.btnAddNewCompany.Click += new System.EventHandler(this.btnAddNewCompany_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Yellow;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.Font = new System.Drawing.Font("Wide Latin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.DarkRed;
            this.btnExit.Location = new System.Drawing.Point(579, 18);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(154, 45);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "E X I T";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(SharpERBLL.Company);
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
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn7});
            this.companyDataGridView.DataSource = this.companyBindingSource;
            this.companyDataGridView.Location = new System.Drawing.Point(26, 203);
            this.companyDataGridView.MultiSelect = false;
            this.companyDataGridView.Name = "companyDataGridView";
            this.companyDataGridView.ReadOnly = true;
            this.companyDataGridView.Size = new System.Drawing.Size(547, 211);
            this.companyDataGridView.TabIndex = 19;
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
            this.lblCompanyTitle.Text = "Get / Find Company Form";
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CompanyID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Company ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 105;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CompanyName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Company Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CompanyPhone";
            this.dataGridViewTextBoxColumn7.HeaderText = "Company Phone";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // SearchCompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(745, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lblCompanyTitle);
            this.Controls.Add(this.lblSelectingCompany);
            this.Controls.Add(this.companyDataGridView);
            this.Controls.Add(this.btnViewCompanyInfo);
            this.Controls.Add(this.btnDeleteCompany);
            this.Controls.Add(this.btnUpdateModifyCompany);
            this.Controls.Add(this.btnAddNewCompany);
            this.Controls.Add(this.btnExit);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SearchCompanyForm";
            this.Text = "Search Company Form";
            this.Load += new System.EventHandler(this.SearchCompanyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewCompanyInfo;
        private System.Windows.Forms.Button btnDeleteCompany;
        private System.Windows.Forms.Button btnUpdateModifyCompany;
        private System.Windows.Forms.Button btnAddNewCompany;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.DataGridView companyDataGridView;
        private System.Windows.Forms.Label lblCompanyTitle;
        private System.Windows.Forms.Label lblSelectingCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}