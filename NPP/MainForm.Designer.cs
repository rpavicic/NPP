﻿namespace NPP
{
    partial class MainForm
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
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(13, 13);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(165, 23);
            this.btnLoadFile.TabIndex = 0;
            this.btnLoadFile.Text = "Učitaj iz datoteke u bazu";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(36, 100);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(35, 13);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnLoadFile);
            this.Name = "MainForm";
            this.Text = "Printing viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Label lblInfo;
    }
}

