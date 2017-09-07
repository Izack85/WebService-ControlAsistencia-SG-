using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Integra.Services.Entities.Kaizen.Enum
{
    public enum EstatusProceso
    {
        QProcess,
        Soluglob,
        Kaizen
    }

    public enum TipoRollback
    {
        Altas = 1,
        Cambios = 2,
        Bajas = 3
    }

    public enum TipoMovimiento
    {
        CambioSueldo = 1,
        CambioSituacionLaboral = 2,
        BajaEmpleado = 3
    }

    public enum TipoCambio
    {        
        Puesto = 1,
        CentroCostos = 2,
        UnidadCostos = 3,
        Sueldo = 4,
        PuestoCentroCostos = 5,
        PuestoUnidadCostos = 6,
        PuestoSueldo = 7,
        CentroCostosUnidadCostos = 8,
        CentroCostosSueldo = 9,
        UnidadCostosSueldo = 10,
        PuestoCentroCostosUnidadCostos = 11,
        PuestoCentroCostosSueldo = 12,
        PuestoUnidadCostosSueldo = 13,
        CentroCostosUnidadCostosSueldo = 14,
        Todos = 15
    }

    public enum TipoDato
    {
        String,
        Integer,
        DateTime,
        Double
    }
     

}
