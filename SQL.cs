using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Web;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace JourneyX
{
    internal class SQL
    { 
        //string connection = @"data source = DESKTOP-1H91E26\SQLEXPRESS; Initial Catalog = JourneyX; User ID = admin; Password = pramod1234";
        string connection = @"Data Source=PRAMOD_MADHUBHA\SQLEXPRESS; Initial Catalog=JourneyX; Integrated Security=True;";

        public bool ProfileDetails(string FirstName, string LastName, string Address, DateTime BirthDay, int Gender, string Email, string PhoneNumber, string Password)
        {            
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connection))
                {
                    sqlConnection.Open();
                    string UserDetails = "INSERT INTO Users (FirstName, LastName, Address, BirthDay, Gender, Email, PhoneNumber, Password ) VALUES(@FirstName, @LastName, @Address, @BirthDay, @Gender, @Email, @PhoneNumber, @Password)";

                    using (SqlCommand sqlCommand = new SqlCommand(UserDetails, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@FirstName", FirstName);
                        sqlCommand.Parameters.AddWithValue("@LastName", LastName);
                        sqlCommand.Parameters.AddWithValue("@Address", Address);
                        sqlCommand.Parameters.AddWithValue("@BirthDay", BirthDay);
                        sqlCommand.Parameters.AddWithValue("@Gender", Gender);
                        sqlCommand.Parameters.AddWithValue("@Email", Email);
                        sqlCommand.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                        sqlCommand.Parameters.AddWithValue("@Password", Password);

                        int result = sqlCommand.ExecuteNonQuery();                       
                        return result > 0;
                    }
                    
                }
            }
            catch(Exception ex)
            {
                return false;      
            }
           
        }
        public string Login(string Email, string password)        
        {      
            
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connection))
                {
                    sqlConnection.Open();
                    string login = "SELECT * FROM Users WHERE Email=@Email AND Password=@password";

                    using (SqlCommand sqlCommand = new SqlCommand(login, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@Email", Email);
                        sqlCommand.Parameters.AddWithValue("@Password", password);

                        using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                        {
                            if (sqlDataReader.HasRows) { return "AA1111"; }
                            else { return "AA0000"; }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return "--Error--";
            }
        }


        public string Dashboard(string Email)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connection))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("SELECT FirstName, PPicture FROM Users WHERE Email = @PrimaryKeyValue", sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@PrimaryKeyValue", Email);

                        using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                        {
                            if (sqlDataReader.Read())
                            {
                                string FirstName = sqlDataReader.GetString(sqlDataReader.GetOrdinal("FirstName"));
                                int ProfilePictureId = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("PPicture"));

                                
                                string ProfilePictureIdString = ProfilePictureId.ToString();                              
                                string result = FirstName + "+" + ProfilePictureIdString;

                                return result;
                            }
                            else
                            {
                                return "--No Data--";
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return "--Error--";
            }
        }


        public string PDetails(string Email)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connection))
                {
                    sqlConnection.Open();

                    using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Users WHERE Email=@Email", sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@Email", Email);

                        using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                        {
                            if (sqlDataReader.Read())
                            {
                                string UEmail = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Email"));
                                string UFirstName = sqlDataReader.GetString(sqlDataReader.GetOrdinal("FirstName"));
                                string ULastName = sqlDataReader.GetString(sqlDataReader.GetOrdinal("LastName"));
                                string UAddress = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Address"));
                                DateTime Birthday = sqlDataReader.GetDateTime(sqlDataReader.GetOrdinal("BirthDay"));
                                int UGender = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("Gender"));
                                string UPhoneNumber = sqlDataReader.GetString(sqlDataReader.GetOrdinal("PhoneNumber"));
                                int UProfilePicture = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("PPicture"));

                                string Textjoin = string.Join("+", UEmail, UFirstName, ULastName, UAddress, Birthday, UGender, UPhoneNumber, UProfilePicture);
                                return Textjoin;
                            }
                            else
                            {
                                
                                return "--No Data--";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return "--Error--";
            }
        }
        public string adminPDetails(string Email)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connection))
                {
                    sqlConnection.Open();

                    using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Admin WHERE Email=@Email", sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@Email", Email);

                        using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                        {
                            if (sqlDataReader.Read())
                            {
                                string UEmail = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Email"));
                                string UFirstName = sqlDataReader.GetString(sqlDataReader.GetOrdinal("FirstName"));
                                string ULastName = sqlDataReader.GetString(sqlDataReader.GetOrdinal("LastName"));
                                string UAddress = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Address"));
                                DateTime Birthday = sqlDataReader.GetDateTime(sqlDataReader.GetOrdinal("BirthDay"));
                                int UGender = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("Gender"));
                                string UPhoneNumber = sqlDataReader.GetString(sqlDataReader.GetOrdinal("PhoneNumber"));
                                int UProfilePicture = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("PPicture"));

                                string Textjoin = string.Join("+", UEmail, UFirstName, ULastName, UAddress, Birthday, UGender, UPhoneNumber, UProfilePicture);
                                return Textjoin;
                            }
                            else
                            {

                                return "--No Data--";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return "--Error--";
            }
        }


        public string InsertSchedule(string province, string place, string email, DateTime date)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connection))
                {
                    sqlConnection.Open();

                    string insertQuery = "INSERT INTO Schedule (Province, Place, Email, Date) " +
                                         "VALUES (@Province, @Place, @Email, @Date)";

                    using (SqlCommand sqlCommand = new SqlCommand(insertQuery, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@Province", province);
                        sqlCommand.Parameters.AddWithValue("@Place", place);
                        sqlCommand.Parameters.AddWithValue("@Email", email);
                        sqlCommand.Parameters.AddWithValue("@Date", date);

                        sqlCommand.ExecuteNonQuery();
                    }

                    return "Insert successful";
                }
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }

        public string[] MySchedule(string Email)
        {
            string[] placesAndDates = new string[6]; 

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connection))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("SELECT TOP 3 Place, Date FROM Schedule WHERE Email = @PrimaryKeyValue", sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@PrimaryKeyValue", Email);

                        using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                        {
                            int index = 0;
                            while (sqlDataReader.Read())
                            {
                                string place = sqlDataReader["Place"].ToString();
                                string date = sqlDataReader["Date"].ToString();

                               
                                placesAndDates[index] = place + " - " + date;
                                index++;
                            }
                           
                            while (index < 3)
                            {
                                placesAndDates[index] = "--No Data--";
                                index++;
                            }
                        }
                    }
                }
                return placesAndDates;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return new string[] { "--Error22--" };
            }
        }

        public bool UpdateUserProfile(string email, string firstName, string lastName, string address, int profilePicture)
        {
            
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connection))
                {
                    sqlConnection.Open();

                    string updateQuery = "UPDATE Users SET FirstName = @FirstName, LastName = @LastName, Address = @Address, PPicture = @ProfilePicture WHERE Email = @Email";

                    using (SqlCommand sqlCommand = new SqlCommand(updateQuery, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@FirstName", firstName);
                        sqlCommand.Parameters.AddWithValue("@LastName", lastName);
                        sqlCommand.Parameters.AddWithValue("@Address", address);
                        sqlCommand.Parameters.AddWithValue("@ProfilePicture", profilePicture);
                        sqlCommand.Parameters.AddWithValue("@Email", email);

                        int rowsAffected = sqlCommand.ExecuteNonQuery();
                        
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }


        public bool InsertFeedback(string comment, string email, int face)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connection))
                {
                    sqlConnection.Open();

                    string insertQuery = "INSERT INTO Feedback (Comment, Email, face) VALUES (@Comment, @Email, @face)";

                    using (SqlCommand sqlCommand = new SqlCommand(insertQuery, sqlConnection))
                    {
                      
                        sqlCommand.Parameters.AddWithValue("@Comment", comment);
                        sqlCommand.Parameters.AddWithValue("@Email", email);
                        sqlCommand.Parameters.AddWithValue("@face", face);

                        int rowsAffected = sqlCommand.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception)
            {
                return false; 
            }
        }


        public bool Insert(string pickup, string dropLocation, DateTime date, string email, int vehicle)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connection))
                {
                    sqlConnection.Open();

                    string insertQuery = "INSERT INTO TaxiBook (pickup, droplocation, date, Email, vehicle) " +
                                         "VALUES (@Pickup, @DropLocation, @Date, @Email, @Vehicle)";

                    using (SqlCommand sqlCommand = new SqlCommand(insertQuery, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@Pickup", pickup);
                        sqlCommand.Parameters.AddWithValue("@DropLocation", dropLocation);
                        sqlCommand.Parameters.AddWithValue("@Date", date);
                        sqlCommand.Parameters.AddWithValue("@Email", email);
                        sqlCommand.Parameters.AddWithValue("@Vehicle", vehicle);

                        int rowsAffected = sqlCommand.ExecuteNonQuery();

                        Console.WriteLine($"Rows affected: {rowsAffected}");

                        return rowsAffected > 0;
                    }
                }
            }
            catch (SqlException )
            {               
                return false;
            }
            catch (Exception )
            {
                return false;
            }
        }






        public bool InsertOffer(string offerText)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connection))
                {
                    sqlConnection.Open();
                  
                    string insertQuery = "INSERT INTO Offers (Offers, Date) OUTPUT INSERTED.OffersID VALUES (@Offers, GETDATE())";

                    using (SqlCommand sqlCommand = new SqlCommand(insertQuery, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@Offers", offerText);
                       
                        int offersID = (int)sqlCommand.ExecuteScalar();
                       
                        Console.WriteLine($"Offer inserted with OffersID: {offersID}");

                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }


        public bool AdmineDetails(string FirstName, string LastName, string Address, DateTime BirthDay, int Gender, string Email, string PhoneNumber, string Password)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connection))
                {
                    sqlConnection.Open();
                    string UserDetails = "INSERT INTO Admin (FirstName, LastName, Address, BirthDay, Gender, Email, PhoneNumber, Password ) VALUES(@FirstName, @LastName, @Address, @BirthDay, @Gender, @Email, @PhoneNumber, @Password)";

                    using (SqlCommand sqlCommand = new SqlCommand(UserDetails, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@FirstName", FirstName);
                        sqlCommand.Parameters.AddWithValue("@LastName", LastName);
                        sqlCommand.Parameters.AddWithValue("@Address", Address);
                        sqlCommand.Parameters.AddWithValue("@BirthDay", BirthDay);
                        sqlCommand.Parameters.AddWithValue("@Gender", Gender);
                        sqlCommand.Parameters.AddWithValue("@Email", Email);
                        sqlCommand.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                        sqlCommand.Parameters.AddWithValue("@Password", Password);

                        int result = sqlCommand.ExecuteNonQuery();
                        Console.WriteLine(result);
                        return result > 0;
                    }

                }
            }
            catch (SqlException sqlEx)
            {
               return false;
            }
            catch (Exception ex)
            {
              return false;
            }

        }

        public string AdminLogin(string Email, string password)
        {

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connection))
                {
                    sqlConnection.Open();
                    string login = "SELECT * FROM Admin WHERE Email=@Email AND Password=@password";

                    using (SqlCommand sqlCommand = new SqlCommand(login, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@Email", Email);
                        sqlCommand.Parameters.AddWithValue("@Password", password);

                        using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                        {
                            if (sqlDataReader.HasRows) { return "ADMIN3550"; }
                            else { return "AA0000"; }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return "--Error--";
            }
        }

        public string GetFirstThreeOffersDetails()
        {
            StringBuilder resultBuilder = new StringBuilder();

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connection))
                {
                    sqlConnection.Open();

                    using (SqlCommand sqlCommand = new SqlCommand("SELECT TOP 4 Offers, Date FROM Offers ORDER BY OffersID ASC", sqlConnection))
                    {
                        using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                        {
                            while (sqlDataReader.Read())
                            {
                                string offer = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Offers"));
                                DateTime date = sqlDataReader.GetDateTime(sqlDataReader.GetOrdinal("Date"));

                                string formattedDate = date.ToString("yyyy-MM-dd HH:mm:ss");
                                resultBuilder.Append(offer).Append(" - ").Append(formattedDate).Append("+");
                            }
                        }
                    }
                }

                string result = resultBuilder.ToString().TrimEnd('+');
                return !string.IsNullOrEmpty(result) ? result : "--No Data--";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return "--Error--";
            }
        }


        public bool UpdateUserProfileAdmin(string email, string firstName, string lastName, string address, int profilePicture)
        {

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connection))
                {
                    sqlConnection.Open();

                    string updateQuery = "UPDATE Users SET FirstName = @FirstName, LastName = @LastName, Address = @Address, PPicture = @ProfilePicture WHERE Email = @Email";

                    using (SqlCommand sqlCommand = new SqlCommand(updateQuery, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@FirstName", firstName);
                        sqlCommand.Parameters.AddWithValue("@LastName", lastName);
                        sqlCommand.Parameters.AddWithValue("@Address", address);
                        sqlCommand.Parameters.AddWithValue("@ProfilePicture", profilePicture);
                        sqlCommand.Parameters.AddWithValue("@Email", email);

                        int rowsAffected = sqlCommand.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }



    }
}
