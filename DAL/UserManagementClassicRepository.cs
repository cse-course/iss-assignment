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
    }
}
