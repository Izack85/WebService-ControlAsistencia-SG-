using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integra.Services.Business.SoluglobAdministrativo
{
    public class PerVac
    {
        public static Entities.SoluglobAdministrativo.PerVac Insert(Entities.SoluglobAdministrativo.PerVac objPerVac)
        {
            Entities.SoluglobAdministrativo.PerVac pervac = new Entities.SoluglobAdministrativo.PerVac();
            try
            {
                Data.SoluglobAdministrativo.PerVac dataPerVac = new Data.SoluglobAdministrativo.PerVac();
                pervac = dataPerVac.Insert(objPerVac);
                return pervac;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public static Entities.SoluglobAdministrativo.PerVac GetOne(int idPersonal, int idVacante)
        {
            Entities.SoluglobAdministrativo.PerVac pervac = new Entities.SoluglobAdministrativo.PerVac();
            try
            {
                Data.SoluglobAdministrativo.PerVac dataPerVac = new Data.SoluglobAdministrativo.PerVac();
                pervac = dataPerVac.GetOne(idPersonal, idVacante);
                return pervac;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public static List<Entities.SoluglobAdministrativo.PerVac> GetAll()
        {
            List<Entities.SoluglobAdministrativo.PerVac> personalCollection = new List<Entities.SoluglobAdministrativo.PerVac>();
            try
            {
                Data.SoluglobAdministrativo.PerVac dataPerVac = new Data.SoluglobAdministrativo.PerVac();
                personalCollection = dataPerVac.GetAll();
                return personalCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public static Entities.SoluglobAdministrativo.PerVac Update(Entities.SoluglobAdministrativo.PerVac objPerVac)
        {
            Entities.SoluglobAdministrativo.PerVac pervac = new Entities.SoluglobAdministrativo.PerVac();
            try
            {
                Data.SoluglobAdministrativo.PerVac dataPerVac = new Data.SoluglobAdministrativo.PerVac();
                pervac = dataPerVac.Update(objPerVac);
                return pervac;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }

        }

        public static void Delete(int idPersonal, int idVacante)
        {
            Data.SoluglobAdministrativo.PerVac dataPerVac = new Data.SoluglobAdministrativo.PerVac();
            dataPerVac.Delete(idPersonal, idVacante);
        }

        public static int GetMinId(int idCatPuesto)
        {
            Data.SoluglobAdministrativo.PerVac dataPerVac = new Data.SoluglobAdministrativo.PerVac();
            return dataPerVac.GetMinId(idCatPuesto);
        }

        public static bool Drop(int idPersonal, int idVacante)
        {
            bool result = false;
            try
            {
                Data.SoluglobAdministrativo.PerVac dataPerVac = new Data.SoluglobAdministrativo.PerVac();
                result = dataPerVac.Drop(idPersonal, idVacante);
                return result;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
           
        }
        
        public static Entities.SoluglobAdministrativo.PerVac UpdateIdPer(int Id_Per, int Id_PerNuevo, int Id_Vac)
        {
            Entities.SoluglobAdministrativo.PerVac pervac = new Entities.SoluglobAdministrativo.PerVac();
            try
            {
                Data.SoluglobAdministrativo.PerVac dataPerVac = new Data.SoluglobAdministrativo.PerVac();
                pervac = dataPerVac.UpdateIdPer(Id_Per, Id_PerNuevo, Id_Vac);
                return pervac;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }

        }


    }
}
