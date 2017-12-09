using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using System.Data.Entity;
using DAL;
using System.Data;
using Utils;
using System;

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

        public List<Grantee> GranteeSystemPrivileges(string privilege)
        {
            List<Grantee> result = new List<Grantee>();
            DataSet dataSet = this.systemPrivilegeRepository.Grantee(privilege.ToUpper());
            DataTable table = dataSet.Tables[0];
            for (int i = 0; i < table.Rows.Count; i++)
            {
                Grantee p = new Grantee
                {
                    Name = table.Rows[i]["GRANTEE"].ToString(),
                    IsAdmin = BooleanUtils.FromString(table.Rows[i]["ADMIN_OPTION"].ToString())
                };
                result.Add(p);
            }
            return result;
        }

        public List<Grantee> GranteeSystemPrivileges(string privilege, bool isAdmin)
        {
            List<Grantee> result = new List<Grantee>();
            DataSet dataSet = this.systemPrivilegeRepository.Grantee(privilege.ToUpper(), BooleanUtils.FromBoolean(isAdmin));
            DataTable table = dataSet.Tables[0];
            for (int i = 0; i < table.Rows.Count; i++)
            {
                Grantee p = new Grantee
                {
                    Name = table.Rows[i]["GRANTEE"].ToString(),
                    IsAdmin = BooleanUtils.FromString(table.Rows[i]["ADMIN_OPTION"].ToString())
                };
                result.Add(p);
            }
            return result;
        }

        public List<Privilege> ColumnPrivileges(string username)
        {
            throw new NotImplementedException();
        }

        public List<Privilege> ColumnPrivileges()
        {
            throw new NotImplementedException();
        }

        public List<Privilege> ColumnPrivileges(string username, bool isAdmin)
        {
            throw new NotImplementedException();
        }

        public bool GrantColumnPrivilege(string username, Privilege privilege)
        {
            throw new NotImplementedException();
        }

        public bool GrantRolePrivilege(RolePrivilege privilege)
        {
            return this.rolePrivilegeRepository.Execute(privilege.QueryGrant);
        }

        public bool GrantSystemPrivilege(SystemPrivilege privilege)
        {
            return this.systemPrivilegeRepository.Execute(privilege.QueryGrant);
        }

        public bool GrantTablePrivilege(string username, Privilege privilege)
        {
            throw new NotImplementedException();
        }

        public bool HasColumnPrivilege(string username, Privilege privilege)
        {
            throw new NotImplementedException();
        }

        public bool HasRolePrivilege(string username, Privilege privilege)
        {
            DataSet dataSet = this.systemPrivilegeRepository.Has(username.ToUpper(), privilege.Name);
            DataTable table = dataSet.Tables[0];
            if (table.Rows.Count >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool HasSystemPrivilege(string username, Privilege privilege)
        {
            DataSet dataSet = this.systemPrivilegeRepository.Has(username.ToUpper(), privilege.Name);
            DataTable table = dataSet.Tables[0];
            if (table.Rows.Count >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool HasTablePrivilege(string username, Privilege privilege)
        {
            throw new NotImplementedException();
        }

        public bool RevokeColumnPrivilege(string username, Privilege privilege)
        {
            throw new NotImplementedException();
        }

        public bool RevokeRolePrivilege(RolePrivilege privilege)
        {
            return this.rolePrivilegeRepository.Execute(privilege.QueryRevoke);
        }

        public bool RevokeSystemPrivilege(SystemPrivilege privilege)
        {
            return this.systemPrivilegeRepository.Execute(privilege.QueryRevoke);
        }

        public bool RevokeTablePrivilege(string username, Privilege privilege)
        {
            throw new NotImplementedException();
        }

        public List<Privilege> RolePrivileges(string username)
        {
            throw new NotImplementedException();
        }

        public List<Privilege> RolePrivileges(string username, bool isAdmin)
        {
            List<Privilege> result = new List<Privilege>();
            DataSet dataSet = this.rolePrivilegeRepository.View(username.ToUpper(), BooleanUtils.FromBoolean(isAdmin));
            DataTable table = dataSet.Tables[0];
            for (int i = 0; i < table.Rows.Count; i++)
            {
                Privilege privilege = new Privilege
                {
                    Name = table.Rows[i]["GRANTED_ROLE"].ToString(),
                    IsAdmin = BooleanUtils.FromString(table.Rows[i]["ADMIN_OPTION"].ToString())
                };
                result.Add(privilege);
            }
            return result;
        }

        public List<Privilege> RolePrivileges()
        {
            List<Privilege> result = new List<Privilege>();
            DataSet dataSet = this.rolePrivilegeRepository.View();
            DataTable table = dataSet.Tables[0];
            for (int i = 0; i < table.Rows.Count; i++)
            {
                Privilege privilege = new Privilege
                {
                    Name = table.Rows[i]["ROLE"].ToString(),
                    IsAdmin = false
                };
                result.Add(privilege);
            }
            return result;
        }

        public List<Privilege> SystemPrivileges(string username)
        {
            List<Privilege> result = new List<Privilege>();
            DataSet dataSet = this.systemPrivilegeRepository.View(username);
            DataTable table = dataSet.Tables[0];
            for (int i = 0; i < table.Rows.Count; i++)
            {
                Privilege privilege = new Privilege
                {
                    Name = table.Rows[i]["PRIVILEGE"].ToString(),
                    IsAdmin = BooleanUtils.FromString(table.Rows[i]["ADMIN_OPTION"].ToString())
                };
                result.Add(privilege);
            }
            return result;
        }

        public List<Privilege> SystemPrivileges()
        {
            List<Privilege> result = new List<Privilege>();
            DataSet dataSet = this.systemPrivilegeRepository.View();
            DataTable table = dataSet.Tables[0];
            for (int i = 0; i < table.Rows.Count; i++)
            {
                Privilege privilege = new Privilege
                {
                    Name = table.Rows[i]["PRIVILEGE"].ToString(),
                    IsAdmin = BooleanUtils.FromString(table.Rows[i]["ADMIN_OPTION"].ToString())
                };
                result.Add(privilege);
            }
            return result;
        }

        public List<Privilege> SystemPrivileges(string username, bool isAdmin)
        {
            List<Privilege> result = new List<Privilege>();
            DataSet dataSet = this.systemPrivilegeRepository.View(username.ToUpper(), BooleanUtils.FromBoolean(isAdmin));
            DataTable table = dataSet.Tables[0];
            for (int i = 0; i < table.Rows.Count; i++)
            {
                Privilege privilege = new Privilege
                {
                    Name = table.Rows[i]["PRIVILEGE"].ToString(),
                    IsAdmin = BooleanUtils.FromString(table.Rows[i]["ADMIN_OPTION"].ToString())
                };
                result.Add(privilege);
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

        public List<Privilege> TablePrivileges(string username, bool isAdmin)
        {
            throw new NotImplementedException();
        }

        public List<Grantee> GranteeRolePrivileges(string privilege, bool isAdmin)
        {
            throw new NotImplementedException();
        }

        public List<Grantee> GranteeRolePrivileges(string privilege)
        {
            List<Grantee> result = new List<Grantee>();

            DataSet dataSet = this.rolePrivilegeRepository.Grantee(privilege);
            DataTable table = dataSet.Tables[0];
            for (int i = 0; i < table.Rows.Count; i++)
            {
                Grantee p = new Grantee
                {
                    Name = table.Rows[i]["GRANTEE"].ToString(),
                    IsAdmin = BooleanUtils.FromString(table.Rows[i]["ADMIN_OPTION"].ToString())
                };
                result.Add(p);
            }
            return result;
        }

        public List<Grantee> GranteeTablePrivileges(string privilege, bool isAdmin)
        {
            throw new NotImplementedException();
        }

        public List<Grantee> GranteeColumnPrivileges(string privilege, bool isAdmin)
        {
            throw new NotImplementedException();
        }

        
    }
}

