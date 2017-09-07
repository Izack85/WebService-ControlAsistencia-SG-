using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Integra.Services.Data.SoluglobChecador
{
    public class Incidencias
    {
        SqlDataReader dataReader = null;
        SqlDataAdapter dataAdapter = null;

        public Connection connection = null;

        public Incidencias()
        {
            this.connection = Connection.Instance;
        }
        public Incidencias(bool isTransaction)
        {
            this.connection = new Connection();
        }
        public Incidencias(Connection connection)
        {
            this.connection = connection;
        }

        public DataSet GetIncidencias(DateTime FechaInicio, DateTime FechaFin)
        {
            DataSet dsIncidencias = new DataSet();

            var dateFechaIni = FechaInicio.ToString("yyyy-MM-dd");
            var dateFechaFin = FechaFin.ToString("yyyy-MM-dd");

            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                parameters.Add(new SqlParameter() { ParameterName = "FechaInicio", Value = dateFechaIni });
                parameters.Add(new SqlParameter() { ParameterName = "FechaFin", Value = dateFechaFin });

                using (dataAdapter = this.connection.ExecuteAdapter("DataSetIIIntegra", parameters))
                {                    
                    dataAdapter.Fill(dsIncidencias);
                }
                                
                dataAdapter.Dispose();             
                return dsIncidencias;
            }
            catch (Exception ex)
            {
                dataAdapter.Dispose();
                throw new Exception(ex.Message.ToString());
            }

        }

              
        public DataTable GetTableIncidencias(DateTime FechaInicio, DateTime FechaFin)
        {
            //DataSet dsIncidencias = new DataSet();
            DataTable dtIncidencias = null;

            var dateFechaIni = FechaInicio.ToString("yyyy-MM-dd");
            var dateFechaFin = FechaFin.ToString("yyyy-MM-dd");

            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                parameters.Add(new SqlParameter() { ParameterName = "FechaInicio", Value = dateFechaIni });
                parameters.Add(new SqlParameter() { ParameterName = "FechaFin", Value = dateFechaFin });

                using (dataReader = this.connection.ExcuteSP("DataSetIIIntegra", parameters))
                {
                    if (dataReader.HasRows)
                    {
                        dtIncidencias = new DataTable();
                        dtIncidencias.Load(dataReader);

                        //while (dataReader.Read())
                        //{
                        //    dtIncidencias = new DataTable();
                        //    dtIncidencias.Load(dataReader);
                        //    dsIncidencias.Tables.Add(dtIncidencias);
                        //    
                        //}
                    }

                    dataReader.Close();
                    dataReader.Dispose();
                }

                return dtIncidencias;

            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message.ToString());
            }
            
        }        

    }
}
