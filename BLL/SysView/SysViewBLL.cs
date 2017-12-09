using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class SysViewBLL
    {
        private readonly ISysViewRepository repository;

        public SysViewBLL(DbContext context)
        {
            this.repository = new SysViewRepository(context);
        }

        public DataSet UserPrivilege()
        {
            return this.repository.UserPrivilege();
        }

        public DataSet RolePrivilegeUser()
        {
            return this.repository.RolePrivilegeUser();
        }

        public DataSet ProfileResourceUser()
        {
            return this.repository.ProfileResourceUser();
        }

        public DataSet UserDetail()
        {
            return this.repository.UserDetail();
        }

        public DataSet UserDetail(String username)
        {
            return this.repository.UserDetail(username);
        }
    }
}
