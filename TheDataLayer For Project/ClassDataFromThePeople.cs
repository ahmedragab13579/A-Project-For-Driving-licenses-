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
    public class ClassDataFromThePeople
    {
        public static DataTable GetAllInformationFromThePeople()
        {
            DataTable table = new DataTable();
            SqlConnection FirstConnection = new SqlConnection(ClassTheConnectionData.StringConnection);
            string QueryForConnection = "select * from People ";
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


        public static bool GetPersonById(ref int ID, ref string firstName, ref string SecondName, ref string ThirdName,
            ref string lastName, ref string email, ref string phone, ref string address, ref DateTime DataOfBirth
            , ref string ImagePath, ref int countryID,ref int Gendor,ref string NationalID)
        {
            bool isfind = false;
            SqlConnection Connection = new SqlConnection(ClassTheConnectionData.StringConnection);
            string QueryForConnection = @"select * from People where PersonID = @PersonID";
            SqlCommand Command = new SqlCommand(QueryForConnection, Connection);
            Command.Parameters.AddWithValue("@PersonID", ID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    isfind = true;
                    ID = (int)Reader["PersonID"];
                    NationalID = (string)Reader["NationalNo"];
                    firstName = (string)Reader["FirstName"];
                    SecondName = (string)Reader["SecondName"];
                    ThirdName = (string)Reader["ThirdName"];
                    lastName = (string)Reader["LastName"];
                    email = (string)Reader["Email"];
                    phone = (string)Reader["Phone"];
                    address = (string)Reader["Address"];
                    DataOfBirth = (DateTime)Reader["DateOfBirth"];
                    ImagePath = Reader["ImagePath"] != DBNull.Value ? (string)Reader["ImagePath"] : "";
                    countryID = (int)Reader["NationalityCountryID"];
                    Gendor = (int)Reader["Gendor"];

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

        public static bool GetPersonByNationalId(ref int ID, ref string firstName, ref string SecondName, ref string ThirdName,
            ref string lastName, ref string email, ref string phone, ref string address, ref DateTime DataOfBirth
            , ref string ImagePath, ref int countryID,ref int Gendor,ref string NationalID)
        {
            bool isfind = false;
            SqlConnection Connection = new SqlConnection(ClassTheConnectionData.StringConnection);
            string QueryForConnection = @"select * from People where NationalNo = @NationalID";
            SqlCommand Command = new SqlCommand(QueryForConnection, Connection);
            Command.Parameters.AddWithValue("@NationalID", NationalID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    isfind = true;
                    ID = (int)Reader["PersonID"];
                    NationalID = (string)Reader["NationalNo"];
                    firstName = (string)Reader["FirstName"];
                    SecondName = (string)Reader["SecondName"];
                    ThirdName = (string)Reader["ThirdName"];
                    lastName = (string)Reader["LastName"];
                    email = (string)Reader["Email"];
                    phone = (string)Reader["Phone"];
                    address = (string)Reader["Address"];
                    DataOfBirth = (DateTime)Reader["DateOfBirth"];
                    ImagePath = Reader["ImagePath"] != DBNull.Value ? (string)Reader["ImagePath"] : "";
                    countryID = (int)Reader["NationalityCountryID"];
                    Gendor = (int)Reader["Gendor"];

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



        public static bool IsNationalIDExist(string NatioanalID)
        {
            bool isfind = false;
            SqlConnection Connection = new SqlConnection(ClassTheConnectionData.StringConnection);
            string QueryForConnection = @"select Found=1 from People where NationalNo = @NationalID";
            SqlCommand Command = new SqlCommand(QueryForConnection, Connection);
            Command.Parameters.AddWithValue("@NationalID", NatioanalID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    isfind = true;
                   
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


        public static int AddPerson(  string firstName,  string SecondName,  string ThirdName,
             string lastName,  string email,  string phone,  string address,  DateTime DataOfBirth
            ,  string ImagePath,  int countryID,  int Gendor,  string NationalID)
        {
            int id=-1;
            SqlConnection connection = new SqlConnection(ClassTheConnectionData.StringConnection);

            string query = @"INSERT INTO People (FirstName, SecondName, ThirdName,
                           LastName, Email, Phone, Address, DateOfBirth, ImagePath,
                           NationalityCountryID, Gendor, NationalNo)
                           VALUES (@FirstName, @SecondName, @ThirdName,
                           @LastName, @Email, @Phone, @Address, @DataOfBirth, @ImagePath,
                           @CountryID, @Gendor, @NationalID)SELECT SCOPE_IDENTITY();
                           ";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FirstName", firstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", lastName);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Phone", phone);
            command.Parameters.AddWithValue("@Address", address);
            command.Parameters.AddWithValue("@DataOfBirth", DataOfBirth);
            command.Parameters.AddWithValue("@ImagePath", ImagePath);
            command.Parameters.AddWithValue("@CountryID", countryID);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@NationalID", NationalID);
            

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


        public static int UpdatePersonInfo( int ID,  string firstName,  string SecondName,  string ThirdName,
             string lastName,  string email,  string phone,  string address,  DateTime DataOfBirth
            ,  string ImagePath,  int countryID,  int Gendor,  string NationalID)
        {
            SqlConnection connection = new SqlConnection(ClassTheConnectionData.StringConnection);

            string query = @"update People
                set  
                FirstName=@FirstName,
                SecondName=@SecondName,
                ThirdName=@ThirdName,
                LastName=@LastName,
                Email=@Email,
                Phone=@Phone,
                Address=@Address,
                DateOfBirth=@DataOfBirth,
                ImagePath=@ImagePath,
                NationalityCountryID=@NationalityCountryID,
                Gendor= @Gendor,
                NationalNo= @NationalNo 
                 where PersonID=@id";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FirstName", firstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", lastName);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Phone", phone);
            command.Parameters.AddWithValue("@Address", address);
            command.Parameters.AddWithValue("@DataOfBirth", DataOfBirth);
            command.Parameters.AddWithValue("@ImagePath", ImagePath);
            command.Parameters.AddWithValue("@NationalityCountryID", countryID);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@NationalNo", NationalID);
            command.Parameters.AddWithValue("@id", ID);

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


        public static int DeletePersonInfo(int id)
        {

            SqlConnection connection = new SqlConnection(ClassTheConnectionData.StringConnection);

            string query = @"delete from People 
                   where PersonID = @id";

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
