using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Entities = Integra.Services.Entities;

namespace Integra.Services.Integra_Soluglob
{
    [ServiceContract]
    public interface IIntegra_Soluglob
    {
        [OperationContract]
        [WebInvoke(
          UriTemplate = "AltaEmpleado",
          Method = "POST",
          ResponseFormat = WebMessageFormat.Json,
          RequestFormat = WebMessageFormat.Json,
          BodyStyle = WebMessageBodyStyle.Wrapped
        )]
        bool AltaEmpleado(int idEmpleado);

        //[OperationContract]
        //[WebInvoke(
        //  UriTemplate = "BajaEmpleado",
        //  Method = "POST",
        //  ResponseFormat = WebMessageFormat.Json,
        //  RequestFormat = WebMessageFormat.Json,
        //  BodyStyle = WebMessageBodyStyle.Wrapped
        //)]
        //bool BajaEmpleado(string compania, string numEmpleado, string motivo, int requisicionMovimiento);

        [OperationContract]
        [WebInvoke(
          UriTemplate = "MovimientoEmpleadoKaizen",
          Method = "POST",
          ResponseFormat = WebMessageFormat.Json,
          RequestFormat = WebMessageFormat.Json,
          BodyStyle = WebMessageBodyStyle.Wrapped
        )]
        bool MovimientoEmpleadoKaizen(string NumEmpleado, int IdRequisicionMovimiento);

        //[OperationContract]
        //[WebInvoke(
        //  UriTemplate = "InsertEmpleadoKaizen",
        //  Method = "POST",
        //  ResponseFormat = WebMessageFormat.Json,
        //  RequestFormat = WebMessageFormat.Json,
        //  BodyStyle = WebMessageBodyStyle.Wrapped
        // )]
        //bool InsertEmpleadoKaizen(Entities.QProcess.Empleado objEmpleadoQP);

        //[OperationContract]
        //[WebInvoke(
        //  UriTemplate = "UpdateEmpleadoChecador",
        //  Method = "POST",
        //  ResponseFormat = WebMessageFormat.Json,
        //  RequestFormat = WebMessageFormat.Json,
        //  BodyStyle = WebMessageBodyStyle.Wrapped
        // )]
        //bool UpdateEmpleadoChecador(Entities.QProcess.Empleado objEmpleadoQP);

        //[OperationContract]
        //[WebInvoke(
        // UriTemplate = "UpdateEmpleadoAdministrativo",
        // Method = "POST",
        // ResponseFormat = WebMessageFormat.Json,
        // RequestFormat = WebMessageFormat.Json,
        // BodyStyle = WebMessageBodyStyle.Wrapped
        //)]
        //bool UpdateEmpleadoAdministrativo(Entities.QProcess.Empleado objEmpleadoQP);
    }

}
