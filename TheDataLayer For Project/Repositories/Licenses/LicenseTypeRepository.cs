using System.Data.SqlClient;
using TheDataLayer_For_Project.Models.ConnectionData;
using TheDataLayer_For_Project.Models.Licenses;

namespace TheDataLayer_For_Project.Repositories.Licenses
{
    public class LicenseTypeRepository
    {
        private readonly string _connectionString;

        public LicenseTypeRepository()
        {
            _connectionString = ClassTheConnectionData.StringConnection;
        }

        private SqlConnection GetConnection() => new SqlConnection(_connectionString);

        public List<LicenseType> GetAll()
        {
            var list = new List<LicenseType>();
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand("SELECT * FROM LicenseClasses", conn))
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

        public LicenseType GetById(int id)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand("SELECT * FROM LicenseClasses WHERE LicenseClassID = @LicenseClassID", conn))
            {
                cmd.Parameters.AddWithValue("@LicenseClassID", id);
                conn.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return Map(reader);
                    }
                }
            }
            return null;
        }

        private LicenseType Map(SqlDataReader reader)
        {
            return new LicenseType
            {
                LicenseClassID = Convert.ToInt32(reader["LicenseClassID"]),
                ClassName = Convert.ToString(reader["ClassName"]),
                ClassDescription = Convert.ToString(reader["ClassDescription"]),
                MinimumAllowedAge = Convert.ToByte(reader["MinimumAllowedAge"]),
                DefaultValidityLength = Convert.ToByte(reader["DefaultValidityLength"]),
                ClassFees = Convert.ToDecimal(reader["ClassFees"])
            };
        }
    }
}
