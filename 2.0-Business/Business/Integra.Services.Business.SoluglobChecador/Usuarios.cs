using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities = Integra.Services.Entities;
using Business = Integra.Services.Entities;

namespace Integra.Services.Business.SoluglobChecador
{
    public class Usuarios
    {
        public static Entities.SoluglobChecador.Usuarios Insert(Entities.SoluglobChecador.Usuarios objUsuarios)
        {
            Entities.SoluglobChecador.Usuarios usuarios = new Entities.SoluglobChecador.Usuarios();
            try
            {
                Data.SoluglobChecador.Usuarios dataUsuarios = new Data.SoluglobChecador.Usuarios();
                usuarios = dataUsuarios.Insert(objUsuarios);
                return usuarios;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public static Entities.SoluglobChecador.Usuarios GetOne(int NumNomina)
        {
            Entities.SoluglobChecador.Usuarios usuarios = new Entities.SoluglobChecador.Usuarios();
            try
            {
                Data.SoluglobChecador.Usuarios dataUsuarios = new Data.SoluglobChecador.Usuarios();
                usuarios = dataUsuarios.GetOne(NumNomina);
                return usuarios;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public static List<Entities.SoluglobChecador.Usuarios> GetAll()
        {
            List<Entities.SoluglobChecador.Usuarios> empleadosColletion = new List<Entities.SoluglobChecador.Usuarios>();
            try
            {
                Data.SoluglobChecador.Usuarios dataUsuarios = new Data.SoluglobChecador.Usuarios();
                empleadosColletion = dataUsuarios.GetAll();
                return empleadosColletion;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public static Entities.SoluglobChecador.Usuarios Update(Entities.SoluglobChecador.Usuarios objUsuarios)
        {
            Entities.SoluglobChecador.Usuarios usuarios = new Entities.SoluglobChecador.Usuarios();
            try
            {
                Data.SoluglobChecador.Usuarios dataUsuarios = new Data.SoluglobChecador.Usuarios();
                usuarios = dataUsuarios.Update(objUsuarios);
                return usuarios;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }

        }

        public static void Delete(int NumNomina,int Estatus)
        {
            Data.SoluglobChecador.Usuarios dataHorarios = new Data.SoluglobChecador.Usuarios();
            dataHorarios.Delete(NumNomina, Estatus);
        }

        public static Entities.SoluglobChecador.Usuarios UpdateNumEmpleado(Entities.QProcess.Empleados.AltaKaizen objEmpleadoQP)
        {            
            try
            {
                if (objEmpleadoQP == null)
                {
                    throw new Exception("El objeto no contiene ningun registro");
                }
                Entities.SoluglobChecador.Usuarios objUsuarios = new Entities.SoluglobChecador.Usuarios();
                objUsuarios.Numero_Nomina = int.Parse(objEmpleadoQP.numEmpleado);
                
                Data.SoluglobChecador.Usuarios dataUsuarios = new Data.SoluglobChecador.Usuarios();
                objUsuarios = dataUsuarios.Update(objUsuarios);


                Entities.SoluglobAdministrativo.Personal objPersonal = new Entities.SoluglobAdministrativo.Personal();
                objPersonal.Num_Checador = int.Parse(objEmpleadoQP.numEmpleado);
                objPersonal.Nomi_Camb = 1;

                

                
                return objUsuarios;
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
                Data.SoluglobChecador.Usuarios dataUsuarios = new Data.SoluglobChecador.Usuarios();
                  
                return dataUsuarios.GetMaxId();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public static Entities.SoluglobChecador.Usuarios GetOneByNumeroNominas(int NumNominas)
        {
            Entities.SoluglobChecador.Usuarios usuarios = new Entities.SoluglobChecador.Usuarios();
            try
            {
                Data.SoluglobChecador.Usuarios dataUsuarios = new Data.SoluglobChecador.Usuarios();
                usuarios = dataUsuarios.GetOneByNumeroNominas(NumNominas);
                return usuarios;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public static Entities.SoluglobChecador.Usuarios UpdateNumeroNominas(Entities.SoluglobChecador.Usuarios objUsuarios)
        {
            Entities.SoluglobChecador.Usuarios usuarios = new Entities.SoluglobChecador.Usuarios();
            try
            {
                Data.SoluglobChecador.Usuarios dataUsuarios = new Data.SoluglobChecador.Usuarios();
                usuarios = dataUsuarios.UpdateNumeroNominas(objUsuarios);
                return usuarios;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public static void EnvioCorreo(int NumChecador, int Id_VacMin)
        {
            try
            {
                Data.SoluglobChecador.Usuarios dataHorarios = new Data.SoluglobChecador.Usuarios();
                dataHorarios.EnvioCorreo(NumChecador, Id_VacMin);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
