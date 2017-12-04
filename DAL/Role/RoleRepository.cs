using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RoleRepository : ClassicRepository, IRoleRepository
    {
        public RoleRepository(DbContext context) : base(context)
        {
        }

        public bool Add(string role)
        {
            try
            {
                this.Execute(role);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataSet ListRole()
        {
            string sql = @"
                    SELECT ROLE FROM  SYS.DBA_ROLES
                    ";
            return this.GetDataSet(sql);
        }

        public bool Remove(string role)
        {
            try
            {
                this.Execute(role);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(string role)
        {
            try
            {
                this.Execute(role);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataSet View()
        {
            string sql = @"
                    SELECT 
                        ROLE, PASSWORD_REQUIRED, AUTHENTICATION_TYPE 
                    FROM  SYS.DBA_ROLES
                    ";
            return this.GetDataSet(sql);
        }

        public DataSet View(string role)
        {
            string sql = @"
                    SELECT 
                        ROLE, PASSWORD_REQUIRED, AUTHENTICATION_TYPE 
                    FROM  SYS.DBA_ROLES
                    WHERE ROLE = :role
                    ";
            Dictionary<string, object> dictionary = new Dictionary<string, object>
            {
                { "role", role }
            };
            return this.GetDataSet(sql, CommandType.Text, dictionary);
        }
    }
}
