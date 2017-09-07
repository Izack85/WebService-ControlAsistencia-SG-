using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities = Integra.Services.Entities;

namespace Integra.Services.Data.SoluglobChecador
{
    public class Horarios
    {
        List<Entities.SoluglobChecador.Horarios> horariosCollection = null;
        Entities.SoluglobChecador.Horarios horarios = null;
        SqlDataReader dataReader = null;

        public Connection connection = null;

        public Horarios()
        {
            this.connection = Connection.Instance;
        }
        public Horarios(bool isTransaction)
        {
            this.connection = new Connection();
        }
        public Horarios(Connection connection)
        {
            this.connection = connection;
        }

        public Entities.SoluglobChecador.Horarios Insert(Entities.SoluglobChecador.Horarios objHorarios)
        {
            horarios = new Entities.SoluglobChecador.Horarios();
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter() { ParameterName = "Numero_Nomina", Value = objHorarios.Numero_Nomina });
                parameters.Add(new SqlParameter() { ParameterName = "Lunes_Entrada", Value = objHorarios.Lunes_Entrada });
                parameters.Add(new SqlParameter() { ParameterName = "Lunes_Salida", Value = objHorarios.Lunes_Salida });
                parameters.Add(new SqlParameter() { ParameterName = "Martes_Entrada", Value = objHorarios.Martes_Entrada });
                parameters.Add(new SqlParameter() { ParameterName = "Martes_Salida", Value = objHorarios.Martes_Salida });
                parameters.Add(new SqlParameter() { ParameterName = "Miercoles_Entrada", Value = objHorarios.Miercoles_Entrada });
                parameters.Add(new SqlParameter() { ParameterName = "Miercoles_Salida", Value = objHorarios.Miercoles_Salida });
                parameters.Add(new SqlParameter() { ParameterName = "Jueves_Entrada", Value = objHorarios.Jueves_Entrada });
                parameters.Add(new SqlParameter() { ParameterName = "Jueves_Salida", Value = objHorarios.Jueves_Salida });
                parameters.Add(new SqlParameter() { ParameterName = "Viernes_Entrada", Value = objHorarios.Viernes_Entrada });
                parameters.Add(new SqlParameter() { ParameterName = "Viernes_Salida", Value = objHorarios.Viernes_Salida });
                parameters.Add(new SqlParameter() { ParameterName = "Sabado_Entrada", Value = objHorarios.Sabado_Entrada });
                parameters.Add(new SqlParameter() { ParameterName = "Sabado_Salida", Value = objHorarios.Sabado_Salida });
                parameters.Add(new SqlParameter() { ParameterName = "Domingo_Entrada", Value = objHorarios.Domingo_Entrada });
                parameters.Add(new SqlParameter() { ParameterName = "Domingo_Salida", Value = objHorarios.Domingo_Salida });
                parameters.Add(new SqlParameter() { ParameterName = "Fecha_Modificacion", Value = objHorarios.Fecha_Modificacion });
                parameters.Add(new SqlParameter() { ParameterName = "msrepl_tran_version", Value = objHorarios.msrepl_tran_version });
                parameters.Add(new SqlParameter() { ParameterName = "Estatus", Value = objHorarios.Estatus });
                using (dataReader = this.connection.ExcuteSP("prc_Horarios_Insert", parameters))
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            horarios.Numero_Nomina = dataReader.IsDBNull(dataReader.GetOrdinal("Numero_Nomina")) ? default(int) : int.Parse(dataReader["Numero_Nomina"].ToString());
                            horarios.Lunes_Entrada = dataReader.IsDBNull(dataReader.GetOrdinal("Lunes_Entrada")) ? null : dataReader["Lunes_Entrada"].ToString();
                            horarios.Lunes_Salida = dataReader.IsDBNull(dataReader.GetOrdinal("Lunes_Salida")) ? null : dataReader["Lunes_Salida"].ToString();
                            horarios.Martes_Entrada = dataReader.IsDBNull(dataReader.GetOrdinal("Martes_Entrada")) ? null : dataReader["Martes_Entrada"].ToString();
                            horarios.Martes_Salida = dataReader.IsDBNull(dataReader.GetOrdinal("Martes_Salida")) ? null : dataReader["Martes_Salida"].ToString();
                            horarios.Miercoles_Entrada = dataReader.IsDBNull(dataReader.GetOrdinal("Miercoles_Entrada")) ? null : dataReader["Miercoles_Entrada"].ToString();
                            horarios.Miercoles_Salida = dataReader.IsDBNull(dataReader.GetOrdinal("Miercoles_Salida")) ? null : dataReader["Miercoles_Salida"].ToString();
                            horarios.Jueves_Entrada = dataReader.IsDBNull(dataReader.GetOrdinal("Jueves_Entrada")) ? null : dataReader["Jueves_Entrada"].ToString();
                            horarios.Jueves_Salida = dataReader.IsDBNull(dataReader.GetOrdinal("Jueves_Salida")) ? null : dataReader["Jueves_Salida"].ToString();
                            horarios.Viernes_Entrada = dataReader.IsDBNull(dataReader.GetOrdinal("Viernes_Entrada")) ? null : dataReader["Viernes_Entrada"].ToString();
                            horarios.Viernes_Salida = dataReader.IsDBNull(dataReader.GetOrdinal("Viernes_Salida")) ? null : dataReader["Viernes_Salida"].ToString();
                            horarios.Sabado_Entrada = dataReader.IsDBNull(dataReader.GetOrdinal("Sabado_Entrada")) ? null : dataReader["Sabado_Entrada"].ToString();
                            horarios.Sabado_Salida = dataReader.IsDBNull(dataReader.GetOrdinal("Sabado_Salida")) ? null : dataReader["Sabado_Salida"].ToString();
                            horarios.Domingo_Entrada = dataReader.IsDBNull(dataReader.GetOrdinal("Domingo_Entrada")) ? null : dataReader["Domingo_Entrada"].ToString();
                            horarios.Domingo_Salida = dataReader.IsDBNull(dataReader.GetOrdinal("Domingo_Salida")) ? null : dataReader["Domingo_Salida"].ToString();
                            horarios.Fecha_Modificacion = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Modificacion")) ? null : dataReader["Fecha_Modificacion"].ToString();
                            horarios.msrepl_tran_version = dataReader.IsDBNull(dataReader.GetOrdinal("msrepl_tran_version")) ? default(Guid) : Guid.Parse(dataReader["msrepl_tran_version"].ToString());

                        }
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }

                return horarios;
            }
            catch(Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message.ToString());
            }
        }

        public Entities.SoluglobChecador.Horarios GetOne(int NumNomina)
        {
            horarios = new Entities.SoluglobChecador.Horarios();
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter() { ParameterName = "Numero_Nomina", Value = NumNomina });

                using (dataReader = this.connection.ExcuteSP("prc_Horarios_GetOne", parameters))
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            horarios.Numero_Nomina = dataReader.IsDBNull(dataReader.GetOrdinal("Numero_Nomina")) ? default(int) : int.Parse(dataReader["Numero_Nomina"].ToString());
                            horarios.Lunes_Entrada = dataReader.IsDBNull(dataReader.GetOrdinal("Lunes_Entrada")) ? null : dataReader["Lunes_Entrada"].ToString();
                            horarios.Lunes_Salida = dataReader.IsDBNull(dataReader.GetOrdinal("Lunes_Salida")) ? null : dataReader["Lunes_Salida"].ToString();
                            horarios.Martes_Entrada = dataReader.IsDBNull(dataReader.GetOrdinal("Martes_Entrada")) ? null : dataReader["Martes_Entrada"].ToString();
                            horarios.Martes_Salida = dataReader.IsDBNull(dataReader.GetOrdinal("Martes_Salida")) ? null : dataReader["Martes_Salida"].ToString();
                            horarios.Miercoles_Entrada = dataReader.IsDBNull(dataReader.GetOrdinal("Miercoles_Entrada")) ? null : dataReader["Miercoles_Entrada"].ToString();
                            horarios.Miercoles_Salida = dataReader.IsDBNull(dataReader.GetOrdinal("Miercoles_Salida")) ? null : dataReader["Miercoles_Salida"].ToString();
                            horarios.Jueves_Entrada = dataReader.IsDBNull(dataReader.GetOrdinal("Jueves_Entrada")) ? null : dataReader["Jueves_Entrada"].ToString();
                            horarios.Jueves_Salida = dataReader.IsDBNull(dataReader.GetOrdinal("Jueves_Salida")) ? null : dataReader["Jueves_Salida"].ToString();
                            horarios.Viernes_Entrada = dataReader.IsDBNull(dataReader.GetOrdinal("Viernes_Entrada")) ? null : dataReader["Viernes_Entrada"].ToString();
                            horarios.Viernes_Salida = dataReader.IsDBNull(dataReader.GetOrdinal("Viernes_Salida")) ? null : dataReader["Viernes_Salida"].ToString();
                            horarios.Sabado_Entrada = dataReader.IsDBNull(dataReader.GetOrdinal("Sabado_Entrada")) ? null : dataReader["Sabado_Entrada"].ToString();
                            horarios.Sabado_Salida = dataReader.IsDBNull(dataReader.GetOrdinal("Sabado_Salida")) ? null : dataReader["Sabado_Salida"].ToString();
                            horarios.Domingo_Entrada = dataReader.IsDBNull(dataReader.GetOrdinal("Domingo_Entrada")) ? null : dataReader["Domingo_Entrada"].ToString();
                            horarios.Domingo_Salida = dataReader.IsDBNull(dataReader.GetOrdinal("Domingo_Salida")) ? null : dataReader["Domingo_Salida"].ToString();
                            horarios.Fecha_Modificacion = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Modificacion")) ? null : dataReader["Fecha_Modificacion"].ToString();
                            horarios.msrepl_tran_version = dataReader.IsDBNull(dataReader.GetOrdinal("msrepl_tran_version")) ? default(Guid) : Guid.Parse(dataReader["msrepl_tran_version"].ToString());

                        }
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }

                return horarios;
            }
            catch(Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message.ToString());
            }
        }

        public List<Entities.SoluglobChecador.Horarios> GetAll()
        {
            horariosCollection = new List<Entities.SoluglobChecador.Horarios>();
            try
            {
                dataReader = this.connection.ExcuteSP("prc_Horarios_GetALL", null);

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        horarios = new Entities.SoluglobChecador.Horarios();
                        horarios.Numero_Nomina = dataReader.IsDBNull(dataReader.GetOrdinal("Numero_Nomina")) ? default(int) : int.Parse(dataReader["Numero_Nomina"].ToString());
                        horarios.Lunes_Entrada = dataReader.IsDBNull(dataReader.GetOrdinal("Lunes_Entrada")) ? null : dataReader["Lunes_Entrada"].ToString();
                        horarios.Lunes_Salida = dataReader.IsDBNull(dataReader.GetOrdinal("Lunes_Salida")) ? null : dataReader["Lunes_Salida"].ToString();
                        horarios.Martes_Entrada = dataReader.IsDBNull(dataReader.GetOrdinal("Martes_Entrada")) ? null : dataReader["Martes_Entrada"].ToString();
                        horarios.Martes_Salida = dataReader.IsDBNull(dataReader.GetOrdinal("Martes_Salida")) ? null : dataReader["Martes_Salida"].ToString();
                        horarios.Miercoles_Entrada = dataReader.IsDBNull(dataReader.GetOrdinal("Miercoles_Entrada")) ? null : dataReader["Miercoles_Entrada"].ToString();
                        horarios.Miercoles_Salida = dataReader.IsDBNull(dataReader.GetOrdinal("Miercoles_Salida")) ? null : dataReader["Miercoles_Salida"].ToString();
                        horarios.Jueves_Entrada = dataReader.IsDBNull(dataReader.GetOrdinal("Jueves_Entrada")) ? null : dataReader["Jueves_Entrada"].ToString();
                        horarios.Jueves_Salida = dataReader.IsDBNull(dataReader.GetOrdinal("Jueves_Salida")) ? null : dataReader["Jueves_Salida"].ToString();
                        horarios.Viernes_Entrada = dataReader.IsDBNull(dataReader.GetOrdinal("Viernes_Entrada")) ? null : dataReader["Viernes_Entrada"].ToString();
                        horarios.Viernes_Salida = dataReader.IsDBNull(dataReader.GetOrdinal("Viernes_Salida")) ? null : dataReader["Viernes_Salida"].ToString();
                        horarios.Sabado_Entrada = dataReader.IsDBNull(dataReader.GetOrdinal("Sabado_Entrada")) ? null : dataReader["Sabado_Entrada"].ToString();
                        horarios.Sabado_Salida = dataReader.IsDBNull(dataReader.GetOrdinal("Sabado_Salida")) ? null : dataReader["Sabado_Salida"].ToString();
                        horarios.Domingo_Entrada = dataReader.IsDBNull(dataReader.GetOrdinal("Domingo_Entrada")) ? null : dataReader["Domingo_Entrada"].ToString();
                        horarios.Domingo_Salida = dataReader.IsDBNull(dataReader.GetOrdinal("Domingo_Salida")) ? null : dataReader["Domingo_Salida"].ToString();
                        horarios.Fecha_Modificacion = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Modificacion")) ? null : dataReader["Fecha_Modificacion"].ToString();
                        horarios.msrepl_tran_version = dataReader.IsDBNull(dataReader.GetOrdinal("msrepl_tran_version")) ? default(Guid) : Guid.Parse(dataReader["msrepl_tran_version"].ToString());
                        horariosCollection.Add(horarios);

                    }
                }
                dataReader.Close();
                dataReader.Dispose();

                return horariosCollection;

            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message.ToString());
            }            
        }

        public Entities.SoluglobChecador.Horarios Update(Entities.SoluglobChecador.Horarios objHorarios)
        {
            horarios = new Entities.SoluglobChecador.Horarios();
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter() { ParameterName = "Numero_Nomina", Value = objHorarios.Numero_Nomina });
                parameters.Add(new SqlParameter() { ParameterName = "Lunes_Entrada", Value = objHorarios.Lunes_Entrada });
                parameters.Add(new SqlParameter() { ParameterName = "Lunes_Salida", Value = objHorarios.Lunes_Salida });
                parameters.Add(new SqlParameter() { ParameterName = "Martes_Entrada", Value = objHorarios.Martes_Entrada });
                parameters.Add(new SqlParameter() { ParameterName = "Martes_Salida", Value = objHorarios.Martes_Salida });
                parameters.Add(new SqlParameter() { ParameterName = "Miercoles_Entrada", Value = objHorarios.Miercoles_Entrada });
                parameters.Add(new SqlParameter() { ParameterName = "Miercoles_Salida", Value = objHorarios.Miercoles_Salida });
                parameters.Add(new SqlParameter() { ParameterName = "Jueves_Entrada", Value = objHorarios.Jueves_Entrada });
                parameters.Add(new SqlParameter() { ParameterName = "Jueves_Salida", Value = objHorarios.Jueves_Salida });
                parameters.Add(new SqlParameter() { ParameterName = "Viernes_Entrada", Value = objHorarios.Viernes_Entrada });
                parameters.Add(new SqlParameter() { ParameterName = "Viernes_Salida", Value = objHorarios.Viernes_Salida });
                parameters.Add(new SqlParameter() { ParameterName = "Sabado_Entrada", Value = objHorarios.Sabado_Entrada });
                parameters.Add(new SqlParameter() { ParameterName = "Sabado_Salida", Value = objHorarios.Sabado_Salida });
                parameters.Add(new SqlParameter() { ParameterName = "Domingo_Entrada", Value = objHorarios.Domingo_Entrada });
                parameters.Add(new SqlParameter() { ParameterName = "Domingo_Salida", Value = objHorarios.Domingo_Salida });
                parameters.Add(new SqlParameter() { ParameterName = "msrepl_tran_version", Value = objHorarios.msrepl_tran_version });

                using (dataReader = this.connection.ExcuteSP("prc_Horarios_Update", parameters))
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            horarios.Numero_Nomina = dataReader.IsDBNull(dataReader.GetOrdinal("Numero_Nomina")) ? default(int) : int.Parse(dataReader["Numero_Nomina"].ToString());
                            horarios.Lunes_Entrada = dataReader.IsDBNull(dataReader.GetOrdinal("Lunes_Entrada")) ? null : dataReader["Lunes_Entrada"].ToString();
                            horarios.Lunes_Salida = dataReader.IsDBNull(dataReader.GetOrdinal("Lunes_Salida")) ? null : dataReader["Lunes_Salida"].ToString();
                            horarios.Martes_Entrada = dataReader.IsDBNull(dataReader.GetOrdinal("Martes_Entrada")) ? null : dataReader["Martes_Entrada"].ToString();
                            horarios.Martes_Salida = dataReader.IsDBNull(dataReader.GetOrdinal("Martes_Salida")) ? null : dataReader["Martes_Salida"].ToString();
                            horarios.Miercoles_Entrada = dataReader.IsDBNull(dataReader.GetOrdinal("Miercoles_Entrada")) ? null : dataReader["Miercoles_Entrada"].ToString();
                            horarios.Miercoles_Salida = dataReader.IsDBNull(dataReader.GetOrdinal("Miercoles_Salida")) ? null : dataReader["Miercoles_Salida"].ToString();
                            horarios.Jueves_Entrada = dataReader.IsDBNull(dataReader.GetOrdinal("Jueves_Entrada")) ? null : dataReader["Jueves_Entrada"].ToString();
                            horarios.Jueves_Salida = dataReader.IsDBNull(dataReader.GetOrdinal("Jueves_Salida")) ? null : dataReader["Jueves_Salida"].ToString();
                            horarios.Viernes_Entrada = dataReader.IsDBNull(dataReader.GetOrdinal("Viernes_Entrada")) ? null : dataReader["Viernes_Entrada"].ToString();
                            horarios.Viernes_Salida = dataReader.IsDBNull(dataReader.GetOrdinal("Viernes_Salida")) ? null : dataReader["Viernes_Salida"].ToString();
                            horarios.Sabado_Entrada = dataReader.IsDBNull(dataReader.GetOrdinal("Sabado_Entrada")) ? null : dataReader["Sabado_Entrada"].ToString();
                            horarios.Sabado_Salida = dataReader.IsDBNull(dataReader.GetOrdinal("Sabado_Salida")) ? null : dataReader["Sabado_Salida"].ToString();
                            horarios.Domingo_Entrada = dataReader.IsDBNull(dataReader.GetOrdinal("Domingo_Entrada")) ? null : dataReader["Domingo_Entrada"].ToString();
                            horarios.Domingo_Salida = dataReader.IsDBNull(dataReader.GetOrdinal("Domingo_Salida")) ? null : dataReader["Domingo_Salida"].ToString();
                            horarios.Fecha_Modificacion = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Modificacion")) ? null : dataReader["Fecha_Modificacion"].ToString();
                            horarios.msrepl_tran_version = dataReader.IsDBNull(dataReader.GetOrdinal("msrepl_tran_version")) ? default(Guid) : Guid.Parse(dataReader["msrepl_tran_version"].ToString());

                        }
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }

                return horarios;
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message.ToString());
            }
        }

        public void Delete(int NumNomina, int Estatus)
        {
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter() { ParameterName = "Numero_Nomina", Value = NumNomina });
                parameters.Add(new SqlParameter() { ParameterName = "Estatus", Value = Estatus });
                this.connection.ExcuteScalar("prc_Horarios_Delete", parameters);
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message);
            }

        }
        #region Inicia Drop
        public void Drop(int NumNomina)
        {
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter() { ParameterName = "Numero_Nomina", Value = NumNomina });

                this.connection.ExcuteScalar("prc_Horarios_Drop", parameters);
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message);
            }
        }
        #endregion Inicia Drop
    }
}
