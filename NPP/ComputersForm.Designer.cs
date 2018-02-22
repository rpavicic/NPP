namespace NPP
{
    partial class ComputersForm
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
            this.dgViewComputers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewComputers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgViewComputers
            // 
            this.dgViewComputers.AllowUserToAddRows = false;
            this.dgViewComputers.AllowUserToDeleteRows = false;
            this.dgViewComputers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewComputers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgViewComputers.Location = new System.Drawing.Point(0, 0);
            this.dgViewComputers.Name = "dgViewComputers";
            this.dgViewComputers.Size = new System.Drawing.Size(481, 796);
            this.dgViewComputers.TabIndex = 0;
            this.dgViewComputers.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgViewComputers_CellEndEdit);
            // 
            // ComputersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 796);
            this.Controls.Add(this.dgViewComputers);
            this.Name = "ComputersForm";
            this.Text = "ComputersForm";
            this.Load += new System.EventHandler(this.ComputersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgViewComputers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgViewComputers;
    }
}