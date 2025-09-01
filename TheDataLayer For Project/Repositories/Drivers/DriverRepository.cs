using System.Data;
using System.Data.SqlClient;
using TheDataLayer_For_Project.Models.ConnectionData;
using TheDataLayer_For_Project.Models.Driver;
using TheDataLayer_For_Project.Models.Drivers;

namespace TheDataLayer_For_Project.Repositories.Drivers
{
    public class DriverRepository
    {
        private readonly string _connectionString;

        public DriverRepository()
        {
            _connectionString = ClassTheConnectionData.StringConnection;
        }

        private SqlConnection GetConnection() => new SqlConnection(_connectionString);

        public List<DriverView> GetAll()
        {
            var list = new List<DriverView>();

            using (var conn = GetConnection())
            using (var cmd = new SqlCommand("SELECT * FROM Drivers_View", conn))
            {
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(Mapview(reader));
                    }
                }
            }

            return list;
        }

        public Driver GetById(int id)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand("SELECT * FROM Drivers WHERE DriverID = @DriverID", conn))
            {
                cmd.Parameters.Add("@DriverID", SqlDbType.Int).Value = id;
                conn.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                        return Map(reader);
                }
            }

            return null;
        }

        public Driver GetByPersonId(int personId)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand("SELECT * FROM Drivers WHERE PersonID = @PersonID", conn))
            {
                cmd.Parameters.Add("@PersonID", SqlDbType.Int).Value = personId;
                conn.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                        return Map(reader);
                }
            }

            return null;
        }

        public int Add(Driver driver)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(@"
                INSERT INTO Drivers (PersonID, CreatedByUserID, CreatedDate)
                VALUES (@PersonID, @CreatedByUserID, @CreatedDate);
                SELECT SCOPE_IDENTITY();", conn))
            {
                cmd.Parameters.Add("@PersonID", SqlDbType.Int).Value = driver.PersonID;
                cmd.Parameters.Add("@CreatedByUserID", SqlDbType.Int).Value = driver.CreatedByUserID;
                cmd.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = driver.CreatedDate;

                conn.Open();
                object result = cmd.ExecuteScalar();
                return result != null && int.TryParse(result.ToString(), out int newId) ? newId : -1;
            }
        }

        private Driver Map(SqlDataReader reader)
        {
            return new Driver
            {
                PersonID = reader["PersonID"] != DBNull.Value ? Convert.ToInt32(reader["PersonID"]) : 0,
                ID = reader["DriverID"] != DBNull.Value ? Convert.ToInt32(reader["DriverID"]) : 0,
                CreatedByUserID = reader["CreatedByUserID"] != DBNull.Value ? Convert.ToInt32(reader["CreatedByUserID"]) : 0,
                CreatedDate = reader["CreatedDate"] != DBNull.Value ? Convert.ToDateTime(reader["CreatedDate"]) : DateTime.MinValue
            };
        }
        private DriverView Mapview(SqlDataReader reader)
        {
            return new DriverView
            {
                PersonID = reader["PersonID"] != DBNull.Value ? Convert.ToInt32(reader["PersonID"]) : 0,
                DriverID = reader["DriverID"] != DBNull.Value ? Convert.ToInt32(reader["DriverID"]) : 0,
                NationalNo = reader["NationalNo"] != DBNull.Value ? Convert.ToString(reader["NationalNo"]) : "",
                CreatedDate = reader["CreatedDate"] != DBNull.Value ? Convert.ToDateTime(reader["CreatedDate"]) : DateTime.MinValue,
                FullName = reader["FullName"] != DBNull.Value ? Convert.ToString(reader["FullName"]) : "",
                NumberOfActiveLicenses = reader["NumberOfActiveLicenses"] != DBNull.Value ? Convert.ToInt32(reader["NumberOfActiveLicenses"]) : 0
            };
        }
    }
}
