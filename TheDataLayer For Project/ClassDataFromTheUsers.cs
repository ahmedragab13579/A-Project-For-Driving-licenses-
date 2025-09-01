using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlClient;


namespace TheDataLayer_For_Project
{
    public class ClassDataFromTheUsers
    {
    
        public static bool IsUserExist(string Name,string Password)
        {

            bool isfind = false;
            SqlConnection Connection = new SqlConnection(ClassTheConnectionData.StringConnection);
            string QueryForConnection = "select found=1 from Users where UserName = @Name and Password=@Password and IsActive = 1";
            SqlCommand Command = new SqlCommand(QueryForConnection, Connection);
            Command.Parameters.AddWithValue("@Name", Name);
            Command.Parameters.AddWithValue("@Password", Password);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    isfind = true;
                }
                else
                {
                    isfind = false;
                }
                Reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Connection.Close();
            }

            return isfind;
        }
        public static bool IsUserExist(int PersonID)
        {

            bool isfind = false;
            SqlConnection Connection = new SqlConnection(ClassTheConnectionData.StringConnection);
            string QueryForConnection = "select found=1 from Users where PersonID = @PersonID ";
            SqlCommand Command = new SqlCommand(QueryForConnection, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
           

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    isfind = true;
                }
                else
                {
                    isfind = false;
                }
                Reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Connection.Close();
            }

            return isfind;
        }


        public static DataTable GetAllInformationFromTheUsers()
        {
            DataTable table = new DataTable();
            SqlConnection FirstConnection = new SqlConnection(ClassTheConnectionData.StringConnection);
            string QueryForConnection = "select * from Users ";
            SqlCommand FirstCommand = new SqlCommand(QueryForConnection, FirstConnection);

            try
            {
                FirstConnection.Open();
                SqlDataReader FirstReader = FirstCommand.ExecuteReader();
                if (FirstReader.HasRows) { table.Load(FirstReader); }
                FirstReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            { FirstConnection.Close(); }


            return table;
        }


        public static bool GetUserById(ref int UserID, ref int PersonID, 
             ref string UserName,  ref string Password,ref bool IsActive )
        {
            bool isfind = false;
            SqlConnection Connection = new SqlConnection(ClassTheConnectionData.StringConnection);
            string QueryForConnection = @"select * from Users where UserID = @UserID";
            SqlCommand Command = new SqlCommand(QueryForConnection, Connection);
            Command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    isfind = true;
                    UserID = (int)Reader["UserID"];
                    PersonID = (int)Reader["PersonID"];
                    UserName = (string)Reader["UserName"];
                    Password = (string)Reader["Password"];
                    IsActive = (bool)Reader["IsActive"];
                   

                }
                else
                {
                    isfind = false;
                }
                Reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Connection.Close();
            }

            return isfind;
        }
       
        public static bool GetUserByNameAndPassword(ref int UserID, ref int PersonID, 
             ref string UserName,  ref string Password,ref bool IsActive )
        {
            bool isfind = false;
            SqlConnection Connection = new SqlConnection(ClassTheConnectionData.StringConnection);
            string QueryForConnection = "select * from Users where UserName = @Name and Password=@Password and IsActive = 1";
            SqlCommand Command = new SqlCommand(QueryForConnection, Connection);
            Command.Parameters.AddWithValue("@Name", UserName);
            Command.Parameters.AddWithValue("@Password", Password);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    isfind = true;
                    UserID = (int)Reader["UserID"];
                    PersonID = (int)Reader["PersonID"];
                    UserName = (string)Reader["UserName"];
                    Password = (string)Reader["Password"];
                    IsActive = (bool)Reader["IsActive"];
                   

                }
                else
                {
                    isfind = false;
                }
                Reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Connection.Close();
            }

            return isfind;
        }
       
        
        public static bool GetUserByPersonId(ref int UserID, ref int PersonID, 
             ref string UserName,  ref string Password,ref bool IsActive )
        {
            bool isfind = false;
            SqlConnection Connection = new SqlConnection(ClassTheConnectionData.StringConnection);
            string QueryForConnection = @"select * from Users where PersonID = @PersonID";
            SqlCommand Command = new SqlCommand(QueryForConnection, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    isfind = true;
                    UserID = (int)Reader["UserID"];
                    PersonID = (int)Reader["PersonID"];
                    UserName = (string)Reader["UserName"];
                    Password = (string)Reader["Password"];
                    IsActive = (bool)Reader["IsActive"];
                   

                }
                else
                {
                    isfind = false;
                }
                Reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Connection.Close();
            }

            return isfind;
        }
       
        
       


        public static int AddUser( int UserID,  int PersonID,
             string UserName,  string Password, bool IsActive)
        {
             UserID = -1;
            SqlConnection connection = new SqlConnection(ClassTheConnectionData.StringConnection);

            string query = @"INSERT INTO Users (UserName,Password,PersonID,IsActive)
                           VALUES (@UserName,@Password,@PersonID,@IsActive)SELECT SCOPE_IDENTITY();
                           ";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@IsActive", IsActive);
           


            try
            {
                connection.Open();
                object reader = command.ExecuteScalar();

                if (reader != null && int.TryParse(reader.ToString(), out int result))
                {
                    UserID = result;

                }
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return UserID;

        }


        public static int UpdateUserInfo( int UserID,  int PersonID,
             string UserName,  string Password, bool IsActive)
        {
            SqlConnection connection = new SqlConnection(ClassTheConnectionData.StringConnection);

            string query = @"update Users
                set  
                UserName=@UserName,
                Password=@Password,
                IsActive=@IsActive
              
                 where UserID=@UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@UserID", UserID);
           

            try
            {
                connection.Open();
                object reader = command.ExecuteNonQuery();

                if (reader != null && int.TryParse(reader.ToString(), out int result))
                {
                    UserID = result;

                }
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return UserID;

        }


        public static int DeleteUserInfo(int id)
        {

            SqlConnection connection = new SqlConnection(ClassTheConnectionData.StringConnection);

            string query = @"delete from Users 
                   where UserID = @id";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@id", id);

            try
            {
                connection.Open();
                int reader = command.ExecuteNonQuery();

                if (reader > 0)
                {
                    return reader;
                }
                else
                {
                    return 0;

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return 0;

        }



    }
}
