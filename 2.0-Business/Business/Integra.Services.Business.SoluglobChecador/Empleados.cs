using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities = Integra.Services.Entities;
using Business = Integra.Services.Business;
using Log = Integra.Services.Business.Log;

namespace Integra.Services.Business.SoluglobChecador
{
    public class Empleados
    {
        public static int Insert(Entities.QProcess.Empleados.AltaSoluglob objEmpleadoQP)
        {   
            Data.SoluglobAdministrativo.Personal dataPersonal = new Data.SoluglobAdministrativo.Personal();
            Data.SoluglobAdministrativo.PerVac dataPerVac = new Data.SoluglobAdministrativo.PerVac();
            Data.SoluglobAdministrativo.Vacantes dataVacantes = new Data.SoluglobAdministrativo.Vacantes();
            Data.SoluglobChecador.Horarios dataHorarios = new Data.SoluglobChecador.Horarios();
            Data.SoluglobChecador.Usuarios dataUsuarios = new Data.SoluglobChecador.Usuarios();
            Data.QProcess.Contratacion dataContratacion = new Data.QProcess.Contratacion();
            Data.QProcess.Empleado dataEmpleado = new Data.QProcess.Empleado();
            int NumeroNomina = 0;
            try
            {
                Entities.SoluglobChecador.Usuarios objUsuarios = new Entities.SoluglobChecador.Usuarios();
                objUsuarios.Numero_Nomina = objEmpleadoQP.Numero_Nomina;
                objUsuarios.Nombres = objEmpleadoQP.Nombres;
                objUsuarios.Apellidos = objEmpleadoQP.Apellidos;
                objUsuarios.Puesto = objEmpleadoQP.Puesto.ToString();
                objUsuarios.Departamento = objEmpleadoQP.Departamento;
                objUsuarios.Telefono = objEmpleadoQP.Telefono;
                objUsuarios.Huella_Bin1 = objEmpleadoQP.Huella_Bin1;
                objUsuarios.Huella_Img1 = objEmpleadoQP.Huella_Img1;
                objUsuarios.Huella_Bin2 = objEmpleadoQP.Huella_Bin2;
                objUsuarios.Huella_Bin3 = objEmpleadoQP.Huella_Bin3;
                objUsuarios.Huella_Bin4 = objEmpleadoQP.Huella_Bin4;
                objUsuarios.Estatus = Convert.ToBoolean(objEmpleadoQP.Estatus);
                objUsuarios.Fecha_Alta = objEmpleadoQP.Fecha_Alta;
                objUsuarios.Fecha_Baja = objEmpleadoQP.Fecha_Baja;
                objUsuarios.Empresa = objEmpleadoQP.Empresa;
                objUsuarios.Ubicacion = objEmpleadoQP.Ubicacion_usuarios;
                objUsuarios.MotivoBaja = objEmpleadoQP.MotivoBaja;
                objUsuarios.Caso_Especial = objEmpleadoQP.Caso_Especial;
                objUsuarios.msrepl_tran_version = objEmpleadoQP.msrepl_tran_version;
                objUsuarios.Registrado = objEmpleadoQP.Registrado;
                objUsuarios.Imss = objEmpleadoQP.Imss;
                objUsuarios.Dias_semana = objEmpleadoQP.Dias_semana;
                objUsuarios.fecha_ingresos = objEmpleadoQP.fecha_ingresos;
                objUsuarios.pagos_hextras = objEmpleadoQP.pagos_hextras;
                objUsuarios.Fechas_registro = objEmpleadoQP.Fechas_registro;
                objUsuarios.unidad_costos = objEmpleadoQP.unidad_costos;
                objUsuarios.Fecha_Reingreso = objEmpleadoQP.Fecha_Reingreso;
                objUsuarios.Centro_costos = objEmpleadoQP.Centro_costos;
                objUsuarios.Numero_Nominas = objEmpleadoQP.Numero_Nominas;
                objUsuarios.Remuneracion = objEmpleadoQP.Remuneracion;
                objUsuarios.Fecha_Alta_Imss = objEmpleadoQP.Fecha_Alta_Imss;
                objUsuarios.Fecha_Baja_sistema = objEmpleadoQP.Fecha_Baja_sistema;
                objUsuarios.Estatus_Edicion = objEmpleadoQP.Estatus;
                objUsuarios.Fecha_Modificacion = objEmpleadoQP.Fecha_Modificacion;
                objUsuarios.Bono = Convert.ToBoolean(objEmpleadoQP.Bono);
                objUsuarios.Responsable_Bono = objEmpleadoQP.Responsable_Bono;
                objUsuarios = dataUsuarios.Insert(objUsuarios);

                if (objUsuarios.Numero_Nomina == 0)
                {
                    string logMesagge = "Error en la inserción de datos a Usuarios";
                    Log.LogService.Log(logMesagge);
                    throw new Exception(logMesagge);
                }
                else
                {
                    Log.LogService.Log("Los datos de la tabla 'Usuarios' se insertaron exitosamente");
                }

                Entities.SoluglobChecador.Horarios objHorarios = new Entities.SoluglobChecador.Horarios();
                objHorarios.Numero_Nomina = objEmpleadoQP.Numero_Nomina;
                objHorarios.Lunes_Entrada = objEmpleadoQP.Lunes_Entrada;
                objHorarios.Lunes_Salida = objEmpleadoQP.Lunes_Salida;
                objHorarios.Martes_Entrada = objEmpleadoQP.Martes_Entrada;
                objHorarios.Martes_Salida = objEmpleadoQP.Martes_Salida;
                objHorarios.Miercoles_Entrada = objEmpleadoQP.Miercoles_Entrada;
                objHorarios.Miercoles_Salida = objEmpleadoQP.Miercoles_Salida;
                objHorarios.Jueves_Entrada = objEmpleadoQP.Jueves_Entrada;
                objHorarios.Jueves_Salida = objEmpleadoQP.Jueves_Salida;
                objHorarios.Viernes_Entrada = objEmpleadoQP.Viernes_Entrada;
                objHorarios.Viernes_Salida = objEmpleadoQP.Viernes_Salida;
                objHorarios.Sabado_Entrada = objEmpleadoQP.Sabado_Entrada;
                objHorarios.Sabado_Salida = objEmpleadoQP.Sabado_Salida;
                objHorarios.Domingo_Entrada = objEmpleadoQP.Domingo_Entrada;
                objHorarios.Domingo_Salida = objEmpleadoQP.Domingo_Salida;
                objHorarios.Fecha_Modificacion = objEmpleadoQP.Fecha_Modificacion.ToString();
                objHorarios.msrepl_tran_version = objEmpleadoQP.msrepl_tran_version;
                objHorarios.Estatus = objEmpleadoQP.Estatus;
                objHorarios = dataHorarios.Insert(objHorarios);

                if (objHorarios.Numero_Nomina == 0)
                {
                    string logMesagge = "Error en la inserción de datos a Horarios";
                    Log.LogService.Log(logMesagge);
                    throw new Exception(logMesagge);
                }
                else
                {
                    Log.LogService.Log("Los datos de la tabla 'Horarios' se insertaron exitosamente");
                }


                Entities.SoluglobAdministrativo.Personal objPersonal = new Entities.SoluglobAdministrativo.Personal();
                objPersonal.Id_Per = objEmpleadoQP.Num_Checador;
                objPersonal.Num_Checador = objEmpleadoQP.Num_Checador;
                objPersonal.Nomi_Camb = objEmpleadoQP.Nomi_Camb;
                objPersonal.FecReg = objEmpleadoQP.FecReg;
                objPersonal.Nombre = objEmpleadoQP.Nombre;
                objPersonal.Sexo = objEmpleadoQP.Sexo;
                objPersonal.Edad = objEmpleadoQP.Edad;
                objPersonal.NSS = objEmpleadoQP.NSS;
                objPersonal.CURP = objEmpleadoQP.CURP;
                objPersonal.Calle = objEmpleadoQP.Calle;
                objPersonal.Numero = objEmpleadoQP.Numero;
                objPersonal.Mz = objEmpleadoQP.Mz;
                objPersonal.Lt = objEmpleadoQP.Lt;
                objPersonal.Colonia = objEmpleadoQP.Colonia;
                objPersonal.Municipio = objEmpleadoQP.Municipio;
                objPersonal.Ciudad = objEmpleadoQP.Ciudad;
                objPersonal.Estado = objEmpleadoQP.Estado;
                objPersonal.CP = objEmpleadoQP.CP;
                objPersonal.Tel = objEmpleadoQP.Tel;
                objPersonal.Cel = objEmpleadoQP.Cel;
                objPersonal.Email = objEmpleadoQP.Email;
                objPersonal.Sueldo = objEmpleadoQP.Sueldo;
                objPersonal.Jefe = objEmpleadoQP.Jefe;
                objPersonal.Horario = objEmpleadoQP.Horario;
                objPersonal.Estatus = objEmpleadoQP.Estatus;
                objPersonal.User_Mod = objEmpleadoQP.User_Mod;
                objPersonal.FecMod = objEmpleadoQP.FecMod;
                objPersonal.AplicaBono = objEmpleadoQP.AplicaBono;
                objPersonal = dataPersonal.Insert(objPersonal);

                if (objPersonal.Id_Per == 0)
                {
                    string logMesagge = "Error en la inserción de datos a Tb_Personal";
                    Log.LogService.Log(logMesagge);
                    throw new Exception(logMesagge);
                }
                else
                {
                    Log.LogService.Log("Los datos de la tabla 'Tb_Personal' se insertaron exitosamente");
                }

                Entities.SoluglobAdministrativo.Vacantes objVacantes = new Entities.SoluglobAdministrativo.Vacantes();
                objVacantes.Id_Vac = objEmpleadoQP.Id_Vac;
                objVacantes.Id_Per = objEmpleadoQP.Num_Checador;
                objVacantes = dataVacantes.UpdateIdPer(objVacantes);

                if (objVacantes.Id_Per == null)
                {
                    string logMesagge = "Error en la actualizacion del campo Id_Per de la tabla Tb_Vacantes";
                    Log.LogService.Log(logMesagge);
                    throw new Exception(logMesagge);
                }
                else
                {
                    Log.LogService.Log("El campo 'Id_Per' de la tabla 'Tb_Vacantes' se actualizo correctamente");
                }

                Entities.SoluglobAdministrativo.PerVac objPerVac = new Entities.SoluglobAdministrativo.PerVac();
                objPerVac.Id_Per = objEmpleadoQP.Num_Checador;
                objPerVac.Id_Vac = objEmpleadoQP.Id_Vac;
                objPerVac = dataPerVac.Insert(objPerVac);

                if (objPerVac == null)
                {
                    string logMesagge = "Error en la inserción de datos a TB_PerVac";
                    Log.LogService.Log(logMesagge);
                    throw new Exception(logMesagge);
                }
                else
                {
                    Log.LogService.Log("Los datos de la tabla 'TB_PerVac' se insertaron exitosamente");
                }

                Entities.QProcess.Contratacion objContratacion = new Entities.QProcess.Contratacion();
                objContratacion = dataContratacion.UpdateEstatusProceso(objEmpleadoQP.Numero_Nomina, (int)Entities.Kaizen.Enum.EstatusProceso.Soluglob);
                //NumeroNomina = dataEmpleado.UpdateEstatusProceso(objEmpleadoQP.Numero_Nomina, (int)Entities.Kaizen.Enum.EstatusProceso.Soluglob);

                if (objContratacion.EstatusProceso.Equals((int)Entities.Kaizen.Enum.EstatusProceso.QProcess))
                {
                    string logMesagge = "Error en la Actualización Estatus Proceso";
                    Log.LogService.Log(logMesagge);
                    throw new Exception(logMesagge);
                }
                else
                {
                    Log.LogService.Log("El campo 'Estatus Proceso' fue actualizado correctamente");
                }

                return int.Parse(objContratacion.NumeroEmpleado);
                //return NumeroNomina;

            }
            catch (Exception ex)//Falta agregar las acciones de todo el catch al Log
            {
                Entities.SoluglobAdministrativo.Vacantes objVacantesRollback = new Entities.SoluglobAdministrativo.Vacantes();
                objVacantesRollback.Id_Per = null;
                objVacantesRollback.Estatus_Vacante = 0;
                objVacantesRollback.Id_Vac = objEmpleadoQP.Id_Vac;
                
                dataPerVac.Drop(objEmpleadoQP.Numero_Nomina, objEmpleadoQP.Id_Vac);
                objVacantesRollback = dataVacantes.UpdateId_PerAndEstatusVacante(objVacantesRollback);
                dataPersonal.Drop(objEmpleadoQP.Id_Per);                
                dataHorarios.Drop(objEmpleadoQP.Numero_Nomina);
                dataUsuarios.Drop(objEmpleadoQP.Numero_Nomina);
                throw new Exception(ex.Message.ToString());
            }
        }

        public static Entities.SoluglobChecador.Empleados GetOne(int NumNomina)
        {
            Entities.SoluglobChecador.Empleados empleados = new Entities.SoluglobChecador.Empleados();
            try
            {
                Data.SoluglobChecador.Empleados dataEmpleados = new Data.SoluglobChecador.Empleados();
                empleados = dataEmpleados.GetOne(NumNomina);
                return empleados;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public static List<Entities.SoluglobChecador.Empleados> GetAll()
        {
            List<Entities.SoluglobChecador.Empleados> empleadosCollection = new List<Entities.SoluglobChecador.Empleados>();
            try
            {
                Data.SoluglobChecador.Empleados dataEmpleados = new Data.SoluglobChecador.Empleados();
                empleadosCollection = dataEmpleados.GetAll();
                return empleadosCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public static Entities.SoluglobChecador.Empleados Update(Entities.SoluglobChecador.Empleados objEmpleados)
        {
            Entities.SoluglobChecador.Empleados empleados = new Entities.SoluglobChecador.Empleados();
            try
            {
                Data.SoluglobChecador.Empleados dataEmpleados = new Data.SoluglobChecador.Empleados();
                empleados = dataEmpleados.Update(objEmpleados);
                return empleados;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }

        }

        public static void Delete(int NumNomina, int Estatus)
        {
            Data.SoluglobChecador.Empleados dataHorarios = new Data.SoluglobChecador.Empleados();
            dataHorarios.Delete(NumNomina, Estatus);
        }

        public static Entities.QProcess.Empleados.AltaSoluglob GetOneSG(int IdEntrevistaCandidato)
        {
            Entities.QProcess.Empleados.AltaSoluglob EmpleadoQP = new Entities.QProcess.Empleados.AltaSoluglob();
            try
            {
                Data.SoluglobChecador.Empleados dataEmpleados = new Data.SoluglobChecador.Empleados();
                EmpleadoQP = dataEmpleados.GetOneSG(IdEntrevistaCandidato);
                Insert(EmpleadoQP);
                return EmpleadoQP;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
