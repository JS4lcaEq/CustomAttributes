using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm
{
    class Db
    {
        public static SqlConnection GetConnection(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = new SqlConnection(ConfigurationManager.AppSettings["SqlConnection"] as string);
            return cmd.Connection;
        }

    }
}
