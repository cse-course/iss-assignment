using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class BooleanUtils
    {
        public static Boolean FromString(String name)
        {
            if ("YES".Equals(name.ToUpper()) || "TRUE".Equals(name.ToUpper()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
