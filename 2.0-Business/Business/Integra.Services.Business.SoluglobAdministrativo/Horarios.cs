using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities = Integra.Services.Entities;
using Business = Integra.Services.Entities;

namespace Integra.Services.Business.SoluglobAdministrativo
{
    public class Horarios
    {
        public static Entities.SoluglobAdministrativo.Horarios Insert(Entities.SoluglobAdministrativo.Horarios objHorarios)
        {
            Entities.SoluglobAdministrativo.Horarios horarios = new Entities.SoluglobAdministrativo.Horarios();
            try
            {
                Data.SoluglobAdministrativo.Horarios dataHorarios = new Data.SoluglobAdministrativo.Horarios();
                horarios = dataHorarios.Insert(objHorarios);
                return horarios;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public static Entities.SoluglobAdministrativo.Horarios GetOne(int NumNomina)
        {
            Entities.SoluglobAdministrativo.Horarios horarios = new Entities.SoluglobAdministrativo.Horarios();
            try
            {
                Data.SoluglobAdministrativo.Horarios dataHorarios = new Data.SoluglobAdministrativo.Horarios();
                horarios = dataHorarios.GetOne(NumNomina);
                return horarios;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public static List<Entities.SoluglobAdministrativo.Horarios> GetAll()
        {
            List<Entities.SoluglobAdministrativo.Horarios> horariosCollection = new List<Entities.SoluglobAdministrativo.Horarios>();
            try
            {
                Data.SoluglobAdministrativo.Horarios dataHorarios = new Data.SoluglobAdministrativo.Horarios();
                horariosCollection = dataHorarios.GetAll();
                return horariosCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public static Entities.SoluglobAdministrativo.Horarios Update(Entities.SoluglobAdministrativo.Horarios objHorarios)
        {
            Entities.SoluglobAdministrativo.Horarios horarios = new Entities.SoluglobAdministrativo.Horarios();
            try
            {
                Data.SoluglobAdministrativo.Horarios dataHorarios = new Data.SoluglobAdministrativo.Horarios();
                horarios = dataHorarios.Update(objHorarios);
                return horarios;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }

        }

        public static void Delete(int NumNomina)
        {
            Data.SoluglobAdministrativo.Horarios dataHorarios = new Data.SoluglobAdministrativo.Horarios();
            dataHorarios.Delete(NumNomina);
        }
    }
}
