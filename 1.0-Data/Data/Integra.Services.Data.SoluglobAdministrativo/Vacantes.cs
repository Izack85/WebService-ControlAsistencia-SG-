using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities = Integra.Services.Entities;

namespace Integra.Services.Data.SoluglobAdministrativo
{
    public class Vacantes
    {
        List<Entities.SoluglobAdministrativo.Vacantes> vacantesCollection = null;
        Entities.SoluglobAdministrativo.Vacantes vacantes = null;
        SqlDataReader dataReader = null;

        public Connection connection = null;

        public Vacantes()
        {
            this.connection = Connection.Instance;
        }
        public Vacantes(bool isTransaction)
        {
            this.connection = new Connection();
        }
        public Vacantes(Connection connection)
        {
            this.connection = connection;
        }

        public Entities.SoluglobAdministrativo.Vacantes Insert(Entities.SoluglobAdministrativo.Vacantes objVacantes)
        {
            vacantes = new Entities.SoluglobAdministrativo.Vacantes();
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter() { ParameterName = "Id_Vac", Value = objVacantes.Id_Vac });
                parameters.Add(new SqlParameter() { ParameterName = "Id_Per", Value = objVacantes.Id_Per });
                parameters.Add(new SqlParameter() { ParameterName = "Desc_Vacante", Value = objVacantes.Desc_Vacante });
                parameters.Add(new SqlParameter() { ParameterName = "CeCo", Value = objVacantes.CeCo });
                parameters.Add(new SqlParameter() { ParameterName = "UCos", Value = objVacantes.UCos });
                parameters.Add(new SqlParameter() { ParameterName = "Ubicacion", Value = objVacantes.Ubicacion });
                parameters.Add(new SqlParameter() { ParameterName = "Estatus_Vacante", Value = objVacantes.Estatus_Vacante });
                parameters.Add(new SqlParameter() { ParameterName = "Segmento", Value = objVacantes.Segmento });
                parameters.Add(new SqlParameter() { ParameterName = "Gerencia", Value = objVacantes.Gerencia });
                parameters.Add(new SqlParameter() { ParameterName = "Puesto", Value = objVacantes.Puesto });
                parameters.Add(new SqlParameter() { ParameterName = "Verificacion", Value = objVacantes.Verificacion });
                parameters.Add(new SqlParameter() { ParameterName = "Depto", Value = objVacantes.Depto });
                parameters.Add(new SqlParameter() { ParameterName = "User_Mod", Value = objVacantes.User_Mod });
                parameters.Add(new SqlParameter() { ParameterName = "FecMod", Value = objVacantes.FecMod });
                parameters.Add(new SqlParameter() { ParameterName = "Transicion", Value = objVacantes.Transicion });
                parameters.Add(new SqlParameter() { ParameterName = "Prioridad", Value = objVacantes.Prioridad });

                using (dataReader = this.connection.ExcuteSP("prc_Vacantes_Insert", parameters))
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            vacantes.Id_Vac = dataReader.IsDBNull(dataReader.GetOrdinal("Id_Vac")) ? default(int) : int.Parse(dataReader["Id_Vac"].ToString());
                            vacantes.Id_Per = dataReader.IsDBNull(dataReader.GetOrdinal("Id_Per")) ? default(int?) : int.Parse(dataReader["Id_Per"].ToString());
                            vacantes.Desc_Vacante = dataReader.IsDBNull(dataReader.GetOrdinal("Desc_Vacante")) ? null : dataReader["Desc_Vacante"].ToString();
                            vacantes.CeCo = dataReader.IsDBNull(dataReader.GetOrdinal("CeCo")) ? default(int?) : int.Parse(dataReader["CeCo"].ToString());
                            vacantes.UCos = dataReader.IsDBNull(dataReader.GetOrdinal("UCos")) ? null : dataReader["UCos"].ToString();
                            vacantes.Ubicacion = dataReader.IsDBNull(dataReader.GetOrdinal("Ubicacion")) ? null : dataReader["Ubicacion"].ToString();
                            vacantes.Estatus_Vacante = dataReader.IsDBNull(dataReader.GetOrdinal("Estatus_Vacante")) ? default(int) : int.Parse(dataReader["Estatus_Vacante"].ToString());
                            vacantes.Segmento = dataReader.IsDBNull(dataReader.GetOrdinal("Segmento")) ? default(int?) : int.Parse(dataReader["Segmento"].ToString());
                            vacantes.Gerencia = dataReader.IsDBNull(dataReader.GetOrdinal("Gerencia")) ? default(int?) : int.Parse(dataReader["Gerencia"].ToString());
                            vacantes.Puesto = dataReader.IsDBNull(dataReader.GetOrdinal("Puesto")) ? default(int?) : int.Parse(dataReader["Puesto"].ToString());
                            vacantes.Verificacion = dataReader.IsDBNull(dataReader.GetOrdinal("Verificacion")) ? null : dataReader["Verificacion"].ToString();
                            vacantes.Depto = dataReader.IsDBNull(dataReader.GetOrdinal("Depto")) ? null : dataReader["Depto"].ToString();
                            vacantes.User_Mod = dataReader.IsDBNull(dataReader.GetOrdinal("User_Mod")) ? default(int?) : int.Parse(dataReader["User_Mod"].ToString());
                            vacantes.FecMod = dataReader.IsDBNull(dataReader.GetOrdinal("FecMod")) ? default(DateTime) : DateTime.Parse(dataReader["FecMod"].ToString());
                            vacantes.Transicion = dataReader.IsDBNull(dataReader.GetOrdinal("Transicion")) ? default(int?) : int.Parse(dataReader["Transicion"].ToString());
                            vacantes.Prioridad = dataReader.IsDBNull(dataReader.GetOrdinal("Prioridad")) ? default(int?) : int.Parse(dataReader["Prioridad"].ToString());
                        }
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }

                return vacantes;
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message.ToString());
            }
        }

        public Entities.SoluglobAdministrativo.Vacantes GetOne(int idVacante)
        {
            vacantes = new Entities.SoluglobAdministrativo.Vacantes();
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter() { ParameterName = "Id_Vac", Value = idVacante });

                using (dataReader = this.connection.ExcuteSP("prc_Vacantes_GetOne", parameters))
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            vacantes.Id_Vac = dataReader.IsDBNull(dataReader.GetOrdinal("Id_Vac")) ? default(int) : int.Parse(dataReader["Id_Vac"].ToString());
                            vacantes.Id_Per = dataReader.IsDBNull(dataReader.GetOrdinal("Id_Per")) ? default(int?) : int.Parse(dataReader["Id_Per"].ToString());
                            vacantes.Desc_Vacante = dataReader.IsDBNull(dataReader.GetOrdinal("Desc_Vacante")) ? null : dataReader["Desc_Vacante"].ToString();
                            vacantes.CeCo = dataReader.IsDBNull(dataReader.GetOrdinal("CeCo")) ? default(int?) : int.Parse(dataReader["CeCo"].ToString());
                            vacantes.UCos = dataReader.IsDBNull(dataReader.GetOrdinal("UCos")) ? null : dataReader["UCos"].ToString();
                            vacantes.Ubicacion = dataReader.IsDBNull(dataReader.GetOrdinal("Ubicacion")) ? null : dataReader["Ubicacion"].ToString();
                            vacantes.Estatus_Vacante = dataReader.IsDBNull(dataReader.GetOrdinal("Estatus_Vacante")) ? default(int) : int.Parse(dataReader["Estatus_Vacante"].ToString());
                            vacantes.Segmento = dataReader.IsDBNull(dataReader.GetOrdinal("Segmento")) ? default(int?) : int.Parse(dataReader["Segmento"].ToString());
                            vacantes.Gerencia = dataReader.IsDBNull(dataReader.GetOrdinal("Gerencia")) ? default(int?) : int.Parse(dataReader["Gerencia"].ToString());
                            vacantes.Puesto = dataReader.IsDBNull(dataReader.GetOrdinal("Puesto")) ? default(int?) : int.Parse(dataReader["Puesto"].ToString());
                            vacantes.Verificacion = dataReader.IsDBNull(dataReader.GetOrdinal("Verificacion")) ? null : dataReader["Verificacion"].ToString();
                            vacantes.Depto = dataReader.IsDBNull(dataReader.GetOrdinal("Depto")) ? null : dataReader["Depto"].ToString();
                            vacantes.User_Mod = dataReader.IsDBNull(dataReader.GetOrdinal("User_Mod")) ? default(int?) : int.Parse(dataReader["User_Mod"].ToString());
                            vacantes.FecMod = dataReader.IsDBNull(dataReader.GetOrdinal("FecMod")) ? default(DateTime?) : DateTime.Parse(dataReader["FecMod"].ToString());
                            vacantes.Transicion = dataReader.IsDBNull(dataReader.GetOrdinal("Transicion")) ? default(int?) : int.Parse(dataReader["Transicion"].ToString());
                            vacantes.Prioridad = dataReader.IsDBNull(dataReader.GetOrdinal("Prioridad")) ? default(int?) : int.Parse(dataReader["Prioridad"].ToString());
                        }
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }

                return vacantes;
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message.ToString());
            }
        }

        public List<Entities.SoluglobAdministrativo.Vacantes> GetAll()
        {
            vacantesCollection = new List<Entities.SoluglobAdministrativo.Vacantes>();
            try
            {
                dataReader = this.connection.ExcuteSP("prc_Vacantes_GetALL", null);

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        vacantes = new Entities.SoluglobAdministrativo.Vacantes();
                        vacantes.Id_Vac = dataReader.IsDBNull(dataReader.GetOrdinal("Id_Vac")) ? default(int) : int.Parse(dataReader["Id_Vac"].ToString());
                        vacantes.Id_Per = dataReader.IsDBNull(dataReader.GetOrdinal("Id_Per")) ? default(int?) : int.Parse(dataReader["Id_Per"].ToString());
                        vacantes.Desc_Vacante = dataReader.IsDBNull(dataReader.GetOrdinal("Desc_Vacante")) ? null : dataReader["Desc_Vacante"].ToString();
                        vacantes.CeCo = dataReader.IsDBNull(dataReader.GetOrdinal("CeCo")) ? default(int?) : int.Parse(dataReader["CeCo"].ToString());
                        vacantes.UCos = dataReader.IsDBNull(dataReader.GetOrdinal("UCos")) ? null : dataReader["UCos"].ToString();
                        vacantes.Ubicacion = dataReader.IsDBNull(dataReader.GetOrdinal("Ubicacion")) ? null : dataReader["Ubicacion"].ToString();
                        vacantes.Estatus_Vacante = dataReader.IsDBNull(dataReader.GetOrdinal("Estatus_Vacante")) ? default(int) : int.Parse(dataReader["Estatus_Vacante"].ToString());
                        vacantes.Segmento = dataReader.IsDBNull(dataReader.GetOrdinal("Segmento")) ? default(int?) : int.Parse(dataReader["Segmento"].ToString());
                        vacantes.Gerencia = dataReader.IsDBNull(dataReader.GetOrdinal("Gerencia")) ? default(int?) : int.Parse(dataReader["Gerencia"].ToString());
                        vacantes.Puesto = dataReader.IsDBNull(dataReader.GetOrdinal("Puesto")) ? default(int?) : int.Parse(dataReader["Puesto"].ToString());
                        vacantes.Verificacion = dataReader.IsDBNull(dataReader.GetOrdinal("Verificacion")) ? null : dataReader["Verificacion"].ToString();
                        vacantes.Depto = dataReader.IsDBNull(dataReader.GetOrdinal("Depto")) ? null : dataReader["Depto"].ToString();
                        vacantes.User_Mod = dataReader.IsDBNull(dataReader.GetOrdinal("User_Mod")) ? default(int?) : int.Parse(dataReader["User_Mod"].ToString());
                        vacantes.FecMod = dataReader.IsDBNull(dataReader.GetOrdinal("FecMod")) ? default(DateTime?) : DateTime.Parse(dataReader["FecMod"].ToString());
                        vacantes.Transicion = dataReader.IsDBNull(dataReader.GetOrdinal("Transicion")) ? default(int?) : int.Parse(dataReader["Transicion"].ToString());
                        vacantes.Prioridad = dataReader.IsDBNull(dataReader.GetOrdinal("Prioridad")) ? default(int?) : int.Parse(dataReader["Prioridad"].ToString());
                        vacantesCollection.Add(vacantes);

                    }
                }
                dataReader.Close();
                dataReader.Dispose();

                return vacantesCollection;

            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message.ToString());
            }
        }

        public Entities.SoluglobAdministrativo.Vacantes Update(Entities.SoluglobAdministrativo.Vacantes objVacantes)
        {
            vacantes = new Entities.SoluglobAdministrativo.Vacantes();
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter() { ParameterName = "Id_Vac", Value = objVacantes.Id_Vac });
                parameters.Add(new SqlParameter() { ParameterName = "Id_Per", Value = objVacantes.Id_Per });
                parameters.Add(new SqlParameter() { ParameterName = "Desc_Vacante", Value = objVacantes.Desc_Vacante });
                parameters.Add(new SqlParameter() { ParameterName = "CeCo", Value = objVacantes.CeCo });
                parameters.Add(new SqlParameter() { ParameterName = "UCos", Value = objVacantes.UCos });
                parameters.Add(new SqlParameter() { ParameterName = "Ubicacion", Value = objVacantes.Ubicacion });
                parameters.Add(new SqlParameter() { ParameterName = "Estatus_Vacante", Value = objVacantes.Estatus_Vacante });
                parameters.Add(new SqlParameter() { ParameterName = "Segmento", Value = objVacantes.Segmento });
                parameters.Add(new SqlParameter() { ParameterName = "Gerencia", Value = objVacantes.Gerencia });
                parameters.Add(new SqlParameter() { ParameterName = "Puesto", Value = objVacantes.Puesto });
                parameters.Add(new SqlParameter() { ParameterName = "Verificacion", Value = objVacantes.Verificacion });
                parameters.Add(new SqlParameter() { ParameterName = "Depto", Value = objVacantes.Depto });
                parameters.Add(new SqlParameter() { ParameterName = "User_Mod", Value = objVacantes.User_Mod });
                parameters.Add(new SqlParameter() { ParameterName = "FecMod", Value = objVacantes.FecMod });
                parameters.Add(new SqlParameter() { ParameterName = "Transicion", Value = objVacantes.Transicion });
                parameters.Add(new SqlParameter() { ParameterName = "Prioridad", Value = objVacantes.Prioridad });

                using (dataReader = this.connection.ExcuteSP("prc_Vacantes_Update", parameters))
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            vacantes.Id_Vac = dataReader.IsDBNull(dataReader.GetOrdinal("Id_Vac")) ? default(int) : int.Parse(dataReader["Id_Vac"].ToString());
                            vacantes.Id_Per = dataReader.IsDBNull(dataReader.GetOrdinal("Id_Per")) ? default(int?) : int.Parse(dataReader["Id_Per"].ToString());
                            vacantes.Desc_Vacante = dataReader.IsDBNull(dataReader.GetOrdinal("Desc_Vacante")) ? null : dataReader["Desc_Vacante"].ToString();
                            vacantes.CeCo = dataReader.IsDBNull(dataReader.GetOrdinal("CeCo")) ? default(int?) : int.Parse(dataReader["CeCo"].ToString());
                            vacantes.UCos = dataReader.IsDBNull(dataReader.GetOrdinal("UCos")) ? null : dataReader["UCos"].ToString();
                            vacantes.Ubicacion = dataReader.IsDBNull(dataReader.GetOrdinal("Ubicacion")) ? null : dataReader["Ubicacion"].ToString();
                            vacantes.Estatus_Vacante = dataReader.IsDBNull(dataReader.GetOrdinal("Estatus_Vacante")) ? default(int) : int.Parse(dataReader["Estatus_Vacante"].ToString());
                            vacantes.Segmento = dataReader.IsDBNull(dataReader.GetOrdinal("Segmento")) ? default(int?) : int.Parse(dataReader["Segmento"].ToString());
                            vacantes.Gerencia = dataReader.IsDBNull(dataReader.GetOrdinal("Gerencia")) ? default(int?) : int.Parse(dataReader["Gerencia"].ToString());
                            vacantes.Puesto = dataReader.IsDBNull(dataReader.GetOrdinal("Puesto")) ? default(int?) : int.Parse(dataReader["Puesto"].ToString());
                            vacantes.Verificacion = dataReader.IsDBNull(dataReader.GetOrdinal("Verificacion")) ? null : dataReader["Verificacion"].ToString();
                            vacantes.Depto = dataReader.IsDBNull(dataReader.GetOrdinal("Depto")) ? null : dataReader["Depto"].ToString();
                            vacantes.User_Mod = dataReader.IsDBNull(dataReader.GetOrdinal("User_Mod")) ? default(int?) : int.Parse(dataReader["User_Mod"].ToString());
                            vacantes.FecMod = dataReader.IsDBNull(dataReader.GetOrdinal("FecMod")) ? default(DateTime?) : DateTime.Parse(dataReader["FecMod"].ToString());
                            vacantes.Transicion = dataReader.IsDBNull(dataReader.GetOrdinal("Transicion")) ? default(int?) : int.Parse(dataReader["Transicion"].ToString());
                            vacantes.Prioridad = dataReader.IsDBNull(dataReader.GetOrdinal("Prioridad")) ? default(int?) : int.Parse(dataReader["Prioridad"].ToString());

                        }
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }

                return vacantes;
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message.ToString());
            }
        }

        public void Delete(int idVacante)
        {
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter() { ParameterName = "Id_Vac", Value = idVacante });

                this.connection.ExcuteScalar("prc_Vacantes_Delete", parameters);

            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message);
            }

        }


        #region Inicia Drop
        public void Drop(int idVacante)
        {
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter() { ParameterName = "Id_Vac", Value = idVacante });

                this.connection.ExcuteScalar("prc_Vacantes_Drop", parameters);
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message);
            }
        }
        #endregion Inicia Drop
        #region Inicia Obtiene Max
        public int GetMaxId()
        {
            vacantes = new Entities.SoluglobAdministrativo.Vacantes();
            try
            {

                using (dataReader = this.connection.ExcuteSP("prc_Vacantes_GetMaxId", null))
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            vacantes.Id_Vac = dataReader.IsDBNull(dataReader.GetOrdinal("Id_Vac")) ? default(int) : int.Parse(dataReader["Id_Vac"].ToString());
                        }
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }

                return vacantes.Id_Vac;
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message.ToString());
            }
        }
        #endregion Inicia Obtiene Max

        public Entities.SoluglobAdministrativo.Vacantes GetOneByIdPer(int numEmpleado)
        {
            vacantes = new Entities.SoluglobAdministrativo.Vacantes();
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter() { ParameterName = "NumeroEmpleado", Value = numEmpleado });

                using (dataReader = this.connection.ExcuteSP("prc_Vacantes_GetOneByIdPer", parameters))
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            vacantes.Id_Vac = dataReader.IsDBNull(dataReader.GetOrdinal("Id_Vac")) ? default(int) : int.Parse(dataReader["Id_Vac"].ToString());
                            vacantes.Id_Per = dataReader.IsDBNull(dataReader.GetOrdinal("Id_Per")) ? default(int?) : int.Parse(dataReader["Id_Per"].ToString());
                            vacantes.Desc_Vacante = dataReader.IsDBNull(dataReader.GetOrdinal("Desc_Vacante")) ? null : dataReader["Desc_Vacante"].ToString();
                            vacantes.CeCo = dataReader.IsDBNull(dataReader.GetOrdinal("CeCo")) ? default(int?) : int.Parse(dataReader["CeCo"].ToString());
                            vacantes.UCos = dataReader.IsDBNull(dataReader.GetOrdinal("UCos")) ? null : dataReader["UCos"].ToString();
                            vacantes.Ubicacion = dataReader.IsDBNull(dataReader.GetOrdinal("Ubicacion")) ? null : dataReader["Ubicacion"].ToString();
                            vacantes.Estatus_Vacante = dataReader.IsDBNull(dataReader.GetOrdinal("Estatus_Vacante")) ? default(int) : int.Parse(dataReader["Estatus_Vacante"].ToString());
                            vacantes.Segmento = dataReader.IsDBNull(dataReader.GetOrdinal("Segmento")) ? default(int?) : int.Parse(dataReader["Segmento"].ToString());
                            vacantes.Gerencia = dataReader.IsDBNull(dataReader.GetOrdinal("Gerencia")) ? default(int?) : int.Parse(dataReader["Gerencia"].ToString());
                            vacantes.Puesto = dataReader.IsDBNull(dataReader.GetOrdinal("Puesto")) ? default(int?) : int.Parse(dataReader["Puesto"].ToString());
                            vacantes.Verificacion = dataReader.IsDBNull(dataReader.GetOrdinal("Verificacion")) ? null : dataReader["Verificacion"].ToString();
                            vacantes.Depto = dataReader.IsDBNull(dataReader.GetOrdinal("Depto")) ? null : dataReader["Depto"].ToString();
                            vacantes.User_Mod = dataReader.IsDBNull(dataReader.GetOrdinal("User_Mod")) ? default(int?) : int.Parse(dataReader["User_Mod"].ToString());
                            vacantes.FecMod = dataReader.IsDBNull(dataReader.GetOrdinal("FecMod")) ? default(DateTime?) : DateTime.Parse(dataReader["FecMod"].ToString());
                            vacantes.Transicion = dataReader.IsDBNull(dataReader.GetOrdinal("Transicion")) ? default(int?) : int.Parse(dataReader["Transicion"].ToString());
                            vacantes.Prioridad = dataReader.IsDBNull(dataReader.GetOrdinal("Prioridad")) ? default(int?) : int.Parse(dataReader["Prioridad"].ToString());
                        }
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }

                return vacantes;
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message.ToString());
            }
        }

        public int GetMinId(int idCatPuesto)
        {
            int Id_Vac = 0;
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter() { ParameterName = "Puesto", Value = idCatPuesto });

                using (dataReader = this.connection.ExcuteSP("Prc_Vacantes_GetMinByPuesto", parameters))
                {

                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            Id_Vac = dataReader.IsDBNull(dataReader.GetOrdinal("id_Vac")) ? default(int) : int.Parse(dataReader["id_Vac"].ToString());
                        }
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }

                return Id_Vac;
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message.ToString());
            }
        }

        public int GetMinIdByPuestoCeCoUCo(int idCatPuesto, int idCeCo, string ClaveUCo)
        {
            int Id_Vac = 0;
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter() { ParameterName = "Puesto", Value = idCatPuesto });
                parameters.Add(new SqlParameter() { ParameterName = "CeCo", Value = idCeCo });
                parameters.Add(new SqlParameter() { ParameterName = "UCos", Value = ClaveUCo });

                using (dataReader = this.connection.ExcuteSP("prc_Vacantes_GetMinByPuestoCeCoUCo", parameters))
                {

                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            Id_Vac = dataReader.IsDBNull(dataReader.GetOrdinal("id_Vac")) ? default(int) : int.Parse(dataReader["id_Vac"].ToString());
                        }
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }

                return Id_Vac;
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message.ToString());
            }
        }

        public Entities.SoluglobAdministrativo.Vacantes UpdateIdPer(Entities.SoluglobAdministrativo.Vacantes objVacantes)
        {
            vacantes = new Entities.SoluglobAdministrativo.Vacantes();

            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter() { ParameterName = "Id_Vac", Value = objVacantes.Id_Vac });
                parameters.Add(new SqlParameter() { ParameterName = "Id_Per", Value = objVacantes.Id_Per });
                

                using (dataReader = this.connection.ExcuteSP("prc_Vacantes_UpdateIdPer", parameters))
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            vacantes.Id_Per = dataReader.IsDBNull(dataReader.GetOrdinal("Id_Per")) ? default(int) : int.Parse(dataReader["Id_Per"].ToString());
                            vacantes.Id_Vac = dataReader.IsDBNull(dataReader.GetOrdinal("Id_Vac")) ? default(int) : int.Parse(dataReader["Id_Vac"].ToString());
                        }
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }
                return vacantes;
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message.ToString());
            }

        }

        public Entities.SoluglobAdministrativo.Vacantes UpdateId_PerAndEstatusVacante(Entities.SoluglobAdministrativo.Vacantes objVacantes)
        {
            vacantes = new Entities.SoluglobAdministrativo.Vacantes();
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter() { ParameterName = "Id_Vac", Value = objVacantes.Id_Vac });
                parameters.Add(new SqlParameter() { ParameterName = "Id_Per", Value = objVacantes.Id_Per });
                parameters.Add(new SqlParameter() { ParameterName = "Estatus_Vacante", Value = objVacantes.Estatus_Vacante });

                using (dataReader = this.connection.ExcuteSP("prc_Vacantes_UpdateId_PerAndEstatusVacante", parameters))
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            vacantes.Id_Vac = dataReader.IsDBNull(dataReader.GetOrdinal("Id_Vac")) ? default(int) : int.Parse(dataReader["Id_Vac"].ToString());
                            vacantes.Id_Per = dataReader.IsDBNull(dataReader.GetOrdinal("Id_Per")) ? default(int?) : int.Parse(dataReader["Id_Per"].ToString());
                            vacantes.Desc_Vacante = dataReader.IsDBNull(dataReader.GetOrdinal("Desc_Vacante")) ? null : dataReader["Desc_Vacante"].ToString();
                            vacantes.CeCo = dataReader.IsDBNull(dataReader.GetOrdinal("CeCo")) ? default(int?) : int.Parse(dataReader["CeCo"].ToString());
                            vacantes.UCos = dataReader.IsDBNull(dataReader.GetOrdinal("UCos")) ? null : dataReader["UCos"].ToString();
                            vacantes.Ubicacion = dataReader.IsDBNull(dataReader.GetOrdinal("Ubicacion")) ? null : dataReader["Ubicacion"].ToString();
                            vacantes.Estatus_Vacante = dataReader.IsDBNull(dataReader.GetOrdinal("Estatus_Vacante")) ? default(int) : int.Parse(dataReader["Estatus_Vacante"].ToString());
                            vacantes.Segmento = dataReader.IsDBNull(dataReader.GetOrdinal("Segmento")) ? default(int?) : int.Parse(dataReader["Segmento"].ToString());
                            vacantes.Gerencia = dataReader.IsDBNull(dataReader.GetOrdinal("Gerencia")) ? default(int?) : int.Parse(dataReader["Gerencia"].ToString());
                            vacantes.Puesto = dataReader.IsDBNull(dataReader.GetOrdinal("Puesto")) ? default(int?) : int.Parse(dataReader["Puesto"].ToString());
                            vacantes.Verificacion = dataReader.IsDBNull(dataReader.GetOrdinal("Verificacion")) ? null : dataReader["Verificacion"].ToString();
                            vacantes.Depto = dataReader.IsDBNull(dataReader.GetOrdinal("Depto")) ? null : dataReader["Depto"].ToString();
                            vacantes.User_Mod = dataReader.IsDBNull(dataReader.GetOrdinal("User_Mod")) ? default(int?) : int.Parse(dataReader["User_Mod"].ToString());
                            vacantes.FecMod = dataReader.IsDBNull(dataReader.GetOrdinal("FecMod")) ? default(DateTime?) : DateTime.Parse(dataReader["FecMod"].ToString());
                            vacantes.Transicion = dataReader.IsDBNull(dataReader.GetOrdinal("Transicion")) ? default(int?) : int.Parse(dataReader["Transicion"].ToString());
                            vacantes.Prioridad = dataReader.IsDBNull(dataReader.GetOrdinal("Prioridad")) ? default(int?) : int.Parse(dataReader["Prioridad"].ToString());

                        }
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }

                return vacantes;
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
