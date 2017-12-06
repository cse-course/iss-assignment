using System;
using System.Collections.Generic;
using DAL;
using System.Data.Entity;
using System.Data;
using Domain;

namespace BLL
{
    public class ProfileBLL : IProfileBLL
    {
        private IProfileClassicRepository repository;

        public ProfileBLL(DbContext context)
        {
            this.repository = new ProfileClassicRepository(context);
        }

        public Profile Add(Profile profile)
        {
            this.repository.Add(profile.QueryAdd);
            return profile;
        }

     
        public bool Remove(Profile profile)
        {
            return this.repository.Remove(profile.QueryRemove);
        }

        public bool RemoveCascade(Profile profile)
        {
            return this.repository.Remove(profile.QueryRemoveCascade);
        }

        public Profile Update(Profile profile)
        {
            this.repository.Update(profile.QueryUpdate);
            return profile;
        }
        public List<Profile> View()
        {
            throw new NotImplementedException();
        }

        public Profile View(string profile)
        { 
            

            DataSet dataSet = this.repository.View(profile);
            DataTable table = dataSet.Tables[0];
            Dictionary<String, String> data = new Dictionary<string, string>();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                //table.Rows[i][0] RESOURCE_NAME
                //table.Rows[i][1] LIMIT
                data.Add(table.Rows[i][0].ToString(), table.Rows[i][1].ToString());
            }
            Profile result = ProfileMapper.Map(data);
            result.Name = profile;

            return result;
        }

        public List<String> ListProfile()
        {
            List<String> result = new List<string>();
            DataSet dataSet = this.repository.ListProfile();
            DataTable table = dataSet.Tables[0] ;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                result.Add(table.Rows[i][0].ToString());
            }
            return result;
        }

    }
}
