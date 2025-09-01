using System.Data;
using System.Data.SqlClient;
using TheDataLayer_For_Project.Models.Applications.LocalApplication;
using TheDataLayer_For_Project.Models.ConnectionData;

namespace TheDataLayer_For_Project.Repositories.Applications.LocalApplication
{
    public class LocalDrivingLicenseApplication_ViewRepository
    {
        private readonly string _connectionString;

        public LocalDrivingLicenseApplication_ViewRepository()
        {
            _connectionString = ClassTheConnectionData.StringConnection;
        }

        public SqlConnection GetConnection() => new SqlConnection(_connectionString);

        public LocalDrivingLicenseApplication_View MapApplicationView(SqlDataReader reader)
        {
            return new LocalDrivingLicenseApplication_View
            {
                LocalDrivingLicenseApplicationID = Convert.ToInt32(reader["LocalDrivingLicenseApplicationID"]),
                ClassName = reader["ClassName"]?.ToString(),
                NationalNo = reader["NationalNo"]?.ToString(),
                FullName = reader["FullName"]?.ToString(),
                ApplicationDate = Convert.ToDateTime(reader["ApplicationDate"]),
                PassedTestCount = Convert.ToInt32(reader["PassedTestCount"]),
                Status = reader["Status"]?.ToString()
            };
        }

        public LocalDrivingLicenseApplication_View GetSingle(string query, SqlParameter parameter)
        {
            using (var connection = GetConnection())
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.Add(parameter);
                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                        return MapApplicationView(reader);
                }
            }
            return null;
        }

        public LocalDrivingLicenseApplication_View GetByID(int id)
        {
            return GetSingle(
                "SELECT * FROM LocalDrivingLicenseApplications_View WHERE LocalDrivingLicenseApplicationID = @id",
                new SqlParameter("@id", SqlDbType.Int) { Value = id }
            );
        }
    }
}
