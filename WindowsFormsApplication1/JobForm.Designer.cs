namespace WindowsFormsApplication1
{
    partial class JobForm
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
            System.Windows.Forms.Label jobAppliedLabel;
            System.Windows.Forms.Label jobCompanyNameLabel;
            System.Windows.Forms.Label jobIDLabel;
            System.Windows.Forms.Label jobNotesLabel;
            System.Windows.Forms.Label jobPayLabel;
            System.Windows.Forms.Label jobPositionLabel;
            System.Windows.Forms.Label jobCompanyIDLabel;
            System.Windows.Forms.Label jobContactIDLabel;
            this.lblJobInfoTitle = new System.Windows.Forms.Label();
            this.jobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobAppliedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.jobIDTextBox = new System.Windows.Forms.TextBox();
            this.jobNotesTextBox = new System.Windows.Forms.TextBox();
            this.jobPositionTextBox = new System.Windows.Forms.TextBox();
            this.lblSalaryPerYear = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyNameComboBox = new System.Windows.Forms.ComboBox();
            this.contactFirstNameComboBox = new System.Windows.Forms.ComboBox();
            this.contactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.JobContactFirstNameLabel = new System.Windows.Forms.Label();
            this.activityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobCompanyIDTextBox = new System.Windows.Forms.TextBox();
            this.jobContactIDTextBox = new System.Windows.Forms.TextBox();
            this.jobPayTextBox = new System.Windows.Forms.TextBox();
            jobAppliedLabel = new System.Windows.Forms.Label();
            jobCompanyNameLabel = new System.Windows.Forms.Label();
            jobIDLabel = new System.Windows.Forms.Label();
            jobNotesLabel = new System.Windows.Forms.Label();
            jobPayLabel = new System.Windows.Forms.Label();
            jobPositionLabel = new System.Windows.Forms.Label();
            jobCompanyIDLabel = new System.Windows.Forms.Label();
            jobContactIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // jobAppliedLabel
            // 
            jobAppliedLabel.AutoSize = true;
            jobAppliedLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            jobAppliedLabel.ForeColor = System.Drawing.Color.DarkBlue;
            jobAppliedLabel.Location = new System.Drawing.Point(73, 140);
            jobAppliedLabel.Name = "jobAppliedLabel";
            jobAppliedLabel.Size = new System.Drawing.Size(82, 19);
            jobAppliedLabel.TabIndex = 40;
            jobAppliedLabel.Text = "Applied on:";
            // 
            // jobCompanyNameLabel
            // 
            jobCompanyNameLabel.AutoSize = true;
            jobCompanyNameLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            jobCompanyNameLabel.ForeColor = System.Drawing.Color.DarkBlue;
            jobCompanyNameLabel.Location = new System.Drawing.Point(43, 261);
            jobCompanyNameLabel.Name = "jobCompanyNameLabel";
            jobCompanyNameLabel.Size = new System.Drawing.Size(109, 19);
            jobCompanyNameLabel.TabIndex = 42;
            jobCompanyNameLabel.Text = "Company Name:";
            // 
            // jobIDLabel
            // 
            jobIDLabel.AutoSize = true;
            jobIDLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            jobIDLabel.ForeColor = System.Drawing.Color.DarkBlue;
            jobIDLabel.Location = new System.Drawing.Point(430, 108);
            jobIDLabel.Name = "jobIDLabel";
            jobIDLabel.Size = new System.Drawing.Size(61, 19);
            jobIDLabel.TabIndex = 46;
            jobIDLabel.Text = "Job ID:";
            // 
            // jobNotesLabel
            // 
            jobNotesLabel.AutoSize = true;
            jobNotesLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            jobNotesLabel.ForeColor = System.Drawing.Color.DarkBlue;
            jobNotesLabel.Location = new System.Drawing.Point(100, 358);
            jobNotesLabel.Name = "jobNotesLabel";
            jobNotesLabel.Size = new System.Drawing.Size(52, 19);
            jobNotesLabel.TabIndex = 48;
            jobNotesLabel.Text = "Notes:";
            // 
            // jobPayLabel
            // 
            jobPayLabel.AutoSize = true;
            jobPayLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            jobPayLabel.ForeColor = System.Drawing.Color.DarkBlue;
            jobPayLabel.Location = new System.Drawing.Point(64, 200);
            jobPayLabel.Name = "jobPayLabel";
            jobPayLabel.Size = new System.Drawing.Size(91, 19);
            jobPayLabel.TabIndex = 50;
            jobPayLabel.Text = "Pay offered:";
            // 
            // jobPositionLabel
            // 
            jobPositionLabel.AutoSize = true;
            jobPositionLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            jobPositionLabel.ForeColor = System.Drawing.Color.DarkBlue;
            jobPositionLabel.Location = new System.Drawing.Point(92, 108);
            jobPositionLabel.Name = "jobPositionLabel";
            jobPositionLabel.Size = new System.Drawing.Size(63, 19);
            jobPositionLabel.TabIndex = 52;
            jobPositionLabel.Text = "Position:";
            // 
            // jobCompanyIDLabel
            // 
            jobCompanyIDLabel.AutoSize = true;
            jobCompanyIDLabel.Location = new System.Drawing.Point(434, 262);
            jobCompanyIDLabel.Name = "jobCompanyIDLabel";
            jobCompanyIDLabel.Size = new System.Drawing.Size(112, 18);
            jobCompanyIDLabel.TabIndex = 67;
            jobCompanyIDLabel.Text = "Job Company ID:";
            // 
            // jobContactIDLabel
            // 
            jobContactIDLabel.AutoSize = true;
            jobContactIDLabel.Location = new System.Drawing.Point(440, 293);
            jobContactIDLabel.Name = "jobContactIDLabel";
            jobContactIDLabel.Size = new System.Drawing.Size(106, 18);
            jobContactIDLabel.TabIndex = 68;
            jobContactIDLabel.Text = "Job Contact ID:";
            // 
            // lblJobInfoTitle
            // 
            this.lblJobInfoTitle.AutoSize = true;
            this.lblJobInfoTitle.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobInfoTitle.ForeColor = System.Drawing.Color.Crimson;
            this.lblJobInfoTitle.Location = new System.Drawing.Point(1, 50);
            this.lblJobInfoTitle.Name = "lblJobInfoTitle";
            this.lblJobInfoTitle.Size = new System.Drawing.Size(220, 43);
            this.lblJobInfoTitle.TabIndex = 39;
            this.lblJobInfoTitle.Text = "Job Information";
            // 
            // jobBindingSource
            // 
            this.jobBindingSource.DataSource = typeof(SharpERBLL.Job);
            // 
            // jobAppliedDateTimePicker
            // 
            this.jobAppliedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.jobBindingSource, "JobApplied", true));
            this.jobAppliedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.jobAppliedDateTimePicker.Location = new System.Drawing.Point(161, 137);
            this.jobAppliedDateTimePicker.Name = "jobAppliedDateTimePicker";
            this.jobAppliedDateTimePicker.Size = new System.Drawing.Size(117, 26);
            this.jobAppliedDateTimePicker.TabIndex = 1;
            // 
            // jobIDTextBox
            // 
            this.jobIDTextBox.BackColor = System.Drawing.Color.LightGray;
            this.jobIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobBindingSource, "JobID", true));
            this.jobIDTextBox.Location = new System.Drawing.Point(497, 105);
            this.jobIDTextBox.Name = "jobIDTextBox";
            this.jobIDTextBox.ReadOnly = true;
            this.jobIDTextBox.Size = new System.Drawing.Size(117, 26);
            this.jobIDTextBox.TabIndex = 9;
            // 
            // jobNotesTextBox
            // 
            this.jobNotesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobBindingSource, "JobNotes", true));
            this.jobNotesTextBox.Location = new System.Drawing.Point(162, 356);
            this.jobNotesTextBox.Multiline = true;
            this.jobNotesTextBox.Name = "jobNotesTextBox";
            this.jobNotesTextBox.Size = new System.Drawing.Size(483, 78);
            this.jobNotesTextBox.TabIndex = 6;
            // 
            // jobPositionTextBox
            // 
            this.jobPositionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobBindingSource, "JobPosition", true));
            this.jobPositionTextBox.Location = new System.Drawing.Point(161, 105);
            this.jobPositionTextBox.Name = "jobPositionTextBox";
            this.jobPositionTextBox.Size = new System.Drawing.Size(249, 26);
            this.jobPositionTextBox.TabIndex = 0;
            // 
            // lblSalaryPerYear
            // 
            this.lblSalaryPerYear.AutoSize = true;
            this.lblSalaryPerYear.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalaryPerYear.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblSalaryPerYear.Location = new System.Drawing.Point(48, 219);
            this.lblSalaryPerYear.Name = "lblSalaryPerYear";
            this.lblSalaryPerYear.Size = new System.Drawing.Size(107, 16);
            this.lblSalaryPerYear.TabIndex = 55;
            this.lblSalaryPerYear.Text = "( salary per year )";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.HotPink;
            this.btnCancel.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnCancel.Location = new System.Drawing.Point(558, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(162, 43);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel / Exit";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.HotPink;
            this.btnSave.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnSave.Location = new System.Drawing.Point(437, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 43);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(SharpERBLL.Company);
            // 
            // companyNameComboBox
            // 
            this.companyNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "CompanyName", true));
            this.companyNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.jobBindingSource, "JobCompanyID", true));
            this.companyNameComboBox.DataSource = this.companyBindingSource;
            this.companyNameComboBox.DisplayMember = "CompanyName";
            this.companyNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.companyNameComboBox.FormattingEnabled = true;
            this.companyNameComboBox.Location = new System.Drawing.Point(161, 259);
            this.companyNameComboBox.Name = "companyNameComboBox";
            this.companyNameComboBox.Size = new System.Drawing.Size(249, 26);
            this.companyNameComboBox.TabIndex = 3;
            this.companyNameComboBox.ValueMember = "CompanyID";
            // 
            // contactFirstNameComboBox
            // 
            this.contactFirstNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.jobBindingSource, "JobContactID", true));
            this.contactFirstNameComboBox.DataSource = this.contactBindingSource;
            this.contactFirstNameComboBox.DisplayMember = "ContactFirstName";
            this.contactFirstNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.contactFirstNameComboBox.FormattingEnabled = true;
            this.contactFirstNameComboBox.Location = new System.Drawing.Point(162, 291);
            this.contactFirstNameComboBox.Name = "contactFirstNameComboBox";
            this.contactFirstNameComboBox.Size = new System.Drawing.Size(248, 26);
            this.contactFirstNameComboBox.TabIndex = 4;
            this.contactFirstNameComboBox.ValueMember = "ContactID";
            // 
            // contactBindingSource
            // 
            this.contactBindingSource.DataSource = typeof(SharpERBLL.Contact);
            // 
            // JobContactFirstNameLabel
            // 
            this.JobContactFirstNameLabel.AutoSize = true;
            this.JobContactFirstNameLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobContactFirstNameLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.JobContactFirstNameLabel.Location = new System.Drawing.Point(12, 293);
            this.JobContactFirstNameLabel.Name = "JobContactFirstNameLabel";
            this.JobContactFirstNameLabel.Size = new System.Drawing.Size(140, 19);
            this.JobContactFirstNameLabel.TabIndex = 63;
            this.JobContactFirstNameLabel.Text = "Contact First Name:";
            // 
            // activityBindingSource
            // 
            this.activityBindingSource.DataSource = typeof(SharpERBLL.Activity);
            // 
            // jobCompanyIDTextBox
            // 
            this.jobCompanyIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobBindingSource, "JobCompanyID", true));
            this.jobCompanyIDTextBox.Location = new System.Drawing.Point(552, 259);
            this.jobCompanyIDTextBox.Name = "jobCompanyIDTextBox";
            this.jobCompanyIDTextBox.Size = new System.Drawing.Size(100, 26);
            this.jobCompanyIDTextBox.TabIndex = 68;
            // 
            // jobContactIDTextBox
            // 
            this.jobContactIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobBindingSource, "JobContactID", true));
            this.jobContactIDTextBox.Location = new System.Drawing.Point(552, 290);
            this.jobContactIDTextBox.Name = "jobContactIDTextBox";
            this.jobContactIDTextBox.Size = new System.Drawing.Size(100, 26);
            this.jobContactIDTextBox.TabIndex = 69;
            // 
            // jobPayTextBox
            // 
            this.jobPayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobBindingSource, "JobPay", true));
            this.jobPayTextBox.Location = new System.Drawing.Point(161, 197);
            this.jobPayTextBox.Name = "jobPayTextBox";
            this.jobPayTextBox.Size = new System.Drawing.Size(117, 26);
            this.jobPayTextBox.TabIndex = 70;
            // 
            // JobForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(759, 472);
            this.ControlBox = false;
            this.Controls.Add(this.jobPayTextBox);
            this.Controls.Add(jobContactIDLabel);
            this.Controls.Add(this.jobContactIDTextBox);
            this.Controls.Add(jobCompanyIDLabel);
            this.Controls.Add(this.jobCompanyIDTextBox);
            this.Controls.Add(this.JobContactFirstNameLabel);
            this.Controls.Add(this.contactFirstNameComboBox);
            this.Controls.Add(this.companyNameComboBox);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblSalaryPerYear);
            this.Controls.Add(jobAppliedLabel);
            this.Controls.Add(this.jobAppliedDateTimePicker);
            this.Controls.Add(jobCompanyNameLabel);
            this.Controls.Add(jobIDLabel);
            this.Controls.Add(this.jobIDTextBox);
            this.Controls.Add(jobNotesLabel);
            this.Controls.Add(this.jobNotesTextBox);
            this.Controls.Add(jobPayLabel);
            this.Controls.Add(jobPositionLabel);
            this.Controls.Add(this.jobPositionTextBox);
            this.Controls.Add(this.lblJobInfoTitle);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "JobForm";
            this.Text = "Job";
            this.Load += new System.EventHandler(this.JobForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJobInfoTitle;
        private System.Windows.Forms.DateTimePicker jobAppliedDateTimePicker;
        private System.Windows.Forms.TextBox jobIDTextBox;
        private System.Windows.Forms.TextBox jobNotesTextBox;
        private System.Windows.Forms.TextBox jobPositionTextBox;
        private System.Windows.Forms.Label lblSalaryPerYear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox companyNameComboBox;
        private System.Windows.Forms.ComboBox contactFirstNameComboBox;
        private System.Windows.Forms.Label JobContactFirstNameLabel;
        public System.Windows.Forms.BindingSource jobBindingSource;
        public System.Windows.Forms.BindingSource companyBindingSource;
        public System.Windows.Forms.BindingSource contactBindingSource;
        public System.Windows.Forms.BindingSource activityBindingSource;
        private System.Windows.Forms.TextBox jobCompanyIDTextBox;
        private System.Windows.Forms.TextBox jobContactIDTextBox;
        private System.Windows.Forms.TextBox jobPayTextBox;
    }
}