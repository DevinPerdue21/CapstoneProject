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
    public partial class ForgotPassword : MaterialForm
    {
        private readonly DBQueries dBQueries;
        public ForgotPassword()
        {
            InitializeComponent();

            string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            dBQueries = new DBQueries(constr);

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey500, Primary.BlueGrey700, Primary.BlueGrey100, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string firstname = FirstName.Text;
            string lastname = LastName.Text;
            string username = Username.Text;
            string password = NewPassword.Text;

            if(FirstName.Text != string.Empty && LastName.Text != string.Empty && Username.Text != string.Empty && NewPassword.Text != string.Empty)
            {
                bool isValid = dBQueries.ForgotPassword(firstname, lastname, username);
                if (isValid)
                {
                    bool isUpdated = dBQueries.ChangePassword(firstname, lastname, username, password);
                    if (isUpdated)
                    {
                        MessageBox.Show("Password is Updated!");
                        Login login = new Login();
                        login.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("The information you provided does not match our records. please create a new User or try again!");
                }
            }
            else
            {
                MessageBox.Show("All Fields are Required!");
            }
        }

        private void FirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
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

        private void CreateUser_Click(object sender, EventArgs e)
        {
            NewUser newUser = new NewUser();
            newUser.Show();
            this.Hide();
        }
    }
}
