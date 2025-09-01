using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDataLayer_For_Project
{
    public class ClassDataFromTheTest
    {

        public static bool GetATestAppointmentByID(ref int TestAppointmentID,
          ref int TestID, ref  bool TestResult, ref string Notes, ref int UserID)
        {
            bool isfind = false;
            SqlConnection Connection = new SqlConnection(ClassTheConnectionData.StringConnection);
            string QueryForConnection = @"select * from Tests where TestAppointmentID = @TestAppointmentID";
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
                    TestID = (int)Reader["TestID"];
                    TestResult = (bool)Reader["TestResult"];
                    Notes = (string)Reader["Notes"];
                    UserID = (int)Reader["CreatedByUserID"];


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



        public static int AddATest( int TestAppointmentID,bool TestResult, 
            string Notes,  int UserID)
        {
            int TestID = -1;
            SqlConnection connection = new SqlConnection(ClassTheConnectionData.StringConnection);

            string query = @"INSERT INTO Tests
         (TestAppointmentID,TestResult,Notes,CreatedByUserID)
                                           VALUES (@TestAppointmentID,@TestResult,@Notes,@CreatedByUserID)
                               SELECT SCOPE_IDENTITY();
                           ";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@TestResult", TestResult);
            command.Parameters.AddWithValue("@Notes", Notes);
            command.Parameters.AddWithValue("@CreatedByUserID", UserID);
         

            try
            {
                connection.Open();
                object reader = command.ExecuteScalar();

                if (reader != null && int.TryParse(reader.ToString(), out int result))
                {
                    TestID = result;

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

            return TestID;

        }


       
        
        public static int UpdateATest(ref int TestAppointmentID,
          ref int TestID, ref bool TestResult, ref string Notes, ref int UserID)
        {
            SqlConnection connection = new SqlConnection(ClassTheConnectionData.StringConnection);
            string query = @"update TestAs
                set  
                TestID=@TestID,
                TestResult=@TestResult,
                Notes=@Notes,
                CreatedByUserID=@CreatedByUserID,

                 where TestAppointmentID=@TestAppointmentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@TestID", TestID);
            command.Parameters.AddWithValue("@TestResult", TestResult);
            command.Parameters.AddWithValue("@Notes", Notes);
            command.Parameters.AddWithValue("@CreatedByUserID", UserID);
            try
            {
                connection.Open();
                object reader = command.ExecuteNonQuery();

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




    }
}
