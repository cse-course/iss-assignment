using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IProfileClassicRepository
    {
        Boolean Add(Profile profile);
        Boolean Update(Profile profile);
        Boolean Remove(Profile profile);

    }
}
