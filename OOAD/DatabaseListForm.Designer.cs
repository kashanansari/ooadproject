namespace OOAD
{
    partial class DatabaseListForm
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
            this.listBoxDatabases = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxDatabases
            // 
            this.listBoxDatabases.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listBoxDatabases.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.listBoxDatabases.FormattingEnabled = true;
            this.listBoxDatabases.ItemHeight = 25;
            this.listBoxDatabases.Location = new System.Drawing.Point(58, 37);
            this.listBoxDatabases.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxDatabases.Name = "listBoxDatabases";
            this.listBoxDatabases.Size = new System.Drawing.Size(462, 279);
            this.listBoxDatabases.TabIndex = 0;
            this.listBoxDatabases.SelectedIndexChanged += new System.EventHandler(this.listBoxDatabases_SelectedIndexChanged);
            // 
            // DatabaseListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.listBoxDatabases);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DatabaseListForm";
            this.Text = "DatabaseListForm";
            this.Load += new System.EventHandler(this.DatabaseListForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDatabases;
    }
}