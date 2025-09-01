using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDataLayer_For_Project
{
    public class ClassDataFromDetainLiceses
    {
        public static bool GetDetainLicenseByLicenseID(
    ref int LicenseID,
    ref int DetainID,
    ref decimal FineFees,
    ref DateTime Date,
    ref int User,
    ref bool IsRelesd,
    ref DateTime RelaseDate,
    ref int RelaisByuser,
    ref int RelaisAppID)
        {
            bool isfind = false;
            SqlConnection Connection = new SqlConnection(ClassTheConnectionData.StringConnection);
            string QueryForConnection = @"select * from DetainedLicenses where LicenseID = @LicenseID";
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
                    DetainID = (int)Reader["DetainID"];
                    FineFees = (decimal)Reader["FineFees"];
                    Date = (DateTime)Reader["DetainDate"];
                    User = (int)Reader["CreatedByUserID"];
                    IsRelesd = (bool)Reader["IsReleased"];
                    RelaseDate = (DateTime)Reader["ReleaseDate"];
                    RelaisByuser = (int)Reader["ReleasedByUserID"];
                    RelaisAppID = (int)Reader["ReleaseApplicationID"];

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





        public static int AddDetainLicense(
             int LicenseID,
        decimal FineFees,
         DateTime Date,
         int User,
         bool IsRelesd
        )
        {
            string query = @"
        INSERT INTO DetainedLicenses (
            LicenseID,
            FineFees,
            DetainDate,
            CreatedByUserID,
            IsReleased
           )
        VALUES (
            @LicenseID,
            @FineFees,
            @Date,
            @User,
            @IsRelesd
           );
        SELECT SCOPE_IDENTITY();";

            int DetainID = 0;
            try
            {
               // System.Data.SqlClient.SqlException: 'The parameterized query
               // '(@LicenseID int, @FineFees decimal(4, 0), @Date datetime, @User int,
               // ' expects the parameter '@RelaseDate', which was not supplied.'

                using (SqlConnection connection = new SqlConnection(ClassTheConnectionData.StringConnection))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LicenseID", LicenseID);
                    command.Parameters.AddWithValue("@FineFees", FineFees);
                    command.Parameters.AddWithValue("@Date", Date);
                    command.Parameters.AddWithValue("@User", User);
                    command.Parameters.AddWithValue("@IsRelesd", IsRelesd);
                  

                    connection.Open();
                    object resultObj = command.ExecuteScalar();

                    if (resultObj != null && int.TryParse(resultObj.ToString(), out int result))
                    {
                        DetainID = result;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return DetainID;
        }

        public static bool UpdateDetainLicense(
        int detainLicenseID,
        bool isReleased,
        DateTime releaseDate,
        int releasedByUserID,
        int releaseApplicationID
    )
        {
            string query = @"
    UPDATE DetainedLicenses 
    SET 
        IsReleased = @IsReleased,
        ReleaseDate = @ReleaseDate,
        ReleasedByUserID = @ReleasedByUserID,
        ReleaseApplicationID = @ReleaseApplicationID
    WHERE DetainID = @DetainID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(ClassTheConnectionData.StringConnection))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DetainID", detainLicenseID);
                    command.Parameters.AddWithValue("@IsReleased", isReleased);
                    command.Parameters.AddWithValue("@ReleaseDate", releaseDate);
                    command.Parameters.AddWithValue("@ReleasedByUserID", releasedByUserID);
                    command.Parameters.AddWithValue("@ReleaseApplicationID", releaseApplicationID);

                    connection.Open();
                    int affectedRows = command.ExecuteNonQuery();

                    return affectedRows > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }


        public static bool IsDetain(int id)
        {
            using (SqlConnection connection = new SqlConnection(ClassTheConnectionData.StringConnection))
            {
                string query = @"SELECT 1 FROM Licenses WHERE LicenseID = @id AND IsReleased = 0";

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

        public static DataTable TheDetainedLicenses()
        {
            DataTable table = new DataTable();
            SqlConnection FirstConnection = new SqlConnection(ClassTheConnectionData.StringConnection);
            string QueryForConnection = "select * from DetainedLicenses ";
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


    }
}
