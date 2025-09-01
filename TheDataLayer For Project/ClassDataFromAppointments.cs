using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDataLayer_For_Project
{
    public class ClassDataFromAppointments
    {
        public static DataTable TheAppointmentData(int LocalID)
        {
            DataTable table = new DataTable();
            SqlConnection FirstConnection = new SqlConnection(ClassTheConnectionData.StringConnection);
            string QueryForConnection = "select * from TestAppointments Where LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID";
            SqlCommand FirstCommand = new SqlCommand(QueryForConnection, FirstConnection);
            FirstCommand.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalID);

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
      
        public static DataRow TheAppointmentRowData(int Appointmentid)
        {
            DataTable table = new DataTable();
            SqlConnection FirstConnection = new SqlConnection(ClassTheConnectionData.StringConnection);
            string QueryForConnection = "select * from TestAppointments_View " +
                "where  TestAppointmentID=@id";
            SqlCommand FirstCommand = new SqlCommand(QueryForConnection, FirstConnection);
            FirstCommand.Parameters.AddWithValue("@id", Appointmentid);

            try
            {
                FirstConnection.Open();
                SqlDataReader FirstReader = FirstCommand.ExecuteReader();
                if (FirstReader.HasRows) 
                { 
                    table.Load(FirstReader); 
                    return table.Rows[0];
                }
                FirstReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            { FirstConnection.Close(); }


            return null;
        }
        
        public static DataRow TheAppointmentRowData(int LocalLocenseID, int TestTypeID)
        {
            DataTable table = new DataTable();
            SqlConnection FirstConnection = new SqlConnection(ClassTheConnectionData.StringConnection);
            string QueryForConnection = "select * from TestAppointments " +
                "where  LocalDrivingLicenseApplicationID=@id and TestTypeID=@TestTypeID";
            SqlCommand FirstCommand = new SqlCommand(QueryForConnection, FirstConnection);
            FirstCommand.Parameters.AddWithValue("@id", LocalLocenseID);
            FirstCommand.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                FirstConnection.Open();
                SqlDataReader FirstReader = FirstCommand.ExecuteReader();
                if (FirstReader.HasRows) 
                { 
                    table.Load(FirstReader); 
                    return table.Rows[0];
                }
                FirstReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            { FirstConnection.Close(); }


            return null;
        }
        
        public static bool IsAppointmentExist(int LocalLocenseID,int TestTypeID)
        {
            bool IsFound=false;
            SqlConnection FirstConnection = new SqlConnection(ClassTheConnectionData.StringConnection);
            string QueryForConnection = "select 1  from TestAppointments where " +
                "LocalDrivingLicenseApplicationID=@LocalLicenseApplicationID and TestTypeID=@TestTypeID";
            SqlCommand FirstCommand = new SqlCommand(QueryForConnection, FirstConnection);
            FirstCommand.Parameters.AddWithValue("@LocalLicenseApplicationID", LocalLocenseID);
            FirstCommand.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            try
            {
                FirstConnection.Open();
                SqlDataReader FirstReader = FirstCommand.ExecuteReader();
                if (FirstReader.HasRows) { IsFound=true; }
                FirstReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            { FirstConnection.Close(); }


            return IsFound;
        }
        
        public static bool IsAppointmentActive(int LocalLocenseID,int TestTypeID)
        {
            bool IsFound=false;
            SqlConnection FirstConnection = new SqlConnection(ClassTheConnectionData.StringConnection);
            string QueryForConnection = "select 1  from TestAppointments where " +
                "LocalDrivingLicenseApplicationID=@LocalLicenseApplicationID and TestTypeID=@TestTypeID and IsLocked=0";
            SqlCommand FirstCommand = new SqlCommand(QueryForConnection, FirstConnection);
            FirstCommand.Parameters.AddWithValue("@LocalLicenseApplicationID", LocalLocenseID);
            FirstCommand.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            try
            {
                FirstConnection.Open();
                SqlDataReader FirstReader = FirstCommand.ExecuteReader();
                if (FirstReader.HasRows) { IsFound=true; }
                FirstReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            { FirstConnection.Close(); }


            return IsFound;
        }

        public static bool GetAnAppointmentByID(ref int TestAppointmentID,
            ref int TestTypeID,ref int LocalLicenseID,ref DateTime AppointmentDate 
            ,ref decimal Fees,ref int UserID,ref bool IsLocked)
        {
            bool isfind = false;
            SqlConnection Connection = new SqlConnection(ClassTheConnectionData.StringConnection);
            string QueryForConnection = @"select * from TestAppointments where TestAppointmentID = @TestAppointmentID";
            SqlCommand Command = new SqlCommand(QueryForConnection, Connection);
            Command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    isfind = true;
                    TestAppointmentID = (int)Reader["TestAppointmentID"];
                    TestTypeID = (int)Reader["TestTypeID"];
                    LocalLicenseID = (int)Reader["LocalDrivingLicenseApplicationID"];
                    AppointmentDate = (DateTime)Reader["AppointmentDate"];
                    Fees = (decimal)Reader["PaidFees"];
                    UserID = (int)Reader["CreatedByUserID"];
                    IsLocked = (bool)Reader["IsLocked"];
                   

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

      
        
        public static int AddAnAppointment(  int TestTypeID,  int LocalLicenseID,
             DateTime AppointmentDate,  decimal Fees,  int UserID,  bool IsLocked)
        {
            int TestAppointmentID = -1;
            SqlConnection connection = new SqlConnection(ClassTheConnectionData.StringConnection);

            string query = @"INSERT INTO TestAppointments
         (TestTypeID,LocalDrivingLicenseApplicationID,AppointmentDate,PaidFees,CreatedByUserID,IsLocked)
                VALUES (@TestTypeID,@LocalLicenseID,@AppointmentDate,@Fees,@UserID,@IsLocked)
                               SELECT SCOPE_IDENTITY();
                           ";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LocalLicenseID", LocalLicenseID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@Fees", Fees);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@IsLocked", IsLocked);



            try
            {
                connection.Open();
                object reader = command.ExecuteScalar();

                if (reader != null && int.TryParse(reader.ToString(), out int result))
                {
                    TestAppointmentID = result;

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

            return TestAppointmentID;

        }


        public static int UpdateAnAppointment( int TestAppointmentID,  int TestTypeID,  int LocalLicenseID,  DateTime AppointmentDate,  decimal Fees,  int UserID,  bool IsLocked)
        {
            SqlConnection connection = new SqlConnection(ClassTheConnectionData.StringConnection);
            string query = @"update TestAppointments
                set  
                TestTypeID=@TestTypeID,
                LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID,
                AppointmentDate=@AppointmentDate,
                PaidFees=@PaidFees,
                CreatedByUserID=@CreatedByUserID,
                IsLocked=@IsLocke
                 where TestAppointmentID=@TestAppointmentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalLicenseID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@PaidFees", Fees);
            command.Parameters.AddWithValue("@CreatedByUserID", UserID);
            command.Parameters.AddWithValue("@IsLocke", IsLocked);
           

            try
            {
                connection.Open();
                int reader = command.ExecuteNonQuery();

                if (reader > 0 )
                {
                    return reader;
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

            return TestAppointmentID;

        }





    }
}
