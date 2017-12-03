using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
using System.Data.Entity;

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
            this.repository.Add(profile);
            return profile;
        }

        public bool Remove(Profile profile)
        {
            return this.repository.Remove(profile);
        }

        public Profile Update(Profile profile)
        {
            this.repository.Update(profile);
            return profile;
        }
    }
}
