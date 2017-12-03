using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;

namespace DAL
{
    public class ProfileClassicRepository : ClassicRepository, IProfileClassicRepository
    {
        public ProfileClassicRepository(DbContext context) : base(context)
        {
        }

        public bool Add(String profile)
        {
            try
            {
                this.Execute(profile);
                return true;
            }
            catch 
            {
                return false;
            }
        }


        public bool Remove(String profile)
        {
            try
            {
                this.Execute(profile);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(String profile)
        {
            try
            {
                this.Execute(profile);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataSet View()
        {
            string sql = @"
                    SELECT 
                        PROFILE, RESOURCE_NAME, LIMIT 
                    FROM SYS.DBA_PROFILES 
                    ";
            return this.GetDataSet(sql);
        }

        public DataSet View(string profile)
        {
            string sql = @"
                    SELECT 
                        RESOURCE_NAME , LIMIT
                    FROM SYS.DBA_PROFILES 
                    WHERE PROFILE = :profile
                    ";
            Dictionary<string, object> dictionary = new Dictionary<string, object>
            {
                { "profile", profile }
            };
            return this.GetDataSet(sql, CommandType.Text, dictionary);
        }


        public DataSet ListProfile()
        {
            string sql = @"
                    SELECT 
                        DISTINCT PROFILE
                    FROM SYS.DBA_PROFILES 
                    ";
            return this.GetDataSet(sql);
        }
    }
}
