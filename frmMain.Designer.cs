namespace mp3Validator
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
            this.btnValidator = new System.Windows.Forms.Button();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGoodFiles = new System.Windows.Forms.Label();
            this.lblBadFiles = new System.Windows.Forms.Label();
            this.chkFix = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnValidator
            // 
            this.btnValidator.Location = new System.Drawing.Point(686, 24);
            this.btnValidator.Name = "btnValidator";
            this.btnValidator.Size = new System.Drawing.Size(102, 23);
            this.btnValidator.TabIndex = 0;
            this.btnValidator.Text = "Validator";
            this.btnValidator.UseVisualStyleBackColor = true;
            this.btnValidator.Click += new System.EventHandler(this.btnValidator_Click);
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(12, 96);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ReadOnly = true;
            this.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResults.Size = new System.Drawing.Size(776, 342);
            this.txtResults.TabIndex = 1;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(12, 24);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(275, 20);
            this.txtPath.TabIndex = 2;
            this.txtPath.Text = "D:\\Music";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Good";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bad";
            // 
            // lblGoodFiles
            // 
            this.lblGoodFiles.AutoSize = true;
            this.lblGoodFiles.Location = new System.Drawing.Point(52, 59);
            this.lblGoodFiles.Name = "lblGoodFiles";
            this.lblGoodFiles.Size = new System.Drawing.Size(0, 13);
            this.lblGoodFiles.TabIndex = 5;
            // 
            // lblBadFiles
            // 
            this.lblBadFiles.AutoSize = true;
            this.lblBadFiles.Location = new System.Drawing.Point(207, 59);
            this.lblBadFiles.Name = "lblBadFiles";
            this.lblBadFiles.Size = new System.Drawing.Size(0, 13);
            this.lblBadFiles.TabIndex = 6;
            // 
            // chkFix
            // 
            this.chkFix.AutoSize = true;
            this.chkFix.Location = new System.Drawing.Point(686, 58);
            this.chkFix.Name = "chkFix";
            this.chkFix.Size = new System.Drawing.Size(66, 17);
            this.chkFix.TabIndex = 7;
            this.chkFix.Text = "Try to fix";
            this.chkFix.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkFix);
            this.Controls.Add(this.lblBadFiles);
            this.Controls.Add(this.lblGoodFiles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.btnValidator);
            this.Name = "frmMain";
            this.Text = "MP3 validator and fixer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValidator;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblGoodFiles;
        private System.Windows.Forms.Label lblBadFiles;
        private System.Windows.Forms.CheckBox chkFix;
    }
}

