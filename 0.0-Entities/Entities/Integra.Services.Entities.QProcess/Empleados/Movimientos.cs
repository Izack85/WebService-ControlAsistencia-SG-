using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integra.Services.Entities.QProcess.Empleados
{
    public class Movimientos
    {
        public int idRequisicionMovimiento { get; set; }

        public string NumeroEmpleado { get; set; }

        public string Compania { get; set; }

        public string CompaniaPasajes { get; set; }

        public string Empleado { get; set; }

        public string Nombre { get; set; }

        public string Cliente { get; set; }

        public int idCatTipoMovimiento { get; set; }

        public string TipoMovimiento { get; set; }

        public int idTipoBaja { get; set; }

        public string TipoBaja { get; set; }

        public int idMotivo { get; set; }

        public string Accion { get; set; }

        public string Motivo { get; set; }

        public string NombreMotivo { get; set; }

        public DateTime FechaBaja { get; set; }

        public DateTime FechaAplicacionCambio { get; set; }

        public int idCatPuesto { get; set; }

        public string NombrePuesto { get; set; }

        public string Puesto { get; set; }

        public int idCeCo { get; set; }

        public string CentroCosto { get; set; }

        public int idCeCoNuevo { get; set; }

        public string CentroCostoNuevo { get; set; }

        public string CodigoCeCo { get; set; }

        public int idUCos { get; set; }

        public string ClaveUCo { get; set; }

        public int idUCosNuevo { get; set; }

        public string ClaveUCoNueva { get; set; }

        public string CodigoUCos { get; set; }

        public string Ubicacion { get; set; }

        public Double Sueldo { get; set; }

        public Double Bono { get; set; }

        public int idCatPuestoNuevo { get; set; }

        public string NombrePuestoNuevo { get; set; }

        public string PuestoNuevo { get; set; }

        public Double SueldoNuevo { get; set; }

        public Double BonoNuevo { get; set; }

        public int EstatusProceso { get; set; }

        public string GrupoPago { get; set; }

        public string GrupoPagoPasajes { get; set; }

        public int NumChecador { get; set; }

        public int Id_Vac_Nueva { get; set; }

        public int IdCambio { get; set; }

        public string DescripcionCambio { get; set; }

        public string Usuario { get; set; }
    }
}
