using System.Data.SqlClient;
using TheDataLayer_For_Project.Models.Appointment;
using TheDataLayer_For_Project.Models.ConnectionData;

namespace TheDataLayer_For_Project.Repositories.Appointments
{
    public class AppointmentRepository
    {
        private readonly string _connectionString;

        public AppointmentRepository()
        {
            _connectionString = ClassTheConnectionData.StringConnection;


        }

        private SqlConnection GetConnection() => new SqlConnection(_connectionString);

        private Appointment Map(SqlDataReader r)
        {
            return new Appointment
            {
                ID = Convert.ToInt32(r["TestAppointmentID"]),
                TestTypeID = Convert.ToInt32(r["TestTypeID"]),
                LocalDrivingLicenseApplicationID = Convert.ToInt32(r["LocalDrivingLicenseApplicationID"]),
                AppointmentDate = Convert.ToDateTime(r["AppointmentDate"]),
                PaidFees = Convert.ToDecimal(r["PaidFees"]),
                CreatedByUserID = Convert.ToInt32(r["CreatedByUserID"]),
                IsLocked = Convert.ToBoolean(r["IsLocked"])
            };
        }

        public List<Appointment> GetAllByLocalId(int localId)
        {
            var list = new List<Appointment>();
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand("SELECT * FROM TestAppointments WHERE LocalDrivingLicenseApplicationID=@LocalId", conn))
            {
                cmd.Parameters.AddWithValue("@LocalId", localId);
                conn.Open();
                using (var r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        list.Add(Map(r));
                    }
                }
            }
            return list;
        }

        public Appointment GetById(int id)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand("SELECT * FROM TestAppointments WHERE TestAppointmentID=@id", conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                using (var r = cmd.ExecuteReader())
                {
                    if (r.Read())
                        return Map(r);
                }
            }
            return null;
        }

        public Appointment GetByLocalAndType(int localId, int testTypeId)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand("SELECT * FROM TestAppointments WHERE LocalDrivingLicenseApplicationID=@localId AND TestTypeID=@testTypeId AND IsLocked=0", conn))
            {
                cmd.Parameters.AddWithValue("@localId", localId);
                cmd.Parameters.AddWithValue("@testTypeId", testTypeId);
                conn.Open();
                using (var r = cmd.ExecuteReader())
                {
                    if (r.Read())
                        return Map(r);
                }
            }
            return null;
        }

        public bool IsAppointmentExist(int localId, int testTypeId)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand("SELECT 1 FROM TestAppointments WHERE LocalDrivingLicenseApplicationID=@localId AND TestTypeID=@testTypeId", conn))
            {
                cmd.Parameters.AddWithValue("@localId", localId);
                cmd.Parameters.AddWithValue("@testTypeId", testTypeId);
                conn.Open();
                using (var r = cmd.ExecuteReader())
                {
                    return r.HasRows;
                }
            }
        }

        public bool IsAppointmentActive(int localId, int testTypeId)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand("SELECT 1 FROM TestAppointments WHERE LocalDrivingLicenseApplicationID=@localId AND TestTypeID=@testTypeId AND IsLocked=0", conn))
            {
                cmd.Parameters.AddWithValue("@localId", localId);
                cmd.Parameters.AddWithValue("@testTypeId", testTypeId);
                conn.Open();
                using (var r = cmd.ExecuteReader())
                {
                    return r.HasRows;
                }
            }
        }

        public int Add(Appointment appointment)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(@"
                INSERT INTO TestAppointments (TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked)
                VALUES (@TestTypeID, @LocalId, @Date, @Fees, @UserId, @IsLocked);
                SELECT SCOPE_IDENTITY();", conn))
            {
                cmd.Parameters.AddWithValue("@TestTypeID", appointment.TestTypeID);
                cmd.Parameters.AddWithValue("@LocalId", appointment.LocalDrivingLicenseApplicationID);
                cmd.Parameters.AddWithValue("@Date", appointment.AppointmentDate);
                cmd.Parameters.AddWithValue("@Fees", appointment.PaidFees);
                cmd.Parameters.AddWithValue("@UserId", appointment.CreatedByUserID);
                cmd.Parameters.AddWithValue("@IsLocked", appointment.IsLocked);

                conn.Open();
                object result = cmd.ExecuteScalar();
                return result != null && int.TryParse(result.ToString(), out int id) ? id : -1;
            }
        }

        public bool Update(Appointment appointment)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(@"
                UPDATE TestAppointments
                SET TestTypeID=@TestTypeID,
                    LocalDrivingLicenseApplicationID=@LocalId,
                    AppointmentDate=@Date,
                    PaidFees=@Fees,
                    CreatedByUserID=@UserId,
                    IsLocked=@IsLocked
                WHERE TestAppointmentID=@Id", conn))
            {
                cmd.Parameters.AddWithValue("@Id", appointment.ID);
                cmd.Parameters.AddWithValue("@TestTypeID", appointment.TestTypeID);
                cmd.Parameters.AddWithValue("@LocalId", appointment.LocalDrivingLicenseApplicationID);
                cmd.Parameters.AddWithValue("@Date", appointment.AppointmentDate);
                cmd.Parameters.AddWithValue("@Fees", appointment.PaidFees);
                cmd.Parameters.AddWithValue("@UserId", appointment.CreatedByUserID);
                cmd.Parameters.AddWithValue("@IsLocked", appointment.IsLocked);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
