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
    public partial class Login : MaterialForm
    {
        private readonly DBQueries dBQueries;
        public Login()
        {
            InitializeComponent();

            string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            dBQueries = new DBQueries(constr);
            //dBQueries.CreateDatabase();
            //dBQueries.DeleteData();
            dBQueries.InitialData();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey500, Primary.BlueGrey700, Primary.BlueGrey100, Accent.LightBlue200, TextShade.WHITE);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = Username.Text;
            string password = Password.Text;


            bool isValid = dBQueries.IsUsernameAndPasswordValid(username, password);
            if (isValid)
            {
                MessageBox.Show("Login Successful!");
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Credentials provided are invalid!");
            }
        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
          

            
        }

        private void NewUser_Click(object sender, EventArgs e)
        {
            NewUser newUser = new NewUser();
            newUser.Show();
            this.Hide();

        }

        private void ForgotPassword_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.Show();
            this.Hide();
        }
    }
}
