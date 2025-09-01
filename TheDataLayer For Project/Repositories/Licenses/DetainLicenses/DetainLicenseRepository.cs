using System.Data.SqlClient;
using TheDataLayer_For_Project.Models;
using TheDataLayer_For_Project.Models.ConnectionData;

namespace TheDataLayer_For_Project.Repositories.Licenses.DetainLicense
{
    public class DetainLicenseRepository
    {
        private readonly string _connectionString;

        public DetainLicenseRepository()
        {
            _connectionString = ClassTheConnectionData.StringConnection;
        }

        private SqlConnection GetConnection() => new SqlConnection(_connectionString);

        public List<DetainedLicense> GetAll()
        {
            var list = new List<DetainedLicense>();
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand("SELECT * FROM DetainedLicenses", conn))
            {
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        list.Add(Map(reader));
                }
            }
            return list;
        }

        public DetainedLicense GetById(int licenseId)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand("SELECT * FROM DetainedLicenses WHERE LicenseID = @LicenseID and IsReleased=0", conn))
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

        public int Add(DetainedLicense model)
        {
            string query = @"
                INSERT INTO DetainedLicenses (
                    LicenseID, FineFees, DetainDate, CreatedByUserID, IsReleased
                ) VALUES (
                    @LicenseID, @FineFees, @DetainDate, @CreatedByUserID, @IsReleased
                );
                SELECT SCOPE_IDENTITY();";

            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@LicenseID", model.LicenseID);
                cmd.Parameters.AddWithValue("@FineFees", model.FineFees);
                cmd.Parameters.AddWithValue("@DetainDate", model.Date);
                cmd.Parameters.AddWithValue("@CreatedByUserID", model.User);
                cmd.Parameters.AddWithValue("@IsReleased", model.IsRelesd);

                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public bool UpdateReleaseInfo(DetainedLicense model)
        {
            string query = @"
                UPDATE DetainedLicenses
                SET IsReleased = @IsReleased,
                    ReleaseDate = @ReleaseDate,
                    ReleasedByUserID = @ReleasedByUserID,
                    ReleaseApplicationID = @ReleaseApplicationID
                WHERE DetainID = @DetainID";

            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@DetainID", model.ID);
                cmd.Parameters.AddWithValue("@IsReleased", model.IsRelesd);
                cmd.Parameters.AddWithValue("@ReleaseDate", model.RelaseDate);
                cmd.Parameters.AddWithValue("@ReleasedByUserID", model.RelaisByuser);
                cmd.Parameters.AddWithValue("@ReleaseApplicationID", model.RelaisAppID);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool IsDetained(int licenseId)
        {
            string query = "SELECT 1 FROM DetainedLicenses WHERE LicenseID = @id AND IsReleased = 0";
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", licenseId);
                conn.Open();
                return cmd.ExecuteScalar() != null;
            }
        }

        private DetainedLicense Map(SqlDataReader r)
        {
            return new DetainedLicense
            {
                LicenseID = Convert.ToInt32(r["LicenseID"]),
                ID = Convert.ToInt32(r["DetainID"]),
                FineFees = Convert.ToDecimal(r["FineFees"]),
                Date = Convert.ToDateTime(r["DetainDate"]),
                User = Convert.ToInt32(r["CreatedByUserID"]),
                IsRelesd = Convert.ToBoolean(r["IsReleased"]),
                RelaseDate = Convert.ToDateTime(r["ReleaseDate"] == DBNull.Value ? null : (DateTime?)Convert.ToDateTime(r["ReleaseDate"])),
                RelaisByuser = Convert.ToInt32(r["ReleasedByUserID"] == DBNull.Value ? null : (int?)Convert.ToInt32(r["ReleasedByUserID"])),
                RelaisAppID = Convert.ToInt32(r["ReleaseApplicationID"] == DBNull.Value ? null : (int?)Convert.ToInt32(r["ReleaseApplicationID"]))
            };
        }
    }
}
