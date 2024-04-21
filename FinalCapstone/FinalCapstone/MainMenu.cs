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
    public partial class MainMenu : MaterialForm
    {
        private readonly DBQueries dBQueries;
        public MainMenu()
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

            DataTable d2 = dBQueries.ProductsData();
            d2.DefaultView.Sort = "ProductID ASC";

            PartListView.MultiSelect = false;
            ProductsListView.MultiSelect = false;

            foreach (DataRow row in d1.Rows)
            {
                ListViewItem listViewItem = new ListViewItem(row["PartID"].ToString());
                listViewItem.SubItems.Add(row["PartName"].ToString());
                listViewItem.SubItems.Add(row["Price"].ToString());
                listViewItem.SubItems.Add(row["Inventory"].ToString());

                PartListView.Items.Add(listViewItem);
            }

            foreach (DataRow row in d2.Rows)
            {
                ListViewItem listViewItem1 = new ListViewItem(row["ProductID"].ToString());
                listViewItem1.SubItems.Add(row["ProductName"].ToString());
                listViewItem1.SubItems.Add(row["Price"].ToString());
                listViewItem1.SubItems.Add(row["Inventory"].ToString());

                ProductsListView.Items.Add(listViewItem1);
            }



        }

        private void AddPart_Click(object sender, EventArgs e)
        {
            AddPart add = new AddPart();
            add.Show();
            this.Hide();
        }

        private void ModifyPart_Click(object sender, EventArgs e)
        { 
            if (PartListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedPart = PartListView.SelectedItems[0];
                string selectedData = selectedPart.SubItems[0].Text;
                if (int.TryParse(selectedData, out int partID))
                {
                    int Id = partID;
                    ModifyPart modify = new ModifyPart(Id);
                    modify.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Please select something to modify");
            }
            
        }

        private void PartListView_Click(object sender, EventArgs e)
        {
            
        }

        private void materialButton8_Click(object sender, EventArgs e)
        {
            string search = SearchParts.Text.ToUpper();

            foreach(ListViewItem item in PartListView.Items)
            {
                item.Selected = false;
                if (item.SubItems[1].Text.ToUpper().StartsWith(search))
                {
                    item.Selected = true;
                    item.EnsureVisible();
                }
            }
        }

        private void SearchParts_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeletePart_Click(object sender, EventArgs e)
        {
            if (PartListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedPart = PartListView.SelectedItems[0];
                string selectedData = selectedPart.SubItems[0].Text;
                if (int.TryParse(selectedData, out int partID))
                {
                    if(DialogResult.Yes == MessageBox.Show("Are you sure you want to delete this part?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        bool isDeleted = dBQueries.DeletePart(partID);
                        if (isDeleted)
                        {
                            MessageBox.Show("Part successfully deleted!");
                            MainMenu main = new MainMenu();
                            main.Show();
                            this.Hide();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select something to delete");
            }
        }
        public MaterialTabControl MaterialTabControl1
        {
            get { return materialTabControl1; }
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            AddProduct product = new AddProduct();
            product.Show();
            this.Hide();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string search = SearchProduct.Text.ToUpper();

            foreach (ListViewItem item in ProductsListView.Items)
            {
                item.Selected = false;
                if (item.SubItems[1].Text.ToUpper().StartsWith(search))
                {
                    item.Selected = true;
                    item.EnsureVisible();
                }
            }
        }

        private void ModifyProduct_Click(object sender, EventArgs e)
        {
            if (ProductsListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedProduct = ProductsListView.SelectedItems[0];
                string selectedData = selectedProduct.SubItems[0].Text;
                if (int.TryParse(selectedData, out int productID))
                {
                    int Id = productID;
                    ModifyProduct mod = new ModifyProduct(Id);
                    mod.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Please select something to modify");
            }

            
        }

        private void DeleteProduct_Click(object sender, EventArgs e)
        {
            if (ProductsListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedProduct = ProductsListView.SelectedItems[0];
                string selectedData = selectedProduct.SubItems[0].Text;
                if (int.TryParse(selectedData, out int productID))
                {
                    if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete this part?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        bool noParts = dBQueries.CheckforParts(productID);
                        if(noParts)
                        {
                            bool isDeleted = dBQueries.DeleteProduct(productID);
                            if (isDeleted)
                            {
                                MessageBox.Show("Part successfully deleted!");
                                MainMenu main = new MainMenu();
                                main.MaterialTabControl1.SelectedTab = main.MaterialTabControl1.TabPages["Products"];
                                main.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("The product you are trying to delete has a part associated with it. Please delete the part from the product and try again!");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select something to delete");
            }
        }

        private void generate_Click(object sender, EventArgs e)
        {
            if(typeOfPart.Checked)
            {
                List<string> inhouse = dBQueries.GetInhouseReport();
                string results = "";
                string results1 = "";
                foreach (string partName in  inhouse)
                {
                    results += partName + "\n";
                }

                List<string> outsourced = dBQueries.GetOutsourcedReport();
                foreach (string partName in outsourced)
                {
                    results1 += partName + "\n";
                }

                report.Text = "Inhouse Parts:" + "\n" +  results + "\n" + "Outsourced Parts:" + "\n" + results1;
            }
            if(reorder.Checked)
            {
                List<string> low = dBQueries.GetLowInventory();
                string results = "";
                foreach (string partName in low)
                {
                    results += partName + "\n";
                }
                report.Text = "Parts for Reordering:" + "\n" + results;
            }
            
        }

        private void typeOfPart_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void log_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
