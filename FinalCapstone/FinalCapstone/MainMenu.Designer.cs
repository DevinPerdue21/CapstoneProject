namespace FinalCapstone
{
    partial class MainMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.Parts = new System.Windows.Forms.TabPage();
            this.materialButton8 = new MaterialSkin.Controls.MaterialButton();
            this.SearchParts = new MaterialSkin.Controls.MaterialTextBox();
            this.DeletePart = new MaterialSkin.Controls.MaterialButton();
            this.ModifyPart = new MaterialSkin.Controls.MaterialButton();
            this.AddPart = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.PartListView = new MaterialSkin.Controls.MaterialListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Inventory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Products = new System.Windows.Forms.TabPage();
            this.Search = new MaterialSkin.Controls.MaterialButton();
            this.SearchProduct = new MaterialSkin.Controls.MaterialTextBox();
            this.AddProduct = new MaterialSkin.Controls.MaterialButton();
            this.ModifyProduct = new MaterialSkin.Controls.MaterialButton();
            this.DeleteProduct = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.ProductsListView = new MaterialSkin.Controls.MaterialListView();
            this.ProductID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductInventory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Reports = new System.Windows.Forms.TabPage();
            this.report = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.generate = new MaterialSkin.Controls.MaterialButton();
            this.reorder = new MaterialSkin.Controls.MaterialRadioButton();
            this.typeOfPart = new MaterialSkin.Controls.MaterialRadioButton();
            this.Logout = new System.Windows.Forms.TabPage();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.log = new MaterialSkin.Controls.MaterialButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.Parts.SuspendLayout();
            this.Products.SuspendLayout();
            this.Reports.SuspendLayout();
            this.Logout.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.Parts);
            this.materialTabControl1.Controls.Add(this.Products);
            this.materialTabControl1.Controls.Add(this.Reports);
            this.materialTabControl1.Controls.Add(this.Logout);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 0);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1034, 479);
            this.materialTabControl1.TabIndex = 0;
            // 
            // Parts
            // 
            this.Parts.Controls.Add(this.materialButton8);
            this.Parts.Controls.Add(this.SearchParts);
            this.Parts.Controls.Add(this.DeletePart);
            this.Parts.Controls.Add(this.ModifyPart);
            this.Parts.Controls.Add(this.AddPart);
            this.Parts.Controls.Add(this.materialLabel1);
            this.Parts.Controls.Add(this.PartListView);
            this.Parts.ImageKey = "icons8-wrench-50.png";
            this.Parts.Location = new System.Drawing.Point(4, 39);
            this.Parts.Name = "Parts";
            this.Parts.Padding = new System.Windows.Forms.Padding(3);
            this.Parts.Size = new System.Drawing.Size(1026, 436);
            this.Parts.TabIndex = 1;
            this.Parts.Text = "Parts";
            this.Parts.UseVisualStyleBackColor = true;
            // 
            // materialButton8
            // 
            this.materialButton8.AutoSize = false;
            this.materialButton8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton8.Depth = 0;
            this.materialButton8.DrawShadows = true;
            this.materialButton8.HighEmphasis = true;
            this.materialButton8.Icon = null;
            this.materialButton8.Location = new System.Drawing.Point(782, 65);
            this.materialButton8.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton8.Name = "materialButton8";
            this.materialButton8.Size = new System.Drawing.Size(87, 36);
            this.materialButton8.TabIndex = 8;
            this.materialButton8.Text = "Search";
            this.materialButton8.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton8.UseAccentColor = false;
            this.materialButton8.UseVisualStyleBackColor = true;
            this.materialButton8.Click += new System.EventHandler(this.materialButton8_Click);
            // 
            // SearchParts
            // 
            this.SearchParts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchParts.Depth = 0;
            this.SearchParts.Font = new System.Drawing.Font("Roboto", 12F);
            this.SearchParts.Hint = "Search...";
            this.SearchParts.Location = new System.Drawing.Point(465, 51);
            this.SearchParts.MaxLength = 50;
            this.SearchParts.MouseState = MaterialSkin.MouseState.OUT;
            this.SearchParts.Multiline = false;
            this.SearchParts.Name = "SearchParts";
            this.SearchParts.Size = new System.Drawing.Size(300, 50);
            this.SearchParts.TabIndex = 7;
            this.SearchParts.Text = "";
            this.SearchParts.TextChanged += new System.EventHandler(this.SearchParts_TextChanged);
            // 
            // DeletePart
            // 
            this.DeletePart.AutoSize = false;
            this.DeletePart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeletePart.Depth = 0;
            this.DeletePart.DrawShadows = true;
            this.DeletePart.HighEmphasis = true;
            this.DeletePart.Icon = null;
            this.DeletePart.Location = new System.Drawing.Point(496, 295);
            this.DeletePart.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DeletePart.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeletePart.Name = "DeletePart";
            this.DeletePart.Size = new System.Drawing.Size(148, 53);
            this.DeletePart.TabIndex = 6;
            this.DeletePart.Text = "Delete Part";
            this.DeletePart.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.DeletePart.UseAccentColor = false;
            this.DeletePart.UseVisualStyleBackColor = true;
            this.DeletePart.Click += new System.EventHandler(this.DeletePart_Click);
            // 
            // ModifyPart
            // 
            this.ModifyPart.AutoSize = false;
            this.ModifyPart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ModifyPart.Depth = 0;
            this.ModifyPart.DrawShadows = true;
            this.ModifyPart.HighEmphasis = true;
            this.ModifyPart.Icon = null;
            this.ModifyPart.Location = new System.Drawing.Point(496, 210);
            this.ModifyPart.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ModifyPart.MouseState = MaterialSkin.MouseState.HOVER;
            this.ModifyPart.Name = "ModifyPart";
            this.ModifyPart.Size = new System.Drawing.Size(148, 53);
            this.ModifyPart.TabIndex = 5;
            this.ModifyPart.Text = "Modify Part";
            this.ModifyPart.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ModifyPart.UseAccentColor = false;
            this.ModifyPart.UseVisualStyleBackColor = true;
            this.ModifyPart.Click += new System.EventHandler(this.ModifyPart_Click);
            // 
            // AddPart
            // 
            this.AddPart.AutoSize = false;
            this.AddPart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddPart.Depth = 0;
            this.AddPart.DrawShadows = true;
            this.AddPart.HighEmphasis = true;
            this.AddPart.Icon = null;
            this.AddPart.Location = new System.Drawing.Point(496, 130);
            this.AddPart.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddPart.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddPart.Name = "AddPart";
            this.AddPart.Size = new System.Drawing.Size(148, 53);
            this.AddPart.TabIndex = 4;
            this.AddPart.Text = "Add Part";
            this.AddPart.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddPart.UseAccentColor = false;
            this.AddPart.UseVisualStyleBackColor = true;
            this.AddPart.Click += new System.EventHandler(this.AddPart_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(28, 17);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(38, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Parts";
            // 
            // PartListView
            // 
            this.PartListView.AutoSizeTable = false;
            this.PartListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PartListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PartListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Name,
            this.Price,
            this.Inventory});
            this.PartListView.Depth = 0;
            this.PartListView.FullRowSelect = true;
            this.PartListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.PartListView.HideSelection = false;
            this.PartListView.Location = new System.Drawing.Point(21, 51);
            this.PartListView.MinimumSize = new System.Drawing.Size(200, 100);
            this.PartListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.PartListView.MouseState = MaterialSkin.MouseState.OUT;
            this.PartListView.Name = "PartListView";
            this.PartListView.OwnerDraw = true;
            this.PartListView.Size = new System.Drawing.Size(396, 297);
            this.PartListView.TabIndex = 1;
            this.PartListView.UseCompatibleStateImageBehavior = false;
            this.PartListView.View = System.Windows.Forms.View.Details;
            this.PartListView.Click += new System.EventHandler(this.PartListView_Click);
            // 
            // ID
            // 
            this.ID.Text = "PartID";
            this.ID.Width = 100;
            // 
            // Name
            // 
            this.Name.Text = "Name";
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
            // Products
            // 
            this.Products.Controls.Add(this.Search);
            this.Products.Controls.Add(this.SearchProduct);
            this.Products.Controls.Add(this.AddProduct);
            this.Products.Controls.Add(this.ModifyProduct);
            this.Products.Controls.Add(this.DeleteProduct);
            this.Products.Controls.Add(this.materialLabel2);
            this.Products.Controls.Add(this.ProductsListView);
            this.Products.ImageKey = "icons8-product-50.png";
            this.Products.Location = new System.Drawing.Point(4, 39);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(1026, 436);
            this.Products.TabIndex = 2;
            this.Products.Text = "Products";
            this.Products.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            this.Search.AutoSize = false;
            this.Search.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Search.Depth = 0;
            this.Search.DrawShadows = true;
            this.Search.HighEmphasis = true;
            this.Search.Icon = null;
            this.Search.Location = new System.Drawing.Point(772, 67);
            this.Search.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Search.MouseState = MaterialSkin.MouseState.HOVER;
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(87, 36);
            this.Search.TabIndex = 9;
            this.Search.Text = "Search";
            this.Search.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Search.UseAccentColor = false;
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // SearchProduct
            // 
            this.SearchProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchProduct.Depth = 0;
            this.SearchProduct.Font = new System.Drawing.Font("Roboto", 12F);
            this.SearchProduct.Hint = "Search...";
            this.SearchProduct.Location = new System.Drawing.Point(452, 53);
            this.SearchProduct.MaxLength = 50;
            this.SearchProduct.MouseState = MaterialSkin.MouseState.OUT;
            this.SearchProduct.Multiline = false;
            this.SearchProduct.Name = "SearchProduct";
            this.SearchProduct.Size = new System.Drawing.Size(300, 50);
            this.SearchProduct.TabIndex = 8;
            this.SearchProduct.Text = "";
            // 
            // AddProduct
            // 
            this.AddProduct.AutoSize = false;
            this.AddProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddProduct.Depth = 0;
            this.AddProduct.DrawShadows = true;
            this.AddProduct.HighEmphasis = true;
            this.AddProduct.Icon = null;
            this.AddProduct.Location = new System.Drawing.Point(481, 148);
            this.AddProduct.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(148, 53);
            this.AddProduct.TabIndex = 7;
            this.AddProduct.Text = "Add Product";
            this.AddProduct.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddProduct.UseAccentColor = false;
            this.AddProduct.UseVisualStyleBackColor = true;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // ModifyProduct
            // 
            this.ModifyProduct.AutoSize = false;
            this.ModifyProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ModifyProduct.Depth = 0;
            this.ModifyProduct.DrawShadows = true;
            this.ModifyProduct.HighEmphasis = true;
            this.ModifyProduct.Icon = null;
            this.ModifyProduct.Location = new System.Drawing.Point(481, 233);
            this.ModifyProduct.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ModifyProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.ModifyProduct.Name = "ModifyProduct";
            this.ModifyProduct.Size = new System.Drawing.Size(148, 53);
            this.ModifyProduct.TabIndex = 6;
            this.ModifyProduct.Text = "Modify Product";
            this.ModifyProduct.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ModifyProduct.UseAccentColor = false;
            this.ModifyProduct.UseVisualStyleBackColor = true;
            this.ModifyProduct.Click += new System.EventHandler(this.ModifyProduct_Click);
            // 
            // DeleteProduct
            // 
            this.DeleteProduct.AutoSize = false;
            this.DeleteProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteProduct.Depth = 0;
            this.DeleteProduct.DrawShadows = true;
            this.DeleteProduct.HighEmphasis = true;
            this.DeleteProduct.Icon = null;
            this.DeleteProduct.Location = new System.Drawing.Point(481, 315);
            this.DeleteProduct.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DeleteProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteProduct.Name = "DeleteProduct";
            this.DeleteProduct.Size = new System.Drawing.Size(148, 53);
            this.DeleteProduct.TabIndex = 5;
            this.DeleteProduct.Text = "Delete Product";
            this.DeleteProduct.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.DeleteProduct.UseAccentColor = false;
            this.DeleteProduct.UseVisualStyleBackColor = true;
            this.DeleteProduct.Click += new System.EventHandler(this.DeleteProduct_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(30, 21);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(64, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Products";
            // 
            // ProductsListView
            // 
            this.ProductsListView.AutoSizeTable = false;
            this.ProductsListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ProductsListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProductID,
            this.ProductName,
            this.ProductPrice,
            this.ProductInventory});
            this.ProductsListView.Depth = 0;
            this.ProductsListView.FullRowSelect = true;
            this.ProductsListView.HideSelection = false;
            this.ProductsListView.Location = new System.Drawing.Point(19, 53);
            this.ProductsListView.MinimumSize = new System.Drawing.Size(200, 100);
            this.ProductsListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ProductsListView.MouseState = MaterialSkin.MouseState.OUT;
            this.ProductsListView.Name = "ProductsListView";
            this.ProductsListView.OwnerDraw = true;
            this.ProductsListView.Size = new System.Drawing.Size(397, 311);
            this.ProductsListView.TabIndex = 2;
            this.ProductsListView.UseCompatibleStateImageBehavior = false;
            this.ProductsListView.View = System.Windows.Forms.View.Details;
            // 
            // ProductID
            // 
            this.ProductID.Text = "ProductID";
            this.ProductID.Width = 100;
            // 
            // ProductName
            // 
            this.ProductName.Text = "Name";
            this.ProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProductName.Width = 100;
            // 
            // ProductPrice
            // 
            this.ProductPrice.Text = "Price";
            this.ProductPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProductPrice.Width = 100;
            // 
            // ProductInventory
            // 
            this.ProductInventory.Text = "Inventory";
            this.ProductInventory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProductInventory.Width = 100;
            // 
            // Reports
            // 
            this.Reports.Controls.Add(this.report);
            this.Reports.Controls.Add(this.materialLabel3);
            this.Reports.Controls.Add(this.generate);
            this.Reports.Controls.Add(this.reorder);
            this.Reports.Controls.Add(this.typeOfPart);
            this.Reports.ImageKey = "icons8-reports-58 (1).png";
            this.Reports.Location = new System.Drawing.Point(4, 39);
            this.Reports.Name = "Reports";
            this.Reports.Size = new System.Drawing.Size(1026, 436);
            this.Reports.TabIndex = 3;
            this.Reports.Text = "Reports";
            this.Reports.UseVisualStyleBackColor = true;
            // 
            // report
            // 
            this.report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.report.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.report.Depth = 0;
            this.report.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.report.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.report.Hint = "";
            this.report.Location = new System.Drawing.Point(371, 35);
            this.report.MouseState = MaterialSkin.MouseState.HOVER;
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(496, 351);
            this.report.TabIndex = 5;
            this.report.Text = "";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel3.Location = new System.Drawing.Point(36, 17);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(119, 41);
            this.materialLabel3.TabIndex = 3;
            this.materialLabel3.Text = "Reports";
            // 
            // generate
            // 
            this.generate.AutoSize = false;
            this.generate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.generate.Depth = 0;
            this.generate.DrawShadows = true;
            this.generate.HighEmphasis = true;
            this.generate.Icon = null;
            this.generate.Location = new System.Drawing.Point(57, 262);
            this.generate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.generate.MouseState = MaterialSkin.MouseState.HOVER;
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(151, 48);
            this.generate.TabIndex = 2;
            this.generate.Text = "Generate Report";
            this.generate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.generate.UseAccentColor = false;
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // reorder
            // 
            this.reorder.AutoSize = true;
            this.reorder.Depth = 0;
            this.reorder.Location = new System.Drawing.Point(31, 185);
            this.reorder.Margin = new System.Windows.Forms.Padding(0);
            this.reorder.MouseLocation = new System.Drawing.Point(-1, -1);
            this.reorder.MouseState = MaterialSkin.MouseState.HOVER;
            this.reorder.Name = "reorder";
            this.reorder.Ripple = true;
            this.reorder.Size = new System.Drawing.Size(229, 37);
            this.reorder.TabIndex = 1;
            this.reorder.TabStop = true;
            this.reorder.Text = "Parts That Need Reordering";
            this.reorder.UseVisualStyleBackColor = true;
            // 
            // typeOfPart
            // 
            this.typeOfPart.AutoSize = true;
            this.typeOfPart.Checked = true;
            this.typeOfPart.Depth = 0;
            this.typeOfPart.Location = new System.Drawing.Point(31, 95);
            this.typeOfPart.Margin = new System.Windows.Forms.Padding(0);
            this.typeOfPart.MouseLocation = new System.Drawing.Point(-1, -1);
            this.typeOfPart.MouseState = MaterialSkin.MouseState.HOVER;
            this.typeOfPart.Name = "typeOfPart";
            this.typeOfPart.Ripple = true;
            this.typeOfPart.Size = new System.Drawing.Size(237, 37);
            this.typeOfPart.TabIndex = 0;
            this.typeOfPart.TabStop = true;
            this.typeOfPart.Text = "Inhouse vs Outsourced Parts";
            this.typeOfPart.UseVisualStyleBackColor = true;
            this.typeOfPart.CheckedChanged += new System.EventHandler(this.typeOfPart_CheckedChanged);
            // 
            // Logout
            // 
            this.Logout.Controls.Add(this.materialLabel4);
            this.Logout.Controls.Add(this.log);
            this.Logout.ImageKey = "icons8-logout-50.png";
            this.Logout.Location = new System.Drawing.Point(4, 39);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(1026, 436);
            this.Logout.TabIndex = 4;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel4.Location = new System.Drawing.Point(21, 29);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(194, 41);
            this.materialLabel4.TabIndex = 1;
            this.materialLabel4.Text = "Logout Here:";
            // 
            // log
            // 
            this.log.AutoSize = false;
            this.log.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.log.Depth = 0;
            this.log.DrawShadows = true;
            this.log.HighEmphasis = true;
            this.log.Icon = null;
            this.log.Location = new System.Drawing.Point(31, 118);
            this.log.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.log.MouseState = MaterialSkin.MouseState.HOVER;
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(274, 90);
            this.log.TabIndex = 0;
            this.log.Text = "Logout";
            this.log.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.log.UseAccentColor = false;
            this.log.UseVisualStyleBackColor = true;
            this.log.Click += new System.EventHandler(this.log_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-logout-50.png");
            this.imageList1.Images.SetKeyName(1, "icons8-reports-58 (1).png");
            this.imageList1.Images.SetKeyName(2, "icons8-reports-58.png");
            this.imageList1.Images.SetKeyName(3, "icons8-wrench-50.png");
            this.imageList1.Images.SetKeyName(4, "icons8-product-50.png");
            this.imageList1.Images.SetKeyName(5, "icons8-home-50.png");
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 479);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            //this.Name = "MainMenu";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invo";
            this.materialTabControl1.ResumeLayout(false);
            this.Parts.ResumeLayout(false);
            this.Parts.PerformLayout();
            this.Products.ResumeLayout(false);
            this.Products.PerformLayout();
            this.Reports.ResumeLayout(false);
            this.Reports.PerformLayout();
            this.Logout.ResumeLayout(false);
            this.Logout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage Parts;
        private System.Windows.Forms.TabPage Products;
        private System.Windows.Forms.TabPage Reports;
        private System.Windows.Forms.TabPage Logout;
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialListView PartListView;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Inventory;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialListView ProductsListView;
        private System.Windows.Forms.ColumnHeader ProductID;
        private System.Windows.Forms.ColumnHeader ProductName;
        private System.Windows.Forms.ColumnHeader ProductPrice;
        private System.Windows.Forms.ColumnHeader ProductInventory;
        private MaterialSkin.Controls.MaterialButton Search;
        private MaterialSkin.Controls.MaterialTextBox SearchProduct;
        private MaterialSkin.Controls.MaterialButton AddProduct;
        private MaterialSkin.Controls.MaterialButton ModifyProduct;
        private MaterialSkin.Controls.MaterialButton DeleteProduct;
        private MaterialSkin.Controls.MaterialButton materialButton8;
        private MaterialSkin.Controls.MaterialTextBox SearchParts;
        private MaterialSkin.Controls.MaterialButton DeletePart;
        private MaterialSkin.Controls.MaterialButton ModifyPart;
        private MaterialSkin.Controls.MaterialButton AddPart;
        private MaterialSkin.Controls.MaterialButton generate;
        private MaterialSkin.Controls.MaterialRadioButton reorder;
        private MaterialSkin.Controls.MaterialRadioButton typeOfPart;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialMultiLineTextBox report;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialButton log;
    }
}