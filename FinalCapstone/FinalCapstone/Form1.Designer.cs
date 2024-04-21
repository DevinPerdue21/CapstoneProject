namespace FinalCapstone
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
            this.Username = new MaterialSkin.Controls.MaterialTextBox();
            this.Password = new MaterialSkin.Controls.MaterialTextBox();
            this.LoginButton = new MaterialSkin.Controls.MaterialButton();
            this.ForgotPassword = new MaterialSkin.Controls.MaterialButton();
            this.NewUser = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Username.Depth = 0;
            this.Username.Font = new System.Drawing.Font("Roboto", 12F);
            this.Username.Hint = "Username";
            this.Username.Location = new System.Drawing.Point(281, 128);
            this.Username.MaxLength = 50;
            this.Username.MouseState = MaterialSkin.MouseState.OUT;
            this.Username.Multiline = false;
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(258, 50);
            this.Username.TabIndex = 0;
            this.Username.Text = "";
            // 
            // Password
            // 
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password.Depth = 0;
            this.Password.Font = new System.Drawing.Font("Roboto", 12F);
            this.Password.Hint = "Password";
            this.Password.Location = new System.Drawing.Point(281, 224);
            this.Password.MaxLength = 50;
            this.Password.MouseState = MaterialSkin.MouseState.OUT;
            this.Password.Multiline = false;
            this.Password.Name = "Password";
            this.Password.Password = true;
            this.Password.Size = new System.Drawing.Size(258, 50);
            this.Password.TabIndex = 1;
            this.Password.Text = "";
            // 
            // LoginButton
            // 
            this.LoginButton.AutoSize = false;
            this.LoginButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoginButton.Depth = 0;
            this.LoginButton.DrawShadows = true;
            this.LoginButton.HighEmphasis = true;
            this.LoginButton.Icon = null;
            this.LoginButton.Location = new System.Drawing.Point(323, 296);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.LoginButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(158, 36);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Login";
            this.LoginButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.LoginButton.UseAccentColor = false;
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // ForgotPassword
            // 
            this.ForgotPassword.AutoSize = false;
            this.ForgotPassword.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ForgotPassword.Depth = 0;
            this.ForgotPassword.DrawShadows = true;
            this.ForgotPassword.HighEmphasis = true;
            this.ForgotPassword.Icon = null;
            this.ForgotPassword.Location = new System.Drawing.Point(450, 359);
            this.ForgotPassword.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ForgotPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.ForgotPassword.Name = "ForgotPassword";
            this.ForgotPassword.Size = new System.Drawing.Size(158, 36);
            this.ForgotPassword.TabIndex = 3;
            this.ForgotPassword.Text = "Forgot Password ?";
            this.ForgotPassword.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ForgotPassword.UseAccentColor = false;
            this.ForgotPassword.UseVisualStyleBackColor = true;
            this.ForgotPassword.Click += new System.EventHandler(this.ForgotPassword_Click);
            // 
            // NewUser
            // 
            this.NewUser.AutoSize = false;
            this.NewUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NewUser.Depth = 0;
            this.NewUser.DrawShadows = true;
            this.NewUser.HighEmphasis = true;
            this.NewUser.Icon = null;
            this.NewUser.Location = new System.Drawing.Point(221, 359);
            this.NewUser.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.NewUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.NewUser.Name = "NewUser";
            this.NewUser.Size = new System.Drawing.Size(158, 36);
            this.NewUser.TabIndex = 4;
            this.NewUser.Text = "New User";
            this.NewUser.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.NewUser.UseAccentColor = false;
            this.NewUser.UseVisualStyleBackColor = true;
            this.NewUser.Click += new System.EventHandler(this.NewUser_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NewUser);
            this.Controls.Add(this.ForgotPassword);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox Username;
        private MaterialSkin.Controls.MaterialTextBox Password;
        private MaterialSkin.Controls.MaterialButton LoginButton;
        private MaterialSkin.Controls.MaterialButton ForgotPassword;
        private MaterialSkin.Controls.MaterialButton NewUser;
    }
}

