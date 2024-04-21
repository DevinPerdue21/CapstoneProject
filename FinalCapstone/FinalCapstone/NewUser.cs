using FinalCapstone.Database;
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
    public partial class NewUser : MaterialForm
    {
        private readonly DBQueries dBQueries;
        public NewUser()
        {
            InitializeComponent();

            string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            dBQueries = new DBQueries(constr);

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey500, Primary.BlueGrey700, Primary.BlueGrey100, Accent.LightBlue200, TextShade.WHITE);
        }

        private void CreateUser_Click(object sender, EventArgs e)
        {
            string first = FirstName.Text;
            string last = LastName.Text;
            string username = CreateUsername.Text;
            string password = CreatePassword.Text;

            if(FirstName.Text != string.Empty && LastName.Text != string.Empty && CreateUsername.Text != string.Empty && CreatePassword.Text != string.Empty)
            {
                bool isUnique = dBQueries.UniqueUsername(username);
                if(isUnique)
                {
                    bool isAdded = dBQueries.AddNewUser(first, last, username, password);
                    if (isAdded)
                    {
                        MessageBox.Show("New User Added!");
                        Login login = new Login();
                        login.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("New User Not Added!");
                    }
                }
                else
                {
                    MessageBox.Show("This username is already in use. Please Login!");
                }
               
            }
            else
            {
                MessageBox.Show("All Fields are Required!");
            }
           
        }

        private void FirstName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void FirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void LastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Login_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
