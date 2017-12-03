using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public sealed class UserManagementClassicRepository : ClassicRepository
    {
        public UserManagementClassicRepository(DbContext context) : base(context)
        {
        }
        public void AddOracleUser(String Username, String Password)
        {
            //string sql = "CREATE USER " + "c##" + Username + " IDENTIFIED BY " + Password + ";";
            string sql = "CREATE USER aabbbbbbbbb IDENTIFIED BY aaaaaaaaaaaaa;";
            Console.WriteLine(sql);
        }
    }
}
