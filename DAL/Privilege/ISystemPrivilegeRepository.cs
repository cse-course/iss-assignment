using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface ISystemPrivilegeRepository
    {
        /// <summary>
        /// Get all privilege
        /// </summary>
        /// <returns>Dataset</returns>
        DataSet View();

        /// <summary>
        /// Get all privilege of grante
        /// </summary>
        /// <param name="grantee"></param>
        /// <returns>Dataset</returns>
        DataSet View(String grantee);

        /// <summary>
        /// Get all privilege of grantee with admin option
        /// </summary>
        /// <param name="grantee"></param>
        /// <param name="isAdmin"></param>
        /// <returns></returns>
        DataSet View(String grantee, String isAdmin);

        /// <summary>
        /// Check grantee has privilege
        /// </summary>
        /// <param name="grantee"></param>
        /// <param name="privilege"></param>
        /// <returns></returns>
        DataSet Has(String grantee, String privilege);

        /// <summary>
        /// Check grantee has admin privilege
        /// </summary>
        /// <param name="grantee"></param>
        /// <param name="privilege"></param>
        /// <returns></returns>
        DataSet Has(String grantee, String privilege, String isAdmin);

        /// <summary>
        /// Get all grantee have privilege
        /// </summary>
        /// <param name="privilege"></param>
        /// <param name="isAdmin"></param>
        /// <returns></returns>
        DataSet Grantee(String privilege);

        /// <summary>
        /// Get all grantee have privilege
        /// </summary>
        /// <param name="privilege"></param>
        /// <param name="isAdmin"></param>
        /// <returns></returns>
        DataSet Grantee(String privilege, String isAdmin);

        /// <summary>
        /// Execute query
        /// Use for Grant or Revoke
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        Boolean Execute(String query);

    }
}
