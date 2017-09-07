using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities = Integra.Services.Entities;
using Business = Integra.Services.Entities;

namespace Integra.Services.Business.SoluglobAdministrativo
{
    public class Personal
    {
        public static Entities.SoluglobAdministrativo.Personal Insert(Entities.SoluglobAdministrativo.Personal objPersonal)
        {
            Entities.SoluglobAdministrativo.Personal personal = new Entities.SoluglobAdministrativo.Personal();
            try
            {
                Data.SoluglobAdministrativo.Personal dataPersonal = new Data.SoluglobAdministrativo.Personal();
                personal = dataPersonal.Insert(objPersonal);
                return personal;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public static Entities.SoluglobAdministrativo.Personal GetOne(int idPersonal)
        {
            Entities.SoluglobAdministrativo.Personal personal = new Entities.SoluglobAdministrativo.Personal();
            try
            {
                Data.SoluglobAdministrativo.Personal dataPersonal = new Data.SoluglobAdministrativo.Personal();
                personal = dataPersonal.GetOne(idPersonal);
                return personal;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public static List<Entities.SoluglobAdministrativo.Personal> GetAll()
        {
            List<Entities.SoluglobAdministrativo.Personal> personalCollection = new List<Entities.SoluglobAdministrativo.Personal>();
            try
            {
                Data.SoluglobAdministrativo.Personal dataPersonal = new Data.SoluglobAdministrativo.Personal();
                personalCollection = dataPersonal.GetAll();
                return personalCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public static Entities.SoluglobAdministrativo.Personal Update(Entities.SoluglobAdministrativo.Personal objPersonal)
        {
            Entities.SoluglobAdministrativo.Personal personal = new Entities.SoluglobAdministrativo.Personal();
            try
            {
                Data.SoluglobAdministrativo.Personal dataPersonal = new Data.SoluglobAdministrativo.Personal();
                personal = dataPersonal.Update(objPersonal);
                return personal;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }

        }

        public static void Delete(int NumeroNomina)
        {
            Data.SoluglobAdministrativo.Personal dataPersonal = new Data.SoluglobAdministrativo.Personal();
            dataPersonal.Delete(NumeroNomina);
        }

        public static Entities.SoluglobAdministrativo.Personal UpdateNumEmpleado(Entities.QProcess.Empleados.AltaKaizen objEmpleadoQP)
        {
            Entities.SoluglobAdministrativo.Personal objPersonal = new Entities.SoluglobAdministrativo.Personal();
            try
            {                
                objPersonal.Num_Checador = int.Parse(objEmpleadoQP.numEmpleado);
                objPersonal.Nomi_Camb = 1;

                Data.SoluglobAdministrativo.Personal dataPersonal = new Data.SoluglobAdministrativo.Personal();
                objPersonal = dataPersonal.Update(objPersonal);
                return objPersonal;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }

        }

        public static int GetMaxId()
        {
            try
            {
                Data.SoluglobAdministrativo.Personal dataPersonal = new Data.SoluglobAdministrativo.Personal();
                return dataPersonal.GetMaxId();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public static List<Entities.SoluglobAdministrativo.Personal> GetAllActivos()
        {
            List<Entities.SoluglobAdministrativo.Personal> personalCollection = new List<Entities.SoluglobAdministrativo.Personal>();
            try
            {
                Data.SoluglobAdministrativo.Personal dataPersonal = new Data.SoluglobAdministrativo.Personal();
                personalCollection = dataPersonal.GetAll();
                var empleadosActivos = (from ea in personalCollection
                                       where ea.Estatus.Equals(1)
                                       select ea).ToList();                
                return empleadosActivos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public static Entities.SoluglobAdministrativo.Personal GetOneByNumeroChecador(int NumChecador)
        {
            Entities.SoluglobAdministrativo.Personal personal = new Entities.SoluglobAdministrativo.Personal();
            try
            {
                Data.SoluglobAdministrativo.Personal dataPersonal = new Data.SoluglobAdministrativo.Personal();
                personal = dataPersonal.GetOneByNumeroChecador(NumChecador);
                return personal;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public static Entities.SoluglobAdministrativo.Personal BajaEmpleado(int Id_Per, int Estatus)
        {
            Entities.SoluglobAdministrativo.Personal personal = new Entities.SoluglobAdministrativo.Personal();
            try
            {
                Data.SoluglobAdministrativo.Personal dataPersonal = new Data.SoluglobAdministrativo.Personal();
                personal = dataPersonal.BajaEmpleado(Id_Per, Estatus);
                return personal;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
           
        }

        public static Entities.SoluglobAdministrativo.Personal UpdateId_PerAndNomiCamb(Entities.SoluglobAdministrativo.Personal objPersonal)
        {
            Entities.SoluglobAdministrativo.Personal personal = new Entities.SoluglobAdministrativo.Personal();
            try
            {
                Data.SoluglobAdministrativo.Personal dataPersonal = new Data.SoluglobAdministrativo.Personal();
                personal = dataPersonal.UpdateId_PerAndNomiCamb(objPersonal);
                return personal;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }

        }      
        
    }
}
