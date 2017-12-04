using DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

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
        public DataSet GetDistincRoleName()
        {
            return this.repository.DistinctRoleName();
        }
        public DataSet GetDistincProfileName()
        {
            return this.repository.DistinctProfileName();
        }
        public DataSet GetDistincTablespaceName()
        {
            return this.repository.DistinctTablespaceName();
        }
        public DataSet GetGrantedRoleToUser(string Userneme)
        {
            return this.repository.GetGrantedRoleToUser(Userneme);
        }
    }
}
