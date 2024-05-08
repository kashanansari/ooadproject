using System.Data.SqlClient;

namespace OOAD
{
    public class DataAccessLayer
    {
        private string _connectionString = "Server=DESKTOP-OFI2DNU;Database=ooad_project;User Id=Huzaifa;Password=123";

        public bool VerifyUserCredentials(string email, string password)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM users WHERE email = @Email AND password = @Password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);

                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
        }
    }
}
