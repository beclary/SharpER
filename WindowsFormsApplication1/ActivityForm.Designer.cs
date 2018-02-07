﻿namespace WindowsFormsApplication1
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
            this.activityContactIDTextBox = new System.Windows.Forms.TextBox();
            this.activityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activityDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.activityDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.activityIDTextBox = new System.Windows.Forms.TextBox();
            this.activityJobIDTextBox = new System.Windows.Forms.TextBox();
            this.activityNotesTextBox = new System.Windows.Forms.TextBox();
            this.activityTravelComboBox = new System.Windows.Forms.ComboBox();
            this.lblActivityInfoTitle = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            activityContactIDLabel = new System.Windows.Forms.Label();
            activityDateLabel = new System.Windows.Forms.Label();
            activityDescriptionLabel = new System.Windows.Forms.Label();
            activityIDLabel = new System.Windows.Forms.Label();
            activityJobIDLabel = new System.Windows.Forms.Label();
            activityNotesLabel = new System.Windows.Forms.Label();
            activityTravelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // activityContactIDLabel
            // 
            activityContactIDLabel.AutoSize = true;
            activityContactIDLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            activityContactIDLabel.ForeColor = System.Drawing.Color.DarkBlue;
            activityContactIDLabel.Location = new System.Drawing.Point(25, 300);
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
            activityDateLabel.Location = new System.Drawing.Point(66, 112);
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
            activityDescriptionLabel.Location = new System.Drawing.Point(25, 145);
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
            activityIDLabel.Location = new System.Drawing.Point(369, 112);
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
            activityJobIDLabel.Location = new System.Drawing.Point(49, 336);
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
            activityNotesLabel.Location = new System.Drawing.Point(57, 365);
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
            activityTravelLabel.Location = new System.Drawing.Point(56, 231);
            activityTravelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            activityTravelLabel.Name = "activityTravelLabel";
            activityTravelLabel.Size = new System.Drawing.Size(54, 19);
            activityTravelLabel.TabIndex = 13;
            activityTravelLabel.Text = "Travel:";
            // 
            // activityContactIDTextBox
            // 
            this.activityContactIDTextBox.BackColor = System.Drawing.Color.LightGray;
            this.activityContactIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityBindingSource, "ActivityContactID", true));
            this.activityContactIDTextBox.Location = new System.Drawing.Point(127, 293);
            this.activityContactIDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.activityContactIDTextBox.Name = "activityContactIDTextBox";
            this.activityContactIDTextBox.ReadOnly = true;
            this.activityContactIDTextBox.Size = new System.Drawing.Size(117, 26);
            this.activityContactIDTextBox.TabIndex = 3;
            // 
            // activityBindingSource
            // 
            this.activityBindingSource.DataSource = typeof(SharpERBLL.Activity);
            // 
            // activityDateDateTimePicker
            // 
            this.activityDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.activityBindingSource, "ActivityDate", true));
            this.activityDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.activityDateDateTimePicker.Location = new System.Drawing.Point(127, 109);
            this.activityDateDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.activityDateDateTimePicker.Name = "activityDateDateTimePicker";
            this.activityDateDateTimePicker.Size = new System.Drawing.Size(130, 26);
            this.activityDateDateTimePicker.TabIndex = 0;
            // 
            // activityDescriptionTextBox
            // 
            this.activityDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityBindingSource, "ActivityDescription", true));
            this.activityDescriptionTextBox.Location = new System.Drawing.Point(127, 143);
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
            this.activityIDTextBox.Location = new System.Drawing.Point(464, 109);
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
            this.activityJobIDTextBox.Location = new System.Drawing.Point(127, 329);
            this.activityJobIDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.activityJobIDTextBox.Name = "activityJobIDTextBox";
            this.activityJobIDTextBox.ReadOnly = true;
            this.activityJobIDTextBox.Size = new System.Drawing.Size(117, 26);
            this.activityJobIDTextBox.TabIndex = 4;
            this.activityJobIDTextBox.TextChanged += new System.EventHandler(this.activityJobIDTextBox_TextChanged);
            // 
            // activityNotesTextBox
            // 
            this.activityNotesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityBindingSource, "ActivityNotes", true));
            this.activityNotesTextBox.Location = new System.Drawing.Point(127, 363);
            this.activityNotesTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.activityNotesTextBox.Multiline = true;
            this.activityNotesTextBox.Name = "activityNotesTextBox";
            this.activityNotesTextBox.Size = new System.Drawing.Size(454, 78);
            this.activityNotesTextBox.TabIndex = 5;
            // 
            // activityTravelComboBox
            // 
            this.activityTravelComboBox.BackColor = System.Drawing.Color.LightGray;
            this.activityTravelComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityBindingSource, "ActivityTravel", true));
            this.activityTravelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.activityTravelComboBox.FormattingEnabled = true;
            this.activityTravelComboBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.activityTravelComboBox.Location = new System.Drawing.Point(127, 229);
            this.activityTravelComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.activityTravelComboBox.Name = "activityTravelComboBox";
            this.activityTravelComboBox.Size = new System.Drawing.Size(72, 26);
            this.activityTravelComboBox.TabIndex = 2;
            // 
            // lblActivityInfoTitle
            // 
            this.lblActivityInfoTitle.AutoSize = true;
            this.lblActivityInfoTitle.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivityInfoTitle.ForeColor = System.Drawing.Color.MediumBlue;
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
            this.btnSave.Location = new System.Drawing.Point(382, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 43);
            this.btnSave.TabIndex = 61;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.HotPink;
            this.btnClear.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnClear.Location = new System.Drawing.Point(503, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 43);
            this.btnClear.TabIndex = 60;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.HotPink;
            this.btnCancel.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnCancel.Location = new System.Drawing.Point(623, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 43);
            this.btnCancel.TabIndex = 59;
            this.btnCancel.Text = "Exit";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // ActivityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(732, 535);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
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
            this.Controls.Add(this.activityTravelComboBox);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ActivityForm";
            this.Text = "Activity";
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource activityBindingSource;
        private System.Windows.Forms.TextBox activityContactIDTextBox;
        private System.Windows.Forms.DateTimePicker activityDateDateTimePicker;
        private System.Windows.Forms.TextBox activityDescriptionTextBox;
        private System.Windows.Forms.TextBox activityIDTextBox;
        private System.Windows.Forms.TextBox activityJobIDTextBox;
        private System.Windows.Forms.TextBox activityNotesTextBox;
        private System.Windows.Forms.ComboBox activityTravelComboBox;
        private System.Windows.Forms.Label lblActivityInfoTitle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancel;
    }
}