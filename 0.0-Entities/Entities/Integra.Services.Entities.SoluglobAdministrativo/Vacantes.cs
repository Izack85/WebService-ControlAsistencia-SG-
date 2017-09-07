using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integra.Services.Entities.SoluglobAdministrativo
{
    public class Vacantes
    {
        public int Id_Vac { get; set; }

        public int? Id_Per { get; set; }

        public string Desc_Vacante { get; set; }

        public int? CeCo { get; set; }

        public string UCos { get; set; }

        public string Ubicacion { get; set; }

        public int? Estatus_Vacante { get; set; }

        public int? Segmento { get; set; }

        public int? Gerencia { get; set; }

        public int? Puesto { get; set; }

        public string Verificacion { get; set; }

        public string Depto { get; set; }

        public int? User_Mod { get; set; }

        public DateTime? FecMod { get; set; }

        public int? Transicion { get; set; }

        public int? Prioridad { get; set; }
    }
}
