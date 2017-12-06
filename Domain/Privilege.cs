using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    //https://docs.oracle.com/cd/B19306_01/server.102/b14200/statements_9013.htm
    public class Privilege
    {
        public string Name {get; set;}
        public Boolean isAdmin { get; set; }
        
    }

    public class SystemPrivilegeBuilder
    {
        private String query;

        private List<String> privilege;

        private GranteeClauseBuilder grantee;

        private Boolean isAdmin;

        public SystemPrivilegeBuilder()
        {
            this.query = "GRANT";
            this.isAdmin = false;
        }

        public SystemPrivilegeBuilder Privilege(List<String> privilege)
        {
            this.privilege = privilege;
            return this;
        }

        public SystemPrivilegeBuilder Grantee(GranteeClauseBuilder grantee)
        {
            this.grantee = grantee;
            return this;
        }

        public SystemPrivilegeBuilder AdminOption(Boolean isAdmin)
        {
            this.isAdmin = isAdmin;
            return this;
        }

        public String Build()
        {
            return String.Join(" ", 
                this.query, 
                string.Join(",", this.privilege), 
                "TO", 
                this.grantee.Build(),
                isAdmin ? "WITH ADMIN OPTION" : ""
                );
        }

    }

    public class ObjectPrivilege
    {
        private String query;

        private List<String> privilege;

        private ObjectClauseBuilder objectClauses;

        private GranteeClauseBuilder grantee;

        private Boolean isAdmin;

        private Boolean isHierarchy;

        public ObjectPrivilege()
        {
            this.query = "GRANT";
            this.isAdmin = false;
            this.isHierarchy = false;
        }

        public ObjectPrivilege Privilege(List<String> privilege)
        {
            this.privilege = privilege;
            return this;
        }

        public ObjectPrivilege ObjectClauses(ObjectClauseBuilder objectClauses)
        {
            this.objectClauses = objectClauses;
            return this;
        }

        public ObjectPrivilege Grantee(GranteeClauseBuilder grantee)
        {
            this.grantee = grantee;
            return this;
        }

        public ObjectPrivilege AdminOption(Boolean isAdmin)
        {
            this.isAdmin = isAdmin;
            return this;
        }

        public ObjectPrivilege HierarchyOption(Boolean isHierarchy)
        {
            this.isHierarchy = isHierarchy;
            return this;
        }


        public String Build()
        {
            return String.Join(" ",
                this.query,
                string.Join(",", this.privilege),
                this.objectClauses.Build(),
                "TO",
                this.grantee.Build(),
                this.isAdmin ? "WITH ADMIN OPTION" : "",
                this.isHierarchy ? "WITH HIERARCHY OPTION" : ""
                );
        }
    }

    //Current only support Grant on Schema.Object
    public class ObjectClauseBuilder
    {
        private String schema;

        private String objectName;

        public ObjectClauseBuilder()
        {
        }

        public ObjectClauseBuilder Schema(String shema)
        {
            this.schema = shema;
            return this;
        }

        public ObjectClauseBuilder ObjectName(String objectName)
        {
            this.objectName = objectName;
            return this;
        }


        public String Build()
        {
            return String.Join(" ",
                "ON",
                 String.Join(".", this.schema, this.objectName)
                );
        }

    }

    public class GranteeClauseBuilder
    {
        private String grantee;

        private String password;

        public GranteeClauseBuilder()
        {
        }

        public GranteeClauseBuilder Grantee(String grantee)
        {
            this.grantee = grantee;
            return this;
        }

        //Grantee = User may be have password
        public GranteeClauseBuilder Password(String password)
        {
            this.password = password;
            return this;
        }


        public String Build()
        {
            return String.Join(" ",
                this.grantee,
                this.password != null ? String.Join(" ", "IDENTIFIED BY", this.password) : ""
                );
        }
    }
}
