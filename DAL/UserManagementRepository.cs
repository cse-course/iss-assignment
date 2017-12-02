using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserManagementRepository : Repository<USER_MANAGEMENT, string>
    {
        public UserManagementRepository(DbContext context) : base(context)
        {
        }
    }
}
