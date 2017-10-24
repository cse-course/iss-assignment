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
            string sql = "";
            return this.GetDataSet(sql);
        }

        public DataSet RolePrivilegeUser()
        {
            string sql = "";
            return this.GetDataSet(sql);
        }

        public DataSet UserDetail()
        {
            string sql = "";
            return this.GetDataSet(sql);
        }

        public DataSet UserPrivilege()
        {
            string sql = "SELECT * FROM sys.dba_sys_privs";
            return this.GetDataSet(sql);
        }

    }
}
