using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integra.Services.Entities.SoluglobChecador
{
    public class Empleados
    {
        public int Numero_Nomina { get; set; }

        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public string Puesto { get; set; }

        public string Departamento { get; set; }

        public string Telefono { get; set; }

        public string Huella_Template { get; set; }

        public string Huella_Img1 { get; set; }

        public string Huella_Img2 { get; set; }

        public string Huella_Img3 { get; set; }

        public string Huella_Img4 { get; set; }

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

        public int? Dias_Semana { get; set; }

        public DateTime? Fecha_Ingresos { get; set; }

        public string Pagos_HExtras { get; set; }

        public DateTime? Fechas_Registro { get; set; }

        public string Unidad_Costos { get; set; }

        public DateTime? Fecha_Reingreso { get; set; }

        public string Centro_Costos { get; set; }

        public int? Numero_Nominas { get; set; }

        public string Remuneracion { get; set; }

        public DateTime? Fecha_Alta_Imss { get; set; }

        public DateTime? Fecha_Baja_Sistema { get; set; }

        public int? Estatus_Edicion { get; set; }

        public DateTime? Fecha_Modificacion { get; set; }

        public bool? Bono { get; set; }

        public string Responsable_Bono { get; set; }
    }
}
