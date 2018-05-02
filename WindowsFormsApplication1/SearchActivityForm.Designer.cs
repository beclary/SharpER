namespace WindowsFormsApplication1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchActivityForm));
            this.lblActivityTitle = new System.Windows.Forms.Label();
            this.lblSelectingActivity = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdateModifyActivity = new System.Windows.Forms.Button();
            this.btnDeleteActivity = new System.Windows.Forms.Button();
            this.btnAddNewActivity = new System.Windows.Forms.Button();
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
            this.btnExit.Size = new System.Drawing.Size(154, 45);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "E X I T";
            this.btnExit.UseVisualStyleBackColor = false;
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
            // 
            // SearchActivityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(749, 454);
            this.ControlBox = false;
            this.Controls.Add(this.btnAddNewActivity);
            this.Controls.Add(this.btnDeleteActivity);
            this.Controls.Add(this.btnUpdateModifyActivity);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblSelectingActivity);
            this.Controls.Add(this.lblActivityTitle);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SearchActivityForm";
            this.Text = "Search Activity Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblActivityTitle;
        private System.Windows.Forms.Label lblSelectingActivity;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpdateModifyActivity;
        private System.Windows.Forms.Button btnDeleteActivity;
        private System.Windows.Forms.Button btnAddNewActivity;
    }
}