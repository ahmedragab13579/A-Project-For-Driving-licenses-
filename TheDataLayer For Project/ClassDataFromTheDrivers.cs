using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDataLayer_For_Project
{
    public class ClassDataFromTheDrivers
    {


        public static bool GetDriverByPersonID(ref int PersonID,ref int ID, ref int CreatedByUserID, ref DateTime CreatedDate)
        {
            bool isfind = false;
            SqlConnection Connection = new SqlConnection(ClassTheConnectionData.StringConnection);
            string QueryForConnection = @"select * from Drivers where PersonID = @PersonID";
            SqlCommand Command = new SqlCommand(QueryForConnection, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    isfind = true;
                    PersonID = (int)Reader["PersonID"];
                    ID = (int)Reader["DriverID"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];
                    CreatedDate = (DateTime)Reader["CreatedDate"];
                   
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

        public static bool GetDriverByID(ref int PersonID, ref int ID, ref int CreatedByUserID, ref DateTime CreatedDate)
        {
            bool isFind = false;
            using (SqlConnection connection = new SqlConnection(ClassTheConnectionData.StringConnection))
            {
                string query = @"SELECT * FROM Drivers WHERE DriverID = @ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", ID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFind = true;

                                PersonID = reader["PersonID"] != DBNull.Value ? Convert.ToInt32(reader["PersonID"]) : 0;
                                ID = reader["DriverID"] != DBNull.Value ? Convert.ToInt32(reader["DriverID"]) : 0;
                                CreatedByUserID = reader["CreatedByUserID"] != DBNull.Value ? Convert.ToInt32(reader["CreatedByUserID"]) : 0;
                                CreatedDate = reader["CreatedDate"] != DBNull.Value ? Convert.ToDateTime(reader["CreatedDate"]) : DateTime.MinValue;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }

            return isFind;
        }


        public static DataTable GetAllDriver()
        {
           DataTable dataTable = new DataTable();
            SqlConnection Connection = new SqlConnection(ClassTheConnectionData.StringConnection);
            string QueryForConnection = @"select * from Drivers_View ";
            SqlCommand Command = new SqlCommand(QueryForConnection, Connection);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
               
                   dataTable.Load(Reader);
                
              
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

            return dataTable;
        }


        public static int AddDriver(int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            int id = -1;
            SqlConnection connection = new SqlConnection(ClassTheConnectionData.StringConnection);

            string query = @"INSERT INTO Drivers (PersonID, CreatedByUserID, CreatedDate)
                           VALUES (@PersonID, @CreatedByUserID, @CreatedDate)SELECT SCOPE_IDENTITY();
                           ";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@CreatedDate", CreatedDate);
            try
            {
                connection.Open();
                object reader = command.ExecuteScalar();

                if (reader != null && int.TryParse(reader.ToString(), out int result))
                {
                    id = result;

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

            return id;

        }

    }
}
