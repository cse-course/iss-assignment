using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IObjectPrivilegeRepository
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
        /// Execute query
        /// Use for Grant or Revoke
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        Boolean Execute(String query);

    }
}
