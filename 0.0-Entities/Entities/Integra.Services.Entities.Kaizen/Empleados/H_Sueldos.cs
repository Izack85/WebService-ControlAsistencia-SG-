using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integra.Services.Entities.Kaizen.Empleados
{
    public class H_Sueldos
    {
        public string Compania { get; set; }

        public string companiaPasajes { get; set; }

        public string numEmpleado { get; set; }

        public DateTime Fecha { get; set; }

        public string Tipo_Sueldo { get; set; }

        public Double Sueldo { get; set; }

        public string Usuario { get; set; }
        
        public string Ip { get; set; }

        public string Mac_Address { get; set; }
    }
}
