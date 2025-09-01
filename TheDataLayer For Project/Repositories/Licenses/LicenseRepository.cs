using System.Data.SqlClient;
using TheDataLayer_For_Project.Models.ConnectionData;
using TheDataLayer_For_Project.Models.Licenses;

namespace TheDataLayer_For_Project.Repositories.Licenses
{
    public class LicenseRepository
    {
        private readonly string _connectionString;

        public LicenseRepository()
        {
            _connectionString = ClassTheConnectionData.StringConnection;
        }

        private SqlConnection GetConnection() => new SqlConnection(_connectionString);

        public License GetByApplicationId(int applicationId)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand("SELECT * FROM Licenses WHERE ApplicationID = @ApplicationID", conn))
            {
                cmd.Parameters.AddWithValue("@ApplicationID", applicationId);
                conn.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                        return Map(reader);
                }
            }
            return null;
        }

        public License GetById(int licenseId)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand("SELECT * FROM Licenses WHERE LicenseID = @LicenseID", conn))
            {
                cmd.Parameters.AddWithValue("@LicenseID", licenseId);
                conn.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                        return Map(reader);
                }
            }
            return null;
        }

        public List<License> GetByDriverId(int driverId)
        {
            var list = new List<License>();

            using (var conn = GetConnection())
            using (var cmd = new SqlCommand("SELECT * FROM Licenses WHERE DriverID = @DriverID", conn))
            {
                cmd.Parameters.AddWithValue("@DriverID", driverId);
                conn.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        list.Add(Map(reader));
                }
            }
            return list;
        }

        public int Add(License license)
        {
            var query = @"
                INSERT INTO Licenses (
                    ApplicationID,
                    LicenseClass,
                    DriverID,
                    IssueDate,
                    ExpirationDate,
                    Notes,
                    PaidFees,
                    IsActive,
                    IssueReason,
                    CreatedByUserID
                ) VALUES (
                    @ApplicationID,
                    @LicenseClass,
                    @DriverID,
                    @IssueDate,
                    @ExpirationDate,
                    @Notes,
                    @PaidFees,
                    @IsActive,
                    @IssueReason,
                    @CreatedByUserID
                );
                SELECT SCOPE_IDENTITY();";

            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@ApplicationID", license.ApplicationID);
                cmd.Parameters.AddWithValue("@LicenseClass", license.LicenseClass);
                cmd.Parameters.AddWithValue("@DriverID", license.DriverID);
                cmd.Parameters.AddWithValue("@IssueDate", license.IssueDate);
                cmd.Parameters.AddWithValue("@ExpirationDate", license.ExpirationDate);
                cmd.Parameters.AddWithValue("@Notes", (object)license.Notes ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@PaidFees", license.Fees);
                cmd.Parameters.AddWithValue("@IsActive", license.IsActive);
                cmd.Parameters.AddWithValue("@IssueReason", license.IssueReason);
                cmd.Parameters.AddWithValue("@CreatedByUserID", license.CreatedByUserID);

                conn.Open();
                object result = cmd.ExecuteScalar();

                return result != null && int.TryParse(result.ToString(), out int id) ? id : -1;
            }
        }

        public bool DeactivateLicense(int licenseId)
        {
            bool found = false;
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand("UPDATE Licenses SET IsActive = 0 WHERE LicenseID = @Id", conn))
            {
                cmd.Parameters.AddWithValue("@Id", licenseId);
                conn.Open();
                cmd.ExecuteNonQuery();
                found = true;
            }
            return found;
        }

        public bool IsActive(int licenseId)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand("SELECT 1 FROM Licenses WHERE LicenseID = @Id AND IsActive = 1", conn))
            {
                cmd.Parameters.AddWithValue("@Id", licenseId);
                conn.Open();
                return cmd.ExecuteScalar() != null;
            }
        }

        private License Map(SqlDataReader r)
        {
            return new License
            {
                ID = Convert.ToInt32(r["LicenseID"]),
                ApplicationID = Convert.ToInt32(r["ApplicationID"]),
                LicenseClass = Convert.ToInt32(r["LicenseClass"]),
                DriverID = Convert.ToInt32(r["DriverID"]),
                IssueDate = Convert.ToDateTime(r["IssueDate"]),
                ExpirationDate = Convert.ToDateTime(r["ExpirationDate"]),
                Notes = r["Notes"] == DBNull.Value ? null : Convert.ToString(r["Notes"]),
                Fees = Convert.ToDecimal(r["PaidFees"]),
                IsActive = Convert.ToBoolean(r["IsActive"]),
                IssueReason = Convert.ToInt32(r["IssueReason"]),
                CreatedByUserID = Convert.ToInt32(r["CreatedByUserID"])
            };
        }
    }
}
