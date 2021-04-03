﻿
namespace SP21_Final_Project
{
    partial class frmProductAdd
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
            this.mnuBar = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.lblProductName = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.tbxSize = new System.Windows.Forms.TextBox();
            this.tbxStock = new System.Windows.Forms.TextBox();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.pbxProductImage = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.mnuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuBar
            // 
            this.mnuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.mnuBar.Location = new System.Drawing.Point(0, 0);
            this.mnuBar.Name = "mnuBar";
            this.mnuBar.Size = new System.Drawing.Size(340, 24);
            this.mnuBar.TabIndex = 0;
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
            this.mnuClose.Size = new System.Drawing.Size(103, 22);
            this.mnuClose.Text = "&Close";
            this.mnuClose.Click += new System.EventHandler(this.mnuClose_Click);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(49, 35);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(38, 13);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Name:";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(93, 32);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(121, 20);
            this.tbxName.TabIndex = 2;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(13, 70);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(74, 13);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price per Unit:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(35, 105);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(52, 13);
            this.lblSize.TabIndex = 4;
            this.lblSize.Text = "Unit Size:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(13, 140);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(76, 13);
            this.lblStock.TabIndex = 5;
            this.lblStock.Text = "Units in Stock:";
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(93, 67);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(121, 20);
            this.tbxPrice.TabIndex = 6;
            // 
            // tbxSize
            // 
            this.tbxSize.Location = new System.Drawing.Point(93, 102);
            this.tbxSize.Name = "tbxSize";
            this.tbxSize.Size = new System.Drawing.Size(121, 20);
            this.tbxSize.TabIndex = 7;
            // 
            // tbxStock
            // 
            this.tbxStock.Location = new System.Drawing.Point(93, 137);
            this.tbxStock.Name = "tbxStock";
            this.tbxStock.Size = new System.Drawing.Size(121, 20);
            this.tbxStock.TabIndex = 8;
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Location = new System.Drawing.Point(221, 138);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(100, 20);
            this.btnSelectImage.TabIndex = 9;
            this.btnSelectImage.Text = "&Select Image";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // pbxProductImage
            // 
            this.pbxProductImage.Location = new System.Drawing.Point(221, 32);
            this.pbxProductImage.Name = "pbxProductImage";
            this.pbxProductImage.Size = new System.Drawing.Size(100, 100);
            this.pbxProductImage.TabIndex = 10;
            this.pbxProductImage.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(52, 179);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(212, 54);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "&Add to database";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmProductAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 249);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pbxProductImage);
            this.Controls.Add(this.btnSelectImage);
            this.Controls.Add(this.tbxStock);
            this.Controls.Add(this.tbxSize);
            this.Controls.Add(this.tbxPrice);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.mnuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuBar;
            this.Name = "frmProductAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Product";
            this.mnuBar.ResumeLayout(false);
            this.mnuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProductImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuBar;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuClose;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.TextBox tbxSize;
        private System.Windows.Forms.TextBox tbxStock;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.PictureBox pbxProductImage;
        private System.Windows.Forms.Button btnAdd;
    }
}