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
        public bool GrantObjectPrivilege(string username, string privilege, bool isAdmin)
        {
            throw new NotImplementedException();
        }

        public bool GrantSystemPrivilege(string username, string privilege, bool isAdmin)
        {
            throw new NotImplementedException();
        }

        public bool HaveObjectPrivilege(string username, string privilege, bool isAdmin)
        {
            throw new NotImplementedException();
        }

        public bool HaveSystemPrivilege(string username, string privilege, bool isAdmin)
        {
            throw new NotImplementedException();
        }

        public List<Privilege> ObjectPrivileges(string username)
        {
            throw new NotImplementedException();
        }

        public bool RevokeObjectPrivilege(string username, string privilege)
        {
            throw new NotImplementedException();
        }

        public bool RevokeSystemPrivilege(string username, string privilege)
        {
            throw new NotImplementedException();
        }

        public List<Privilege> SystemPrivileges(string username)
        {
            throw new NotImplementedException();
        }
    }
}

