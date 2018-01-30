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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivityForm));
            this.activityBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.activityContactIDTextBox = new System.Windows.Forms.TextBox();
            this.activityDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.activityDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.activityIDTextBox = new System.Windows.Forms.TextBox();
            this.activityJobIDTextBox = new System.Windows.Forms.TextBox();
            this.activityNotesTextBox = new System.Windows.Forms.TextBox();
            this.activityTravelComboBox = new System.Windows.Forms.ComboBox();
            this.lblActivityInfoTitle = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelActivityDateLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxActivityDateTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonActivityDateButton = new System.Windows.Forms.ToolStripButton();
            this.activityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            activityContactIDLabel = new System.Windows.Forms.Label();
            activityDateLabel = new System.Windows.Forms.Label();
            activityDescriptionLabel = new System.Windows.Forms.Label();
            activityIDLabel = new System.Windows.Forms.Label();
            activityJobIDLabel = new System.Windows.Forms.Label();
            activityNotesLabel = new System.Windows.Forms.Label();
            activityTravelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingNavigator)).BeginInit();
            this.activityBindingNavigator.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // activityBindingNavigator
            // 
            this.activityBindingNavigator.AddNewItem = null;
            this.activityBindingNavigator.BindingSource = this.activityBindingSource;
            this.activityBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.activityBindingNavigator.DeleteItem = null;
            this.activityBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.activityBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.activityBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.activityBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.activityBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.activityBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.activityBindingNavigator.Name = "activityBindingNavigator";
            this.activityBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.activityBindingNavigator.Size = new System.Drawing.Size(732, 25);
            this.activityBindingNavigator.TabIndex = 0;
            this.activityBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // activityContactIDTextBox
            // 
            this.activityContactIDTextBox.BackColor = System.Drawing.Color.LightGray;
            this.activityContactIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityBindingSource, "ActivityContactID", true));
            this.activityContactIDTextBox.Location = new System.Drawing.Point(127, 293);
            this.activityContactIDTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.activityContactIDTextBox.Name = "activityContactIDTextBox";
            this.activityContactIDTextBox.ReadOnly = true;
            this.activityContactIDTextBox.Size = new System.Drawing.Size(117, 26);
            this.activityContactIDTextBox.TabIndex = 2;
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
            // activityDateDateTimePicker
            // 
            this.activityDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.activityBindingSource, "ActivityDate", true));
            this.activityDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.activityDateDateTimePicker.Location = new System.Drawing.Point(127, 109);
            this.activityDateDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.activityDateDateTimePicker.Name = "activityDateDateTimePicker";
            this.activityDateDateTimePicker.Size = new System.Drawing.Size(130, 26);
            this.activityDateDateTimePicker.TabIndex = 4;
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
            // activityDescriptionTextBox
            // 
            this.activityDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityBindingSource, "ActivityDescription", true));
            this.activityDescriptionTextBox.Location = new System.Drawing.Point(127, 143);
            this.activityDescriptionTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.activityDescriptionTextBox.Multiline = true;
            this.activityDescriptionTextBox.Name = "activityDescriptionTextBox";
            this.activityDescriptionTextBox.Size = new System.Drawing.Size(454, 78);
            this.activityDescriptionTextBox.TabIndex = 6;
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
            // activityIDTextBox
            // 
            this.activityIDTextBox.BackColor = System.Drawing.Color.LightGray;
            this.activityIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityBindingSource, "ActivityID", true));
            this.activityIDTextBox.Location = new System.Drawing.Point(464, 109);
            this.activityIDTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.activityIDTextBox.Name = "activityIDTextBox";
            this.activityIDTextBox.ReadOnly = true;
            this.activityIDTextBox.Size = new System.Drawing.Size(117, 26);
            this.activityIDTextBox.TabIndex = 8;
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
            // activityJobIDTextBox
            // 
            this.activityJobIDTextBox.BackColor = System.Drawing.Color.LightGray;
            this.activityJobIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityBindingSource, "ActivityJobID", true));
            this.activityJobIDTextBox.Location = new System.Drawing.Point(127, 329);
            this.activityJobIDTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.activityJobIDTextBox.Name = "activityJobIDTextBox";
            this.activityJobIDTextBox.ReadOnly = true;
            this.activityJobIDTextBox.Size = new System.Drawing.Size(117, 26);
            this.activityJobIDTextBox.TabIndex = 10;
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
            // activityNotesTextBox
            // 
            this.activityNotesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityBindingSource, "ActivityNotes", true));
            this.activityNotesTextBox.Location = new System.Drawing.Point(127, 363);
            this.activityNotesTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.activityNotesTextBox.Multiline = true;
            this.activityNotesTextBox.Name = "activityNotesTextBox";
            this.activityNotesTextBox.Size = new System.Drawing.Size(454, 78);
            this.activityNotesTextBox.TabIndex = 12;
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
            this.activityTravelComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.activityTravelComboBox.Name = "activityTravelComboBox";
            this.activityTravelComboBox.Size = new System.Drawing.Size(72, 26);
            this.activityTravelComboBox.TabIndex = 14;
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
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightGray;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelActivityDateLabel,
            this.toolStripTextBoxActivityDateTextBox,
            this.toolStripButtonActivityDateButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(732, 25);
            this.toolStrip1.TabIndex = 39;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabelActivityDateLabel
            // 
            this.toolStripLabelActivityDateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabelActivityDateLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.toolStripLabelActivityDateLabel.Name = "toolStripLabelActivityDateLabel";
            this.toolStripLabelActivityDateLabel.Size = new System.Drawing.Size(178, 22);
            this.toolStripLabelActivityDateLabel.Text = "Activity Date (mm/dd/yyyy):";
            // 
            // toolStripTextBoxActivityDateTextBox
            // 
            this.toolStripTextBoxActivityDateTextBox.Name = "toolStripTextBoxActivityDateTextBox";
            this.toolStripTextBoxActivityDateTextBox.Size = new System.Drawing.Size(132, 25);
            // 
            // toolStripButtonActivityDateButton
            // 
            this.toolStripButtonActivityDateButton.BackColor = System.Drawing.Color.SandyBrown;
            this.toolStripButtonActivityDateButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonActivityDateButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonActivityDateButton.ForeColor = System.Drawing.Color.DarkRed;
            this.toolStripButtonActivityDateButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonActivityDateButton.Image")));
            this.toolStripButtonActivityDateButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonActivityDateButton.Name = "toolStripButtonActivityDateButton";
            this.toolStripButtonActivityDateButton.Size = new System.Drawing.Size(52, 22);
            this.toolStripButtonActivityDateButton.Text = "Search";
            // 
            // activityBindingSource
            // 
            this.activityBindingSource.DataSource = typeof(SharpERBLL.Activity);
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
            // ActivityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(732, 535);
            this.Controls.Add(this.toolStrip1);
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
            this.Controls.Add(this.activityBindingNavigator);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ActivityForm";
            this.Text = "Activity";
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingNavigator)).EndInit();
            this.activityBindingNavigator.ResumeLayout(false);
            this.activityBindingNavigator.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource activityBindingSource;
        private System.Windows.Forms.BindingNavigator activityBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox activityContactIDTextBox;
        private System.Windows.Forms.DateTimePicker activityDateDateTimePicker;
        private System.Windows.Forms.TextBox activityDescriptionTextBox;
        private System.Windows.Forms.TextBox activityIDTextBox;
        private System.Windows.Forms.TextBox activityJobIDTextBox;
        private System.Windows.Forms.TextBox activityNotesTextBox;
        private System.Windows.Forms.ComboBox activityTravelComboBox;
        private System.Windows.Forms.Label lblActivityInfoTitle;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabelActivityDateLabel;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxActivityDateTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButtonActivityDateButton;
    }
}