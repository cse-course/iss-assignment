using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
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

        public String QueryAdd { get; set; }
        public String QueryUpdate { get; set; }
        public String QueryRemove { get; set; }
        public String QueryRemoveCascade { get; set; }


        public String Name { get; set; }
    }

    public class ProfileBuilder
    {
        private Profile profile = new Profile();

        public ProfileBuilder(String name)
        {
            this.profile.Name = name;
            this.profile.QueryAdd = String.Join(" ", "CREATE PROFILE", name, "LIMIT");
            this.profile.QueryUpdate = String.Join(" ", "ALTER PROFILE", name, "LIMIT");
            this.profile.QueryRemove = String.Join(" ", "DROP PROFILE", name);
            this.profile.QueryRemoveCascade = String.Join(" ", "DROP PROFILE", name, "CASCADE");

        }

        public Profile Build()
        {
            return this.profile;
        }

        #region resource_parameters
        public ProfileBuilder SessionsPerUser(String value)
        {
            this.profile.SessionsPerUser = value;
            this.profile.QueryAdd = String.Join(" ", this.profile.QueryAdd, ProfileType.SESSIONS_PER_USER, value);
            this.profile.QueryUpdate = String.Join(" ", this.profile.QueryUpdate, ProfileType.SESSIONS_PER_USER, value);

            return this;
        }
        public ProfileBuilder CPUPerSession(String value)
        {
            this.profile.CPUPerSession = value;
            this.profile.QueryAdd = String.Join(" ", this.profile.QueryAdd, ProfileType.CPU_PER_SESSION, value);
            this.profile.QueryUpdate = String.Join(" ", this.profile.QueryUpdate, ProfileType.CPU_PER_SESSION, value);

            return this;
        }
        public ProfileBuilder CPUPerCall(String value)
        {
            this.profile.CPUPerCall = value;
            this.profile.QueryAdd = String.Join(" ", this.profile.QueryAdd, ProfileType.CPU_PER_CALL, value);
            this.profile.QueryUpdate = String.Join(" ", this.profile.QueryUpdate, ProfileType.CPU_PER_CALL, value);

            return this;
        }
        public ProfileBuilder ConnectTime(String value)
        {
            this.profile.ConnectTime = value;
            this.profile.QueryAdd = String.Join(" ", this.profile.QueryAdd, ProfileType.CONNECT_TIME, value);
            this.profile.QueryUpdate = String.Join(" ", this.profile.QueryUpdate, ProfileType.CONNECT_TIME, value);

            return this;
        }
        public ProfileBuilder IdleTime(String value)
        {
            this.profile.IdleTime = value;
            this.profile.QueryAdd = String.Join(" ", this.profile.QueryAdd, ProfileType.IDLE_TIME, value);
            this.profile.QueryUpdate = String.Join(" ", this.profile.QueryUpdate, ProfileType.IDLE_TIME, value);

            return this;
        }
        public ProfileBuilder LogicalReadsPerSession(String value)
        {
            this.profile.LogicalReadsPerSession = value;
            this.profile.QueryAdd = String.Join(" ", this.profile.QueryAdd, ProfileType.LOGICAL_READS_PER_SESSION, value);
            this.profile.QueryUpdate = String.Join(" ", this.profile.QueryUpdate, ProfileType.LOGICAL_READS_PER_SESSION, value);
            return this;
        }
        public ProfileBuilder LogicalReadsPerCall(String value)
        {
            this.profile.LogicalReadsPerCall = value;
            this.profile.QueryAdd = String.Join(" ", this.profile.QueryAdd, ProfileType.LOGICAL_READS_PER_CALL, value);
            this.profile.QueryUpdate = String.Join(" ", this.profile.QueryUpdate, ProfileType.LOGICAL_READS_PER_CALL, value);
            return this;
        }
        public ProfileBuilder PrivateSGA(String value)
        {
            this.profile.PrivateSGA = value;
            this.profile.QueryAdd = String.Join(" ", this.profile.QueryAdd, ProfileType.PRIVATE_SGA, value);
            this.profile.QueryUpdate = String.Join(" ", this.profile.QueryUpdate, ProfileType.PRIVATE_SGA, value);
            return this;
        }
        public ProfileBuilder CompositeLimit(String value)
        {
            this.profile.CompositeLimit = value;
            this.profile.QueryAdd = String.Join(" ", this.profile.QueryAdd, ProfileType.COMPOSITE_LIMIT, value);
            this.profile.QueryUpdate = String.Join(" ", this.profile.QueryUpdate, ProfileType.COMPOSITE_LIMIT, value);
            return this;
        }
        #endregion resource_parameters

        #region password_parameters 
        public ProfileBuilder FailedLoginAttemps(String value)
        {
            this.profile.FailedLoginAttemps = value;
            this.profile.QueryAdd = String.Join(" ", this.profile.QueryAdd, ProfileType.FAILED_LOGIN_ATTEMPTS, value);
            this.profile.QueryUpdate = String.Join(" ", this.profile.QueryUpdate, ProfileType.FAILED_LOGIN_ATTEMPTS, value);
            return this;
        }
        public ProfileBuilder PasswordLifeTime(String value)
        {
            this.profile.PasswordLifeTime = value;
            this.profile.QueryAdd = String.Join(" ", this.profile.QueryAdd, ProfileType.PASSWORD_LIFE_TIME, value);
            this.profile.QueryUpdate = String.Join(" ", this.profile.QueryUpdate, ProfileType.PASSWORD_LIFE_TIME, value);
            return this;
        }
        public ProfileBuilder PasswordReuseTime(String value)
        {
            this.profile.PasswordReuseTime = value;
            this.profile.QueryAdd = String.Join(" ", this.profile.QueryAdd, ProfileType.PASSWORD_REUSE_TIME, value);
            this.profile.QueryUpdate = String.Join(" ", this.profile.QueryUpdate, ProfileType.PASSWORD_REUSE_TIME, value);
            return this;
        }
        public ProfileBuilder PasswordReuseMax(String value)
        {
            this.profile.PasswordReuseMax = value;
            this.profile.QueryAdd = String.Join(" ", this.profile.QueryAdd, ProfileType.PASSWORD_REUSE_MAX, value);
            this.profile.QueryUpdate = String.Join(" ", this.profile.QueryUpdate, ProfileType.PASSWORD_REUSE_MAX, value);
            return this;
        }
        public ProfileBuilder PasswordLockTime(String value)
        {
            this.profile.PasswordLockTime = value;
            this.profile.QueryAdd = String.Join(" ", this.profile.QueryAdd, ProfileType.PASSWORD_LOCK_TIME, value);
            this.profile.QueryUpdate = String.Join(" ", this.profile.QueryUpdate, ProfileType.PASSWORD_LOCK_TIME, value);
            return this;
        }
        public ProfileBuilder PasswordGraceTime(String value)
        {
            this.profile.PasswordGraceTime = value;
            this.profile.QueryAdd = String.Join(" ", this.profile.QueryAdd, ProfileType.PASSWORD_GRACE_TIME, value);
            this.profile.QueryUpdate = String.Join(" ", this.profile.QueryUpdate, ProfileType.PASSWORD_GRACE_TIME, value);
            return this;
        }
        public ProfileBuilder PasswordVerifyFunction(String value)
        {
            this.profile.PasswordVerifyFunction = value;
            this.profile.QueryAdd = String.Join(" ", this.profile.QueryAdd, ProfileType.PASSWORD_VERIFY_FUNCTION, value);
            this.profile.QueryUpdate = String.Join(" ", this.profile.QueryUpdate, ProfileType.PASSWORD_VERIFY_FUNCTION, value);
            return this;
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

    public class ProfileValue
    {
        public static string DEFAULT = "DEFAULT";
        public static string UNLIMITED = "UNLIMITED";
        public static string NULL = "NULL";
    }

    public class ProfileMapper
    {
        public static Profile Map(Dictionary<String, String> data)
        {
            Profile profile = new Profile();
            #region resource_parameters

            if (data.ContainsKey(ProfileType.SESSIONS_PER_USER))
            {
                profile.SessionsPerUser = data[ProfileType.SESSIONS_PER_USER];
            }

            if (data.ContainsKey(ProfileType.CPU_PER_SESSION))
            {
                profile.CPUPerSession = data[ProfileType.CPU_PER_SESSION];
            }

            if (data.ContainsKey(ProfileType.CPU_PER_CALL))
            {
                profile.CPUPerCall = data[ProfileType.CPU_PER_CALL];
            }

            if (data.ContainsKey(ProfileType.CONNECT_TIME))
            {
                profile.ConnectTime = data[ProfileType.CONNECT_TIME];
            }
            if (data.ContainsKey(ProfileType.IDLE_TIME))
            {
                profile.IdleTime = data[ProfileType.IDLE_TIME];
            }
            if (data.ContainsKey(ProfileType.LOGICAL_READS_PER_SESSION))
            {
                profile.LogicalReadsPerSession = data[ProfileType.LOGICAL_READS_PER_SESSION];
            }
            if (data.ContainsKey(ProfileType.LOGICAL_READS_PER_CALL))
            {
                profile.LogicalReadsPerCall = data[ProfileType.LOGICAL_READS_PER_CALL];
            }
            if (data.ContainsKey(ProfileType.PRIVATE_SGA))
            {
                profile.PrivateSGA = data[ProfileType.PRIVATE_SGA];
            }
            if (data.ContainsKey(ProfileType.COMPOSITE_LIMIT))
            {
                profile.CompositeLimit = data[ProfileType.COMPOSITE_LIMIT];
            }


            #endregion resource_parameters

            #region password_parameters 
            if (data.ContainsKey(ProfileType.FAILED_LOGIN_ATTEMPTS))
            {
                profile.FailedLoginAttemps = data[ProfileType.FAILED_LOGIN_ATTEMPTS];
            }

            if (data.ContainsKey(ProfileType.PASSWORD_LIFE_TIME))
            {
                profile.PasswordLifeTime = data[ProfileType.PASSWORD_LIFE_TIME];
            }

            if (data.ContainsKey(ProfileType.PASSWORD_REUSE_TIME))
            {
                profile.PasswordReuseTime = data[ProfileType.PASSWORD_REUSE_TIME];
            }

            if (data.ContainsKey(ProfileType.PASSWORD_REUSE_MAX))
            {
                profile.PasswordReuseMax = data[ProfileType.PASSWORD_REUSE_MAX];
            }

            if (data.ContainsKey(ProfileType.PASSWORD_LOCK_TIME))
            {
                profile.PasswordLockTime = data[ProfileType.PASSWORD_LOCK_TIME];
            }

            if (data.ContainsKey(ProfileType.PASSWORD_GRACE_TIME))
            {
                profile.PasswordGraceTime = data[ProfileType.PASSWORD_GRACE_TIME];
            }

            if (data.ContainsKey(ProfileType.PASSWORD_VERIFY_FUNCTION))
            {
                profile.PasswordVerifyFunction = data[ProfileType.PASSWORD_VERIFY_FUNCTION];
            }
            #endregion password_parameters



            return profile;
        }
    }
}
