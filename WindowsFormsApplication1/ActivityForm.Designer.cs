namespace WindowsFormsApplication1
{
    partial class ActivityForm
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
            System.Windows.Forms.Label activityDateLabel;
            System.Windows.Forms.Label activityDescriptionLabel;
            System.Windows.Forms.Label activityIDLabel;
            System.Windows.Forms.Label activityNotesLabel;
            System.Windows.Forms.Label activityTravelLabel;
            System.Windows.Forms.Label contactFirstNameLabel;
            System.Windows.Forms.Label activityJobIDLabel;
            this.activityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activityDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.activityDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.activityIDTextBox = new System.Windows.Forms.TextBox();
            this.activityNotesTextBox = new System.Windows.Forms.TextBox();
            this.lblActivityInfoTitle = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.activityTravelComboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.activityContactIDComboBox = new System.Windows.Forms.ComboBox();
            this.lblContactReminder = new System.Windows.Forms.Label();
            this.btnAddJob = new System.Windows.Forms.Button();
            this.lblJobReminder = new System.Windows.Forms.Label();
            this.activityJobIDComboBox = new System.Windows.Forms.ComboBox();
            activityDateLabel = new System.Windows.Forms.Label();
            activityDescriptionLabel = new System.Windows.Forms.Label();
            activityIDLabel = new System.Windows.Forms.Label();
            activityNotesLabel = new System.Windows.Forms.Label();
            activityTravelLabel = new System.Windows.Forms.Label();
            contactFirstNameLabel = new System.Windows.Forms.Label();
            activityJobIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // activityDateLabel
            // 
            activityDateLabel.AutoSize = true;
            activityDateLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            activityDateLabel.ForeColor = System.Drawing.Color.DarkBlue;
            activityDateLabel.Location = new System.Drawing.Point(109, 108);
            activityDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            activityDateLabel.Name = "activityDateLabel";
            activityDateLabel.Size = new System.Drawing.Size(44, 19);
            activityDateLabel.TabIndex = 7;
            activityDateLabel.Text = "Date:";
            // 
            // activityDescriptionLabel
            // 
            activityDescriptionLabel.AutoSize = true;
            activityDescriptionLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            activityDescriptionLabel.ForeColor = System.Drawing.Color.DarkBlue;
            activityDescriptionLabel.Location = new System.Drawing.Point(68, 138);
            activityDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            activityDescriptionLabel.Name = "activityDescriptionLabel";
            activityDescriptionLabel.Size = new System.Drawing.Size(85, 19);
            activityDescriptionLabel.TabIndex = 8;
            activityDescriptionLabel.Text = "Description:";
            // 
            // activityIDLabel
            // 
            activityIDLabel.AutoSize = true;
            activityIDLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            activityIDLabel.ForeColor = System.Drawing.Color.DarkBlue;
            activityIDLabel.Location = new System.Drawing.Point(402, 108);
            activityIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            activityIDLabel.Name = "activityIDLabel";
            activityIDLabel.Size = new System.Drawing.Size(87, 19);
            activityIDLabel.TabIndex = 12;
            activityIDLabel.Text = "Activity ID:";
            // 
            // activityNotesLabel
            // 
            activityNotesLabel.AutoSize = true;
            activityNotesLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            activityNotesLabel.ForeColor = System.Drawing.Color.DarkBlue;
            activityNotesLabel.Location = new System.Drawing.Point(101, 319);
            activityNotesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            activityNotesLabel.Name = "activityNotesLabel";
            activityNotesLabel.Size = new System.Drawing.Size(52, 19);
            activityNotesLabel.TabIndex = 11;
            activityNotesLabel.Text = "Notes:";
            // 
            // activityTravelLabel
            // 
            activityTravelLabel.AutoSize = true;
            activityTravelLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            activityTravelLabel.ForeColor = System.Drawing.Color.DarkBlue;
            activityTravelLabel.Location = new System.Drawing.Point(84, 224);
            activityTravelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            activityTravelLabel.Name = "activityTravelLabel";
            activityTravelLabel.Size = new System.Drawing.Size(69, 19);
            activityTravelLabel.TabIndex = 9;
            activityTravelLabel.Text = "Traveled:";
            // 
            // contactFirstNameLabel
            // 
            contactFirstNameLabel.AutoSize = true;
            contactFirstNameLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contactFirstNameLabel.ForeColor = System.Drawing.Color.DarkBlue;
            contactFirstNameLabel.Location = new System.Drawing.Point(13, 254);
            contactFirstNameLabel.Name = "contactFirstNameLabel";
            contactFirstNameLabel.Size = new System.Drawing.Size(140, 19);
            contactFirstNameLabel.TabIndex = 17;
            contactFirstNameLabel.Text = "Contact First Name:";
            // 
            // activityJobIDLabel
            // 
            activityJobIDLabel.AutoSize = true;
            activityJobIDLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            activityJobIDLabel.ForeColor = System.Drawing.Color.DarkBlue;
            activityJobIDLabel.Location = new System.Drawing.Point(59, 289);
            activityJobIDLabel.Name = "activityJobIDLabel";
            activityJobIDLabel.Size = new System.Drawing.Size(93, 19);
            activityJobIDLabel.TabIndex = 21;
            activityJobIDLabel.Text = "Job Position:";
            // 
            // activityBindingSource
            // 
            this.activityBindingSource.DataSource = typeof(SharpERBLL.Activity);
            // 
            // jobBindingSource
            // 
            this.jobBindingSource.DataSource = typeof(SharpERBLL.Job);
            // 
            // contactBindingSource
            // 
            this.contactBindingSource.DataSource = typeof(SharpERBLL.Contact);
            // 
            // activityDateDateTimePicker
            // 
            this.activityDateDateTimePicker.CausesValidation = false;
            this.activityDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityBindingSource, "ActivityDate", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.activityDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.activityBindingSource, "ActivityDate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.activityDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.activityDateDateTimePicker.Location = new System.Drawing.Point(161, 105);
            this.activityDateDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.activityDateDateTimePicker.Name = "activityDateDateTimePicker";
            this.activityDateDateTimePicker.ShowCheckBox = true;
            this.activityDateDateTimePicker.Size = new System.Drawing.Size(191, 26);
            this.activityDateDateTimePicker.TabIndex = 0;
            // 
            // activityDescriptionTextBox
            // 
            this.activityDescriptionTextBox.CausesValidation = false;
            this.activityDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityBindingSource, "ActivityDescription", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.activityDescriptionTextBox.Location = new System.Drawing.Point(161, 137);
            this.activityDescriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.activityDescriptionTextBox.Multiline = true;
            this.activityDescriptionTextBox.Name = "activityDescriptionTextBox";
            this.activityDescriptionTextBox.Size = new System.Drawing.Size(454, 78);
            this.activityDescriptionTextBox.TabIndex = 1;
            // 
            // activityIDTextBox
            // 
            this.activityIDTextBox.BackColor = System.Drawing.Color.LightGray;
            this.activityIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityBindingSource, "ActivityID", true));
            this.activityIDTextBox.Location = new System.Drawing.Point(497, 105);
            this.activityIDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.activityIDTextBox.Name = "activityIDTextBox";
            this.activityIDTextBox.ReadOnly = true;
            this.activityIDTextBox.Size = new System.Drawing.Size(117, 26);
            this.activityIDTextBox.TabIndex = 10;
            // 
            // activityNotesTextBox
            // 
            this.activityNotesTextBox.CausesValidation = false;
            this.activityNotesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityBindingSource, "ActivityNotes", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.activityNotesTextBox.Location = new System.Drawing.Point(160, 319);
            this.activityNotesTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.activityNotesTextBox.Multiline = true;
            this.activityNotesTextBox.Name = "activityNotesTextBox";
            this.activityNotesTextBox.Size = new System.Drawing.Size(454, 78);
            this.activityNotesTextBox.TabIndex = 7;
            // 
            // lblActivityInfoTitle
            // 
            this.lblActivityInfoTitle.AutoSize = true;
            this.lblActivityInfoTitle.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivityInfoTitle.ForeColor = System.Drawing.Color.Crimson;
            this.lblActivityInfoTitle.Location = new System.Drawing.Point(1, 50);
            this.lblActivityInfoTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActivityInfoTitle.Name = "lblActivityInfoTitle";
            this.lblActivityInfoTitle.Size = new System.Drawing.Size(278, 43);
            this.lblActivityInfoTitle.TabIndex = 14;
            this.lblActivityInfoTitle.Text = "Activity Information";
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
            // activityTravelComboBox1
            // 
            this.activityTravelComboBox1.BackColor = System.Drawing.Color.LightGray;
            this.activityTravelComboBox1.CausesValidation = false;
            this.activityTravelComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.activityBindingSource, "ActivityTravel", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.activityTravelComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityBindingSource, "ActivityTravel", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.activityTravelComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.activityTravelComboBox1.DropDownWidth = 72;
            this.activityTravelComboBox1.FormattingEnabled = true;
            this.activityTravelComboBox1.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.activityTravelComboBox1.Location = new System.Drawing.Point(161, 221);
            this.activityTravelComboBox1.Name = "activityTravelComboBox1";
            this.activityTravelComboBox1.Size = new System.Drawing.Size(117, 26);
            this.activityTravelComboBox1.TabIndex = 2;
            this.activityTravelComboBox1.SelectionChangeCommitted += new System.EventHandler(this.activityTravelComboBox1_SelectionChangeCommitted);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddNew.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.btnAddNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAddNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAddNew.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnAddNew.Location = new System.Drawing.Point(298, 251);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(141, 27);
            this.btnAddNew.TabIndex = 4;
            this.btnAddNew.Text = "Add New Contact";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNewContact_Click);
            // 
            // activityContactIDComboBox
            // 
            this.activityContactIDComboBox.CausesValidation = false;
            this.activityContactIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.activityBindingSource, "ActivityContactID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.activityContactIDComboBox.DataSource = this.contactBindingSource;
            this.activityContactIDComboBox.DisplayMember = "ContactFirstName";
            this.activityContactIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.activityContactIDComboBox.FormattingEnabled = true;
            this.activityContactIDComboBox.ItemHeight = 18;
            this.activityContactIDComboBox.Location = new System.Drawing.Point(160, 252);
            this.activityContactIDComboBox.Name = "activityContactIDComboBox";
            this.activityContactIDComboBox.Size = new System.Drawing.Size(121, 26);
            this.activityContactIDComboBox.TabIndex = 3;
            this.activityContactIDComboBox.ValueMember = "ContactID";
            this.activityContactIDComboBox.SelectionChangeCommitted += new System.EventHandler(this.activityContactIDComboBox_SelectionChangeCommitted);
            // 
            // lblContactReminder
            // 
            this.lblContactReminder.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactReminder.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lblContactReminder.Location = new System.Drawing.Point(445, 251);
            this.lblContactReminder.Name = "lblContactReminder";
            this.lblContactReminder.Size = new System.Drawing.Size(273, 20);
            this.lblContactReminder.TabIndex = 19;
            this.lblContactReminder.Text = "←Don\'t forget to select a Contact";
            this.lblContactReminder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblContactReminder.Visible = false;
            // 
            // btnAddJob
            // 
            this.btnAddJob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddJob.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.btnAddJob.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAddJob.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAddJob.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddJob.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnAddJob.Location = new System.Drawing.Point(368, 286);
            this.btnAddJob.Name = "btnAddJob";
            this.btnAddJob.Size = new System.Drawing.Size(141, 27);
            this.btnAddJob.TabIndex = 6;
            this.btnAddJob.Text = "Add New Job";
            this.btnAddJob.UseVisualStyleBackColor = false;
            this.btnAddJob.Click += new System.EventHandler(this.btnAddJob_Click);
            // 
            // lblJobReminder
            // 
            this.lblJobReminder.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobReminder.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lblJobReminder.Location = new System.Drawing.Point(515, 275);
            this.lblJobReminder.Name = "lblJobReminder";
            this.lblJobReminder.Size = new System.Drawing.Size(213, 42);
            this.lblJobReminder.TabIndex = 21;
            this.lblJobReminder.Text = "←Don\'t forget to select a Job Position";
            this.lblJobReminder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblJobReminder.Visible = false;
            // 
            // activityJobIDComboBox
            // 
            this.activityJobIDComboBox.CausesValidation = false;
            this.activityJobIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.activityBindingSource, "ActivityJobID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.activityJobIDComboBox.DataSource = this.jobBindingSource;
            this.activityJobIDComboBox.DisplayMember = "JobPosition";
            this.activityJobIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.activityJobIDComboBox.FormattingEnabled = true;
            this.activityJobIDComboBox.Location = new System.Drawing.Point(159, 286);
            this.activityJobIDComboBox.Name = "activityJobIDComboBox";
            this.activityJobIDComboBox.Size = new System.Drawing.Size(193, 26);
            this.activityJobIDComboBox.TabIndex = 5;
            this.activityJobIDComboBox.ValueMember = "JobID";
            this.activityJobIDComboBox.SelectionChangeCommitted += new System.EventHandler(this.activityJobIDComboBox_SelectionChangeCommitted);
            // 
            // ActivityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(748, 482);
            this.ControlBox = false;
            this.Controls.Add(activityJobIDLabel);
            this.Controls.Add(this.activityJobIDComboBox);
            this.Controls.Add(this.lblJobReminder);
            this.Controls.Add(this.btnAddJob);
            this.Controls.Add(this.lblContactReminder);
            this.Controls.Add(contactFirstNameLabel);
            this.Controls.Add(this.activityContactIDComboBox);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.activityTravelComboBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblActivityInfoTitle);
            this.Controls.Add(activityDateLabel);
            this.Controls.Add(this.activityDateDateTimePicker);
            this.Controls.Add(activityDescriptionLabel);
            this.Controls.Add(this.activityDescriptionTextBox);
            this.Controls.Add(activityIDLabel);
            this.Controls.Add(this.activityIDTextBox);
            this.Controls.Add(activityNotesLabel);
            this.Controls.Add(this.activityNotesTextBox);
            this.Controls.Add(activityTravelLabel);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ActivityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Activity";
            this.Load += new System.EventHandler(this.ActivityForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker activityDateDateTimePicker;
        private System.Windows.Forms.TextBox activityDescriptionTextBox;
        private System.Windows.Forms.TextBox activityIDTextBox;
        private System.Windows.Forms.TextBox activityNotesTextBox;
        private System.Windows.Forms.Label lblActivityInfoTitle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.BindingSource activityBindingSource;
        private System.Windows.Forms.ComboBox activityTravelComboBox1;
        private System.Windows.Forms.BindingSource contactBindingSource;
        private System.Windows.Forms.BindingSource jobBindingSource;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.ComboBox activityContactIDComboBox;
        private System.Windows.Forms.Label lblContactReminder;
        private System.Windows.Forms.Button btnAddJob;
        private System.Windows.Forms.Label lblJobReminder;
        private System.Windows.Forms.ComboBox activityJobIDComboBox;
    }
}