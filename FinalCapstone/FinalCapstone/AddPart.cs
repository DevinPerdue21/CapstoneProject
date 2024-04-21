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
    public partial class AddPart : MaterialForm
    {
        private readonly DBQueries dBQueries;
        public AddPart()
        {
            InitializeComponent();

            string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            dBQueries = new DBQueries(constr);

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey500, Primary.BlueGrey700, Primary.BlueGrey100, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Inhouse_CheckedChanged(object sender, EventArgs e)
        {
            if (Inhouse.Checked)
            {
                PartType.Hint = "MachineID";
                PartType.Clear();
                PartType.KeyPress += PartType_KeyPress;
            }
        }

        private void Outsourced_CheckedChanged(object sender, EventArgs e)
        {
            if(Outsourced.Checked)
            {
                PartType.Hint = "Company Name";
                PartType.Clear();
                PartType.KeyPress -= PartType_KeyPress;
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (PartName.Text != string.Empty && PartPrice.Text != string.Empty && PartType.Text != string.Empty && PartInventory.Text != string.Empty)
            {
                if (Inhouse.Checked == true)
                {
                    string name = PartName.Text;
                    decimal price = decimal.Parse(PartPrice.Text);
                    int type = int.Parse(PartType.Text);
                    int inventory = int.Parse(PartInventory.Text);

                    Inhouse inhouse = new Inhouse
                    {
                        Name = name,
                        Price = price,
                        Inventory = inventory,
                        MachineID = type,

                    };
                    bool isAdded = dBQueries.AddInhousePart(inhouse);
                    if(isAdded)
                    {
                        MessageBox.Show("Part was successfully added!");
                        MainMenu main = new MainMenu();
                        main.Show();
                        this.Hide();
                    }
                }
                if(Outsourced.Checked == true)
                {
                    string name = PartName.Text;
                    decimal price = decimal.Parse(PartPrice.Text);
                    string type = PartType.Text;
                    int inventory = int.Parse(PartInventory.Text);

                    Outsourced outsource = new Outsourced
                    {
                        Name = name,
                        Price = price,
                        Inventory = inventory,
                        CompanyName = type,

                    };
                    bool isAdded = dBQueries.AddOutsourcedPart(outsource);
                    if (isAdded)
                    {
                        MessageBox.Show("Part was successfully added!");
                        MainMenu main = new MainMenu();
                        main.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                MessageBox.Show("All fields must be filled out!");
            }
            
        }

        private void PartType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PartInventory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PartPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void PartPrice_Leave(object sender, EventArgs e)
        {
            if(decimal.TryParse(PartPrice.Text, out decimal price))
            {
                PartPrice.Text = price.ToString("0.00");
            }
        }

        private void PartPrice_TextChanged(object sender, EventArgs e)
        {
            decimal number;
            if((!Decimal.TryParse(PartPrice.Text, out number)) && !string.IsNullOrWhiteSpace(PartPrice.Text))
            {
                MessageBox.Show("Enter price in a 0.00 format.");
                PartPrice.Clear();
                return;
                
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            main.Show();
            this.Hide();
        }
    }
}
