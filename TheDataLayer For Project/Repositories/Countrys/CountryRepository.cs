using System.Data.SqlClient;
using TheDataLayer_For_Project.Models.ConnectionData;

namespace TheDataLayer_For_Project.Repositories.Country
{
    public class CountryRepository
    {
        private string _ConnectionString;
        public CountryRepository()
        {
            _ConnectionString = ClassTheConnectionData.StringConnection;
        }
        private SqlConnection GetConnection() => new SqlConnection(_ConnectionString);
        public List<TheDataLayer_For_Project.Models.Country.Country> GetAll()
        {
            var list = new List<TheDataLayer_For_Project.Models.Country.Country>();
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand("SELECT * FROM Countries", conn))
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

        private TheDataLayer_For_Project.Models.Country.Country Map(SqlDataReader r)
        {
            return new TheDataLayer_For_Project.Models.Country.Country
            {
                Id = Convert.ToInt32(r["CountryID"]),
                Name = Convert.ToString(r["CountryName"])
            };
        }


    }
}
