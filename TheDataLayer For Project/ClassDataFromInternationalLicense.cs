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
    public class ClassDataFromInternationalLicense
    {
        public static DataTable TheInternationalLicense()
        {
            DataTable table = new DataTable();
            SqlConnection FirstConnection = new SqlConnection(ClassTheConnectionData.StringConnection);
            string QueryForConnection = "select * from InternationalLicenses ";
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

        public static bool ISTheLicenseExist(int ApplicationID)
        {
            bool IsFound = false;
            DataTable table = new DataTable();
            SqlConnection FirstConnection = new SqlConnection(ClassTheConnectionData.StringConnection);
            string QueryForConnection = "select found=1 from InternationalLicenses where " +
               " ApplicationID=@ApplicationID";
            SqlCommand FirstCommand = new SqlCommand(QueryForConnection, FirstConnection);
            FirstCommand.Parameters.AddWithValue("@ApplicationID", ApplicationID);

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


        //public static bool GetLocalLicenseApplicationById(ref int LocalDrivingLicenseApplicationID,
        //    ref int ApplicationID, ref int LicenseClassID)
        //{
        //    bool isfind = false;
        //    SqlConnection Connection = new SqlConnection(ClassTheConnectionData.StringConnection);
        //    string QueryForConnection = @"select * from LocalDrivingLicenseApplications where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";
        //    SqlCommand Command = new SqlCommand(QueryForConnection, Connection);
        //    Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

        //    try
        //    {
        //        Connection.Open();
        //        SqlDataReader Reader = Command.ExecuteReader();
        //        if (Reader.Read())
        //        {
        //            isfind = true;
        //            LocalDrivingLicenseApplicationID = (int)Reader["LocalDrivingLicenseApplicationID"];
        //            ApplicationID = (int)Reader["ApplicationID"];
        //            LicenseClassID = (int)Reader["LicenseClassID"];

        //        }
        //        else
        //        {
        //            isfind = false;
        //        }
        //        Reader.Close();

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //    finally
        //    {
        //        Connection.Close();
        //    }

        //    return isfind;
        //}


        public static DataTable GetLicenseForDriverByDriverID(ref int DriverID)
        {
            DataTable table = new DataTable();
            bool isfind = false;
            SqlConnection Connection = new SqlConnection(ClassTheConnectionData.StringConnection);
            string QueryForConnection = @"select * from InternationalLicenses where DriverID = @DriverID";
            SqlCommand Command = new SqlCommand(QueryForConnection, Connection);
            Command.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    table.Load(Reader);
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

            return table;

        }

       
        public static int AddInternationalLicense(
            int ApplicationID,int DriverID,int IssueUsingLicalLicenseID,DateTime IssueData,DateTime ExpirationDate,bool IsActive, int CreatedByuserID)
        {
            int LocalDrivingLicenseApplicationID = -1;
            SqlConnection connection = new SqlConnection(ClassTheConnectionData.StringConnection);

            string query = @"INSERT INTO InternationalLicenses
               (ApplicationID,DriverID,IssuedUsingLocalLicenseID,IssueDate,ExpirationDate,IsActive,CreatedByuserID)
        VALUES (@ApplicationID,@DriverID,@IssueUsingLicalLicenseID,@IssueData,@ExpirationDate,@IsActive,@CreatedByuserID)
                        SELECT SCOPE_IDENTITY();
                           ";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@IssueUsingLicalLicenseID", IssueUsingLicalLicenseID);
            command.Parameters.AddWithValue("@IssueData", IssueData);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@CreatedByuserID", CreatedByuserID);



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
    }
}
