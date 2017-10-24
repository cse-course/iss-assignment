using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public sealed class SysViewRepository : ClassicRepository, ISysViewRepository
    {
        public SysViewRepository(DbContext context) : base(context)
        {
        }

        public DataSet ProfileResourceUser()
        {
            string sql = @"
                    SELECT 
                        PROFILE, RESOURCE_NAME, USERNAME 
                    FROM SYS.DBA_PROFILES P 
                    LEFT OUTER JOIN SYS.DBA_USERS U USING (PROFILE)
                    ";
            return this.GetDataSet(sql);
        }

        public DataSet RolePrivilegeUser()
        {
            string sql = @"
                        SELECT 
                            ROLE, PRIVILEGE, GRANTEE 
                        FROM SYS.ROLE_SYS_PRIVS S 
                        LEFT OUTER JOIN SYS.DBA_ROLE_PRIVS R ON S.ROLE = R.GRANTED_ROLE
                        ";
            return this.GetDataSet(sql);
        }

        public DataSet UserDetail()
        {
            string sql = @"
                    SELECT 
                        U.USERNAME, U.ACCOUNT_STATUS, U.LOCK_DATE, U.CREATED, U.DEFAULT_TABLESPACE, U.TEMPORARY_TABLESPACE, U.PROFILE
                        ,P.GRANTEE, P.PRIVILEGE, P.ADMIN_OPTION
                        , R.GRANTEE AS GRANTEE_ROLE, R.GRANTED_ROLE, R.ADMIN_OPTION AS ADMIN_OPTION_ROLE
                    FROM SYS.DBA_USERS U 
                    FULL OUTER JOIN SYS.DBA_SYS_PRIVS P ON U.USERNAME = P.GRANTEE
                    FULL OUTER JOIN SYS.DBA_ROLE_PRIVS R ON U.USERNAME = R.GRANTEE
                    ";
            return this.GetDataSet(sql);
        }

        public DataSet UserPrivilege()
        {
            string sql = "SELECT * FROM SYS.DBA_SYS_PRIVS";
            return this.GetDataSet(sql);
        }

    }
}
