using DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserManagementClassicBLL
    {
        private UserManagementClassicRepository repository;
        public UserManagementClassicBLL(DbContext context)
        {
            this.repository = new UserManagementClassicRepository(context);
        }
        public void AddOracleUser(String Username, String Password)
        {
            this.repository.AddOracleUser(Username, Password);
        }
    }
}
