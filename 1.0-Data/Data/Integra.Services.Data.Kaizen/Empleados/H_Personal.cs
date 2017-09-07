using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integra.Services.Data.Kaizen.Empleados
{
    public class H_Personal
    {
        List<Entities.Kaizen.Empleados.H_Personal> h_personalCollection = null;
        Entities.Kaizen.Empleados.H_Personal h_personal = null;
        SqlDataReader dataReader = null;

        public Connection connection = null;

        public H_Personal()
        {
            this.connection = Connection.Instance;
        }
        public H_Personal(bool isTransaction)
        {
            this.connection = new Connection();
        }
        public H_Personal(Connection connection)
        {
            this.connection = connection;
        }

        public Entities.Kaizen.Empleados.H_Personal Insert(Entities.Kaizen.Empleados.H_Personal objH_Personal)
        {
            h_personal = new Entities.Kaizen.Empleados.H_Personal();
            //StringBuilder sb = new StringBuilder();
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                parameters.Add(new SqlParameter() { ParameterName = "Compania", Value = objH_Personal.Compania });
                parameters.Add(new SqlParameter() { ParameterName = "companiaPasajes", Value = objH_Personal.companiaPasajes });
                parameters.Add(new SqlParameter() { ParameterName = "Empleado", Value = objH_Personal.numEmpleado });
                parameters.Add(new SqlParameter() { ParameterName = "Fecha", Value = objH_Personal.Fecha });
                parameters.Add(new SqlParameter() { ParameterName = "Direccion", Value = objH_Personal.Direccion });
                parameters.Add(new SqlParameter() { ParameterName = "Poblacion", Value = objH_Personal.Poblacion });
                parameters.Add(new SqlParameter() { ParameterName = "Ciudad", Value = objH_Personal.Ciudad });
                parameters.Add(new SqlParameter() { ParameterName = "Colonia", Value = objH_Personal.Colonia });
                parameters.Add(new SqlParameter() { ParameterName = "Cp", Value = objH_Personal.Cp });
                parameters.Add(new SqlParameter() { ParameterName = "Pais", Value = objH_Personal.Pais });
                parameters.Add(new SqlParameter() { ParameterName = "Estado", Value = objH_Personal.Estado });
                parameters.Add(new SqlParameter() { ParameterName = "Estado_Civil", Value = objH_Personal.Estado_Civil });
                parameters.Add(new SqlParameter() { ParameterName = "Usuario", Value = objH_Personal.Usuario });
                parameters.Add(new SqlParameter() { ParameterName = "Numero_Ext", Value = objH_Personal.Numero_Ext });
                parameters.Add(new SqlParameter() { ParameterName = "Numero_Int", Value = objH_Personal.Numero_Int });
                parameters.Add(new SqlParameter() { ParameterName = "Ip", Value = objH_Personal.Ip });
                parameters.Add(new SqlParameter() { ParameterName = "Mac_Address", Value = objH_Personal.Mac_Address });

                using (dataReader = this.connection.ExcuteSP("prc_H_Personal_Insert_SoluGlob", parameters))
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            h_personal.Compania = dataReader.IsDBNull(dataReader.GetOrdinal("Compania")) ? null : dataReader["Compania"].ToString();
                            h_personal.numEmpleado = dataReader.IsDBNull(dataReader.GetOrdinal("Empleado")) ? null : dataReader["Empleado"].ToString();
                            h_personal.Fecha = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha")) ? default(DateTime) : DateTime.Parse(dataReader["Fecha"].ToString());
                            h_personal.Direccion = dataReader.IsDBNull(dataReader.GetOrdinal("Direccion")) ? null : dataReader["Direccion"].ToString();
                            h_personal.Poblacion = dataReader.IsDBNull(dataReader.GetOrdinal("Poblacion")) ? null : dataReader["Poblacion"].ToString();
                            h_personal.Ciudad = dataReader.IsDBNull(dataReader.GetOrdinal("Ciudad")) ? null : dataReader["Ciudad"].ToString();
                            h_personal.Colonia = dataReader.IsDBNull(dataReader.GetOrdinal("Colonia")) ? null : dataReader["Colonia"].ToString();
                            h_personal.Cp = dataReader.IsDBNull(dataReader.GetOrdinal("Cp")) ? null : dataReader["Cp"].ToString();
                            h_personal.Pais = dataReader.IsDBNull(dataReader.GetOrdinal("Pais")) ? null : dataReader["Pais"].ToString();
                            h_personal.Estado = dataReader.IsDBNull(dataReader.GetOrdinal("Estado")) ? null : dataReader["Estado"].ToString();
                            h_personal.Estado_Civil = dataReader.IsDBNull(dataReader.GetOrdinal("Estado_Civil")) ? default(Int16?) : Int16.Parse(dataReader["Estado_Civil"].ToString());
                            h_personal.Usuario = dataReader.IsDBNull(dataReader.GetOrdinal("Usuario")) ? null : dataReader["Usuario"].ToString();
                            h_personal.Numero_Ext = dataReader.IsDBNull(dataReader.GetOrdinal("Numero_Ext")) ? null : dataReader["Numero_Ext"].ToString();
                            h_personal.Numero_Int = dataReader.IsDBNull(dataReader.GetOrdinal("Numero_Int")) ? null : dataReader["Numero_Int"].ToString();
                            h_personal.Ip = dataReader.IsDBNull(dataReader.GetOrdinal("Ip")) ? null : dataReader["Ip"].ToString();
                            h_personal.Mac_Address = dataReader.IsDBNull(dataReader.GetOrdinal("Mac_Address")) ? null : dataReader["Mac_Address"].ToString();

                        }
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }

                return h_personal;
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message.ToString());
            }
        }

        public Entities.Kaizen.Empleados.H_Personal GetOne(string Compania, string NumEmpleado)
        {
            h_personal = new Entities.Kaizen.Empleados.H_Personal();

            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter() { ParameterName = "compania", Value = Compania });
                parameters.Add(new SqlParameter() { ParameterName = "empleado", Value = NumEmpleado });

                using (dataReader = this.connection.ExcuteSP("prc_H_Personal_GetOne_SoluGlob", parameters))
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            h_personal.Compania = dataReader.IsDBNull(dataReader.GetOrdinal("Compania")) ? null : dataReader["Compania"].ToString();
                            h_personal.numEmpleado = dataReader.IsDBNull(dataReader.GetOrdinal("Empleado")) ? null : dataReader["Empleado"].ToString();
                            h_personal.Fecha = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha")) ? default(DateTime) : DateTime.Parse(dataReader["Fecha"].ToString());
                            h_personal.Direccion = dataReader.IsDBNull(dataReader.GetOrdinal("Direccion")) ? null : dataReader["Direccion"].ToString();
                            h_personal.Poblacion = dataReader.IsDBNull(dataReader.GetOrdinal("Poblacion")) ? null : dataReader["Poblacion"].ToString();
                            h_personal.Ciudad = dataReader.IsDBNull(dataReader.GetOrdinal("Ciudad")) ? null : dataReader["Ciudad"].ToString();
                            h_personal.Colonia = dataReader.IsDBNull(dataReader.GetOrdinal("Colonia")) ? null : dataReader["Colonia"].ToString();
                            h_personal.Cp = dataReader.IsDBNull(dataReader.GetOrdinal("Cp")) ? null : dataReader["Cp"].ToString();
                            h_personal.Pais = dataReader.IsDBNull(dataReader.GetOrdinal("Pais")) ? null : dataReader["Pais"].ToString();
                            h_personal.Estado = dataReader.IsDBNull(dataReader.GetOrdinal("Motivo")) ? null : dataReader["Estado"].ToString();
                            h_personal.Estado_Civil = dataReader.IsDBNull(dataReader.GetOrdinal("Estado_Civil")) ? default(Int16?) : Int16.Parse(dataReader["Estado_Civil"].ToString());
                            h_personal.Usuario = dataReader.IsDBNull(dataReader.GetOrdinal("Usuario")) ? null : dataReader["Usuario"].ToString();
                            h_personal.Numero_Ext = dataReader.IsDBNull(dataReader.GetOrdinal("Numero_Ext")) ? null : dataReader["Numero_Ext"].ToString();
                            h_personal.Numero_Int = dataReader.IsDBNull(dataReader.GetOrdinal("Numero_Int")) ? null : dataReader["Numero_Int"].ToString();
                            h_personal.Ip = dataReader.IsDBNull(dataReader.GetOrdinal("Ip")) ? null : dataReader["Ip"].ToString();
                            h_personal.Mac_Address = dataReader.IsDBNull(dataReader.GetOrdinal("Mac_Address")) ? null : dataReader["Mac_Address"].ToString();
                        }
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }

                return h_personal;
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message.ToString());
            }
        }

        public List<Entities.Kaizen.Empleados.H_Personal> GetAll()
        {
            h_personalCollection = new List<Entities.Kaizen.Empleados.H_Personal>();
            try
            {
                dataReader = this.connection.ExcuteSP("prc_H_Personal_GetAll_SoluGlob", null);

                while (dataReader.Read())
                {
                    h_personal = new Entities.Kaizen.Empleados.H_Personal();
                    h_personal.Compania = dataReader.IsDBNull(dataReader.GetOrdinal("Compania")) ? null : dataReader["Compania"].ToString();
                    h_personal.numEmpleado = dataReader.IsDBNull(dataReader.GetOrdinal("Empleado")) ? null : dataReader["Empleado"].ToString();
                    h_personal.Fecha = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha")) ? default(DateTime) : DateTime.Parse(dataReader["Fecha"].ToString());
                    h_personal.Direccion = dataReader.IsDBNull(dataReader.GetOrdinal("Direccion")) ? null : dataReader["Direccion"].ToString();
                    h_personal.Poblacion = dataReader.IsDBNull(dataReader.GetOrdinal("Poblacion")) ? null : dataReader["Poblacion"].ToString();
                    h_personal.Ciudad = dataReader.IsDBNull(dataReader.GetOrdinal("Ciudad")) ? null : dataReader["Ciudad"].ToString();
                    h_personal.Colonia = dataReader.IsDBNull(dataReader.GetOrdinal("Colonia")) ? null : dataReader["Colonia"].ToString();
                    h_personal.Cp = dataReader.IsDBNull(dataReader.GetOrdinal("Cp")) ? null : dataReader["Cp"].ToString();
                    h_personal.Pais = dataReader.IsDBNull(dataReader.GetOrdinal("Pais")) ? null : dataReader["Pais"].ToString();
                    h_personal.Estado = dataReader.IsDBNull(dataReader.GetOrdinal("Motivo")) ? null : dataReader["Estado"].ToString();
                    h_personal.Estado_Civil = dataReader.IsDBNull(dataReader.GetOrdinal("Estado_Civil")) ? default(Int16?) : Int16.Parse(dataReader["Estado_Civil"].ToString());
                    h_personal.Usuario = dataReader.IsDBNull(dataReader.GetOrdinal("Usuario")) ? null : dataReader["Usuario"].ToString();
                    h_personal.Numero_Ext = dataReader.IsDBNull(dataReader.GetOrdinal("Numero_Ext")) ? null : dataReader["Numero_Ext"].ToString();
                    h_personal.Numero_Int = dataReader.IsDBNull(dataReader.GetOrdinal("Numero_Int")) ? null : dataReader["Numero_Int"].ToString();
                    h_personal.Ip = dataReader.IsDBNull(dataReader.GetOrdinal("Ip")) ? null : dataReader["Ip"].ToString();
                    h_personal.Mac_Address = dataReader.IsDBNull(dataReader.GetOrdinal("Mac_Address")) ? null : dataReader["Mac_Address"].ToString();
                    h_personalCollection.Add(h_personal);
                }
                dataReader.Close();
                dataReader.Dispose();

                return h_personalCollection;
            }
            catch (Exception ex)
            {

                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message.ToString());
            }
        }

        public Entities.Kaizen.Empleados.H_Personal Update(Entities.Kaizen.Empleados.H_Personal objH_Personal)
        {
            h_personal = new Entities.Kaizen.Empleados.H_Personal();
            //StringBuilder sb = new StringBuilder();
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                parameters.Add(new SqlParameter() { ParameterName = "Compania", Value = objH_Personal.Compania });
                parameters.Add(new SqlParameter() { ParameterName = "Empleado", Value = objH_Personal.numEmpleado });
                parameters.Add(new SqlParameter() { ParameterName = "Fecha", Value = objH_Personal.Fecha });
                parameters.Add(new SqlParameter() { ParameterName = "Direccion", Value = objH_Personal.Direccion });
                parameters.Add(new SqlParameter() { ParameterName = "Poblacion", Value = objH_Personal.Poblacion });
                parameters.Add(new SqlParameter() { ParameterName = "Ciudad", Value = objH_Personal.Ciudad });
                parameters.Add(new SqlParameter() { ParameterName = "Colonia", Value = objH_Personal.Colonia });
                parameters.Add(new SqlParameter() { ParameterName = "Cp", Value = objH_Personal.Cp });
                parameters.Add(new SqlParameter() { ParameterName = "Pais", Value = objH_Personal.Pais });
                parameters.Add(new SqlParameter() { ParameterName = "Estado", Value = objH_Personal.Estado });
                parameters.Add(new SqlParameter() { ParameterName = "Estado_Civil", Value = objH_Personal.Estado_Civil });
                parameters.Add(new SqlParameter() { ParameterName = "Usuario", Value = objH_Personal.Usuario });
                parameters.Add(new SqlParameter() { ParameterName = "Numero_Ext", Value = objH_Personal.Numero_Ext });
                parameters.Add(new SqlParameter() { ParameterName = "Numero_Int", Value = objH_Personal.Numero_Int });
                parameters.Add(new SqlParameter() { ParameterName = "Ip", Value = objH_Personal.Ip });
                parameters.Add(new SqlParameter() { ParameterName = "Mac_Address", Value = objH_Personal.Mac_Address });

                using (dataReader = this.connection.ExcuteSP("prc_H_Personal_Update_SoluGlob", parameters))
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            h_personal.Compania = dataReader.IsDBNull(dataReader.GetOrdinal("Compania")) ? null : dataReader["Compania"].ToString();
                            h_personal.numEmpleado = dataReader.IsDBNull(dataReader.GetOrdinal("Empleado")) ? null : dataReader["Empleado"].ToString();
                            h_personal.Fecha = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha")) ? default(DateTime) : DateTime.Parse(dataReader["Fecha"].ToString());
                            h_personal.Direccion = dataReader.IsDBNull(dataReader.GetOrdinal("Direccion")) ? null : dataReader["Direccion"].ToString();
                            h_personal.Poblacion = dataReader.IsDBNull(dataReader.GetOrdinal("Poblacion")) ? null : dataReader["Poblacion"].ToString();
                            h_personal.Ciudad = dataReader.IsDBNull(dataReader.GetOrdinal("Ciudad")) ? null : dataReader["Ciudad"].ToString();
                            h_personal.Colonia = dataReader.IsDBNull(dataReader.GetOrdinal("Colonia")) ? null : dataReader["Colonia"].ToString();
                            h_personal.Cp = dataReader.IsDBNull(dataReader.GetOrdinal("Cp")) ? null : dataReader["Cp"].ToString();
                            h_personal.Pais = dataReader.IsDBNull(dataReader.GetOrdinal("Pais")) ? null : dataReader["Pais"].ToString();
                            h_personal.Estado = dataReader.IsDBNull(dataReader.GetOrdinal("Motivo")) ? null : dataReader["Estado"].ToString();
                            h_personal.Estado_Civil = dataReader.IsDBNull(dataReader.GetOrdinal("Estado_Civil")) ? default(Int16?) : Int16.Parse(dataReader["Estado_Civil"].ToString());
                            h_personal.Usuario = dataReader.IsDBNull(dataReader.GetOrdinal("Usuario")) ? null : dataReader["Usuario"].ToString();
                            h_personal.Numero_Ext = dataReader.IsDBNull(dataReader.GetOrdinal("Numero_Ext")) ? null : dataReader["Numero_Ext"].ToString();
                            h_personal.Numero_Int = dataReader.IsDBNull(dataReader.GetOrdinal("Numero_Int")) ? null : dataReader["Numero_Int"].ToString();
                            h_personal.Ip = dataReader.IsDBNull(dataReader.GetOrdinal("Ip")) ? null : dataReader["Ip"].ToString();
                            h_personal.Mac_Address = dataReader.IsDBNull(dataReader.GetOrdinal("Mac_Address")) ? null : dataReader["Mac_Address"].ToString();
                        }
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }

                return h_personal;
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

                this.connection.ExcuteScalar("prc_H_Personal_Delete_SoluGlob", parameters);
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

                this.connection.ExcuteScalar("prc_H_Personal_Drop_SoluGlob", parameters);
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
