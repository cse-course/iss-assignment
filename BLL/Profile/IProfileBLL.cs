using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IProfileBLL
    {
        Profile Add(Profile profile);

        Profile Update(Profile profile);

        Boolean Remove(Profile proile);
        
    }
}
