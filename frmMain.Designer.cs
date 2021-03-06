namespace SP21_Final_Project
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnPrevPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.pnlSpecials = new System.Windows.Forms.Panel();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.lblSpecials = new System.Windows.Forms.Label();
            this.mnuMenuBar = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuShoppingCart = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSpecials = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRefreshHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlSpecials.SuspendLayout();
            this.mnuMenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.Location = new System.Drawing.Point(12, 170);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(20, 100);
            this.btnPrevPage.TabIndex = 0;
            this.btnPrevPage.Text = "<";
            this.btnPrevPage.UseVisualStyleBackColor = true;
            this.btnPrevPage.Click += new System.EventHandler(this.btnPrevPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Location = new System.Drawing.Point(508, 170);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(20, 100);
            this.btnNextPage.TabIndex = 1;
            this.btnNextPage.Text = ">";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // pnlSpecials
            // 
            this.pnlSpecials.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSpecials.Controls.Add(this.btnDown);
            this.pnlSpecials.Controls.Add(this.btnUp);
            this.pnlSpecials.Controls.Add(this.lblSpecials);
            this.pnlSpecials.Location = new System.Drawing.Point(540, -1);
            this.pnlSpecials.Name = "pnlSpecials";
            this.pnlSpecials.Size = new System.Drawing.Size(245, 463);
            this.pnlSpecials.TabIndex = 2;
            // 
            // btnDown
            // 
            this.btnDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.Location = new System.Drawing.Point(3, 248);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(20, 185);
            this.btnDown.TabIndex = 5;
            this.btnDown.Text = "\\/";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.Location = new System.Drawing.Point(3, 43);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(20, 185);
            this.btnUp.TabIndex = 4;
            this.btnUp.Text = "/\\";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // lblSpecials
            // 
            this.lblSpecials.AutoSize = true;
            this.lblSpecials.Location = new System.Drawing.Point(4, 12);
            this.lblSpecials.Name = "lblSpecials";
            this.lblSpecials.Size = new System.Drawing.Size(50, 13);
            this.lblSpecials.TabIndex = 0;
            this.lblSpecials.Text = "Specials:";
            // 
            // mnuMenuBar
            // 
            this.mnuMenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuLogin,
            this.mnuShoppingCart,
            this.mnuRefresh,
            this.mnuHelp});
            this.mnuMenuBar.Location = new System.Drawing.Point(0, 0);
            this.mnuMenuBar.Name = "mnuMenuBar";
            this.mnuMenuBar.Size = new System.Drawing.Size(784, 24);
            this.mnuMenuBar.TabIndex = 3;
            this.mnuMenuBar.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(93, 22);
            this.mnuExit.Text = "E&xit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuLogin
            // 
            this.mnuLogin.Name = "mnuLogin";
            this.mnuLogin.Size = new System.Drawing.Size(89, 20);
            this.mnuLogin.Text = "&Login as staff";
            this.mnuLogin.Click += new System.EventHandler(this.mnuLogin_Click);
            // 
            // mnuShoppingCart
            // 
            this.mnuShoppingCart.Name = "mnuShoppingCart";
            this.mnuShoppingCart.Size = new System.Drawing.Size(95, 20);
            this.mnuShoppingCart.Text = "&Shopping Cart";
            this.mnuShoppingCart.Click += new System.EventHandler(this.mnuShoppingCart_Click);
            // 
            // mnuRefresh
            // 
            this.mnuRefresh.Name = "mnuRefresh";
            this.mnuRefresh.Size = new System.Drawing.Size(58, 20);
            this.mnuRefresh.Text = "&Refresh";
            this.mnuRefresh.Click += new System.EventHandler(this.mnuRefresh_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProducts,
            this.mnuSpecials,
            this.mnuRefreshHelp});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "&Help";
            // 
            // mnuProducts
            // 
            this.mnuProducts.Name = "mnuProducts";
            this.mnuProducts.Size = new System.Drawing.Size(121, 22);
            this.mnuProducts.Text = "&Products";
            this.mnuProducts.Click += new System.EventHandler(this.mnuProducts_Click);
            // 
            // mnuSpecials
            // 
            this.mnuSpecials.Name = "mnuSpecials";
            this.mnuSpecials.Size = new System.Drawing.Size(121, 22);
            this.mnuSpecials.Text = "&Specials";
            this.mnuSpecials.Click += new System.EventHandler(this.mnuSpecials_Click);
            // 
            // mnuRefreshHelp
            // 
            this.mnuRefreshHelp.Name = "mnuRefreshHelp";
            this.mnuRefreshHelp.Size = new System.Drawing.Size(121, 22);
            this.mnuRefreshHelp.Text = "&Refresh";
            this.mnuRefreshHelp.Click += new System.EventHandler(this.mnuRefreshHelp_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.pnlSpecials);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.btnPrevPage);
            this.Controls.Add(this.mnuMenuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMenuBar;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ian\'s Grocery Store";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlSpecials.ResumeLayout(false);
            this.pnlSpecials.PerformLayout();
            this.mnuMenuBar.ResumeLayout(false);
            this.mnuMenuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrevPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Panel pnlSpecials;
        private System.Windows.Forms.Label lblSpecials;
        private System.Windows.Forms.MenuStrip mnuMenuBar;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuLogin;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.ToolStripMenuItem mnuShoppingCart;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuProducts;
        private System.Windows.Forms.ToolStripMenuItem mnuSpecials;
        private System.Windows.Forms.ToolStripMenuItem mnuRefresh;
        private System.Windows.Forms.ToolStripMenuItem mnuRefreshHelp;
    }
}

