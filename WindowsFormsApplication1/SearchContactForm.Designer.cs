namespace WindowsFormsApplication1
{
    partial class SearchContactForm
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
            this.lblContactID = new System.Windows.Forms.Label();
            this.txtContactID = new System.Windows.Forms.TextBox();
            this.btnGetContact = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblContactID
            // 
            this.lblContactID.AutoSize = true;
            this.lblContactID.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactID.Location = new System.Drawing.Point(13, 18);
            this.lblContactID.Name = "lblContactID";
            this.lblContactID.Size = new System.Drawing.Size(102, 23);
            this.lblContactID.TabIndex = 0;
            this.lblContactID.Text = "Contact ID :";
            // 
            // txtContactID
            // 
            this.txtContactID.BackColor = System.Drawing.Color.Gainsboro;
            this.txtContactID.Location = new System.Drawing.Point(122, 18);
            this.txtContactID.Name = "txtContactID";
            this.txtContactID.Size = new System.Drawing.Size(88, 26);
            this.txtContactID.TabIndex = 1;
            // 
            // btnGetContact
            // 
            this.btnGetContact.BackColor = System.Drawing.Color.PeachPuff;
            this.btnGetContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGetContact.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetContact.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnGetContact.Location = new System.Drawing.Point(251, 15);
            this.btnGetContact.Name = "btnGetContact";
            this.btnGetContact.Size = new System.Drawing.Size(127, 33);
            this.btnGetContact.TabIndex = 2;
            this.btnGetContact.Text = "Get Contact";
            this.btnGetContact.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PeachPuff;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkBlue;
            this.button1.Location = new System.Drawing.Point(418, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Find Contact";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // SearchContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(701, 525);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGetContact);
            this.Controls.Add(this.txtContactID);
            this.Controls.Add(this.lblContactID);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SearchContactForm";
            this.Text = "Get / Find Contact Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContactID;
        private System.Windows.Forms.TextBox txtContactID;
        private System.Windows.Forms.Button btnGetContact;
        private System.Windows.Forms.Button button1;
    }
}