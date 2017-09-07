using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Entities = Integra.Services.Entities.Kaizen;
using Business = Integra.Services.Business.Kaizen;
using Integra.Services.Entities.QProcess;
using BusinessSG = Integra.Services.Business;
using Integra.Services.Entities.SoluglobAdministrativo;

namespace Integra.Services.Soluglob_Integra
{
    public class Soluglob_Integra : ISoluglob_Integra
    {
         public int AltaEmpleadoSG(int IdEntrevistaCandidato)
        {
            Entities.QProcess.Empleados.AltaSoluglob oQProcessSoluglob = new Entities.QProcess.Empleados.AltaSoluglob();
            int NumeroEmpleado = BusinessSG.QProcess.Empleado.GetLayoutSoluglob(IdEntrevistaCandidato);
            return NumeroEmpleado;
        }

        public DataSet GetIncidenciasSG(DateTime FechaInicio, DateTime FechaFin)
        {
            DataSet dsIncidenciasSG = Business.SoluglobChecador.Incidencias.GetIncidencias(FechaInicio, FechaFin);
            return dsIncidenciasSG;
        }
                
        public bool MovimientoEmpleadoSG(string NumEmpleado, int IdRequisicionMovimiento)
        {
            Entities.SoluglobAdministrativo.Personal objEmpleadoSG = Business.QProcess.Empleado.MovimientoEmpleadoSG(NumEmpleado, IdRequisicionMovimiento);
            return objEmpleadoSG != null ? true : false;
        }

        //public bool ObtieneEmpleadoSG(string NumEmpleado)
        //{
        //    Entities.QProcess.Empleados.AltaSoluglob objEmpleadoSG = Business.QProcess.Empleado.GetOneByNumChecador(Convert.ToInt32(NumEmpleado));
        //    return objEmpleadoSG != null ? true : false;
        //}

        //public bool InsertEmpleado(Entities.QProcess.Empleados.QProcessKaizen EmpleadoQP)
        //{
        //    Entities.Kaizen.Empleados.Empleado empleado = Business.Kaizen.Empleados.Empleado.Insert(EmpleadoQP);
        //    return true;
        //}

        //public Entities.Kaizen.Empleados.Empleado GetOneEmpleado(string Compania, string NumEmpleado)
        //{
        //    Entities.Kaizen.Empleados.Empleado empleado = Business.Kaizen.Empleados.Empleado.GetOne(Compania, NumEmpleado);
        //    return empleado;
        //}

        //public List<Entities.Kaizen.Empleados.Empleado> GetAllEmpleado()
        //{
        //    List<Entities.Kaizen.Empleados.Empleado> empleadoCollection = Business.Kaizen.Empleados.Empleado.GetAll();
        //    return empleadoCollection;
        //}

        //public string UpdateEmpleado(Entities.Kaizen.Empleados.Empleado Empleado)
        //{
        //    Entities.Kaizen.Empleados.Empleado empleado = Business.Kaizen.Empleados.Empleado.Update(Empleado);
        //    return empleado != null ? empleado.compania + empleado.numEmpleado : "0";
        //    //return empleado != null ? true : false;
        //}

        //public void DeleteEmpleado(string Compania, string NumEmpleado)
        //{
        //    Business.Kaizen.Empleados.Empleado.Delete(Compania, NumEmpleado);
        //}

        //public int InsertEmpleadoSG(Entities.QProcess.Empleados.QProcessSoluglob EmpleadoQP)
        //{
        //   return BusinessSG.SoluglobChecador.Empleados.Insert(EmpleadoQP);
        //}      

        //private bool DeleteEmpleadoSG(int NumeroNomina)
        //{
        //    return BusinessSG.QProcess.Empleado.DeleteEmpleadoSoluglob(NumeroNomina);
        //}

        //private bool UpdateEmpleadoSG(Entities.QProcess.Empleados.QProcessSoluglob EmpleadoQP)
        //{
        //    BusinessSG.QProcess.Empleado.UpdateEmpleadoSoluglob(EmpleadoQP);
        //    return true;
        //}
    }
}
