namespace OOAD
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnConnectLocal = new System.Windows.Forms.Button();
            this.btnConnectRemote = new System.Windows.Forms.Button();
            this.cboServerIP = new System.Windows.Forms.ComboBox();
            this.cboServerName = new System.Windows.Forms.ComboBox();
            this.cboUsername = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "System IP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 26.25F);
            this.label2.Location = new System.Drawing.Point(35, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "Server Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 26.25F);
            this.label3.Location = new System.Drawing.Point(50, 184);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 41);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 26.25F);
            this.label4.Location = new System.Drawing.Point(50, 241);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 41);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(341, 259);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(181, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // btnConnectLocal
            // 
            this.btnConnectLocal.BackColor = System.Drawing.SystemColors.Window;
            this.btnConnectLocal.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F);
            this.btnConnectLocal.Location = new System.Drawing.Point(297, 320);
            this.btnConnectLocal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConnectLocal.Name = "btnConnectLocal";
            this.btnConnectLocal.Size = new System.Drawing.Size(216, 46);
            this.btnConnectLocal.TabIndex = 8;
            this.btnConnectLocal.Text = "Connect Locally";
            this.btnConnectLocal.UseVisualStyleBackColor = false;
            this.btnConnectLocal.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConnectRemote
            // 
            this.btnConnectRemote.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnConnectRemote.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F);
            this.btnConnectRemote.Location = new System.Drawing.Point(67, 320);
            this.btnConnectRemote.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConnectRemote.Name = "btnConnectRemote";
            this.btnConnectRemote.Size = new System.Drawing.Size(216, 46);
            this.btnConnectRemote.TabIndex = 9;
            this.btnConnectRemote.Text = "Connect Remotely";
            this.btnConnectRemote.UseVisualStyleBackColor = false;
            this.btnConnectRemote.Click += new System.EventHandler(this.btnConnectRemote_Click_1);
            // 
            // cboServerIP
            // 
            this.cboServerIP.FormattingEnabled = true;
            this.cboServerIP.Location = new System.Drawing.Point(341, 69);
            this.cboServerIP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboServerIP.Name = "cboServerIP";
            this.cboServerIP.Size = new System.Drawing.Size(181, 21);
            this.cboServerIP.TabIndex = 10;
            // 
            // cboServerName
            // 
            this.cboServerName.FormattingEnabled = true;
            this.cboServerName.Location = new System.Drawing.Point(341, 132);
            this.cboServerName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboServerName.Name = "cboServerName";
            this.cboServerName.Size = new System.Drawing.Size(181, 21);
            this.cboServerName.TabIndex = 11;
            // 
            // cboUsername
            // 
            this.cboUsername.FormattingEnabled = true;
            this.cboUsername.Location = new System.Drawing.Point(341, 195);
            this.cboUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboUsername.Name = "cboUsername";
            this.cboUsername.Size = new System.Drawing.Size(181, 21);
            this.cboUsername.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(614, 398);
            this.Controls.Add(this.cboUsername);
            this.Controls.Add(this.cboServerName);
            this.Controls.Add(this.cboServerIP);
            this.Controls.Add(this.btnConnectRemote);
            this.Controls.Add(this.btnConnectLocal);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnConnectLocal;
        private System.Windows.Forms.Button btnConnectRemote;
        private System.Windows.Forms.ComboBox cboServerIP;
        private System.Windows.Forms.ComboBox cboServerName;
        private System.Windows.Forms.ComboBox cboUsername;
    }
}

