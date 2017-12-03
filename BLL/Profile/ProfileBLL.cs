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

        public Profile Update(Profile profile)
        {
            this.repository.Update(profile.QueryUpdate);
            return profile;
        }

        public DataSet View()
        {
            return this.repository.View();
        }

        public DataSet View(string profile)
        {
            return this.repository.View(profile);
        }
    }
}
