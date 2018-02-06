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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobForm));
            this.lblJobInfoTitle = new System.Windows.Forms.Label();
            this.jobBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.jobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.jobAppliedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.jobCompanyIDTextBox = new System.Windows.Forms.TextBox();
            this.jobContactIDTextBox = new System.Windows.Forms.TextBox();
            this.jobIDTextBox = new System.Windows.Forms.TextBox();
            this.jobNotesTextBox = new System.Windows.Forms.TextBox();
            this.jobPayTextBox = new System.Windows.Forms.TextBox();
            this.jobPositionTextBox = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelJobPositionLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxJobPositionTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonJobSearchButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonJobExitButton = new System.Windows.Forms.ToolStripButton();
            this.lblSalaryPerYear = new System.Windows.Forms.Label();
            jobAppliedLabel = new System.Windows.Forms.Label();
            jobCompanyIDLabel = new System.Windows.Forms.Label();
            jobContactIDLabel = new System.Windows.Forms.Label();
            jobIDLabel = new System.Windows.Forms.Label();
            jobNotesLabel = new System.Windows.Forms.Label();
            jobPayLabel = new System.Windows.Forms.Label();
            jobPositionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingNavigator)).BeginInit();
            this.jobBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // jobAppliedLabel
            // 
            jobAppliedLabel.AutoSize = true;
            jobAppliedLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            jobAppliedLabel.ForeColor = System.Drawing.Color.DarkBlue;
            jobAppliedLabel.Location = new System.Drawing.Point(47, 145);
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
            jobCompanyIDLabel.Location = new System.Drawing.Point(38, 265);
            jobCompanyIDLabel.Name = "jobCompanyIDLabel";
            jobCompanyIDLabel.Size = new System.Drawing.Size(90, 19);
            jobCompanyIDLabel.TabIndex = 42;
            jobCompanyIDLabel.Text = "Company ID:";
            // 
            // jobContactIDLabel
            // 
            jobContactIDLabel.AutoSize = true;
            jobContactIDLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            jobContactIDLabel.ForeColor = System.Drawing.Color.DarkBlue;
            jobContactIDLabel.Location = new System.Drawing.Point(43, 297);
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
            jobIDLabel.Location = new System.Drawing.Point(445, 112);
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
            jobNotesLabel.Location = new System.Drawing.Point(76, 359);
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
            jobPayLabel.Location = new System.Drawing.Point(38, 204);
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
            jobPositionLabel.Location = new System.Drawing.Point(66, 112);
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
            this.lblJobInfoTitle.Location = new System.Drawing.Point(1, 50);
            this.lblJobInfoTitle.Name = "lblJobInfoTitle";
            this.lblJobInfoTitle.Size = new System.Drawing.Size(220, 43);
            this.lblJobInfoTitle.TabIndex = 39;
            this.lblJobInfoTitle.Text = "Job Information";
            this.lblJobInfoTitle.Click += new System.EventHandler(this.lblJobInfoTitle_Click);
            // 
            // jobBindingNavigator
            // 
            this.jobBindingNavigator.AddNewItem = null;
            this.jobBindingNavigator.BindingSource = this.jobBindingSource;
            this.jobBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.jobBindingNavigator.DeleteItem = null;
            this.jobBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.cutToolStripButton,
            this.toolStripSeparator1,
            this.printToolStripButton1,
            this.toolStripSeparator2});
            this.jobBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.jobBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.jobBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.jobBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.jobBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.jobBindingNavigator.Name = "jobBindingNavigator";
            this.jobBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.jobBindingNavigator.Size = new System.Drawing.Size(732, 25);
            this.jobBindingNavigator.TabIndex = 40;
            this.jobBindingNavigator.Text = "bindingNavigator1";
            // 
            // jobBindingSource
            // 
            this.jobBindingSource.DataSource = typeof(SharpERBLL.Job);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "&New";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = global::WindowsFormsApplication1.Properties.Resources.deletered3;
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.cutToolStripButton.Text = "C&ut";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // printToolStripButton1
            // 
            this.printToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton1.Image")));
            this.printToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton1.Name = "printToolStripButton1";
            this.printToolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.printToolStripButton1.Text = "&Print";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // jobAppliedDateTimePicker
            // 
            this.jobAppliedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.jobBindingSource, "JobApplied", true));
            this.jobAppliedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.jobAppliedDateTimePicker.Location = new System.Drawing.Point(135, 142);
            this.jobAppliedDateTimePicker.Name = "jobAppliedDateTimePicker";
            this.jobAppliedDateTimePicker.Size = new System.Drawing.Size(130, 26);
            this.jobAppliedDateTimePicker.TabIndex = 1;
            // 
            // jobCompanyIDTextBox
            // 
            this.jobCompanyIDTextBox.BackColor = System.Drawing.Color.LightGray;
            this.jobCompanyIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobBindingSource, "JobCompanyID", true));
            this.jobCompanyIDTextBox.Location = new System.Drawing.Point(134, 263);
            this.jobCompanyIDTextBox.Name = "jobCompanyIDTextBox";
            this.jobCompanyIDTextBox.ReadOnly = true;
            this.jobCompanyIDTextBox.Size = new System.Drawing.Size(117, 26);
            this.jobCompanyIDTextBox.TabIndex = 3;
            // 
            // jobContactIDTextBox
            // 
            this.jobContactIDTextBox.BackColor = System.Drawing.Color.LightGray;
            this.jobContactIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobBindingSource, "JobContactID", true));
            this.jobContactIDTextBox.Location = new System.Drawing.Point(134, 295);
            this.jobContactIDTextBox.Name = "jobContactIDTextBox";
            this.jobContactIDTextBox.ReadOnly = true;
            this.jobContactIDTextBox.Size = new System.Drawing.Size(117, 26);
            this.jobContactIDTextBox.TabIndex = 4;
            // 
            // jobIDTextBox
            // 
            this.jobIDTextBox.BackColor = System.Drawing.Color.LightGray;
            this.jobIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobBindingSource, "JobID", true));
            this.jobIDTextBox.Location = new System.Drawing.Point(512, 110);
            this.jobIDTextBox.Name = "jobIDTextBox";
            this.jobIDTextBox.ReadOnly = true;
            this.jobIDTextBox.Size = new System.Drawing.Size(117, 26);
            this.jobIDTextBox.TabIndex = 47;
            // 
            // jobNotesTextBox
            // 
            this.jobNotesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobBindingSource, "JobNotes", true));
            this.jobNotesTextBox.Location = new System.Drawing.Point(134, 357);
            this.jobNotesTextBox.Multiline = true;
            this.jobNotesTextBox.Name = "jobNotesTextBox";
            this.jobNotesTextBox.Size = new System.Drawing.Size(454, 78);
            this.jobNotesTextBox.TabIndex = 5;
            // 
            // jobPayTextBox
            // 
            this.jobPayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobBindingSource, "JobPay", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.jobPayTextBox.Location = new System.Drawing.Point(135, 202);
            this.jobPayTextBox.Name = "jobPayTextBox";
            this.jobPayTextBox.Size = new System.Drawing.Size(130, 26);
            this.jobPayTextBox.TabIndex = 2;
            // 
            // jobPositionTextBox
            // 
            this.jobPositionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobBindingSource, "JobPosition", true));
            this.jobPositionTextBox.Location = new System.Drawing.Point(135, 110);
            this.jobPositionTextBox.Name = "jobPositionTextBox";
            this.jobPositionTextBox.Size = new System.Drawing.Size(283, 26);
            this.jobPositionTextBox.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightGray;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelJobPositionLabel,
            this.toolStripTextBoxJobPositionTextBox,
            this.toolStripButtonJobSearchButton,
            this.toolStripSeparator3,
            this.toolStripButtonJobExitButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(732, 25);
            this.toolStrip1.TabIndex = 54;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabelJobPositionLabel
            // 
            this.toolStripLabelJobPositionLabel.BackColor = System.Drawing.Color.LightGray;
            this.toolStripLabelJobPositionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabelJobPositionLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.toolStripLabelJobPositionLabel.Name = "toolStripLabelJobPositionLabel";
            this.toolStripLabelJobPositionLabel.Size = new System.Drawing.Size(60, 22);
            this.toolStripLabelJobPositionLabel.Text = "Position:";
            // 
            // toolStripTextBoxJobPositionTextBox
            // 
            this.toolStripTextBoxJobPositionTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.toolStripTextBoxJobPositionTextBox.Name = "toolStripTextBoxJobPositionTextBox";
            this.toolStripTextBoxJobPositionTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripButtonJobSearchButton
            // 
            this.toolStripButtonJobSearchButton.BackColor = System.Drawing.Color.SandyBrown;
            this.toolStripButtonJobSearchButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonJobSearchButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonJobSearchButton.ForeColor = System.Drawing.Color.DarkRed;
            this.toolStripButtonJobSearchButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonJobSearchButton.Image")));
            this.toolStripButtonJobSearchButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonJobSearchButton.Name = "toolStripButtonJobSearchButton";
            this.toolStripButtonJobSearchButton.Size = new System.Drawing.Size(52, 22);
            this.toolStripButtonJobSearchButton.Text = "Search";
            this.toolStripButtonJobSearchButton.Click += new System.EventHandler(this.toolStripButtonJobSearchButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonJobExitButton
            // 
            this.toolStripButtonJobExitButton.BackColor = System.Drawing.Color.Gold;
            this.toolStripButtonJobExitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonJobExitButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonJobExitButton.ForeColor = System.Drawing.Color.DarkRed;
            this.toolStripButtonJobExitButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonJobExitButton.Image")));
            this.toolStripButtonJobExitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonJobExitButton.Name = "toolStripButtonJobExitButton";
            this.toolStripButtonJobExitButton.Size = new System.Drawing.Size(35, 22);
            this.toolStripButtonJobExitButton.Text = "Exit";
            this.toolStripButtonJobExitButton.Click += new System.EventHandler(this.toolStripButtonJobExitButton_Click);
            // 
            // lblSalaryPerYear
            // 
            this.lblSalaryPerYear.AutoSize = true;
            this.lblSalaryPerYear.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalaryPerYear.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblSalaryPerYear.Location = new System.Drawing.Point(28, 223);
            this.lblSalaryPerYear.Name = "lblSalaryPerYear";
            this.lblSalaryPerYear.Size = new System.Drawing.Size(107, 16);
            this.lblSalaryPerYear.TabIndex = 55;
            this.lblSalaryPerYear.Text = "( salary per year )";
            // 
            // JobForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(732, 535);
            this.Controls.Add(this.lblSalaryPerYear);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(jobAppliedLabel);
            this.Controls.Add(this.jobAppliedDateTimePicker);
            this.Controls.Add(jobCompanyIDLabel);
            this.Controls.Add(this.jobCompanyIDTextBox);
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
            this.Controls.Add(this.jobBindingNavigator);
            this.Controls.Add(this.lblJobInfoTitle);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "JobForm";
            this.Text = "Job";
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingNavigator)).EndInit();
            this.jobBindingNavigator.ResumeLayout(false);
            this.jobBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJobInfoTitle;
        private System.Windows.Forms.BindingSource jobBindingSource;
        private System.Windows.Forms.BindingNavigator jobBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DateTimePicker jobAppliedDateTimePicker;
        private System.Windows.Forms.TextBox jobCompanyIDTextBox;
        private System.Windows.Forms.TextBox jobContactIDTextBox;
        private System.Windows.Forms.TextBox jobIDTextBox;
        private System.Windows.Forms.TextBox jobNotesTextBox;
        private System.Windows.Forms.TextBox jobPayTextBox;
        private System.Windows.Forms.TextBox jobPositionTextBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabelJobPositionLabel;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxJobPositionTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButtonJobSearchButton;
        private System.Windows.Forms.Label lblSalaryPerYear;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton printToolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonJobExitButton;
    }
}