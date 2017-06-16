namespace DeployCreator
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbxFTPAccount = new System.Windows.Forms.TextBox();
            this.tbxFtpUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxWebDeployArg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "FTP 帳號：";
            // 
            // tbxFTPAccount
            // 
            this.tbxFTPAccount.Location = new System.Drawing.Point(82, 81);
            this.tbxFTPAccount.Name = "tbxFTPAccount";
            this.tbxFTPAccount.Size = new System.Drawing.Size(417, 22);
            this.tbxFTPAccount.TabIndex = 2;
            // 
            // tbxFtpUrl
            // 
            this.tbxFtpUrl.Location = new System.Drawing.Point(82, 53);
            this.tbxFtpUrl.Name = "tbxFtpUrl";
            this.tbxFtpUrl.Size = new System.Drawing.Size(417, 22);
            this.tbxFtpUrl.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "FTP 主機：";
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(82, 109);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(417, 22);
            this.tbxPassword.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "FTP 密碼：";
            // 
            // tbxWebDeployArg
            // 
            this.tbxWebDeployArg.Location = new System.Drawing.Point(118, 12);
            this.tbxWebDeployArg.Name = "tbxWebDeployArg";
            this.tbxWebDeployArg.Size = new System.Drawing.Size(661, 22);
            this.tbxWebDeployArg.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "WebDeploy 參數：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 145);
            this.Controls.Add(this.tbxWebDeployArg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxFtpUrl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxFTPAccount);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Azure Publish 檔案讀取器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxFTPAccount;
        private System.Windows.Forms.TextBox tbxFtpUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxWebDeployArg;
        private System.Windows.Forms.Label label4;
    }
}

