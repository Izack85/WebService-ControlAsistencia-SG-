using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Entities = Integra.Services.Entities.QProcess;

namespace Integra.Services.Soluglob_Integra
{
    [ServiceContract]
    public interface ISoluglob_Integra
    {
        [OperationContract]
        [WebInvoke(
          UriTemplate = "AltaEmpleadoSG",
          Method = "POST",
          ResponseFormat = WebMessageFormat.Json,
          RequestFormat = WebMessageFormat.Json,
          BodyStyle = WebMessageBodyStyle.Wrapped
        )]
        int AltaEmpleadoSG(int IdEntrevistaCandidato);

        [OperationContract]
        [WebInvoke(
          UriTemplate = "GetIncidenciasSG",
          Method = "POST",
          ResponseFormat = WebMessageFormat.Json,
          RequestFormat = WebMessageFormat.Json,
          BodyStyle = WebMessageBodyStyle.Wrapped
        )]
        System.Data.DataSet GetIncidenciasSG(DateTime FechaInicio, DateTime FechaFin);

        [OperationContract]
        [WebInvoke(
          UriTemplate = "MovimientoEmpleadoSG",
          Method = "POST",
          ResponseFormat = WebMessageFormat.Json,
          RequestFormat = WebMessageFormat.Json,
          BodyStyle = WebMessageBodyStyle.Wrapped
        )]
        bool MovimientoEmpleadoSG(string NumEmpleado, int IdRequisicionMovimiento);

        //[OperationContract]
        //[WebInvoke(
        // UriTemplate = "ObtieneEmpleadoSG",
        // Method = "POST",
        // ResponseFormat = WebMessageFormat.Json,
        // RequestFormat = WebMessageFormat.Json,
        // BodyStyle = WebMessageBodyStyle.Wrapped
        //)]
        //bool ObtieneEmpleadoSG(string NumEmpleado);

        //[OperationContract]
        //[WebInvoke(
        // UriTemplate = "InsertEmpleado",
        // Method = "POST",
        // ResponseFormat = WebMessageFormat.Json,
        // RequestFormat = WebMessageFormat.Json,
        // BodyStyle = WebMessageBodyStyle.Wrapped
        //)]
        //bool InsertEmpleado(Entities.QProcess.Empleados.QProcessKaizen EmpleadoQP);

        //[OperationContract]
        //[WebInvoke(
        //  UriTemplate = "GetOneEmpleado",
        //  Method = "POST",
        //  ResponseFormat = WebMessageFormat.Json,
        //  RequestFormat = WebMessageFormat.Json,
        //  BodyStyle = WebMessageBodyStyle.Wrapped
        //)]
        //Entities.Kaizen.Empleados.Empleado GetOneEmpleado(string Compania, string NumEmpleado);

        //[OperationContract]
        //[WebInvoke(
        //  UriTemplate = "GetAllEmpleado",
        //  Method = "POST",
        //  ResponseFormat = WebMessageFormat.Json,
        //  RequestFormat = WebMessageFormat.Json,
        //  BodyStyle = WebMessageBodyStyle.Wrapped
        //)]
        //List<Entities.Kaizen.Empleados.Empleado> GetAllEmpleado();

        //[OperationContract]
        //[WebInvoke(
        //  UriTemplate = "UpdateEmpleado",
        //  Method = "POST",
        //  ResponseFormat = WebMessageFormat.Json,
        //  RequestFormat = WebMessageFormat.Json,
        //  BodyStyle = WebMessageBodyStyle.Wrapped
        //)]
        //string UpdateEmpleado(Entities.Kaizen.Empleados.Empleado Empleado);

        //[OperationContract]
        //[WebInvoke(
        //  UriTemplate = "DeleteEmpleado",
        //  Method = "POST",
        //  ResponseFormat = WebMessageFormat.Json,
        //  RequestFormat = WebMessageFormat.Json,
        //  BodyStyle = WebMessageBodyStyle.Wrapped
        //)]
        //void DeleteEmpleado(string Compania, string NumEmpleado);

        //[OperationContract]
        //[WebInvoke(
        //  UriTemplate = "InsertEmpleadoSG",
        //  Method = "POST",
        //  ResponseFormat = WebMessageFormat.Json,
        //  RequestFormat = WebMessageFormat.Json,
        //  BodyStyle = WebMessageBodyStyle.Wrapped
        //)]
        //int InsertEmpleadoSG(Entities.QProcess.Empleados.QProcessSoluglob EmpleadoQP);       

        //[OperationContract]
        //[WebInvoke(
        //  UriTemplate = "DeleteEmpleadoSG",
        //  Method = "POST",
        //  ResponseFormat = WebMessageFormat.Json,
        //  RequestFormat = WebMessageFormat.Json,
        //  BodyStyle = WebMessageBodyStyle.Wrapped
        //)]
        //bool DeleteEmpleadoSG(int NumeroNomina);
    }
}
