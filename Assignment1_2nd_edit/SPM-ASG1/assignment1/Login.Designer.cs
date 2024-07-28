namespace assignment1
{
    partial class Login
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
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.submitBttn = new System.Windows.Forms.Button();
            this.backbnt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // usernameInput
            // 
            this.usernameInput.Location = new System.Drawing.Point(63, 181);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(373, 46);
            this.usernameInput.TabIndex = 3;
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(63, 350);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(373, 46);
            this.passwordInput.TabIndex = 4;
            // 
            // submitBttn
            // 
            this.submitBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBttn.Location = new System.Drawing.Point(167, 477);
            this.submitBttn.Name = "submitBttn";
            this.submitBttn.Size = new System.Drawing.Size(135, 44);
            this.submitBttn.TabIndex = 5;
            this.submitBttn.Text = "Submit";
            this.submitBttn.UseVisualStyleBackColor = true;
            this.submitBttn.Click += new System.EventHandler(this.submitBttn_Click);
            // 
            // backbnt
            // 
            this.backbnt.Location = new System.Drawing.Point(12, 29);
            this.backbnt.Name = "backbnt";
            this.backbnt.Size = new System.Drawing.Size(157, 51);
            this.backbnt.TabIndex = 6;
            this.backbnt.Text = "back";
            this.backbnt.UseVisualStyleBackColor = true;
            this.backbnt.Click += new System.EventHandler(this.backbnt_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(514, 580);
            this.Controls.Add(this.backbnt);
            this.Controls.Add(this.submitBttn);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Button submitBttn;
        private System.Windows.Forms.Button backbnt;
    }
}