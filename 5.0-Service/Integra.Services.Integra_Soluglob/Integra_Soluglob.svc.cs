using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Integra.Services.Entities.Kaizen.Empleados;
using Integra.Services.Entities.QProcess;
using Entities = Integra.Services.Entities;

namespace Integra.Services.Integra_Soluglob
{
    public class Integra_Soluglob : IIntegra_Soluglob
    {      
        public bool AltaEmpleado(int idEmpleado)
        {
            Entities.Kaizen.Empleados.Empleado empleado = Business.QProcess.Empleado.GetLayoutKaizen(idEmpleado);
            return empleado != null ? true : false;
        }

        //public bool BajaEmpleado(string compania, string numEmpleado, string motivo, int requisicionMovimiento)
        //{
        //    Entities.Kaizen.Empleados.Empleado empleado = Business.QProcess.Empleado.BajaEmpleadoKaizen(compania, numEmpleado, motivo, requisicionMovimiento);
        //    return empleado != null ? true : false;
        //}

        public bool MovimientoEmpleadoKaizen(string NumEmpleado, int IdRequisicionMovimiento)
        {
            Entities.QProcess.Empleados.Movimientos empleado = Business.QProcess.Empleado.MovimientoEmpleadoKaizen(NumEmpleado, IdRequisicionMovimiento);
            return empleado != null ? true : false;
        }


        //public bool InsertEmpleadoKaizen(Entities.QProcess.Empleado objEmpleadoQP)
        //{
        //    Entities.Kaizen.Empleados.Empleado empleado = Business.Kaizen.Empleados.Empleado.Insert(objEmpleadoQP);
        //    return empleado != null ? true : false;
        //}

        //public bool UpdateEmpleadoChecador(Entities.QProcess.Empleado objEmpleadoQP)
        //{
        //    Entities.SoluglobChecador.Usuarios usuariosChecador = Business.SoluglobChecador.Usuarios.UpdateNumEmpleado(objEmpleadoQP);
        //    return usuariosChecador != null ? true : false;
        //}

        //public bool UpdateEmpleadoAdministrativo(Entities.QProcess.Empleado objEmpleadoQP)
        //{
        //    Entities.SoluglobAdministrativo.Personal personalAdministrativo = Business.SoluglobAdministrativo.Personal.UpdateNumEmpleado(objEmpleadoQP);
        //    return personalAdministrativo != null ? true : false;
        //}

    }
}
