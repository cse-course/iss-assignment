using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
using System.Data.Entity;
using System.Data;

namespace BLL
{
    public class RoleBLL : IRoleBLL
    {
        private IRoleRepository repository;

        public RoleBLL(DbContext context)
        {
            this.repository = new RoleRepository(context);
        }

        public Boolean Add(Role role)
        {
            return this.repository.Add(role.QueryAdd);
        }

        public List<String> ListRole()
        {
            List<String> result = new List<string>();
            DataSet dataSet = this.repository.ListRole();
            DataTable table = dataSet.Tables[0];
            for (int i = 0; i < table.Rows.Count; i++)
            {
                result.Add(table.Rows[i][0].ToString());
            }
            return result;
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
            throw new NotImplementedException();
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
