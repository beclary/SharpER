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
            System.Windows.Forms.Label jobCompanyIDLabel;
            System.Windows.Forms.Label jobContactIDLabel;
            System.Windows.Forms.Label jobIDLabel;
            System.Windows.Forms.Label jobNotesLabel;
            System.Windows.Forms.Label jobPayLabel;
            System.Windows.Forms.Label jobPositionLabel;
            this.lblJobInfoTitle = new System.Windows.Forms.Label();
            this.jobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobAppliedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.jobContactIDTextBox = new System.Windows.Forms.TextBox();
            this.jobIDTextBox = new System.Windows.Forms.TextBox();
            this.jobNotesTextBox = new System.Windows.Forms.TextBox();
            this.jobPayTextBox = new System.Windows.Forms.TextBox();
            this.jobPositionTextBox = new System.Windows.Forms.TextBox();
            this.lblSalaryPerYear = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyNameComboBox = new System.Windows.Forms.ComboBox();
            jobAppliedLabel = new System.Windows.Forms.Label();
            jobCompanyIDLabel = new System.Windows.Forms.Label();
            jobContactIDLabel = new System.Windows.Forms.Label();
            jobIDLabel = new System.Windows.Forms.Label();
            jobNotesLabel = new System.Windows.Forms.Label();
            jobPayLabel = new System.Windows.Forms.Label();
            jobPositionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // jobAppliedLabel
            // 
            jobAppliedLabel.AutoSize = true;
            jobAppliedLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            jobAppliedLabel.ForeColor = System.Drawing.Color.DarkBlue;
            jobAppliedLabel.Location = new System.Drawing.Point(50, 143);
            jobAppliedLabel.Name = "jobAppliedLabel";
            jobAppliedLabel.Size = new System.Drawing.Size(82, 19);
            jobAppliedLabel.TabIndex = 40;
            jobAppliedLabel.Text = "Applied on:";
            // 
            // jobCompanyIDLabel
            // 
            jobCompanyIDLabel.AutoSize = true;
            jobCompanyIDLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            jobCompanyIDLabel.ForeColor = System.Drawing.Color.DarkBlue;
            jobCompanyIDLabel.Location = new System.Drawing.Point(41, 263);
            jobCompanyIDLabel.Name = "jobCompanyIDLabel";
            jobCompanyIDLabel.Size = new System.Drawing.Size(68, 19);
            jobCompanyIDLabel.TabIndex = 42;
            jobCompanyIDLabel.Text = "Company:";
            // 
            // jobContactIDLabel
            // 
            jobContactIDLabel.AutoSize = true;
            jobContactIDLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            jobContactIDLabel.ForeColor = System.Drawing.Color.DarkBlue;
            jobContactIDLabel.Location = new System.Drawing.Point(46, 295);
            jobContactIDLabel.Name = "jobContactIDLabel";
            jobContactIDLabel.Size = new System.Drawing.Size(85, 19);
            jobContactIDLabel.TabIndex = 44;
            jobContactIDLabel.Text = "Contact ID:";
            // 
            // jobIDLabel
            // 
            jobIDLabel.AutoSize = true;
            jobIDLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            jobIDLabel.ForeColor = System.Drawing.Color.DarkBlue;
            jobIDLabel.Location = new System.Drawing.Point(448, 110);
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
            jobNotesLabel.Location = new System.Drawing.Point(79, 357);
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
            jobPayLabel.Location = new System.Drawing.Point(41, 202);
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
            jobPositionLabel.Location = new System.Drawing.Point(69, 110);
            jobPositionLabel.Name = "jobPositionLabel";
            jobPositionLabel.Size = new System.Drawing.Size(63, 19);
            jobPositionLabel.TabIndex = 52;
            jobPositionLabel.Text = "Position:";
            // 
            // lblJobInfoTitle
            // 
            this.lblJobInfoTitle.AutoSize = true;
            this.lblJobInfoTitle.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobInfoTitle.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblJobInfoTitle.Location = new System.Drawing.Point(4, 48);
            this.lblJobInfoTitle.Name = "lblJobInfoTitle";
            this.lblJobInfoTitle.Size = new System.Drawing.Size(220, 43);
            this.lblJobInfoTitle.TabIndex = 39;
            this.lblJobInfoTitle.Text = "Job Information";
            this.lblJobInfoTitle.Click += new System.EventHandler(this.lblJobInfoTitle_Click);
            // 
            // jobBindingSource
            // 
            this.jobBindingSource.DataSource = typeof(SharpERBLL.Job);
            // 
            // jobAppliedDateTimePicker
            // 
            this.jobAppliedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.jobBindingSource, "JobApplied", true));
            this.jobAppliedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.jobAppliedDateTimePicker.Location = new System.Drawing.Point(138, 140);
            this.jobAppliedDateTimePicker.Name = "jobAppliedDateTimePicker";
            this.jobAppliedDateTimePicker.Size = new System.Drawing.Size(130, 26);
            this.jobAppliedDateTimePicker.TabIndex = 1;
            // 
            // jobContactIDTextBox
            // 
            this.jobContactIDTextBox.BackColor = System.Drawing.Color.LightGray;
            this.jobContactIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobBindingSource, "JobContactID", true));
            this.jobContactIDTextBox.Location = new System.Drawing.Point(137, 293);
            this.jobContactIDTextBox.Name = "jobContactIDTextBox";
            this.jobContactIDTextBox.Size = new System.Drawing.Size(117, 26);
            this.jobContactIDTextBox.TabIndex = 4;
            // 
            // jobIDTextBox
            // 
            this.jobIDTextBox.BackColor = System.Drawing.Color.LightGray;
            this.jobIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobBindingSource, "JobID", true));
            this.jobIDTextBox.Location = new System.Drawing.Point(515, 108);
            this.jobIDTextBox.Name = "jobIDTextBox";
            this.jobIDTextBox.ReadOnly = true;
            this.jobIDTextBox.Size = new System.Drawing.Size(117, 26);
            this.jobIDTextBox.TabIndex = 47;
            // 
            // jobNotesTextBox
            // 
            this.jobNotesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobBindingSource, "JobNotes", true));
            this.jobNotesTextBox.Location = new System.Drawing.Point(137, 355);
            this.jobNotesTextBox.Multiline = true;
            this.jobNotesTextBox.Name = "jobNotesTextBox";
            this.jobNotesTextBox.Size = new System.Drawing.Size(454, 78);
            this.jobNotesTextBox.TabIndex = 5;
            // 
            // jobPayTextBox
            // 
            this.jobPayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobBindingSource, "JobPay", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.jobPayTextBox.Location = new System.Drawing.Point(138, 200);
            this.jobPayTextBox.Name = "jobPayTextBox";
            this.jobPayTextBox.Size = new System.Drawing.Size(130, 26);
            this.jobPayTextBox.TabIndex = 2;
            // 
            // jobPositionTextBox
            // 
            this.jobPositionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobBindingSource, "JobPosition", true));
            this.jobPositionTextBox.Location = new System.Drawing.Point(138, 108);
            this.jobPositionTextBox.Name = "jobPositionTextBox";
            this.jobPositionTextBox.Size = new System.Drawing.Size(283, 26);
            this.jobPositionTextBox.TabIndex = 0;
            // 
            // lblSalaryPerYear
            // 
            this.lblSalaryPerYear.AutoSize = true;
            this.lblSalaryPerYear.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalaryPerYear.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblSalaryPerYear.Location = new System.Drawing.Point(31, 221);
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
            this.btnCancel.TabIndex = 56;
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
            this.btnSave.TabIndex = 58;
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
            this.companyNameComboBox.FormattingEnabled = true;
            this.companyNameComboBox.Location = new System.Drawing.Point(138, 261);
            this.companyNameComboBox.Name = "companyNameComboBox";
            this.companyNameComboBox.Size = new System.Drawing.Size(121, 26);
            this.companyNameComboBox.TabIndex = 59;
            this.companyNameComboBox.SelectedIndexChanged += new System.EventHandler(this.companyNameComboBox_SelectedIndexChanged);
            // 
            // JobForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(742, 477);
            this.Controls.Add(this.companyNameComboBox);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblSalaryPerYear);
            this.Controls.Add(jobAppliedLabel);
            this.Controls.Add(this.jobAppliedDateTimePicker);
            this.Controls.Add(jobCompanyIDLabel);
            this.Controls.Add(jobContactIDLabel);
            this.Controls.Add(this.jobContactIDTextBox);
            this.Controls.Add(jobIDLabel);
            this.Controls.Add(this.jobIDTextBox);
            this.Controls.Add(jobNotesLabel);
            this.Controls.Add(this.jobNotesTextBox);
            this.Controls.Add(jobPayLabel);
            this.Controls.Add(this.jobPayTextBox);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJobInfoTitle;
        private System.Windows.Forms.BindingSource jobBindingSource;
        private System.Windows.Forms.DateTimePicker jobAppliedDateTimePicker;
        private System.Windows.Forms.TextBox jobContactIDTextBox;
        private System.Windows.Forms.TextBox jobIDTextBox;
        private System.Windows.Forms.TextBox jobNotesTextBox;
        private System.Windows.Forms.TextBox jobPayTextBox;
        private System.Windows.Forms.TextBox jobPositionTextBox;
        private System.Windows.Forms.Label lblSalaryPerYear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.ComboBox companyNameComboBox;
    }
}