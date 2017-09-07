using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integra.Services.Data.QProcess
{
    public class Contratacion
    {
        //List<Entities.QProcess.Contratacion> contratacionCollection = null;
        Entities.QProcess.Contratacion contratacion = null;
        SqlDataReader dataReader = null;

        public Connection connection = null;

        public Contratacion()
        {
            this.connection = Connection.Instance;
        }

        public Contratacion(bool isTransaction)
        {
            this.connection = new Connection();
        }

        public Contratacion(Connection connection)
        {
            this.connection = connection;
        }

        public Entities.QProcess.Contratacion GetOne(string Compania, string NumEmpleado)
        {
            contratacion = new Entities.QProcess.Contratacion();

            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter() { ParameterName = "compania", Value = Compania });
                parameters.Add(new SqlParameter() { ParameterName = "empleado", Value = NumEmpleado });

                using (dataReader = this.connection.ExcuteSP("prc_Empleados_GetOne_SoluGlob", parameters))
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            contratacion.idContratacion = dataReader.IsDBNull(dataReader.GetOrdinal("idContratacion")) ? default(int) : int.Parse(dataReader["idContratacion"].ToString());
                            contratacion.idRequisicionContratacion = dataReader.IsDBNull(dataReader.GetOrdinal("idRequisicionContratacion")) ? default(int) : int.Parse(dataReader["idRequisicionContratacion"].ToString());
                            contratacion.idEntrevistaCandidato = dataReader.IsDBNull(dataReader.GetOrdinal("idEntrevistaCandidato")) ? default(int) : int.Parse(dataReader["idEntrevistaCandidato"].ToString());
                            contratacion.NumeroEmpleado = dataReader.IsDBNull(dataReader.GetOrdinal("NumeroEmpleado")) ? null : dataReader["NumeroEmpleado"].ToString();
                            contratacion.idCatTipocontrato = dataReader.IsDBNull(dataReader.GetOrdinal("idCatTipocontrato")) ? default(int) : int.Parse(dataReader["idCatTipocontrato"].ToString());
                            contratacion.FechaContrato = dataReader.IsDBNull(dataReader.GetOrdinal("FechaContrato")) ? default(DateTime) : DateTime.Parse(dataReader["FechaContrato"].ToString());
                            contratacion.FechaInicioLaboral = dataReader.IsDBNull(dataReader.GetOrdinal("FechaInicioLaboral")) ? default(DateTime) : DateTime.Parse(dataReader["FechaInicioLaboral"].ToString());
                            contratacion.FechaAplicaBono = dataReader.IsDBNull(dataReader.GetOrdinal("FechaAplicaBono")) ? default(DateTime) : DateTime.Parse(dataReader["FechaAplicaBono"].ToString());
                            contratacion.FechaFinContrato = dataReader.IsDBNull(dataReader.GetOrdinal("FechaFinContrato")) ? default(DateTime) : DateTime.Parse(dataReader["FechaFinContrato"].ToString());
                            contratacion.SueldoAutorizado = dataReader.IsDBNull(dataReader.GetOrdinal("SueldoAutorizado")) ? default(Double) : Double.Parse(dataReader["SueldoAutorizado"].ToString());
                            contratacion.BonoAutorizado = dataReader.IsDBNull(dataReader.GetOrdinal("BonoAutorizado")) ? default(Double) : Double.Parse(dataReader["BonoAutorizado"].ToString());
                            contratacion.SueldoDiario = dataReader.IsDBNull(dataReader.GetOrdinal("SueldoDiario")) ? default(Double) : Double.Parse(dataReader["SueldoDiario"].ToString());
                            contratacion.Calle = dataReader.IsDBNull(dataReader.GetOrdinal("Calle")) ? null : dataReader["Calle"].ToString();
                            contratacion.NumeroExt = dataReader.IsDBNull(dataReader.GetOrdinal("NumeroExt")) ? null : dataReader["NumeroExt"].ToString();
                            contratacion.NumeroInt = dataReader.IsDBNull(dataReader.GetOrdinal("NumeroInt")) ? null : dataReader["NumeroInt"].ToString();
                            contratacion.Colonia = dataReader.IsDBNull(dataReader.GetOrdinal("Colonia")) ? null : dataReader["Colonia"].ToString();
                            contratacion.CP = dataReader.IsDBNull(dataReader.GetOrdinal("CP")) ? null : dataReader["CP"].ToString();
                            contratacion.Estado = dataReader.IsDBNull(dataReader.GetOrdinal("Estado")) ? null : dataReader["Estado"].ToString();
                            contratacion.MunicipioDelegacion = dataReader.IsDBNull(dataReader.GetOrdinal("MunicipioDelegacion")) ? null : dataReader["MunicipioDelegacion"].ToString();
                            contratacion.TelefonoCelular = dataReader.IsDBNull(dataReader.GetOrdinal("TelefonoCelular")) ? null : dataReader["TelefonoCelular"].ToString();
                            contratacion.NombreContactoEmergencia = dataReader.IsDBNull(dataReader.GetOrdinal("NombreContactoEmergencia")) ? null : dataReader["NombreContactoEmergencia"].ToString();
                            contratacion.TelContactoEmergencia = dataReader.IsDBNull(dataReader.GetOrdinal("TelContactoEmergencia")) ? null : dataReader["TelContactoEmergencia"].ToString();
                            contratacion.Email = dataReader.IsDBNull(dataReader.GetOrdinal("Email")) ? null : dataReader["Email"].ToString();
                            contratacion.idNacionalidad = dataReader.IsDBNull(dataReader.GetOrdinal("idNacionalidad")) ? default(int) : int.Parse(dataReader["idNacionalidad"].ToString());
                            contratacion.idEstadoCivil = dataReader.IsDBNull(dataReader.GetOrdinal("idEstadoCivil")) ? default(int) : int.Parse(dataReader["idEstadoCivil"].ToString());
                            contratacion.idCatFormaPago = dataReader.IsDBNull(dataReader.GetOrdinal("idCatFormaPago")) ? default(int) : int.Parse(dataReader["idCatFormaPago"].ToString());
                            contratacion.AltaIMSS = dataReader.IsDBNull(dataReader.GetOrdinal("AltaIMSS")) ? default(bool) : bool.Parse(dataReader["AltaIMSS"].ToString());
                            contratacion.FechaAltaIMSS = dataReader.IsDBNull(dataReader.GetOrdinal("FechaAltaIMSS")) ? default(DateTime) : DateTime.Parse(dataReader["FechaAltaIMSS"].ToString());
                            contratacion.NSS = dataReader.IsDBNull(dataReader.GetOrdinal("NSS")) ? null : dataReader["NSS"].ToString();
                            contratacion.CURP = dataReader.IsDBNull(dataReader.GetOrdinal("CURP")) ? null : dataReader["CURP"].ToString();
                            contratacion.NumCreditoInfonavit = dataReader.IsDBNull(dataReader.GetOrdinal("NumCreditoInfonavit")) ? null : dataReader["NumCreditoInfonavit"].ToString();
                            contratacion.idBanco = dataReader.IsDBNull(dataReader.GetOrdinal("idBanco")) ? default(int) : int.Parse(dataReader["idBanco"].ToString());
                            contratacion.Cta_Cheques = dataReader.IsDBNull(dataReader.GetOrdinal("Cta_Cheques")) ? null : dataReader["Cta_Cheques"].ToString();
                            contratacion.NumIdentificacionOficial = dataReader.IsDBNull(dataReader.GetOrdinal("NumIdentificacionOficial")) ? null : dataReader["NumIdentificacionOficial"].ToString();
                            contratacion.idCatEmpresaPagadora = dataReader.IsDBNull(dataReader.GetOrdinal("idCatEmpresaPagadora")) ? default(int?) : int.Parse(dataReader["idCatEmpresaPagadora"].ToString());
                            contratacion.idTipoPeriodicidad = dataReader.IsDBNull(dataReader.GetOrdinal("idTipoPeriodicidad")) ? default(int) : int.Parse(dataReader["idTipoPeriodicidad"].ToString());
                            contratacion.Date = dataReader.IsDBNull(dataReader.GetOrdinal("Date")) ? default(DateTime) : DateTime.Parse(dataReader["Date"].ToString());
                            contratacion.User = dataReader.IsDBNull(dataReader.GetOrdinal("User")) ? null : dataReader["User"].ToString();
                            contratacion.Status = dataReader.IsDBNull(dataReader.GetOrdinal("Status")) ? default(bool) : bool.Parse(dataReader["Status"].ToString());
                            contratacion.CLABEInterbancaria = dataReader.IsDBNull(dataReader.GetOrdinal("CLABEInterbancaria")) ? null : dataReader["CLABEInterbancaria"].ToString();
                            contratacion.ClaveSector = dataReader.IsDBNull(dataReader.GetOrdinal("ClaveSector")) ? null : dataReader["ClaveSector"].ToString();
                            contratacion.ClaveRegion = dataReader.IsDBNull(dataReader.GetOrdinal("ClaveRegion")) ? null : dataReader["ClaveRegion"].ToString();
                            contratacion.ClaveTipoOperacion = dataReader.IsDBNull(dataReader.GetOrdinal("ClaveTipoOperacion")) ? null : dataReader["ClaveTipoOperacion"].ToString();
                            contratacion.idcatmarca = dataReader.IsDBNull(dataReader.GetOrdinal("idcatmarca")) ? default(Int16?) : Int16.Parse(dataReader["idcatmarca"].ToString());
                            contratacion.idGrupoPago = dataReader.IsDBNull(dataReader.GetOrdinal("idGrupoPago")) ? default(int?) : int.Parse(dataReader["idGrupoPago"].ToString());
                            contratacion.IdSoluglob = dataReader.IsDBNull(dataReader.GetOrdinal("IdSoluglob")) ? default(int?) : int.Parse(dataReader["IdSoluglob"].ToString());
                            contratacion.EstatusProceso = dataReader.IsDBNull(dataReader.GetOrdinal("EstatusProceso")) ? default(int?) : int.Parse(dataReader["EstatusProceso"].ToString());
                            contratacion.Id_Per = dataReader.IsDBNull(dataReader.GetOrdinal("Id_Per")) ? default(int?) : int.Parse(dataReader["Id_Per"].ToString());
                            contratacion.SDI = dataReader.IsDBNull(dataReader.GetOrdinal("SDI")) ? default(Double?) : Double.Parse(dataReader["SDI"].ToString());
                            contratacion.SDP = dataReader.IsDBNull(dataReader.GetOrdinal("SDP")) ? default(Double?) : Double.Parse(dataReader["SDP"].ToString());
                            contratacion.SDN = dataReader.IsDBNull(dataReader.GetOrdinal("SDN")) ? default(Double?) : Double.Parse(dataReader["SDN"].ToString());
                            contratacion.idCatEmpresaPagadoraPasajes = dataReader.IsDBNull(dataReader.GetOrdinal("idCatEmpresaPagadoraPasajes")) ? default(int?) : int.Parse(dataReader["idCatEmpresaPagadoraPasajes"].ToString());
                            contratacion.idGrupoPagoPasajes = dataReader.IsDBNull(dataReader.GetOrdinal("idGrupoPagoPasajes")) ? default(int?) : int.Parse(dataReader["idGrupoPagoPasajes"].ToString());
                            contratacion.idRegionContratacion = dataReader.IsDBNull(dataReader.GetOrdinal("idRegionContratacion")) ? default(int?) : int.Parse(dataReader["idRegionContratacion"].ToString());
                            contratacion.idTipoNomina = dataReader.IsDBNull(dataReader.GetOrdinal("idTipoNomina")) ? default(int?) : int.Parse(dataReader["idTipoNomina"].ToString());
                            
                        }
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }

                return contratacion;
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message.ToString());
            }
        }

        public Entities.QProcess.Contratacion UpdateEstatusProceso(int NumeroNomina, int EstatusProceso)
        {
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                parameters.Add(new SqlParameter() { ParameterName = "NumeroNomina", Value = NumeroNomina });
                parameters.Add(new SqlParameter() { ParameterName = "EstatusProceso", Value = EstatusProceso });
                
                using (dataReader = this.connection.ExcuteSP("prc_UpdateEstatusProceso", parameters))
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            contratacion = new Entities.QProcess.Contratacion();
                            contratacion.idContratacion = dataReader.IsDBNull(dataReader.GetOrdinal("idContratacion")) ? default(int) : int.Parse(dataReader["idContratacion"].ToString());
                            contratacion.idRequisicionContratacion = dataReader.IsDBNull(dataReader.GetOrdinal("idRequisicionContratacion")) ? default(int) : int.Parse(dataReader["idRequisicionContratacion"].ToString());
                            contratacion.idEntrevistaCandidato = dataReader.IsDBNull(dataReader.GetOrdinal("idEntrevistaCandidato")) ? default(int) : int.Parse(dataReader["idEntrevistaCandidato"].ToString());
                            contratacion.NumeroEmpleado = dataReader.IsDBNull(dataReader.GetOrdinal("NumeroEmpleado")) ? null : dataReader["NumeroEmpleado"].ToString();
                            contratacion.idCatTipocontrato = dataReader.IsDBNull(dataReader.GetOrdinal("idCatTipocontrato")) ? default(int) : int.Parse(dataReader["idCatTipocontrato"].ToString());
                            contratacion.FechaContrato = dataReader.IsDBNull(dataReader.GetOrdinal("FechaContrato")) ? default(DateTime) : DateTime.Parse(dataReader["FechaContrato"].ToString());
                            contratacion.FechaInicioLaboral = dataReader.IsDBNull(dataReader.GetOrdinal("FechaInicioLaboral")) ? default(DateTime) : DateTime.Parse(dataReader["FechaInicioLaboral"].ToString());
                            contratacion.FechaAplicaBono = dataReader.IsDBNull(dataReader.GetOrdinal("FechaAplicaBono")) ? default(DateTime) : DateTime.Parse(dataReader["FechaAplicaBono"].ToString());
                            contratacion.FechaFinContrato = dataReader.IsDBNull(dataReader.GetOrdinal("FechaFinContrato")) ? default(DateTime) : DateTime.Parse(dataReader["FechaFinContrato"].ToString());
                            contratacion.SueldoAutorizado = dataReader.IsDBNull(dataReader.GetOrdinal("SueldoAutorizado")) ? default(Double) : Double.Parse(dataReader["SueldoAutorizado"].ToString());
                            contratacion.BonoAutorizado = dataReader.IsDBNull(dataReader.GetOrdinal("BonoAutorizado")) ? default(Double) : Double.Parse(dataReader["BonoAutorizado"].ToString());
                            contratacion.SueldoDiario = dataReader.IsDBNull(dataReader.GetOrdinal("SueldoDiario")) ? default(Double) : Double.Parse(dataReader["SueldoDiario"].ToString());
                            contratacion.Calle = dataReader.IsDBNull(dataReader.GetOrdinal("Calle")) ? null : dataReader["Calle"].ToString();
                            contratacion.NumeroExt = dataReader.IsDBNull(dataReader.GetOrdinal("NumeroExt")) ? null : dataReader["NumeroExt"].ToString();
                            contratacion.NumeroInt = dataReader.IsDBNull(dataReader.GetOrdinal("NumeroInt")) ? null : dataReader["NumeroInt"].ToString();
                            contratacion.Colonia = dataReader.IsDBNull(dataReader.GetOrdinal("Colonia")) ? null : dataReader["Colonia"].ToString();
                            contratacion.CP = dataReader.IsDBNull(dataReader.GetOrdinal("CP")) ? null : dataReader["CP"].ToString();
                            contratacion.Estado = dataReader.IsDBNull(dataReader.GetOrdinal("Estado")) ? null : dataReader["Estado"].ToString();
                            contratacion.MunicipioDelegacion = dataReader.IsDBNull(dataReader.GetOrdinal("MunicipioDelegacion")) ? null : dataReader["MunicipioDelegacion"].ToString();
                            contratacion.TelefonoCelular = dataReader.IsDBNull(dataReader.GetOrdinal("TelefonoCelular")) ? null : dataReader["TelefonoCelular"].ToString();
                            contratacion.NombreContactoEmergencia = dataReader.IsDBNull(dataReader.GetOrdinal("NombreContactoEmergencia")) ? null : dataReader["NombreContactoEmergencia"].ToString();
                            contratacion.TelContactoEmergencia = dataReader.IsDBNull(dataReader.GetOrdinal("TelContactoEmergencia")) ? null : dataReader["TelContactoEmergencia"].ToString();
                            contratacion.Email = dataReader.IsDBNull(dataReader.GetOrdinal("Email")) ? null : dataReader["Email"].ToString();
                            contratacion.idNacionalidad = dataReader.IsDBNull(dataReader.GetOrdinal("idNacionalidad")) ? default(int) : int.Parse(dataReader["idNacionalidad"].ToString());
                            contratacion.idEstadoCivil = dataReader.IsDBNull(dataReader.GetOrdinal("idEstadoCivil")) ? default(int) : int.Parse(dataReader["idEstadoCivil"].ToString());
                            contratacion.idCatFormaPago = dataReader.IsDBNull(dataReader.GetOrdinal("idCatFormaPago")) ? default(int) : int.Parse(dataReader["idCatFormaPago"].ToString());
                            contratacion.AltaIMSS = dataReader.IsDBNull(dataReader.GetOrdinal("AltaIMSS")) ? default(bool) : bool.Parse(dataReader["AltaIMSS"].ToString());
                            contratacion.FechaAltaIMSS = dataReader.IsDBNull(dataReader.GetOrdinal("FechaAltaIMSS")) ? default(DateTime) : DateTime.Parse(dataReader["FechaAltaIMSS"].ToString());
                            contratacion.NSS = dataReader.IsDBNull(dataReader.GetOrdinal("NSS")) ? null : dataReader["NSS"].ToString();
                            contratacion.CURP = dataReader.IsDBNull(dataReader.GetOrdinal("CURP")) ? null : dataReader["CURP"].ToString();
                            contratacion.NumCreditoInfonavit = dataReader.IsDBNull(dataReader.GetOrdinal("NumCreditoInfonavit")) ? null : dataReader["NumCreditoInfonavit"].ToString();
                            contratacion.idBanco = dataReader.IsDBNull(dataReader.GetOrdinal("idBanco")) ? default(int) : int.Parse(dataReader["idBanco"].ToString());
                            contratacion.Cta_Cheques = dataReader.IsDBNull(dataReader.GetOrdinal("Cta_Cheques")) ? null : dataReader["Cta_Cheques"].ToString();
                            contratacion.NumIdentificacionOficial = dataReader.IsDBNull(dataReader.GetOrdinal("NumIdentificacionOficial")) ? null : dataReader["NumIdentificacionOficial"].ToString();
                            contratacion.idCatEmpresaPagadora = dataReader.IsDBNull(dataReader.GetOrdinal("idCatEmpresaPagadora")) ? default(int?) : int.Parse(dataReader["idCatEmpresaPagadora"].ToString());
                            contratacion.idTipoPeriodicidad = dataReader.IsDBNull(dataReader.GetOrdinal("idTipoPeriodicidad")) ? default(int) : int.Parse(dataReader["idTipoPeriodicidad"].ToString());
                            contratacion.Date = dataReader.IsDBNull(dataReader.GetOrdinal("Date")) ? default(DateTime) : DateTime.Parse(dataReader["Date"].ToString());
                            contratacion.User = dataReader.IsDBNull(dataReader.GetOrdinal("User")) ? null : dataReader["User"].ToString();
                            contratacion.Status = dataReader.IsDBNull(dataReader.GetOrdinal("Status")) ? default(bool) : bool.Parse(dataReader["Status"].ToString());
                            contratacion.CLABEInterbancaria = dataReader.IsDBNull(dataReader.GetOrdinal("CLABEInterbancaria")) ? null : dataReader["CLABEInterbancaria"].ToString();
                            contratacion.ClaveSector = dataReader.IsDBNull(dataReader.GetOrdinal("ClaveSector")) ? null : dataReader["ClaveSector"].ToString();
                            contratacion.ClaveRegion = dataReader.IsDBNull(dataReader.GetOrdinal("ClaveRegion")) ? null : dataReader["ClaveRegion"].ToString();
                            contratacion.ClaveTipoOperacion = dataReader.IsDBNull(dataReader.GetOrdinal("ClaveTipoOperacion")) ? null : dataReader["ClaveTipoOperacion"].ToString();
                            contratacion.idcatmarca = dataReader.IsDBNull(dataReader.GetOrdinal("idcatmarca")) ? default(Int16?) : Int16.Parse(dataReader["idcatmarca"].ToString());
                            contratacion.idGrupoPago = dataReader.IsDBNull(dataReader.GetOrdinal("idGrupoPago")) ? default(int?) : int.Parse(dataReader["idGrupoPago"].ToString());
                            contratacion.IdSoluglob = dataReader.IsDBNull(dataReader.GetOrdinal("IdSoluglob")) ? default(int?) : int.Parse(dataReader["IdSoluglob"].ToString());
                            contratacion.EstatusProceso = dataReader.IsDBNull(dataReader.GetOrdinal("EstatusProceso")) ? default(int?) : int.Parse(dataReader["EstatusProceso"].ToString());
                            contratacion.Id_Per = dataReader.IsDBNull(dataReader.GetOrdinal("Id_Per")) ? default(int?) : int.Parse(dataReader["Id_Per"].ToString());
                            contratacion.SDI = dataReader.IsDBNull(dataReader.GetOrdinal("SDI")) ? default(Double?) : Double.Parse(dataReader["SDI"].ToString());
                            contratacion.SDP = dataReader.IsDBNull(dataReader.GetOrdinal("SDP")) ? default(Double?) : Double.Parse(dataReader["SDP"].ToString());
                            contratacion.SDN = dataReader.IsDBNull(dataReader.GetOrdinal("SDN")) ? default(Double?) : Double.Parse(dataReader["SDN"].ToString());
                            contratacion.idCatEmpresaPagadoraPasajes = dataReader.IsDBNull(dataReader.GetOrdinal("idCatEmpresaPagadoraPasajes")) ? default(int?) : int.Parse(dataReader["idCatEmpresaPagadoraPasajes"].ToString());
                            contratacion.idGrupoPagoPasajes = dataReader.IsDBNull(dataReader.GetOrdinal("idGrupoPagoPasajes")) ? default(int?) : int.Parse(dataReader["idGrupoPagoPasajes"].ToString());
                            contratacion.idRegionContratacion = dataReader.IsDBNull(dataReader.GetOrdinal("idRegionContratacion")) ? default(int?) : int.Parse(dataReader["idRegionContratacion"].ToString());
                            contratacion.idTipoNomina = dataReader.IsDBNull(dataReader.GetOrdinal("idTipoNomina")) ? default(int?) : int.Parse(dataReader["idTipoNomina"].ToString());


                        }
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }

                return contratacion;
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
