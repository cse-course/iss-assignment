using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DAL
{
    public sealed class UserManagementClassicRepository : ClassicRepository
    {
        public UserManagementClassicRepository(DbContext context) : base(context)
        {
        }
        public void AddOracleUser(String Username, String Password)
        {
            string sql = "CREATE USER "+ Username + " IDENTIFIED BY " + Password;
            this.Execute(sql);
        }
        public void DropOracleUser(String Username)
        {
            Username = Username.ToUpper();
            string sql = "drop user " + Username;
            this.Execute(sql);
        }
        public DataSet DistinctProfileName()
        {
            string sql = "select Distinct DBA_PROFILES.profile from DBA_PROFILES";
            return this.GetDataSet(sql);
        }
        public DataSet DistinctRoleName()
        {
            string sql = "SELECT Distinct DBA_ROLES.ROLE FROM DBA_ROLES";
            return this.GetDataSet(sql);
        }
        public DataSet DistinctTablespaceName()
        {
            string sql = @"SELECT dd.tablespace_name tablespace_name
                            FROM sys.dba_free_space fs, sys.dba_data_files dd
                            WHERE dd.tablespace_name = fs.tablespace_name
                            AND dd.file_id = fs.file_id
                            GROUP BY dd.tablespace_name
                            ORDER BY dd.tablespace_name
                           ";
            return this.GetDataSet(sql);
        }
        public DataSet GetGrantedRoleToUser(string Userneme)
        {
            Userneme = Userneme.ToUpper();
            string sql = "SELECT Granted_Role From Dba_Role_Privs WHERE GRANTEE = '" + Userneme + "'";
            Debug.WriteLine(sql);
            return this.GetDataSet(sql);
        }
        public DataSet GetGrantedProfileToUser(string Username)
        {
            Username = Username.ToUpper();
            string sql = "SELECT Distinct PROFILE, USERNAME FROM DBA_PROFILES P LEFT OUTER JOIN DBA_USERS U USING(PROFILE) WHERE USERNAME = '" + Username + "'";
            Debug.WriteLine(sql);
            return this.GetDataSet(sql);
        }
        public void AddRoleToUser(String Username, String Role)
        {
            string sql = "GRANT " + Role + " TO " + Username;
            this.Execute(sql);
        }
        public void RemoveRoleFromUser(String Username, String Role)
        {
            string sql = "REVOKE " + Role + " FROM " + Username;
            this.Execute(sql);
        }

        public void AddProfileToUser(String Username, String Profile)
        {
            string sql = "ALTER USER " + Username + " PROFILE " + Profile;
            this.Execute(sql);
        }
        public void RemoveProfileFromUser(String Username, String Profile)
        {
            string sql = "ALTER USER " + Username + " PROFILE " + "Default";
            this.Execute(sql);
        }
        public void LockAccount(String Username)
        {
            Username = Username.ToUpper();
            string sql = "ALTER USER " + Username + " ACCOUNT LOCK";
            this.Execute(sql);
        }
        public void UnLockAccount(String Username)
        {
            Username = Username.ToUpper();
            string sql = "ALTER USER " + Username + " ACCOUNT UNLOCK";
            this.Execute(sql);
        }
        public Boolean IsLock(String Username)
        {
            Username = Username.ToUpper();
            string sql = "Select 1 From Dba_Users Where username = '" + Username + "' AND Account_Status = 'OPEN'";
            DataSet ds = this.GetDataSet(sql);
            if (ds.Tables[0].Rows.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
