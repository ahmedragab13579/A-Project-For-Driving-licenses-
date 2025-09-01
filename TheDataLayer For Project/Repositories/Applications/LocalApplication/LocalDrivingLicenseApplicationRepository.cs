using System.Data;
using System.Data.SqlClient;
using TheDataLayer_For_Project.Models.Applications.LocalApplication;
using TheDataLayer_For_Project.Models.ConnectionData;

namespace TheDataLayer_For_Project.Repositories.Applications.LocalApplication
{
    public class LocalDrivingLicenseApplicationRepository
    {
        private readonly string _ConnectionString;
        public LocalDrivingLicenseApplicationRepository()
        {
            _ConnectionString = ClassTheConnectionData.StringConnection;
        }
        private SqlConnection GetConnection() => new SqlConnection(_ConnectionString);

        private LocalDrivingLicenseApplication MapApplication(SqlDataReader reader)
        {
            return new LocalDrivingLicenseApplication
            {
                ID = Convert.ToInt32(reader["LocalDrivingLicenseApplicationID"]),
                ApplicationID = Convert.ToInt32(reader["ApplicationID"]),
                LicenseClassID = Convert.ToInt32(reader["LicenseClassID"]),

            };
        }

        private LocalDrivingLicenseApplication GetSingle(string query, SqlParameter parameter)
        {
            using (var connection = GetConnection())
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.Add(parameter);
                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                        return MapApplication(reader);
                }
            }
            return null;
        }

        public DataTable GetAll()
        {
            using (var connection = GetConnection())
            using (var command = new SqlCommand("SELECT * FROM LocalDrivingLicenseApplications_View", connection))
            {
                var table = new DataTable();
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    table.Load(reader);
                }
                return table;
            }
        }

        public LocalDrivingLicenseApplication GetByID(int id)
        {
            return GetSingle(
                "SELECT * FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @id",
                new SqlParameter("@id", SqlDbType.Int) { Value = id }
            );
        }

        public LocalDrivingLicenseApplication GetByApplicationID(int applicationID)
        {
            return GetSingle(
                "SELECT * FROM LocalDrivingLicenseApplications WHERE ApplicationID = @applicationID",
                new SqlParameter("@applicationID", SqlDbType.Int) { Value = applicationID }
            );
        }

        public bool IsLicenseExist(string nationalNo, string className)
        {
            using (var connection = GetConnection())
            using (var command = new SqlCommand(
                @"SELECT 1 
                  FROM LocalDrivingLicenseApplications_View
                  WHERE NationalNo = @NationalNo 
                    AND ClassName = @ClassName
                    AND Status IN ('New','Completed')", connection))
            {
                command.Parameters.Add("@NationalNo", SqlDbType.NVarChar).Value = nationalNo;
                command.Parameters.Add("@ClassName", SqlDbType.NVarChar).Value = className;

                connection.Open();
                return command.ExecuteScalar() != null;
            }
        }

        public int Add(LocalDrivingLicenseApplication application)
        {
            using (var connection = GetConnection())
            using (var command = new SqlCommand(@"
                INSERT INTO LocalDrivingLicenseApplications (ApplicationID, LicenseClassID)
                VALUES (@ApplicationID, @LicenseClassID);
                SELECT SCOPE_IDENTITY();", connection))
            {
                command.Parameters.Add("@ApplicationID", SqlDbType.Int).Value = application.ApplicationID;
                command.Parameters.Add("@LicenseClassID", SqlDbType.Int).Value = application.LicenseClassID;

                connection.Open();
                var result = command.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : -1;
            }
        }

        public bool Update(LocalDrivingLicenseApplication application)
        {
            using (var connection = GetConnection())
            using (var command = new SqlCommand(@"
                UPDATE LocalDrivingLicenseApplications
                SET ApplicationID = @ApplicationID,
                    LicenseClassID = @LicenseClassID
                WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID", connection))
            {
                command.Parameters.Add("@ApplicationID", SqlDbType.Int).Value = application.ApplicationID;
                command.Parameters.Add("@LicenseClassID", SqlDbType.Int).Value = application.LicenseClassID;
                command.Parameters.Add("@LocalDrivingLicenseApplicationID", SqlDbType.Int).Value = application.ID;

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool Delete(int id)
        {
            using (var connection = GetConnection())
            using (var command = new SqlCommand(
                "DELETE FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @id", connection))
            {
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }
    }
}
