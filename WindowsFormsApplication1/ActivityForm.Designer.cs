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
            System.Windows.Forms.Label activityContactIDLabel;
            System.Windows.Forms.Label activityDateLabel;
            System.Windows.Forms.Label activityDescriptionLabel;
            System.Windows.Forms.Label activityIDLabel;
            System.Windows.Forms.Label activityJobIDLabel;
            System.Windows.Forms.Label activityNotesLabel;
            System.Windows.Forms.Label activityTravelLabel;
            System.Windows.Forms.Label lblActivityContactFirstName;
            this.activityContactIDTextBox = new System.Windows.Forms.TextBox();
            this.activityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activityDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.activityDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.activityIDTextBox = new System.Windows.Forms.TextBox();
            this.activityJobIDTextBox = new System.Windows.Forms.TextBox();
            this.activityNotesTextBox = new System.Windows.Forms.TextBox();
            this.lblActivityInfoTitle = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.activityTravelComboBox1 = new System.Windows.Forms.ComboBox();
            this.activityContactIDComboBox = new System.Windows.Forms.ComboBox();
            this.contactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            activityContactIDLabel = new System.Windows.Forms.Label();
            activityDateLabel = new System.Windows.Forms.Label();
            activityDescriptionLabel = new System.Windows.Forms.Label();
            activityIDLabel = new System.Windows.Forms.Label();
            activityJobIDLabel = new System.Windows.Forms.Label();
            activityNotesLabel = new System.Windows.Forms.Label();
            activityTravelLabel = new System.Windows.Forms.Label();
            lblActivityContactFirstName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // activityContactIDLabel
            // 
            activityContactIDLabel.AutoSize = true;
            activityContactIDLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            activityContactIDLabel.ForeColor = System.Drawing.Color.DarkBlue;
            activityContactIDLabel.Location = new System.Drawing.Point(120, 286);
            activityContactIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            activityContactIDLabel.Name = "activityContactIDLabel";
            activityContactIDLabel.Size = new System.Drawing.Size(85, 19);
            activityContactIDLabel.TabIndex = 1;
            activityContactIDLabel.Text = "Contact ID:";
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
            activityDateLabel.TabIndex = 3;
            activityDateLabel.Text = "Date:";
            // 
            // activityDescriptionLabel
            // 
            activityDescriptionLabel.AutoSize = true;
            activityDescriptionLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            activityDescriptionLabel.ForeColor = System.Drawing.Color.DarkBlue;
            activityDescriptionLabel.Location = new System.Drawing.Point(69, 138);
            activityDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            activityDescriptionLabel.Name = "activityDescriptionLabel";
            activityDescriptionLabel.Size = new System.Drawing.Size(85, 19);
            activityDescriptionLabel.TabIndex = 5;
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
            activityIDLabel.TabIndex = 7;
            activityIDLabel.Text = "Activity ID:";
            // 
            // activityJobIDLabel
            // 
            activityJobIDLabel.AutoSize = true;
            activityJobIDLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            activityJobIDLabel.ForeColor = System.Drawing.Color.DarkBlue;
            activityJobIDLabel.Location = new System.Drawing.Point(430, 286);
            activityJobIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            activityJobIDLabel.Name = "activityJobIDLabel";
            activityJobIDLabel.Size = new System.Drawing.Size(61, 19);
            activityJobIDLabel.TabIndex = 9;
            activityJobIDLabel.Text = "Job ID:";
            // 
            // activityNotesLabel
            // 
            activityNotesLabel.AutoSize = true;
            activityNotesLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            activityNotesLabel.ForeColor = System.Drawing.Color.DarkBlue;
            activityNotesLabel.Location = new System.Drawing.Point(101, 315);
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
            activityTravelLabel.Location = new System.Drawing.Point(85, 224);
            activityTravelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            activityTravelLabel.Name = "activityTravelLabel";
            activityTravelLabel.Size = new System.Drawing.Size(69, 19);
            activityTravelLabel.TabIndex = 13;
            activityTravelLabel.Text = "Traveled:";
            // 
            // lblActivityContactFirstName
            // 
            lblActivityContactFirstName.AutoSize = true;
            lblActivityContactFirstName.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblActivityContactFirstName.ForeColor = System.Drawing.Color.DarkBlue;
            lblActivityContactFirstName.Location = new System.Drawing.Point(53, 254);
            lblActivityContactFirstName.Name = "lblActivityContactFirstName";
            lblActivityContactFirstName.Size = new System.Drawing.Size(152, 19);
            lblActivityContactFirstName.TabIndex = 62;
            lblActivityContactFirstName.Text = "Contact\'s First Name:";
            // 
            // activityContactIDTextBox
            // 
            this.activityContactIDTextBox.BackColor = System.Drawing.Color.LightGray;
            this.activityContactIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityBindingSource, "ActivityContactID", true));
            this.activityContactIDTextBox.Location = new System.Drawing.Point(212, 283);
            this.activityContactIDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.activityContactIDTextBox.Name = "activityContactIDTextBox";
            this.activityContactIDTextBox.ReadOnly = true;
            this.activityContactIDTextBox.Size = new System.Drawing.Size(117, 26);
            this.activityContactIDTextBox.TabIndex = 4;
            // 
            // activityBindingSource
            // 
            this.activityBindingSource.DataSource = typeof(SharpERBLL.Activity);
            // 
            // activityDateDateTimePicker
            // 
            this.activityDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.activityBindingSource, "ActivityDate", true));
            this.activityDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.activityDateDateTimePicker.Location = new System.Drawing.Point(161, 105);
            this.activityDateDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.activityDateDateTimePicker.Name = "activityDateDateTimePicker";
            this.activityDateDateTimePicker.Size = new System.Drawing.Size(117, 26);
            this.activityDateDateTimePicker.TabIndex = 0;
            // 
            // activityDescriptionTextBox
            // 
            this.activityDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityBindingSource, "ActivityDescription", true));
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
            this.activityIDTextBox.TabIndex = 8;
            // 
            // activityJobIDTextBox
            // 
            this.activityJobIDTextBox.BackColor = System.Drawing.Color.LightGray;
            this.activityJobIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityBindingSource, "ActivityJobID", true));
            this.activityJobIDTextBox.Location = new System.Drawing.Point(498, 282);
            this.activityJobIDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.activityJobIDTextBox.Name = "activityJobIDTextBox";
            this.activityJobIDTextBox.ReadOnly = true;
            this.activityJobIDTextBox.Size = new System.Drawing.Size(117, 26);
            this.activityJobIDTextBox.TabIndex = 3;
            // 
            // activityNotesTextBox
            // 
            this.activityNotesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityBindingSource, "ActivityNotes", true));
            this.activityNotesTextBox.Location = new System.Drawing.Point(161, 315);
            this.activityNotesTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.activityNotesTextBox.Multiline = true;
            this.activityNotesTextBox.Name = "activityNotesTextBox";
            this.activityNotesTextBox.Size = new System.Drawing.Size(454, 78);
            this.activityNotesTextBox.TabIndex = 4;
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
            this.lblActivityInfoTitle.TabIndex = 38;
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
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.HotPink;
            this.btnCancel.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnCancel.Location = new System.Drawing.Point(558, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(162, 43);
            this.btnCancel.TabIndex = 59;
            this.btnCancel.Text = "Cancel / Exit";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // activityTravelComboBox1
            // 
            this.activityTravelComboBox1.BackColor = System.Drawing.Color.LightGray;
            this.activityTravelComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityBindingSource, "ActivityTravel", true));
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
            // 
            // activityContactIDComboBox
            // 
            this.activityContactIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityBindingSource, "ActivityContactID", true));
            this.activityContactIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.activityBindingSource, "ActivityContactID", true));
            this.activityContactIDComboBox.DataSource = this.contactBindingSource;
            this.activityContactIDComboBox.DisplayMember = "ContactFirstName";
            this.activityContactIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.activityContactIDComboBox.FormattingEnabled = true;
            this.activityContactIDComboBox.Location = new System.Drawing.Point(211, 252);
            this.activityContactIDComboBox.Name = "activityContactIDComboBox";
            this.activityContactIDComboBox.Size = new System.Drawing.Size(117, 26);
            this.activityContactIDComboBox.TabIndex = 3;
            this.activityContactIDComboBox.ValueMember = "ContactID";
            this.activityContactIDComboBox.SelectedIndexChanged += new System.EventHandler(this.activityContactIDComboBox_SelectedIndexChanged);
            // 
            // contactBindingSource
            // 
            this.contactBindingSource.DataSource = typeof(SharpERBLL.Contact);
            // 
            // ActivityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(732, 472);
            this.ControlBox = false;
            this.Controls.Add(lblActivityContactFirstName);
            this.Controls.Add(this.activityContactIDComboBox);
            this.Controls.Add(this.activityTravelComboBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblActivityInfoTitle);
            this.Controls.Add(activityContactIDLabel);
            this.Controls.Add(this.activityContactIDTextBox);
            this.Controls.Add(activityDateLabel);
            this.Controls.Add(this.activityDateDateTimePicker);
            this.Controls.Add(activityDescriptionLabel);
            this.Controls.Add(this.activityDescriptionTextBox);
            this.Controls.Add(activityIDLabel);
            this.Controls.Add(this.activityIDTextBox);
            this.Controls.Add(activityJobIDLabel);
            this.Controls.Add(this.activityJobIDTextBox);
            this.Controls.Add(activityNotesLabel);
            this.Controls.Add(this.activityNotesTextBox);
            this.Controls.Add(activityTravelLabel);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ActivityForm";
            this.Text = "Activity";
            this.Load += new System.EventHandler(this.ActivityForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox activityContactIDTextBox;
        private System.Windows.Forms.DateTimePicker activityDateDateTimePicker;
        private System.Windows.Forms.TextBox activityDescriptionTextBox;
        private System.Windows.Forms.TextBox activityIDTextBox;
        private System.Windows.Forms.TextBox activityJobIDTextBox;
        private System.Windows.Forms.TextBox activityNotesTextBox;
        private System.Windows.Forms.Label lblActivityInfoTitle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.BindingSource activityBindingSource;
        private System.Windows.Forms.ComboBox activityTravelComboBox1;
        private System.Windows.Forms.ComboBox activityContactIDComboBox;
        private System.Windows.Forms.BindingSource contactBindingSource;
    }
}