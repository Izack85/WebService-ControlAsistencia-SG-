using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Integra.Services.Data
{
    public class Connection
    {

        private SqlConnection sqlConnection = null;
        private SqlCommand sqlCommand = null;
        private SqlDataReader sqlReader = null;
        private object sqlScalar = null;
        private static Connection instance = null;
        public static Connection Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Connection();
                }
                else
                {
                    if (instance.sqlConnection.State.Equals(System.Data.ConnectionState.Closed))
                    {
                        instance.sqlConnection.Open();
                    }
                }
                return instance;
            }
        }

        public Connection()
        {


            if (sqlConnection == null)
            {
                sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = ConnectionString();
                sqlConnection.Open();
            }
            else
            {


                if (sqlConnection.State.Equals(System.Data.ConnectionState.Closed))
                {
                    sqlConnection.Open();
                }

            }

        }

        private string ConnectionString()
        {
            string connectionstring = string.Empty;
            connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["Integra.Services.Data.Kaizen"].ToString();
            return connectionstring;
        }


        public SqlDataReader ExcuteSP(string nameProcedure, List<SqlParameter> parameters)
        {
            sqlCommand = new SqlCommand();
            sqlCommand.Connection = this.sqlConnection;
            sqlCommand.CommandTimeout = 36000;//3600;
            sqlCommand.CommandText = nameProcedure;

            if (parameters != null && parameters.Count > 0)
            {
                sqlCommand.Parameters.AddRange(parameters.ToArray());
            }

            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlReader = sqlCommand.ExecuteReader();
            return sqlReader;
        }

        public void ExcuteNone()
        {

        }

        public object ExcuteScalar(string nameProcedure, List<SqlParameter> parameters)
        {
            sqlCommand = new SqlCommand();
            sqlCommand.Connection = this.sqlConnection;
            sqlCommand.CommandTimeout = 3600;
            sqlCommand.CommandText = nameProcedure;

            if (parameters != null && parameters.Count > 0)
            {
                sqlCommand.Parameters.AddRange(parameters.ToArray());
            }
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlScalar = sqlCommand.ExecuteScalar();


            return sqlScalar;
        }
    }
}
