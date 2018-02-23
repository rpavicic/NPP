namespace NPP
{
    partial class UsersForm
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
            this.dgViewUsers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgViewUsers
            // 
            this.dgViewUsers.AllowUserToAddRows = false;
            this.dgViewUsers.AllowUserToDeleteRows = false;
            this.dgViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgViewUsers.Location = new System.Drawing.Point(0, 0);
            this.dgViewUsers.Name = "dgViewUsers";
            this.dgViewUsers.Size = new System.Drawing.Size(334, 711);
            this.dgViewUsers.TabIndex = 0;
            this.dgViewUsers.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgViewUsers_CellEndEdit);
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 711);
            this.Controls.Add(this.dgViewUsers);
            this.Name = "UsersForm";
            this.Text = "UsersForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.UsersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgViewUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgViewUsers;
    }
}