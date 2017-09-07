using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integra.Services.Entities.Kaizen.Empleados
{
    public class Empleado
    {
        public string compania { get; set; }

        public string companiaPasajes { get; set; }

        public string numEmpleado { get; set; }

        public string apellido_paterno { get; set; }

        public string apellido_materno { get; set; }

        public string nombres { get; set; }

        public string nombre { get; set; }

        public string path_foto { get; set; }

        public string rfc { get; set; }

        public string curp { get; set; }

        public string elector { get; set; }

        public string cartilla { get; set; }

        public string licencia { get; set; }

        public string numero_imss { get; set; }

        public string tipo_sangre { get; set; }

        public Int16? sexo { get; set; }

        public string tratamiento { get; set; }

        public string nivel_estudio { get; set; }

        public DateTime? fecha_nac { get; set; }

        public string lugar_nac { get; set; }

        public string pais_nac { get; set; }

        public string estado_nac { get; set; }

        public string nombre_padre { get; set; }

        public string nombre_madre { get; set; }

        public Int16? origen { get; set; }

        public string nacionalidad { get; set; }

        public Int16? tipo_pago { get; set; }

        public string banco { get; set; }

        public string sucursal { get; set; }

        public string cta_cheques { get; set; }

        public string fuente { get; set; }

        public Int16? tarjeta { get; set; }

        public Int16? destajos { get; set; }

        public string turno { get; set; }

        public string expediente { get; set; }

        public string infonavit { get; set; }

        public Int16? tipo_pago_infonavit { get; set; }

        public Decimal? factor { get; set; }

        public string clabe { get; set; }

        public string banco_alt { get; set; }

        public string sucursal_alt { get; set; }

        public string cta_cheques_alt { get; set; }

        public string clabe_alt { get; set; }

        public string tarjeta_vales { get; set; }

        public string path_firma { get; set; }

        public string estatus { get; set; }

        public Int16? estado_civil { get; set; }

        public string ip { get; set; }

        public string mac_address { get; set; }

        public string usuario { get; set; }

        public string tarjeta_vales_ant { get; set; }

        public string Correo { get; set; }

        public string Tarjeta_VGasolina { get; set; }

        public string entidadLaboral { get; set; }
    }
}
