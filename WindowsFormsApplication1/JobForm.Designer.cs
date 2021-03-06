﻿namespace WindowsFormsApplication1
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
            this.jobPayTextBox = new System.Windows.Forms.TextBox();
            this.btnAddNewContactJobForm = new System.Windows.Forms.Button();
            this.lblContactReminderJobForm = new System.Windows.Forms.Label();
            this.btnAddNewCompanyJobForm = new System.Windows.Forms.Button();
            this.lblCompanyReminderJobForm = new System.Windows.Forms.Label();
            this.lblJobPayTextBoxError = new System.Windows.Forms.Label();
            jobAppliedLabel = new System.Windows.Forms.Label();
            jobCompanyNameLabel = new System.Windows.Forms.Label();
            jobIDLabel = new System.Windows.Forms.Label();
            jobNotesLabel = new System.Windows.Forms.Label();
            jobPayLabel = new System.Windows.Forms.Label();
            jobPositionLabel = new System.Windows.Forms.Label();
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
            this.jobIDTextBox.TabIndex = 10;
            // 
            // jobNotesTextBox
            // 
            this.jobNotesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobBindingSource, "JobNotes", true));
            this.jobNotesTextBox.Location = new System.Drawing.Point(162, 356);
            this.jobNotesTextBox.Multiline = true;
            this.jobNotesTextBox.Name = "jobNotesTextBox";
            this.jobNotesTextBox.Size = new System.Drawing.Size(483, 78);
            this.jobNotesTextBox.TabIndex = 7;
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
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnCancel.Location = new System.Drawing.Point(558, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(162, 43);
            this.btnCancel.TabIndex = 9;
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
            this.btnSave.TabIndex = 8;
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
            this.companyNameComboBox.CausesValidation = false;
            this.companyNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.jobBindingSource, "JobCompanyID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.companyNameComboBox.DataSource = this.companyBindingSource;
            this.companyNameComboBox.DisplayMember = "CompanyName";
            this.companyNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.companyNameComboBox.FormattingEnabled = true;
            this.companyNameComboBox.Location = new System.Drawing.Point(161, 259);
            this.companyNameComboBox.Name = "companyNameComboBox";
            this.companyNameComboBox.Size = new System.Drawing.Size(164, 26);
            this.companyNameComboBox.TabIndex = 3;
            this.companyNameComboBox.ValueMember = "CompanyID";
            this.companyNameComboBox.SelectionChangeCommitted += new System.EventHandler(this.companyNameComboBox_SelectionChangeCommitted);
            // 
            // contactFirstNameComboBox
            // 
            this.contactFirstNameComboBox.CausesValidation = false;
            this.contactFirstNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.jobBindingSource, "JobContactID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.contactFirstNameComboBox.DataSource = this.contactBindingSource;
            this.contactFirstNameComboBox.DisplayMember = "ContactFirstName";
            this.contactFirstNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.contactFirstNameComboBox.FormattingEnabled = true;
            this.contactFirstNameComboBox.Location = new System.Drawing.Point(162, 291);
            this.contactFirstNameComboBox.Name = "contactFirstNameComboBox";
            this.contactFirstNameComboBox.Size = new System.Drawing.Size(163, 26);
            this.contactFirstNameComboBox.TabIndex = 5;
            this.contactFirstNameComboBox.ValueMember = "ContactID";
            this.contactFirstNameComboBox.SelectionChangeCommitted += new System.EventHandler(this.contactFirstNameComboBox_SelectionChangeCommitted);
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
            // jobPayTextBox
            // 
            this.jobPayTextBox.CausesValidation = false;
            this.jobPayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobBindingSource, "JobPay", true));
            this.jobPayTextBox.Location = new System.Drawing.Point(161, 197);
            this.jobPayTextBox.Name = "jobPayTextBox";
            this.jobPayTextBox.Size = new System.Drawing.Size(117, 26);
            this.jobPayTextBox.TabIndex = 2;
            //this.jobPayTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.jobPayTextBox_Validating);
            // 
            // btnAddNewContactJobForm
            // 
            this.btnAddNewContactJobForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddNewContactJobForm.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddNewContactJobForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAddNewContactJobForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAddNewContactJobForm.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewContactJobForm.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnAddNewContactJobForm.Location = new System.Drawing.Point(340, 290);
            this.btnAddNewContactJobForm.Name = "btnAddNewContactJobForm";
            this.btnAddNewContactJobForm.Size = new System.Drawing.Size(141, 27);
            this.btnAddNewContactJobForm.TabIndex = 6;
            this.btnAddNewContactJobForm.Text = "Add New Contact";
            this.btnAddNewContactJobForm.UseVisualStyleBackColor = false;
            this.btnAddNewContactJobForm.Click += new System.EventHandler(this.btnAddNewContactJobForm_Click);
            // 
            // lblContactReminderJobForm
            // 
            this.lblContactReminderJobForm.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactReminderJobForm.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lblContactReminderJobForm.Location = new System.Drawing.Point(487, 293);
            this.lblContactReminderJobForm.Name = "lblContactReminderJobForm";
            this.lblContactReminderJobForm.Size = new System.Drawing.Size(273, 20);
            this.lblContactReminderJobForm.TabIndex = 72;
            this.lblContactReminderJobForm.Text = "←Don\'t forget to select a Contact";
            this.lblContactReminderJobForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblContactReminderJobForm.Visible = false;
            // 
            // btnAddNewCompanyJobForm
            // 
            this.btnAddNewCompanyJobForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddNewCompanyJobForm.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.btnAddNewCompanyJobForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAddNewCompanyJobForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAddNewCompanyJobForm.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCompanyJobForm.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnAddNewCompanyJobForm.Location = new System.Drawing.Point(340, 259);
            this.btnAddNewCompanyJobForm.Name = "btnAddNewCompanyJobForm";
            this.btnAddNewCompanyJobForm.Size = new System.Drawing.Size(141, 27);
            this.btnAddNewCompanyJobForm.TabIndex = 4;
            this.btnAddNewCompanyJobForm.Text = "Add New Company";
            this.btnAddNewCompanyJobForm.UseVisualStyleBackColor = false;
            this.btnAddNewCompanyJobForm.Click += new System.EventHandler(this.btnAddNewCompanyJobForm_Click);
            // 
            // lblCompanyReminderJobForm
            // 
            this.lblCompanyReminderJobForm.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyReminderJobForm.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lblCompanyReminderJobForm.Location = new System.Drawing.Point(487, 255);
            this.lblCompanyReminderJobForm.Name = "lblCompanyReminderJobForm";
            this.lblCompanyReminderJobForm.Size = new System.Drawing.Size(273, 34);
            this.lblCompanyReminderJobForm.TabIndex = 74;
            this.lblCompanyReminderJobForm.Text = "←Don\'t forget to select a Company";
            this.lblCompanyReminderJobForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCompanyReminderJobForm.Visible = false;
            // 
            // lblJobPayTextBoxError
            // 
            this.lblJobPayTextBoxError.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobPayTextBoxError.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lblJobPayTextBoxError.Location = new System.Drawing.Point(284, 185);
            this.lblJobPayTextBoxError.Name = "lblJobPayTextBoxError";
            this.lblJobPayTextBoxError.Size = new System.Drawing.Size(422, 50);
            this.lblJobPayTextBoxError.TabIndex = 75;
            this.lblJobPayTextBoxError.Text = "Error message will go here";
            this.lblJobPayTextBoxError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblJobPayTextBoxError.Visible = false;
            // 
            // JobForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(759, 472);
            this.ControlBox = false;
            this.Controls.Add(this.lblJobPayTextBoxError);
            this.Controls.Add(this.lblCompanyReminderJobForm);
            this.Controls.Add(this.btnAddNewCompanyJobForm);
            this.Controls.Add(this.lblContactReminderJobForm);
            this.Controls.Add(this.btnAddNewContactJobForm);
            this.Controls.Add(this.jobPayTextBox);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
        private System.Windows.Forms.TextBox jobPayTextBox;
        private System.Windows.Forms.Button btnAddNewContactJobForm;
        private System.Windows.Forms.Label lblContactReminderJobForm;
        private System.Windows.Forms.Button btnAddNewCompanyJobForm;
        private System.Windows.Forms.Label lblCompanyReminderJobForm;
        private System.Windows.Forms.Label lblJobPayTextBoxError;
    }
}