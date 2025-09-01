using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace TheDataLayer_For_Project
{
    public class ClassdataFromLocalLicenseApplication
    {

        public static DataTable TheLocalLicenseApplicationData()
        {
            DataTable table = new DataTable();
            SqlConnection FirstConnection = new SqlConnection(ClassTheConnectionData.StringConnection);
            string QueryForConnection = "select * from LocalDrivingLicenseApplications_View ";
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
       
        
        public static DataRow RowFromLicenseApplicationData(int LocalLicenseID)
        {
            SqlConnection FirstConnection = new SqlConnection(ClassTheConnectionData.StringConnection);
            string QueryForConnection = "select top 1 * from LocalDrivingLicenseApplications_View where LocalDrivingLicenseApplicationID =@id ";
            SqlCommand FirstCommand = new SqlCommand(QueryForConnection, FirstConnection);
            FirstCommand.Parameters.AddWithValue("@id", LocalLicenseID);
            DataTable dt= new DataTable();
            try
            {
                FirstConnection.Open();

                SqlDataReader FirstReader = FirstCommand.ExecuteReader();

                if (FirstReader.HasRows)
                {
                    dt.Load(FirstReader);
                    return dt.Rows[0];

                }
                FirstReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            { FirstConnection.Close(); }


            return null ;
        }
       
       
        
        
        
        public static bool ISTheLicenseExist(string NationalNumber,string ClassName)
        {
            bool IsFound=false;
            DataTable table = new DataTable();
            SqlConnection FirstConnection = new SqlConnection(ClassTheConnectionData.StringConnection);
            string QueryForConnection = "select found=1 from LocalDrivingLicenseApplications_View where " +
                " NationalNo=@NationalNo and ClassName=@ClassName and Status in ('New','Combleted')";
            SqlCommand FirstCommand = new SqlCommand(QueryForConnection, FirstConnection);
            FirstCommand.Parameters.AddWithValue("@NationalNo", NationalNumber);
            FirstCommand.Parameters.AddWithValue("@ClassName", ClassName);

            try
            {
                FirstConnection.Open();
                SqlDataReader Reader = FirstCommand.ExecuteReader();
                if (Reader.Read())
                {
                    IsFound = true;
                  
                }
                else
                {
                    IsFound = false;
                }
                Reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                FirstConnection.Close();
            }

            return IsFound;
        }


        public static bool GetLocalLicenseApplicationById(ref int LocalDrivingLicenseApplicationID, 
            ref int ApplicationID,ref int LicenseClassID)
        {
            bool isfind = false;
            SqlConnection Connection = new SqlConnection(ClassTheConnectionData.StringConnection);
            string QueryForConnection = @"select * from LocalDrivingLicenseApplications where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";
            SqlCommand Command = new SqlCommand(QueryForConnection, Connection);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    isfind = true;
                    LocalDrivingLicenseApplicationID = (int)Reader["LocalDrivingLicenseApplicationID"];
                    ApplicationID = (int)Reader["ApplicationID"];
                    LicenseClassID = (int)Reader["LicenseClassID"];
                   
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

       
        public static bool GetLocalLicenseApplicationByApplicationId(  ref int ApplicationID, ref int LocalDrivingLicenseApplicationID, ref int LicenseClassID)
        {
            bool isfind = false;
            SqlConnection Connection = new SqlConnection(ClassTheConnectionData.StringConnection);
            string QueryForConnection = @"select * from LocalDrivingLicenseApplications where ApplicationID = @ApplicationID";
            SqlCommand Command = new SqlCommand(QueryForConnection, Connection);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    isfind = true;
                    LocalDrivingLicenseApplicationID = (int)Reader["LocalDrivingLicenseApplicationID"];
                    ApplicationID = (int)Reader["ApplicationID"];
                    LicenseClassID = (int)Reader["LicenseClassID"];
                   
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

       
        
        public static int AddLocalLicenseApplication( 
             int ApplicationID,  int LicenseClassID)
        {
            int LocalDrivingLicenseApplicationID = -1;
            SqlConnection connection = new SqlConnection(ClassTheConnectionData.StringConnection);

            string query = @"INSERT INTO LocalDrivingLicenseApplications (ApplicationID,LicenseClassID)
                           VALUES (@ApplicationID,@LicenseClassID)SELECT SCOPE_IDENTITY();
                           ";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);



            try
            {
                connection.Open();
                object reader = command.ExecuteScalar();

                if (reader != null && int.TryParse(reader.ToString(), out int result))
                {
                    LocalDrivingLicenseApplicationID = result;

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

            return LocalDrivingLicenseApplicationID;

        }


        public static int UpdateLocalLicenseApplicationInfo(
            int LocalDrivingLicenseApplicationID, 
             int ApplicationID,  int LicenseClassID)
        {
            SqlConnection connection = new SqlConnection(ClassTheConnectionData.StringConnection);

            string query = @"update Users
                set  
                ApplicationID=@ApplicationID,
                LicenseClassID=@LicenseClassID
              
                 where LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);


            try
            {
                connection.Open();
                object reader = command.ExecuteNonQuery();

                if (reader != null && int.TryParse(reader.ToString(), out int result))
                {
                    LocalDrivingLicenseApplicationID = result;

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

            return LocalDrivingLicenseApplicationID;

        }


        public static int DeleteApplicationInfo(int id)
        {

            SqlConnection connection = new SqlConnection(ClassTheConnectionData.StringConnection);

            string query = @"delete from LocalDrivingLicenseApplications 
                   where LocalDrivingLicenseApplicationID = @id";

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
