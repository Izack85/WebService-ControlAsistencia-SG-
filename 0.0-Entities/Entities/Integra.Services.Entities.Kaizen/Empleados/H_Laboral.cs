using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integra.Services.Entities.Kaizen.Empleados
{
    public class H_Laboral
    {
        public string Compania { get; set; }

        public string companiaPasajes { get; set; }

        public string numEmpleado { get; set; }

        public DateTime Fecha { get; set; }

        public Int16 Sec { get; set; }

        public string Accion { get; set; }

        public string Motivo { get; set; }

        public string Grupo_Pago { get; set; }

        public string Grupo_Pago_Pasajes { get; set; }

        public Int16? Tipo_Contrato { get; set; }

        public DateTime? Fecha_Ingreso { get; set; }

        public DateTime? Fecha_Antiguedad1 { get; set; }

        public DateTime? Fecha_Antiguedad2 { get; set; }

        public DateTime? Fecha_Antiguedad3 { get; set; }

        public Int16? Duracion { get; set; }

        public DateTime? Fecha_Vento { get; set; }

        public DateTime? Fecha_Baja { get; set; }

        public Int16? Tipo_Salario { get; set; }

        public string Tipo_Empleado { get; set; }

        public string Localidad { get; set; }

        public string Departamento { get; set; }

        public string Puesto { get; set; }

        public string Dependencia { get; set; }

        public string Cliente { get; set; }

        public string Tipo_De_Operacion { get; set; }

        public string Region { get; set; }

        public string Sector { get; set; }

        public string Usuario { get; set; }

        public Int16? Sindicalizado { get; set; }

        public string Ip { get; set; }

        public string Mac_Address { get; set; }

        public int RegistroMovimientoId { get; set; }

        public int RegistroMovimientoIdPasajes { get; set; }
        
    }
}
