namespace FinalCapstone
{
    partial class ForgotPassword
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
            this.LastName = new MaterialSkin.Controls.MaterialTextBox();
            this.Username = new MaterialSkin.Controls.MaterialTextBox();
            this.Login = new MaterialSkin.Controls.MaterialButton();
            this.NewPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.FirstName = new MaterialSkin.Controls.MaterialTextBox();
            this.CreateUser = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // LastName
            // 
            this.LastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LastName.Depth = 0;
            this.LastName.Font = new System.Drawing.Font("Roboto", 12F);
            this.LastName.Hint = "Last Name";
            this.LastName.Location = new System.Drawing.Point(284, 160);
            this.LastName.MaxLength = 50;
            this.LastName.MouseState = MaterialSkin.MouseState.OUT;
            this.LastName.Multiline = false;
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(270, 50);
            this.LastName.TabIndex = 0;
            this.LastName.Text = "";
            this.LastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LastName_KeyPress);
            // 
            // Username
            // 
            this.Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Username.Depth = 0;
            this.Username.Font = new System.Drawing.Font("Roboto", 12F);
            this.Username.Hint = "Username";
            this.Username.Location = new System.Drawing.Point(284, 231);
            this.Username.MaxLength = 50;
            this.Username.MouseState = MaterialSkin.MouseState.OUT;
            this.Username.Multiline = false;
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(270, 50);
            this.Username.TabIndex = 1;
            this.Username.Text = "";
            // 
            // Login
            // 
            this.Login.AutoSize = false;
            this.Login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Login.Depth = 0;
            this.Login.DrawShadows = true;
            this.Login.HighEmphasis = true;
            this.Login.Icon = null;
            this.Login.Location = new System.Drawing.Point(321, 365);
            this.Login.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Login.MouseState = MaterialSkin.MouseState.HOVER;
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(192, 40);
            this.Login.TabIndex = 2;
            this.Login.Text = "Create New Password";
            this.Login.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Login.UseAccentColor = false;
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // NewPassword
            // 
            this.NewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewPassword.Depth = 0;
            this.NewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.NewPassword.Hint = "New Password";
            this.NewPassword.Location = new System.Drawing.Point(284, 296);
            this.NewPassword.MaxLength = 50;
            this.NewPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.NewPassword.Multiline = false;
            this.NewPassword.Name = "NewPassword";
            this.NewPassword.Size = new System.Drawing.Size(270, 50);
            this.NewPassword.TabIndex = 3;
            this.NewPassword.Text = "";
            // 
            // FirstName
            // 
            this.FirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FirstName.Depth = 0;
            this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FirstName.Hint = "First Name";
            this.FirstName.Location = new System.Drawing.Point(284, 94);
            this.FirstName.MaxLength = 50;
            this.FirstName.MouseState = MaterialSkin.MouseState.OUT;
            this.FirstName.Multiline = false;
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(270, 50);
            this.FirstName.TabIndex = 4;
            this.FirstName.Text = "";
            this.FirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FirstName_KeyPress);
            // 
            // CreateUser
            // 
            this.CreateUser.AutoSize = false;
            this.CreateUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CreateUser.Depth = 0;
            this.CreateUser.DrawShadows = true;
            this.CreateUser.HighEmphasis = true;
            this.CreateUser.Icon = null;
            this.CreateUser.Location = new System.Drawing.Point(321, 417);
            this.CreateUser.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CreateUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.CreateUser.Name = "CreateUser";
            this.CreateUser.Size = new System.Drawing.Size(192, 40);
            this.CreateUser.TabIndex = 5;
            this.CreateUser.Text = "New User";
            this.CreateUser.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CreateUser.UseAccentColor = false;
            this.CreateUser.UseVisualStyleBackColor = true;
            this.CreateUser.Click += new System.EventHandler(this.CreateUser_Click);
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 490);
            this.Controls.Add(this.CreateUser);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.NewPassword);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.LastName);
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPassword";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox LastName;
        private MaterialSkin.Controls.MaterialTextBox Username;
        private MaterialSkin.Controls.MaterialButton Login;
        private MaterialSkin.Controls.MaterialTextBox NewPassword;
        private MaterialSkin.Controls.MaterialTextBox FirstName;
        private MaterialSkin.Controls.MaterialButton CreateUser;
    }
}