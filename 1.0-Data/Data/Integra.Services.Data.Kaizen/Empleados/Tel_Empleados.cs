using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integra.Services.Data.Kaizen.Empleados
{
    public class Tel_Empleados
    {
  
        Entities.Kaizen.Empleados.Tel_Empleados tel_empleados = null;
        SqlDataReader dataReader = null;

        public Connection connection = null;

        public Tel_Empleados()
        {
            this.connection = Connection.Instance;
        }
        public Tel_Empleados(bool isTransaction)
        {
            this.connection = new Connection();
        }
        public Tel_Empleados(Connection connection)
        {
            this.connection = connection;
        }

        public Entities.Kaizen.Empleados.Tel_Empleados Insert(Entities.Kaizen.Empleados.Tel_Empleados objH_Valores_X_Emp)
        {
            tel_empleados = new Entities.Kaizen.Empleados.Tel_Empleados();
            //StringBuilder sb = new StringBuilder();
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                parameters.Add(new SqlParameter() { ParameterName = "Compania", Value = objH_Valores_X_Emp.Compania });
                parameters.Add(new SqlParameter() { ParameterName = "companiaPasajes", Value = objH_Valores_X_Emp.companiaPasajes });
                parameters.Add(new SqlParameter() { ParameterName = "Empleado", Value = objH_Valores_X_Emp.numEmpleado });
                parameters.Add(new SqlParameter() { ParameterName = "Tipo", Value = objH_Valores_X_Emp.Tipo });
                parameters.Add(new SqlParameter() { ParameterName = "Sec", Value = objH_Valores_X_Emp.Sec });
                parameters.Add(new SqlParameter() { ParameterName = "Telefono", Value = objH_Valores_X_Emp.Telefono });

                using (dataReader = this.connection.ExcuteSP("prc_Tel_Empleados_Insert_SoluGlob", parameters))
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            tel_empleados.Compania = dataReader.IsDBNull(dataReader.GetOrdinal("Compania")) ? null : dataReader["Compania"].ToString();
                            tel_empleados.numEmpleado = dataReader.IsDBNull(dataReader.GetOrdinal("Empleado")) ? null : dataReader["Empleado"].ToString();
                            tel_empleados.Tipo = dataReader.IsDBNull(dataReader.GetOrdinal("Tipo")) ? default(Int16) : Int16.Parse(dataReader["Tipo"].ToString());
                            tel_empleados.Sec = dataReader.IsDBNull(dataReader.GetOrdinal("Sec")) ? default(Int16) : Int16.Parse(dataReader["Sec"].ToString());
                            tel_empleados.Telefono = dataReader.IsDBNull(dataReader.GetOrdinal("Telefono")) ? null : dataReader["Telefono"].ToString();

                        }
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }

                return tel_empleados;
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message.ToString());
            }
        }

        public void Drop(string Compania, string NumEmpleado)
        {
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter() { ParameterName = "compania", Value = Compania });
                parameters.Add(new SqlParameter() { ParameterName = "empleado", Value = NumEmpleado });

                this.connection.ExcuteScalar("prc_Tel_Empleados_Drop_SoluGlob", parameters);
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message);
            }
        }
    }
}
