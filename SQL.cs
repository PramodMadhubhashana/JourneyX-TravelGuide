using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Web;

namespace JourneyX
{
    internal class SQL
    { 
        //string connection = @"data source = PRAMOD_MADHUBHA\SQLEXPRESS; Initial Catalog = JourneyX; User ID = admin; Password = pramod1234";
        string connection = @"Data Source=PRAMOD_MADHUBHA\SQLEXPRESS;Initial Catalog=JourneyX;Integrated Security=True;";

        public string ProfileDetails(string FirstName, string LastName, string Address, DateTime BirthDay, int Gender, string Email, string PhoneNumber, string Password)
        {            
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connection))
                {
                    sqlConnection.Open();
                    string UserDetails = "INSERT INTO Users (FirstName, LastName, Address, BirthDay, Gender, Email, phone_Number, Password ) VALUES(@FirstName, @LastName, @Address, @BirthDay, @Gender, @Email, @PhoneNumber, @Password)";

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

                        sqlCommand.ExecuteNonQuery();                        
                    }
                    sqlConnection.Close();
                }
            }
            catch(Exception ex)
            {
                return ex.ToString();
            }
            return null;
        }
        public string Login(string Email, String password)
        {
            try
            {
                using(SqlConnection sqlConnection = new SqlConnection(connection))
                {
                    sqlConnection.Open();
                    string login = "SELECT * FROM Users WHERE Email=@Email AND Password=@password";
                    using (SqlCommand sqlCommand = new SqlCommand(login, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@Email", Email);
                        sqlCommand.Parameters.AddWithValue("@Password", password);
                        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                        sqlDataReader.Close();
                        sqlConnection.Close();

                        if(sqlDataReader.HasRows)
                        {
                            if(Email == "ADMIN3550")
                            {
                                return "ADMIN3550";
                            }
                            else
                            {
                                return "AA1111";
                            }                                                      
                        }
                        else
                        {
                            return "AA0000";
                        }                       
                    }                    
                }
            }
            catch(Exception ex)
            {
                return ex.ToString();
            }            
        }

        public string Dashboard(string Email)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connection))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("SELECT FirstName FROM Users WHERE Email = @PrimaryKeyValue", sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@PrimaryKeyValue", Email);

                        using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                        {
                            if (sqlDataReader.Read())
                            {
                                string FirstName = sqlDataReader.GetString(sqlDataReader.GetOrdinal("FirstName"));
                                return FirstName;
                            }
                            else
                            {
                                // Handle the case where no rows are returned
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

                    using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM <table_name> WHERE email=@Email", sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@Email", Email);

                        using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                        {
                            string UEmail = sqlDataReader.GetString(0);
                            string UFirstName = sqlDataReader.GetString(1);
                            string ULastName = sqlDataReader.GetString(2);
                            string UAdress = sqlDataReader.GetString(3);
                            string Birthday = sqlDataReader.GetDateTime(4).ToString();
                            string UGender = sqlDataReader.GetInt32(5).ToString();
                            string UPhoneNumber = sqlDataReader.GetString(6);
                            string UProfilePicture = sqlDataReader.GetInt32(8).ToString();
                            sqlDataReader.Close();
                            sqlConnection.Close();

                            string Textjoin = string.Join("+", UEmail, UFirstName, ULastName, UAdress, Birthday, UGender, UPhoneNumber, UProfilePicture);
                            return Textjoin;
                        }
                    }
                }
            }
            catch (Exception)
            {
                return "--Error--";
            }
        }     

    }
}
