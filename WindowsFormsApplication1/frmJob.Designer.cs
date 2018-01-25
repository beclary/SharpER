namespace WindowsFormsApplication1
{
    partial class frmJob
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJob));
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.lblJobInfoTitle = new System.Windows.Forms.Label();
            this.tslblJobPositionField = new System.Windows.Forms.ToolStripLabel();
            this.tstxtJobPositionField = new System.Windows.Forms.ToolStripTextBox();
            this.tsbtnSearchJobPositionButton = new System.Windows.Forms.ToolStripButton();
            this.lblJobPosition = new System.Windows.Forms.Label();
            this.txtJobPosition = new System.Windows.Forms.TextBox();
            this.lblJobID = new System.Windows.Forms.Label();
            this.txtJobID = new System.Windows.Forms.TextBox();
            this.lblJobApplied = new System.Windows.Forms.Label();
            this.dtpJobApplied = new System.Windows.Forms.DateTimePicker();
            this.lblJobPay1 = new System.Windows.Forms.Label();
            this.lblJobPay2 = new System.Windows.Forms.Label();
            this.txtJobPay = new System.Windows.Forms.TextBox();
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightGray;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblJobPositionField,
            this.tstxtJobPositionField,
            this.tsbtnSearchJobPositionButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(732, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
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
            // lblJobInfoTitle
            // 
            this.lblJobInfoTitle.AutoSize = true;
            this.lblJobInfoTitle.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobInfoTitle.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblJobInfoTitle.Location = new System.Drawing.Point(1, 50);
            this.lblJobInfoTitle.Name = "lblJobInfoTitle";
            this.lblJobInfoTitle.Size = new System.Drawing.Size(220, 43);
            this.lblJobInfoTitle.TabIndex = 38;
            this.lblJobInfoTitle.Text = "Job Information";
            // 
            // tslblJobPositionField
            // 
            this.tslblJobPositionField.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tslblJobPositionField.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslblJobPositionField.ForeColor = System.Drawing.Color.DarkRed;
            this.tslblJobPositionField.Name = "tslblJobPositionField";
            this.tslblJobPositionField.Size = new System.Drawing.Size(60, 22);
            this.tslblJobPositionField.Text = "Position:";
            // 
            // tstxtJobPositionField
            // 
            this.tstxtJobPositionField.Name = "tstxtJobPositionField";
            this.tstxtJobPositionField.Size = new System.Drawing.Size(100, 25);
            // 
            // tsbtnSearchJobPositionButton
            // 
            this.tsbtnSearchJobPositionButton.BackColor = System.Drawing.Color.SandyBrown;
            this.tsbtnSearchJobPositionButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnSearchJobPositionButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnSearchJobPositionButton.ForeColor = System.Drawing.Color.DarkRed;
            this.tsbtnSearchJobPositionButton.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSearchJobPositionButton.Image")));
            this.tsbtnSearchJobPositionButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSearchJobPositionButton.Name = "tsbtnSearchJobPositionButton";
            this.tsbtnSearchJobPositionButton.Size = new System.Drawing.Size(52, 22);
            this.tsbtnSearchJobPositionButton.Text = "Search";
            // 
            // lblJobPosition
            // 
            this.lblJobPosition.AutoSize = true;
            this.lblJobPosition.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobPosition.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblJobPosition.Location = new System.Drawing.Point(66, 112);
            this.lblJobPosition.Name = "lblJobPosition";
            this.lblJobPosition.Size = new System.Drawing.Size(63, 19);
            this.lblJobPosition.TabIndex = 43;
            this.lblJobPosition.Text = "Position:";
            // 
            // txtJobPosition
            // 
            this.txtJobPosition.Location = new System.Drawing.Point(135, 110);
            this.txtJobPosition.Name = "txtJobPosition";
            this.txtJobPosition.Size = new System.Drawing.Size(261, 26);
            this.txtJobPosition.TabIndex = 44;
            // 
            // lblJobID
            // 
            this.lblJobID.AutoSize = true;
            this.lblJobID.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobID.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblJobID.Location = new System.Drawing.Point(402, 112);
            this.lblJobID.Name = "lblJobID";
            this.lblJobID.Size = new System.Drawing.Size(61, 19);
            this.lblJobID.TabIndex = 45;
            this.lblJobID.Text = "Job ID:";
            // 
            // txtJobID
            // 
            this.txtJobID.BackColor = System.Drawing.Color.LightGray;
            this.txtJobID.Location = new System.Drawing.Point(470, 109);
            this.txtJobID.Name = "txtJobID";
            this.txtJobID.ReadOnly = true;
            this.txtJobID.Size = new System.Drawing.Size(100, 26);
            this.txtJobID.TabIndex = 46;
            // 
            // lblJobApplied
            // 
            this.lblJobApplied.AutoSize = true;
            this.lblJobApplied.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobApplied.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblJobApplied.Location = new System.Drawing.Point(47, 149);
            this.lblJobApplied.Name = "lblJobApplied";
            this.lblJobApplied.Size = new System.Drawing.Size(82, 19);
            this.lblJobApplied.TabIndex = 47;
            this.lblJobApplied.Text = "Applied on:";
            // 
            // dtpJobApplied
            // 
            this.dtpJobApplied.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpJobApplied.Location = new System.Drawing.Point(135, 146);
            this.dtpJobApplied.Name = "dtpJobApplied";
            this.dtpJobApplied.Size = new System.Drawing.Size(116, 26);
            this.dtpJobApplied.TabIndex = 48;
            // 
            // lblJobPay1
            // 
            this.lblJobPay1.AutoSize = true;
            this.lblJobPay1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobPay1.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblJobPay1.Location = new System.Drawing.Point(38, 202);
            this.lblJobPay1.Name = "lblJobPay1";
            this.lblJobPay1.Size = new System.Drawing.Size(91, 19);
            this.lblJobPay1.TabIndex = 49;
            this.lblJobPay1.Text = "Pay offered:";
            // 
            // lblJobPay2
            // 
            this.lblJobPay2.AutoSize = true;
            this.lblJobPay2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobPay2.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblJobPay2.Location = new System.Drawing.Point(28, 220);
            this.lblJobPay2.Name = "lblJobPay2";
            this.lblJobPay2.Size = new System.Drawing.Size(107, 16);
            this.lblJobPay2.TabIndex = 50;
            this.lblJobPay2.Text = "( salary per year )";
            // 
            // txtJobPay
            // 
            this.txtJobPay.Location = new System.Drawing.Point(136, 200);
            this.txtJobPay.Name = "txtJobPay";
            this.txtJobPay.Size = new System.Drawing.Size(115, 26);
            this.txtJobPay.TabIndex = 51;
            // 
            // frmJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(732, 535);
            this.Controls.Add(this.txtJobPay);
            this.Controls.Add(this.lblJobPay2);
            this.Controls.Add(this.lblJobPay1);
            this.Controls.Add(this.dtpJobApplied);
            this.Controls.Add(this.lblJobApplied);
            this.Controls.Add(this.txtJobID);
            this.Controls.Add(this.lblJobID);
            this.Controls.Add(this.txtJobPosition);
            this.Controls.Add(this.lblJobPosition);
            this.Controls.Add(this.lblJobInfoTitle);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.bindingNavigator1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmJob";
            this.Text = "Job";
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
        private System.Windows.Forms.Label lblJobInfoTitle;
        private System.Windows.Forms.ToolStripLabel tslblJobPositionField;
        private System.Windows.Forms.ToolStripTextBox tstxtJobPositionField;
        private System.Windows.Forms.ToolStripButton tsbtnSearchJobPositionButton;
        private System.Windows.Forms.Label lblJobPosition;
        private System.Windows.Forms.TextBox txtJobPosition;
        private System.Windows.Forms.Label lblJobID;
        private System.Windows.Forms.TextBox txtJobID;
        private System.Windows.Forms.Label lblJobApplied;
        private System.Windows.Forms.DateTimePicker dtpJobApplied;
        private System.Windows.Forms.Label lblJobPay1;
        private System.Windows.Forms.Label lblJobPay2;
        private System.Windows.Forms.TextBox txtJobPay;
    }
}