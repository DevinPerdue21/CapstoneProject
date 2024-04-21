namespace FinalCapstone
{
    partial class AddPart
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
            this.PartName = new MaterialSkin.Controls.MaterialTextBox();
            this.PartPrice = new MaterialSkin.Controls.MaterialTextBox();
            this.PartType = new MaterialSkin.Controls.MaterialTextBox();
            this.Inhouse = new MaterialSkin.Controls.MaterialRadioButton();
            this.Outsourced = new MaterialSkin.Controls.MaterialRadioButton();
            this.PartInventory = new MaterialSkin.Controls.MaterialTextBox();
            this.Add = new MaterialSkin.Controls.MaterialButton();
            this.Cancel = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // PartName
            // 
            this.PartName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PartName.Depth = 0;
            this.PartName.Font = new System.Drawing.Font("Roboto", 12F);
            this.PartName.Hint = "Part Name";
            this.PartName.Location = new System.Drawing.Point(130, 101);
            this.PartName.MaxLength = 50;
            this.PartName.MouseState = MaterialSkin.MouseState.OUT;
            this.PartName.Multiline = false;
            this.PartName.Name = "PartName";
            this.PartName.Size = new System.Drawing.Size(205, 50);
            this.PartName.TabIndex = 0;
            this.PartName.Text = "";
            // 
            // PartPrice
            // 
            this.PartPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PartPrice.Depth = 0;
            this.PartPrice.Font = new System.Drawing.Font("Roboto", 12F);
            this.PartPrice.Hint = "Price";
            this.PartPrice.Location = new System.Drawing.Point(130, 171);
            this.PartPrice.MaxLength = 50;
            this.PartPrice.MouseState = MaterialSkin.MouseState.OUT;
            this.PartPrice.Multiline = false;
            this.PartPrice.Name = "PartPrice";
            this.PartPrice.Size = new System.Drawing.Size(205, 50);
            this.PartPrice.TabIndex = 1;
            this.PartPrice.Text = "";
            this.PartPrice.TextChanged += new System.EventHandler(this.PartPrice_TextChanged);
            this.PartPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PartPrice_KeyPress);
            this.PartPrice.Leave += new System.EventHandler(this.PartPrice_Leave);
            // 
            // PartType
            // 
            this.PartType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PartType.Depth = 0;
            this.PartType.Font = new System.Drawing.Font("Roboto", 12F);
            this.PartType.Hint = "MachineID";
            this.PartType.Location = new System.Drawing.Point(130, 244);
            this.PartType.MaxLength = 50;
            this.PartType.MouseState = MaterialSkin.MouseState.OUT;
            this.PartType.Multiline = false;
            this.PartType.Name = "PartType";
            this.PartType.Size = new System.Drawing.Size(205, 50);
            this.PartType.TabIndex = 2;
            this.PartType.Text = "";
            this.PartType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PartType_KeyPress);
            // 
            // Inhouse
            // 
            this.Inhouse.AutoSize = true;
            this.Inhouse.Checked = true;
            this.Inhouse.Depth = 0;
            this.Inhouse.Location = new System.Drawing.Point(99, 383);
            this.Inhouse.Margin = new System.Windows.Forms.Padding(0);
            this.Inhouse.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Inhouse.MouseState = MaterialSkin.MouseState.HOVER;
            this.Inhouse.Name = "Inhouse";
            this.Inhouse.Ripple = true;
            this.Inhouse.Size = new System.Drawing.Size(91, 37);
            this.Inhouse.TabIndex = 3;
            this.Inhouse.TabStop = true;
            this.Inhouse.Text = "Inhouse";
            this.Inhouse.UseVisualStyleBackColor = true;
            this.Inhouse.CheckedChanged += new System.EventHandler(this.Inhouse_CheckedChanged);
            // 
            // Outsourced
            // 
            this.Outsourced.AutoSize = true;
            this.Outsourced.Depth = 0;
            this.Outsourced.Location = new System.Drawing.Point(237, 383);
            this.Outsourced.Margin = new System.Windows.Forms.Padding(0);
            this.Outsourced.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Outsourced.MouseState = MaterialSkin.MouseState.HOVER;
            this.Outsourced.Name = "Outsourced";
            this.Outsourced.Ripple = true;
            this.Outsourced.Size = new System.Drawing.Size(116, 37);
            this.Outsourced.TabIndex = 4;
            this.Outsourced.TabStop = true;
            this.Outsourced.Text = "Outsourced";
            this.Outsourced.UseVisualStyleBackColor = true;
            this.Outsourced.CheckedChanged += new System.EventHandler(this.Outsourced_CheckedChanged);
            // 
            // PartInventory
            // 
            this.PartInventory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PartInventory.Depth = 0;
            this.PartInventory.Font = new System.Drawing.Font("Roboto", 12F);
            this.PartInventory.Hint = "Inventory";
            this.PartInventory.Location = new System.Drawing.Point(130, 318);
            this.PartInventory.MaxLength = 50;
            this.PartInventory.MouseState = MaterialSkin.MouseState.OUT;
            this.PartInventory.Multiline = false;
            this.PartInventory.Name = "PartInventory";
            this.PartInventory.Size = new System.Drawing.Size(205, 50);
            this.PartInventory.TabIndex = 5;
            this.PartInventory.Text = "";
            this.PartInventory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PartInventory_KeyPress);
            // 
            // Add
            // 
            this.Add.AutoSize = false;
            this.Add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Add.Depth = 0;
            this.Add.DrawShadows = true;
            this.Add.HighEmphasis = true;
            this.Add.Icon = null;
            this.Add.Location = new System.Drawing.Point(150, 447);
            this.Add.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Add.MouseState = MaterialSkin.MouseState.HOVER;
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(167, 45);
            this.Add.TabIndex = 6;
            this.Add.Text = "Add Part";
            this.Add.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Add.UseAccentColor = false;
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Cancel
            // 
            this.Cancel.AutoSize = false;
            this.Cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Cancel.Depth = 0;
            this.Cancel.DrawShadows = true;
            this.Cancel.ForeColor = System.Drawing.Color.Red;
            this.Cancel.HighEmphasis = true;
            this.Cancel.Icon = null;
            this.Cancel.Location = new System.Drawing.Point(150, 521);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(167, 40);
            this.Cancel.TabIndex = 15;
            this.Cancel.Text = "Cancel";
            this.Cancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Cancel.UseAccentColor = false;
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 576);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.PartInventory);
            this.Controls.Add(this.Outsourced);
            this.Controls.Add(this.Inhouse);
            this.Controls.Add(this.PartType);
            this.Controls.Add(this.PartPrice);
            this.Controls.Add(this.PartName);
            this.Name = "AddPart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox PartName;
        private MaterialSkin.Controls.MaterialTextBox PartPrice;
        private MaterialSkin.Controls.MaterialTextBox PartType;
        private MaterialSkin.Controls.MaterialRadioButton Inhouse;
        private MaterialSkin.Controls.MaterialRadioButton Outsourced;
        private MaterialSkin.Controls.MaterialTextBox PartInventory;
        private MaterialSkin.Controls.MaterialButton Add;
        private MaterialSkin.Controls.MaterialButton Cancel;
    }
}