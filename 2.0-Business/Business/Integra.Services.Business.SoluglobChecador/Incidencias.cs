using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using Entities = Integra.Services.Entities;
using Business = Integra.Services.Business;
using Log = Integra.Services.Business.Log;

namespace Integra.Services.Business.SoluglobChecador
{
    public class Incidencias
    {       
        public static DataSet GetIncidencias(DateTime FechaInicio, DateTime FechaFin)
        {
            DataSet dsIncidencias = null;
            Data.SoluglobChecador.Incidencias dataIncidencias = new Data.SoluglobChecador.Incidencias();
            try
            {
                dsIncidencias = dataIncidencias.GetIncidencias(FechaInicio, FechaFin);
            }
            catch (Exception)
            {
                throw;
            }

            return dsIncidencias;
        }

        public static DataTable GetTableIncidencias(DateTime FechaInicio, DateTime FechaFin)
        {
            DataTable dtIncidencias = null;
            Data.SoluglobChecador.Incidencias dataIncidencias = new Data.SoluglobChecador.Incidencias();
            try
            {
                dtIncidencias = dataIncidencias.GetTableIncidencias(FechaInicio, FechaFin);
            }
            catch (Exception)
            {
                throw;
            }

            return dtIncidencias;
        }
    }
}
