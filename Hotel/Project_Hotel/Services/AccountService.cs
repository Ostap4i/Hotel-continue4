using Project_Hotel.Entities;
using Project_Hotel.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project_Hotel.Services
{
    public class AccountService
    {
        string connectionString = "Server=tcp:ostapserver.database.windows.net,1433;" +
            "Initial Catalog=Testdb;Persist Security Info=False;User ID=CloudSA713bc2aa;Password=ITstep123;" +
            "MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;" +
            "Pooling=true; Max Pool Size=10; Min Pool Size=2";


        private AccountRepository accountRepository = new AccountRepository();

        public Account login(string name, string password)
        {
            Account account;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                account = accountRepository.login(connection, name, password);
            }
            return account;
        }

    }

}


