using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integra.Services.Business.SoluglobAdministrativo
{
    public class Vacantes
    {
        public static Entities.SoluglobAdministrativo.Vacantes Insert(Entities.SoluglobAdministrativo.Vacantes objVacantes)
        {
            Entities.SoluglobAdministrativo.Vacantes vacantes = new Entities.SoluglobAdministrativo.Vacantes();
            try
            {
                Data.SoluglobAdministrativo.Vacantes dataVacantes = new Data.SoluglobAdministrativo.Vacantes();
                vacantes = dataVacantes.Insert(objVacantes);
                return vacantes;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }

        }

        public static Entities.SoluglobAdministrativo.Vacantes GetOne(int idVacante)
        {
            Entities.SoluglobAdministrativo.Vacantes vacantes = new Entities.SoluglobAdministrativo.Vacantes();
            try
            {
                Data.SoluglobAdministrativo.Vacantes dataVacantes = new Data.SoluglobAdministrativo.Vacantes();
                vacantes = dataVacantes.GetOne(idVacante);
                return vacantes;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }

        }

        public static List<Entities.SoluglobAdministrativo.Vacantes> GetAll()
        {
            List<Entities.SoluglobAdministrativo.Vacantes> horariosCollection = new List<Entities.SoluglobAdministrativo.Vacantes>();
            try
            {
                Data.SoluglobAdministrativo.Vacantes dataVacantes = new Data.SoluglobAdministrativo.Vacantes();
                horariosCollection = dataVacantes.GetAll();
                return horariosCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }

        }

        public static Entities.SoluglobAdministrativo.Vacantes Update(Entities.SoluglobAdministrativo.Vacantes objVacantes)
        {
            Entities.SoluglobAdministrativo.Vacantes vacantes = new Entities.SoluglobAdministrativo.Vacantes();
            try
            {
                Data.SoluglobAdministrativo.Vacantes dataVacantes = new Data.SoluglobAdministrativo.Vacantes();
                vacantes = dataVacantes.Update(objVacantes);
                return vacantes;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }

        }

        public static void Delete(int idVacante)
        {
            Data.SoluglobAdministrativo.Vacantes dataVacantes = new Data.SoluglobAdministrativo.Vacantes();
            dataVacantes.Delete(idVacante);
        }

        public static int GetMaxId()
        {
            try
            {
                Data.SoluglobAdministrativo.Vacantes dataVacantes = new Data.SoluglobAdministrativo.Vacantes();
                return  dataVacantes.GetMaxId();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }

        }

        public static Entities.SoluglobAdministrativo.Vacantes GetOneByIdPer(int numEmpleado)
        {
            Entities.SoluglobAdministrativo.Vacantes vacantes = new Entities.SoluglobAdministrativo.Vacantes();
            try
            {
                Data.SoluglobAdministrativo.Vacantes dataVacantes = new Data.SoluglobAdministrativo.Vacantes();
                vacantes = dataVacantes.GetOneByIdPer(numEmpleado);
                return vacantes;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }

        }

        public static Entities.SoluglobAdministrativo.Vacantes UpdateIdPer(Entities.SoluglobAdministrativo.Vacantes objVacantes)
        {
            Entities.SoluglobAdministrativo.Vacantes vacantes = new Entities.SoluglobAdministrativo.Vacantes();
            try
            {
                Data.SoluglobAdministrativo.Vacantes dataVacantes = new Data.SoluglobAdministrativo.Vacantes();
                vacantes = dataVacantes.UpdateIdPer(objVacantes);
                return vacantes;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        public static Entities.SoluglobAdministrativo.Vacantes UpdateId_PerAndEstatusVacante(Entities.SoluglobAdministrativo.Vacantes objVacantes)
        {
            Entities.SoluglobAdministrativo.Vacantes vacantes = new Entities.SoluglobAdministrativo.Vacantes();
            try
            {
                Data.SoluglobAdministrativo.Vacantes dataVacantes = new Data.SoluglobAdministrativo.Vacantes();
                vacantes = dataVacantes.UpdateId_PerAndEstatusVacante(objVacantes);
                return vacantes;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }

        }

        public static int GetMinIdByPuestoCeCoUCo(int idCatPuesto, int idCeCo, string ClaveUCo)
        {
            Data.SoluglobAdministrativo.Vacantes dataPerVac = new Data.SoluglobAdministrativo.Vacantes();
            return dataPerVac.GetMinIdByPuestoCeCoUCo(idCatPuesto, idCeCo, ClaveUCo);
        }

    }

}
