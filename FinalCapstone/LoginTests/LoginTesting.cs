using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinalCapstone;
using FinalCapstone.Database;

namespace LoginTests
{
    [TestClass]
    public class LoginTesting
    {
        [TestMethod]
        public void TestUsernameAndPasswordExists()
        {
            //Arrange
            string connectionString = "Host=localhost;Port=3306;Database=inventory;Username=sqlUser;Password=Passw0rd!";
            var dBQueries = new DBQueries(connectionString);

            //Act
            bool existingUser = dBQueries.IsUsernameAndPasswordValid("DevinPerdue", "123456789");
            bool nonexistingUser = dBQueries.IsUsernameAndPasswordValid("Bobby", "12345");

            //Assert
            Assert.IsTrue(existingUser);
            Assert.IsFalse(nonexistingUser);
        }

        [TestMethod]
        public void CreateNewUserTest()
        {
            //Arrange
            string connectionString = "Host=localhost;Port=3306;Database=inventory;Username=sqlUser;Password=Passw0rd!";
            var dBQueries = new DBQueries(connectionString);

            //Act
            bool existingUsername = dBQueries.UniqueUsername("John1234");
            bool nonexistingUsername = dBQueries.UniqueUsername("DevinPerdue");
            bool addeduser = dBQueries.AddNewUser("John", "Daily", "John1234567", "123456");

            //Assert
            Assert.IsTrue(existingUsername);
            Assert.IsFalse(nonexistingUsername);
            Assert.IsTrue(addeduser);
        }

        [TestMethod]
        public void ForgotPasswordTest()
        {
            //Arrange
            string connectionString = "Host=localhost;Port=3306;Database=inventory;Username=sqlUser;Password=Passw0rd!";
            var dBQueries = new DBQueries(connectionString);

            //Act
            bool existingUser = dBQueries.ForgotPassword("Devin", "Perdue", "DevinPerdue");
            bool nonexistingUser = dBQueries.ForgotPassword("Bobby","Blue", "BobbyBlue");
            bool newPassword = dBQueries.ChangePassword("Devin", "Perdue", "DevinPerdue", "123456789");

            //Assert
            Assert.IsTrue(existingUser);
            Assert.IsFalse(nonexistingUser);
            Assert.IsTrue(newPassword);
        }
    }
}
