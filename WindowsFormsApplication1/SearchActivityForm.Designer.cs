﻿namespace WindowsFormsApplication1
{
    partial class SearchActivityForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchActivityForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblActivityTitle = new System.Windows.Forms.Label();
            this.lblSelectingActivity = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdateModifyActivity = new System.Windows.Forms.Button();
            this.btnDeleteActivity = new System.Windows.Forms.Button();
            this.btnAddNewActivity = new System.Windows.Forms.Button();
            this.activityDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActivityTravel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActivityContactID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActivityNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpActivityDisplayResults = new System.Windows.Forms.GroupBox();
            this.chkDateActivity = new System.Windows.Forms.CheckBox();
            this.lblDispResuSelctAct = new System.Windows.Forms.Label();
            this.chkActivityDescription = new System.Windows.Forms.CheckBox();
            this.btnResetActivityGridview = new System.Windows.Forms.Button();
            this.btnSearchActivityDescription = new System.Windows.Forms.Button();
            this.btnSearchActivityDate = new System.Windows.Forms.Button();
            this.txtActivityDescription = new System.Windows.Forms.TextBox();
            this.lblSearchActivityDescriptionInst = new System.Windows.Forms.Label();
            this.lblSearchActivityDateInst = new System.Windows.Forms.Label();
            this.mtbActivityDate = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.activityDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).BeginInit();
            this.grpActivityDisplayResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblActivityTitle
            // 
            this.lblActivityTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblActivityTitle.Font = new System.Drawing.Font("Goudy Old Style", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivityTitle.ForeColor = System.Drawing.Color.Indigo;
            this.lblActivityTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblActivityTitle.Location = new System.Drawing.Point(24, 12);
            this.lblActivityTitle.Name = "lblActivityTitle";
            this.lblActivityTitle.Size = new System.Drawing.Size(522, 51);
            this.lblActivityTitle.TabIndex = 22;
            this.lblActivityTitle.Text = "Search Activity Form";
            this.lblActivityTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSelectingActivity
            // 
            this.lblSelectingActivity.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectingActivity.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSelectingActivity.Location = new System.Drawing.Point(27, 63);
            this.lblSelectingActivity.Name = "lblSelectingActivity";
            this.lblSelectingActivity.Size = new System.Drawing.Size(519, 134);
            this.lblSelectingActivity.TabIndex = 23;
            this.lblSelectingActivity.Text = resources.GetString("lblSelectingActivity.Text");
            this.lblSelectingActivity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Yellow;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.Font = new System.Drawing.Font("Wide Latin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(579, 18);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(154, 51);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "E X I T";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdateModifyActivity
            // 
            this.btnUpdateModifyActivity.BackColor = System.Drawing.Color.Goldenrod;
            this.btnUpdateModifyActivity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdateModifyActivity.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateModifyActivity.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnUpdateModifyActivity.Location = new System.Drawing.Point(579, 205);
            this.btnUpdateModifyActivity.Name = "btnUpdateModifyActivity";
            this.btnUpdateModifyActivity.Size = new System.Drawing.Size(154, 51);
            this.btnUpdateModifyActivity.TabIndex = 25;
            this.btnUpdateModifyActivity.Text = "View / Modify Activity";
            this.btnUpdateModifyActivity.UseVisualStyleBackColor = false;
            this.btnUpdateModifyActivity.Click += new System.EventHandler(this.btnUpdateModifyActivity_Click);
            // 
            // btnDeleteActivity
            // 
            this.btnDeleteActivity.BackColor = System.Drawing.Color.Goldenrod;
            this.btnDeleteActivity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteActivity.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteActivity.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnDeleteActivity.Location = new System.Drawing.Point(579, 262);
            this.btnDeleteActivity.Name = "btnDeleteActivity";
            this.btnDeleteActivity.Size = new System.Drawing.Size(154, 51);
            this.btnDeleteActivity.TabIndex = 26;
            this.btnDeleteActivity.Text = "Delete Activity";
            this.btnDeleteActivity.UseVisualStyleBackColor = false;
            this.btnDeleteActivity.Click += new System.EventHandler(this.btnDeleteActivity_Click);
            // 
            // btnAddNewActivity
            // 
            this.btnAddNewActivity.BackColor = System.Drawing.Color.Teal;
            this.btnAddNewActivity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNewActivity.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewActivity.ForeColor = System.Drawing.Color.Yellow;
            this.btnAddNewActivity.Location = new System.Drawing.Point(579, 319);
            this.btnAddNewActivity.Name = "btnAddNewActivity";
            this.btnAddNewActivity.Size = new System.Drawing.Size(154, 51);
            this.btnAddNewActivity.TabIndex = 27;
            this.btnAddNewActivity.Text = "Add New Activity";
            this.btnAddNewActivity.UseVisualStyleBackColor = false;
            this.btnAddNewActivity.Click += new System.EventHandler(this.btnAddNewActivity_Click);
            // 
            // activityDataGridView
            // 
            this.activityDataGridView.AllowUserToAddRows = false;
            this.activityDataGridView.AllowUserToDeleteRows = false;
            this.activityDataGridView.AutoGenerateColumns = false;
            this.activityDataGridView.BackgroundColor = System.Drawing.Color.Pink;
            this.activityDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.activityDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activityDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.ActivityTravel,
            this.ActivityContactID,
            this.ActivityNotes});
            this.activityDataGridView.DataSource = this.activityBindingSource;
            this.activityDataGridView.Location = new System.Drawing.Point(27, 203);
            this.activityDataGridView.MultiSelect = false;
            this.activityDataGridView.Name = "activityDataGridView";
            this.activityDataGridView.ReadOnly = true;
            this.activityDataGridView.Size = new System.Drawing.Size(547, 211);
            this.activityDataGridView.TabIndex = 28;
            this.activityDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.activityDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ActivityID";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Maroon;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn1.HeaderText = "Activity ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ActivityDate";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Maroon;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn2.HeaderText = "Activity Date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 112;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ActivityDescription";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Maroon;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn3.HeaderText = "Description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // ActivityTravel
            // 
            this.ActivityTravel.DataPropertyName = "ActivityTravel";
            this.ActivityTravel.HeaderText = "ActivityTravel";
            this.ActivityTravel.Name = "ActivityTravel";
            this.ActivityTravel.ReadOnly = true;
            this.ActivityTravel.Visible = false;
            // 
            // ActivityContactID
            // 
            this.ActivityContactID.DataPropertyName = "ActivityContactID";
            this.ActivityContactID.HeaderText = "ActivityContactID";
            this.ActivityContactID.Name = "ActivityContactID";
            this.ActivityContactID.ReadOnly = true;
            this.ActivityContactID.Visible = false;
            // 
            // ActivityNotes
            // 
            this.ActivityNotes.DataPropertyName = "ActivityNotes";
            this.ActivityNotes.HeaderText = "ActivityNotes";
            this.ActivityNotes.Name = "ActivityNotes";
            this.ActivityNotes.ReadOnly = true;
            this.ActivityNotes.Visible = false;
            // 
            // activityBindingSource
            // 
            this.activityBindingSource.DataSource = typeof(SharpERBLL.Activity);
            // 
            // grpActivityDisplayResults
            // 
            this.grpActivityDisplayResults.BackColor = System.Drawing.Color.Silver;
            this.grpActivityDisplayResults.Controls.Add(this.chkDateActivity);
            this.grpActivityDisplayResults.Controls.Add(this.lblDispResuSelctAct);
            this.grpActivityDisplayResults.Controls.Add(this.chkActivityDescription);
            this.grpActivityDisplayResults.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpActivityDisplayResults.Location = new System.Drawing.Point(582, 440);
            this.grpActivityDisplayResults.Name = "grpActivityDisplayResults";
            this.grpActivityDisplayResults.Size = new System.Drawing.Size(143, 115);
            this.grpActivityDisplayResults.TabIndex = 36;
            this.grpActivityDisplayResults.TabStop = false;
            this.grpActivityDisplayResults.Text = "Display Results";
            // 
            // chkDateActivity
            // 
            this.chkDateActivity.AutoSize = true;
            this.chkDateActivity.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDateActivity.Location = new System.Drawing.Point(10, 57);
            this.chkDateActivity.Name = "chkDateActivity";
            this.chkDateActivity.Size = new System.Drawing.Size(55, 21);
            this.chkDateActivity.TabIndex = 4;
            this.chkDateActivity.Text = "Date";
            this.chkDateActivity.UseVisualStyleBackColor = true;
            // 
            // lblDispResuSelctAct
            // 
            this.lblDispResuSelctAct.AutoSize = true;
            this.lblDispResuSelctAct.Font = new System.Drawing.Font("Eras Bold ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDispResuSelctAct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblDispResuSelctAct.Location = new System.Drawing.Point(6, 34);
            this.lblDispResuSelctAct.Name = "lblDispResuSelctAct";
            this.lblDispResuSelctAct.Size = new System.Drawing.Size(83, 19);
            this.lblDispResuSelctAct.TabIndex = 3;
            this.lblDispResuSelctAct.Text = "SORT BY:";
            // 
            // chkActivityDescription
            // 
            this.chkActivityDescription.AutoSize = true;
            this.chkActivityDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActivityDescription.Location = new System.Drawing.Point(10, 79);
            this.chkActivityDescription.Name = "chkActivityDescription";
            this.chkActivityDescription.Size = new System.Drawing.Size(95, 21);
            this.chkActivityDescription.TabIndex = 1;
            this.chkActivityDescription.Text = "Description";
            this.chkActivityDescription.UseVisualStyleBackColor = true;
            // 
            // btnResetActivityGridview
            // 
            this.btnResetActivityGridview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnResetActivityGridview.Font = new System.Drawing.Font("Eras Bold ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetActivityGridview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnResetActivityGridview.Location = new System.Drawing.Point(357, 440);
            this.btnResetActivityGridview.Name = "btnResetActivityGridview";
            this.btnResetActivityGridview.Size = new System.Drawing.Size(176, 82);
            this.btnResetActivityGridview.TabIndex = 35;
            this.btnResetActivityGridview.Text = "Clear Results - Show All Activities";
            this.btnResetActivityGridview.UseVisualStyleBackColor = false;
            this.btnResetActivityGridview.Click += new System.EventHandler(this.btnResetActivityGridview_Click);
            // 
            // btnSearchActivityDescription
            // 
            this.btnSearchActivityDescription.Location = new System.Drawing.Point(284, 484);
            this.btnSearchActivityDescription.Name = "btnSearchActivityDescription";
            this.btnSearchActivityDescription.Size = new System.Drawing.Size(67, 29);
            this.btnSearchActivityDescription.TabIndex = 34;
            this.btnSearchActivityDescription.Text = "Search";
            this.btnSearchActivityDescription.UseVisualStyleBackColor = true;
            // 
            // btnSearchActivityDate
            // 
            this.btnSearchActivityDate.Location = new System.Drawing.Point(284, 449);
            this.btnSearchActivityDate.Name = "btnSearchActivityDate";
            this.btnSearchActivityDate.Size = new System.Drawing.Size(67, 29);
            this.btnSearchActivityDate.TabIndex = 33;
            this.btnSearchActivityDate.Text = "Search";
            this.btnSearchActivityDate.UseVisualStyleBackColor = true;
            // 
            // txtActivityDescription
            // 
            this.txtActivityDescription.Location = new System.Drawing.Point(124, 485);
            this.txtActivityDescription.Name = "txtActivityDescription";
            this.txtActivityDescription.Size = new System.Drawing.Size(154, 26);
            this.txtActivityDescription.TabIndex = 32;
            // 
            // lblSearchActivityDescriptionInst
            // 
            this.lblSearchActivityDescriptionInst.AutoSize = true;
            this.lblSearchActivityDescriptionInst.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchActivityDescriptionInst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblSearchActivityDescriptionInst.Location = new System.Drawing.Point(28, 487);
            this.lblSearchActivityDescriptionInst.Name = "lblSearchActivityDescriptionInst";
            this.lblSearchActivityDescriptionInst.Size = new System.Drawing.Size(91, 20);
            this.lblSearchActivityDescriptionInst.TabIndex = 30;
            this.lblSearchActivityDescriptionInst.Text = "Description:";
            // 
            // lblSearchActivityDateInst
            // 
            this.lblSearchActivityDateInst.AutoSize = true;
            this.lblSearchActivityDateInst.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchActivityDateInst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblSearchActivityDateInst.Location = new System.Drawing.Point(74, 452);
            this.lblSearchActivityDateInst.Name = "lblSearchActivityDateInst";
            this.lblSearchActivityDateInst.Size = new System.Drawing.Size(45, 20);
            this.lblSearchActivityDateInst.TabIndex = 29;
            this.lblSearchActivityDateInst.Text = "Date:";
            // 
            // mtbActivityDate
            // 
            this.mtbActivityDate.Location = new System.Drawing.Point(126, 452);
            this.mtbActivityDate.Mask = "00/00/0000";
            this.mtbActivityDate.Name = "mtbActivityDate";
            this.mtbActivityDate.Size = new System.Drawing.Size(152, 26);
            this.mtbActivityDate.TabIndex = 37;
            this.mtbActivityDate.ValidatingType = typeof(System.DateTime);
            // 
            // SearchActivityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(745, 620);
            this.ControlBox = false;
            this.Controls.Add(this.mtbActivityDate);
            this.Controls.Add(this.grpActivityDisplayResults);
            this.Controls.Add(this.btnResetActivityGridview);
            this.Controls.Add(this.btnSearchActivityDescription);
            this.Controls.Add(this.btnSearchActivityDate);
            this.Controls.Add(this.txtActivityDescription);
            this.Controls.Add(this.lblSearchActivityDescriptionInst);
            this.Controls.Add(this.lblSearchActivityDateInst);
            this.Controls.Add(this.activityDataGridView);
            this.Controls.Add(this.btnAddNewActivity);
            this.Controls.Add(this.btnDeleteActivity);
            this.Controls.Add(this.btnUpdateModifyActivity);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblSelectingActivity);
            this.Controls.Add(this.lblActivityTitle);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SearchActivityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search Activity Form";
            this.Load += new System.EventHandler(this.SearchActivityForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.activityDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).EndInit();
            this.grpActivityDisplayResults.ResumeLayout(false);
            this.grpActivityDisplayResults.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblActivityTitle;
        private System.Windows.Forms.Label lblSelectingActivity;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpdateModifyActivity;
        private System.Windows.Forms.Button btnDeleteActivity;
        private System.Windows.Forms.Button btnAddNewActivity;
        private System.Windows.Forms.BindingSource activityBindingSource;
        private System.Windows.Forms.DataGridView activityDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActivityTravel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActivityContactID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActivityNotes;
        private System.Windows.Forms.GroupBox grpActivityDisplayResults;
        private System.Windows.Forms.CheckBox chkDateActivity;
        private System.Windows.Forms.Label lblDispResuSelctAct;
        private System.Windows.Forms.CheckBox chkActivityDescription;
        private System.Windows.Forms.Button btnResetActivityGridview;
        private System.Windows.Forms.Button btnSearchActivityDescription;
        private System.Windows.Forms.Button btnSearchActivityDate;
        private System.Windows.Forms.TextBox txtActivityDescription;
        private System.Windows.Forms.Label lblSearchActivityDescriptionInst;
        private System.Windows.Forms.Label lblSearchActivityDateInst;
        private System.Windows.Forms.MaskedTextBox mtbActivityDate;
    }
}