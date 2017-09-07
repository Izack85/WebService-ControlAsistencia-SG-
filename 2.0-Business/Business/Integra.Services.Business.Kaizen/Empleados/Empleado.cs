using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities = Integra.Services.Entities;
using Log = Integra.Services.Business.Log;

namespace Integra.Services.Business.Kaizen.Empleados
{
    public class Empleado
    {
        public static Entities.Kaizen.Empleados.Empleado Insert(Entities.QProcess.Empleados.AltaKaizen objEmpleadoQP)
        {
            Entities.Kaizen.Empleados.Empleado objEmpleado = new Entities.Kaizen.Empleados.Empleado();
            Entities.Kaizen.Empleados.Tel_Empleados objTel_Empleados = new Entities.Kaizen.Empleados.Tel_Empleados();
            Entities.Kaizen.Empleados.H_Personal objH_Personal = new Entities.Kaizen.Empleados.H_Personal();
            Entities.Kaizen.Empleados.H_Sueldos objH_Sueldos1 = new Entities.Kaizen.Empleados.H_Sueldos();
            Entities.Kaizen.Empleados.H_Sueldos objH_Sueldos2 = new Entities.Kaizen.Empleados.H_Sueldos();
            Entities.Kaizen.Empleados.H_Sueldos objH_Sueldos3 = new Entities.Kaizen.Empleados.H_Sueldos();
            Entities.Kaizen.Empleados.H_Laboral objH_Laboral = new Entities.Kaizen.Empleados.H_Laboral();
            Entities.Kaizen.Empleados.H_Valores_X_Emp objH_Valores_X_Emp = new Entities.Kaizen.Empleados.H_Valores_X_Emp();
            Entities.Kaizen.Empleados.H_Valores_X_Emp objH_Valores_X_EmpTUM = new Entities.Kaizen.Empleados.H_Valores_X_Emp();
            Entities.Kaizen.Empleados.H_Valores_X_Emp objH_Valores_X_EmpContabilidad = new Entities.Kaizen.Empleados.H_Valores_X_Emp();

            Data.Kaizen.Empleados.Empleado dataEmpleado = new Data.Kaizen.Empleados.Empleado();
            Data.Kaizen.Empleados.H_Laboral dataH_Laboral = new Data.Kaizen.Empleados.H_Laboral();
            Data.Kaizen.Empleados.H_Personal dataH_Personal = new Data.Kaizen.Empleados.H_Personal();
            Data.Kaizen.Empleados.H_Sueldos dataH_Sueldos = new Data.Kaizen.Empleados.H_Sueldos();
            Data.Kaizen.Empleados.H_Valores_X_Emp dataH_Valores_X_Emp = new Data.Kaizen.Empleados.H_Valores_X_Emp();
            Data.Kaizen.Empleados.Tel_Empleados dataTel_Empleados = new Data.Kaizen.Empleados.Tel_Empleados();

            try
            {
                //Datos Empleado
                objEmpleado = new Entities.Kaizen.Empleados.Empleado();
                objEmpleado.compania = objEmpleadoQP.Compania;
                objEmpleado.companiaPasajes = objEmpleadoQP.CompaniaPasajes;
                objEmpleado.numEmpleado = objEmpleadoQP.numEmpleado;
                objEmpleado.expediente = objEmpleadoQP.Expediente;
                objEmpleado.apellido_materno = objEmpleadoQP.ApellidoPat;
                objEmpleado.apellido_paterno = objEmpleadoQP.ApellidoMat;
                objEmpleado.nombres = objEmpleadoQP.Nombres;
                objEmpleado.nombre = objEmpleadoQP.Nombre;
                objEmpleado.fecha_nac = objEmpleadoQP.FechaNacimiento;
                objEmpleado.pais_nac = objEmpleadoQP.PaisNacimiento;
                objEmpleado.estado_nac = objEmpleadoQP.Estado_Nac;
                objEmpleado.lugar_nac = objEmpleadoQP.Lugar_Nac;
                objEmpleado.sexo = objEmpleadoQP.Sexo;
                objEmpleado.tipo_sangre = objEmpleadoQP.TipoSangre;
                objEmpleado.rfc = objEmpleadoQP.RFC;
                objEmpleado.curp = objEmpleadoQP.CURP;
                objEmpleado.numero_imss = objEmpleadoQP.NSS;
                objEmpleado.infonavit = objEmpleadoQP.NumCreditoInfonavit;
                objEmpleado.tipo_pago_infonavit = objEmpleadoQP.Tipo_Pago_Infonavit;
                objEmpleado.factor = objEmpleadoQP.Factor;
                objEmpleado.nombre_padre = objEmpleadoQP.Nombre_Padre;
                objEmpleado.nombre_madre = objEmpleadoQP.Nombre_Madre;
                objEmpleado.origen = objEmpleadoQP.Origen;
                objEmpleado.nacionalidad = objEmpleadoQP.Nacionalidad;
                objEmpleado.nivel_estudio = objEmpleadoQP.NivelEstudio;
                objEmpleado.turno = objEmpleadoQP.Turno;
                objEmpleado.tarjeta = objEmpleadoQP.Tarjeta;
                objEmpleado.destajos = objEmpleadoQP.Destajos;
                objEmpleado.tratamiento = objEmpleadoQP.Tratamiento;
                objEmpleado.elector = objEmpleadoQP.Elector;
                objEmpleado.licencia = objEmpleadoQP.Licencia;
                objEmpleado.tipo_pago = objEmpleadoQP.Tipo_Pago;
                objEmpleado.banco = objEmpleadoQP.Banco;
                objEmpleado.sucursal = objEmpleadoQP.Sucursal;
                objEmpleado.cta_cheques = objEmpleadoQP.Cta_Cheques;
                objEmpleado.clabe = objEmpleadoQP.CLABE;
                objEmpleado.banco_alt = objEmpleadoQP.Banco_Alt;
                objEmpleado.sucursal_alt = objEmpleadoQP.Sucursal_Alt;
                objEmpleado.cta_cheques_alt = objEmpleadoQP.Cta_Cheques_Alt;
                objEmpleado.clabe_alt = objEmpleadoQP.CLABE_Alt;
                objEmpleado.tarjeta_vales = objEmpleadoQP.Tarjeta_Vales;
                objEmpleado.path_foto = objEmpleadoQP.Path_Foto;
                objEmpleado.estatus = objEmpleadoQP.Estatus;
                objEmpleado.usuario = objEmpleadoQP.Usuario;
                objEmpleado.ip = objEmpleadoQP.Ip;
                objEmpleado.mac_address = objEmpleadoQP.Mac_Address;
                objEmpleado.entidadLaboral = objEmpleadoQP.EntidadLaboral;
                objEmpleado.cartilla = objEmpleadoQP.Cartilla;
                objEmpleado.fuente = objEmpleadoQP.Fuente;
                objEmpleado.path_firma = objEmpleadoQP.Path_Firma;
                objEmpleado.tarjeta_vales_ant = objEmpleadoQP.Tarjeta_Vales_Ant;
                objEmpleado.Correo = objEmpleadoQP.Correo;
                objEmpleado.Tarjeta_VGasolina = objEmpleadoQP.Tarjeta_VGasolina;
                objEmpleado = dataEmpleado.Insert(objEmpleado);

                if (objEmpleado.numEmpleado == null)
                {
                    string logMesagge = "Error en la insercion del Empleado";
                    Log.LogService.Log(logMesagge);
                    throw new Exception(logMesagge);
                }
                else
                {
                    Log.LogService.Log("Los datos de la tabla 'Empleados' se insertaron exitosamente");
                }

                //Datos Tel_Empleados
                objTel_Empleados = new Entities.Kaizen.Empleados.Tel_Empleados();
                objTel_Empleados.Compania = objEmpleadoQP.Compania;
                objTel_Empleados.companiaPasajes = objEmpleadoQP.CompaniaPasajes;
                objTel_Empleados.numEmpleado = objEmpleado.numEmpleado;
                objTel_Empleados.Tipo = objEmpleadoQP.Tipo;
                objTel_Empleados.Sec = 1;
                objTel_Empleados.Telefono = objEmpleadoQP.Telefono;
                objTel_Empleados = dataTel_Empleados.Insert(objTel_Empleados);

                if (objTel_Empleados == null)
                {
                    string logMesagge = "Error en la insercion del Tel_Empleados";
                    Log.LogService.Log(logMesagge);
                    throw new Exception(logMesagge);
                }
                else
                {
                    Log.LogService.Log("Los datos de la tabla 'Tel_Empleados' se insertaron exitosamente");
                }

                //Datos H_Personal
                objH_Personal = new Entities.Kaizen.Empleados.H_Personal();
                objH_Personal.Compania = objEmpleadoQP.Compania;
                objH_Personal.companiaPasajes = objEmpleadoQP.CompaniaPasajes;
                objH_Personal.numEmpleado = objEmpleadoQP.numEmpleado;
                objH_Personal.Fecha = objEmpleadoQP.Fecha;
                objH_Personal.Direccion = objEmpleadoQP.Direccion;
                objH_Personal.Poblacion = objEmpleadoQP.Poblacion;
                objH_Personal.Numero_Ext = objEmpleadoQP.Numero_Ext;
                objH_Personal.Numero_Int = objEmpleadoQP.Numero_Int;
                objH_Personal.Pais = objEmpleadoQP.Pais;
                objH_Personal.Cp = objEmpleadoQP.Cp;
                objH_Personal.Estado = objEmpleadoQP.Estado;
                objH_Personal.Estado_Civil = objEmpleadoQP.Estado_Civil;
                objH_Personal.Ciudad = objEmpleadoQP.Ciudad;
                objH_Personal.Colonia = objEmpleadoQP.Colonia;
                objH_Personal.Usuario = objEmpleadoQP.Usuario;
                objH_Personal.Ip = objEmpleadoQP.Ip;
                objH_Personal.Mac_Address = objEmpleadoQP.Mac_Address;
                objH_Personal = dataH_Personal.Insert(objH_Personal);

                if (objH_Personal == null)
                {
                    string logMesagge = "Error en la insercion de H_Personal";
                    Log.LogService.Log(logMesagge);
                    throw new Exception(logMesagge);
                }
                else
                {
                    Log.LogService.Log("Los datos de la tabla 'H_Personal' se insertaron exitosamente");
                }

                //Datos H_Sueldos 1
                objH_Sueldos1 = new Entities.Kaizen.Empleados.H_Sueldos();
                objH_Sueldos1.Compania = objEmpleadoQP.Compania;
                objH_Sueldos1.companiaPasajes = objEmpleadoQP.CompaniaPasajes;
                objH_Sueldos1.numEmpleado = objEmpleadoQP.numEmpleado;
                //objH_Sueldos1.Fecha = objEmpleadoQP.Fecha;
                objH_Sueldos1.Tipo_Sueldo = "SDI";
                objH_Sueldos1.Sueldo = objEmpleadoQP.SDI;
                objH_Sueldos1.Usuario = objEmpleadoQP.Usuario;
                objH_Sueldos1.Ip = objEmpleadoQP.Ip;
                objH_Sueldos1.Mac_Address = objEmpleadoQP.Mac_Address;
                objH_Sueldos1 = dataH_Sueldos.Insert(objH_Sueldos1);

                if (objH_Sueldos1 == null)
                {
                    string logMesagge = "Error en la insercion del SDI en H_Sueldos";
                    Log.LogService.Log(logMesagge);
                    throw new Exception(logMesagge);                    
                }
                else
                {
                    Log.LogService.Log("El SDI de la tabla 'H_Sueldos' se inserto exitosamente");
                }

                //Datos H_Sueldos 2
                objH_Sueldos2 = new Entities.Kaizen.Empleados.H_Sueldos();
                objH_Sueldos2.Compania = objEmpleadoQP.Compania;
                objH_Sueldos2.companiaPasajes = objEmpleadoQP.CompaniaPasajes;
                objH_Sueldos2.numEmpleado = objEmpleadoQP.numEmpleado;
                //objH_Sueldos2.Fecha = objEmpleadoQP.Fecha;
                objH_Sueldos2.Tipo_Sueldo = "SDN";
                objH_Sueldos2.Sueldo = objEmpleadoQP.SDN;
                objH_Sueldos2.Usuario = objEmpleadoQP.Usuario;
                objH_Sueldos2.Ip = objEmpleadoQP.Ip;
                objH_Sueldos2.Mac_Address = objEmpleadoQP.Mac_Address;
                objH_Sueldos2 = dataH_Sueldos.Insert(objH_Sueldos2);

                if (objH_Sueldos2 == null)
                {
                    string logMesagge = "Error en la insercion del SDN en H_Sueldos";
                    Log.LogService.Log(logMesagge);
                    throw new Exception(logMesagge);
                }
                else
                {
                    Log.LogService.Log("El SDN de la tabla 'H_Sueldos' se inserto exitosamente");
                }

                //Datos H_Sueldos 3
                objH_Sueldos3 = new Entities.Kaizen.Empleados.H_Sueldos();
                objH_Sueldos3.Compania = objEmpleadoQP.Compania;
                objH_Sueldos3.companiaPasajes = objEmpleadoQP.CompaniaPasajes;
                objH_Sueldos3.numEmpleado = objEmpleadoQP.numEmpleado;
                //objH_Sueldos3.Fecha = objEmpleadoQP.Fecha;
                objH_Sueldos3.Tipo_Sueldo = "SM";
                objH_Sueldos3.Sueldo = objEmpleadoQP.SM;
                objH_Sueldos3.Usuario = objEmpleadoQP.Usuario;
                objH_Sueldos3.Ip = objEmpleadoQP.Ip;
                objH_Sueldos3.Mac_Address = objEmpleadoQP.Mac_Address;
                objH_Sueldos3 = dataH_Sueldos.Insert(objH_Sueldos3);

                if (objH_Sueldos3 == null)
                {
                    string logMesagge = "Error en la insercion del SM en H_Sueldos";
                    Log.LogService.Log(logMesagge);
                    throw new Exception(logMesagge);                    
                }
                else
                {
                    Log.LogService.Log("El SM de la tabla 'H_Sueldos' se inserto exitosamente");
                }

                //Datos H_Laboral
                objH_Laboral = new Entities.Kaizen.Empleados.H_Laboral();
                objH_Laboral.Compania = objEmpleadoQP.Compania;
                objH_Laboral.companiaPasajes = objEmpleadoQP.CompaniaPasajes;
                objH_Laboral.numEmpleado = objEmpleadoQP.numEmpleado;
                objH_Laboral.Fecha = objEmpleadoQP.Fecha;
                objH_Laboral.Sec = objEmpleadoQP.Sec_H_Laboral;
                objH_Laboral.Accion = objEmpleadoQP.Accion;
                objH_Laboral.Motivo = objEmpleadoQP.Motivo;
                objH_Laboral.Grupo_Pago = objEmpleadoQP.Grupo_Pago;
                objH_Laboral.Grupo_Pago_Pasajes = objEmpleadoQP.Grupo_Pago_Pasajes;
                objH_Laboral.Tipo_Contrato = objEmpleadoQP.Tipo_Contrato;
                objH_Laboral.Fecha_Ingreso = objEmpleadoQP.Fecha_Ingreso;
                objH_Laboral.Fecha_Antiguedad1 = objEmpleadoQP.Fecha_Antiguedad1;
                objH_Laboral.Fecha_Antiguedad2 = objEmpleadoQP.Fecha_Antiguedad2;
                objH_Laboral.Fecha_Antiguedad3 = objEmpleadoQP.Fecha_Antiguedad3;
                objH_Laboral.Duracion = objEmpleadoQP.Duracion;
                objH_Laboral.Fecha_Vento = objEmpleadoQP.Fecha_Vento;
                objH_Laboral.Fecha_Baja = objEmpleadoQP.Fecha_Baja;
                objH_Laboral.Tipo_Salario = objEmpleadoQP.Tipo_Salario;
                objH_Laboral.Tipo_Empleado = objEmpleadoQP.Tipo_Empleado;
                objH_Laboral.Localidad = objEmpleadoQP.Localidad;
                objH_Laboral.Departamento = objEmpleadoQP.Departamento;
                objH_Laboral.Puesto = objEmpleadoQP.Puesto;
                objH_Laboral.Dependencia = objEmpleadoQP.Dependencia;
                objH_Laboral.Cliente = objEmpleadoQP.Cliente;
                objH_Laboral.Tipo_De_Operacion = objEmpleadoQP.Tipo_De_Operacion;
                objH_Laboral.Region = objEmpleadoQP.Region;
                objH_Laboral.Sector = objEmpleadoQP.Sector;
                objH_Laboral.Usuario = objEmpleadoQP.Usuario;
                objH_Laboral.Sindicalizado = objEmpleadoQP.Sindicalizado;
                objH_Laboral.Ip = objEmpleadoQP.Ip;
                objH_Laboral.Mac_Address = objEmpleadoQP.Mac_Address;
                objH_Laboral = dataH_Laboral.Insert(objH_Laboral);

                if (objH_Laboral == null)
                {
                    string logMesagge = "Error en la insercion del H_Laboral";
                    Log.LogService.Log(logMesagge);
                    throw new Exception(logMesagge);
                }
                else
                {
                    Log.LogService.Log("Los datos de la tabla 'H_Laboral' se insertaron exitosamente");
                }

                //Datos H_Valores_X_Emp
                if (objEmpleadoQP.Unidad_de_Costos != null || objEmpleadoQP.Unidad_de_Costos != "")
                {
                    objH_Valores_X_Emp = new Entities.Kaizen.Empleados.H_Valores_X_Emp();
                    objH_Valores_X_Emp.Compania = objEmpleadoQP.Compania;
                    objH_Valores_X_Emp.companiaPasajes = objEmpleadoQP.CompaniaPasajes;
                    objH_Valores_X_Emp.numEmpleado = objEmpleadoQP.numEmpleado;
                    objH_Valores_X_Emp.Nombre = "UC";
                    objH_Valores_X_Emp.Fecha = objEmpleadoQP.Fecha;
                    objH_Valores_X_Emp.Valor = objEmpleadoQP.Unidad_de_Costos;
                    objH_Valores_X_Emp = dataH_Valores_X_Emp.Insert(objH_Valores_X_Emp);

                    if (objH_Valores_X_Emp == null)
                    {
                        string logMesagge = "Error en la insercion de H_Valores_X_Emp con UC";
                        Log.LogService.Log(logMesagge);
                        throw new Exception(logMesagge);
                    }
                    else
                    {
                        Log.LogService.Log("La Unidad de Costos de la tabla 'H_Valores_X_Emp' se inserto exitosamente");
                    }
                }

                if (objEmpleadoQP.Centro_de_Costos != null || objEmpleadoQP.Centro_de_Costos != "")
                {
                    objH_Valores_X_Emp = new Entities.Kaizen.Empleados.H_Valores_X_Emp();
                    objH_Valores_X_Emp.Compania = objEmpleadoQP.Compania;
                    objH_Valores_X_Emp.companiaPasajes = objEmpleadoQP.CompaniaPasajes;
                    objH_Valores_X_Emp.numEmpleado = objEmpleadoQP.numEmpleado;
                    objH_Valores_X_Emp.Nombre = "CC";
                    objH_Valores_X_Emp.Fecha = objEmpleadoQP.Fecha;
                    objH_Valores_X_Emp.Valor = objEmpleadoQP.Centro_de_Costos;
                    objH_Valores_X_Emp = dataH_Valores_X_Emp.Insert(objH_Valores_X_Emp);

                    if (objH_Valores_X_Emp == null)
                    {
                        string logMesagge = "Error en la insercion de H_Valores_X_Emp con CC";
                        Log.LogService.Log(logMesagge);
                        throw new Exception(logMesagge);
                    }
                    else
                    {
                        Log.LogService.Log("El Centro de Costos de la tabla 'H_Valores_X_Emp' se inserto exitosamente");
                    }
                }

                if (objH_Valores_X_Emp.numEmpleado == null)
                {
                    objEmpleado = null;
                }

                return objEmpleado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Entities.Kaizen.Empleados.Empleado GetOne(string Compania, string NumEmpleado)
        {
            Entities.Kaizen.Empleados.Empleado empleado = new Entities.Kaizen.Empleados.Empleado();
            try
            {
                Data.Kaizen.Empleados.Empleado dataEmpleado = new Data.Kaizen.Empleados.Empleado();
                empleado = dataEmpleado.GetOne(Compania, NumEmpleado);
                return empleado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Entities.Kaizen.Empleados.Empleado> GetAll()
        {
            List<Entities.Kaizen.Empleados.Empleado> empleadoCollection = new List<Entities.Kaizen.Empleados.Empleado>();
            try
            {
                Data.Kaizen.Empleados.Empleado dataEmpleado = new Data.Kaizen.Empleados.Empleado();
                empleadoCollection = dataEmpleado.GetAll();
                return empleadoCollection;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Entities.Kaizen.Empleados.Empleado Update(Entities.Kaizen.Empleados.Empleado objEmpleado)
        {
            Entities.Kaizen.Empleados.Empleado empleado = new Entities.Kaizen.Empleados.Empleado();
            try
            {
                Data.Kaizen.Empleados.Empleado dataEmpleado = new Data.Kaizen.Empleados.Empleado();
                empleado = dataEmpleado.Update(objEmpleado);
                return empleado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Delete(string Compania, string NumEmpleado)
        {
            Data.Kaizen.Empleados.Empleado dataEmpleado = new Data.Kaizen.Empleados.Empleado();
            dataEmpleado.Delete(Compania, NumEmpleado);
        }

        public static void Rollback(Entities.Kaizen.Empleados.Empleado objEmpleado, int TipoRollback)
        {
            //Tipos de Rollback
            // 1 = Altas
            // 2 = Cambios
            // 3 = Bajas

            switch (TipoRollback)
            {
                case (int)Entities.Kaizen.Enum.TipoRollback.Altas:

                    if (TipoRollback.Equals((int)Entities.Kaizen.Enum.TipoRollback.Altas))
                    {
                        Data.Kaizen.Empleados.Empleado dataEmpleado = new Data.Kaizen.Empleados.Empleado();
                        Data.Kaizen.Empleados.H_Laboral dataH_Laboral = new Data.Kaizen.Empleados.H_Laboral();
                        Data.Kaizen.Empleados.H_Personal dataH_Personal = new Data.Kaizen.Empleados.H_Personal();
                        Data.Kaizen.Empleados.H_Sueldos dataH_Sueldos = new Data.Kaizen.Empleados.H_Sueldos();
                        Data.Kaizen.Empleados.H_Valores_X_Emp dataH_Valores_X_Emp = new Data.Kaizen.Empleados.H_Valores_X_Emp();
                        Data.Kaizen.Empleados.Tel_Empleados dataTel_Empleados = new Data.Kaizen.Empleados.Tel_Empleados();

                        dataH_Valores_X_Emp.Drop(objEmpleado.compania, objEmpleado.numEmpleado);
                        dataH_Laboral.Drop(objEmpleado.compania, objEmpleado.numEmpleado);
                        dataH_Sueldos.Drop(objEmpleado.compania, objEmpleado.numEmpleado);
                        dataH_Personal.Drop(objEmpleado.compania, objEmpleado.numEmpleado);
                        dataTel_Empleados.Drop(objEmpleado.compania, objEmpleado.numEmpleado);
                        dataEmpleado.Drop(objEmpleado.compania, objEmpleado.numEmpleado);

                        if (objEmpleado.companiaPasajes != "" || objEmpleado.companiaPasajes != null)
                        {
                            dataH_Valores_X_Emp.Drop(objEmpleado.companiaPasajes, objEmpleado.numEmpleado);
                            dataH_Laboral.Drop(objEmpleado.companiaPasajes, objEmpleado.numEmpleado);
                            dataH_Sueldos.Drop(objEmpleado.companiaPasajes, objEmpleado.numEmpleado);
                            dataH_Personal.Drop(objEmpleado.companiaPasajes, objEmpleado.numEmpleado);
                            dataTel_Empleados.Drop(objEmpleado.companiaPasajes, objEmpleado.numEmpleado);
                            dataEmpleado.Drop(objEmpleado.companiaPasajes, objEmpleado.numEmpleado);
                        }
                    }

                break;

                case 2:

                    if (TipoRollback.Equals((int)Entities.Kaizen.Enum.TipoRollback.Cambios))
                    {

                    }

                break;

                case 3:

                    if (TipoRollback.Equals((int)Entities.Kaizen.Enum.TipoRollback.Bajas))
                    {
                        Data.Kaizen.Empleados.Empleado dataEmpleado = new Data.Kaizen.Empleados.Empleado();
                        dataEmpleado.Update(objEmpleado);

                        if (objEmpleado.companiaPasajes != null)
                        {
                            objEmpleado.compania = objEmpleado.companiaPasajes;
                            dataEmpleado.Update(objEmpleado);
                        }
                    }

                break;
                    
            }

        }

        public static Entities.Kaizen.Empleados.Empleado BajaEmpleado(string compania, string numEmpleado, string motivo)
        {
            Entities.Kaizen.Empleados.Empleado empleado = new Entities.Kaizen.Empleados.Empleado();
            try
            {
                Data.Kaizen.Empleados.Empleado dataEmpleado = new Data.Kaizen.Empleados.Empleado();
                empleado = dataEmpleado.BajaEmpleado(compania, numEmpleado, motivo);
                return empleado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }

        public static Entities.Kaizen.Empleados.Empleado UpdateEmpleado(string compania, string numEmpleado, string motivo)
        {
            Entities.Kaizen.Empleados.Empleado empleado = new Entities.Kaizen.Empleados.Empleado();
            try
            {
                Data.Kaizen.Empleados.Empleado dataEmpleado = new Data.Kaizen.Empleados.Empleado();
                empleado = dataEmpleado.BajaEmpleado(compania, numEmpleado, motivo);
                return empleado;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }       

    }
}
