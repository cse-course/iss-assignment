using System;
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

            var command = this.context.Database.Connection.CreateCommand();
            command.CommandType = commandType;
            command.CommandText = sql;

            foreach (var pr in parameters)
            {
                var param = command.CreateParameter();
                param.ParameterName = pr.Key;
                param.Value = pr.Value;
                command.Parameters.Add(param);
            }

            try
            {
                this.context.Database.Connection.Open();
                var reader = command.ExecuteReader();

                do
                {
                    var table = new DataTable();
                    table.Load(reader);
                    result.Tables.Add(table);

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


        protected void Execute(string sql, CommandType commandType, Dictionary<string, Object> parameters)
        {
            var command = this.context.Database.Connection.CreateCommand();
            command.CommandType = commandType;
            command.CommandText = sql;

            foreach (var pr in parameters)
            {
                var param = command.CreateParameter();
                param.ParameterName = pr.Key;
                param.Value = pr.Value;
                command.Parameters.Add(param);
            }

            try
            {
                this.context.Database.Connection.Open();
                command.ExecuteNonQuery();
            }
            finally
            {
                this.context.Database.Connection.Close();
            }
        }

        protected void Execute(string sql, CommandType commandType)
        {
            this.Execute(sql, commandType, new Dictionary<String, Object>());
        }
        protected void Execute(string sql)
        {
            this.Execute(sql, CommandType.Text);
        }
    }
}
