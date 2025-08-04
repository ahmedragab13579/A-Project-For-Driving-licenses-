using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace TheDataLayer_For_Project
{
    public class ClassDataFromTheLicense
    {
       public static bool GetLicenseByApplicationid(
       int ApplicationID,
       ref int LicenseID,
       ref int LicenseClass,
       ref int DriverID,
       ref DateTime IssueDate,
       ref DateTime ExpirationDate,
       ref string Notes,
       ref decimal PaidFees,
       ref bool IsActive,
       ref int IssueReason,
       ref int CreatedByUserID)
        {
            bool isfind = false;
            SqlConnection Connection = new SqlConnection(ClassTheConnectionData.StringConnection);
            string QueryForConnection = @"select * from Licenses where ApplicationID = @ApplicationID";
            SqlCommand Command = new SqlCommand(QueryForConnection, Connection);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    isfind = true;
                    LicenseID = (int)Reader["LicenseID"];
                    LicenseClass = (int)Reader["LicenseClass"];
                    DriverID = (int)Reader["DriverID"];
                    IssueDate = (DateTime)Reader["IssueDate"];
                    ExpirationDate = (DateTime)Reader["ExpirationDate"];
                    Notes = (string)Reader["Notes"];
                    PaidFees = (decimal)Reader["PaidFees"];
                    IsActive = (bool)Reader["IsActive"];
                    IssueReason = (int)Reader["IssueReason"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];

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
      
        public static bool GetLicenseByID(
       ref int LicenseID,
       ref int ApplicationID,
       ref int LicenseClass,
       ref int DriverID,
       ref DateTime IssueDate,
       ref DateTime ExpirationDate,
       ref string Notes,
       ref decimal PaidFees,
       ref bool IsActive,
       ref int IssueReason,
       ref int CreatedByUserID)
        {
            bool isfind = false;
            SqlConnection Connection = new SqlConnection(ClassTheConnectionData.StringConnection);
            string QueryForConnection = @"select * from Licenses where LicenseID = @LicenseID";
            SqlCommand Command = new SqlCommand(QueryForConnection, Connection);
            Command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    isfind = true;
                    LicenseID = (int)Reader["LicenseID"];
                    ApplicationID = (int)Reader["ApplicationID"];
                    LicenseClass = (int)Reader["LicenseClass"];
                    DriverID = (int)Reader["DriverID"];
                    IssueDate = (DateTime)Reader["IssueDate"];
                    ExpirationDate = (DateTime)Reader["ExpirationDate"];
                    Notes = (Reader["Notes"] == DBNull.Value ? "No Notes" : (string)Reader["Notes"]);
                    PaidFees = (decimal)Reader["PaidFees"];
                    IsActive = (bool)Reader["IsActive"];
                    IssueReason = (byte)Reader["IssueReason"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];


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
       public static DataTable GetLicenseForDriverByDriverID( ref int DriverID)
        {
            DataTable table = new DataTable();
            bool isfind = false;
            SqlConnection Connection = new SqlConnection(ClassTheConnectionData.StringConnection);
            string QueryForConnection = @"select * from Licenses where DriverID = @DriverID";
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

        public static int AddLicense(
        int ApplicantID,
        int LicenseClass,
        int DriverID,
        DateTime IssueDate,
        DateTime ExpirationDate,
        string Notes,
        decimal PaidFees,
        bool IsActive,
        int IssueReason,
        int CreatedByUserID)
        {
            int LicenseID = -1;

            string query = @"
        INSERT INTO Licenses (
            ApplicationID,
            LicenseClass,
            DriverID,
            IssueDate,
            ExpirationDate,
            Notes,
            PaidFees,
            IsActive,
            IssueReason,
            CreatedByUserID)
        VALUES (
            @ApplicantID,
            @LicenseClass,
            @DriverID,
            @IssueDate,
            @ExpirationDate,
            @Notes,
            @PaidFees,
            @IsActive,
            @IssueReason,
            @CreatedByUserID);
        SELECT SCOPE_IDENTITY();";

            try
            {
                using (SqlConnection connection = new SqlConnection(ClassTheConnectionData.StringConnection))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicantID", ApplicantID);
                    command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
                    command.Parameters.AddWithValue("@DriverID", DriverID);
                    command.Parameters.AddWithValue("@IssueDate", IssueDate);
                    command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
                    command.Parameters.AddWithValue("@Notes", Notes ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@PaidFees", PaidFees);
                    command.Parameters.AddWithValue("@IsActive", IsActive);
                    command.Parameters.AddWithValue("@IssueReason", IssueReason);
                    command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                    connection.Open();
                    object resultObj = command.ExecuteScalar();

                    if (resultObj != null && int.TryParse(resultObj.ToString(), out int result))
                    {
                        LicenseID = result;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return LicenseID;
        }



        public static void DeactivatetheOldLicense(int ID)
        {
            using (SqlConnection connection = new SqlConnection(ClassTheConnectionData.StringConnection))
            {
                string query = @"UPDATE Licenses SET IsActive = 0 WHERE LicenseID = @Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", ID);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery(); 
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error deactivating license: " + ex.Message);
                    }
                }
            }
        }

        public static bool IsActive(int id)
        {
            using (SqlConnection connection = new SqlConnection(ClassTheConnectionData.StringConnection))
            {
                string query = @"SELECT 1 FROM Licenses WHERE LicenseID = @id AND IsActive = 1";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id); 

                    try
                    {
                        connection.Open();
                        var result = command.ExecuteScalar(); 

                        return result != null; 
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error checking license status: " + ex.Message);
                        return false;
                    }
                }
            }
        }



    }

}

