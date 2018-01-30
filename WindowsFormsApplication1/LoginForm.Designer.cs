namespace WindowsFormsApplication1
{
    partial class frmLoginScreen
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
            this.grpLoginContainer = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnLoginButton = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.picLoginScreenImage = new System.Windows.Forms.PictureBox();
            this.lblTitleForLogin = new System.Windows.Forms.Label();
            this.grpLoginContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoginScreenImage)).BeginInit();
            this.SuspendLayout();
            // 
            // grpLoginContainer
            // 
            this.grpLoginContainer.BackColor = System.Drawing.Color.Goldenrod;
            this.grpLoginContainer.Controls.Add(this.txtPassword);
            this.grpLoginContainer.Controls.Add(this.txtUsername);
            this.grpLoginContainer.Controls.Add(this.btnLoginButton);
            this.grpLoginContainer.Controls.Add(this.lblPassword);
            this.grpLoginContainer.Controls.Add(this.lblUsername);
            this.grpLoginContainer.Controls.Add(this.picLoginScreenImage);
            this.grpLoginContainer.Location = new System.Drawing.Point(486, 49);
            this.grpLoginContainer.Name = "grpLoginContainer";
            this.grpLoginContainer.Size = new System.Drawing.Size(291, 377);
            this.grpLoginContainer.TabIndex = 0;
            this.grpLoginContainer.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtPassword.Location = new System.Drawing.Point(24, 272);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(242, 25);
            this.txtPassword.TabIndex = 2;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtUsername.Location = new System.Drawing.Point(24, 219);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(242, 25);
            this.txtUsername.TabIndex = 1;
            // 
            // btnLoginButton
            // 
            this.btnLoginButton.BackColor = System.Drawing.Color.SandyBrown;
            this.btnLoginButton.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginButton.Location = new System.Drawing.Point(64, 315);
            this.btnLoginButton.Name = "btnLoginButton";
            this.btnLoginButton.Size = new System.Drawing.Size(165, 38);
            this.btnLoginButton.TabIndex = 3;
            this.btnLoginButton.Text = "Login";
            this.btnLoginButton.UseVisualStyleBackColor = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(112, 256);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(60, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(78, 203);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(135, 13);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username ( your email ):";
            // 
            // picLoginScreenImage
            // 
            this.picLoginScreenImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLoginScreenImage.ErrorImage = null;
            this.picLoginScreenImage.Image = global::WindowsFormsApplication1.Properties.Resources.screen_shot_2013_09_06_at_11_061;
            this.picLoginScreenImage.ImageLocation = "";
            this.picLoginScreenImage.InitialImage = null;
            this.picLoginScreenImage.Location = new System.Drawing.Point(4, 43);
            this.picLoginScreenImage.Name = "picLoginScreenImage";
            this.picLoginScreenImage.Size = new System.Drawing.Size(284, 145);
            this.picLoginScreenImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLoginScreenImage.TabIndex = 1;
            this.picLoginScreenImage.TabStop = false;
            // 
            // lblTitleForLogin
            // 
            this.lblTitleForLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleForLogin.Font = new System.Drawing.Font("Wide Latin", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleForLogin.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.lblTitleForLogin.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblTitleForLogin.Location = new System.Drawing.Point(29, 288);
            this.lblTitleForLogin.Name = "lblTitleForLogin";
            this.lblTitleForLogin.Size = new System.Drawing.Size(432, 138);
            this.lblTitleForLogin.TabIndex = 1;
            this.lblTitleForLogin.Text = "SharpER (#ER) App for Bruce Clary";
            this.lblTitleForLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmLoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.grand_staircase__large;
            this.ClientSize = new System.Drawing.Size(789, 469);
            this.Controls.Add(this.lblTitleForLogin);
            this.Controls.Add(this.grpLoginContainer);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLoginScreen";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLoginScreen_Load);
            this.grpLoginContainer.ResumeLayout(false);
            this.grpLoginContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoginScreenImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLoginContainer;
        private System.Windows.Forms.PictureBox picLoginScreenImage;
        private System.Windows.Forms.Button btnLoginButton;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblTitleForLogin;
    }
}