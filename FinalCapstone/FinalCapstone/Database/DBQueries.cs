using FinalCapstone.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FinalCapstone.Database
{
    public class DBQueries
    {
        private readonly string connectionString;

        public DBQueries(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool IsUsernameAndPasswordValid(string username, string password)
        {
            bool isValid = false;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "SELECT COUNT(*) FROM Login WHERE username = @Username AND password =@Password";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        connection.Open();
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        isValid = count > 0;
                    }
                }
                return isValid;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool CheckforParts(int ID)
        {
            bool isValid = false;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "SELECT COUNT(*) FROM productparts WHERE ProductID = @ID";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ID", ID);

                        connection.Open();
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        isValid = count < 1;
                    }
                }
                return isValid;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool UniqueUsername(string Username)
        {
            bool isValid = false;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "SELECT COUNT(*) FROM Login WHERE username = @Username";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Username", Username);

                        connection.Open();
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        isValid = count == 0;
                    }
                }
                return isValid;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool ForgotPassword(string FirstName, string LastName, string Username)
        {
            bool isValid = false;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "SELECT COUNT(*) FROM Login WHERE FirstName = @firstname AND LastName = @lastname AND username = @Username";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@firstname", FirstName);
                        cmd.Parameters.AddWithValue("@lastname", LastName);
                        cmd.Parameters.AddWithValue("@Username", Username);

                        connection.Open();
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        isValid = count > 0;
                    }
                }
                return isValid;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool ChangePassword(string FirstName, string LastName, string Username, string Password)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "Update Login set Password = @password where Username = @username AND FirstName = @firstname AND LastName = @lastname";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@password", Password);
                        cmd.Parameters.AddWithValue("@username", Username);
                        cmd.Parameters.AddWithValue("@firstname", FirstName);
                        cmd.Parameters.AddWithValue("@lastname", LastName);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool AddNewUser(string FirstName, string LastName, string Username, string Password)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO login VALUES (NULL,@username, @password, @firstname, @lastname)";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", Username);
                        cmd.Parameters.AddWithValue("@password", Password);
                        cmd.Parameters.AddWithValue("@firstname", FirstName);
                        cmd.Parameters.AddWithValue("@lastname", LastName);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool AddInhousePart(Inhouse inhouse)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO parts VALUES (NULL,@Name, @Price, 'Inhouse', @MachineID, NULL, @Inventory)";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Name", inhouse.Name);
                        cmd.Parameters.AddWithValue("@Price", inhouse.Price);
                        cmd.Parameters.AddWithValue("@MachineID", inhouse.MachineID);
                        cmd.Parameters.AddWithValue("@Inventory", inhouse.Inventory);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool AddOutsourcedPart(Outsourced outsourced)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO parts VALUES (NULL,@Name, @Price, 'Outsourced', NULL, @CompanyName, @Inventory)";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Name", outsourced.Name);
                        cmd.Parameters.AddWithValue("@Price", outsourced.Price);
                        cmd.Parameters.AddWithValue("@CompanyName", outsourced.CompanyName);
                        cmd.Parameters.AddWithValue("@Inventory", outsourced.Inventory);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public DataTable PartsData()
        {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT PartID, PartName, Price, PartType, Inventory FROM parts";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            return dt;
                        }
                        
                    }
                }
        }

        public DataTable PartswithProducts(int ID)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT parts.PartID, parts.PartName, parts.Price, parts.Inventory FROM parts, products, productparts WHERE parts.PartID = productparts.PartID AND products.ProductID = productparts.ProductID AND productparts.ProductID = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", ID);
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }

                }
            }
        }

        public DataTable ProductsData()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT ProductID, ProductName, Price, Inventory FROM products";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }

                }
            }
        }

        public string PartName(int ID)
        {
            string partName = null;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT PartName from parts WHERE partID = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", ID);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    
                    if(reader.Read())
                    {
                        partName = reader.GetString(0);
                    }
                }
            }
            return partName;
        }

        public decimal PartPrice(int ID)
        {
            decimal partName = 0;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Price from parts WHERE partID = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", ID);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        partName = reader.GetDecimal(0);
                    }
                }
            }
            return partName;
        }

        public int PartInventory(int ID)
        {
            int partName = 0;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Inventory from parts WHERE partID = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", ID);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        partName = reader.GetInt32(0);
                    }
                }
            }
            return partName;
        }

        public string PartType(int ID)
        {
            string partType = null;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT PartType from parts WHERE partID = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", ID);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        partType = reader.GetString(0);
                    }
                }
            }
            return partType.ToUpper();
        }

        public int MachineID(int ID)
        {
            int machineID = 0;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT MachineID from parts WHERE partID = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", ID);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        machineID = reader.GetInt32(0);
                    }
                }
            }
            return machineID;
        }

        public string CompanyName(int ID)
        {
            string companyName = null;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT CompanyName from parts WHERE partID = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", ID);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        companyName = reader.GetString(0);
                    }
                }
            }
            return companyName;
        }

        public bool ModifyInhousePart(Inhouse inhouse, int ID)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE parts SET PartName =@Name, Price = @Price, PartType = 'Inhouse', MachineID = @MachineID, CompanyName = NULL, Inventory = @Inventory WHERE PartID = @ID ";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Name", inhouse.Name);
                        cmd.Parameters.AddWithValue("@Price", inhouse.Price);
                        cmd.Parameters.AddWithValue("@MachineID", inhouse.MachineID);
                        cmd.Parameters.AddWithValue("@Inventory", inhouse.Inventory);
                        cmd.Parameters.AddWithValue("@Inventory", ID);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool ModifyOutsourcedPart(Outsourced outsourced, int ID)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE parts SET PartName =@Name, Price = @Price, PartType = 'Outsourced', MachineID = NULL, CompanyName = @CompanyName, Inventory = @Inventory WHERE PartID = @ID ";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Name", outsourced.Name);
                        cmd.Parameters.AddWithValue("@Price", outsourced.Price);
                        cmd.Parameters.AddWithValue("@CompanyName", outsourced.CompanyName);
                        cmd.Parameters.AddWithValue("@Inventory", outsourced.Inventory);
                        cmd.Parameters.AddWithValue("@ID", ID);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool ModifyProduct(Product product, int ID)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE products SET ProductName =@Name, Price = @Price, Inventory = @Inventory WHERE ProductID = @ID ";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Name", product.Name);
                        cmd.Parameters.AddWithValue("@Price", product.Price);
                        cmd.Parameters.AddWithValue("@Inventory", product.Inventory);
                        cmd.Parameters.AddWithValue("@ID", ID);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool DeletePart(int ID)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM parts WHERE PartID = @ID";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ID", ID);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool DeleteProduct(int ID)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM products WHERE ProductID = @ID";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ID", ID);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public int AddProduct(Product product)
        {
                int productID = 0;
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO products VALUES (NULL,@Name, @Price, @Inventory); SELECT LAST_INSERT_ID();";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Name", product.Name);
                        cmd.Parameters.AddWithValue("@Price", product.Price);
                        cmd.Parameters.AddWithValue("@Inventory", product.Inventory);
                        productID = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
                return productID;
        }

        public bool AddProductParts(int productID, List<int>partIDs)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    foreach(int partID in partIDs)
                    {
                        string query = "INSERT INTO productparts VALUES(@ProductID, @PartID)";
                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@ProductID", productID);
                            cmd.Parameters.AddWithValue("@PartID", partID);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    
                }
                return true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool DeleteProductParts(int productID)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                        string query = "DELETE FROM productparts WHERE ProductID = @id";
                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@id", productID);
                            cmd.ExecuteNonQuery();
                        }

                }
                return true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool UpdateProductParts(int productID, List<int> partIDs)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    foreach (int partID in partIDs)
                    {
                        string query = "INSERT INTO productparts VALUES(@ProductID, @PartID)";
                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@ProductID", productID);
                            cmd.Parameters.AddWithValue("@PartID", partID);
                            cmd.ExecuteNonQuery();
                        }
                    }

                }
                return true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public string ProductName(int ID)
        {
            string productName = null;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT ProductName from products WHERE productID = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", ID);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        productName = reader.GetString(0);
                    }
                }
            }
            return productName;
        }

        public decimal ProductPrice(int ID)
        {
            decimal productPrice = 0;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Price from products WHERE productID = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", ID);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        productPrice = reader.GetDecimal(0);
                    }
                }
            }
            return productPrice;
        }

        public int ProductInventory(int ID)
        {
            int productInventory = 0;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Inventory from products WHERE productID = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", ID);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        productInventory = reader.GetInt32(0);
                    }
                }
            }
            return productInventory;
        }

        public List<string> GetInhouseReport()
        {
            List<string> inhouseParts = new List<string>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT PartName from parts WHERE PartType = 'Inhouse'";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string partName = reader.GetString("PartName");
                        inhouseParts.Add(partName);  
                    }
                }
            }
            return inhouseParts;
        }
        
        public List<string> GetOutsourcedReport()
        {
            List<string> outsourcedParts = new List<string>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT PartName from parts WHERE PartType = 'Outsourced'";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string partName = reader.GetString("PartName");
                        outsourcedParts.Add(partName);
                    }
                }
            }
            return outsourcedParts;
        }

        public List<string> GetLowInventory()
        {
            List<string> outsourcedParts = new List<string>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT PartName from parts WHERE Inventory < 20";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string partName = reader.GetString("PartName");
                        outsourcedParts.Add(partName);
                    }
                }
            }
            return outsourcedParts;
        }

        public bool InitialData()
        {
            using(MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlTransaction transaction = connection.BeginTransaction(); 

                try
                {
                    string createDatabase = "CREATE DATABASE IF NOT EXISTS inventory";
                    using(MySqlCommand cmd = new MySqlCommand(createDatabase, connection, transaction))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    string createTables = "CREATE TABLE IF NOT EXISTS parts (PartID INT AUTO_INCREMENT PRIMARY KEY, PartName VARCHAR(255), Price DECIMAL(10,2), PartType ENUM('Inhouse', 'Outsourced'), MachineID int, CompanyName VARCHAR(255), Inventory int); INSERT INTO parts (PartName, Price, PartType, MachineID, CompanyName, Inventory) VALUES ('Wheel', 20.99, 'Inhouse', 1234, NULL, 40), ('Engine', 200.99, 'Outsourced', NULL,'Engine Inc.', 10), ('Exhaust', 30.99, 'Inhouse', 12345, NULL, 15);";
                    using (MySqlCommand cmd = new MySqlCommand(createTables, connection, transaction))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    string createTables1 = "CREATE TABLE IF NOT EXISTS products (ProductID INT AUTO_INCREMENT PRIMARY KEY, ProductName VARCHAR(255), Price DECIMAL(10,2), Inventory int); INSERT INTO products (ProductName, Price, Inventory) VALUES ('Toy Car', 500.99, 5),('Scooter', 200.99, 10);";
                    using (MySqlCommand cmd = new MySqlCommand(createTables1, connection, transaction))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    string createTables2 = "CREATE TABLE IF NOT EXISTS productparts (ProductID int , PartID int , FOREIGN KEY (ProductID) REFERENCES products(ProductID), FOREIGN KEY (PartID) REFERENCES parts(PartID)); INSERT INTO productparts (ProductID, PartID) VALUES (1,1), (1,2), (1,3), (2,1), (2,2);";
                    using (MySqlCommand cmd = new MySqlCommand(createTables2, connection, transaction))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    string createTables3 = "CREATE TABLE IF NOT EXISTS login (LoginID int AUTO_INCREMENT PRIMARY KEY, Username VARCHAR(255), Password VARCHAR(255), FirstName VARCHAR(255), LastName VARCHAR(255)); INSERT INTO login (Username, Password, FirstName, LastName) VALUES ('DevinPerdue', 12345, 'Devin', 'Perdue');";
                    using (MySqlCommand cmd = new MySqlCommand(createTables3, connection, transaction))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    transaction.Rollback();
                    return false;
                }
            }
        }

        public bool DeleteData()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "drop tables login, parts, productparts, products";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //public void CreateDatabase()
        //{
        //    try
        //    {
        //        using (MySqlConnection connection = new MySqlConnection(connectionString))
        //        {
        //            connection.Open();
        //            string query = "CREATE USER if not exists 'evaluator'@'%' IDENTIFIED WITH mysql_native_password BY ''; GRANT ALL PRIVILEGES ON *.* TO 'evaluator'@'%'; FLUSH PRIVILEGES; CREATE DATABASE IF NOT exists inventory;use inventory;";
        //            using (MySqlCommand cmd = new MySqlCommand(query, connection))
        //            {
        //                cmd.ExecuteNonQuery();
        //            }
        //        }
        //    }

        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
    }
}
