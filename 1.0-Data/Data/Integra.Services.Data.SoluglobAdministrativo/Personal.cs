using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities = Integra.Services.Entities;

namespace Integra.Services.Data.SoluglobAdministrativo
{
    public class Personal
    { // aqui inicia

        List<Entities.SoluglobAdministrativo.Personal> personalCollection = null;
        Entities.SoluglobAdministrativo.Personal personal = null;
        SqlDataReader dataReader = null;

        public Connection connection = null;

        public Personal()
        {
            this.connection = Connection.Instance;
        }
        public Personal(bool isTransaction)
        {
            this.connection = new Connection();
        }
        public Personal(Connection connection)
        {
            this.connection = connection;
        }

        #region Inicia Insert

        public Entities.SoluglobAdministrativo.Personal Insert(Entities.SoluglobAdministrativo.Personal objPersonal)
        {
            personal = new Entities.SoluglobAdministrativo.Personal();
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter() { ParameterName = "Id_Per", Value = objPersonal.Id_Per });
                parameters.Add(new SqlParameter() { ParameterName = "Num_Checador", Value = objPersonal.Num_Checador });
                parameters.Add(new SqlParameter() { ParameterName = "Nomi_Camb",Value = objPersonal.Nomi_Camb });
                parameters.Add(new SqlParameter() { ParameterName = "FecReg",Value =  objPersonal.FecReg});
                parameters.Add(new SqlParameter() { ParameterName = "Nombre",Value = objPersonal.Nombre });
                parameters.Add(new SqlParameter() { ParameterName = "Sexo",Value = objPersonal.Sexo });
                parameters.Add(new SqlParameter() { ParameterName = "Edad",Value = objPersonal.Edad });
                parameters.Add(new SqlParameter() { ParameterName = "NSS",Value = objPersonal.NSS });
                parameters.Add(new SqlParameter() { ParameterName = "CURP",Value = objPersonal.CURP });
                parameters.Add(new SqlParameter() { ParameterName = "Calle",Value = objPersonal.Calle });
                parameters.Add(new SqlParameter() { ParameterName = "Numero",Value = objPersonal.Numero });
                parameters.Add(new SqlParameter() { ParameterName = "Mz",Value = objPersonal.Mz });
                parameters.Add(new SqlParameter() { ParameterName = "Lt",Value = objPersonal.Lt });
                parameters.Add(new SqlParameter() { ParameterName = "Colonia",Value = objPersonal.Colonia });
                parameters.Add(new SqlParameter() { ParameterName = "Municipio",Value = objPersonal.Municipio });
                parameters.Add(new SqlParameter() { ParameterName = "Ciudad",Value = objPersonal.Ciudad });
                parameters.Add(new SqlParameter() { ParameterName = "Estado",Value = objPersonal.Estado });
                parameters.Add(new SqlParameter() { ParameterName = "CP",Value = objPersonal.CP });
                parameters.Add(new SqlParameter() { ParameterName = "Tel",Value = objPersonal.Tel });
                parameters.Add(new SqlParameter() { ParameterName = "Cel",Value = objPersonal.Cel });
                parameters.Add(new SqlParameter() { ParameterName = "Email",Value = objPersonal.Email });
                parameters.Add(new SqlParameter() { ParameterName = "Sueldo",Value = objPersonal.Sueldo });
                parameters.Add(new SqlParameter() { ParameterName = "Jefe",Value = objPersonal.Jefe });
                parameters.Add(new SqlParameter() { ParameterName = "Horario",Value = objPersonal.Horario });
                parameters.Add(new SqlParameter() { ParameterName = "Estatus",Value = objPersonal.Estatus });
                parameters.Add(new SqlParameter() { ParameterName = "User_Mod",Value = objPersonal.User_Mod });
                parameters.Add(new SqlParameter() { ParameterName = "FecMod",Value = objPersonal.FecMod});
                parameters.Add(new SqlParameter() { ParameterName = "AplicaBono",Value = objPersonal.AplicaBono });

                using (dataReader = this.connection.ExcuteSP("prc_Personal_Insert", parameters))
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            personal.Id_Per = dataReader.IsDBNull(dataReader.GetOrdinal("Id_Per")) ? default(int) : int.Parse(dataReader["Id_Per"].ToString());
                            personal.Num_Checador = dataReader.IsDBNull(dataReader.GetOrdinal("Num_Checador")) ? default(int?) : int.Parse(dataReader["Num_Checador"].ToString());
                            personal.Nomi_Camb = dataReader.IsDBNull(dataReader.GetOrdinal("Nomi_Camb")) ? default(int?) : int.Parse(dataReader["Nomi_Camb"].ToString());
                            personal.FecReg = dataReader.IsDBNull(dataReader.GetOrdinal("FecReg")) ? default(DateTime?) : Convert.ToDateTime(dataReader["FecReg"].ToString());
                            personal.Nombre = dataReader.IsDBNull(dataReader.GetOrdinal("Nombre")) ? null : dataReader["Nombre"].ToString();
                            personal.Sexo = dataReader.IsDBNull(dataReader.GetOrdinal("Sexo")) ? default(int?) : int.Parse(dataReader["Sexo"].ToString());
                            personal.Edad = dataReader.IsDBNull(dataReader.GetOrdinal("Edad")) ? default(int?) : int.Parse(dataReader["Edad"].ToString());
                            personal.NSS = dataReader.IsDBNull(dataReader.GetOrdinal("NSS")) ? null : dataReader["NSS"].ToString();
                            personal.CURP = dataReader.IsDBNull(dataReader.GetOrdinal("CURP")) ? null : dataReader["CURP"].ToString();
                            personal.Calle = dataReader.IsDBNull(dataReader.GetOrdinal("Calle")) ? null : dataReader["Calle"].ToString();
                            personal.Numero = dataReader.IsDBNull(dataReader.GetOrdinal("Numero")) ? null : dataReader["Numero"].ToString();
                            personal.Mz = dataReader.IsDBNull(dataReader.GetOrdinal("Mz")) ? null : dataReader["Mz"].ToString();
                            personal.Lt = dataReader.IsDBNull(dataReader.GetOrdinal("Lt")) ? null : dataReader["Lt"].ToString();
                            personal.Colonia = dataReader.IsDBNull(dataReader.GetOrdinal("Colonia")) ? null : dataReader["Colonia"].ToString();
                            personal.Municipio = dataReader.IsDBNull(dataReader.GetOrdinal("Municipio")) ? null : dataReader["Municipio"].ToString();
                            personal.Ciudad = dataReader.IsDBNull(dataReader.GetOrdinal("Ciudad")) ? null : dataReader["Ciudad"].ToString();
                            personal.Estado = dataReader.IsDBNull(dataReader.GetOrdinal("Estado")) ? null : dataReader["Estado"].ToString();
                            personal.CP = dataReader.IsDBNull(dataReader.GetOrdinal("CP")) ? null : dataReader["CP"].ToString();
                            personal.Tel = dataReader.IsDBNull(dataReader.GetOrdinal("Tel")) ? null : dataReader["Tel"].ToString();
                            personal.Cel = dataReader.IsDBNull(dataReader.GetOrdinal("Cel")) ? null : dataReader["Cel"].ToString();
                            personal.Email = dataReader.IsDBNull(dataReader.GetOrdinal("Email")) ? null : dataReader["Email"].ToString();
                            personal.Sueldo = dataReader.IsDBNull(dataReader.GetOrdinal("Sueldo")) ? default(decimal?) : decimal.Parse(dataReader["Sueldo"].ToString());
                            personal.Jefe = dataReader.IsDBNull(dataReader.GetOrdinal("Jefe")) ? default(int?) : int.Parse(dataReader["Jefe"].ToString());
                            personal.Horario = dataReader.IsDBNull(dataReader.GetOrdinal("Horario")) ? null : dataReader["Horario"].ToString();
                            personal.Estatus = dataReader.IsDBNull(dataReader.GetOrdinal("Estatus")) ? default(int?) : int.Parse(dataReader["Estatus"].ToString());
                            personal.User_Mod = dataReader.IsDBNull(dataReader.GetOrdinal("User_Mod")) ? default(int?) : int.Parse(dataReader["User_Mod"].ToString());
                            personal.FecMod = dataReader.IsDBNull(dataReader.GetOrdinal("FecMod")) ? default(DateTime?) : Convert.ToDateTime(dataReader["FecMod"].ToString());
                            personal.AplicaBono = dataReader.IsDBNull(dataReader.GetOrdinal("AplicaBono")) ? default(int?) : int.Parse(dataReader["AplicaBono"].ToString());
                        }
                    }

                    dataReader.Close();
                    dataReader.Dispose();
                }

                return personal;
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
        public Entities.SoluglobAdministrativo.Personal GetOne(int idPersonal)
        {
            Entities.SoluglobAdministrativo.Personal personal = new Entities.SoluglobAdministrativo.Personal();
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter() {ParameterName = "Id_Per", Value = idPersonal });

                using (dataReader = this.connection.ExcuteSP("prc_Personal_GetOne", parameters))
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            personal.Id_Per = dataReader.IsDBNull(dataReader.GetOrdinal("Id_Per")) ? default(int) : int.Parse(dataReader["Id_Per"].ToString());
                            personal.Num_Checador = dataReader.IsDBNull(dataReader.GetOrdinal("Num_Checador")) ? default(int?) : int.Parse(dataReader["Num_Checador"].ToString());
                            personal.Nomi_Camb = dataReader.IsDBNull(dataReader.GetOrdinal("Nomi_Camb")) ? default(int?) : int.Parse(dataReader["Nomi_Camb"].ToString());
                            personal.FecReg = dataReader.IsDBNull(dataReader.GetOrdinal("FecReg")) ? default(DateTime?) : DateTime.Parse(dataReader["FecReg"].ToString());
                            personal.Nombre = dataReader.IsDBNull(dataReader.GetOrdinal("Nombre")) ? null : dataReader["Nombre"].ToString();
                            personal.Sexo = dataReader.IsDBNull(dataReader.GetOrdinal("Sexo")) ? default(int?) : int.Parse(dataReader["Sexo"].ToString());
                            personal.Edad = dataReader.IsDBNull(dataReader.GetOrdinal("Edad")) ? default(int?) : int.Parse(dataReader["Edad"].ToString());
                            personal.NSS = dataReader.IsDBNull(dataReader.GetOrdinal("NSS")) ? null : dataReader["NSS"].ToString();
                            personal.CURP = dataReader.IsDBNull(dataReader.GetOrdinal("CURP")) ? null : dataReader["CURP"].ToString();
                            personal.Calle = dataReader.IsDBNull(dataReader.GetOrdinal("Calle")) ? null : dataReader["Calle"].ToString();
                            personal.Numero = dataReader.IsDBNull(dataReader.GetOrdinal("Numero")) ? null : dataReader["Numero"].ToString();
                            personal.Mz = dataReader.IsDBNull(dataReader.GetOrdinal("Mz")) ? null : dataReader["Mz"].ToString();
                            personal.Lt = dataReader.IsDBNull(dataReader.GetOrdinal("Lt")) ? null : dataReader["Lt"].ToString();
                            personal.Colonia = dataReader.IsDBNull(dataReader.GetOrdinal("Colonia")) ? null : dataReader["Colonia"].ToString();
                            personal.Municipio = dataReader.IsDBNull(dataReader.GetOrdinal("Municipio")) ? null : dataReader["Municipio"].ToString();
                            personal.Ciudad = dataReader.IsDBNull(dataReader.GetOrdinal("Ciudad")) ? null : dataReader["Ciudad"].ToString();
                            personal.Estado = dataReader.IsDBNull(dataReader.GetOrdinal("Estado")) ? null : dataReader["Estado"].ToString();
                            personal.CP = dataReader.IsDBNull(dataReader.GetOrdinal("CP")) ? null : dataReader["CP"].ToString();
                            personal.Tel = dataReader.IsDBNull(dataReader.GetOrdinal("Tel")) ? null : dataReader["Tel"].ToString();
                            personal.Cel = dataReader.IsDBNull(dataReader.GetOrdinal("Cel")) ? null : dataReader["Cel"].ToString();
                            personal.Email = dataReader.IsDBNull(dataReader.GetOrdinal("Email")) ? null : dataReader["Email"].ToString();
                            personal.Sueldo = dataReader.IsDBNull(dataReader.GetOrdinal("Sueldo")) ? default(decimal?) : decimal.Parse(dataReader["Sueldo"].ToString());
                            personal.Jefe = dataReader.IsDBNull(dataReader.GetOrdinal("Jefe")) ? default(int?) : int.Parse(dataReader["Jefe"].ToString());
                            personal.Horario = dataReader.IsDBNull(dataReader.GetOrdinal("Horario")) ? null : dataReader["Horario"].ToString();
                            personal.Estatus = dataReader.IsDBNull(dataReader.GetOrdinal("Estatus")) ? default(int?) : int.Parse(dataReader["Estatus"].ToString());
                            personal.User_Mod = dataReader.IsDBNull(dataReader.GetOrdinal("User_Mod")) ? default(int?) : int.Parse(dataReader["User_Mod"].ToString());
                            personal.FecMod = dataReader.IsDBNull(dataReader.GetOrdinal("FecMod")) ? default(DateTime?) : DateTime.Parse(dataReader["FecMod"].ToString());
                            personal.AplicaBono = dataReader.IsDBNull(dataReader.GetOrdinal("AplicaBono")) ? default(int?) : int.Parse(dataReader["AplicaBono"].ToString());

                        }
                    }

                }

                    return personal;
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
        public List<Entities.SoluglobAdministrativo.Personal> GetAll()
        {
            personalCollection = new List<Entities.SoluglobAdministrativo.Personal>();
            try
            {
                dataReader = this.connection.ExcuteSP("prc_Personal_GetAll", null);
                while (dataReader.Read())
                {
                    personal = new Entities.SoluglobAdministrativo.Personal();
                    personal.Id_Per = dataReader.IsDBNull(dataReader.GetOrdinal("Id_Per")) ? default(int) : int.Parse(dataReader["Id_Per"].ToString());
                    personal.Num_Checador = dataReader.IsDBNull(dataReader.GetOrdinal("Num_Checador")) ? default(int?) : int.Parse(dataReader["Num_Checador"].ToString());
                    personal.Nomi_Camb = dataReader.IsDBNull(dataReader.GetOrdinal("Nomi_Camb")) ? default(int?) : int.Parse(dataReader["Nomi_Camb"].ToString());
                    personal.FecReg = dataReader.IsDBNull(dataReader.GetOrdinal("FecReg")) ? default(DateTime?) : DateTime.Parse(dataReader["FecReg"].ToString());
                    personal.Nombre = dataReader.IsDBNull(dataReader.GetOrdinal("Nombre")) ? null : dataReader["Nombre"].ToString();
                    personal.Sexo = dataReader.IsDBNull(dataReader.GetOrdinal("Sexo")) ? default(int?) : int.Parse(dataReader["Sexo"].ToString());
                    personal.Edad = dataReader.IsDBNull(dataReader.GetOrdinal("Edad")) ? default(int?) : int.Parse(dataReader["Edad"].ToString());
                    personal.NSS = dataReader.IsDBNull(dataReader.GetOrdinal("NSS")) ? null : dataReader["NSS"].ToString();
                    personal.CURP = dataReader.IsDBNull(dataReader.GetOrdinal("CURP")) ? null : dataReader["CURP"].ToString();
                    personal.Calle = dataReader.IsDBNull(dataReader.GetOrdinal("Calle")) ? null : dataReader["Calle"].ToString();
                    personal.Numero = dataReader.IsDBNull(dataReader.GetOrdinal("Numero")) ? null : dataReader["Numero"].ToString();
                    personal.Mz = dataReader.IsDBNull(dataReader.GetOrdinal("Mz")) ? null : dataReader["Mz"].ToString();
                    personal.Lt = dataReader.IsDBNull(dataReader.GetOrdinal("Lt")) ? null : dataReader["Lt"].ToString();
                    personal.Colonia = dataReader.IsDBNull(dataReader.GetOrdinal("Colonia")) ? null : dataReader["Colonia"].ToString();
                    personal.Municipio = dataReader.IsDBNull(dataReader.GetOrdinal("Municipio")) ? null : dataReader["Municipio"].ToString();
                    personal.Ciudad = dataReader.IsDBNull(dataReader.GetOrdinal("Ciudad")) ? null : dataReader["Ciudad"].ToString();
                    personal.Estado = dataReader.IsDBNull(dataReader.GetOrdinal("Estado")) ? null : dataReader["Estado"].ToString();
                    personal.CP = dataReader.IsDBNull(dataReader.GetOrdinal("CP")) ? null : dataReader["CP"].ToString();
                    personal.Tel = dataReader.IsDBNull(dataReader.GetOrdinal("Tel")) ? null : dataReader["Tel"].ToString();
                    personal.Cel = dataReader.IsDBNull(dataReader.GetOrdinal("Cel")) ? null : dataReader["Cel"].ToString();
                    personal.Email = dataReader.IsDBNull(dataReader.GetOrdinal("Email")) ? null : dataReader["Email"].ToString();
                    personal.Sueldo = dataReader.IsDBNull(dataReader.GetOrdinal("Sueldo")) ? default(decimal?) : decimal.Parse(dataReader["Sueldo"].ToString());
                    personal.Jefe = dataReader.IsDBNull(dataReader.GetOrdinal("Jefe")) ? default(int?) : int.Parse(dataReader["Jefe"].ToString());
                    personal.Horario = dataReader.IsDBNull(dataReader.GetOrdinal("Horario")) ? null : dataReader["Horario"].ToString();
                    personal.Estatus = dataReader.IsDBNull(dataReader.GetOrdinal("Estatus")) ? default(int?) : int.Parse(dataReader["Estatus"].ToString());
                    personal.User_Mod = dataReader.IsDBNull(dataReader.GetOrdinal("User_Mod")) ? default(int?) : int.Parse(dataReader["User_Mod"].ToString());
                    personal.FecMod = dataReader.IsDBNull(dataReader.GetOrdinal("FecMod")) ? default(DateTime?) : DateTime.Parse(dataReader["FecMod"].ToString());
                    personal.AplicaBono = dataReader.IsDBNull(dataReader.GetOrdinal("AplicaBono")) ? default(int?) : int.Parse(dataReader["AplicaBono"].ToString());
                    personalCollection.Add(personal);
                }
                dataReader.Close();
                dataReader.Dispose();

                return personalCollection;
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
        public Entities.SoluglobAdministrativo.Personal Update(Entities.SoluglobAdministrativo.Personal objPersonal)
        {
            personal = new Entities.SoluglobAdministrativo.Personal();
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter() { ParameterName = "Id_Per", Value = objPersonal.Id_Per });
                parameters.Add(new SqlParameter() { ParameterName = "Num_Checador", Value = objPersonal.Num_Checador });
                parameters.Add(new SqlParameter() { ParameterName = "Nomi_Camb", Value = objPersonal.Nomi_Camb });
                parameters.Add(new SqlParameter() { ParameterName = "FecReg", Value = objPersonal.FecReg });
                parameters.Add(new SqlParameter() { ParameterName = "Nombre", Value = objPersonal.Nombre });
                parameters.Add(new SqlParameter() { ParameterName = "Sexo", Value = objPersonal.Sexo });
                parameters.Add(new SqlParameter() { ParameterName = "Edad", Value = objPersonal.Edad });
                parameters.Add(new SqlParameter() { ParameterName = "NSS", Value = objPersonal.NSS });
                parameters.Add(new SqlParameter() { ParameterName = "CURP", Value = objPersonal.CURP });
                parameters.Add(new SqlParameter() { ParameterName = "Calle", Value = objPersonal.Calle });
                parameters.Add(new SqlParameter() { ParameterName = "Numero", Value = objPersonal.Numero });
                parameters.Add(new SqlParameter() { ParameterName = "Mz", Value = objPersonal.Mz });
                parameters.Add(new SqlParameter() { ParameterName = "Lt", Value = objPersonal.Lt });
                parameters.Add(new SqlParameter() { ParameterName = "Colonia", Value = objPersonal.Colonia });
                parameters.Add(new SqlParameter() { ParameterName = "Municipio", Value = objPersonal.Municipio });
                parameters.Add(new SqlParameter() { ParameterName = "Ciudad", Value = objPersonal.Ciudad });
                parameters.Add(new SqlParameter() { ParameterName = "Estado", Value = objPersonal.Estado });
                parameters.Add(new SqlParameter() { ParameterName = "CP", Value = objPersonal.CP });
                parameters.Add(new SqlParameter() { ParameterName = "Tel", Value = objPersonal.Tel });
                parameters.Add(new SqlParameter() { ParameterName = "Cel", Value = objPersonal.Cel });
                parameters.Add(new SqlParameter() { ParameterName = "Email", Value = objPersonal.Email });
                parameters.Add(new SqlParameter() { ParameterName = "Sueldo", Value = objPersonal.Sueldo });
                parameters.Add(new SqlParameter() { ParameterName = "Jefe", Value = objPersonal.Jefe });
                parameters.Add(new SqlParameter() { ParameterName = "Horario", Value = objPersonal.Horario });
                parameters.Add(new SqlParameter() { ParameterName = "Estatus", Value = objPersonal.Estatus });
                parameters.Add(new SqlParameter() { ParameterName = "User_Mod", Value = objPersonal.User_Mod });
                parameters.Add(new SqlParameter() { ParameterName = "FecMod", Value = objPersonal.FecMod });
                parameters.Add(new SqlParameter() { ParameterName = "AplicaBono", Value = objPersonal.AplicaBono });

                using (dataReader = this.connection.ExcuteSP("prc_Personal_Update", parameters))
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            personal.Id_Per = dataReader.IsDBNull(dataReader.GetOrdinal("Id_Per")) ? default(int) : int.Parse(dataReader["Id_Per"].ToString());
                            personal.Num_Checador = dataReader.IsDBNull(dataReader.GetOrdinal("Num_Checador")) ? default(int?) : int.Parse(dataReader["Num_Checador"].ToString());
                            personal.Nomi_Camb = dataReader.IsDBNull(dataReader.GetOrdinal("Nomi_Camb")) ? default(int?) : int.Parse(dataReader["Nomi_Camb"].ToString());
                            personal.FecReg = dataReader.IsDBNull(dataReader.GetOrdinal("FecReg")) ? default(DateTime?) : DateTime.Parse(dataReader["FecReg"].ToString());
                            personal.Nombre = dataReader.IsDBNull(dataReader.GetOrdinal("Nombre")) ? null : dataReader["Nombre"].ToString();
                            personal.Sexo = dataReader.IsDBNull(dataReader.GetOrdinal("Sexo")) ? default(int?) : int.Parse(dataReader["Sexo"].ToString());
                            personal.Edad = dataReader.IsDBNull(dataReader.GetOrdinal("Edad")) ? default(int?) : int.Parse(dataReader["Edad"].ToString());
                            personal.NSS = dataReader.IsDBNull(dataReader.GetOrdinal("NSS")) ? null : dataReader["NSS"].ToString();
                            personal.CURP = dataReader.IsDBNull(dataReader.GetOrdinal("CURP")) ? null : dataReader["CURP"].ToString();
                            personal.Calle = dataReader.IsDBNull(dataReader.GetOrdinal("Calle")) ? null : dataReader["Calle"].ToString();
                            personal.Numero = dataReader.IsDBNull(dataReader.GetOrdinal("Numero")) ? null : dataReader["Numero"].ToString();
                            personal.Mz = dataReader.IsDBNull(dataReader.GetOrdinal("Mz")) ? null : dataReader["Mz"].ToString();
                            personal.Lt = dataReader.IsDBNull(dataReader.GetOrdinal("Lt")) ? null : dataReader["Lt"].ToString();
                            personal.Colonia = dataReader.IsDBNull(dataReader.GetOrdinal("Colonia")) ? null : dataReader["Colonia"].ToString();
                            personal.Municipio = dataReader.IsDBNull(dataReader.GetOrdinal("Municipio")) ? null : dataReader["Municipio"].ToString();
                            personal.Ciudad = dataReader.IsDBNull(dataReader.GetOrdinal("Ciudad")) ? null : dataReader["Ciudad"].ToString();
                            personal.Estado = dataReader.IsDBNull(dataReader.GetOrdinal("Estado")) ? null : dataReader["Estado"].ToString();
                            personal.CP = dataReader.IsDBNull(dataReader.GetOrdinal("CP")) ? null : dataReader["CP"].ToString();
                            personal.Tel = dataReader.IsDBNull(dataReader.GetOrdinal("Tel")) ? null : dataReader["Tel"].ToString();
                            personal.Cel = dataReader.IsDBNull(dataReader.GetOrdinal("Cel")) ? null : dataReader["Cel"].ToString();
                            personal.Email = dataReader.IsDBNull(dataReader.GetOrdinal("Email")) ? null : dataReader["Email"].ToString();
                            personal.Sueldo = dataReader.IsDBNull(dataReader.GetOrdinal("Sueldo")) ? default(decimal?) : decimal.Parse(dataReader["Sueldo"].ToString());
                            personal.Jefe = dataReader.IsDBNull(dataReader.GetOrdinal("Jefe")) ? default(int?) : int.Parse(dataReader["Jefe"].ToString());
                            personal.Horario = dataReader.IsDBNull(dataReader.GetOrdinal("Horario")) ? null : dataReader["Horario"].ToString();
                            personal.Estatus = dataReader.IsDBNull(dataReader.GetOrdinal("Estatus")) ? default(int?) : int.Parse(dataReader["Estatus"].ToString());
                            personal.User_Mod = dataReader.IsDBNull(dataReader.GetOrdinal("User_Mod")) ? default(int?) : int.Parse(dataReader["User_Mod"].ToString());
                            personal.FecMod = dataReader.IsDBNull(dataReader.GetOrdinal("FecMod")) ? default(DateTime?) : DateTime.Parse(dataReader["FecMod"].ToString());
                            personal.AplicaBono = dataReader.IsDBNull(dataReader.GetOrdinal("AplicaBono")) ? default(int?) : int.Parse(dataReader["AplicaBono"].ToString());
                        }
                    }

                    dataReader.Close();
                    dataReader.Dispose();
                }

                return personal;
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
        public void Delete(int NumeroNomina)
        {
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter() { ParameterName = "Num_Checador", Value = NumeroNomina });

                this.connection.ExcuteScalar("prc_Personal_Delete", parameters);
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
        public void Drop(int Id_Per)
        {
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter() { ParameterName = "Id_Per", Value = Id_Per });

                this.connection.ExcuteScalar("prc_Personal_Drop", parameters);
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message);
            }
        }
        #endregion Inicia Drop

        public Entities.SoluglobAdministrativo.Personal GetOneByNumeroChecador(int NumeroNomina)
        {
            Entities.SoluglobAdministrativo.Personal personal = new Entities.SoluglobAdministrativo.Personal();
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter() { ParameterName = "Num_Checador", Value = NumeroNomina });

                using (dataReader = this.connection.ExcuteSP("prc_Personal_GetOneByNumeroChecador", parameters))
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            personal.Id_Per = dataReader.IsDBNull(dataReader.GetOrdinal("Id_Per")) ? default(int) : int.Parse(dataReader["Id_Per"].ToString());
                            personal.Num_Checador = dataReader.IsDBNull(dataReader.GetOrdinal("Num_Checador")) ? default(int?) : int.Parse(dataReader["Num_Checador"].ToString());
                            personal.Nomi_Camb = dataReader.IsDBNull(dataReader.GetOrdinal("Nomi_Camb")) ? default(int?) : int.Parse(dataReader["Nomi_Camb"].ToString());
                            personal.FecReg = dataReader.IsDBNull(dataReader.GetOrdinal("FecReg")) ? default(DateTime?) : DateTime.Parse(dataReader["FecReg"].ToString());
                            personal.Nombre = dataReader.IsDBNull(dataReader.GetOrdinal("Nombre")) ? null : dataReader["Nombre"].ToString();
                            personal.Sexo = dataReader.IsDBNull(dataReader.GetOrdinal("Sexo")) ? default(int?) : int.Parse(dataReader["Sexo"].ToString());
                            personal.Edad = dataReader.IsDBNull(dataReader.GetOrdinal("Edad")) ? default(int?) : int.Parse(dataReader["Edad"].ToString());
                            personal.NSS = dataReader.IsDBNull(dataReader.GetOrdinal("NSS")) ? null : dataReader["NSS"].ToString();
                            personal.CURP = dataReader.IsDBNull(dataReader.GetOrdinal("CURP")) ? null : dataReader["CURP"].ToString();
                            personal.Calle = dataReader.IsDBNull(dataReader.GetOrdinal("Calle")) ? null : dataReader["Calle"].ToString();
                            personal.Numero = dataReader.IsDBNull(dataReader.GetOrdinal("Numero")) ? null : dataReader["Numero"].ToString();
                            personal.Mz = dataReader.IsDBNull(dataReader.GetOrdinal("Mz")) ? null : dataReader["Mz"].ToString();
                            personal.Lt = dataReader.IsDBNull(dataReader.GetOrdinal("Lt")) ? null : dataReader["Lt"].ToString();
                            personal.Colonia = dataReader.IsDBNull(dataReader.GetOrdinal("Colonia")) ? null : dataReader["Colonia"].ToString();
                            personal.Municipio = dataReader.IsDBNull(dataReader.GetOrdinal("Municipio")) ? null : dataReader["Municipio"].ToString();
                            personal.Ciudad = dataReader.IsDBNull(dataReader.GetOrdinal("Ciudad")) ? null : dataReader["Ciudad"].ToString();
                            personal.Estado = dataReader.IsDBNull(dataReader.GetOrdinal("Estado")) ? null : dataReader["Estado"].ToString();
                            personal.CP = dataReader.IsDBNull(dataReader.GetOrdinal("CP")) ? null : dataReader["CP"].ToString();
                            personal.Tel = dataReader.IsDBNull(dataReader.GetOrdinal("Tel")) ? null : dataReader["Tel"].ToString();
                            personal.Cel = dataReader.IsDBNull(dataReader.GetOrdinal("Cel")) ? null : dataReader["Cel"].ToString();
                            personal.Email = dataReader.IsDBNull(dataReader.GetOrdinal("Email")) ? null : dataReader["Email"].ToString();
                            personal.Sueldo = dataReader.IsDBNull(dataReader.GetOrdinal("Sueldo")) ? default(decimal?) : decimal.Parse(dataReader["Sueldo"].ToString());
                            personal.Jefe = dataReader.IsDBNull(dataReader.GetOrdinal("Jefe")) ? default(int?) : int.Parse(dataReader["Jefe"].ToString());
                            personal.Horario = dataReader.IsDBNull(dataReader.GetOrdinal("Horario")) ? null : dataReader["Horario"].ToString();
                            personal.Estatus = dataReader.IsDBNull(dataReader.GetOrdinal("Estatus")) ? default(int?) : int.Parse(dataReader["Estatus"].ToString());
                            personal.User_Mod = dataReader.IsDBNull(dataReader.GetOrdinal("User_Mod")) ? default(int?) : int.Parse(dataReader["User_Mod"].ToString());
                            personal.FecMod = dataReader.IsDBNull(dataReader.GetOrdinal("FecMod")) ? default(DateTime?) : DateTime.Parse(dataReader["FecMod"].ToString());
                            personal.AplicaBono = dataReader.IsDBNull(dataReader.GetOrdinal("AplicaBono")) ? default(int?) : int.Parse(dataReader["AplicaBono"].ToString());

                        }
                    }

                    dataReader.Close();
                    dataReader.Dispose();
                }

                return personal;
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message.ToString());
            }


        }

        public Entities.SoluglobAdministrativo.Personal UpdateId_PerAndNomiCamb(Entities.SoluglobAdministrativo.Personal objPersonal)
        {
            personal = new Entities.SoluglobAdministrativo.Personal();
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter() { ParameterName = "Id_Per", Value = objPersonal.Id_Per });
                parameters.Add(new SqlParameter() { ParameterName = "Num_Checador", Value = objPersonal.Num_Checador });
                parameters.Add(new SqlParameter() { ParameterName = "Nomi_Camb", Value = objPersonal.Nomi_Camb });

                using (dataReader = this.connection.ExcuteSP("prc_Personal_UpdateId_PerAndNomiCamb", parameters))
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            personal.Id_Per = dataReader.IsDBNull(dataReader.GetOrdinal("Id_Per")) ? default(int) : int.Parse(dataReader["Id_Per"].ToString());
                            personal.Num_Checador = dataReader.IsDBNull(dataReader.GetOrdinal("Num_Checador")) ? default(int?) : int.Parse(dataReader["Num_Checador"].ToString());
                            personal.Nomi_Camb = dataReader.IsDBNull(dataReader.GetOrdinal("Nomi_Camb")) ? default(int?) : int.Parse(dataReader["Nomi_Camb"].ToString());
                            personal.FecReg = dataReader.IsDBNull(dataReader.GetOrdinal("FecReg")) ? default(DateTime?) : DateTime.Parse(dataReader["FecReg"].ToString());
                            personal.Nombre = dataReader.IsDBNull(dataReader.GetOrdinal("Nombre")) ? null : dataReader["Nombre"].ToString();
                            personal.Sexo = dataReader.IsDBNull(dataReader.GetOrdinal("Sexo")) ? default(int?) : int.Parse(dataReader["Sexo"].ToString());
                            personal.Edad = dataReader.IsDBNull(dataReader.GetOrdinal("Edad")) ? default(int?) : int.Parse(dataReader["Edad"].ToString());
                            personal.NSS = dataReader.IsDBNull(dataReader.GetOrdinal("NSS")) ? null : dataReader["NSS"].ToString();
                            personal.CURP = dataReader.IsDBNull(dataReader.GetOrdinal("CURP")) ? null : dataReader["CURP"].ToString();
                            personal.Calle = dataReader.IsDBNull(dataReader.GetOrdinal("Calle")) ? null : dataReader["Calle"].ToString();
                            personal.Numero = dataReader.IsDBNull(dataReader.GetOrdinal("Numero")) ? null : dataReader["Numero"].ToString();
                            personal.Mz = dataReader.IsDBNull(dataReader.GetOrdinal("Mz")) ? null : dataReader["Mz"].ToString();
                            personal.Lt = dataReader.IsDBNull(dataReader.GetOrdinal("Lt")) ? null : dataReader["Lt"].ToString();
                            personal.Colonia = dataReader.IsDBNull(dataReader.GetOrdinal("Colonia")) ? null : dataReader["Colonia"].ToString();
                            personal.Municipio = dataReader.IsDBNull(dataReader.GetOrdinal("Municipio")) ? null : dataReader["Municipio"].ToString();
                            personal.Ciudad = dataReader.IsDBNull(dataReader.GetOrdinal("Ciudad")) ? null : dataReader["Ciudad"].ToString();
                            personal.Estado = dataReader.IsDBNull(dataReader.GetOrdinal("Estado")) ? null : dataReader["Estado"].ToString();
                            personal.CP = dataReader.IsDBNull(dataReader.GetOrdinal("CP")) ? null : dataReader["CP"].ToString();
                            personal.Tel = dataReader.IsDBNull(dataReader.GetOrdinal("Tel")) ? null : dataReader["Tel"].ToString();
                            personal.Cel = dataReader.IsDBNull(dataReader.GetOrdinal("Cel")) ? null : dataReader["Cel"].ToString();
                            personal.Email = dataReader.IsDBNull(dataReader.GetOrdinal("Email")) ? null : dataReader["Email"].ToString();
                            personal.Sueldo = dataReader.IsDBNull(dataReader.GetOrdinal("Sueldo")) ? default(decimal?) : decimal.Parse(dataReader["Sueldo"].ToString());
                            personal.Jefe = dataReader.IsDBNull(dataReader.GetOrdinal("Jefe")) ? default(int?) : int.Parse(dataReader["Jefe"].ToString());
                            personal.Horario = dataReader.IsDBNull(dataReader.GetOrdinal("Horario")) ? null : dataReader["Horario"].ToString();
                            personal.Estatus = dataReader.IsDBNull(dataReader.GetOrdinal("Estatus")) ? default(int?) : int.Parse(dataReader["Estatus"].ToString());
                            personal.User_Mod = dataReader.IsDBNull(dataReader.GetOrdinal("User_Mod")) ? default(int?) : int.Parse(dataReader["User_Mod"].ToString());
                            personal.FecMod = dataReader.IsDBNull(dataReader.GetOrdinal("FecMod")) ? default(DateTime?) : DateTime.Parse(dataReader["FecMod"].ToString());
                            personal.AplicaBono = dataReader.IsDBNull(dataReader.GetOrdinal("AplicaBono")) ? default(int?) : int.Parse(dataReader["AplicaBono"].ToString());
                        }
                    }

                    dataReader.Close();
                    dataReader.Dispose();
                }

                return personal;
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message.ToString());
            }
        }
        
        public int GetMaxId()
        {
            Entities.SoluglobAdministrativo.Personal personal = new Entities.SoluglobAdministrativo.Personal();
            try
            {
                using (dataReader = this.connection.ExcuteSP("prc_Personal_GetMaxId", null))
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            personal.Id_Per = dataReader.IsDBNull(dataReader.GetOrdinal("Id_Per")) ? default(int) : int.Parse(dataReader["Id_Per"].ToString());
                        }
                    }

                    dataReader.Close();
                    dataReader.Dispose();
                }

                return personal.Id_Per;
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message.ToString());
            }


        }

        public Entities.SoluglobAdministrativo.Personal BajaEmpleado(int Id_Per, int Estatus)
        {
            personal = new Entities.SoluglobAdministrativo.Personal();
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter() { ParameterName = "Id_Per", Value = Id_Per });
                parameters.Add(new SqlParameter() { ParameterName = "Estatus", Value = Estatus });

                using (dataReader = this.connection.ExcuteSP("prc_Personal_UpdateEstatus", parameters))
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            personal.Id_Per = dataReader.IsDBNull(dataReader.GetOrdinal("Id_Per")) ? default(int) : int.Parse(dataReader["Id_Per"].ToString());
                            personal.Num_Checador = dataReader.IsDBNull(dataReader.GetOrdinal("Num_Checador")) ? default(int?) : int.Parse(dataReader["Num_Checador"].ToString());
                            personal.Nomi_Camb = dataReader.IsDBNull(dataReader.GetOrdinal("Nomi_Camb")) ? default(int?) : int.Parse(dataReader["Nomi_Camb"].ToString());
                            personal.FecReg = dataReader.IsDBNull(dataReader.GetOrdinal("FecReg")) ? default(DateTime?) : DateTime.Parse(dataReader["FecReg"].ToString());
                            personal.Nombre = dataReader.IsDBNull(dataReader.GetOrdinal("Nombre")) ? null : dataReader["Nombre"].ToString();
                            personal.Sexo = dataReader.IsDBNull(dataReader.GetOrdinal("Sexo")) ? default(int?) : int.Parse(dataReader["Sexo"].ToString());
                            personal.Edad = dataReader.IsDBNull(dataReader.GetOrdinal("Edad")) ? default(int?) : int.Parse(dataReader["Edad"].ToString());
                            personal.NSS = dataReader.IsDBNull(dataReader.GetOrdinal("NSS")) ? null : dataReader["NSS"].ToString();
                            personal.CURP = dataReader.IsDBNull(dataReader.GetOrdinal("CURP")) ? null : dataReader["CURP"].ToString();
                            personal.Calle = dataReader.IsDBNull(dataReader.GetOrdinal("Calle")) ? null : dataReader["Calle"].ToString();
                            personal.Numero = dataReader.IsDBNull(dataReader.GetOrdinal("Numero")) ? null : dataReader["Numero"].ToString();
                            personal.Mz = dataReader.IsDBNull(dataReader.GetOrdinal("Mz")) ? null : dataReader["Mz"].ToString();
                            personal.Lt = dataReader.IsDBNull(dataReader.GetOrdinal("Lt")) ? null : dataReader["Lt"].ToString();
                            personal.Colonia = dataReader.IsDBNull(dataReader.GetOrdinal("Colonia")) ? null : dataReader["Colonia"].ToString();
                            personal.Municipio = dataReader.IsDBNull(dataReader.GetOrdinal("Municipio")) ? null : dataReader["Municipio"].ToString();
                            personal.Ciudad = dataReader.IsDBNull(dataReader.GetOrdinal("Ciudad")) ? null : dataReader["Ciudad"].ToString();
                            personal.Estado = dataReader.IsDBNull(dataReader.GetOrdinal("Estado")) ? null : dataReader["Estado"].ToString();
                            personal.CP = dataReader.IsDBNull(dataReader.GetOrdinal("CP")) ? null : dataReader["CP"].ToString();
                            personal.Tel = dataReader.IsDBNull(dataReader.GetOrdinal("Tel")) ? null : dataReader["Tel"].ToString();
                            personal.Cel = dataReader.IsDBNull(dataReader.GetOrdinal("Cel")) ? null : dataReader["Cel"].ToString();
                            personal.Email = dataReader.IsDBNull(dataReader.GetOrdinal("Email")) ? null : dataReader["Email"].ToString();
                            personal.Sueldo = dataReader.IsDBNull(dataReader.GetOrdinal("Sueldo")) ? default(decimal?) : decimal.Parse(dataReader["Sueldo"].ToString());
                            personal.Jefe = dataReader.IsDBNull(dataReader.GetOrdinal("Jefe")) ? default(int?) : int.Parse(dataReader["Jefe"].ToString());
                            personal.Horario = dataReader.IsDBNull(dataReader.GetOrdinal("Horario")) ? null : dataReader["Horario"].ToString();
                            personal.Estatus = dataReader.IsDBNull(dataReader.GetOrdinal("Estatus")) ? default(int?) : int.Parse(dataReader["Estatus"].ToString());
                            personal.User_Mod = dataReader.IsDBNull(dataReader.GetOrdinal("User_Mod")) ? default(int?) : int.Parse(dataReader["User_Mod"].ToString());
                            personal.FecMod = dataReader.IsDBNull(dataReader.GetOrdinal("FecMod")) ? default(DateTime?) : DateTime.Parse(dataReader["FecMod"].ToString());
                            personal.AplicaBono = dataReader.IsDBNull(dataReader.GetOrdinal("AplicaBono")) ? default(int?) : int.Parse(dataReader["AplicaBono"].ToString());
                        }
                    }

                    dataReader.Close();
                    dataReader.Dispose();
                }

                return personal;
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
