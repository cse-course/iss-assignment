using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SystemPrivilegeRepository : ClassicRepository, ISystemPrivilegeRepository
    {
        public SystemPrivilegeRepository(DbContext context) : base(context)
        {
        }

        public DataSet View()
        {
            String query = @"SELECT * FROM SYS.DBA_SYS_PRIVS";
            return this.GetDataSet(query);
        }

        public DataSet View(string grantee)
        {
            String query = @"SELECT * FROM SYS.DBA_SYS_PRIVS WHERE GRANTEE = :grantee";
            Dictionary<string, object> dictionary = new Dictionary<string, object>
            {
                { "grantee", grantee }
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
