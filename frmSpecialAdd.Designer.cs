﻿
namespace SP21_Final_Project
{
    partial class frmSpecialAdd
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
            this.cbxProducts = new System.Windows.Forms.ComboBox();
            this.mnuBar = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSpecialFor = new System.Windows.Forms.Label();
            this.tbxDiscount = new System.Windows.Forms.TextBox();
            this.tbxExtraDetails = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblExtraDetails = new System.Windows.Forms.Label();
            this.btnAddSpecial = new System.Windows.Forms.Button();
            this.mnuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxProducts
            // 
            this.cbxProducts.FormattingEnabled = true;
            this.cbxProducts.Location = new System.Drawing.Point(81, 27);
            this.cbxProducts.Name = "cbxProducts";
            this.cbxProducts.Size = new System.Drawing.Size(121, 21);
            this.cbxProducts.TabIndex = 0;
            // 
            // mnuBar
            // 
            this.mnuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.mnuBar.Location = new System.Drawing.Point(0, 0);
            this.mnuBar.Name = "mnuBar";
            this.mnuBar.Size = new System.Drawing.Size(213, 24);
            this.mnuBar.TabIndex = 1;
            this.mnuBar.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuClose});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuClose
            // 
            this.mnuClose.Name = "mnuClose";
            this.mnuClose.Size = new System.Drawing.Size(180, 22);
            this.mnuClose.Text = "&Close";
            this.mnuClose.Click += new System.EventHandler(this.mnuClose_Click);
            // 
            // lblSpecialFor
            // 
            this.lblSpecialFor.AutoSize = true;
            this.lblSpecialFor.Location = new System.Drawing.Point(12, 30);
            this.lblSpecialFor.Name = "lblSpecialFor";
            this.lblSpecialFor.Size = new System.Drawing.Size(63, 13);
            this.lblSpecialFor.TabIndex = 2;
            this.lblSpecialFor.Text = "Special For:";
            // 
            // tbxDiscount
            // 
            this.tbxDiscount.Location = new System.Drawing.Point(81, 55);
            this.tbxDiscount.Name = "tbxDiscount";
            this.tbxDiscount.Size = new System.Drawing.Size(121, 20);
            this.tbxDiscount.TabIndex = 3;
            // 
            // tbxExtraDetails
            // 
            this.tbxExtraDetails.Location = new System.Drawing.Point(81, 81);
            this.tbxExtraDetails.Name = "tbxExtraDetails";
            this.tbxExtraDetails.Size = new System.Drawing.Size(121, 20);
            this.tbxExtraDetails.TabIndex = 4;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(28, 58);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(47, 13);
            this.lblDiscount.TabIndex = 5;
            this.lblDiscount.Text = "Dicount:";
            // 
            // lblExtraDetails
            // 
            this.lblExtraDetails.AutoSize = true;
            this.lblExtraDetails.Location = new System.Drawing.Point(6, 84);
            this.lblExtraDetails.Name = "lblExtraDetails";
            this.lblExtraDetails.Size = new System.Drawing.Size(69, 13);
            this.lblExtraDetails.TabIndex = 6;
            this.lblExtraDetails.Text = "Extra Details:";
            // 
            // btnAddSpecial
            // 
            this.btnAddSpecial.Location = new System.Drawing.Point(9, 108);
            this.btnAddSpecial.Name = "btnAddSpecial";
            this.btnAddSpecial.Size = new System.Drawing.Size(192, 23);
            this.btnAddSpecial.TabIndex = 7;
            this.btnAddSpecial.Text = "&Add Special";
            this.btnAddSpecial.UseVisualStyleBackColor = true;
            this.btnAddSpecial.Click += new System.EventHandler(this.btnAddSpecial_Click);
            // 
            // frmSpecialAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 142);
            this.Controls.Add(this.btnAddSpecial);
            this.Controls.Add(this.lblExtraDetails);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.tbxExtraDetails);
            this.Controls.Add(this.tbxDiscount);
            this.Controls.Add(this.lblSpecialFor);
            this.Controls.Add(this.cbxProducts);
            this.Controls.Add(this.mnuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuBar;
            this.Name = "frmSpecialAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Special";
            this.Load += new System.EventHandler(this.frmSpecialAdd_Load);
            this.mnuBar.ResumeLayout(false);
            this.mnuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxProducts;
        private System.Windows.Forms.MenuStrip mnuBar;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuClose;
        private System.Windows.Forms.Label lblSpecialFor;
        private System.Windows.Forms.TextBox tbxDiscount;
        private System.Windows.Forms.TextBox tbxExtraDetails;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblExtraDetails;
        private System.Windows.Forms.Button btnAddSpecial;
    }
}