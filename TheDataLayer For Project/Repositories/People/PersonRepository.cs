using System.Data.SqlClient;
using TheDataLayer_For_Project.Models.Person;
using TheDataLayer_For_Project.Models.ConnectionData;

namespace TheDataLayer_For_Project.Repositories.Person
{
    public class PersonRepository
    {
        private readonly string _connectionString;

        public PersonRepository()
        {
            _connectionString =  ClassTheConnectionData.StringConnection;
        }

        private SqlConnection GetConnection() => new SqlConnection(_connectionString);

        public List<TheDataLayer_For_Project.Models.Person.Person> GetAll()
        {
            var list = new List<TheDataLayer_For_Project.Models.Person.Person>();
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand("SELECT * FROM People", conn))
            {
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(Map(reader));
                    }
                }
            }
            return list;
        }

        public TheDataLayer_For_Project.Models.Person.Person GetById(int id)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand("SELECT * FROM People WHERE PersonID = @PersonID", conn))
            {
                cmd.Parameters.AddWithValue("@PersonID", id);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                        return Map(reader);
                }
            }
            return null;
        }

        public TheDataLayer_For_Project.Models.Person.Person GetByNationalId(string nationalId)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand("SELECT * FROM People WHERE NationalNo = @NationalID", conn))
            {
                cmd.Parameters.AddWithValue("@NationalID", nationalId);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                        return Map(reader);
                }
            }
            return null;
        }

        public bool IsNationalIdExist(string nationalId)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand("SELECT 1 FROM People WHERE NationalNo = @NationalID", conn))
            {
                cmd.Parameters.AddWithValue("@NationalID", nationalId);
                conn.Open();
                var result = cmd.ExecuteScalar();
                return result != null;
            }
        }

        public int Add(TheDataLayer_For_Project.Models.Person.Person person)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(@"
                INSERT INTO People (FirstName, SecondName, ThirdName, LastName, Email, Phone, Address, DateOfBirth, ImagePath,
                                     NationalityCountryID, Gendor, NationalNo)
                VALUES (@FirstName, @SecondName, @ThirdName, @LastName, @Email, @Phone, @Address, @DateOfBirth, @ImagePath,
                        @CountryID, @Gendor, @NationalID);
                SELECT SCOPE_IDENTITY();", conn))
            {
                cmd.Parameters.AddWithValue("@FirstName", person.FirstName);
                cmd.Parameters.AddWithValue("@SecondName", person.SecondName);
                cmd.Parameters.AddWithValue("@ThirdName", person.ThirdName);
                cmd.Parameters.AddWithValue("@LastName", person.LastName);
                cmd.Parameters.AddWithValue("@Email", person.Email);
                cmd.Parameters.AddWithValue("@Phone", person.Phone);
                cmd.Parameters.AddWithValue("@Address", person.Address);
                cmd.Parameters.AddWithValue("@DateOfBirth", person.DateOfBirth);
                cmd.Parameters.AddWithValue("@ImagePath", (object)person.ImagePath ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@CountryID", person.NationalityCountryID);
                cmd.Parameters.AddWithValue("@Gendor", person.Gendor);
                cmd.Parameters.AddWithValue("@NationalID", person.NationalNo);

                conn.Open();
                var result = cmd.ExecuteScalar();
                return result != null && int.TryParse(result.ToString(), out int id) ? id : -1;
            }
        }

        public bool Update(TheDataLayer_For_Project.Models.Person.Person person)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(@"
                UPDATE People
                SET FirstName = @FirstName,
                    SecondName = @SecondName,
                    ThirdName = @ThirdName,
                    LastName = @LastName,
                    Email = @Email,
                    Phone = @Phone,
                    Address = @Address,
                    DateOfBirth = @DateOfBirth,
                    ImagePath = @ImagePath,
                    NationalityCountryID = @CountryID,
                    Gendor = @Gendor,
                    NationalNo = @NationalID
                WHERE PersonID = @ID", conn))
            {
                cmd.Parameters.AddWithValue("@ID", person.PersonID);
                cmd.Parameters.AddWithValue("@FirstName", person.FirstName);
                cmd.Parameters.AddWithValue("@SecondName", person.SecondName);
                cmd.Parameters.AddWithValue("@ThirdName", person.ThirdName);
                cmd.Parameters.AddWithValue("@LastName", person.LastName);
                cmd.Parameters.AddWithValue("@Email", person.Email);
                cmd.Parameters.AddWithValue("@Phone", person.Phone);
                cmd.Parameters.AddWithValue("@Address", person.Address);
                cmd.Parameters.AddWithValue("@DateOfBirth", person.DateOfBirth);
                cmd.Parameters.AddWithValue("@ImagePath", (object)person.ImagePath ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@CountryID", person.NationalityCountryID);
                cmd.Parameters.AddWithValue("@Gendor", person.Gendor);
                cmd.Parameters.AddWithValue("@NationalID", person.NationalNo);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Delete(int id)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand("DELETE FROM People WHERE PersonID = @ID", conn))
            {
                cmd.Parameters.AddWithValue("@ID", id);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        private TheDataLayer_For_Project.Models.Person.Person Map(SqlDataReader r)
        {
            return new TheDataLayer_For_Project.Models.Person.Person
            {
                PersonID = Convert.ToInt32(r["PersonID"]),
                NationalNo = Convert.ToString(r["NationalNo"]),
                FirstName = Convert.ToString(r["FirstName"]),
                SecondName = Convert.ToString(r["SecondName"]),
                ThirdName = Convert.ToString(r["ThirdName"]),
                LastName = Convert.ToString(r["LastName"]),
                Email = Convert.ToString(r["Email"]),
                Phone = Convert.ToString(r["Phone"]),
                Address = Convert.ToString(r["Address"]),
                DateOfBirth = Convert.ToDateTime(r["DateOfBirth"]),
                ImagePath = r["ImagePath"] != DBNull.Value ? Convert.ToString(r["ImagePath"]) : null,
                NationalityCountryID = Convert.ToInt32(r["NationalityCountryID"]),
                Gendor = Convert.ToInt32(r["Gendor"])
            };
        }
    }
}
