using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities = Integra.Services.Entities;

namespace Integra.Services.Data.SoluglobAdministrativo
{
    public class PerVac
    {// aqui inicia

        List<Entities.SoluglobAdministrativo.PerVac> pervacCollection = null;
        Entities.SoluglobAdministrativo.PerVac pervac = null;
        SqlDataReader dataReader = null;

        public Connection connection = null;

        public PerVac()
        {
            this.connection = Connection.Instance;
        }
        public PerVac(bool isTransaction)
        {
            this.connection = new Connection();
        }
        public PerVac(Connection connection)
        {
            this.connection = connection;
        }

        #region Inicia Insert
        public Entities.SoluglobAdministrativo.PerVac Insert(Entities.SoluglobAdministrativo.PerVac objPerVac)
        {
            pervac = new Entities.SoluglobAdministrativo.PerVac();
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter() { ParameterName = "Id_Per", Value = objPerVac.Id_Per });
                parameters.Add(new SqlParameter() { ParameterName = "Id_Vac", Value = objPerVac.Id_Vac });                

                using (dataReader = this.connection.ExcuteSP("prc_PerVac_Insert", parameters))
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            pervac.Id_Per = dataReader.IsDBNull(dataReader.GetOrdinal("Id_Per")) ? default(int) : int.Parse(dataReader["Id_Per"].ToString());
                            pervac.Id_Vac = dataReader.IsDBNull(dataReader.GetOrdinal("Id_Vac")) ? default(int) : int.Parse(dataReader["Id_Vac"].ToString());                            
                        }
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }
                return pervac;
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message.ToString());
            }


        }
        #endregion

        #region Inicia GetOne
        public Entities.SoluglobAdministrativo.PerVac GetOne(int idPersonal, int idVacante)
        {
            Entities.SoluglobAdministrativo.PerVac pervac = new Entities.SoluglobAdministrativo.PerVac();
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter() { ParameterName = "Id_Per", Value = idPersonal });
                parameters.Add(new SqlParameter() { ParameterName = "Id_Vac", Value = idVacante });                

                using (dataReader = this.connection.ExcuteSP("prc_PerVac_GetOne", parameters))
                {

                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            pervac.Id_Per = dataReader.IsDBNull(dataReader.GetOrdinal("Id_Per")) ? default(int) : int.Parse(dataReader["Id_Per"].ToString());
                            pervac.Id_Vac = dataReader.IsDBNull(dataReader.GetOrdinal("Id_Vac")) ? default(int) : int.Parse(dataReader["Id_Vac"].ToString());                            
                        }
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }

                return pervac;
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message.ToString());
            }


        }
        #endregion

        #region Inicia GetAll
        public List<Entities.SoluglobAdministrativo.PerVac> GetAll()
        {
            pervacCollection = new List<Entities.SoluglobAdministrativo.PerVac>();
            try
            {
                dataReader = this.connection.ExcuteSP("prc_PerVac_GetAll", null);
                while (dataReader.Read())
                {
                    pervac = new Entities.SoluglobAdministrativo.PerVac();
                    pervac.Id_Per = dataReader.IsDBNull(dataReader.GetOrdinal("Id_Per")) ? default(int) : int.Parse(dataReader["Id_Per"].ToString());
                    pervac.Id_Vac = dataReader.IsDBNull(dataReader.GetOrdinal("Id_Vac")) ? default(int) : int.Parse(dataReader["Id_Vac"].ToString());                    
                    pervacCollection.Add(pervac);
                }
                dataReader.Close();
                dataReader.Dispose();
                return pervacCollection;
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message.ToString());
            }
        }
        #endregion

        #region Inicia Update
        public Entities.SoluglobAdministrativo.PerVac Update(Entities.SoluglobAdministrativo.PerVac objpervac)
        {
            pervac = new Entities.SoluglobAdministrativo.PerVac();
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter() { ParameterName = "Id_Per", Value = objpervac.Id_Per });
                parameters.Add(new SqlParameter() { ParameterName = "Id_Vac", Value = objpervac.Id_Vac });                

                using (dataReader = this.connection.ExcuteSP("prc_PerVac_Update", parameters))
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            pervac.Id_Per = dataReader.IsDBNull(dataReader.GetOrdinal("Id_Per")) ? default(int) : int.Parse(dataReader["Id_Per"].ToString());
                            pervac.Id_Vac = dataReader.IsDBNull(dataReader.GetOrdinal("Id_Vac")) ? default(int) : int.Parse(dataReader["Id_Vac"].ToString());                            
                        }
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }
                return pervac;
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message.ToString());
            }
        }
        #endregion

        #region Inicia Delete
        public void Delete(int idPersonal, int idVacante)
        {
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter() { ParameterName = "Id_Per", Value = idPersonal });
                parameters.Add(new SqlParameter() { ParameterName = "Id_Vac", Value = idVacante });

                this.connection.ExcuteScalar("", parameters); // no se encontro el stored
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region Inicia Drop
        public bool Drop(int idPersonal, int idVacante)
        {
            int result = default(int);
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter() { ParameterName = "Id_Per", Value = idPersonal });
                parameters.Add(new SqlParameter() { ParameterName = "Id_Vac", Value = idVacante });                

                using (dataReader = this.connection.ExcuteSP("prc_PerVac_Drop", parameters))
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
        #endregion Inicia Drop

        #region Inicia Min
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
        #endregion Inicia Min

        public int GetMinIdByPuestoCeCoUCo(int idCatPuesto, int CeCo, string UCo)
        {
            int Id_Vac = 0;
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter() { ParameterName = "Puesto", Value = idCatPuesto });
                parameters.Add(new SqlParameter() { ParameterName = "CeCo", Value = CeCo });
                parameters.Add(new SqlParameter() { ParameterName = "UCos", Value = UCo });

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

        public Entities.SoluglobAdministrativo.PerVac UpdateIdPer(int Id_Per, int Id_PerNuevo, int Id_Vac)
        {
            pervac = new Entities.SoluglobAdministrativo.PerVac();
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter() { ParameterName = "Id_Per", Value = Id_Per });
                parameters.Add(new SqlParameter() { ParameterName = "Id_PerNuevo", Value = Id_PerNuevo });
                parameters.Add(new SqlParameter() { ParameterName = "Id_Vac", Value = Id_Vac });

                using (dataReader = this.connection.ExcuteSP("prc_PerVac_Update_IdPer", parameters))
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            pervac.Id_Per = dataReader.IsDBNull(dataReader.GetOrdinal("Id_Per")) ? default(int) : int.Parse(dataReader["Id_Per"].ToString());
                            pervac.Id_Vac = dataReader.IsDBNull(dataReader.GetOrdinal("Id_Vac")) ? default(int) : int.Parse(dataReader["Id_Vac"].ToString());
                        }
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }
                return pervac;
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message.ToString());
            }
        }
    } // aqui termina
}
