﻿namespace assignment1
{
    partial class pickAlt
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
            this.q2bnt = new System.Windows.Forms.Button();
            this.q3bnt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // q2bnt
            // 
            this.q2bnt.Location = new System.Drawing.Point(78, 271);
            this.q2bnt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.q2bnt.Name = "q2bnt";
            this.q2bnt.Size = new System.Drawing.Size(181, 77);
            this.q2bnt.TabIndex = 0;
            this.q2bnt.Text = "Choose a new location";
            this.q2bnt.UseVisualStyleBackColor = true;
            this.q2bnt.Click += new System.EventHandler(this.q2bnt_Click);
            // 
            // q3bnt
            // 
            this.q3bnt.Location = new System.Drawing.Point(405, 271);
            this.q3bnt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.q3bnt.Name = "q3bnt";
            this.q3bnt.Size = new System.Drawing.Size(187, 77);
            this.q3bnt.TabIndex = 1;
            this.q3bnt.Text = "Continue with the current location";
            this.q3bnt.UseVisualStyleBackColor = true;
            this.q3bnt.Click += new System.EventHandler(this.q3bnt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 111);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose the current location \r\n                  or \r\n    Choose a new location\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pickAlt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 503);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.q3bnt);
            this.Controls.Add(this.q2bnt);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "pickAlt";
            this.Text = "pickAlt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button q2bnt;
        private System.Windows.Forms.Button q3bnt;
        private System.Windows.Forms.Label label1;
    }
}