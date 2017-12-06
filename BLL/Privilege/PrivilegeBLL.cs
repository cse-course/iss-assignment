using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using System.Data.Entity;
using DAL;
using System.Data;

namespace BLL
{
    public class PrivilegeBLL : IPrivilegeBLL
    {
        private DbContext context;

        private ISystemPrivilegeRepository systemPrivilegeRepository;

        private ISystemPrivilegeRepository rolePrivilegeRepository;
        public PrivilegeBLL(DbContext context)
        {
            this.context = context;
            this.systemPrivilegeRepository = new SystemPrivilegeRepository(this.context);
            this.rolePrivilegeRepository = new RolePrivilegeRepository(this.context);
        }
        public List<Privilege> ColumnPrivileges(string username)
        {
            throw new NotImplementedException();
        }

        public List<Privilege> ColumnPrivileges()
        {
            throw new NotImplementedException();
        }

        public bool GrantColumnPrivilege(string username, Privilege privilege)
        {
            throw new NotImplementedException();
        }

        public bool GrantSystemPrivilege(string username, Privilege privilege)
        {
            throw new NotImplementedException();
        }

        public bool GrantTablePrivilege(string username, Privilege privilege)
        {
            throw new NotImplementedException();
        }

        public bool HasColumnPrivilege(string username, Privilege privilege)
        {
            throw new NotImplementedException();
        }

        public bool HasSystemPrivilege(string username, Privilege privilege)
        {
            throw new NotImplementedException();
        }

        public bool HasTablePrivilege(string username, Privilege privilege)
        {
            throw new NotImplementedException();
        }

        public bool RevokeColumnPrivilege(string username, Privilege privilege)
        {
            throw new NotImplementedException();
        }

        public bool RevokeSystemPrivilege(string username, Privilege privilege)
        {
            throw new NotImplementedException();
        }

        public bool RevokeTablePrivilege(string username, Privilege privilege)
        {
            throw new NotImplementedException();
        }

        public List<Privilege> SystemPrivileges(string username)
        {
            throw new NotImplementedException();
        }

        public List<Privilege> SystemPrivileges()
        {
            List<Privilege> result = new List<Privilege>();
            DataSet dataSet = this.systemPrivilegeRepository.View();
            DataTable table = dataSet.Tables[0];
            for (int i = 0; i < table.Rows.Count; i++)
            {
                //table.Rows[i][0] RESOURCE_NAME
                //table.Rows[i][1] LIMIT
                Privilege privilege = new Privilege();
                privilege.Name = table.Rows[i]["PRIVILEGE"].ToString();
                //table.Rows[i]["ADMIN_OPTION"];

            }
            return result;
        }

        public List<Privilege> TablePrivileges(string username)
        {
            throw new NotImplementedException();
        }

        public List<Privilege> TablePrivileges()
        {
            throw new NotImplementedException();
        }
    }
}

