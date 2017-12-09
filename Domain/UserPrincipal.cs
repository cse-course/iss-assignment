using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class UserPrincipal
    {
        private String userName;

        private Boolean isAdmin;

        public UserPrincipal()
        {
            this.isAdmin = false;
            this.userName = "";
        }

        public string UserName { get => userName; set => userName = value; }
        public bool IsAdmin { get => isAdmin; set => isAdmin = value; }

        public Boolean IsLogin()
        {
            if (userName != null && userName.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
