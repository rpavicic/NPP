namespace NPP
{
    partial class PrintersForm
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
            this.dgViewPrinters = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewPrinters)).BeginInit();
            this.SuspendLayout();
            // 
            // dgViewPrinters
            // 
            this.dgViewPrinters.AllowUserToAddRows = false;
            this.dgViewPrinters.AllowUserToDeleteRows = false;
            this.dgViewPrinters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewPrinters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgViewPrinters.Location = new System.Drawing.Point(0, 0);
            this.dgViewPrinters.Name = "dgViewPrinters";
            this.dgViewPrinters.Size = new System.Drawing.Size(443, 788);
            this.dgViewPrinters.TabIndex = 0;
            this.dgViewPrinters.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgViewPrinters_CellContentClick);
            // 
            // PrintersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 788);
            this.Controls.Add(this.dgViewPrinters);
            this.Name = "PrintersForm";
            this.Text = "PrintersForm";
            this.Load += new System.EventHandler(this.PrintersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgViewPrinters)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgViewPrinters;
    }
}