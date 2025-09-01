using System.Data.SqlClient;
using TheDataLayer_For_Project.Models.ConnectionData;
using TheDataLayer_For_Project.Models.Tests;

namespace TheDataLayer_For_Project.Repositories.Tests
{
    public class TestTypeRepository
    {
        private string _ConnectionString;
        public TestTypeRepository()
        {
            _ConnectionString = ClassTheConnectionData.StringConnection;

        }
        private SqlConnection GetConnection() => new SqlConnection(_ConnectionString);

        public List<TestType> GetAll()
        {
            var list = new List<TestType>();
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand("SELECT * FROM TestTypes", conn))
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

        public TestType GetById(int id)
        {
            using (var connection = new SqlConnection(ClassTheConnectionData.StringConnection))
            using (var command = new SqlCommand("SELECT * FROM TestTypes WHERE TestTypeID = @TestTypeID", connection))
            {
                command.Parameters.AddWithValue("@TestTypeID", id);
                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return Map(reader);
                    }
                }
            }
            return null;
        }

        public bool Update(TestType test)
        {
            using (var connection = new SqlConnection(ClassTheConnectionData.StringConnection))
            using (var command = new SqlCommand(@"
        UPDATE TestTypes
        SET TestTypeTitle = @TestTypeTitle,
            TestTypeFees = @TestTypeFees,
            TestTypeDescription = @TestTypeDescription
        WHERE TestTypeID = @TestTypeID", connection))
            {
                command.Parameters.AddWithValue("@TestTypeID", test.Id);
                command.Parameters.AddWithValue("@TestTypeTitle", test.Title);
                command.Parameters.AddWithValue("@TestTypeFees", test.Fees);
                command.Parameters.AddWithValue("@TestTypeDescription", test.Description);

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        private TestType Map(SqlDataReader r)
        {
            return new TestType
            {
                Id = Convert.ToInt32(r["TestTypeID"]),
                Title = Convert.ToString(r["TestTypeTitle"]),
                Description = Convert.ToString(r["TestTypeDescription"]),
                Fees = Convert.ToDecimal(r["TestTypeFees"])
            };
        }
    }
}
