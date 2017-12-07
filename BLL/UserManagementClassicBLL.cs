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
        public void LockAccount(String Username)
        {
            this.repository.LockAccount(Username);
        }
        public void UnLockAccount(String Username)
        {
            this.repository.UnLockAccount(Username);
        }
        public Boolean IsLock(String Username)
        {
            return this.repository.IsLock(Username);
        }
        public void UpdateDefaultTablespace(String Username, String Tablespace)
        {
            this.repository.UpdateDefaultTablespace(Username, Tablespace);
        }
        public void UpdateTemporaryTablespace(String Username, String TmpTablespace)
        {
            this.repository.UpdateTemporaryTablespace(Username, TmpTablespace);
        }
        public void UpdateQuota(String Username, String Quota, String Location)
        {
            this.UpdateQuota(Username, Quota, Location);
        }
    }
}
