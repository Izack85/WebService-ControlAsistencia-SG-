using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integra.Services.Business.Kaizen.Empleados
{
    public class H_Laboral
    {
        public static Entities.Kaizen.Empleados.H_Laboral Insert(Entities.Kaizen.Empleados.H_Laboral objH_Laboral)
        {
            Entities.Kaizen.Empleados.H_Laboral h_laboral = new Entities.Kaizen.Empleados.H_Laboral();
            try
            {
                Data.Kaizen.Empleados.H_Laboral dataH_Laboral = new Data.Kaizen.Empleados.H_Laboral();
                h_laboral = dataH_Laboral.Insert(objH_Laboral);
                return h_laboral;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static Entities.Kaizen.Empleados.H_Laboral GetOne(string Compania, string NumEmpleado, string GrupoPago)
        {
            Entities.Kaizen.Empleados.H_Laboral h_laboral = new Entities.Kaizen.Empleados.H_Laboral();
            try
            {
                Data.Kaizen.Empleados.H_Laboral dataH_Laboral = new Data.Kaizen.Empleados.H_Laboral();
                h_laboral = dataH_Laboral.GetOne(Compania, NumEmpleado, GrupoPago);
                return h_laboral;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static Entities.Kaizen.Empleados.H_Laboral Update(Entities.Kaizen.Empleados.H_Laboral objH_Laboral)
        {
            Entities.Kaizen.Empleados.H_Laboral h_laboral = new Entities.Kaizen.Empleados.H_Laboral();
            try
            {
                Data.Kaizen.Empleados.H_Laboral dataH_Laboral = new Data.Kaizen.Empleados.H_Laboral();
                h_laboral = dataH_Laboral.Update(objH_Laboral);
                return h_laboral;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static Entities.Kaizen.Empleados.H_Laboral UpdatePuesto(Entities.Kaizen.Empleados.H_Laboral objH_Laboral)
        {
            Entities.Kaizen.Empleados.H_Laboral h_laboral = new Entities.Kaizen.Empleados.H_Laboral();
            try
            {
                Data.Kaizen.Empleados.H_Laboral dataH_Laboral = new Data.Kaizen.Empleados.H_Laboral();
                h_laboral = dataH_Laboral.UpdatePuesto(objH_Laboral);
                return h_laboral;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static void DropLast(Entities.Kaizen.Empleados.H_Laboral objH_Laboral)
        {
            Data.Kaizen.Empleados.H_Laboral dataH_Laboral = new Data.Kaizen.Empleados.H_Laboral();
            dataH_Laboral.DropLast(objH_Laboral);
        }
    }
}
