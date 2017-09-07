using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integra.Services.Entities.SoluglobAdministrativo
{
    public class Horarios
    {
        public int? Numero_Nomina { get; set; }

        public string Lunes_Entrada { get; set; }

        public string Lunes_Salida { get; set; }
                      
        public string Martes_Entrada { get; set; }
                      
        public string Martes_Salida { get; set; }
                      
        public string Miercoles_Entrada { get; set; }
                      
        public string Miercoles_Salida { get; set; }
                      
        public string Jueves_Entrada { get; set; }
                      
        public string Jueves_Salida { get; set; }
                      
        public string Viernes_Entrada { get; set; }
                      
        public string Viernes_Salida { get; set; }
                      
        public string Sabado_Entrada { get; set; }
                      
        public string Sabado_Salida { get; set; }
                      
        public string Domingo_Entrada { get; set; }
                      
        public string Domingo_Salida { get; set; }
                      
        public string Fecha_Modificacion { get; set; }

        public Guid? msrepl_tran_version { get; set; }

        public int Estatus { get; set; }
    }
}
