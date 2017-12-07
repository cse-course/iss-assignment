using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RolePrivilegeRepository : ClassicRepository, ISystemPrivilegeRepository
    {
        public RolePrivilegeRepository(DbContext context) : base(context)
        {
        }

        public DataSet Grantee(string privilege, string isAdmin)
        {
            String query = "SELECT * FROM SYS.DBA_ROLE_PRIVS WHERE GRANTED_ROLE = :privilege AND ADMIN_OPTION= :isAdmin";
            Dictionary<string, object> dictionary = new Dictionary<string, object>
            {
                {"privilege" , privilege},
                { "isAdmin", isAdmin }
            };
            return this.GetDataSet(query, CommandType.Text, dictionary);
        }

        public DataSet Has(string grantee, string privilege)
        {
            String query = "SELECT * FROM SYS.DBA_ROLE_PRIVS WHERE GRANTED_ROLE = :privilege AND GRANTEE = :grantee";
            Dictionary<string, object> dictionary = new Dictionary<string, object>
            {
                {"privilege" , privilege},
                { "grantee", grantee }
            };
            return this.GetDataSet(query, CommandType.Text, dictionary);
        }

        public DataSet Has(string grantee, string privilege, string isAdmin)
        {
            String query = "SELECT * FROM SYS.DBA_ROLE_PRIVS WHERE GRANTED_ROLE = :privilege AND GRANTEE = :grantee AND ADMIN_OPTION= :isAdmin";
            Dictionary<string, object> dictionary = new Dictionary<string, object>
            {
                {"privilege" , privilege},
                { "grantee", grantee },
                { "isAdmin", isAdmin }
            };
            return this.GetDataSet(query, CommandType.Text, dictionary);
        }

        public DataSet View()
        {
            String query = "SELECT * FROM SYS.DBA_ROLE_PRIVS";
            return this.GetDataSet(query);
        }

        public DataSet View(string grantee)
        {
            String query = "SELECT * FROM SYS.DBA_ROLE_PRIVS WHERE GRANTEE = :grantee";
            Dictionary<string, object> dictionary = new Dictionary<string, object>
            {
                { "grantee", grantee }
            };
            return this.GetDataSet(query, CommandType.Text, dictionary);
        }

        public DataSet View(string grantee, string isAdmin)
        {
            String query = "SELECT * FROM SYS.DBA_ROLE_PRIVS WHERE GRANTEE = :grantee AND ADMIN_OPTION= :isAdmin";
            Dictionary<string, object> dictionary = new Dictionary<string, object>
            {
                { "grantee", grantee },
                { "isAdmin", isAdmin }
            };
            return this.GetDataSet(query, CommandType.Text, dictionary);
        }

        bool ISystemPrivilegeRepository.Execute(string query)
        {
            try
            {
                this.Execute(query);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
