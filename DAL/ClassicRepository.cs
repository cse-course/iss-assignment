﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public abstract class ClassicRepository
    {
        protected readonly DbContext context;

        public ClassicRepository(DbContext context)
        {
            this.context = context;
        }

        protected DataSet GetDataSet(string sql, CommandType commandType, Dictionary<string, Object> parameters)
        {
            var result = new DataSet();

            var cmd = this.context.Database.Connection.CreateCommand();
            cmd.CommandType = commandType;
            cmd.CommandText = sql;

            foreach (var pr in parameters)
            {
                var p = cmd.CreateParameter();
                p.ParameterName = pr.Key;
                p.Value = pr.Value;
                cmd.Parameters.Add(p);
            }

            try
            {
                this.context.Database.Connection.Open();
                var reader = cmd.ExecuteReader();

                do
                {
                    var tb = new DataTable();
                    tb.Load(reader);
                    result.Tables.Add(tb);

                } while (!reader.IsClosed);
            }
            finally
            {
                this.context.Database.Connection.Close();
            }
            return result;
        }

        protected DataSet GetDataSet(string sql, CommandType commandType)
        {
            return this.GetDataSet(sql, commandType, new Dictionary<String, Object>());
        }

        protected DataSet GetDataSet(string sql)
        {
            return this.GetDataSet(sql, CommandType.Text);
        }
    }
}