using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integra.Services.Entities.QProcess
{
    public class Contratacion
    {
        public int idContratacion { get; set; }

        public int idRequisicionContratacion { get; set; }

        public int idEntrevistaCandidato { get; set; }

        public string NumeroEmpleado { get; set; }

        public int idCatTipocontrato { get; set; }

        public DateTime FechaContrato { get; set; }

        public DateTime FechaInicioLaboral { get; set; }

        public DateTime FechaAplicaBono { get; set; }

        public DateTime FechaFinContrato { get; set; }

        public Double SueldoAutorizado { get; set; }

        public Double BonoAutorizado { get; set; }

        public Double SueldoDiario { get; set; }

        public string Calle { get; set; }

        public string NumeroExt { get; set; }

        public string NumeroInt { get; set; }

        public string Colonia { get; set; }

        public string CP { get; set; }

        public string Estado { get; set; }

        public string MunicipioDelegacion { get; set; }

        public string TelefonoCelular { get; set; }

        public string NombreContactoEmergencia { get; set; }

        public string TelContactoEmergencia { get; set; }

        public string Email { get; set; }

        public int idNacionalidad { get; set; }

        public int idEstadoCivil { get; set; }

        public int idCatFormaPago { get; set; }

        public bool AltaIMSS { get; set; }

        public DateTime FechaAltaIMSS { get; set; }

        public string NSS { get; set; }

        public string CURP { get; set; }

        public string NumCreditoInfonavit { get; set; }

        public int idBanco { get; set; }

        public string Cta_Cheques { get; set; }

        public string NumIdentificacionOficial { get; set; }

        public int? idCatEmpresaPagadora { get; set; }

        public int idTipoPeriodicidad { get; set; }

        public DateTime Date { get; set; }

        public string User { get; set; }

        public bool Status { get; set; }

        public string CLABEInterbancaria { get; set; }

        public string ClaveSector { get; set; }

        public string ClaveRegion { get; set; }

        public string ClaveTipoOperacion { get; set; }

        public Int16? idcatmarca { get; set; }

        public int? idGrupoPago { get; set; }

        public int? IdSoluglob { get; set; }

        public int? EstatusProceso { get; set; }

        public int? Id_Per { get; set; }

        public Double? SDI { get; set; }

        public Double? SDP { get; set; }

        public Double? SDN { get; set; }

        public int? idCatEmpresaPagadoraPasajes { get; set; }

        public int? idGrupoPagoPasajes { get; set; }

        public int? idRegionContratacion { get; set; }

        public int? idTipoNomina { get; set; }

    }

}
