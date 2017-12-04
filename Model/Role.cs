using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Role
    {
        public String Name { get; set; }
        public String Password { get; set; }

        //https://docs.oracle.com/cd/B19306_01/server.102/b14200/statements_6012.htm
        public String QueryAdd { get; set; }
        //https://docs.oracle.com/cd/B14117_01/server.101/b10759/statements_2009.htm#i2227790
        public String QueryUpdate { get; set; }
        //https://docs.oracle.com/cd/B14117_01/server.101/b10759/statements_8026.htm
        public String QueryRemove { get; set; }
    }

    public class RoleBuilder
    {
        private Role role = new Role();

        public RoleBuilder(String name)
        {
            this.role.Name = name;
            this.role.QueryAdd = String.Join(" ", "CREATE ROLE", name);
            this.role.QueryUpdate = String.Join(" ", "ALTER ROLE", name);
            this.role.QueryRemove = String.Join(" ", "DROP ROLE", name);
        }

        public RoleBuilder Password(String password)
        {
            this.role.Password = password;
            this.role.QueryAdd = String.Join(" ", this.role.QueryAdd, "IDENTIFIED BY", password);
            this.role.QueryUpdate = String.Join(" ", this.role.QueryUpdate, "IDENTIFIED BY", password);
            return this;
        }

        public Role Build()
        {
            return this.role;
        }
    }
}
