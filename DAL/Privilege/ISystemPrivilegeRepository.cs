﻿using System;
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
        /// Execute query
        /// Use for Grant or Revoke
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        Boolean Execute(String query);

    }
}
