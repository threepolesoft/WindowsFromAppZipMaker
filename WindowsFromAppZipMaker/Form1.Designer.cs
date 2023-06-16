namespace WindowsFromAppZipMaker
{
    partial class Form1
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
            this.btnFolderOne = new System.Windows.Forms.Button();
            this.BtnFolderTwo = new System.Windows.Forms.Button();
            this.btnCreateToZip = new System.Windows.Forms.Button();
            this.lbFolderOne = new System.Windows.Forms.Label();
            this.lbFolderTwo = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFolderOne
            // 
            this.btnFolderOne.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFolderOne.Location = new System.Drawing.Point(87, 71);
            this.btnFolderOne.Name = "btnFolderOne";
            this.btnFolderOne.Size = new System.Drawing.Size(97, 38);
            this.btnFolderOne.TabIndex = 0;
            this.btnFolderOne.Text = "Browse Folder 1";
            this.btnFolderOne.UseVisualStyleBackColor = true;
            this.btnFolderOne.Click += new System.EventHandler(this.btnFolderOne_Click);
            // 
            // BtnFolderTwo
            // 
            this.BtnFolderTwo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnFolderTwo.Location = new System.Drawing.Point(87, 160);
            this.BtnFolderTwo.Name = "BtnFolderTwo";
            this.BtnFolderTwo.Size = new System.Drawing.Size(97, 38);
            this.BtnFolderTwo.TabIndex = 1;
            this.BtnFolderTwo.Text = "Browse Folder 2";
            this.BtnFolderTwo.UseVisualStyleBackColor = true;
            this.BtnFolderTwo.Click += new System.EventHandler(this.BtnFolderTwo_Click);
            // 
            // btnCreateToZip
            // 
            this.btnCreateToZip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreateToZip.Location = new System.Drawing.Point(367, 160);
            this.btnCreateToZip.Name = "btnCreateToZip";
            this.btnCreateToZip.Size = new System.Drawing.Size(97, 38);
            this.btnCreateToZip.TabIndex = 2;
            this.btnCreateToZip.Text = "Create to Zip";
            this.btnCreateToZip.UseVisualStyleBackColor = true;
            this.btnCreateToZip.Click += new System.EventHandler(this.btnCreateToZip_Click);
            // 
            // lbFolderOne
            // 
            this.lbFolderOne.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbFolderOne.AutoSize = true;
            this.lbFolderOne.Location = new System.Drawing.Point(87, 52);
            this.lbFolderOne.Name = "lbFolderOne";
            this.lbFolderOne.Size = new System.Drawing.Size(0, 13);
            this.lbFolderOne.TabIndex = 6;
            // 
            // lbFolderTwo
            // 
            this.lbFolderTwo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbFolderTwo.AutoSize = true;
            this.lbFolderTwo.Location = new System.Drawing.Point(87, 141);
            this.lbFolderTwo.Name = "lbFolderTwo";
            this.lbFolderTwo.Size = new System.Drawing.Size(0, 13);
            this.lbFolderTwo.TabIndex = 7;
            // 
            // lbStatus
            // 
            this.lbStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(367, 200);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(0, 13);
            this.lbStatus.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 323);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lbFolderTwo);
            this.Controls.Add(this.lbFolderOne);
            this.Controls.Add(this.btnCreateToZip);
            this.Controls.Add(this.BtnFolderTwo);
            this.Controls.Add(this.btnFolderOne);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zip Maker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFolderOne;
        private System.Windows.Forms.Button BtnFolderTwo;
        private System.Windows.Forms.Button btnCreateToZip;
        private System.Windows.Forms.Label lbFolderOne;
        private System.Windows.Forms.Label lbFolderTwo;
        private System.Windows.Forms.Label lbStatus;
    }
}

