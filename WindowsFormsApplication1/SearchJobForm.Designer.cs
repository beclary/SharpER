namespace WindowsFormsApplication1
{
    partial class SearchJobForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchJobForm));
            this.lblJobTitle = new System.Windows.Forms.Label();
            this.lblSelectingJob = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdateModifyJob = new System.Windows.Forms.Button();
            this.btnDeleteJob = new System.Windows.Forms.Button();
            this.btnAddNewJob = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblJobTitle.Font = new System.Drawing.Font("Goudy Old Style", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobTitle.ForeColor = System.Drawing.Color.Indigo;
            this.lblJobTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblJobTitle.Location = new System.Drawing.Point(24, 12);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(522, 51);
            this.lblJobTitle.TabIndex = 22;
            this.lblJobTitle.Text = "Search Job Form";
            this.lblJobTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSelectingJob
            // 
            this.lblSelectingJob.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectingJob.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSelectingJob.Location = new System.Drawing.Point(27, 57);
            this.lblSelectingJob.Name = "lblSelectingJob";
            this.lblSelectingJob.Size = new System.Drawing.Size(519, 134);
            this.lblSelectingJob.TabIndex = 23;
            this.lblSelectingJob.Text = resources.GetString("lblSelectingJob.Text");
            this.lblSelectingJob.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnExit.Size = new System.Drawing.Size(154, 45);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "E X I T";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnUpdateModifyJob
            // 
            this.btnUpdateModifyJob.BackColor = System.Drawing.Color.Goldenrod;
            this.btnUpdateModifyJob.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdateModifyJob.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateModifyJob.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnUpdateModifyJob.Location = new System.Drawing.Point(579, 205);
            this.btnUpdateModifyJob.Name = "btnUpdateModifyJob";
            this.btnUpdateModifyJob.Size = new System.Drawing.Size(154, 51);
            this.btnUpdateModifyJob.TabIndex = 25;
            this.btnUpdateModifyJob.Text = "View / Modify Job";
            this.btnUpdateModifyJob.UseVisualStyleBackColor = false;
            // 
            // btnDeleteJob
            // 
            this.btnDeleteJob.BackColor = System.Drawing.Color.Goldenrod;
            this.btnDeleteJob.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteJob.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteJob.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnDeleteJob.Location = new System.Drawing.Point(579, 262);
            this.btnDeleteJob.Name = "btnDeleteJob";
            this.btnDeleteJob.Size = new System.Drawing.Size(154, 51);
            this.btnDeleteJob.TabIndex = 27;
            this.btnDeleteJob.Text = "Delete Job";
            this.btnDeleteJob.UseVisualStyleBackColor = false;
            // 
            // btnAddNewJob
            // 
            this.btnAddNewJob.BackColor = System.Drawing.Color.Teal;
            this.btnAddNewJob.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNewJob.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewJob.ForeColor = System.Drawing.Color.Yellow;
            this.btnAddNewJob.Location = new System.Drawing.Point(579, 319);
            this.btnAddNewJob.Name = "btnAddNewJob";
            this.btnAddNewJob.Size = new System.Drawing.Size(154, 51);
            this.btnAddNewJob.TabIndex = 28;
            this.btnAddNewJob.Text = "Add New Job";
            this.btnAddNewJob.UseVisualStyleBackColor = false;
            // 
            // SearchJobForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(745, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnAddNewJob);
            this.Controls.Add(this.btnDeleteJob);
            this.Controls.Add(this.btnUpdateModifyJob);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblSelectingJob);
            this.Controls.Add(this.lblJobTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "SearchJobForm";
            this.Text = "Search Job Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblJobTitle;
        private System.Windows.Forms.Label lblSelectingJob;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpdateModifyJob;
        private System.Windows.Forms.Button btnDeleteJob;
        private System.Windows.Forms.Button btnAddNewJob;
    }
}