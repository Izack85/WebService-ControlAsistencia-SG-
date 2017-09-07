using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities = Integra.Services.Entities;
using Business = Integra.Services.Entities;

namespace Integra.Services.Business.SoluglobChecador
{
    public class Horarios
    {
        public static Entities.SoluglobChecador.Horarios Insert(Entities.SoluglobChecador.Horarios objHorarios)
        {
            Entities.SoluglobChecador.Horarios horarios = new Entities.SoluglobChecador.Horarios();
            try
            {
                Data.SoluglobChecador.Horarios dataHorarios = new Data.SoluglobChecador.Horarios();
                horarios = dataHorarios.Insert(objHorarios);
                return horarios;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public static Entities.SoluglobChecador.Horarios GetOne(int NumNomina)
        {
            Entities.SoluglobChecador.Horarios horarios = new Entities.SoluglobChecador.Horarios();
            try
            {
                Data.SoluglobChecador.Horarios dataHorarios = new Data.SoluglobChecador.Horarios();
                horarios = dataHorarios.GetOne(NumNomina);
                return horarios;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public static List<Entities.SoluglobChecador.Horarios> GetAll()
        {
            List<Entities.SoluglobChecador.Horarios> empleadosColletion = new List<Entities.SoluglobChecador.Horarios>();
            try
            {
                Data.SoluglobChecador.Horarios dataHorarios = new Data.SoluglobChecador.Horarios();
                empleadosColletion = dataHorarios.GetAll();
                return empleadosColletion;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public static Entities.SoluglobChecador.Horarios Update(Entities.SoluglobChecador.Horarios objHorarios)
        {
            Entities.SoluglobChecador.Horarios horarios = new Entities.SoluglobChecador.Horarios();
            try
            {
                Data.SoluglobChecador.Horarios dataHorarios = new Data.SoluglobChecador.Horarios();
                horarios = dataHorarios.Update(objHorarios);
                return horarios;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }

        }

        public static void Delete(int NumNomina, int Estatus)
        {
            Data.SoluglobChecador.Horarios dataHorarios = new Data.SoluglobChecador.Horarios();
            dataHorarios.Delete(NumNomina,Estatus);
        }
    }
}
