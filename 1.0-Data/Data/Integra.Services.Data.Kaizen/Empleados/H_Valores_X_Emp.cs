using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integra.Services.Data.Kaizen.Empleados
{
    public class H_Valores_X_Emp
    {
        List<Entities.Kaizen.Empleados.H_Valores_X_Emp> h_valores_x_empCollection = null;
        Entities.Kaizen.Empleados.H_Valores_X_Emp h_valores_x_emp = null;
        SqlDataReader dataReader = null;

        public Connection connection = null;

        public H_Valores_X_Emp()
        {
            this.connection = Connection.Instance;
        }
        public H_Valores_X_Emp(bool isTransaction)
        {
            this.connection = new Connection();
        }
        public H_Valores_X_Emp(Connection connection)
        {
            this.connection = connection;
        }

        public Entities.Kaizen.Empleados.H_Valores_X_Emp Insert(Entities.Kaizen.Empleados.H_Valores_X_Emp objH_Valores_X_Emp)
        {
            h_valores_x_emp = new Entities.Kaizen.Empleados.H_Valores_X_Emp();
            //StringBuilder sb = new StringBuilder();
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                parameters.Add(new SqlParameter() { ParameterName = "Compania", Value = objH_Valores_X_Emp.Compania });
                parameters.Add(new SqlParameter() { ParameterName = "companiaPasajes", Value = objH_Valores_X_Emp.companiaPasajes });
                parameters.Add(new SqlParameter() { ParameterName = "Empleado", Value = objH_Valores_X_Emp.numEmpleado });
                parameters.Add(new SqlParameter() { ParameterName = "Nombre", Value = objH_Valores_X_Emp.Nombre });
                parameters.Add(new SqlParameter() { ParameterName = "Fecha", Value = objH_Valores_X_Emp.Fecha });
                parameters.Add(new SqlParameter() { ParameterName = "Valor", Value = objH_Valores_X_Emp.Valor });

                using (dataReader = this.connection.ExcuteSP("prc_H_Valores_X_Emp_Insert_SoluGlob", parameters))
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            h_valores_x_emp.Compania = dataReader.IsDBNull(dataReader.GetOrdinal("Compania")) ? null : dataReader["Compania"].ToString();
                            h_valores_x_emp.numEmpleado = dataReader.IsDBNull(dataReader.GetOrdinal("Empleado")) ? null : dataReader["Empleado"].ToString();
                            h_valores_x_emp.Nombre = dataReader.IsDBNull(dataReader.GetOrdinal("Nombre")) ? null : dataReader["Nombre"].ToString();
                            h_valores_x_emp.Fecha = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha")) ? default(DateTime) : DateTime.Parse(dataReader["Fecha"].ToString());                            
                            h_valores_x_emp.Valor = dataReader.IsDBNull(dataReader.GetOrdinal("Valor")) ? null : dataReader["Valor"].ToString();

                        }
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }

                return h_valores_x_emp;
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message.ToString());
            }
        }

        public Entities.Kaizen.Empleados.H_Valores_X_Emp GetOne(string Compania, string NumEmpleado)
        {
            h_valores_x_emp = new Entities.Kaizen.Empleados.H_Valores_X_Emp();

            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter() { ParameterName = "compania", Value = Compania });
                parameters.Add(new SqlParameter() { ParameterName = "empleado", Value = NumEmpleado });

                using (dataReader = this.connection.ExcuteSP("prc_H_Valores_X_Emp_GetOne_SoluGlob", parameters))
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            h_valores_x_emp.Compania = dataReader.IsDBNull(dataReader.GetOrdinal("Compania")) ? null : dataReader["Compania"].ToString();
                            h_valores_x_emp.numEmpleado = dataReader.IsDBNull(dataReader.GetOrdinal("Empleado")) ? null : dataReader["Empleado"].ToString();
                            h_valores_x_emp.Nombre = dataReader.IsDBNull(dataReader.GetOrdinal("Nombre")) ? null : dataReader["Nombre"].ToString();
                            h_valores_x_emp.Fecha = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha")) ? default(DateTime) : DateTime.Parse(dataReader["Fecha"].ToString());
                            h_valores_x_emp.Valor = dataReader.IsDBNull(dataReader.GetOrdinal("Valor")) ? null : dataReader["Valor"].ToString();
                        }
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }

                return h_valores_x_emp;
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message.ToString());
            }
        }

        public List<Entities.Kaizen.Empleados.H_Valores_X_Emp> GetAll()
        {
            h_valores_x_empCollection = new List<Entities.Kaizen.Empleados.H_Valores_X_Emp>();
            try
            {
                dataReader = this.connection.ExcuteSP("prc_H_Valores_X_Emp_GetAll_SoluGlob", null);

                while (dataReader.Read())
                {
                    h_valores_x_emp = new Entities.Kaizen.Empleados.H_Valores_X_Emp();
                    h_valores_x_emp.Compania = dataReader.IsDBNull(dataReader.GetOrdinal("Compania")) ? null : dataReader["Compania"].ToString();
                    h_valores_x_emp.numEmpleado = dataReader.IsDBNull(dataReader.GetOrdinal("Empleado")) ? null : dataReader["Empleado"].ToString();
                    h_valores_x_emp.Nombre = dataReader.IsDBNull(dataReader.GetOrdinal("Nombre")) ? null : dataReader["Nombre"].ToString();
                    h_valores_x_emp.Fecha = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha")) ? default(DateTime) : DateTime.Parse(dataReader["Fecha"].ToString());
                    h_valores_x_emp.Valor = dataReader.IsDBNull(dataReader.GetOrdinal("Valor")) ? null : dataReader["Valor"].ToString();
                    h_valores_x_empCollection.Add(h_valores_x_emp);
                }
                dataReader.Close();
                dataReader.Dispose();

                return h_valores_x_empCollection;
            }
            catch (Exception ex)
            {

                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message.ToString());
            }
        }

        public Entities.Kaizen.Empleados.H_Valores_X_Emp Update(Entities.Kaizen.Empleados.H_Valores_X_Emp objH_Valores_X_Emp)
        {
            h_valores_x_emp = new Entities.Kaizen.Empleados.H_Valores_X_Emp();
            //StringBuilder sb = new StringBuilder();
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                parameters.Add(new SqlParameter() { ParameterName = "Compania", Value = objH_Valores_X_Emp.Compania });
                parameters.Add(new SqlParameter() { ParameterName = "Empleado", Value = objH_Valores_X_Emp.numEmpleado });
                parameters.Add(new SqlParameter() { ParameterName = "Nombre", Value = objH_Valores_X_Emp.Nombre });
                parameters.Add(new SqlParameter() { ParameterName = "Fecha", Value = objH_Valores_X_Emp.Fecha });
                parameters.Add(new SqlParameter() { ParameterName = "Valor", Value = objH_Valores_X_Emp.Valor });

                using (dataReader = this.connection.ExcuteSP("prc_H_Valores_X_Emp_Update_SoluGlob", parameters))
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            h_valores_x_emp.Compania = dataReader.IsDBNull(dataReader.GetOrdinal("Compania")) ? null : dataReader["Compania"].ToString();
                            h_valores_x_emp.numEmpleado = dataReader.IsDBNull(dataReader.GetOrdinal("Empleado")) ? null : dataReader["Empleado"].ToString();
                            h_valores_x_emp.Nombre = dataReader.IsDBNull(dataReader.GetOrdinal("Nombre")) ? null : dataReader["Nombre"].ToString();
                            h_valores_x_emp.Fecha = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha")) ? default(DateTime) : DateTime.Parse(dataReader["Fecha"].ToString());
                            h_valores_x_emp.Valor = dataReader.IsDBNull(dataReader.GetOrdinal("Valor")) ? null : dataReader["Valor"].ToString();
                        }
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }

                return h_valores_x_emp;
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

                this.connection.ExcuteScalar("prc_H_Valores_X_Emp_Delete_SoluGlob", parameters);
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

                this.connection.ExcuteScalar("prc_H_Valores_X_Emp_Drop_SoluGlob", parameters);
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message);
            }
        }

        public void DropLast(Entities.Kaizen.Empleados.H_Valores_X_Emp objH_Valores_X_Emp)
        {
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter() { ParameterName = "Compania", Value = objH_Valores_X_Emp.Compania });
                parameters.Add(new SqlParameter() { ParameterName = "Empleado", Value = objH_Valores_X_Emp.numEmpleado });
                parameters.Add(new SqlParameter() { ParameterName = "CompaniaPasajes", Value = objH_Valores_X_Emp.companiaPasajes });
                parameters.Add(new SqlParameter() { ParameterName = "Nombre", Value = objH_Valores_X_Emp.Nombre });

                this.connection.ExcuteScalar("prc_H_Valores_X_Emp_DropLast_SoluGlob", parameters);
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message);
            }
        }

        public Entities.Kaizen.Empleados.H_Valores_X_Emp UpdateCeco(Entities.Kaizen.Empleados.H_Valores_X_Emp objH_Valores_X_Emp)
        {
            h_valores_x_emp = new Entities.Kaizen.Empleados.H_Valores_X_Emp();
            //StringBuilder sb = new StringBuilder();
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                parameters.Add(new SqlParameter() { ParameterName = "Compania", Value = objH_Valores_X_Emp.Compania });
                parameters.Add(new SqlParameter() { ParameterName = "Empleado", Value = objH_Valores_X_Emp.numEmpleado });
                parameters.Add(new SqlParameter() { ParameterName = "CompaniaPasajes", Value = objH_Valores_X_Emp.companiaPasajes });
                parameters.Add(new SqlParameter() { ParameterName = "Valor", Value = objH_Valores_X_Emp.Valor });

                using (dataReader = this.connection.ExcuteSP("prc_H_Valores_X_Emp_UpdateCeco_Soluglob", parameters))
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            h_valores_x_emp.Compania = dataReader.IsDBNull(dataReader.GetOrdinal("Compania")) ? null : dataReader["Compania"].ToString();
                            h_valores_x_emp.numEmpleado = dataReader.IsDBNull(dataReader.GetOrdinal("Empleado")) ? null : dataReader["Empleado"].ToString();
                            h_valores_x_emp.Nombre = dataReader.IsDBNull(dataReader.GetOrdinal("Nombre")) ? null : dataReader["Nombre"].ToString();
                            h_valores_x_emp.Fecha = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha")) ? default(DateTime) : DateTime.Parse(dataReader["Fecha"].ToString());
                            h_valores_x_emp.Valor = dataReader.IsDBNull(dataReader.GetOrdinal("Valor")) ? null : dataReader["Valor"].ToString();
                        }
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }

                return h_valores_x_emp;
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message.ToString());
            }
        }

        public Entities.Kaizen.Empleados.H_Valores_X_Emp UpdateUCo(Entities.Kaizen.Empleados.H_Valores_X_Emp objH_Valores_X_Emp)
        {
            h_valores_x_emp = new Entities.Kaizen.Empleados.H_Valores_X_Emp();
            //StringBuilder sb = new StringBuilder();
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                parameters.Add(new SqlParameter() { ParameterName = "Compania", Value = objH_Valores_X_Emp.Compania });
                parameters.Add(new SqlParameter() { ParameterName = "Empleado", Value = objH_Valores_X_Emp.numEmpleado });
                parameters.Add(new SqlParameter() { ParameterName = "CompaniaPasajes", Value = objH_Valores_X_Emp.companiaPasajes });
                parameters.Add(new SqlParameter() { ParameterName = "Valor", Value = objH_Valores_X_Emp.Valor });

                using (dataReader = this.connection.ExcuteSP("prc_H_Valores_X_Emp_UpdateUCo_Soluglob", parameters))
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            h_valores_x_emp.Compania = dataReader.IsDBNull(dataReader.GetOrdinal("Compania")) ? null : dataReader["Compania"].ToString();
                            h_valores_x_emp.numEmpleado = dataReader.IsDBNull(dataReader.GetOrdinal("Empleado")) ? null : dataReader["Empleado"].ToString();
                            h_valores_x_emp.Nombre = dataReader.IsDBNull(dataReader.GetOrdinal("Nombre")) ? null : dataReader["Nombre"].ToString();
                            h_valores_x_emp.Fecha = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha")) ? default(DateTime) : DateTime.Parse(dataReader["Fecha"].ToString());
                            h_valores_x_emp.Valor = dataReader.IsDBNull(dataReader.GetOrdinal("Valor")) ? null : dataReader["Valor"].ToString();
                        }
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }

                return h_valores_x_emp;
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message.ToString());
            }
        }

        public Entities.Kaizen.Empleados.H_Valores_X_Emp GetOneByNombre(string Compania, string NumEmpleado, string Nombre)
        {
            h_valores_x_emp = new Entities.Kaizen.Empleados.H_Valores_X_Emp();

            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter() { ParameterName = "compania", Value = Compania });
                parameters.Add(new SqlParameter() { ParameterName = "empleado", Value = NumEmpleado });
                parameters.Add(new SqlParameter() { ParameterName = "nombre", Value = Nombre });

                using (dataReader = this.connection.ExcuteSP("prc_H_Valores_X_Emp_GetOneByNombre_SoluGlob", parameters))
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            h_valores_x_emp.Compania = dataReader.IsDBNull(dataReader.GetOrdinal("Compania")) ? null : dataReader["Compania"].ToString();
                            h_valores_x_emp.numEmpleado = dataReader.IsDBNull(dataReader.GetOrdinal("Empleado")) ? null : dataReader["Empleado"].ToString();
                            h_valores_x_emp.Nombre = dataReader.IsDBNull(dataReader.GetOrdinal("Nombre")) ? null : dataReader["Nombre"].ToString();
                            h_valores_x_emp.Fecha = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha")) ? default(DateTime) : DateTime.Parse(dataReader["Fecha"].ToString());
                            h_valores_x_emp.Valor = dataReader.IsDBNull(dataReader.GetOrdinal("Valor")) ? null : dataReader["Valor"].ToString();
                        }
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }

                return h_valores_x_emp;
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
