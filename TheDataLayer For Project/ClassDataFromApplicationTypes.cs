using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TheDataLayer_For_Project
{
    public class ClassDataFromApplicationTypes
    {
        public static DataTable TheApplicationData()
        {
            DataTable table = new DataTable();
            SqlConnection FirstConnection = new SqlConnection(ClassTheConnectionData.StringConnection);
            string QueryForConnection = "select * from ApplicationTypes ";
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


        public static bool FindApplicationByID(ref int ID, ref string Title, ref decimal Fees)
        {
            bool isfind = false;
            SqlConnection Connection = new SqlConnection(ClassTheConnectionData.StringConnection);
            string QueryForConnection = @"select * from ApplicationTypes where ApplicationTypeID = @ApplicationTypeID";
            SqlCommand Command = new SqlCommand(QueryForConnection, Connection);
            Command.Parameters.AddWithValue("@ApplicationTypeID", ID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    isfind = true;
                    ID = (int)Reader["ApplicationTypeID"];
                    Title = (string)Reader["ApplicationTypeTitle"];
                    Fees = (decimal)Reader["ApplicationFees"];
                   

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

        public static int UpdateApplicationInfo(int ID, string Title, decimal Fees)
        {
            SqlConnection connection = new SqlConnection(ClassTheConnectionData.StringConnection);

            string query = @"update ApplicationTypes
                set  
                ApplicationTypeTitle=@ApplicationTypeTitle,
                ApplicationFees=@ApplicationFees
               
                 where ApplicationTypeID=@ApplicationTypeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationTypeTitle", Title);
            command.Parameters.AddWithValue("@ApplicationFees", Fees);
            command.Parameters.AddWithValue("@ApplicationTypeID", ID);

            try
            {
                connection.Open();
                object reader = command.ExecuteNonQuery();

                if (reader != null && int.TryParse(reader.ToString(), out int result))
                {
                    ID = result;

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

            return ID;

        }


    }
}
