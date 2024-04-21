namespace FinalCapstone
{
    partial class NewUser
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
            this.CreateUsername = new MaterialSkin.Controls.MaterialTextBox();
            this.CreatePassword = new MaterialSkin.Controls.MaterialTextBox();
            this.CreateUser = new MaterialSkin.Controls.MaterialButton();
            this.LastName = new MaterialSkin.Controls.MaterialTextBox();
            this.FirstName = new MaterialSkin.Controls.MaterialTextBox();
            this.Login = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // CreateUsername
            // 
            this.CreateUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CreateUsername.Depth = 0;
            this.CreateUsername.Font = new System.Drawing.Font("Roboto", 12F);
            this.CreateUsername.Hint = "Create Username";
            this.CreateUsername.Location = new System.Drawing.Point(258, 236);
            this.CreateUsername.MaxLength = 50;
            this.CreateUsername.MouseState = MaterialSkin.MouseState.OUT;
            this.CreateUsername.Multiline = false;
            this.CreateUsername.Name = "CreateUsername";
            this.CreateUsername.Size = new System.Drawing.Size(231, 50);
            this.CreateUsername.TabIndex = 0;
            this.CreateUsername.Text = "";
            // 
            // CreatePassword
            // 
            this.CreatePassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CreatePassword.Depth = 0;
            this.CreatePassword.Font = new System.Drawing.Font("Roboto", 12F);
            this.CreatePassword.Hint = "Create Password";
            this.CreatePassword.Location = new System.Drawing.Point(258, 309);
            this.CreatePassword.MaxLength = 50;
            this.CreatePassword.MouseState = MaterialSkin.MouseState.OUT;
            this.CreatePassword.Multiline = false;
            this.CreatePassword.Name = "CreatePassword";
            this.CreatePassword.Size = new System.Drawing.Size(231, 50);
            this.CreatePassword.TabIndex = 1;
            this.CreatePassword.Text = "";
            // 
            // CreateUser
            // 
            this.CreateUser.AutoSize = false;
            this.CreateUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CreateUser.Depth = 0;
            this.CreateUser.DrawShadows = true;
            this.CreateUser.HighEmphasis = true;
            this.CreateUser.Icon = null;
            this.CreateUser.Location = new System.Drawing.Point(289, 368);
            this.CreateUser.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CreateUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.CreateUser.Name = "CreateUser";
            this.CreateUser.Size = new System.Drawing.Size(155, 36);
            this.CreateUser.TabIndex = 2;
            this.CreateUser.Text = "Create User";
            this.CreateUser.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CreateUser.UseAccentColor = false;
            this.CreateUser.UseVisualStyleBackColor = true;
            this.CreateUser.Click += new System.EventHandler(this.CreateUser_Click);
            // 
            // LastName
            // 
            this.LastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LastName.Depth = 0;
            this.LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LastName.Hint = "Last Name";
            this.LastName.Location = new System.Drawing.Point(258, 163);
            this.LastName.MaxLength = 50;
            this.LastName.MouseState = MaterialSkin.MouseState.OUT;
            this.LastName.Multiline = false;
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(231, 50);
            this.LastName.TabIndex = 3;
            this.LastName.Text = "";
            this.LastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LastName_KeyPress);
            // 
            // FirstName
            // 
            this.FirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FirstName.Depth = 0;
            this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FirstName.Hint = "First Name";
            this.FirstName.Location = new System.Drawing.Point(258, 90);
            this.FirstName.MaxLength = 50;
            this.FirstName.MouseState = MaterialSkin.MouseState.OUT;
            this.FirstName.Multiline = false;
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(231, 50);
            this.FirstName.TabIndex = 4;
            this.FirstName.Text = "";
            this.FirstName.TextChanged += new System.EventHandler(this.FirstName_TextChanged);
            this.FirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FirstName_KeyPress);
            // 
            // Login
            // 
            this.Login.AutoSize = false;
            this.Login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Login.Depth = 0;
            this.Login.DrawShadows = true;
            this.Login.HighEmphasis = true;
            this.Login.Icon = null;
            this.Login.Location = new System.Drawing.Point(289, 416);
            this.Login.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Login.MouseState = MaterialSkin.MouseState.HOVER;
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(155, 36);
            this.Login.TabIndex = 5;
            this.Login.Text = "Login";
            this.Login.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Login.UseAccentColor = false;
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 484);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.CreateUser);
            this.Controls.Add(this.CreatePassword);
            this.Controls.Add(this.CreateUsername);
            this.Name = "NewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewUser";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox CreateUsername;
        private MaterialSkin.Controls.MaterialTextBox CreatePassword;
        private MaterialSkin.Controls.MaterialButton CreateUser;
        private MaterialSkin.Controls.MaterialTextBox LastName;
        private MaterialSkin.Controls.MaterialTextBox FirstName;
        private MaterialSkin.Controls.MaterialButton Login;
    }
}