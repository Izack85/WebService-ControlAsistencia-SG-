using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integra.Services.Business.QProcess
{
    public class Contratacion
    {
        public static Entities.QProcess.Contratacion UpdateEstatusProceso(int NumeroNomina, int EstatusProceso)
        {
            Entities.QProcess.Contratacion contratacion = new Entities.QProcess.Contratacion();
            try
            {
                Data.QProcess.Contratacion dataContratacion = new Data.QProcess.Contratacion();
                contratacion = dataContratacion.UpdateEstatusProceso(NumeroNomina, EstatusProceso);
                return contratacion;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }

        }
    }
}
