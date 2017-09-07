using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integra.Services.Business.Kaizen.Empleados
{
    public class Tel_Empleados
    {
        public static Entities.Kaizen.Empleados.Tel_Empleados Insert(Entities.Kaizen.Empleados.Tel_Empleados objTel_Empleados)
        {
            Entities.Kaizen.Empleados.Tel_Empleados tel_empleados = new Entities.Kaizen.Empleados.Tel_Empleados();
            try
            {
                Data.Kaizen.Empleados.Tel_Empleados dataTel_Empleados = new Data.Kaizen.Empleados.Tel_Empleados();
                tel_empleados = dataTel_Empleados.Insert(objTel_Empleados);
                return tel_empleados;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
