using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integra.Services.Data.Kaizen.Empleados
{
    public class H_Sueldos
    {
        List<Entities.Kaizen.Empleados.H_Sueldos> h_sueldosCollection = null;
        Entities.Kaizen.Empleados.H_Sueldos h_sueldos = null;
        SqlDataReader dataReader = null;

        public Connection connection = null;

        public H_Sueldos()
        {
            this.connection = Connection.Instance;
        }
        public H_Sueldos(bool isTransaction)
        {
            this.connection = new Connection();
        }
        public H_Sueldos(Connection connection)
        {
            this.connection = connection;
        }

        public Entities.Kaizen.Empleados.H_Sueldos Insert(Entities.Kaizen.Empleados.H_Sueldos objH_Sueldos)
        {
            h_sueldos = new Entities.Kaizen.Empleados.H_Sueldos();
            //StringBuilder sb = new StringBuilder();
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                parameters.Add(new SqlParameter() { ParameterName = "Compania", Value = objH_Sueldos.Compania });
                parameters.Add(new SqlParameter() { ParameterName = "companiaPasajes", Value = objH_Sueldos.companiaPasajes });
                parameters.Add(new SqlParameter() { ParameterName = "Empleado", Value = objH_Sueldos.numEmpleado });
                //parameters.Add(new SqlParameter() { ParameterName = "Fecha", Value = objH_Sueldos.Fecha });
                parameters.Add(new SqlParameter() { ParameterName = "Tipo_Sueldo", Value = objH_Sueldos.Tipo_Sueldo });
                parameters.Add(new SqlParameter() { ParameterName = "Sueldo", Value = objH_Sueldos.Sueldo });
                parameters.Add(new SqlParameter() { ParameterName = "Usuario", Value = objH_Sueldos.Usuario });
                parameters.Add(new SqlParameter() { ParameterName = "Ip", Value = objH_Sueldos.Ip });
                parameters.Add(new SqlParameter() { ParameterName = "Mac_Address", Value = objH_Sueldos.Mac_Address });

                using (dataReader = this.connection.ExcuteSP("prc_H_Sueldos_Insert_SoluGlob", parameters))
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            h_sueldos.Compania = dataReader.IsDBNull(dataReader.GetOrdinal("Compania")) ? null : dataReader["Compania"].ToString();
                            h_sueldos.numEmpleado = dataReader.IsDBNull(dataReader.GetOrdinal("Empleado")) ? null : dataReader["Empleado"].ToString();
                            h_sueldos.Fecha = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha")) ? default(DateTime) : DateTime.Parse(dataReader["Fecha"].ToString());
                            h_sueldos.Tipo_Sueldo = dataReader.IsDBNull(dataReader.GetOrdinal("Tipo_Sueldo")) ? null : dataReader["Tipo_Sueldo"].ToString();
                            h_sueldos.Sueldo = dataReader.IsDBNull(dataReader.GetOrdinal("Sueldo")) ? default(Double) : Double.Parse(dataReader["Sueldo"].ToString());
                            h_sueldos.Usuario = dataReader.IsDBNull(dataReader.GetOrdinal("Usuario")) ? null : dataReader["Usuario"].ToString();
                            h_sueldos.Ip = dataReader.IsDBNull(dataReader.GetOrdinal("Ip")) ? null : dataReader["Ip"].ToString();
                            h_sueldos.Mac_Address = dataReader.IsDBNull(dataReader.GetOrdinal("Mac_Address")) ? null : dataReader["Mac_Address"].ToString();

                        }
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }

                return h_sueldos;
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message.ToString());
            }
        }

        public Entities.Kaizen.Empleados.H_Sueldos GetOne(string Compania, string NumEmpleado)
        {
            h_sueldos = new Entities.Kaizen.Empleados.H_Sueldos();

            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter() { ParameterName = "compania", Value = Compania });
                parameters.Add(new SqlParameter() { ParameterName = "empleado", Value = NumEmpleado });

                using (dataReader = this.connection.ExcuteSP("prc_H_Sueldos_GetOne_SoluGlob", parameters))
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            h_sueldos.Compania = dataReader.IsDBNull(dataReader.GetOrdinal("Compania")) ? null : dataReader["Compania"].ToString();
                            h_sueldos.numEmpleado = dataReader.IsDBNull(dataReader.GetOrdinal("Empleado")) ? null : dataReader["Empleado"].ToString();
                            h_sueldos.Fecha = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha")) ? default(DateTime) : DateTime.Parse(dataReader["Fecha"].ToString());
                            h_sueldos.Tipo_Sueldo = dataReader.IsDBNull(dataReader.GetOrdinal("Tipo_Sueldo")) ? null : dataReader["Tipo_Sueldo"].ToString();
                            h_sueldos.Sueldo = dataReader.IsDBNull(dataReader.GetOrdinal("Sueldo")) ? default(Double) : Double.Parse(dataReader["Sueldo"].ToString());
                            h_sueldos.Usuario = dataReader.IsDBNull(dataReader.GetOrdinal("Usuario")) ? null : dataReader["Usuario"].ToString();
                            h_sueldos.Ip = dataReader.IsDBNull(dataReader.GetOrdinal("Ip")) ? null : dataReader["Ip"].ToString();
                            h_sueldos.Mac_Address = dataReader.IsDBNull(dataReader.GetOrdinal("Mac_Address")) ? null : dataReader["Mac_Address"].ToString();
                        }
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }

                return h_sueldos;
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message.ToString());
            }
        }

        public List<Entities.Kaizen.Empleados.H_Sueldos> GetAll()
        {
            h_sueldosCollection = new List<Entities.Kaizen.Empleados.H_Sueldos>();
            try
            {
                dataReader = this.connection.ExcuteSP("prc_H_Sueldos_GetAll_SoluGlob", null);

                while (dataReader.Read())
                {
                    h_sueldos = new Entities.Kaizen.Empleados.H_Sueldos();
                    h_sueldos.Compania = dataReader.IsDBNull(dataReader.GetOrdinal("Compania")) ? null : dataReader["Compania"].ToString();
                    h_sueldos.numEmpleado = dataReader.IsDBNull(dataReader.GetOrdinal("Empleado")) ? null : dataReader["Empleado"].ToString();
                    h_sueldos.Fecha = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha")) ? default(DateTime) : DateTime.Parse(dataReader["Fecha"].ToString());
                    h_sueldos.Tipo_Sueldo = dataReader.IsDBNull(dataReader.GetOrdinal("Tipo_Sueldo")) ? null : dataReader["Tipo_Sueldo"].ToString();
                    h_sueldos.Sueldo = dataReader.IsDBNull(dataReader.GetOrdinal("Sueldo")) ? default(Double) : Double.Parse(dataReader["Sueldo"].ToString());
                    h_sueldos.Usuario = dataReader.IsDBNull(dataReader.GetOrdinal("Usuario")) ? null : dataReader["Usuario"].ToString();
                    h_sueldos.Ip = dataReader.IsDBNull(dataReader.GetOrdinal("Ip")) ? null : dataReader["Ip"].ToString();
                    h_sueldos.Mac_Address = dataReader.IsDBNull(dataReader.GetOrdinal("Mac_Address")) ? null : dataReader["Mac_Address"].ToString();
                    h_sueldosCollection.Add(h_sueldos);
                }
                dataReader.Close();
                dataReader.Dispose();

                return h_sueldosCollection;
            }
            catch (Exception ex)
            {

                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message.ToString());
            }
        }

        public Entities.Kaizen.Empleados.H_Sueldos Update(Entities.Kaizen.Empleados.H_Sueldos objH_Sueldos)
        {
            h_sueldos = new Entities.Kaizen.Empleados.H_Sueldos();
            //StringBuilder sb = new StringBuilder();
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                parameters.Add(new SqlParameter() { ParameterName = "Compania", Value = objH_Sueldos.Compania });
                parameters.Add(new SqlParameter() { ParameterName = "Empleado", Value = objH_Sueldos.numEmpleado });
                parameters.Add(new SqlParameter() { ParameterName = "Fecha", Value = objH_Sueldos.Fecha });
                parameters.Add(new SqlParameter() { ParameterName = "Tipo_Sueldo", Value = objH_Sueldos.Tipo_Sueldo });
                parameters.Add(new SqlParameter() { ParameterName = "Sueldo", Value = objH_Sueldos.Sueldo });
                parameters.Add(new SqlParameter() { ParameterName = "Usuario", Value = objH_Sueldos.Usuario });
                parameters.Add(new SqlParameter() { ParameterName = "Ip", Value = objH_Sueldos.Ip });
                parameters.Add(new SqlParameter() { ParameterName = "Mac_Address", Value = objH_Sueldos.Mac_Address });

                using (dataReader = this.connection.ExcuteSP("prc_H_Sueldos_Update_SoluGlob", parameters))
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            h_sueldos.Compania = dataReader.IsDBNull(dataReader.GetOrdinal("Compania")) ? null : dataReader["Compania"].ToString();
                            h_sueldos.numEmpleado = dataReader.IsDBNull(dataReader.GetOrdinal("Empleado")) ? null : dataReader["Empleado"].ToString();
                            h_sueldos.Fecha = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha")) ? default(DateTime) : DateTime.Parse(dataReader["Fecha"].ToString());
                            h_sueldos.Tipo_Sueldo = dataReader.IsDBNull(dataReader.GetOrdinal("Tipo_Sueldo")) ? null : dataReader["Tipo_Sueldo"].ToString();
                            h_sueldos.Sueldo = dataReader.IsDBNull(dataReader.GetOrdinal("Sueldo")) ? default(Double) : Double.Parse(dataReader["Sueldo"].ToString());
                            h_sueldos.Usuario = dataReader.IsDBNull(dataReader.GetOrdinal("Usuario")) ? null : dataReader["Usuario"].ToString();
                            h_sueldos.Ip = dataReader.IsDBNull(dataReader.GetOrdinal("Ip")) ? null : dataReader["Ip"].ToString();
                            h_sueldos.Mac_Address = dataReader.IsDBNull(dataReader.GetOrdinal("Mac_Address")) ? null : dataReader["Mac_Address"].ToString();
                        }
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }

                return h_sueldos;
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message.ToString());
            }
        }

        public void Delete(string Compania, string NumEmpleado)
        {
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter() { ParameterName = "compania", Value = Compania });
                parameters.Add(new SqlParameter() { ParameterName = "empleado", Value = NumEmpleado });

                this.connection.ExcuteScalar("prc_H_Sueldos_Delete_SoluGlob", parameters);
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message);
            }
        }

        public void Drop(string Compania, string NumEmpleado)
        {
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter() { ParameterName = "compania", Value = Compania });
                parameters.Add(new SqlParameter() { ParameterName = "empleado", Value = NumEmpleado });

                this.connection.ExcuteScalar("prc_H_Sueldos_Drop_SoluGlob", parameters);
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message);
            }
        }

        public bool DropLast(Entities.Kaizen.Empleados.H_Sueldos objH_Sueldos)
        {
            int result = default(int);
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter() { ParameterName = "Compania", Value = objH_Sueldos.Compania });
                parameters.Add(new SqlParameter() { ParameterName = "Empleado", Value = objH_Sueldos.numEmpleado });
                parameters.Add(new SqlParameter() { ParameterName = "CompaniaPasajes", Value = objH_Sueldos.companiaPasajes });
                parameters.Add(new SqlParameter() { ParameterName = "Tipo_Sueldo", Value = objH_Sueldos.Tipo_Sueldo });

                using (dataReader = this.connection.ExcuteSP("prc_H_Sueldos_DropLast_SoluGlob", parameters))
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                             result = dataReader.IsDBNull(dataReader.GetOrdinal("result")) ? default(int) : int.Parse(dataReader["result"].ToString());
                        }
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }

                return result != default(int) ? true : false;
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
