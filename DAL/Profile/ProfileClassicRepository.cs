using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class ProfileClassicRepository : ClassicRepository, IProfileClassicRepository
    {
        public ProfileClassicRepository(DbContext context) : base(context)
        {
        }

        public bool Add(Profile profile)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Profile profile)
        {
            throw new NotImplementedException();
        }

        public bool Update(Profile profile)
        {
            throw new NotImplementedException();
        }
    }
}
