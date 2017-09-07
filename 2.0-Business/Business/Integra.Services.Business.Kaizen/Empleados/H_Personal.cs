using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integra.Services.Business.Kaizen.Empleados
{
    public class H_Personal
    {
        public static Entities.Kaizen.Empleados.H_Personal Insert(Entities.Kaizen.Empleados.H_Personal objH_Personal)
        {
            Entities.Kaizen.Empleados.H_Personal h_personal = new Entities.Kaizen.Empleados.H_Personal();
            try
            {
                Data.Kaizen.Empleados.H_Personal dataH_Personal = new Data.Kaizen.Empleados.H_Personal();
                h_personal = dataH_Personal.Insert(objH_Personal);
                return h_personal;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
