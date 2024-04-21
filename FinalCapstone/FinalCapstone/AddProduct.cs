using FinalCapstone.Database;
using FinalCapstone.Model;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalCapstone
{
    public partial class AddProduct : MaterialForm
    {
        private readonly DBQueries dBQueries;
        public AddProduct()
        {
            InitializeComponent();

            string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            dBQueries = new DBQueries(constr);

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey500, Primary.BlueGrey700, Primary.BlueGrey100, Accent.LightBlue200, TextShade.WHITE);

            DataTable d1 = dBQueries.PartsData();
            d1.DefaultView.Sort = "PartID ASC";

            foreach (DataRow row in d1.Rows)
            {
                ListViewItem listViewItem = new ListViewItem(row["PartID"].ToString());
                listViewItem.SubItems.Add(row["PartName"].ToString());
                listViewItem.SubItems.Add(row["Price"].ToString());
                listViewItem.SubItems.Add(row["Inventory"].ToString());

                AllPartsListView.Items.Add(listViewItem);
            }
        }

        private void AddPart_Click(object sender, EventArgs e)
        {
            if (AllPartsListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedPart = AllPartsListView.SelectedItems[0];
                ListViewItem duplicate = (ListViewItem)selectedPart.Clone();

                bool duplicatedPart = false;
                foreach (ListViewItem item in PartsWithProductListView.Items)
                {
                    if(item.Text == duplicate.Text)
                    {
                        duplicatedPart = true;
                        break;
                    }
                }

                if(!duplicatedPart)
                {
                    PartsWithProductListView.Items.Add(duplicate);
                }
                else
                {
                    MessageBox.Show("This part is already added to this product!");
                }

            }
            else
            {
                MessageBox.Show("Please select a part to add!");
            }
        }

        private void DeletePart_Click(object sender, EventArgs e)
        {
            if (PartsWithProductListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedPart = PartsWithProductListView.SelectedItems[0];
                PartsWithProductListView.Items.Remove(selectedPart);

            }
            else
            {
                MessageBox.Show("Please select a part to delete!");
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if(ProductName.Text != string.Empty && ProductPrice.Text != string.Empty && ProductInventory.Text != string.Empty)
            {
                //if(PartsWithProductListView.Items.Count >0)
                //{
                    List<int> partIDs = new List<int>();

                    foreach (ListViewItem item in PartsWithProductListView.Items)
                    {
                        int partID;
                        if (int.TryParse(item.SubItems[0].Text, out partID))
                        {
                            partIDs.Add(partID);
                        }
                    }
                    string name = ProductName.Text;
                    decimal price = decimal.Parse(ProductPrice.Text);
                    int inventory = int.Parse(ProductInventory.Text);

                    Product product = new Product
                    {
                        Name = name,
                        Price = price,
                        Inventory = inventory,

                    };
                    int productID = dBQueries.AddProduct(product);
                    bool isAdded = dBQueries.AddProductParts(productID, partIDs);
                    if (isAdded)
                    {
                        MessageBox.Show("Product was successfully added!");

                        MainMenu main = new MainMenu();
                        main.MaterialTabControl1.SelectedTab = main.MaterialTabControl1.TabPages["Products"];
                        main.Show();
                        this.Hide();
                    }
                //}
                //else
                //{
                //    MessageBox.Show("Each product must have at least one part!");
                //}
            }
            else
            {
                MessageBox.Show("All fields must be filled out!");
            }
        }

        private void ProductInventory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ProductPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ProductPrice_Leave(object sender, EventArgs e)
        {
            if (decimal.TryParse(ProductPrice.Text, out decimal price))
            {
                ProductPrice.Text = price.ToString("0.00");
            }
        }

        private void ProductPrice_TextChanged(object sender, EventArgs e)
        {
            decimal number;
            if ((!Decimal.TryParse(ProductPrice.Text, out number)) && !string.IsNullOrWhiteSpace(ProductPrice.Text))
            {
                MessageBox.Show("Enter price in a 0.00 format.");
                ProductPrice.Clear();
                return;

            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            main.MaterialTabControl1.SelectedTab = main.MaterialTabControl1.TabPages["Products"];
            main.Show();
            this.Hide();
        }

    }
}
