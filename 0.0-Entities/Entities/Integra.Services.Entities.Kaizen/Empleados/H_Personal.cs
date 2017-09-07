using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integra.Services.Entities.Kaizen.Empleados
{
    public class H_Personal
    {
        public string Compania { get; set; }

        public string companiaPasajes { get; set; }

        public string numEmpleado { get; set; }

        public DateTime Fecha { get; set; }

        public string Direccion { get; set; }

        public string Poblacion { get; set; }

        public string Ciudad { get; set; }

        public string Colonia { get; set; }

        public string Cp { get; set; }

        public string Pais { get; set; }

        public string Estado { get; set; }

        public Int16? Estado_Civil { get; set; }
        
        public string Usuario { get; set; }

        public string Numero_Ext { get; set; }

        public string Numero_Int { get; set; }

        public string Ip { get; set; }

        public string Mac_Address { get; set; }
    }
}
