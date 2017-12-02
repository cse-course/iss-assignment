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
    public class UserManagementBLL
    {
        private UserManagementRepository repository;

        public UserManagementBLL(DbContext context)
        {
            this.repository = new UserManagementRepository(context);
        }
        public IEnumerable<USER_MANAGEMENT> GetAll()
        {
            return repository.GetAll();
        }
        public IEnumerable<USER_MANAGEMENT> GetUserInfo(String Username)
        {
            return this.repository.Find(u => u.USERNAME.Equals(Username));
        }
        public void Update(USER_MANAGEMENT user)
        {
            this.repository.Update(user);
        }
        public void Add(USER_MANAGEMENT user)
        {
            this.repository.Add(user);
        }
        public void Remove(USER_MANAGEMENT user)
        {
            this.repository.Remove(user);
        }
    }
}
