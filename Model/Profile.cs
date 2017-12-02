using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    //https://docs.oracle.com/cd/B19306_01/server.102/b14200/statements_6010.htm
    public class Profile
    {
        #region resource_parameters
        public string SESSIONS_PER_USER { get; set; }
        public string CPU_PER_SESSION{ get; set; }
        public string CPU_PER_CALL{ get; set; }
        public string CONNECT_TIME{ get; set; }
        public string IDLE_TIME{ get; set; }
        public string LOGICAL_READS_PER_SESSION{ get; set; }
        public string LOGICAL_READS_PER_CALL{ get; set; }
        public string public_SGA{ get; set; }
        public string COMPOSITE_LIMIT{ get; set; }
        #endregion resource_parameters

        #region password_parameters 
        public string FAILED_LOGIN_ATTEMPTS{ get; set; }
        public string PASSWORD_LIFE_TIME{ get; set; }
        public string PASSWORD_REUSE_TIME{ get; set; }
        public string PASSWORD_REUSE_MAX{ get; set; }
        public Double PASSWORD_LOCK_TIME{ get; set; }
        public string PASSWORD_GRACE_TIME{ get; set; }
        public string PASSWORD_VERIFY_FUNCTION{ get; set; }

        #endregion password_parameters 


    }
}
