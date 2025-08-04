using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDataLayer_For_Project
{
    public class ClassDataFromApplication
    {

        public static DataTable TheApplicationsData()
        {
            DataTable table = new DataTable();
            SqlConnection FirstConnection = new SqlConnection(ClassTheConnectionData.StringConnection);
            string QueryForConnection = "select * from Applications ";
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


        public static bool GetApplicationById(
            ref int ApplicationID,
            ref int ApplicationPersonID,
            ref DateTime ApplicationDate,
            ref int ApplicationTypeID,
            ref byte ApplicationStatusID,
            ref DateTime ApplicationLastStatusDate,
            ref decimal ApplicationPaidFees,
            ref int ApplicationCreatedByUserID)
        {
            bool isfind = false;
            SqlConnection Connection = new SqlConnection(ClassTheConnectionData.StringConnection);
            string QueryForConnection = @"select * from Applications where ApplicationID = @ApplicationID";
            SqlCommand Command = new SqlCommand(QueryForConnection, Connection);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    isfind = true;
                    ApplicationID = (int)Reader["ApplicationID"];
                    ApplicationPersonID = (int)Reader["ApplicantPersonID"];
                    ApplicationDate = (DateTime)Reader["ApplicationDate"];
                    ApplicationTypeID = (int)Reader["ApplicationTypeID"];
                    ApplicationStatusID = (byte)Reader["ApplicationStatus"];
                    ApplicationLastStatusDate = (DateTime)Reader["LastStatusDate"];
                    ApplicationPaidFees = (decimal)Reader["PaidFees"];
                    ApplicationCreatedByUserID = (int)Reader["CreatedByUserID"];

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

        public static int AddApplication(
                  int ApplicationPersonID,
             DateTime ApplicationDate,
                  int ApplicationTypeID,
                  int ApplicationStatusID,
             DateTime ApplicationLastStatusDate,
              decimal ApplicationPaidFees,
                  int ApplicationCreatedByUserID)
        {
            int ApplicationID = -1;
            SqlConnection connection = new SqlConnection(ClassTheConnectionData.StringConnection);

            string query = @"INSERT INTO Applications (
                           ApplicantPersonID,
                          ApplicationDate,
                          ApplicationTypeID,
                          ApplicationStatus,
                          LastStatusDate,
                          PaidFees,
                          CreatedByUserID)
                           VALUES (
                           @ApplicationPersonID,
                            @ApplicationDate,
                            @ApplicationTypeID,
                            @ApplicationStatusID,
                            @ApplicationLastStatusDate,
                            @ApplicationPaidFees,
                            @ApplicationCreatedByUserID)SELECT SCOPE_IDENTITY();
                           ";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationPersonID", ApplicationPersonID);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationStatusID", ApplicationStatusID);
            command.Parameters.AddWithValue("@ApplicationLastStatusDate", ApplicationLastStatusDate);
            command.Parameters.AddWithValue("@ApplicationPaidFees", ApplicationPaidFees);
            command.Parameters.AddWithValue("@ApplicationCreatedByUserID", ApplicationCreatedByUserID);



            try
            {
                connection.Open();
                object reader = command.ExecuteScalar();

                if (reader != null && int.TryParse(reader.ToString(), out int result))
                {
                    ApplicationID = result;

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

            return ApplicationID;

        }


        public static int UpdateApplication(
                   int ApplicationID,
                   int ApplicationPersonID,
              DateTime ApplicationDate,
                   int ApplicationTypeID,
                   int ApplicationStatusID,
              DateTime ApplicationLastStatusDate,
               decimal ApplicationPaidFees,
                   int ApplicationCreatedByUserID)
        {
            SqlConnection connection = new SqlConnection(ClassTheConnectionData.StringConnection);

            string query = @"Update  Applications 
                            set
                           ApplicantPersonID=@ApplicationPersonID,
                          ApplicationDate=@ApplicationDate,
                          ApplicationTypeID=@ApplicationTypeID,
                          ApplicationStatus=@ApplicationStatusID,
                          LastStatusDate=@ApplicationLastStatusDate,
                          PaidFees=@ApplicationPaidFees,
                          CreatedByUserID=@ApplicationCreatedByUserID
                          Where ApplicationID=@ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@ApplicationPersonID", ApplicationPersonID);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationStatusID", ApplicationStatusID);
            command.Parameters.AddWithValue("@ApplicationLastStatusDate", ApplicationLastStatusDate);
            command.Parameters.AddWithValue("@ApplicationPaidFees", ApplicationPaidFees);
            command.Parameters.AddWithValue("@ApplicationCreatedByUserID", ApplicationCreatedByUserID);



            try
            {
                connection.Open();
                object reader = command.ExecuteScalar();

                if (reader != null && int.TryParse(reader.ToString(), out int result))
                {
                    ApplicationID = result;

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

            return ApplicationID;

        }



        public static int DeleteApplicartionInfo(int id)
        {

            SqlConnection connection = new SqlConnection(ClassTheConnectionData.StringConnection);

            string query = @"delete from Applications 
                   where ApplicationID = @id";

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



        public static int CancelAnApplication(int ApplicationID)
        {
            SqlConnection connection = new SqlConnection(ClassTheConnectionData.StringConnection);

            string query = @"Update  Applications 
                            set
                          ApplicationStatus=@ApplicationStatusID,
                          LastStatusDate=@ApplicationLastStatusDate
                          Where ApplicationID=@ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@ApplicationStatusID", 2);
            command.Parameters.AddWithValue("@ApplicationLastStatusDate", DateTime.Now);


            int RowAffected = 0;

            try
            {
                connection.Open();
                int reader = command.ExecuteNonQuery();

                if (reader != null && int.TryParse(reader.ToString(), out int result))
                {
                    RowAffected= result;

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

            return RowAffected;

        }





    }
}
