﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class UserManagermentBLL
    {
        private UserManagementRepository user;

        public UserManagermentBLL(DbContext context)
        {
            this.user = new UserManagementRepository(context);
        }
        public IEnumerable<USER_MANAGEMENT> GetAll()
        {
            return user.GetAll();
        }
    }
}
