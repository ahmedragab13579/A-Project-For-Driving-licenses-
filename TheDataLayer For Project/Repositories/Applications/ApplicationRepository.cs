using System.Data.SqlClient;
using TheDataLayer_For_Project.Models.Applications;
using TheDataLayer_For_Project.Models.ConnectionData;
namespace TheDataLayer_For_Project.Repositories.Applications
{
    public class ApplicationRepository
    {
        private string _ConnectionString;
        public ApplicationRepository()
        {
            _ConnectionString = ClassTheConnectionData.StringConnection;

        }

        private SqlConnection GetConnection() => new SqlConnection(_ConnectionString);

        public List<Application> GetAll()
        {
            var list = new List<Application>();
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand("SELECT * FROM Applications", conn))
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

        public Application GetById(int id)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand("SELECT * FROM Applications WHERE ApplicationID = @ID", conn))
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

        public int Add(Application app)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(@"
                INSERT INTO Applications (ApplicantPersonID, ApplicationDate, ApplicationTypeID, 
                                          ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID)
                VALUES (@PersonID, @Date, @Type, @StatusID, @LastStatusDate, @Fees, @CreatedByUserID);
                SELECT SCOPE_IDENTITY();", conn))
            {
                FillParams(cmd, app, isUpdate: false);
                conn.Open();
                object result = cmd.ExecuteScalar();
                return result != null && int.TryParse(result.ToString(), out int id) ? id : -1;
            }
        }

        public bool Update(Application app)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(@"
                UPDATE Applications SET 
                    ApplicantPersonID = @PersonID,
                    ApplicationDate = @Date,
                    ApplicationTypeID = @Type,
                    ApplicationStatus = @StatusID,
                    LastStatusDate = @LastStatusDate,
                    PaidFees = @Fees,
                    CreatedByUserID = @CreatedByUserID
                WHERE ApplicationID = @ID", conn))
            {
                FillParams(cmd, app, isUpdate: true);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Delete(int id)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand("DELETE FROM Applications WHERE ApplicationID = @ID", conn))
            {
                cmd.Parameters.AddWithValue("@ID", id);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Cancel(int id)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(@"
                UPDATE Applications SET 
                    ApplicationStatus = 2, 
                    LastStatusDate = @Now 
                WHERE ApplicationID = @ID", conn))
            {
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@Now", DateTime.Now);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        private Application Map(SqlDataReader r)
        {
            return new Application
            {
                ID = Convert.ToInt32(r["ApplicationID"]),
                PersonID = Convert.ToInt32(r["ApplicantPersonID"]),
                Date = Convert.ToDateTime(r["ApplicationDate"]),
                Type = Convert.ToInt32(r["ApplicationTypeID"]),
                StatusID = Convert.ToByte(r["ApplicationStatus"]),
                LastStatusDate = Convert.ToDateTime(r["LastStatusDate"]),
                Fees = Convert.ToDecimal(r["PaidFees"]),
                CreatedByUserID = Convert.ToInt32(r["CreatedByUserID"])
            };
        }

        private void FillParams(SqlCommand cmd, Application app, bool isUpdate)
        {
            if (isUpdate)
                cmd.Parameters.AddWithValue("@ID", app.ID);

            cmd.Parameters.AddWithValue("@PersonID", app.PersonID);
            cmd.Parameters.AddWithValue("@Date", app.Date);
            cmd.Parameters.AddWithValue("@Type", app.Type);
            cmd.Parameters.AddWithValue("@StatusID", app.StatusID);
            cmd.Parameters.AddWithValue("@LastStatusDate", app.LastStatusDate);
            cmd.Parameters.AddWithValue("@Fees", app.Fees);
            cmd.Parameters.AddWithValue("@CreatedByUserID", app.CreatedByUserID);
        }
    }
}
