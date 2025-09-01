using System.Data;
using System.Data.SqlClient;
using TheDataLayer_For_Project.Models.ConnectionData;
using TheDataLayer_For_Project.Models.Tests;

namespace TheDataLayer_For_Project.Repositories.Tests
{
    public class TestRepository
    {
        private readonly string _ConnectionString;

        public TestRepository()
        {
            _ConnectionString = ClassTheConnectionData.StringConnection;
        }

        private SqlConnection GetConnection() => new SqlConnection(_ConnectionString);

        private Test MapTest(SqlDataReader reader)
        {
            return new Test
            {
                TestAppointmentID = Convert.ToInt32(reader["TestAppointmentID"]),
                ID = Convert.ToInt32(reader["TestID"]),
                TestResult = Convert.ToBoolean(reader["TestResult"]),
                Notes = reader["Notes"] == DBNull.Value ? null : reader["Notes"].ToString(),
                UserID = Convert.ToInt32(reader["CreatedByUserID"])
            };
        }

        private Test GetSingle(string query, SqlParameter parameter)
        {
            using (var connection = GetConnection())
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.Add(parameter);
                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                        return MapTest(reader);
                }
            }
            return null;
        }

        public Test GetByAppointmentID(int testAppointmentID)
        {
            return GetSingle(
                "SELECT * FROM Tests WHERE TestAppointmentID = @TestAppointmentID",
                new SqlParameter("@TestAppointmentID", SqlDbType.Int) { Value = testAppointmentID }
            );
        }

        public Test GetByID(int id)
        {
            return GetSingle(
                "SELECT * FROM Tests WHERE TestID = @TestID",
                new SqlParameter("@TestID", SqlDbType.Int) { Value = id }
            );
        }

        public int Add(Test test)
        {
            using (var connection = GetConnection())
            using (var command = new SqlCommand(@"
                INSERT INTO Tests (TestAppointmentID, TestResult, Notes, CreatedByUserID)
                VALUES (@TestAppointmentID, @TestResult, @Notes, @CreatedByUserID);
                SELECT SCOPE_IDENTITY();", connection))
            {
                command.Parameters.Add("@TestAppointmentID", SqlDbType.Int).Value = test.TestAppointmentID;
                command.Parameters.Add("@TestResult", SqlDbType.Bit).Value = test.TestResult;
                command.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = (object)test.Notes ?? DBNull.Value;
                command.Parameters.Add("@CreatedByUserID", SqlDbType.Int).Value = test.UserID;

                connection.Open();
                var result = command.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : -1;
            }
        }

        public bool Update(Test test)
        {
            using (var connection = GetConnection())
            using (var command = new SqlCommand(@"
                UPDATE Tests
                SET TestResult = @TestResult,
                    Notes = @Notes,
                    CreatedByUserID = @CreatedByUserID
                WHERE TestID = @TestID", connection))
            {
                command.Parameters.Add("@TestResult", SqlDbType.Bit).Value = test.TestResult;
                command.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = (object)test.Notes ?? DBNull.Value;
                command.Parameters.Add("@CreatedByUserID", SqlDbType.Int).Value = test.UserID;
                command.Parameters.Add("@TestID", SqlDbType.Int).Value = test.ID;

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }
    }
}
