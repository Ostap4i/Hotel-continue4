using Project_Hotel.Entities;
using Project_Hotel.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Project_Hotel.Controllers
{
    public class AccountController
    {
        private AccountService accountService = new AccountService();

        public Account login(string email, string password)
        {
            return accountService.login(email, password);
        }
    }

}

