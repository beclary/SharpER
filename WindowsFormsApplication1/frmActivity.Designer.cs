namespace WindowsFormsApplication1
{
    partial class frmActivity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActivity));
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
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tstxtActivityDateField = new System.Windows.Forms.ToolStripTextBox();
            this.tsbtnSearchActivityDateButton = new System.Windows.Forms.ToolStripButton();
            this.lblActivityInfoTitle = new System.Windows.Forms.Label();
            this.lblActivityDate = new System.Windows.Forms.Label();
            this.lblActivityDescription = new System.Windows.Forms.Label();
            this.lblActivityID = new System.Windows.Forms.Label();
            this.lblActivityTravel = new System.Windows.Forms.Label();
            this.lblActivityJobIDForeignKey = new System.Windows.Forms.Label();
            this.lblActivityContactIDForeignKey = new System.Windows.Forms.Label();
            this.lblActivityNotes = new System.Windows.Forms.Label();
            this.txtActivityID = new System.Windows.Forms.TextBox();
            this.dtpActivityDate = new System.Windows.Forms.DateTimePicker();
            this.txtActivityDescription = new System.Windows.Forms.TextBox();
            this.txtActivityNotes = new System.Windows.Forms.TextBox();
            this.txtActivityJobIDForeignKey = new System.Windows.Forms.TextBox();
            this.txtActivityContactIDForeignKey = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.bindingNavigatorDeleteItem,
            this.saveToolStripButton,
            this.printToolStripButton,
            this.toolStripSeparator});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(732, 25);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Enabled = false;
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
            this.bindingNavigatorDeleteItem.Enabled = false;
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
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Enabled = false;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printToolStripButton.Text = "&Print";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightGray;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tstxtActivityDateField,
            this.tsbtnSearchActivityDateButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(732, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.DarkRed;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(88, 22);
            this.toolStripLabel1.Text = "Activity Date:";
            // 
            // tstxtActivityDateField
            // 
            this.tstxtActivityDateField.BackColor = System.Drawing.Color.LemonChiffon;
            this.tstxtActivityDateField.Name = "tstxtActivityDateField";
            this.tstxtActivityDateField.Size = new System.Drawing.Size(100, 25);
            // 
            // tsbtnSearchActivityDateButton
            // 
            this.tsbtnSearchActivityDateButton.BackColor = System.Drawing.Color.SandyBrown;
            this.tsbtnSearchActivityDateButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnSearchActivityDateButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnSearchActivityDateButton.ForeColor = System.Drawing.Color.DarkRed;
            this.tsbtnSearchActivityDateButton.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSearchActivityDateButton.Image")));
            this.tsbtnSearchActivityDateButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSearchActivityDateButton.Name = "tsbtnSearchActivityDateButton";
            this.tsbtnSearchActivityDateButton.Size = new System.Drawing.Size(52, 22);
            this.tsbtnSearchActivityDateButton.Text = "Search";
            // 
            // lblActivityInfoTitle
            // 
            this.lblActivityInfoTitle.AutoSize = true;
            this.lblActivityInfoTitle.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivityInfoTitle.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblActivityInfoTitle.Location = new System.Drawing.Point(3, 50);
            this.lblActivityInfoTitle.Name = "lblActivityInfoTitle";
            this.lblActivityInfoTitle.Size = new System.Drawing.Size(278, 43);
            this.lblActivityInfoTitle.TabIndex = 37;
            this.lblActivityInfoTitle.Text = "Activity Information";
            // 
            // lblActivityDate
            // 
            this.lblActivityDate.AutoSize = true;
            this.lblActivityDate.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivityDate.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblActivityDate.Location = new System.Drawing.Point(66, 112);
            this.lblActivityDate.Name = "lblActivityDate";
            this.lblActivityDate.Size = new System.Drawing.Size(44, 19);
            this.lblActivityDate.TabIndex = 42;
            this.lblActivityDate.Text = "Date:";
            // 
            // lblActivityDescription
            // 
            this.lblActivityDescription.AutoSize = true;
            this.lblActivityDescription.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivityDescription.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblActivityDescription.Location = new System.Drawing.Point(25, 145);
            this.lblActivityDescription.Name = "lblActivityDescription";
            this.lblActivityDescription.Size = new System.Drawing.Size(85, 19);
            this.lblActivityDescription.TabIndex = 43;
            this.lblActivityDescription.Text = "Description:";
            // 
            // lblActivityID
            // 
            this.lblActivityID.AutoSize = true;
            this.lblActivityID.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivityID.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblActivityID.Location = new System.Drawing.Point(382, 113);
            this.lblActivityID.Name = "lblActivityID";
            this.lblActivityID.Size = new System.Drawing.Size(87, 19);
            this.lblActivityID.TabIndex = 44;
            this.lblActivityID.Text = "Activity ID:";
            // 
            // lblActivityTravel
            // 
            this.lblActivityTravel.AutoSize = true;
            this.lblActivityTravel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivityTravel.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblActivityTravel.Location = new System.Drawing.Point(56, 238);
            this.lblActivityTravel.Name = "lblActivityTravel";
            this.lblActivityTravel.Size = new System.Drawing.Size(54, 19);
            this.lblActivityTravel.TabIndex = 45;
            this.lblActivityTravel.Text = "Travel:";
            // 
            // lblActivityJobIDForeignKey
            // 
            this.lblActivityJobIDForeignKey.AutoSize = true;
            this.lblActivityJobIDForeignKey.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivityJobIDForeignKey.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblActivityJobIDForeignKey.Location = new System.Drawing.Point(49, 286);
            this.lblActivityJobIDForeignKey.Name = "lblActivityJobIDForeignKey";
            this.lblActivityJobIDForeignKey.Size = new System.Drawing.Size(61, 19);
            this.lblActivityJobIDForeignKey.TabIndex = 46;
            this.lblActivityJobIDForeignKey.Text = "Job ID:";
            // 
            // lblActivityContactIDForeignKey
            // 
            this.lblActivityContactIDForeignKey.AutoSize = true;
            this.lblActivityContactIDForeignKey.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivityContactIDForeignKey.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblActivityContactIDForeignKey.Location = new System.Drawing.Point(25, 318);
            this.lblActivityContactIDForeignKey.Name = "lblActivityContactIDForeignKey";
            this.lblActivityContactIDForeignKey.Size = new System.Drawing.Size(85, 19);
            this.lblActivityContactIDForeignKey.TabIndex = 47;
            this.lblActivityContactIDForeignKey.Text = "Contact ID:";
            // 
            // lblActivityNotes
            // 
            this.lblActivityNotes.AutoSize = true;
            this.lblActivityNotes.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivityNotes.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblActivityNotes.Location = new System.Drawing.Point(58, 347);
            this.lblActivityNotes.Name = "lblActivityNotes";
            this.lblActivityNotes.Size = new System.Drawing.Size(52, 19);
            this.lblActivityNotes.TabIndex = 48;
            this.lblActivityNotes.Text = "Notes:";
            // 
            // txtActivityID
            // 
            this.txtActivityID.BackColor = System.Drawing.Color.LightGray;
            this.txtActivityID.Cursor = System.Windows.Forms.Cursors.No;
            this.txtActivityID.Location = new System.Drawing.Point(475, 110);
            this.txtActivityID.Name = "txtActivityID";
            this.txtActivityID.ReadOnly = true;
            this.txtActivityID.Size = new System.Drawing.Size(100, 26);
            this.txtActivityID.TabIndex = 49;
            // 
            // dtpActivityDate
            // 
            this.dtpActivityDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpActivityDate.Location = new System.Drawing.Point(117, 110);
            this.dtpActivityDate.Name = "dtpActivityDate";
            this.dtpActivityDate.Size = new System.Drawing.Size(116, 26);
            this.dtpActivityDate.TabIndex = 50;
            // 
            // txtActivityDescription
            // 
            this.txtActivityDescription.Location = new System.Drawing.Point(117, 143);
            this.txtActivityDescription.Multiline = true;
            this.txtActivityDescription.Name = "txtActivityDescription";
            this.txtActivityDescription.Size = new System.Drawing.Size(454, 78);
            this.txtActivityDescription.TabIndex = 51;
            // 
            // txtActivityNotes
            // 
            this.txtActivityNotes.Location = new System.Drawing.Point(116, 347);
            this.txtActivityNotes.Multiline = true;
            this.txtActivityNotes.Name = "txtActivityNotes";
            this.txtActivityNotes.Size = new System.Drawing.Size(454, 78);
            this.txtActivityNotes.TabIndex = 52;
            // 
            // txtActivityJobIDForeignKey
            // 
            this.txtActivityJobIDForeignKey.BackColor = System.Drawing.Color.LightGray;
            this.txtActivityJobIDForeignKey.Cursor = System.Windows.Forms.Cursors.No;
            this.txtActivityJobIDForeignKey.Location = new System.Drawing.Point(116, 284);
            this.txtActivityJobIDForeignKey.Name = "txtActivityJobIDForeignKey";
            this.txtActivityJobIDForeignKey.ReadOnly = true;
            this.txtActivityJobIDForeignKey.Size = new System.Drawing.Size(100, 26);
            this.txtActivityJobIDForeignKey.TabIndex = 53;
            // 
            // txtActivityContactIDForeignKey
            // 
            this.txtActivityContactIDForeignKey.BackColor = System.Drawing.Color.LightGray;
            this.txtActivityContactIDForeignKey.Cursor = System.Windows.Forms.Cursors.No;
            this.txtActivityContactIDForeignKey.Location = new System.Drawing.Point(116, 316);
            this.txtActivityContactIDForeignKey.Name = "txtActivityContactIDForeignKey";
            this.txtActivityContactIDForeignKey.ReadOnly = true;
            this.txtActivityContactIDForeignKey.Size = new System.Drawing.Size(100, 26);
            this.txtActivityContactIDForeignKey.TabIndex = 54;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBox1.Location = new System.Drawing.Point(116, 234);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(59, 26);
            this.comboBox1.TabIndex = 55;
            // 
            // frmActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(732, 535);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtActivityContactIDForeignKey);
            this.Controls.Add(this.txtActivityJobIDForeignKey);
            this.Controls.Add(this.txtActivityNotes);
            this.Controls.Add(this.txtActivityDescription);
            this.Controls.Add(this.dtpActivityDate);
            this.Controls.Add(this.txtActivityID);
            this.Controls.Add(this.lblActivityNotes);
            this.Controls.Add(this.lblActivityContactIDForeignKey);
            this.Controls.Add(this.lblActivityJobIDForeignKey);
            this.Controls.Add(this.lblActivityTravel);
            this.Controls.Add(this.lblActivityID);
            this.Controls.Add(this.lblActivityDescription);
            this.Controls.Add(this.lblActivityDate);
            this.Controls.Add(this.lblActivityInfoTitle);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.bindingNavigator1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmActivity";
            this.Text = "Activity";
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tstxtActivityDateField;
        private System.Windows.Forms.ToolStripButton tsbtnSearchActivityDateButton;
        private System.Windows.Forms.Label lblActivityInfoTitle;
        private System.Windows.Forms.Label lblActivityDate;
        private System.Windows.Forms.Label lblActivityDescription;
        private System.Windows.Forms.Label lblActivityID;
        private System.Windows.Forms.Label lblActivityTravel;
        private System.Windows.Forms.Label lblActivityJobIDForeignKey;
        private System.Windows.Forms.Label lblActivityContactIDForeignKey;
        private System.Windows.Forms.Label lblActivityNotes;
        private System.Windows.Forms.TextBox txtActivityID;
        private System.Windows.Forms.DateTimePicker dtpActivityDate;
        private System.Windows.Forms.TextBox txtActivityDescription;
        private System.Windows.Forms.TextBox txtActivityNotes;
        private System.Windows.Forms.TextBox txtActivityJobIDForeignKey;
        private System.Windows.Forms.TextBox txtActivityContactIDForeignKey;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}