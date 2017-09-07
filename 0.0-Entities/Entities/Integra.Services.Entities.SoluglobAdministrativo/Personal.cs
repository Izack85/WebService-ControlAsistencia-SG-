using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integra.Services.Entities.SoluglobAdministrativo
{
    public class Personal
    {
        public int Id_Per { get; set; }

        public int? Num_Checador { get; set; }

        public int? Nomi_Camb { get; set; }

        public DateTime? FecReg { get; set; }

        public string Nombre { get; set; }

        public int? Sexo { get; set; }

        public int? Edad { get; set; }

        public string NSS { get; set; }

        public string CURP { get; set; }

        public string Calle { get; set; }

        public string Numero { get; set; }

        public string Mz { get; set; }

        public string Lt { get; set; }

        public string Colonia { get; set; }

        public string Municipio { get; set; }

        public string Ciudad { get; set; }

        public string Estado { get; set; }

        public string CP { get; set; }

        public string Tel { get; set; }

        public string Cel { get; set; }

        public string Email { get; set; }

        public decimal? Sueldo { get; set; }

        public int? Jefe { get; set; }

        public string Horario { get; set; }

        public int? Estatus { get; set; }

        public int? User_Mod { get; set; }

        public DateTime? FecMod { get; set; }

        public int? AplicaBono { get; set; }
    }
}
