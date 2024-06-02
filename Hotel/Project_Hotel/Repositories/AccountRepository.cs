using Project_Hotel.Entities;
using System.Data.SqlClient;
namespace Project_Hotel.Repositories
{
    public class AccountRepository
    {

        public Account login(SqlConnection connection, string name, string password)
        {
            Account account = null;
            string query = "SELECT * FROM Accounts WHERE name = @name AND password = @password";

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.Add("@name", System.Data.SqlDbType.NVarChar).Value = name;
                cmd.Parameters.Add("@password", System.Data.SqlDbType.NVarChar).Value = password;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["id"]);
                        string email = Convert.ToString(reader["email"]);

                        account = new Account(id, name, email, password);
                    }
                }
            }
            return account;
        }

    }
}





