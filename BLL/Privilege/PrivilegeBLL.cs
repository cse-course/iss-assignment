using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace BLL
{
    public class PrivilegeBLL : IPrivilegeBLL
    {
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
            throw new NotImplementedException();
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

