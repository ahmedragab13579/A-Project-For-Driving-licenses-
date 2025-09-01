using System.Data.SqlClient;
using TheDataLayer_For_Project.Models.ConnectionData;
using TheDataLayer_For_Project.Models.Licenses.InternationalLicense;

namespace TheDataLayer_For_Project.Repositories.Licenses.InternationalLicense
{
    public class InternationalRepository
    {
        private readonly string _connectionString;

        public InternationalRepository()
        {
            _connectionString = ClassTheConnectionData.StringConnection;
        }

        private SqlConnection GetConnection() => new SqlConnection(_connectionString);

        private TheDataLayer_For_Project.Models.Licenses.InternationalLicense.InternationalLicense Map(SqlDataReader r)
        {
            return new TheDataLayer_For_Project.Models.Licenses.InternationalLicense.InternationalLicense
            {
                ID = r["InternationalLicenseID"] != DBNull.Value ? Convert.ToInt32(r["InternationalLicenseID"]) : 0,
                ApplicationID = r["ApplicationID"] != DBNull.Value ? Convert.ToInt32(r["ApplicationID"]) : 0,
                DriverID = r["DriverID"] != DBNull.Value ? Convert.ToInt32(r["DriverID"]) : 0,
                IssueUsingLicalLicenseID = r["IssuedUsingLocalLicenseID"] != DBNull.Value ? Convert.ToInt32(r["IssuedUsingLocalLicenseID"]) : 0,
                IssueData = r["IssueDate"] != DBNull.Value ? Convert.ToDateTime(r["IssueDate"]) : DateTime.MinValue,
                ExpirationDate = r["ExpirationDate"] != DBNull.Value ? Convert.ToDateTime(r["ExpirationDate"]) : DateTime.MinValue,
                IsActive = r["IsActive"] != DBNull.Value && Convert.ToBoolean(r["IsActive"]),
                CreatedByuserID = r["CreatedByUserID"] != DBNull.Value ? Convert.ToInt32(r["CreatedByUserID"]) : 0
            };
        }

        public List<TheDataLayer_For_Project.Models.Licenses.InternationalLicense.InternationalLicense> GetAll()
        {
            var list = new List<TheDataLayer_For_Project.Models.Licenses.InternationalLicense.InternationalLicense>();
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand("SELECT * FROM InternationalLicenses", conn))
            {
                conn.Open();
                using (var r = cmd.ExecuteReader())
                {
                    while (r.Read())
                        list.Add(Map(r));
                }
            }
            return list;
        }

        public bool IsLicenseExist(int applicationId)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand("SELECT 1 FROM InternationalLicenses WHERE ApplicationID=@ApplicationID", conn))
            {
                cmd.Parameters.AddWithValue("@ApplicationID", applicationId);
                conn.Open();
                using (var r = cmd.ExecuteReader())
                {
                    return r.HasRows;
                }
            }
        }

        public List<TheDataLayer_For_Project.Models.Licenses.InternationalLicense.InternationalLicense> GetByDriverId(int driverId)
        {
            var list = new List<TheDataLayer_For_Project.Models.Licenses.InternationalLicense.InternationalLicense>();
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand("SELECT * FROM InternationalLicenses WHERE DriverID=@DriverID", conn))
            {
                cmd.Parameters.AddWithValue("@DriverID", driverId);
                conn.Open();
                using (var r = cmd.ExecuteReader())
                {
                    while (r.Read())
                        list.Add(Map(r));
                }
            }
            return list;
        }

        public int Add(TheDataLayer_For_Project.Models.Licenses.InternationalLicense.InternationalLicense license)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(@"
                INSERT INTO InternationalLicenses
                (ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID)
                VALUES (@ApplicationID, @DriverID, @IssuedUsingLocalLicenseID, @IssueDate, @ExpirationDate, @IsActive, @CreatedByUserID);
                SELECT SCOPE_IDENTITY();", conn))
            {
                cmd.Parameters.AddWithValue("@ApplicationID", license.ApplicationID);
                cmd.Parameters.AddWithValue("@DriverID", license.DriverID);
                cmd.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", license.IssueUsingLicalLicenseID);
                cmd.Parameters.AddWithValue("@IssueDate", license.IssueData);
                cmd.Parameters.AddWithValue("@ExpirationDate", license.ExpirationDate);
                cmd.Parameters.AddWithValue("@IsActive", license.IsActive);
                cmd.Parameters.AddWithValue("@CreatedByUserID", license.CreatedByuserID);

                conn.Open();
                object result = cmd.ExecuteScalar();
                return result != null && int.TryParse(result.ToString(), out int id) ? id : -1;
            }
        }
    }
}
