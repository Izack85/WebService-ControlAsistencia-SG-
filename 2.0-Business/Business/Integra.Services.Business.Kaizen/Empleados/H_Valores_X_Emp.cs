using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integra.Services.Business.Kaizen.Empleados
{
    public class H_Valores_X_Emp
    {
        public static Entities.Kaizen.Empleados.H_Valores_X_Emp Insert(Entities.Kaizen.Empleados.H_Valores_X_Emp objH_Valores_X_Emp)
        {
            Entities.Kaizen.Empleados.H_Valores_X_Emp h_valores_x_emp = new Entities.Kaizen.Empleados.H_Valores_X_Emp();
            try
            {
                Data.Kaizen.Empleados.H_Valores_X_Emp dataH_Valores_X_Emp = new Data.Kaizen.Empleados.H_Valores_X_Emp();
                h_valores_x_emp = dataH_Valores_X_Emp.Insert(objH_Valores_X_Emp);
                return h_valores_x_emp;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }        

        public static Entities.Kaizen.Empleados.H_Valores_X_Emp GetOne(string Compania, string NumEmpleado)
        {
            Entities.Kaizen.Empleados.H_Valores_X_Emp h_valores_x_emp = new Entities.Kaizen.Empleados.H_Valores_X_Emp();
            try
            {
                Data.Kaizen.Empleados.H_Valores_X_Emp dataH_Valores_X_Emp = new Data.Kaizen.Empleados.H_Valores_X_Emp();
                h_valores_x_emp = dataH_Valores_X_Emp.GetOne(Compania, NumEmpleado);
                return h_valores_x_emp;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public static Entities.Kaizen.Empleados.H_Valores_X_Emp Update(Entities.Kaizen.Empleados.H_Valores_X_Emp objH_Valores_X_Emp)
        {
            Entities.Kaizen.Empleados.H_Valores_X_Emp h_valores_x_emp = new Entities.Kaizen.Empleados.H_Valores_X_Emp();
            try
            {
                Data.Kaizen.Empleados.H_Valores_X_Emp dataH_Valores_X_Emp = new Data.Kaizen.Empleados.H_Valores_X_Emp();
                h_valores_x_emp = dataH_Valores_X_Emp.Update(objH_Valores_X_Emp);
                return h_valores_x_emp;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public static Entities.Kaizen.Empleados.H_Valores_X_Emp UpdateCeco(Entities.Kaizen.Empleados.H_Valores_X_Emp objH_Valores_X_Emp)
        {
            Entities.Kaizen.Empleados.H_Valores_X_Emp h_valores_x_emp = new Entities.Kaizen.Empleados.H_Valores_X_Emp();
            try
            {
                Data.Kaizen.Empleados.H_Valores_X_Emp dataH_Valores_X_Emp = new Data.Kaizen.Empleados.H_Valores_X_Emp();
                h_valores_x_emp = dataH_Valores_X_Emp.UpdateCeco(objH_Valores_X_Emp);
                return h_valores_x_emp;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public static Entities.Kaizen.Empleados.H_Valores_X_Emp UpdateUCo(Entities.Kaizen.Empleados.H_Valores_X_Emp objH_Valores_X_Emp)
        {
            Entities.Kaizen.Empleados.H_Valores_X_Emp h_valores_x_emp = new Entities.Kaizen.Empleados.H_Valores_X_Emp();
            try
            {
                Data.Kaizen.Empleados.H_Valores_X_Emp dataH_Valores_X_Emp = new Data.Kaizen.Empleados.H_Valores_X_Emp();
                h_valores_x_emp = dataH_Valores_X_Emp.UpdateUCo(objH_Valores_X_Emp);
                return h_valores_x_emp;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public static Entities.Kaizen.Empleados.H_Valores_X_Emp GetOneByNombre(string Compania, string NumEmpleado, string Nombre)
        {
            Entities.Kaizen.Empleados.H_Valores_X_Emp h_valores_x_emp = new Entities.Kaizen.Empleados.H_Valores_X_Emp();
            try
            {
                Data.Kaizen.Empleados.H_Valores_X_Emp dataH_Valores_X_Emp = new Data.Kaizen.Empleados.H_Valores_X_Emp();
                h_valores_x_emp = dataH_Valores_X_Emp.GetOneByNombre(Compania, NumEmpleado, Nombre);
                return h_valores_x_emp;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public static void DropLast(Entities.Kaizen.Empleados.H_Valores_X_Emp objH_Valores_X_Emp)
        {
            Data.Kaizen.Empleados.H_Valores_X_Emp dataH_Valores_X_Emp = new Data.Kaizen.Empleados.H_Valores_X_Emp();
            dataH_Valores_X_Emp.DropLast(objH_Valores_X_Emp);
        }
    }
}
