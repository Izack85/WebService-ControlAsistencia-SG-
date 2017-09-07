using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integra.Services.Entities.SoluglobChecador
{
    public class Usuarios
    {
        public int Numero_Nomina { get; set; }

        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public string Puesto { get; set; }

        public string Departamento { get; set; }

        public string Telefono { get; set; }

        public string Huella_Bin1 { get; set; }

        public string Huella_Img1 { get; set; }

        public string Huella_Bin2 { get; set; }

        public string Huella_Bin3 { get; set; }

        public string Huella_Bin4 { get; set; }

        public bool Estatus { get; set; }

        public DateTime? Fecha_Alta { get; set; }

        public DateTime? Fecha_Baja { get; set; }

        public string Empresa { get; set; }

        public string Ubicacion { get; set; }

        public string MotivoBaja { get; set; }

        public bool? Caso_Especial { get; set; }

        public Guid? msrepl_tran_version { get; set; }

        public int? Registrado { get; set; }

        public string Imss { get; set; }

        public int? Dias_semana { get; set; }

        public DateTime? fecha_ingresos { get; set; }

        public string pagos_hextras { get; set; }

        public DateTime? Fechas_registro { get; set; }

        public string unidad_costos { get; set; }

        public DateTime? Fecha_Reingreso { get; set; }

        public string Centro_costos { get; set; }

        public int? Numero_Nominas { get; set; }

        public string Remuneracion { get; set; }

        public DateTime? Fecha_Alta_Imss { get; set; }

        public DateTime? Fecha_Baja_sistema { get; set; }

        public int? Estatus_Edicion { get; set; }

        public DateTime? Fecha_Modificacion { get; set; }

        public bool? Bono { get; set; }

        public string Responsable_Bono { get; set; }
    }
}
