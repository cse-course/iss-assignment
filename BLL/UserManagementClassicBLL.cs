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

        public DataSet GetGrantedProfileToUser(string Userneme)
        {
            return this.repository.GetGrantedProfileToUser(Userneme);
        }
        public void AddProfileToUser(String Username, String Profile)
        {
            this.repository.AddProfileToUser(Username, Profile);
        }
        public void RemoveProfileFromUser(String Username, String Profile)
        {
            this.repository.RemoveProfileFromUser(Username, Profile);
        }
        public void AddRoleToUser(String Username, String Role)
        {
            this.repository.AddRoleToUser(Username, Role);
        }
        public void RemoveRoleFromUser(String Username, String Role)
        {
            this.repository.RemoveRoleFromUser(Username, Role);
        }
        public void DropOracleUser(String Username)
        {
            this.repository.DropOracleUser(Username);
        }
    }
}
