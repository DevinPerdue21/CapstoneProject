namespace FinalCapstone
{
    partial class ModifyProduct
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
            this.DeletePart = new MaterialSkin.Controls.MaterialButton();
            this.AddPart = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.PartsWithProductListView = new MaterialSkin.Controls.MaterialListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PartName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PartPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PartInventory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AllPartsListView = new MaterialSkin.Controls.MaterialListView();
            this.PartID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Inventory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cancel = new MaterialSkin.Controls.MaterialButton();
            this.Add = new MaterialSkin.Controls.MaterialButton();
            this.ProductInventory = new MaterialSkin.Controls.MaterialTextBox();
            this.ProductPrice = new MaterialSkin.Controls.MaterialTextBox();
            this.ProductName = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // DeletePart
            // 
            this.DeletePart.AutoSize = false;
            this.DeletePart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeletePart.Depth = 0;
            this.DeletePart.DrawShadows = true;
            this.DeletePart.HighEmphasis = true;
            this.DeletePart.Icon = null;
            this.DeletePart.Location = new System.Drawing.Point(732, 638);
            this.DeletePart.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DeletePart.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeletePart.Name = "DeletePart";
            this.DeletePart.Size = new System.Drawing.Size(133, 33);
            this.DeletePart.TabIndex = 40;
            this.DeletePart.Text = "Delete Part";
            this.DeletePart.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.DeletePart.UseAccentColor = false;
            this.DeletePart.UseVisualStyleBackColor = true;
            this.DeletePart.Click += new System.EventHandler(this.DeletePart_Click);
            // 
            // AddPart
            // 
            this.AddPart.AutoSize = false;
            this.AddPart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddPart.Depth = 0;
            this.AddPart.DrawShadows = true;
            this.AddPart.HighEmphasis = true;
            this.AddPart.Icon = null;
            this.AddPart.Location = new System.Drawing.Point(732, 323);
            this.AddPart.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddPart.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddPart.Name = "AddPart";
            this.AddPart.Size = new System.Drawing.Size(133, 33);
            this.AddPart.TabIndex = 39;
            this.AddPart.Text = "Add Part";
            this.AddPart.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddPart.UseAccentColor = false;
            this.AddPart.UseVisualStyleBackColor = true;
            this.AddPart.Click += new System.EventHandler(this.AddPart_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(499, 392);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(215, 19);
            this.materialLabel2.TabIndex = 38;
            this.materialLabel2.Text = "Parts Associated With Product";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(499, 75);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(60, 19);
            this.materialLabel1.TabIndex = 37;
            this.materialLabel1.Text = "All Parts";
            // 
            // PartsWithProductListView
            // 
            this.PartsWithProductListView.AutoSizeTable = false;
            this.PartsWithProductListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PartsWithProductListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PartsWithProductListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.PartName,
            this.PartPrice,
            this.PartInventory});
            this.PartsWithProductListView.Depth = 0;
            this.PartsWithProductListView.FullRowSelect = true;
            this.PartsWithProductListView.HideSelection = false;
            this.PartsWithProductListView.Location = new System.Drawing.Point(499, 424);
            this.PartsWithProductListView.MinimumSize = new System.Drawing.Size(200, 100);
            this.PartsWithProductListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.PartsWithProductListView.MouseState = MaterialSkin.MouseState.OUT;
            this.PartsWithProductListView.Name = "PartsWithProductListView";
            this.PartsWithProductListView.OwnerDraw = true;
            this.PartsWithProductListView.Size = new System.Drawing.Size(399, 189);
            this.PartsWithProductListView.TabIndex = 36;
            this.PartsWithProductListView.UseCompatibleStateImageBehavior = false;
            this.PartsWithProductListView.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "PartID";
            this.ID.Width = 100;
            // 
            // PartName
            // 
            this.PartName.Text = "Part Name";
            this.PartName.Width = 100;
            // 
            // PartPrice
            // 
            this.PartPrice.Text = "Price";
            this.PartPrice.Width = 100;
            // 
            // PartInventory
            // 
            this.PartInventory.Text = "Inventory";
            this.PartInventory.Width = 100;
            // 
            // AllPartsListView
            // 
            this.AllPartsListView.AutoSizeTable = false;
            this.AllPartsListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AllPartsListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AllPartsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PartID,
            this.Name,
            this.Price,
            this.Inventory});
            this.AllPartsListView.Depth = 0;
            this.AllPartsListView.FullRowSelect = true;
            this.AllPartsListView.HideSelection = false;
            this.AllPartsListView.Location = new System.Drawing.Point(499, 111);
            this.AllPartsListView.MinimumSize = new System.Drawing.Size(200, 100);
            this.AllPartsListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.AllPartsListView.MouseState = MaterialSkin.MouseState.OUT;
            this.AllPartsListView.Name = "AllPartsListView";
            this.AllPartsListView.OwnerDraw = true;
            this.AllPartsListView.Size = new System.Drawing.Size(399, 189);
            this.AllPartsListView.TabIndex = 35;
            this.AllPartsListView.UseCompatibleStateImageBehavior = false;
            this.AllPartsListView.View = System.Windows.Forms.View.Details;
            // 
            // PartID
            // 
            this.PartID.Text = "PartID";
            this.PartID.Width = 100;
            // 
            // Name
            // 
            this.Name.Text = "Part Name";
            this.Name.Width = 100;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 100;
            // 
            // Inventory
            // 
            this.Inventory.Text = "Inventory";
            this.Inventory.Width = 100;
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
            this.Cancel.Location = new System.Drawing.Point(55, 508);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(167, 40);
            this.Cancel.TabIndex = 34;
            this.Cancel.Text = "Cancel";
            this.Cancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Cancel.UseAccentColor = false;
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Add
            // 
            this.Add.AutoSize = false;
            this.Add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Add.Depth = 0;
            this.Add.DrawShadows = true;
            this.Add.HighEmphasis = true;
            this.Add.Icon = null;
            this.Add.Location = new System.Drawing.Point(55, 434);
            this.Add.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Add.MouseState = MaterialSkin.MouseState.HOVER;
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(167, 45);
            this.Add.TabIndex = 33;
            this.Add.Text = "Update Product";
            this.Add.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Add.UseAccentColor = false;
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // ProductInventory
            // 
            this.ProductInventory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductInventory.Depth = 0;
            this.ProductInventory.Font = new System.Drawing.Font("Roboto", 12F);
            this.ProductInventory.Hint = "Inventory";
            this.ProductInventory.Location = new System.Drawing.Point(44, 284);
            this.ProductInventory.MaxLength = 50;
            this.ProductInventory.MouseState = MaterialSkin.MouseState.OUT;
            this.ProductInventory.Multiline = false;
            this.ProductInventory.Name = "ProductInventory";
            this.ProductInventory.Size = new System.Drawing.Size(205, 50);
            this.ProductInventory.TabIndex = 32;
            this.ProductInventory.Text = "";
            this.ProductInventory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProductInventory_KeyPress);
            // 
            // ProductPrice
            // 
            this.ProductPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductPrice.Depth = 0;
            this.ProductPrice.Font = new System.Drawing.Font("Roboto", 12F);
            this.ProductPrice.Hint = "Price";
            this.ProductPrice.Location = new System.Drawing.Point(44, 210);
            this.ProductPrice.MaxLength = 50;
            this.ProductPrice.MouseState = MaterialSkin.MouseState.OUT;
            this.ProductPrice.Multiline = false;
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.Size = new System.Drawing.Size(205, 50);
            this.ProductPrice.TabIndex = 31;
            this.ProductPrice.Text = "";
            this.ProductPrice.TextChanged += new System.EventHandler(this.ProductPrice_TextChanged);
            this.ProductPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProductPrice_KeyPress);
            this.ProductPrice.Leave += new System.EventHandler(this.ProductPrice_Leave);
            // 
            // ProductName
            // 
            this.ProductName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductName.Depth = 0;
            this.ProductName.Font = new System.Drawing.Font("Roboto", 12F);
            this.ProductName.Hint = "Product Name";
            this.ProductName.Location = new System.Drawing.Point(44, 133);
            this.ProductName.MaxLength = 50;
            this.ProductName.MouseState = MaterialSkin.MouseState.OUT;
            this.ProductName.Multiline = false;
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(205, 50);
            this.ProductName.TabIndex = 30;
            this.ProductName.Text = "";
            // 
            // ModifyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 708);
            this.Controls.Add(this.DeletePart);
            this.Controls.Add(this.AddPart);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.PartsWithProductListView);
            this.Controls.Add(this.AllPartsListView);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.ProductInventory);
            this.Controls.Add(this.ProductPrice);
            this.Controls.Add(this.ProductName);
            //this.Name = "ModifyProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModifyProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton DeletePart;
        private MaterialSkin.Controls.MaterialButton AddPart;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialListView PartsWithProductListView;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader PartName;
        private System.Windows.Forms.ColumnHeader PartPrice;
        private System.Windows.Forms.ColumnHeader PartInventory;
        private MaterialSkin.Controls.MaterialListView AllPartsListView;
        private System.Windows.Forms.ColumnHeader PartID;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Inventory;
        private MaterialSkin.Controls.MaterialButton Cancel;
        private MaterialSkin.Controls.MaterialButton Add;
        private MaterialSkin.Controls.MaterialTextBox ProductInventory;
        private MaterialSkin.Controls.MaterialTextBox ProductPrice;
        private MaterialSkin.Controls.MaterialTextBox ProductName;
    }
}