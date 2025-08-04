using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDataLayer_For_Project
{
    public class ClassDataFromTheCountry
    {
        public static DataTable GetAllInformationFromTheCountry()
        {
            DataTable table = new DataTable();
            SqlConnection FirstConnection = new SqlConnection(ClassTheConnectionData.StringConnection);
            string QueryForConnection = "select * from Countries ";
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
