namespace WindowsFormsApplication1
{
    partial class SearchJobForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchJobForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblJobTitle = new System.Windows.Forms.Label();
            this.lblSelectingJob = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdateModifyJob = new System.Windows.Forms.Button();
            this.btnDeleteJob = new System.Windows.Forms.Button();
            this.btnAddNewJob = new System.Windows.Forms.Button();
            this.jobDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.jobDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblJobTitle.Font = new System.Drawing.Font("Goudy Old Style", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobTitle.ForeColor = System.Drawing.Color.Indigo;
            this.lblJobTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblJobTitle.Location = new System.Drawing.Point(24, 12);
            this.lblJobTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(522, 51);
            this.lblJobTitle.TabIndex = 22;
            this.lblJobTitle.Text = "Search Job Form";
            this.lblJobTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSelectingJob
            // 
            this.lblSelectingJob.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectingJob.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSelectingJob.Location = new System.Drawing.Point(27, 63);
            this.lblSelectingJob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectingJob.Name = "lblSelectingJob";
            this.lblSelectingJob.Size = new System.Drawing.Size(519, 134);
            this.lblSelectingJob.TabIndex = 23;
            this.lblSelectingJob.Text = resources.GetString("lblSelectingJob.Text");
            this.lblSelectingJob.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(154, 51);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "E X I T";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdateModifyJob
            // 
            this.btnUpdateModifyJob.BackColor = System.Drawing.Color.Goldenrod;
            this.btnUpdateModifyJob.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdateModifyJob.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateModifyJob.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnUpdateModifyJob.Location = new System.Drawing.Point(579, 205);
            this.btnUpdateModifyJob.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateModifyJob.Name = "btnUpdateModifyJob";
            this.btnUpdateModifyJob.Size = new System.Drawing.Size(154, 51);
            this.btnUpdateModifyJob.TabIndex = 25;
            this.btnUpdateModifyJob.Text = "View / Modify Job";
            this.btnUpdateModifyJob.UseVisualStyleBackColor = false;
            this.btnUpdateModifyJob.Click += new System.EventHandler(this.btnUpdateModifyJob_Click);
            // 
            // btnDeleteJob
            // 
            this.btnDeleteJob.BackColor = System.Drawing.Color.Goldenrod;
            this.btnDeleteJob.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteJob.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteJob.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnDeleteJob.Location = new System.Drawing.Point(579, 262);
            this.btnDeleteJob.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteJob.Name = "btnDeleteJob";
            this.btnDeleteJob.Size = new System.Drawing.Size(154, 51);
            this.btnDeleteJob.TabIndex = 27;
            this.btnDeleteJob.Text = "Delete Job";
            this.btnDeleteJob.UseVisualStyleBackColor = false;
            this.btnDeleteJob.Click += new System.EventHandler(this.btnDeleteJob_Click);
            // 
            // btnAddNewJob
            // 
            this.btnAddNewJob.BackColor = System.Drawing.Color.Teal;
            this.btnAddNewJob.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNewJob.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewJob.ForeColor = System.Drawing.Color.Yellow;
            this.btnAddNewJob.Location = new System.Drawing.Point(579, 319);
            this.btnAddNewJob.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewJob.Name = "btnAddNewJob";
            this.btnAddNewJob.Size = new System.Drawing.Size(154, 51);
            this.btnAddNewJob.TabIndex = 28;
            this.btnAddNewJob.Text = "Add New Job";
            this.btnAddNewJob.UseVisualStyleBackColor = false;
            this.btnAddNewJob.Click += new System.EventHandler(this.btnAddNewJob_Click);
            // 
            // jobDataGridView
            // 
            this.jobDataGridView.AllowUserToAddRows = false;
            this.jobDataGridView.AllowUserToDeleteRows = false;
            this.jobDataGridView.AutoGenerateColumns = false;
            this.jobDataGridView.BackgroundColor = System.Drawing.Color.Pink;
            this.jobDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.jobDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jobDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2});
            this.jobDataGridView.DataSource = this.jobBindingSource;
            this.jobDataGridView.Location = new System.Drawing.Point(26, 203);
            this.jobDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.jobDataGridView.MultiSelect = false;
            this.jobDataGridView.Name = "jobDataGridView";
            this.jobDataGridView.ReadOnly = true;
            this.jobDataGridView.Size = new System.Drawing.Size(547, 211);
            this.jobDataGridView.TabIndex = 29;
            this.jobDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.jobDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "JobID";
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Maroon;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTextBoxColumn1.HeaderText = "Job ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 77;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "JobApplied";
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Maroon;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTextBoxColumn3.HeaderText = "Job Applied";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 107;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "JobPosition";
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Maroon;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewTextBoxColumn2.HeaderText = "Job Position";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // jobBindingSource
            // 
            this.jobBindingSource.DataSource = typeof(SharpERBLL.Job);
            // 
            // SearchJobForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(745, 450);
            this.ControlBox = false;
            this.Controls.Add(this.jobDataGridView);
            this.Controls.Add(this.btnAddNewJob);
            this.Controls.Add(this.btnDeleteJob);
            this.Controls.Add(this.btnUpdateModifyJob);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblSelectingJob);
            this.Controls.Add(this.lblJobTitle);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SearchJobForm";
            this.Text = "Search Job Form";
            this.Load += new System.EventHandler(this.SearchJobForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jobDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblJobTitle;
        private System.Windows.Forms.Label lblSelectingJob;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpdateModifyJob;
        private System.Windows.Forms.Button btnDeleteJob;
        private System.Windows.Forms.Button btnAddNewJob;
        private System.Windows.Forms.DataGridView jobDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        public System.Windows.Forms.BindingSource jobBindingSource;
    }
}