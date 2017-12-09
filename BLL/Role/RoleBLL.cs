using System;
using System.Collections.Generic;
using DAL;
using System.Data.Entity;
using System.Data;
using Domain;
using Utils;

namespace BLL
{
    public class RoleBLL : IRoleBLL
    {
        private IRoleRepository repository;

        private ISystemPrivilegeRepository rolePrivilegeRepository;

        public RoleBLL(DbContext context)
        {
            this.repository = new RoleRepository(context);
            this.rolePrivilegeRepository = new RolePrivilegeRepository(context);
        }

        public Boolean Add(Role role)
        {
            return this.repository.Add(role.QueryAdd);
        }

        public bool Remove(Role role)
        {
            return this.repository.Remove(role.QueryRemove);
        }

        public Boolean Update(Role role)
        {
            return this.repository.Update(role.QueryUpdate);
        }

        public List<Role> View()
        {
            List<Role> result = new List<Role>();
            DataSet dataSet = this.repository.View();
            DataTable table = dataSet.Tables[0];
            for (int i = 0; i < table.Rows.Count; i++)
            {
                Role role = new Role
                {
                    Name = table.Rows[i]["ROLE"].ToString()
                };
                result.Add(role);
            }

                return result;
        }

        public Role View(string role)
        {
            DataSet dataSet = this.repository.View(role);
            DataTable table = dataSet.Tables[0];
            if (table.Rows.Count == 1)
            {
                DataRow row = table.Rows[0];
                Role result = new Role
                {
                    Name = row[0].ToString(),
                    Password = row[1].ToString()
                };
                return result;
            }
            else
            {
                return null;
            }
        }
    }
}
