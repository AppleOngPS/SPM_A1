namespace SPM_ASG1
{
    partial class Menu
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
            this.ArcadeGameBtn = new System.Windows.Forms.Button();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.SignInBtn = new System.Windows.Forms.Button();
            this.FreeGameBtn = new System.Windows.Forms.Button();
            this.LoadSaveBtn = new System.Windows.Forms.Button();
            this.DisplayHighScoreBtn = new System.Windows.Forms.Button();
            this.ExitGameBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ArcadeGameBtn
            // 
            this.ArcadeGameBtn.Location = new System.Drawing.Point(126, 103);
            this.ArcadeGameBtn.Name = "ArcadeGameBtn";
            this.ArcadeGameBtn.Size = new System.Drawing.Size(555, 67);
            this.ArcadeGameBtn.TabIndex = 0;
            this.ArcadeGameBtn.Text = "Start New Arcade Game ";
            this.ArcadeGameBtn.UseVisualStyleBackColor = true;
            this.ArcadeGameBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(680, 31);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(83, 39);
            this.LoginBtn.TabIndex = 1;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // SignInBtn
            // 
            this.SignInBtn.Location = new System.Drawing.Point(769, 32);
            this.SignInBtn.Name = "SignInBtn";
            this.SignInBtn.Size = new System.Drawing.Size(81, 36);
            this.SignInBtn.TabIndex = 2;
            this.SignInBtn.Text = "Sign In";
            this.SignInBtn.UseVisualStyleBackColor = true;
            // 
            // FreeGameBtn
            // 
            this.FreeGameBtn.AutoEllipsis = true;
            this.FreeGameBtn.Location = new System.Drawing.Point(126, 176);
            this.FreeGameBtn.Name = "FreeGameBtn";
            this.FreeGameBtn.Size = new System.Drawing.Size(555, 67);
            this.FreeGameBtn.TabIndex = 3;
            this.FreeGameBtn.Text = "Start New Free Play Game";
            this.FreeGameBtn.UseVisualStyleBackColor = true;
            this.FreeGameBtn.Click += new System.EventHandler(this.FreeGameBtn_Click);
            // 
            // LoadSaveBtn
            // 
            this.LoadSaveBtn.Location = new System.Drawing.Point(126, 249);
            this.LoadSaveBtn.Name = "LoadSaveBtn";
            this.LoadSaveBtn.Size = new System.Drawing.Size(555, 67);
            this.LoadSaveBtn.TabIndex = 4;
            this.LoadSaveBtn.Text = "Load Saved Game";
            this.LoadSaveBtn.UseVisualStyleBackColor = true;
            // 
            // DisplayHighScoreBtn
            // 
            this.DisplayHighScoreBtn.Location = new System.Drawing.Point(126, 322);
            this.DisplayHighScoreBtn.Name = "DisplayHighScoreBtn";
            this.DisplayHighScoreBtn.Size = new System.Drawing.Size(555, 67);
            this.DisplayHighScoreBtn.TabIndex = 5;
            this.DisplayHighScoreBtn.Text = "Display High Score";
            this.DisplayHighScoreBtn.UseVisualStyleBackColor = true;
            // 
            // ExitGameBtn
            // 
            this.ExitGameBtn.Location = new System.Drawing.Point(126, 395);
            this.ExitGameBtn.Name = "ExitGameBtn";
            this.ExitGameBtn.Size = new System.Drawing.Size(555, 67);
            this.ExitGameBtn.TabIndex = 6;
            this.ExitGameBtn.Text = "Exit Game";
            this.ExitGameBtn.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 534);
            this.Controls.Add(this.ExitGameBtn);
            this.Controls.Add(this.DisplayHighScoreBtn);
            this.Controls.Add(this.LoadSaveBtn);
            this.Controls.Add(this.FreeGameBtn);
            this.Controls.Add(this.SignInBtn);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.ArcadeGameBtn);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ArcadeGameBtn;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Button SignInBtn;
        private System.Windows.Forms.Button FreeGameBtn;
        private System.Windows.Forms.Button LoadSaveBtn;
        private System.Windows.Forms.Button DisplayHighScoreBtn;
        private System.Windows.Forms.Button ExitGameBtn;
    }
}