using System.Data.SqlClient;
using TheDataLayer_For_Project.Models.Applications;
using TheDataLayer_For_Project.Models.ConnectionData;


namespace TheDataLayer_For_Project.Repositories.Applications
{
    public class ApplicationTypeRepository
    {
        private string _ConnectionString;
        public ApplicationTypeRepository()
        {
            _ConnectionString = ClassTheConnectionData.StringConnection;

        }

        private SqlConnection GetConnection() => new SqlConnection(_ConnectionString);

        public List<ApplicationType> GetAll()
        {
            var list = new List<ApplicationType>();
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(@"select * from ApplicationTypes", conn))
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

        public ApplicationType GetById(int id)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(@"select * from ApplicationTypes where ApplicationTypeID = @ID", conn))
            {
                cmd.Parameters.AddWithValue("@ID", id);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                        return Map(reader);
                }
            }
            return null;
        }


        public bool Update(ApplicationType app)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(@"
                UPDATE ApplicationTypes SET
                    ApplicationTypeTitle = @Title,
                    ApplicationFees = @Fees
                WHERE ApplicationTypeID = @ID", conn))
            {
                cmd.Parameters.AddWithValue("@ID", app.ID);
                cmd.Parameters.AddWithValue("@Title", app.Title);
                cmd.Parameters.AddWithValue("@Fees", app.Fees);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        private ApplicationType Map(SqlDataReader r)
        {
            return new ApplicationType
            {
                ID = Convert.ToInt32(r["ApplicationTypeID"]),
                Fees = Convert.ToDecimal(r["ApplicationFees"]),
                Title = Convert.ToString(r["ApplicationTypeTitle"])
            };

        }

    }
}
