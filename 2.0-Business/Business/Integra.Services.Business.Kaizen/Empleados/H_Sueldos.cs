using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integra.Services.Business.Kaizen.Empleados
{
    public class H_Sueldos
    {
        public static Entities.Kaizen.Empleados.H_Sueldos Insert(Entities.Kaizen.Empleados.H_Sueldos objH_Sueldos)
        {
            Entities.Kaizen.Empleados.H_Sueldos h_sueldos = new Entities.Kaizen.Empleados.H_Sueldos();
            try
            {
                Data.Kaizen.Empleados.H_Sueldos dataH_Sueldos = new Data.Kaizen.Empleados.H_Sueldos();
                h_sueldos = dataH_Sueldos.Insert(objH_Sueldos);
                return h_sueldos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public static bool DropLast(Entities.Kaizen.Empleados.H_Sueldos objH_Sueldos)
        {
            bool result = false;
            try
            {
                Data.Kaizen.Empleados.H_Sueldos dataH_Sueldos = new Data.Kaizen.Empleados.H_Sueldos();
                result = dataH_Sueldos.DropLast(objH_Sueldos);
                return result;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
           
        }
    }
}
