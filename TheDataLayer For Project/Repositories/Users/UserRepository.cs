using System.Data.SqlClient;
using TheDataLayer_For_Project.Models.ConnectionData;
using TheDataLayer_For_Project.Models.Users;

namespace TheDataLayer_For_Project.Repositories.Users
{
    public class UserRepository
    {
        private readonly string _connectionString;

        public UserRepository()
        {
            _connectionString = ClassTheConnectionData.StringConnection;
        }

        private SqlConnection GetConnection() => new SqlConnection(_connectionString);

        public List<User> GetAll()
        {
            var list = new List<User>();
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand("SELECT * FROM Users", conn))
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

        public User GetById(int userId)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand("SELECT * FROM Users WHERE UserID = @ID", conn))
            {
                cmd.Parameters.AddWithValue("@ID", userId);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                        return Map(reader);
                }
            }
            return null;
        }

        public User GetByUserNameAndPassword(string userName, string password)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(
                "SELECT * FROM Users WHERE UserName = @Name AND Password = @Password AND IsActive = 1", conn))
            {
                cmd.Parameters.AddWithValue("@Name", userName);
                cmd.Parameters.AddWithValue("@Password", password);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                        return Map(reader);
                }
            }
            return null;
        }

        public User GetByPersonId(int personId)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand("SELECT * FROM Users WHERE PersonID = @PersonID", conn))
            {
                cmd.Parameters.AddWithValue("@PersonID", personId);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                        return Map(reader);
                }
            }
            return null;
        }

        public bool IsUserExist(string userName, string password)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(
                "SELECT 1 FROM Users WHERE UserName = @Name AND Password = @Password AND IsActive = 1", conn))
            {
                cmd.Parameters.AddWithValue("@Name", userName);
                cmd.Parameters.AddWithValue("@Password", password);
                conn.Open();
                return cmd.ExecuteScalar() != null;
            }
        }

        public bool IsUserExist(int personId)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand("SELECT 1 FROM Users WHERE PersonID = @PersonID", conn))
            {
                cmd.Parameters.AddWithValue("@PersonID", personId);
                conn.Open();
                return cmd.ExecuteScalar() != null;
            }
        }

        public int Add(User user)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(@"
                INSERT INTO Users (UserName, Password, PersonID, IsActive)
                VALUES (@UserName, @Password, @PersonID, @IsActive);
                SELECT SCOPE_IDENTITY();", conn))
            {
                cmd.Parameters.AddWithValue("@UserName", user.UserName);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@PersonID", user.PersonID);
                cmd.Parameters.AddWithValue("@IsActive", user.IsActive);

                conn.Open();
                var result = cmd.ExecuteScalar();
                return result != null && int.TryParse(result.ToString(), out int id) ? id : -1;
            }
        }

        public bool Update(User user)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(@"
                UPDATE Users
                SET UserName = @UserName,
                    Password = @Password,
                    IsActive = @IsActive
                WHERE UserID = @UserID", conn))
            {
                cmd.Parameters.AddWithValue("@UserName", user.UserName);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@IsActive", user.IsActive);
                cmd.Parameters.AddWithValue("@UserID", user.UserID);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Delete(int id)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand("DELETE FROM Users WHERE UserID = @ID", conn))
            {
                cmd.Parameters.AddWithValue("@ID", id);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        private User Map(SqlDataReader r)
        {
            return new User
            {
                UserID = Convert.ToInt32(r["UserID"]),
                PersonID = Convert.ToInt32(r["PersonID"]),
                UserName = Convert.ToString(r["UserName"]),
                Password = Convert.ToString(r["Password"]),
                IsActive = Convert.ToBoolean(r["IsActive"])
            };
        }
    }
}
