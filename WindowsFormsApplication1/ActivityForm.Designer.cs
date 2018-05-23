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
            System.Windows.Forms.Label lblActivityContactFirstName;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivityForm));
            this.activityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activityDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.activityDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.activityIDTextBox = new System.Windows.Forms.TextBox();
            this.activityNotesTextBox = new System.Windows.Forms.TextBox();
            this.lblActivityInfoTitle = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.activityTravelComboBox1 = new System.Windows.Forms.ComboBox();
            this.activityContactIDComboBox = new System.Windows.Forms.ComboBox();
            this.contactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddNew = new System.Windows.Forms.Button();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            activityDateLabel = new System.Windows.Forms.Label();
            activityDescriptionLabel = new System.Windows.Forms.Label();
            activityIDLabel = new System.Windows.Forms.Label();
            activityNotesLabel = new System.Windows.Forms.Label();
            activityTravelLabel = new System.Windows.Forms.Label();
            lblActivityContactFirstName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // activityDateLabel
            // 
            activityDateLabel.AutoSize = true;
            activityDateLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            activityDateLabel.ForeColor = System.Drawing.Color.DarkBlue;
            activityDateLabel.Location = new System.Drawing.Point(110, 108);
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
            activityDescriptionLabel.Location = new System.Drawing.Point(69, 138);
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
            activityNotesLabel.Location = new System.Drawing.Point(102, 319);
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
            activityTravelLabel.TabIndex = 9;
            activityTravelLabel.Text = "Traveled:";
            // 
            // lblActivityContactFirstName
            // 
            lblActivityContactFirstName.AutoSize = true;
            lblActivityContactFirstName.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblActivityContactFirstName.ForeColor = System.Drawing.Color.DarkBlue;
            lblActivityContactFirstName.Location = new System.Drawing.Point(2, 254);
            lblActivityContactFirstName.Name = "lblActivityContactFirstName";
            lblActivityContactFirstName.Size = new System.Drawing.Size(152, 19);
            lblActivityContactFirstName.TabIndex = 10;
            lblActivityContactFirstName.Text = "Contact\'s First Name:";
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
            this.activityIDTextBox.TabIndex = 13;
            // 
            // activityNotesTextBox
            // 
            this.activityNotesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityBindingSource, "ActivityNotes", true));
            this.activityNotesTextBox.Location = new System.Drawing.Point(160, 319);
            this.activityNotesTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.activityNotesTextBox.Multiline = true;
            this.activityNotesTextBox.Name = "activityNotesTextBox";
            this.activityNotesTextBox.Size = new System.Drawing.Size(454, 78);
            this.activityNotesTextBox.TabIndex = 5;
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
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel / Exit";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // activityTravelComboBox1
            // 
            this.activityTravelComboBox1.BackColor = System.Drawing.Color.LightGray;
            this.activityTravelComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityBindingSource, "ActivityTravel", true));
            this.activityTravelComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.activityBindingSource, "ActivityTravel", true));
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
            this.activityContactIDComboBox.Location = new System.Drawing.Point(161, 252);
            this.activityContactIDComboBox.Name = "activityContactIDComboBox";
            this.activityContactIDComboBox.Size = new System.Drawing.Size(117, 26);
            this.activityContactIDComboBox.TabIndex = 3;
            this.activityContactIDComboBox.ValueMember = "ContactID";
            // 
            // contactBindingSource
            // 
            this.contactBindingSource.DataSource = typeof(SharpERBLL.Contact);
            // 
            // jobBindingSource
            // 
            this.jobBindingSource.DataSource = typeof(SharpERBLL.Job);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddNew.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.btnAddNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAddNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAddNew.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnAddNew.Location = new System.Drawing.Point(284, 252);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(141, 27);
            this.btnAddNew.TabIndex = 16;
            this.btnAddNew.Text = "Add New Contact";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(740, 25);
            this.bindingNavigator1.TabIndex = 17;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ActivityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(740, 472);
            this.ControlBox = false;
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(lblActivityContactFirstName);
            this.Controls.Add(this.activityContactIDComboBox);
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
            this.Text = "Activity";
            this.Load += new System.EventHandler(this.ActivityForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
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
        private System.Windows.Forms.ComboBox activityContactIDComboBox;
        private System.Windows.Forms.BindingSource contactBindingSource;
        private System.Windows.Forms.BindingSource jobBindingSource;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    }
}