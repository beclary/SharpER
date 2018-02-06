namespace WindowsFormsApplication1
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.companyToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.activityToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.jobToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jobsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateModifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.companyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.activityToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.jobToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.companyToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.activityToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.jobToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jobsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.developerInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnContact = new System.Windows.Forms.Button();
            this.btnCompany = new System.Windows.Forms.Button();
            this.btnActivity = new System.Windows.Forms.Button();
            this.btnJob = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.maintenanceToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactToolStripMenuItem3,
            this.companyToolStripMenuItem3,
            this.activityToolStripMenuItem3,
            this.jobToolStripMenuItem3});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "Add";
            // 
            // contactToolStripMenuItem3
            // 
            this.contactToolStripMenuItem3.Name = "contactToolStripMenuItem3";
            this.contactToolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.contactToolStripMenuItem3.Text = "Contact";
            this.contactToolStripMenuItem3.Click += new System.EventHandler(this.contactToolStripMenuItem3_Click);
            // 
            // companyToolStripMenuItem3
            // 
            this.companyToolStripMenuItem3.Name = "companyToolStripMenuItem3";
            this.companyToolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.companyToolStripMenuItem3.Text = "Company";
            this.companyToolStripMenuItem3.Click += new System.EventHandler(this.companyToolStripMenuItem3_Click);
            // 
            // activityToolStripMenuItem3
            // 
            this.activityToolStripMenuItem3.Name = "activityToolStripMenuItem3";
            this.activityToolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.activityToolStripMenuItem3.Text = "Activity";
            // 
            // jobToolStripMenuItem3
            // 
            this.jobToolStripMenuItem3.Name = "jobToolStripMenuItem3";
            this.jobToolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.jobToolStripMenuItem3.Text = "Job";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactToolStripMenuItem,
            this.companyToolStripMenuItem,
            this.activityToolStripMenuItem,
            this.jobsToolStripMenuItem1});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // contactToolStripMenuItem
            // 
            this.contactToolStripMenuItem.Name = "contactToolStripMenuItem";
            this.contactToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.contactToolStripMenuItem.Text = "Contact";
            this.contactToolStripMenuItem.Click += new System.EventHandler(this.contactToolStripMenuItem_Click);
            // 
            // companyToolStripMenuItem
            // 
            this.companyToolStripMenuItem.Name = "companyToolStripMenuItem";
            this.companyToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.companyToolStripMenuItem.Text = "Company";
            // 
            // activityToolStripMenuItem
            // 
            this.activityToolStripMenuItem.Name = "activityToolStripMenuItem";
            this.activityToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.activityToolStripMenuItem.Text = "Activity";
            // 
            // jobsToolStripMenuItem1
            // 
            this.jobsToolStripMenuItem1.Name = "jobsToolStripMenuItem1";
            this.jobsToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.jobsToolStripMenuItem1.Text = "Job";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateModifyToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // updateModifyToolStripMenuItem
            // 
            this.updateModifyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactToolStripMenuItem1,
            this.companyToolStripMenuItem1,
            this.activityToolStripMenuItem1,
            this.jobToolStripMenuItem1});
            this.updateModifyToolStripMenuItem.Name = "updateModifyToolStripMenuItem";
            this.updateModifyToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.updateModifyToolStripMenuItem.Text = "Update / Modify";
            // 
            // contactToolStripMenuItem1
            // 
            this.contactToolStripMenuItem1.Name = "contactToolStripMenuItem1";
            this.contactToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.contactToolStripMenuItem1.Text = "Contact";
            // 
            // companyToolStripMenuItem1
            // 
            this.companyToolStripMenuItem1.Name = "companyToolStripMenuItem1";
            this.companyToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.companyToolStripMenuItem1.Text = "Company";
            // 
            // activityToolStripMenuItem1
            // 
            this.activityToolStripMenuItem1.Name = "activityToolStripMenuItem1";
            this.activityToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.activityToolStripMenuItem1.Text = "Activity";
            // 
            // jobToolStripMenuItem1
            // 
            this.jobToolStripMenuItem1.Name = "jobToolStripMenuItem1";
            this.jobToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.jobToolStripMenuItem1.Text = "Job";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactToolStripMenuItem2,
            this.companyToolStripMenuItem2,
            this.activityToolStripMenuItem2,
            this.jobToolStripMenuItem2});
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // contactToolStripMenuItem2
            // 
            this.contactToolStripMenuItem2.Name = "contactToolStripMenuItem2";
            this.contactToolStripMenuItem2.Size = new System.Drawing.Size(126, 22);
            this.contactToolStripMenuItem2.Text = "Contact";
            // 
            // companyToolStripMenuItem2
            // 
            this.companyToolStripMenuItem2.Name = "companyToolStripMenuItem2";
            this.companyToolStripMenuItem2.Size = new System.Drawing.Size(126, 22);
            this.companyToolStripMenuItem2.Text = "Company";
            // 
            // activityToolStripMenuItem2
            // 
            this.activityToolStripMenuItem2.Name = "activityToolStripMenuItem2";
            this.activityToolStripMenuItem2.Size = new System.Drawing.Size(126, 22);
            this.activityToolStripMenuItem2.Text = "Activity";
            // 
            // jobToolStripMenuItem2
            // 
            this.jobToolStripMenuItem2.Name = "jobToolStripMenuItem2";
            this.jobToolStripMenuItem2.Size = new System.Drawing.Size(126, 22);
            this.jobToolStripMenuItem2.Text = "Job";
            // 
            // maintenanceToolStripMenuItem
            // 
            this.maintenanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactsToolStripMenuItem,
            this.companiesToolStripMenuItem,
            this.activitiesToolStripMenuItem,
            this.jobsToolStripMenuItem});
            this.maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            this.maintenanceToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.maintenanceToolStripMenuItem.Text = "Tables";
            // 
            // contactsToolStripMenuItem
            // 
            this.contactsToolStripMenuItem.Name = "contactsToolStripMenuItem";
            this.contactsToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.contactsToolStripMenuItem.Text = "Contact";
            // 
            // companiesToolStripMenuItem
            // 
            this.companiesToolStripMenuItem.Name = "companiesToolStripMenuItem";
            this.companiesToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.companiesToolStripMenuItem.Text = "Company";
            // 
            // activitiesToolStripMenuItem
            // 
            this.activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            this.activitiesToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.activitiesToolStripMenuItem.Text = "Activity";
            // 
            // jobsToolStripMenuItem
            // 
            this.jobsToolStripMenuItem.Name = "jobsToolStripMenuItem";
            this.jobsToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.jobsToolStripMenuItem.Text = "Job";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutProgramToolStripMenuItem,
            this.developerInfoToolStripMenuItem,
            this.versionInfoToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutProgramToolStripMenuItem
            // 
            this.aboutProgramToolStripMenuItem.Name = "aboutProgramToolStripMenuItem";
            this.aboutProgramToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.aboutProgramToolStripMenuItem.Text = "About application";
            // 
            // developerInfoToolStripMenuItem
            // 
            this.developerInfoToolStripMenuItem.Name = "developerInfoToolStripMenuItem";
            this.developerInfoToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.developerInfoToolStripMenuItem.Text = "Developer Info";
            // 
            // versionInfoToolStripMenuItem
            // 
            this.versionInfoToolStripMenuItem.Name = "versionInfoToolStripMenuItem";
            this.versionInfoToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.versionInfoToolStripMenuItem.Text = "Version Info";
            // 
            // btnContact
            // 
            this.btnContact.BackColor = System.Drawing.Color.HotPink;
            this.btnContact.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnContact.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContact.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnContact.Location = new System.Drawing.Point(72, 87);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(184, 46);
            this.btnContact.TabIndex = 1;
            this.btnContact.Text = "Contact";
            this.btnContact.UseVisualStyleBackColor = false;
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // btnCompany
            // 
            this.btnCompany.BackColor = System.Drawing.Color.HotPink;
            this.btnCompany.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCompany.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompany.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnCompany.Location = new System.Drawing.Point(335, 87);
            this.btnCompany.Name = "btnCompany";
            this.btnCompany.Size = new System.Drawing.Size(184, 46);
            this.btnCompany.TabIndex = 2;
            this.btnCompany.Text = "Company";
            this.btnCompany.UseVisualStyleBackColor = false;
            this.btnCompany.Click += new System.EventHandler(this.btnCompany_Click);
            // 
            // btnActivity
            // 
            this.btnActivity.BackColor = System.Drawing.Color.HotPink;
            this.btnActivity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActivity.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivity.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnActivity.Location = new System.Drawing.Point(72, 181);
            this.btnActivity.Name = "btnActivity";
            this.btnActivity.Size = new System.Drawing.Size(184, 46);
            this.btnActivity.TabIndex = 3;
            this.btnActivity.Text = "Activity";
            this.btnActivity.UseVisualStyleBackColor = false;
            this.btnActivity.Click += new System.EventHandler(this.btnActivity_Click);
            // 
            // btnJob
            // 
            this.btnJob.BackColor = System.Drawing.Color.HotPink;
            this.btnJob.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnJob.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJob.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnJob.Location = new System.Drawing.Point(335, 181);
            this.btnJob.Name = "btnJob";
            this.btnJob.Size = new System.Drawing.Size(184, 46);
            this.btnJob.TabIndex = 4;
            this.btnJob.Text = "Job";
            this.btnJob.UseVisualStyleBackColor = false;
            this.btnJob.Click += new System.EventHandler(this.btnJob_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._09_9226610_uploadsmember665562yourshot_665562_9226610jpg_igdjhxksrjifxjzu4rgbsw37bhp3eflutfvvbpyjwjhzlmh4iziq_3000x2000_adapt_1190_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(600, 405);
            this.Controls.Add(this.btnJob);
            this.Controls.Add(this.btnActivity);
            this.Controls.Add(this.btnCompany);
            this.Controls.Add(this.btnContact);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateModifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem companyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem activityToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem jobToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem companyToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem activityToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem jobToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem maintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jobsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem developerInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionInfoToolStripMenuItem;
        private System.Windows.Forms.Button btnContact;
        private System.Windows.Forms.Button btnCompany;
        private System.Windows.Forms.Button btnActivity;
        private System.Windows.Forms.Button btnJob;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem companyToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem activityToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem jobToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jobsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

