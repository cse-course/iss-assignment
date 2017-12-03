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
        public string SessionsPerUser { get; set; }
        public string CPUPerSession { get; set; }
        public string CPUPerCall { get; set; }
        public string ConnectTime { get; set; }
        public string IdleTime { get; set; }
        public string LogicalReadsPerSession { get; set; }
        public string LogicalReadsPerCall{ get; set; }
        public string PrivateSGA { get; set; }
        public string CompositeLimit{ get; set; }
        #endregion resource_parameters

        #region password_parameters 
        public string FailedLoginAttemps{ get; set; }
        public string PasswordLifeTime{ get; set; }
        public string PasswordReuseTime{ get; set; }
        public string PasswordReuseMax{ get; set; }
        public string PasswordLockTime { get; set; }
        public string PasswordGraceTime{ get; set; }
        public string PasswordVerifyFunction{ get; set; }
        #endregion password_parameters 

        public String Query { get; set; }
        
        public String Name { get; set; }
    }

    public class ProfileBuilder
    {
        private Profile profile = new Profile();

        public ProfileBuilder(String name)
        {
            this.profile.Name = name;
            this.profile.Query = String.Join(" ", "CREATE PROFILE", name, "LIMIT");
        }

        private Profile Build()
        {
            return this.profile;
        }

        #region resource_parameters
        public void SessionsPerUser(String value)
        {
            this.profile.SessionsPerUser = value;
            this.profile.Query = String.Join(" ", this.profile.Query, ProfileType.SESSIONS_PER_USER, value);
        }
        public void CPUPerSession(String value)
        {
            this.profile.CPUPerSession = value;
            this.profile.Query = String.Join(" ", this.profile.Query, ProfileType.CPU_PER_SESSION, value);
        }
        public void CPUPerCall(String value)
        {
            this.profile.CPUPerCall = value;
            this.profile.Query = String.Join(" ", this.profile.Query, ProfileType.CPU_PER_CALL, value);
        }
        public void ConnectTime(String value)
        {
            this.profile.ConnectTime = value;
            this.profile.Query = String.Join(" ", this.profile.Query, ProfileType.CONNECT_TIME, value);
        }
        public void IdleTime(String value)
        {
            this.profile.IdleTime = value;
            this.profile.Query = String.Join(" ", this.profile.Query, ProfileType.IDLE_TIME, value);
        }
        public void LogicalReadsPerSession(String value)
        {
            this.profile.LogicalReadsPerSession = value;
            this.profile.Query = String.Join(" ", this.profile.Query, ProfileType.LOGICAL_READS_PER_SESSION, value);
        }
        public void LogicalReadsPerCall(String value)
        {
            this.profile.LogicalReadsPerCall = value;
            this.profile.Query = String.Join(" ", this.profile.Query, ProfileType.LOGICAL_READS_PER_CALL, value);
        }
        public void PrivateSGA(String value)
        {
            this.profile.PrivateSGA = value;
            this.profile.Query = String.Join(" ", this.profile.Query, ProfileType.PRIVATE_SGA, value);
        }
        public void CompositeLimit(String value)
        {
            this.profile.CompositeLimit = value;
            this.profile.Query = String.Join(" ", this.profile.Query, ProfileType.COMPOSITE_LIMIT, value);
        }
        #endregion resource_parameters

        #region password_parameters 
        public void FailedLoginAttemps(String value)
        {
            this.profile.FailedLoginAttemps = value;
            this.profile.Query = String.Join(" ", this.profile.Query, ProfileType.FAILED_LOGIN_ATTEMPTS, value);
        }
        public void PasswordLifeTime(String value)
        {
            this.profile.PasswordLifeTime = value;
            this.profile.Query = String.Join(" ", this.profile.Query, ProfileType.PASSWORD_LIFE_TIME, value);
        }
        public void PasswordReuseTime(String value)
        {
            this.profile.PasswordReuseTime = value;
            this.profile.Query = String.Join(" ", this.profile.Query, ProfileType.PASSWORD_REUSE_TIME, value);
        }
        public void PasswordReuseMax(String value)
        {
            this.profile.PasswordReuseMax = value;
            this.profile.Query = String.Join(" ", this.profile.Query, ProfileType.PASSWORD_REUSE_MAX, value);
        }
        public void PasswordLockTime(String value)
        {
            this.profile.PasswordLockTime = value;
            this.profile.Query = String.Join(" ", this.profile.Query, ProfileType.PASSWORD_LOCK_TIME, value);
        }
        public void PasswordGraceTime(String value)
        {
            this.profile.PasswordGraceTime = value;
            this.profile.Query = String.Join(" ", this.profile.Query, ProfileType.PASSWORD_GRACE_TIME, value);
        }
        public void PasswordVerifyFunction(String value)
        {
            this.profile.PasswordVerifyFunction = value;
            this.profile.Query = String.Join(" ", this.profile.Query, ProfileType.PASSWORD_VERIFY_FUNCTION, value);
        }
        #endregion password_parameters 
    }

    public class ProfileType
    {
        #region resource_parameters
        public static string SESSIONS_PER_USER = "SESSIONS_PER_USER";
        public static string CPU_PER_SESSION = "CPU_PER_SESSION";
        public static string CPU_PER_CALL = "CPU_PER_CALL";
        public static string CONNECT_TIME = "CONNECT_TIME";
        public static string IDLE_TIME = "IDLE_TIME";
        public static string LOGICAL_READS_PER_SESSION = "LOGICAL_READS_PER_SESSION";
        public static string LOGICAL_READS_PER_CALL = "LOGICAL_READS_PER_CALL";
        public static string PRIVATE_SGA = "PRIVATE_SGA";
        public static string COMPOSITE_LIMIT = "COMPOSITE_LIMIT";
        #endregion resource_parameters

        #region password_parameters 
        public static string FAILED_LOGIN_ATTEMPTS = "FAILED_LOGIN_ATTEMPTS";
        public static string PASSWORD_LIFE_TIME = "PASSWORD_LIFE_TIME";
        public static string PASSWORD_REUSE_TIME = "PASSWORD_REUSE_TIME";
        public static string PASSWORD_REUSE_MAX = "PASSWORD_REUSE_MAX";
        public static string PASSWORD_LOCK_TIME = "PASSWORD_LOCK_TIME";
        public static string PASSWORD_GRACE_TIME = "PASSWORD_GRACE_TIME";
        public static string PASSWORD_VERIFY_FUNCTION = "PASSWORD_VERIFY_FUNCTION";
        #endregion password_parameters
    }
}
