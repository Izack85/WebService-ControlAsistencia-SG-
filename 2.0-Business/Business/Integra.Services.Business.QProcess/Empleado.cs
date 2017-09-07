using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Log = Integra.Services.Business.Log;


namespace Integra.Services.Business.QProcess
{
    public class Empleado
    {
        #region GetLayoutKaizen
        //public static Entities.QProcess.Empleados.QProcessKaizen GetLayoutKaizen(int idLayout)
        //{
        //    Data.QProcess.Empleado dataEmpleadoQP = new Data.QProcess.Empleado();
        //    Data.Kaizen.Empleados.Empleado dataEmpleado = new Data.Kaizen.Empleados.Empleado();
        //    Data.Kaizen.Empleados.H_Laboral dataH_Laboral = new Data.Kaizen.Empleados.H_Laboral();
        //    Data.Kaizen.Empleados.H_Personal dataH_Personal = new Data.Kaizen.Empleados.H_Personal();
        //    Data.Kaizen.Empleados.H_Sueldos dataH_Sueldos = new Data.Kaizen.Empleados.H_Sueldos();
        //    Data.Kaizen.Empleados.H_Valores_X_Emp dataH_Valores_X_Emp = new Data.Kaizen.Empleados.H_Valores_X_Emp();
        //    Data.Kaizen.Empleados.Tel_Empleados dataTel_Empleados = new Data.Kaizen.Empleados.Tel_Empleados();
        //    Data.SoluglobChecador.Usuarios dataChecadorUsuarios = new Data.SoluglobChecador.Usuarios();
        //    Data.SoluglobAdministrativo.Personal dataAdministrativoPersonal = new Data.SoluglobAdministrativo.Personal();
        //    int Numero_de_Empleado = 0;
        //    Entities.QProcess.Empleados.QProcessKaizen objEmpleadoQP = new Entities.QProcess.Empleados.QProcessKaizen();
        //    Entities.Kaizen.Empleados.Empleado objEmpleado = new Entities.Kaizen.Empleados.Empleado();
        //    Entities.Kaizen.Empleados.Tel_Empleados objTel_Empleados = new Entities.Kaizen.Empleados.Tel_Empleados();
        //    Entities.Kaizen.Empleados.H_Personal objH_Personal = new Entities.Kaizen.Empleados.H_Personal();
        //    Entities.Kaizen.Empleados.H_Sueldos objH_Sueldos1 = new Entities.Kaizen.Empleados.H_Sueldos();
        //    Entities.Kaizen.Empleados.H_Sueldos objH_Sueldos2 = new Entities.Kaizen.Empleados.H_Sueldos();
        //    Entities.Kaizen.Empleados.H_Sueldos objH_Sueldos3 = new Entities.Kaizen.Empleados.H_Sueldos();
        //    Entities.Kaizen.Empleados.H_Laboral objH_Laboral = new Entities.Kaizen.Empleados.H_Laboral();
        //    Entities.Kaizen.Empleados.H_Valores_X_Emp objH_Valores_X_Emp = new Entities.Kaizen.Empleados.H_Valores_X_Emp();
        //    Entities.Kaizen.Empleados.H_Valores_X_Emp objH_Valores_X_EmpTUM = new Entities.Kaizen.Empleados.H_Valores_X_Emp();
        //    Entities.Kaizen.Empleados.H_Valores_X_Emp objH_Valores_X_EmpContabilidad = new Entities.Kaizen.Empleados.H_Valores_X_Emp();
        //    Entities.SoluglobChecador.Usuarios objChecadorUsuariosInicial = null;
        //    Entities.SoluglobAdministrativo.Personal objAdministrativoPersonalInicial = null;


        //    try
        //    {
        //        //Se obtienen datos de QProcess
        //        objEmpleadoQP = dataEmpleadoQP.GetLayoutKaizen(idLayout);
        //        Numero_de_Empleado = objEmpleadoQP.Numero_Nomina;

        //        if (objEmpleadoQP == null)
        //        {
        //            throw new Exception("Error en la recuperacion de datos de QProcess");
        //        }

        //        //Datos Empleado
        //        objEmpleado = new Entities.Kaizen.Empleados.Empleado();
        //        objEmpleado.compania = objEmpleadoQP.Compania;
        //        objEmpleado.numEmpleado = objEmpleadoQP.numEmpleado;
        //        objEmpleado.expediente = objEmpleadoQP.Expediente;
        //        objEmpleado.apellido_materno = objEmpleadoQP.ApellidoPat;
        //        objEmpleado.apellido_paterno = objEmpleadoQP.ApellidoMat;
        //        objEmpleado.nombres = objEmpleadoQP.Nombres;
        //        objEmpleado.nombre = objEmpleadoQP.Nombre;
        //        objEmpleado.fecha_nac = objEmpleadoQP.FechaNacimiento;
        //        objEmpleado.pais_nac = objEmpleadoQP.PaisNacimiento;
        //        objEmpleado.estado_nac = objEmpleadoQP.Estado_Nac;
        //        objEmpleado.lugar_nac = objEmpleadoQP.Lugar_Nac;
        //        objEmpleado.sexo = objEmpleadoQP.Sexo;
        //        objEmpleado.tipo_sangre = objEmpleadoQP.TipoSangre;
        //        objEmpleado.rfc = objEmpleadoQP.RFC;
        //        objEmpleado.curp = objEmpleadoQP.CURP;
        //        objEmpleado.numero_imss = objEmpleadoQP.NSS;
        //        objEmpleado.infonavit = objEmpleadoQP.NumCreditoInfonavit;
        //        objEmpleado.tipo_pago_infonavit = objEmpleadoQP.Tipo_Pago_Infonavit;
        //        objEmpleado.factor = objEmpleadoQP.Factor;
        //        objEmpleado.nombre_padre = objEmpleadoQP.Nombre_Padre;
        //        objEmpleado.nombre_madre = objEmpleadoQP.Nombre_Madre;
        //        objEmpleado.origen = objEmpleadoQP.Origen;
        //        objEmpleado.nacionalidad = objEmpleadoQP.Nacionalidad;
        //        objEmpleado.nivel_estudio = objEmpleadoQP.NivelEstudio;
        //        objEmpleado.turno = objEmpleadoQP.Turno;
        //        objEmpleado.tarjeta = objEmpleadoQP.Tarjeta;
        //        objEmpleado.destajos = objEmpleadoQP.Destajos;
        //        objEmpleado.tratamiento = objEmpleadoQP.Tratamiento;
        //        objEmpleado.elector = objEmpleadoQP.Elector;
        //        objEmpleado.licencia = objEmpleadoQP.Licencia;
        //        objEmpleado.tipo_pago = objEmpleadoQP.Tipo_Pago;
        //        objEmpleado.banco = objEmpleadoQP.Banco;
        //        objEmpleado.sucursal = objEmpleadoQP.Sucursal;
        //        objEmpleado.cta_cheques = objEmpleadoQP.Cta_Cheques;
        //        objEmpleado.clabe = objEmpleadoQP.CLABE;
        //        objEmpleado.banco_alt = objEmpleadoQP.Banco_Alt;
        //        objEmpleado.sucursal_alt = objEmpleadoQP.Sucursal_Alt;
        //        objEmpleado.cta_cheques_alt = objEmpleadoQP.Cta_Cheques_Alt;
        //        objEmpleado.clabe_alt = objEmpleadoQP.CLABE_Alt;
        //        objEmpleado.tarjeta_vales = objEmpleadoQP.Tarjeta_Vales;
        //        objEmpleado.path_foto = objEmpleadoQP.Path_Foto;
        //        objEmpleado.estatus = objEmpleadoQP.Estatus;
        //        objEmpleado.usuario = objEmpleadoQP.Usuario;
        //        objEmpleado.ip = objEmpleadoQP.Ip;
        //        objEmpleado.mac_address = objEmpleadoQP.Mac_Address;
        //        objEmpleado.entidadLaboral = objEmpleadoQP.EntidadLaboral;
        //        objEmpleado.cartilla = objEmpleadoQP.Cartilla;
        //        objEmpleado.fuente = objEmpleadoQP.Fuente;
        //        objEmpleado.path_firma = objEmpleadoQP.Path_Firma;
        //        objEmpleado.tarjeta_vales_ant = objEmpleadoQP.Tarjeta_Vales_Ant;
        //        objEmpleado.Correo = objEmpleadoQP.Correo;
        //        objEmpleado.Tarjeta_VGasolina = objEmpleadoQP.Tarjeta_VGasolina;
        //        objEmpleado = dataEmpleado.Insert(objEmpleado);

        //        if (objEmpleado.numEmpleado == null)
        //        {
        //            throw new Exception("Error en la insercion del Empleado");
        //        }

        //        //Datos Tel_Empleados
        //        objTel_Empleados = new Entities.Kaizen.Empleados.Tel_Empleados();
        //        objTel_Empleados.Compania = objEmpleadoQP.Compania;
        //        objTel_Empleados.numEmpleado = objEmpleado.numEmpleado;
        //        objTel_Empleados.Tipo = objEmpleadoQP.Tipo;
        //        objTel_Empleados.Sec = 1;
        //        objTel_Empleados.Telefono = objEmpleadoQP.Telefono;
        //        objTel_Empleados = dataTel_Empleados.Insert(objTel_Empleados);

        //        if (objTel_Empleados == null)
        //        {
        //            throw new Exception("Error en la insercion de Tel_Empleados");
        //        }

        //        //Datos H_Personal
        //        objH_Personal = new Entities.Kaizen.Empleados.H_Personal();
        //        objH_Personal.Compania = objEmpleadoQP.Compania;
        //        objH_Personal.numEmpleado = objEmpleadoQP.numEmpleado;
        //        objH_Personal.Fecha = objEmpleadoQP.Fecha;
        //        objH_Personal.Direccion = objEmpleadoQP.Direccion;
        //        objH_Personal.Poblacion = objEmpleadoQP.Poblacion;
        //        objH_Personal.Numero_Ext = objEmpleadoQP.Numero_Ext;
        //        objH_Personal.Numero_Int = objEmpleadoQP.Numero_Int;
        //        objH_Personal.Pais = objEmpleadoQP.Pais;
        //        objH_Personal.Cp = objEmpleadoQP.Cp;
        //        objH_Personal.Estado = objEmpleadoQP.Estado;
        //        objH_Personal.Estado_Civil = objEmpleadoQP.Estado_Civil;
        //        objH_Personal.Ciudad = objEmpleadoQP.Ciudad;
        //        objH_Personal.Colonia = objEmpleadoQP.Colonia;
        //        objH_Personal.Usuario = objEmpleadoQP.Usuario;
        //        objH_Personal.Ip = objEmpleadoQP.Ip;
        //        objH_Personal.Mac_Address = objEmpleadoQP.Mac_Address;
        //        objH_Personal = dataH_Personal.Insert(objH_Personal);

        //        if (objH_Personal == null)
        //        {
        //            throw new Exception("Error en la insercion de H_Personal");
        //        }

        //        //Datos H_Sueldos 1
        //        objH_Sueldos1 = new Entities.Kaizen.Empleados.H_Sueldos();
        //        objH_Sueldos1.Compania = objEmpleadoQP.Compania;
        //        objH_Sueldos1.numEmpleado = objEmpleadoQP.numEmpleado;
        //        objH_Sueldos1.Fecha = objEmpleadoQP.Fecha;
        //        objH_Sueldos1.Tipo_Sueldo = "SDI";
        //        objH_Sueldos1.Sueldo = objEmpleadoQP.Sueldo;
        //        objH_Sueldos1.Usuario = objEmpleadoQP.Usuario;
        //        objH_Sueldos1.Ip = objEmpleadoQP.Ip;
        //        objH_Sueldos1.Mac_Address = objEmpleadoQP.Mac_Address;
        //        objH_Sueldos1 = dataH_Sueldos.Insert(objH_Sueldos1);

        //        if (objH_Sueldos1 == null)
        //        {
        //            throw new Exception("Error en la insercion de H_Sueldos1");
        //        }

        //        //Datos H_Sueldos 2
        //        objH_Sueldos2 = new Entities.Kaizen.Empleados.H_Sueldos();
        //        objH_Sueldos2.Compania = objEmpleadoQP.Compania;
        //        objH_Sueldos2.numEmpleado = objEmpleadoQP.numEmpleado;
        //        objH_Sueldos2.Fecha = objEmpleadoQP.Fecha;
        //        objH_Sueldos2.Tipo_Sueldo = "SDN";
        //        objH_Sueldos2.Sueldo = objEmpleadoQP.Sueldo;
        //        objH_Sueldos2.Usuario = objEmpleadoQP.Usuario;
        //        objH_Sueldos2.Ip = objEmpleadoQP.Ip;
        //        objH_Sueldos2.Mac_Address = objEmpleadoQP.Mac_Address;
        //        objH_Sueldos2 = dataH_Sueldos.Insert(objH_Sueldos2);

        //        if (objH_Sueldos2 == null)
        //        {
        //            throw new Exception("Error en la insercion de H_Sueldos2");
        //        }

        //        //Datos H_Sueldos 3
        //        objH_Sueldos3 = new Entities.Kaizen.Empleados.H_Sueldos();
        //        objH_Sueldos3.Compania = objEmpleadoQP.Compania;
        //        objH_Sueldos3.numEmpleado = objEmpleadoQP.numEmpleado;
        //        objH_Sueldos3.Fecha = objEmpleadoQP.Fecha;
        //        objH_Sueldos3.Tipo_Sueldo = "SM";
        //        objH_Sueldos3.Sueldo = objEmpleadoQP.Sueldo;
        //        objH_Sueldos3.Usuario = objEmpleadoQP.Usuario;
        //        objH_Sueldos3.Ip = objEmpleadoQP.Ip;
        //        objH_Sueldos3.Mac_Address = objEmpleadoQP.Mac_Address;
        //        objH_Sueldos3 = dataH_Sueldos.Insert(objH_Sueldos3);

        //        if (objH_Sueldos3 == null)
        //        {
        //            throw new Exception("Error en la insercion de H_Sueldos3");
        //        }

        //        //Datos H_Laboral
        //        objH_Laboral = new Entities.Kaizen.Empleados.H_Laboral();
        //        objH_Laboral.Compania = objEmpleadoQP.Compania;
        //        objH_Laboral.numEmpleado = objEmpleadoQP.numEmpleado;
        //        objH_Laboral.Fecha = objEmpleadoQP.Fecha;
        //        objH_Laboral.Sec = objEmpleadoQP.Sec_H_Laboral;
        //        objH_Laboral.Accion = objEmpleadoQP.Accion;
        //        objH_Laboral.Motivo = objEmpleadoQP.Motivo;
        //        objH_Laboral.Grupo_Pago = objEmpleadoQP.Grupo_Pago;
        //        objH_Laboral.Tipo_Contrato = objEmpleadoQP.Tipo_Contrato;
        //        objH_Laboral.Fecha_Ingreso = objEmpleadoQP.Fecha_Ingreso;
        //        objH_Laboral.Fecha_Antiguedad1 = objEmpleadoQP.Fecha_Antiguedad1;
        //        objH_Laboral.Fecha_Antiguedad2 = objEmpleadoQP.Fecha_Antiguedad2;
        //        objH_Laboral.Fecha_Antiguedad3 = objEmpleadoQP.Fecha_Antiguedad3;
        //        objH_Laboral.Duracion = objEmpleadoQP.Duracion;
        //        objH_Laboral.Fecha_Vento = objEmpleadoQP.Fecha_Vento;
        //        objH_Laboral.Fecha_Baja = objEmpleadoQP.Fecha_Baja;
        //        objH_Laboral.Tipo_Salario = objEmpleadoQP.Tipo_Salario;
        //        objH_Laboral.Tipo_Empleado = objEmpleadoQP.Tipo_Empleado;
        //        objH_Laboral.Localidad = objEmpleadoQP.Localidad;
        //        objH_Laboral.Departamento = objEmpleadoQP.Departamento;
        //        objH_Laboral.Puesto = objEmpleadoQP.Puesto;
        //        objH_Laboral.Dependencia = objEmpleadoQP.Dependencia;
        //        objH_Laboral.Cliente = objEmpleadoQP.Cliente;
        //        objH_Laboral.Tipo_De_Operacion = objEmpleadoQP.Tipo_De_Operacion;
        //        objH_Laboral.Region = objEmpleadoQP.Region;
        //        objH_Laboral.Sector = objEmpleadoQP.Sector;
        //        objH_Laboral.Usuario = objEmpleadoQP.Usuario;
        //        objH_Laboral.Sindicalizado = objEmpleadoQP.Sindicalizado;
        //        objH_Laboral.Ip = objEmpleadoQP.Ip;
        //        objH_Laboral.Mac_Address = objEmpleadoQP.Mac_Address;
        //        objH_Laboral = dataH_Laboral.Insert(objH_Laboral);

        //        if (objH_Laboral == null)
        //        {
        //            throw new Exception("Error en la insercion de H_Laboral");
        //        }

        //        //Datos H_Valores_X_Emp
        //        if (objEmpleadoQP.Unidad_de_Costos != null || objEmpleadoQP.Unidad_de_Costos != "")
        //        {
        //            objH_Valores_X_Emp = new Entities.Kaizen.Empleados.H_Valores_X_Emp();
        //            objH_Valores_X_Emp.Compania = objEmpleadoQP.Compania;
        //            objH_Valores_X_Emp.numEmpleado = objEmpleadoQP.numEmpleado;
        //            objH_Valores_X_Emp.Nombre = "UC";
        //            objH_Valores_X_Emp.Fecha = objEmpleadoQP.Fecha;
        //            objH_Valores_X_Emp.Valor = objEmpleadoQP.Unidad_de_Costos;
        //            objH_Valores_X_Emp = dataH_Valores_X_Emp.Insert(objH_Valores_X_Emp);

        //            if (objH_Valores_X_Emp == null)
        //            {
        //                throw new Exception("Error en la insercion de H_Valores_X_Emp con UC");
        //            }
        //        }

        //        if (objEmpleadoQP.Centro_de_Costos != null || objEmpleadoQP.Centro_de_Costos != "")
        //        {
        //            objH_Valores_X_Emp = new Entities.Kaizen.Empleados.H_Valores_X_Emp();
        //            objH_Valores_X_Emp.Compania = objEmpleadoQP.Compania;
        //            objH_Valores_X_Emp.numEmpleado = objEmpleadoQP.numEmpleado;
        //            objH_Valores_X_Emp.Nombre = "CC";
        //            objH_Valores_X_Emp.Fecha = objEmpleadoQP.Fecha;
        //            objH_Valores_X_Emp.Valor = objEmpleadoQP.Centro_de_Costos;
        //            objH_Valores_X_Emp = dataH_Valores_X_Emp.Insert(objH_Valores_X_Emp);

        //            if (objH_Valores_X_Emp == null)
        //            {
        //                throw new Exception("Error en la insercion de H_Valores_X_Emp con CC");
        //            }
        //        }

        //        //Se obtiene el registro que se va a actualizar para usarlo en el rollback manual
        //        objChecadorUsuariosInicial = dataChecadorUsuarios.GetOne(objEmpleadoQP.Numero_Nomina);

        //        if (objChecadorUsuariosInicial == null)
        //        {
        //            throw new Exception("Error al recuperar el registro inicial de la tabla Usuarios");
        //        }

        //        //Datos Checador Usuarios
        //        Entities.SoluglobChecador.Usuarios objChecadorUsuarios = new Entities.SoluglobChecador.Usuarios();
        //        objChecadorUsuarios = new Entities.SoluglobChecador.Usuarios();
        //        objChecadorUsuarios.Numero_Nomina = objEmpleadoQP.Numero_Nomina;
        //        objChecadorUsuarios.Numero_Nominas = int.Parse(objEmpleadoQP.Compania + objEmpleadoQP.numEmpleado);
        //        objChecadorUsuarios = dataChecadorUsuarios.UpdateNumeroNominas(objChecadorUsuarios);

        //        if (objChecadorUsuarios == null)
        //        {
        //            throw new Exception("Error en la insercion de Usuario");
        //        }

        //        //Se obtiene el registro que se va a actualizar para usarlo en el rollback manual
        //        objAdministrativoPersonalInicial = dataAdministrativoPersonal.GetOneByNumeroChecador(objEmpleadoQP.Numero_Nomina);

        //        if (objAdministrativoPersonalInicial == null)
        //        {
        //            throw new Exception("Error al recuperar el registro inicial de la tabla Personal");
        //        }

        //        if (objAdministrativoPersonalInicial.Id_Per != 0)
        //        {
        //            //Datos Administrativo
        //            Entities.SoluglobAdministrativo.Personal objAdministrativoPersonal = new Entities.SoluglobAdministrativo.Personal();
        //            objAdministrativoPersonal = new Entities.SoluglobAdministrativo.Personal();
        //            objAdministrativoPersonal.Id_Per = objAdministrativoPersonalInicial.Id_Per;
        //            objAdministrativoPersonal.Num_Checador = int.Parse(objEmpleadoQP.Compania + objEmpleadoQP.numEmpleado);
        //            objAdministrativoPersonal.Nomi_Camb = 1;
        //            objAdministrativoPersonal = dataAdministrativoPersonal.UpdateNumChecadorAndNomiCamb(objAdministrativoPersonal);

        //            if (objAdministrativoPersonal.Id_Per != 0)
        //            {
        //                int NumeroNomina = dataEmpleadoQP.UpdateEstatusProceso(objEmpleadoQP.Numero_Nomina, 2);
        //            }
        //            else
        //            {
        //                objEmpleadoQP = null;
        //            }
        //        }
        //        else
        //        {
        //            throw new Exception("La tabla 'Personal' no fue actualizada correctamente");
        //        }

        //        //if (objEmpleadoQP != null)
        //        //{
        //        //    throw new Exception("Prueba de Reverso");
        //        //}

        //        return objEmpleadoQP;

        //    }
        //    catch (Exception ex)
        //    {
        //        //Rollback Kaizen
        //        dataH_Valores_X_Emp.Drop(objEmpleadoQP.Compania, objEmpleadoQP.numEmpleado);
        //        dataH_Laboral.Drop(objEmpleadoQP.Compania, objEmpleadoQP.numEmpleado);
        //        dataH_Sueldos.Drop(objEmpleadoQP.Compania, objEmpleadoQP.numEmpleado);
        //        dataH_Personal.Drop(objEmpleadoQP.Compania, objEmpleadoQP.numEmpleado);
        //        dataTel_Empleados.Drop(objEmpleadoQP.Compania, objEmpleadoQP.numEmpleado);
        //        dataEmpleado.Drop(objEmpleadoQP.Compania, objEmpleadoQP.numEmpleado);

        //        //Rollback Checador 
        //        if (objChecadorUsuariosInicial != null)
        //        {
        //            Entities.SoluglobChecador.Usuarios objChecadorUsuarios = new Entities.SoluglobChecador.Usuarios();
        //            objChecadorUsuarios = new Entities.SoluglobChecador.Usuarios();
        //            objChecadorUsuarios.Numero_Nomina = objChecadorUsuariosInicial.Numero_Nomina;
        //            objChecadorUsuarios.Numero_Nominas = objChecadorUsuariosInicial.Numero_Nominas;
        //            objChecadorUsuarios = dataChecadorUsuarios.UpdateNumeroNominas(objChecadorUsuarios);
        //        }
        //        //Rollback Administrativo
        //        if (objAdministrativoPersonalInicial != null)
        //        {
        //            Entities.SoluglobAdministrativo.Personal objAdministrativoPersonal = new Entities.SoluglobAdministrativo.Personal();
        //            objAdministrativoPersonal = new Entities.SoluglobAdministrativo.Personal();
        //            objAdministrativoPersonal.Id_Per = objAdministrativoPersonalInicial.Id_Per;
        //            objAdministrativoPersonal.Num_Checador = objAdministrativoPersonalInicial.Num_Checador;
        //            objAdministrativoPersonal.Nomi_Camb = 0;
        //            objAdministrativoPersonal = dataAdministrativoPersonal.UpdateNumChecadorAndNomiCamb(objAdministrativoPersonal);
        //        }

        //        throw new Exception(ex.Message.ToString());
        //    }
        //}

        #endregion

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        #region Altas
        public static Entities.Kaizen.Empleados.Empleado GetLayoutKaizen(int idLayout)
        {
            int Numero_de_Empleado = 0;
            int Id_PerNuevo = 0;
            int NumeroNomina = 0;
            Entities.QProcess.Empleados.AltaKaizen objEmpleadoQP = new Entities.QProcess.Empleados.AltaKaizen();
            Entities.SoluglobAdministrativo.Personal objPersonalInicial = null;
            Entities.SoluglobAdministrativo.Vacantes objVacantesInicial = null;
            Entities.SoluglobAdministrativo.PerVac objPerVacInicial = null;
            Entities.SoluglobAdministrativo.Vacantes objVacantes = new Entities.SoluglobAdministrativo.Vacantes();
            Entities.SoluglobAdministrativo.PerVac objPerVac = new Entities.SoluglobAdministrativo.PerVac();
            Entities.QProcess.Contratacion objContratacion = new Entities.QProcess.Contratacion();

            Data.QProcess.Empleado dataEmpleadoQP = new Data.QProcess.Empleado();
            Data.SoluglobChecador.Usuarios dataChecadorUsuarios = new Data.SoluglobChecador.Usuarios();
            Data.SoluglobAdministrativo.Personal dataAdministrativoPersonal = new Data.SoluglobAdministrativo.Personal();

            try
            {
                //Se obtienen datos de QProcess
                objEmpleadoQP = dataEmpleadoQP.GetLayoutKaizen(idLayout);
                Numero_de_Empleado = objEmpleadoQP.Numero_Nomina;

                if (objEmpleadoQP == null)
                {
                    string logMesagge = "Error en la recuperacion de datos de QProcess en el proceso de Alta de Empleado.";
                    Log.LogService.Log(logMesagge);
                    throw new Exception(logMesagge);
                }
                else
                {
                    Log.LogService.Log("Recuperacion de datos de QProcess exitosamente en el proceso de Alta de Empleado.");
                }

                //Se inserta el empleado a Kaizen con los datos obtenidos de QProcess
                Entities.Kaizen.Empleados.Empleado altaEmpleado = Business.Kaizen.Empleados.Empleado.Insert(objEmpleadoQP);

                if (altaEmpleado.compania == null || altaEmpleado.numEmpleado == null)
                {
                    string logMesagge = "Error en la insercion a Kaizen";
                    Log.LogService.Log(logMesagge);
                    throw new Exception(logMesagge);
                }
                else
                {
                    Log.LogService.Log("Los datos de Kaizen se insertaron exitosamente");
                }

                //Se obtienen los registros que se va a actualizar para usarlos en el rollback manual
                objPersonalInicial = dataAdministrativoPersonal.GetOneByNumeroChecador(objEmpleadoQP.Numero_Nomina);

                if (objPersonalInicial.Id_Per == 0)
                {
                    string logMesagge = "Error al recuperar el registro inicial de la tabla Personal";
                    Log.LogService.Log(logMesagge);
                    throw new Exception(logMesagge);
                }
                else
                {
                    Log.LogService.Log("Se recuperan los datos de tabla Personal exitosamente");
                }

                //Se obtienen los registros que se va a actualizar para usarlos en el rollback manual
                objVacantesInicial = Business.SoluglobAdministrativo.Vacantes.GetOneByIdPer(objEmpleadoQP.Numero_Nomina);

                if (objVacantesInicial.Id_Per == 0)
                {
                    string logMesagge = "Error al recuperar el registro inicial de la tabla Vacantes";
                    Log.LogService.Log(logMesagge);
                    throw new Exception(logMesagge);
                }
                else
                {
                    Log.LogService.Log("Se recuperan los datos de tabla Vacantes exitosamente");
                }

                //Se obtienen los registros que se va a actualizar para usarlos en el rollback manual
                objPerVacInicial = Business.SoluglobAdministrativo.PerVac.GetOne(objEmpleadoQP.Numero_Nomina, objVacantesInicial.Id_Vac);

                if (objPerVacInicial.Id_Per == 0)
                {
                    string logMesagge = "Error al recuperar el registro inicial de la tabla PerVac";///////////////////////////////
                    Log.LogService.Log(logMesagge);
                    throw new Exception(logMesagge);
                }
                else
                {
                    Log.LogService.Log("Se recuperan los datos de tabla PerVac exitosamente");
                }

                if (objPersonalInicial.Id_Per != 0)
                {
                    //Se actualizan los datos de Personal en BD Administrativo
                    Entities.SoluglobAdministrativo.Personal objAdministrativoPersonal = new Entities.SoluglobAdministrativo.Personal();
                    objAdministrativoPersonal = new Entities.SoluglobAdministrativo.Personal();
                    objAdministrativoPersonal.Id_Per = int.Parse(altaEmpleado.compania + altaEmpleado.numEmpleado);
                    objAdministrativoPersonal.Num_Checador = objEmpleadoQP.Numero_Nomina;
                    objAdministrativoPersonal.Nomi_Camb = 1;
                    objAdministrativoPersonal = dataAdministrativoPersonal.UpdateId_PerAndNomiCamb(objAdministrativoPersonal);

                    if (objAdministrativoPersonal.Id_Per == 0)
                    {
                        string logMesagge = "Los datos de la tabla 'Personal' no fueron actualizados correctamente";
                        Log.LogService.Log(logMesagge);
                        throw new Exception(logMesagge);
                    }
                    else
                    {
                        Log.LogService.Log("Los datos de la tabla 'Personal' fueron actualizados correctamente");
                    }
                }
                else
                {
                    string logMesagge = "Los datos de la tabla 'Personal' no fueron insertados correctamente";
                    Log.LogService.Log(logMesagge);
                    throw new Exception(logMesagge);
                }


                if (objVacantesInicial.Id_Per != 0)
                {
                    //Se actualizan los datos de Vacantes en BD Administrativo
                    objVacantes = new Entities.SoluglobAdministrativo.Vacantes();
                    objVacantes.Id_Per = Convert.ToInt32(altaEmpleado.compania + altaEmpleado.numEmpleado);
                    objVacantes.Id_Vac = objVacantesInicial.Id_Vac;
                    objVacantes = Business.SoluglobAdministrativo.Vacantes.UpdateIdPer(objVacantes);
                }
                else
                {
                    string logMesagge = "Los datos de la tabla 'Tb_Vacantes' no fueron insertados correctamente";
                    Log.LogService.Log(logMesagge);
                    throw new Exception(logMesagge);
                }


                if (objVacantes.Id_Per != int.Parse(altaEmpleado.compania + altaEmpleado.numEmpleado))
                {
                    string logMesagge = "Los datos de la tabla 'Tb_Vacantes' no fueron actualizados correctamente";
                    Log.LogService.Log(logMesagge);
                    throw new Exception(logMesagge);
                }
                else
                {
                    Log.LogService.Log("Los datos de la tabla 'Tb_Vacantes' fueron actualizados correctamente");
                }

                if (objPerVacInicial.Id_Per != 0)
                {
                    //Se actualizan los datos de PerVac en BD Administrativo
                    Id_PerNuevo = int.Parse(altaEmpleado.compania + altaEmpleado.numEmpleado);
                    objPerVac = new Entities.SoluglobAdministrativo.PerVac();
                    objPerVac = Business.SoluglobAdministrativo.PerVac.UpdateIdPer(objPerVacInicial.Id_Per, Id_PerNuevo, objPerVacInicial.Id_Vac);

                    if (objPerVac.Id_Per == 0)
                    {
                        altaEmpleado = null;
                        string logMesagge = "Los datos de la tabla 'Tb_PerVac' no fueron actualizados correctamente";
                        Log.LogService.Log(logMesagge);
                        throw new Exception(logMesagge);
                    }
                    else
                    {
                        Log.LogService.Log("Los datos de la tabla 'Tb_PerVac' fueron actualizados correctamente");
                    }
                }
                else
                {
                    string logMesagge = "Los datos de la tabla 'Tb_PerVac' no fueron insertados correctamente";
                    Log.LogService.Log(logMesagge);
                    throw new Exception(logMesagge);
                }

                if (objPerVac.Id_Per == int.Parse(altaEmpleado.compania + altaEmpleado.numEmpleado))
                {
                    //Se actualizan el campo EstatusProceso en QProcess
                    objContratacion = Business.QProcess.Contratacion.UpdateEstatusProceso(objEmpleadoQP.Numero_Nomina, (int)Entities.Kaizen.Enum.EstatusProceso.Kaizen);
                    //NumeroNomina = dataEmpleadoQP.UpdateEstatusProceso(objEmpleadoQP.Numero_Nomina, (int)Entities.Kaizen.Enum.EstatusProceso.Kaizen);
                }
                else
                {
                    altaEmpleado = null;
                    string logMesagge = "Los datos de la tabla 'Tb_PerVac' no fueron actualizados correctamente";
                    Log.LogService.Log(logMesagge);
                    throw new Exception(logMesagge);
                }

                if (!objContratacion.EstatusProceso.Equals((int)Entities.Kaizen.Enum.EstatusProceso.Kaizen))
                {
                    altaEmpleado = null;
                    string logMesagge = "El campo 'Estatus Proceso' no se actualizo correctamente";
                    Log.LogService.Log(logMesagge);
                    throw new Exception(logMesagge);
                }
                else
                {
                    Log.LogService.Log("El campo 'Estatus Proceso' fue actualizado correctamente");
                    if (objVacantes.Id_Vac == 9991 || objVacantes.Id_Vac == 9992 || objVacantes.Id_Vac == 9993 || objVacantes.Id_Vac == 9994 || objVacantes.Id_Vac == 9995)
                    {
                        Business.SoluglobChecador.Usuarios.EnvioCorreo(objEmpleadoQP.Numero_Nomina, objVacantes.Id_Vac);
                        //bool result = Business.SoluglobChecador.Usuarios.EnvioCorreo2(objEmpleadoQP.NumChecador, Id_VacMin);
                    }
                }

                return altaEmpleado;

            }
            catch (Exception ex)//Falta agregar las acciones de todo el catch al Log
            {
                //Rollback Kaizen
                Entities.Kaizen.Empleados.Empleado objEmpleadoRollBack = new Entities.Kaizen.Empleados.Empleado();
                objEmpleadoRollBack.compania = objEmpleadoQP.Compania;
                objEmpleadoRollBack.companiaPasajes = objEmpleadoQP.CompaniaPasajes;
                objEmpleadoRollBack.numEmpleado = objEmpleadoQP.numEmpleado;
                Business.Kaizen.Empleados.Empleado.Rollback(objEmpleadoRollBack, (int)Entities.Kaizen.Enum.TipoRollback.Altas);

                //Rollback Administrativo
                if (objPersonalInicial != null)
                {
                    Entities.SoluglobAdministrativo.Personal objAdministrativoPersonal = new Entities.SoluglobAdministrativo.Personal();
                    objAdministrativoPersonal = new Entities.SoluglobAdministrativo.Personal();
                    objAdministrativoPersonal.Id_Per = objPersonalInicial.Id_Per;
                    objAdministrativoPersonal.Num_Checador = objPersonalInicial.Num_Checador;
                    objAdministrativoPersonal.Nomi_Camb = 0;
                    objAdministrativoPersonal = dataAdministrativoPersonal.UpdateId_PerAndNomiCamb(objAdministrativoPersonal);
                }

                if (objVacantesInicial != null)
                {
                    Entities.SoluglobAdministrativo.Vacantes objVacantesRollback = new Entities.SoluglobAdministrativo.Vacantes();
                    objVacantesRollback.Id_Per = objVacantesInicial.Id_Per;
                    objVacantesRollback.Id_Vac = objVacantesInicial.Id_Vac;
                    objVacantesRollback = Business.SoluglobAdministrativo.Vacantes.UpdateIdPer(objVacantesRollback);
                }

                if (objPerVacInicial != null)
                {
                    Entities.SoluglobAdministrativo.PerVac objPerVacRollback = new Entities.SoluglobAdministrativo.PerVac();
                    objPerVacRollback = Business.SoluglobAdministrativo.PerVac.UpdateIdPer(Id_PerNuevo, objPerVacInicial.Id_Per, objPerVacInicial.Id_Vac);

                }

                if (objContratacion.EstatusProceso.Equals((int)Entities.Kaizen.Enum.EstatusProceso.Kaizen))
                {
                    NumeroNomina = dataEmpleadoQP.UpdateEstatusProceso(objEmpleadoQP.Numero_Nomina, (int)Entities.Kaizen.Enum.EstatusProceso.Soluglob);
                }

                throw ex;
            }
        }

        public static int GetLayoutSoluglob(int IdEntrevistaCandidato)
        {
            Entities.QProcess.Empleados.AltaSoluglob EmpleadoQP = new Entities.QProcess.Empleados.AltaSoluglob();
            try
            {
                Data.QProcess.Empleado dataEmpleados = new Data.QProcess.Empleado();
                int id_Per = Business.SoluglobAdministrativo.Personal.GetMaxId();
                if (id_Per == 0)
                {
                    string logMesagge = "Fallo la recuperacion del Id_Per maximo";
                    Log.LogService.Log(logMesagge);
                    throw new Exception(logMesagge);
                }
                else
                {
                    Log.LogService.Log("Se recupero el Id_Per maximo exitosamente");
                }

                int Numero_Nomina = Business.SoluglobChecador.Usuarios.GetMaxId();
                if (Numero_Nomina == 0)
                {
                    string logMesagge = "Fallo la recuperacion del Numero_Nomina maximo";
                    Log.LogService.Log(logMesagge);
                    throw new Exception(logMesagge);
                }
                else
                {
                    Log.LogService.Log("Se recupero el Numero_Nomina maximo exitosamente");
                }
                int NumeroEmpleado = 0;
                int Id_VacMin = 0;

                EmpleadoQP = dataEmpleados.GetLayoutSoluglob(IdEntrevistaCandidato, id_Per, Numero_Nomina);
                if (EmpleadoQP == null)
                {
                    string logMesagge = "Error en la recuperacion de datos de QProcess";
                    Log.LogService.Log(logMesagge);
                    throw new Exception(logMesagge);
                }
                else
                {
                    Log.LogService.Log("Recuperacion de datos de QProcess exitosamente en el proceso de Alta de Empleado de Soluglob.");

                    Id_VacMin = Business.SoluglobAdministrativo.Vacantes.GetMinIdByPuestoCeCoUCo(EmpleadoQP.idCatPuesto, EmpleadoQP.CeCo, EmpleadoQP.UCos);

                    if (Id_VacMin == 0)
                    {
                        string logMesagge = "Error en la recuperacion de datos Min Vacantes";
                        Log.LogService.Log(logMesagge);
                        throw new Exception(logMesagge);
                    }
                    else
                    {
                        Log.LogService.Log("Se recupera el Id minimo disponible de la vacante del puesto.");
                    }

                    EmpleadoQP.Id_Vac = Id_VacMin;
                    NumeroEmpleado = SoluglobChecador.Empleados.Insert(EmpleadoQP);
                }

                return NumeroEmpleado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        public static Entities.SoluglobAdministrativo.Personal MovimientoEmpleadoSG(string NumEmpleado, int IdRequisicionMovimiento)
        {
            int Id_VacMin = 0;
            bool resultDropPerVar = false;
            Entities.QProcess.Empleados.Movimientos objEmpleadoQP = new Entities.QProcess.Empleados.Movimientos();
            Entities.SoluglobAdministrativo.Personal objPersonal = new Entities.SoluglobAdministrativo.Personal();
            Entities.SoluglobAdministrativo.Vacantes objVacantes = new Entities.SoluglobAdministrativo.Vacantes();
            Entities.SoluglobAdministrativo.PerVac objPerVac = new Entities.SoluglobAdministrativo.PerVac();

            Entities.SoluglobAdministrativo.Personal objPersonalInicial = new Entities.SoluglobAdministrativo.Personal();
            Entities.SoluglobAdministrativo.Vacantes objVacantesInicial = new Entities.SoluglobAdministrativo.Vacantes();
            Entities.SoluglobAdministrativo.PerVac objPerVacInicial = new Entities.SoluglobAdministrativo.PerVac();


            Data.QProcess.Empleado dataEmpleadoQP = new Data.QProcess.Empleado();
            try
            {
                //Se obtienen datos de QProcess
                objEmpleadoQP = dataEmpleadoQP.GetLayoutMovimientos(NumEmpleado, IdRequisicionMovimiento);

                if (objEmpleadoQP == null)
                {
                    string logMesagge = "Error en la recuperacion de datos de QProcess del empleado: " + NumEmpleado;
                    Log.LogService.Log(logMesagge);
                    throw new Exception(logMesagge);
                }
                else
                {
                    Log.LogService.Log("Recuperacion de datos de QProcess exitosamente del empleado: " + NumEmpleado);
                }

                if (objEmpleadoQP.NumChecador == 0)
                {
                    //Se obtiene el Id_Per de empleados antiguos (antes de implementar QProcess)
                    objPersonalInicial = Business.SoluglobAdministrativo.Personal.GetOneByNumeroChecador(Convert.ToInt32(NumEmpleado));
                }

                //Se obtienen los datos actuales del empleado
                objPersonalInicial = Business.SoluglobAdministrativo.Personal.GetOneByNumeroChecador(objEmpleadoQP.NumChecador);

                if (objPersonalInicial.Id_Per == 0)
                {
                    string logMesagge = "Error al recuperar el registro inicial de la tabla Personal del empleado: " + NumEmpleado;
                    Log.LogService.Log(logMesagge);
                    throw new Exception(logMesagge);
                }
                else
                {
                    Log.LogService.Log("Se recuperan los datos de tabla Personal exitosamente del empleado: " + NumEmpleado);
                }

                //Se obtiene los datos de la vacante que ocupa el empleado actualmente
                objVacantesInicial = Business.SoluglobAdministrativo.Vacantes.GetOneByIdPer(objPersonalInicial.Id_Per);

                if (objVacantesInicial.Id_Per == 0)
                {
                    string logMesagge = "Error al recuperar el registro inicial de la tabla Vacantes del empleado: " + NumEmpleado;
                    Log.LogService.Log(logMesagge);
                    throw new Exception(logMesagge);
                }
                else
                {
                    Log.LogService.Log("Se recuperan los datos de tabla Vacantes exitosamente del empleado: " + NumEmpleado);
                }

                //Se obtiene los datos de la relacion PerVac actual
                objPerVacInicial = Business.SoluglobAdministrativo.PerVac.GetOne(objPersonalInicial.Id_Per, objVacantesInicial.Id_Vac);

                if (objPerVacInicial.Id_Per == 0)
                {
                    string logMesagge = "Error al recuperar el registro inicial de la tabla PerVac del empleado: " + NumEmpleado;
                    Log.LogService.Log(logMesagge);
                    throw new Exception(logMesagge);
                }
                else
                {
                    Log.LogService.Log("Se recuperan los datos de tabla PerVac exitosamente del empleado: " + NumEmpleado);
                }

                if (objEmpleadoQP.idCatTipoMovimiento == (int)Entities.Kaizen.Enum.TipoMovimiento.CambioSueldo)
                {
                    if (!objEmpleadoQP.IdCambio.Equals((int)Entities.Kaizen.Enum.TipoCambio.Puesto))
                    {
                        objEmpleadoQP.idCatTipoMovimiento = (int)Entities.Kaizen.Enum.TipoMovimiento.CambioSituacionLaboral;
                    }
                }


                switch (objEmpleadoQP.idCatTipoMovimiento)
                {
                    case (int)Entities.Kaizen.Enum.TipoMovimiento.CambioSueldo://Cambio de Sueldo

                        break;

                    case (int)Entities.Kaizen.Enum.TipoMovimiento.CambioSituacionLaboral://Cambios de Situacion Laboral

                        //Se obtiene la vacante del nuevo puesto del empleado
                        Id_VacMin = Business.SoluglobAdministrativo.Vacantes.GetMinIdByPuestoCeCoUCo(objEmpleadoQP.idCatPuestoNuevo, objEmpleadoQP.idCeCoNuevo, objEmpleadoQP.ClaveUCoNueva);

                        if (Id_VacMin == 0)
                        {
                            string logMesagge = "No se encuentra la relacion entre Puesto, Centro de Costos y Unidad de Costos del empleado: " + NumEmpleado;
                            Log.LogService.Log(logMesagge);
                            throw new Exception(logMesagge);
                        }
                        else
                        {
                            Log.LogService.Log("Se recupera el Id minimo disponible de la vacante del puesto del empleado: " + NumEmpleado);

                        }

                        objEmpleadoQP.Id_Vac_Nueva = Id_VacMin;//Preguntar a Rafa: Al obterner esta vacante ya estan relacionados el Puesto con CeCo y UCo???

                        //Se libera la vacante que ocupa el empleado actualmente
                        objVacantes = new Entities.SoluglobAdministrativo.Vacantes();
                        objVacantes.Id_Per = null;
                        objVacantes.Estatus_Vacante = 0;
                        objVacantes.Id_Vac = objVacantesInicial.Id_Vac;
                        objVacantes = Business.SoluglobAdministrativo.Vacantes.UpdateId_PerAndEstatusVacante(objVacantes);

                        if (objVacantes.Id_Per != null)
                        {
                            string logMesagge = "Error en la liberacion de la vacante de la tabla Tb_Vacantes del empleado: " + NumEmpleado;
                            Log.LogService.Log(logMesagge);
                            throw new Exception(logMesagge);
                        }
                        else
                        {
                            Log.LogService.Log("Se libera la vacante que ocupa actualmente el empleado: " + NumEmpleado + " de forma exitosa");
                        }

                        //Se quita la relacion PerVac
                        resultDropPerVar = Business.SoluglobAdministrativo.PerVac.Drop(objPersonalInicial.Id_Per, objVacantesInicial.Id_Vac);

                        if (resultDropPerVar == false)
                        {
                            string logMesagge = "Error en la eliminacion de la relacion de la tabla Tb_PerVac.";
                            Log.LogService.Log(logMesagge);
                            throw new Exception(logMesagge);
                        }
                        else
                        {
                            Log.LogService.Log("Se elimino la relacion de la tabla Tb_PerVac que ocupa el empleado: " + NumEmpleado + " de forma exitosa.");
                        }

                        //Se asigna el empleado a la nueva vacante 
                        objVacantes = new Entities.SoluglobAdministrativo.Vacantes();
                        objVacantes.Id_Vac = objEmpleadoQP.Id_Vac_Nueva;
                        objVacantes.Id_Per = objPersonalInicial.Id_Per;
                        objVacantes = Business.SoluglobAdministrativo.Vacantes.UpdateIdPer(objVacantes);

                        if (objVacantes.Id_Per == null)
                        {
                            string logMesagge = "Error en la actualizacion del campo Id_Per de la tabla Tb_Vacantes del empleado: " + NumEmpleado;
                            Log.LogService.Log(logMesagge);
                            throw new Exception(logMesagge);
                        }
                        else
                        {
                            Log.LogService.Log("Se asigno al empleado: " + NumEmpleado + " a la nueva vacante de forma exitosa");
                        }

                        //Se inserta la nueva relacion PerVac
                        objPerVac = new Entities.SoluglobAdministrativo.PerVac();
                        objPerVac.Id_Per = objPersonalInicial.Id_Per;
                        objPerVac.Id_Vac = objEmpleadoQP.Id_Vac_Nueva;
                        objPerVac = Business.SoluglobAdministrativo.PerVac.Insert(objPerVac);

                        if (objPerVac == null)
                        {
                            string logMesagge = "Error en la inserción de datos a TB_PerVac del empleado: " + NumEmpleado;
                            Log.LogService.Log(logMesagge);
                            throw new Exception(logMesagge);
                        }
                        else
                        {
                            Log.LogService.Log("Se inserta la nueva relacion PerVac de forma exitosa del empleado: " + NumEmpleado);
                        }

                        //Se cambia EstatusProceso en QProcess
                        Entities.QProcess.Empleados.Movimientos objEmpleadoMovimientosQP = dataEmpleadoQP.UpdateEstatusProcesoMovimiento(NumEmpleado, IdRequisicionMovimiento, (int)Entities.Kaizen.Enum.EstatusProceso.Soluglob);

                        if (!objEmpleadoMovimientosQP.EstatusProceso.Equals((int)Entities.Kaizen.Enum.EstatusProceso.Soluglob))
                        {
                            string logMesagge = "Error en la Actualización Estatus Proceso Movimiento del empleado: " + NumEmpleado;
                            Log.LogService.Log(logMesagge);
                            throw new Exception(logMesagge);
                        }
                        else
                        {
                            Log.LogService.Log("El campo 'Estatus Proceso Movimiento' fue actualizado correctamente del empleado: " + NumEmpleado);
                        }

                        break;

                    case (int)Entities.Kaizen.Enum.TipoMovimiento.BajaEmpleado://Baja de empleado

                        objPersonal = Business.SoluglobAdministrativo.Personal.BajaEmpleado(Convert.ToInt32(NumEmpleado), -1);

                        if (objPersonal.Estatus == -1)
                        {
                            Log.LogService.Log("Se dio de baja al empleado con Id_Per: '" + objPersonal.Id_Per + "' correctamente");
                            objEmpleadoQP = dataEmpleadoQP.UpdateEstatusProcesoMovimiento(NumEmpleado, objEmpleadoQP.idRequisicionMovimiento, (int)Entities.Kaizen.Enum.EstatusProceso.Soluglob);

                            if (objEmpleadoQP.EstatusProceso != 1)
                            {
                                string logMesagge = "Error al actualizar el 'Estatus Proceso' al terminar el proceso de baja en Soluglob. El valor del campo 'Estatus Proceso' es " + objEmpleadoQP.EstatusProceso + ".";
                                Log.LogService.Log(logMesagge);
                                throw new Exception(logMesagge);
                            }
                            else
                            {
                                Log.LogService.Log("El campo 'Estatus Proceso Movimiento' fue actualizado correctamente del empleado: " + NumEmpleado);
                            }
                        }
                        else
                        {
                            string logMesagge = "Hubo un error al intentar cambiar el estatus del empleado con Id_Per: '" + objPersonal.Id_Per + "' en la tabla Tb_Personal";
                            Log.LogService.Log(logMesagge);
                            throw new Exception(logMesagge);
                        }

                        break;

                }

                return objPersonal;

            }
            catch (Exception ex)
            {
                switch (objEmpleadoQP.idCatTipoMovimiento)
                {
                    case (int)Entities.Kaizen.Enum.TipoMovimiento.CambioSueldo://Cambio de Sueldo

                        break;

                    case (int)Entities.Kaizen.Enum.TipoMovimiento.CambioSituacionLaboral://Cambios de Situacion Laboral

                        if (objVacantesInicial.Id_Vac != 0)
                        {
                            Entities.SoluglobAdministrativo.Vacantes objVacantesRollback = new Entities.SoluglobAdministrativo.Vacantes();
                            if (objVacantes.Id_Vac != 0)
                            {
                                objVacantesRollback.Id_Per = null;
                                objVacantesRollback.Estatus_Vacante = 0;
                                objVacantesRollback.Id_Vac = objVacantes.Id_Vac;
                                objVacantesRollback = Business.SoluglobAdministrativo.Vacantes.UpdateId_PerAndEstatusVacante(objVacantesRollback);

                                if (objVacantesRollback.Id_Per != null)
                                {
                                    string logMesagge = "Rollback: Error al intentar regresar al punto inicial la vacante: " + objVacantes.Id_Vac;
                                    Log.LogService.Log(logMesagge);
                                    throw new Exception(logMesagge);
                                }
                                else
                                {
                                    Log.LogService.Log("Rollback: La vacante: " + objVacantes.Id_Vac + "se regreso a su punto inicial correctamente");
                                }
                            }
                            objVacantesRollback = Business.SoluglobAdministrativo.Vacantes.UpdateId_PerAndEstatusVacante(objVacantesInicial);

                            if (objVacantesRollback.Id_Per != null)
                            {
                                string logMesagge = "Rollback: Error al intentar regresar al punto inicial la vacante: " + objVacantes.Id_Vac;
                                Log.LogService.Log(logMesagge);
                                throw new Exception(logMesagge);
                            }
                            else
                            {
                                Log.LogService.Log("Rollback: La vacante: " + objVacantes.Id_Vac + "se regreso a su punto inicial correctamente");
                            }

                        }

                        if (objPerVacInicial.Id_Vac != 0)
                        {
                            bool resultDropPerVacRollback = false;

                            if (objPerVac.Id_Vac != 0)
                            {
                                resultDropPerVacRollback = Business.SoluglobAdministrativo.PerVac.Drop(objPerVac.Id_Per, objEmpleadoQP.Id_Vac_Nueva);

                                if (resultDropPerVacRollback == false)
                                {
                                    string logMesagge = "Rollback: Error al intentar borrar la nueva relacion PerVac Id_Per: " + objPerVac.Id_Per + "Id_Vac: " + objEmpleadoQP.Id_Vac_Nueva;
                                    Log.LogService.Log(logMesagge);
                                    throw new Exception(logMesagge);
                                }
                                else
                                {
                                    Log.LogService.Log("Rollback: Se borro la nueva relacion PerVac Id_Per: " + objPerVac.Id_Per + "Id_Vac: " + objEmpleadoQP.Id_Vac_Nueva + " correctamente");
                                }
                            }

                            if (resultDropPerVar == true)
                            {
                                Entities.SoluglobAdministrativo.PerVac objPerVacRollback = Business.SoluglobAdministrativo.PerVac.Insert(objPerVacInicial);

                                if (objPerVacRollback.Id_Vac == 0)
                                {
                                    string logMesagge = "Rollback: Error al insertar la relacion inicial PerVac Id_Per: " + objPerVacInicial.Id_Per + "Id_Vac: " + objPerVacInicial.Id_Vac;
                                    Log.LogService.Log(logMesagge);
                                    throw new Exception(logMesagge);
                                }
                                else
                                {
                                    Log.LogService.Log("Rollback: Se borro la relacion inicial PerVac Id_Per: " + objPerVacInicial.Id_Per + "Id_Vac: " + objPerVacInicial.Id_Vac + " correctamente");
                                }
                            }

                        }

                        break;

                    case (int)Entities.Kaizen.Enum.TipoMovimiento.BajaEmpleado://Baja de empleado

                        if (objPersonal.Estatus == -1)
                        {
                            objPersonal = Business.SoluglobAdministrativo.Personal.BajaEmpleado(Convert.ToInt32(NumEmpleado), 1);

                            if (objPersonal.Estatus == -1)
                            {
                                string logMesagge = "Rollback: Hubo un error al intentar regresar al punto inicial el estatus del empleado: " + NumEmpleado;
                                Log.LogService.Log(logMesagge);
                                throw new Exception(logMesagge);
                            }
                            else
                            {
                                Log.LogService.Log("Rollback: El estatus del empleado: " + NumEmpleado + " se regreso al punto inicial correctamente");
                            }
                        }

                        if (objVacantesInicial.Id_Vac != 0)
                        {
                            Entities.SoluglobAdministrativo.Vacantes objVacantesRollback = Business.SoluglobAdministrativo.Vacantes.UpdateId_PerAndEstatusVacante(objVacantesInicial);

                            if (objVacantesRollback.Id_Vac != objVacantesInicial.Id_Vac)
                            {
                                string logMesagge = "Rollback: Error al intentar regresar al punto inicial la vacante: " + objVacantesInicial.Id_Vac;
                                Log.LogService.Log(logMesagge);
                                throw new Exception(logMesagge);
                            }
                            else
                            {
                                Log.LogService.Log("Rollback: La vacante: " + objVacantesInicial.Id_Vac + "se regreso a su punto inicial correctamente");
                            }
                        }

                        if (objPerVacInicial.Id_Vac != 0)
                        {
                            bool resultDropPerVacRollback = false;

                            if (objPerVac.Id_Vac != 0)
                            {
                                resultDropPerVacRollback = Business.SoluglobAdministrativo.PerVac.Drop(objPerVac.Id_Per, objEmpleadoQP.Id_Vac_Nueva);

                                if (resultDropPerVacRollback == false)
                                {
                                    string logMesagge = "Rollback: Error al intentar borrar la nueva relacion PerVac Id_Per: " + objPerVac.Id_Per + "Id_Vac: " + objEmpleadoQP.Id_Vac_Nueva;
                                    Log.LogService.Log(logMesagge);
                                    throw new Exception(logMesagge);
                                }
                                else
                                {
                                    Log.LogService.Log("Rollback: Se borro la nueva relacion PerVac Id_Per: " + objPerVac.Id_Per + "Id_Vac: " + objEmpleadoQP.Id_Vac_Nueva + " correctamente");
                                }
                            }

                            if (resultDropPerVar == true)
                            {
                                Entities.SoluglobAdministrativo.PerVac objPerVacRollback = Business.SoluglobAdministrativo.PerVac.Insert(objPerVacInicial);

                                if (objPerVacRollback.Id_Vac == 0)
                                {
                                    string logMesagge = "Rollback: Error al insertar la relacion inicial PerVac Id_Per: " + objPerVacInicial.Id_Per + "Id_Vac: " + objPerVacInicial.Id_Vac;
                                    Log.LogService.Log(logMesagge);
                                    throw new Exception(logMesagge);
                                }
                                else
                                {
                                    Log.LogService.Log("Rollback: Se borro la relacion inicial PerVac Id_Per: " + objPerVacInicial.Id_Per + "Id_Vac: " + objPerVacInicial.Id_Vac + " correctamente");
                                }
                            }
                        }

                        break;

                }

                objEmpleadoQP = dataEmpleadoQP.UpdateEstatusProcesoMovimiento(NumEmpleado, objEmpleadoQP.idRequisicionMovimiento, (int)Entities.Kaizen.Enum.EstatusProceso.QProcess);

                if (!objEmpleadoQP.EstatusProceso.Equals((int)Entities.Kaizen.Enum.EstatusProceso.QProcess))
                {
                    string logMesagge = "Rollback: Error al intentar regresar el campo 'Estatus Proceso' del empleado: " + NumEmpleado + " al punto inicial";
                    Log.LogService.Log(logMesagge);
                    throw new Exception(logMesagge);
                }
                else
                {
                    Log.LogService.Log("Rollback: El campo 'Estatus Proceso' del empleado: " + NumEmpleado + " se regreso a su punto inicial correctamente");
                }

                throw ex;
            }

        }

        public static Entities.QProcess.Empleados.Movimientos MovimientoEmpleadoKaizen(string NumEmpleado, int IdRequisicionMovimiento)
        {
            Entities.QProcess.Empleados.Movimientos objEmpleadoQP = new Entities.QProcess.Empleados.Movimientos();
            Entities.Kaizen.Empleados.Empleado objEmpleadoKaizen = new Entities.Kaizen.Empleados.Empleado();
            Entities.Kaizen.Empleados.H_Laboral objH_Laboral = new Entities.Kaizen.Empleados.H_Laboral();
            Entities.Kaizen.Empleados.H_Valores_X_Emp objH_Valores_X_EmpCeco = new Entities.Kaizen.Empleados.H_Valores_X_Emp();
            Entities.Kaizen.Empleados.H_Valores_X_Emp objH_Valores_X_EmpUCos = new Entities.Kaizen.Empleados.H_Valores_X_Emp();
            Entities.Kaizen.Empleados.H_Sueldos objH_Sueldos = new Entities.Kaizen.Empleados.H_Sueldos();
            Entities.QProcess.Empleados.Movimientos objEmpleadoMovimientosQP = new Entities.QProcess.Empleados.Movimientos();

            //Objetos creados para mantener los datos en memoria 
            Entities.QProcess.Empleados.Movimientos objEmpleadoQPInicial = new Entities.QProcess.Empleados.Movimientos();
            Entities.Kaizen.Empleados.Empleado objEmpleadoKaizenInicial = new Entities.Kaizen.Empleados.Empleado();
            Entities.Kaizen.Empleados.H_Laboral objH_LaboralInicial = new Entities.Kaizen.Empleados.H_Laboral();

            Data.QProcess.Empleado dataEmpleadoQP = new Data.QProcess.Empleado();

            try
            {
                //Se obtienen datos de QProcess
                objEmpleadoQP = dataEmpleadoQP.GetLayoutMovimientos(NumEmpleado, IdRequisicionMovimiento);

                if (objEmpleadoQP.Compania == null)
                {
                    string logMesagge = "Error en la recuperacion de datos de QProcess del empleado: " + NumEmpleado;
                    Log.LogService.Log(logMesagge);
                    throw new Exception(logMesagge);
                }
                else
                {
                    Log.LogService.Log("Recuperacion de datos de QProcess del empleado: " + NumEmpleado + " exitosa");
                }

                objEmpleadoQPInicial = objEmpleadoQP;

                switch (objEmpleadoQPInicial.idCatTipoMovimiento)
                {
                    case (int)Entities.Kaizen.Enum.TipoMovimiento.CambioSueldo://Cambio de Sueldos

                        switch (objEmpleadoQPInicial.IdCambio)
                        {
                            case (int)Entities.Kaizen.Enum.TipoCambio.Sueldo://Sueldo

                                objEmpleadoQP.CompaniaPasajes = "";
                                objH_Sueldos = CambioSueldo(objH_Sueldos, objEmpleadoQP);

                                if (objH_Sueldos.Fecha == default(DateTime))
                                {
                                    string logMesagge = "Fallo la actualizacion de Sueldo del empleado: " + NumEmpleado;
                                    Log.LogService.Log(logMesagge);
                                    throw new Exception(logMesagge);
                                }
                                else
                                {
                                    Log.LogService.Log("Actualizacion de Sueldo exitosa del empleado: " + NumEmpleado);
                                }

                                //Se llena el objeto de salida con los atributos que se cambiaron
                                objEmpleadoQP = new Entities.QProcess.Empleados.Movimientos();
                                objEmpleadoQP.Compania = objH_Sueldos.Compania;
                                objEmpleadoQP.Empleado = objH_Sueldos.numEmpleado;
                                objEmpleadoQP.CompaniaPasajes = objH_Sueldos.companiaPasajes;
                                objEmpleadoQP.SueldoNuevo = objH_Sueldos.Sueldo;

                                break;

                            case (int)Entities.Kaizen.Enum.TipoCambio.PuestoSueldo://Puesto, Sueldo

                                //Se cambia el Puesto
                                objH_Laboral = CambioPuesto(objH_Laboral, objEmpleadoQP);

                                if (objH_Laboral.Compania == null)
                                {
                                    string logMesagge = "Fallo la actualizacion de Puesto del empleado: " + NumEmpleado;
                                    Log.LogService.Log(logMesagge);
                                    throw new Exception(logMesagge);
                                }
                                else
                                {
                                    Log.LogService.Log("Actualizacion de Puesto exitosa del empleado: " + NumEmpleado);
                                }

                                //Se cambia el Sueldo
                                objH_Sueldos = CambioSueldo(objH_Sueldos, objEmpleadoQP);

                                if (objH_Sueldos.Fecha == default(DateTime))
                                {
                                    string logMesagge = "Fallo la actualizacion de Sueldo del empleado: " + NumEmpleado;
                                    Log.LogService.Log(logMesagge);
                                    throw new Exception(logMesagge);
                                }
                                else
                                {
                                    Log.LogService.Log("Actualizacion de Sueldo exitosa del empleado: " + NumEmpleado);
                                }

                                //Se llena el objeto de salida con los atributos que se cambiaron
                                objEmpleadoQP = new Entities.QProcess.Empleados.Movimientos();
                                objEmpleadoQP.Compania = objH_Sueldos.Compania;
                                objEmpleadoQP.Empleado = objH_Sueldos.numEmpleado;
                                objEmpleadoQP.CompaniaPasajes = objH_Sueldos.companiaPasajes;
                                objEmpleadoQP.Accion = objH_Laboral.Accion;
                                objEmpleadoQP.Motivo = objH_Laboral.Motivo;
                                objEmpleadoQP.PuestoNuevo = objH_Laboral.Puesto;
                                objEmpleadoQP.SueldoNuevo = objH_Sueldos.Sueldo;

                                break;

                            case (int)Entities.Kaizen.Enum.TipoCambio.CentroCostosSueldo://CeCo, Sueldo

                                //Se cambia el Ceco
                                objH_Valores_X_EmpCeco = CambioCentroCostos(objH_Valores_X_EmpCeco, objEmpleadoQP);

                                if (objH_Valores_X_EmpCeco.Compania == null)
                                {
                                    string logMesagge = "Fallo la actualizacion de Centro de Costos del empleado: " + NumEmpleado;
                                    Log.LogService.Log(logMesagge);
                                    throw new Exception(logMesagge);
                                }
                                else
                                {
                                    Log.LogService.Log("Actualizacion de Centro de Costos exitosa del empleado: " + NumEmpleado);
                                }

                                //Se cambia el Sueldo
                                objH_Sueldos = CambioSueldo(objH_Sueldos, objEmpleadoQP);

                                if (objH_Sueldos.Fecha == default(DateTime))
                                {
                                    string logMesagge = "Fallo la actualizacion de Sueldo del empleado: " + NumEmpleado;
                                    Log.LogService.Log(logMesagge);
                                    throw new Exception(logMesagge);
                                }
                                else
                                {
                                    Log.LogService.Log("Actualizacion de Sueldo exitosa del empleado: " + NumEmpleado);
                                }

                                //Se llena el objeto de salida con los atributos que se cambiaron
                                objEmpleadoQP = new Entities.QProcess.Empleados.Movimientos();
                                objEmpleadoQP.Compania = objH_Sueldos.Compania;
                                objEmpleadoQP.Empleado = objH_Sueldos.numEmpleado;
                                objEmpleadoQP.CompaniaPasajes = objH_Sueldos.companiaPasajes;
                                objEmpleadoQP.CentroCostoNuevo = objH_Valores_X_EmpCeco.Valor;
                                objEmpleadoQP.SueldoNuevo = objH_Sueldos.Sueldo;

                                break;

                            case (int)Entities.Kaizen.Enum.TipoCambio.UnidadCostosSueldo://UCOS, SUELDO

                                //Se cambia el UCos
                                objH_Valores_X_EmpUCos = CambioUnidadCostos(objH_Valores_X_EmpUCos, objEmpleadoQP);

                                if (objH_Valores_X_EmpUCos.Compania == null)
                                {
                                    string logMesagge = "Fallo la actualizacion de Unidad de Costos del empleado: " + NumEmpleado;
                                    Log.LogService.Log(logMesagge);
                                    throw new Exception(logMesagge);
                                }
                                else
                                {
                                    Log.LogService.Log("Actualizacion de Unidad de Costos exitosa del empleado: " + NumEmpleado);
                                }

                                //Se cambia el Sueldo
                                objH_Sueldos = CambioSueldo(objH_Sueldos, objEmpleadoQP);

                                if (objH_Sueldos.Fecha == default(DateTime))
                                {
                                    string logMesagge = "Fallo la actualizacion de Sueldo del empleado: " + NumEmpleado;
                                    Log.LogService.Log(logMesagge);
                                    throw new Exception(logMesagge);
                                }
                                else
                                {
                                    Log.LogService.Log("Actualizacion de Sueldo exitosa del empleado: " + NumEmpleado);
                                }

                                //Se llena el objeto de salida con los atributos que se cambiaron
                                objEmpleadoQP = new Entities.QProcess.Empleados.Movimientos();
                                objEmpleadoQP.Compania = objH_Sueldos.Compania;
                                objEmpleadoQP.Empleado = objH_Sueldos.numEmpleado;
                                objEmpleadoQP.CompaniaPasajes = objH_Sueldos.companiaPasajes;
                                objEmpleadoQP.ClaveUCoNueva = objH_Valores_X_EmpUCos.Valor;
                                objEmpleadoQP.SueldoNuevo = objH_Sueldos.Sueldo;

                                break;

                            case (int)Entities.Kaizen.Enum.TipoCambio.PuestoCentroCostosSueldo://PUESTO, CECO, SUELDO

                                //Se cambia el Puesto
                                objH_Laboral = CambioPuesto(objH_Laboral, objEmpleadoQP);

                                if (objH_Laboral.Compania == null)
                                {
                                    string logMesagge = "Fallo la actualizacion de Puesto del empleado: " + NumEmpleado;
                                    Log.LogService.Log(logMesagge);
                                    throw new Exception(logMesagge);
                                }
                                else
                                {
                                    Log.LogService.Log("Actualizacion de Puesto exitosa del empleado: " + NumEmpleado);
                                }

                                //Se cambia el Ceco
                                objH_Valores_X_EmpCeco = CambioCentroCostos(objH_Valores_X_EmpCeco, objEmpleadoQP);

                                if (objH_Valores_X_EmpCeco.Compania == null)
                                {
                                    string logMesagge = "Fallo la actualizacion de Centro de Costos del empleado: " + NumEmpleado;
                                    Log.LogService.Log(logMesagge);
                                    throw new Exception(logMesagge);
                                }
                                else
                                {
                                    Log.LogService.Log("Actualizacion de Centro de Costos exitosa del empleado: " + NumEmpleado);
                                }

                                //Se cambia el Sueldo
                                objH_Sueldos = CambioSueldo(objH_Sueldos, objEmpleadoQP);

                                if (objH_Sueldos.Fecha == default(DateTime))
                                {
                                    string logMesagge = "Fallo la actualizacion de Sueldo del empleado: " + NumEmpleado;
                                    Log.LogService.Log(logMesagge);
                                    throw new Exception(logMesagge);
                                }
                                else
                                {
                                    Log.LogService.Log("Actualizacion de Sueldo exitosa del empleado: " + NumEmpleado);
                                }

                                //Se llena el objeto de salida con los atributos que se cambiaron
                                objEmpleadoQP = new Entities.QProcess.Empleados.Movimientos();
                                objEmpleadoQP.Compania = objH_Sueldos.Compania;
                                objEmpleadoQP.Empleado = objH_Sueldos.numEmpleado;
                                objEmpleadoQP.CompaniaPasajes = objH_Sueldos.companiaPasajes;
                                objEmpleadoQP.Accion = objH_Laboral.Accion;
                                objEmpleadoQP.Motivo = objH_Laboral.Motivo;
                                objEmpleadoQP.PuestoNuevo = objH_Laboral.Puesto;
                                objEmpleadoQP.CentroCostoNuevo = objH_Valores_X_EmpCeco.Valor;
                                objEmpleadoQP.SueldoNuevo = objH_Sueldos.Sueldo;

                                break;

                            case (int)Entities.Kaizen.Enum.TipoCambio.PuestoUnidadCostosSueldo://PUESTO, UCOS, SUELDO

                                //Se cambia el Puesto
                                objH_Laboral = CambioPuesto(objH_Laboral, objEmpleadoQP);

                                if (objH_Laboral.Compania == null)
                                {
                                    string logMesagge = "Fallo la actualizacion de Puesto del empleado: " + NumEmpleado;
                                    Log.LogService.Log(logMesagge);
                                    throw new Exception(logMesagge);
                                }
                                else
                                {
                                    Log.LogService.Log("Actualizacion de Puesto exitosa del empleado: " + NumEmpleado);
                                }

                                //Se cambia el UCos
                                objH_Valores_X_EmpUCos = CambioUnidadCostos(objH_Valores_X_EmpUCos, objEmpleadoQP);

                                if (objH_Valores_X_EmpUCos.Compania == null)
                                {
                                    string logMesagge = "Fallo la actualizacion de Unidad de Costos del empleado: " + NumEmpleado;
                                    Log.LogService.Log(logMesagge);
                                    throw new Exception(logMesagge);
                                }
                                else
                                {
                                    Log.LogService.Log("Actualizacion de Unidad de Costos exitosa del empleado: " + NumEmpleado);
                                }

                                //Se cambia el Sueldo
                                objH_Sueldos = CambioSueldo(objH_Sueldos, objEmpleadoQP);

                                if (objH_Sueldos.Fecha == default(DateTime))
                                {
                                    string logMesagge = "Fallo la actualizacion de Sueldo del empleado: " + NumEmpleado;
                                    Log.LogService.Log(logMesagge);
                                    throw new Exception(logMesagge);
                                }
                                else
                                {
                                    Log.LogService.Log("Actualizacion de Sueldo exitosa del empleado: " + NumEmpleado);
                                }

                                //Se llena el objeto de salida con los atributos que se cambiaron
                                objEmpleadoQP = new Entities.QProcess.Empleados.Movimientos();
                                objEmpleadoQP.Compania = objH_Laboral.Compania;
                                objEmpleadoQP.Empleado = objH_Laboral.numEmpleado;
                                objEmpleadoQP.CompaniaPasajes = objH_Laboral.companiaPasajes;
                                objEmpleadoQP.Accion = objH_Laboral.Accion;
                                objEmpleadoQP.Motivo = objH_Laboral.Motivo;
                                objEmpleadoQP.PuestoNuevo = objH_Laboral.Puesto;
                                objEmpleadoQP.ClaveUCoNueva = objH_Valores_X_EmpUCos.Valor;
                                objEmpleadoQP.SueldoNuevo = objH_Sueldos.Sueldo;

                                break;

                            case (int)Entities.Kaizen.Enum.TipoCambio.CentroCostosUnidadCostosSueldo://CECO, UCOS, SUELDO

                                //Se cambia el Ceco
                                objH_Valores_X_EmpCeco = CambioCentroCostos(objH_Valores_X_EmpCeco, objEmpleadoQP);

                                if (objH_Valores_X_EmpCeco.Compania == null)
                                {
                                    string logMesagge = "Fallo la actualizacion de Centro de Costos del empleado: " + NumEmpleado;
                                    Log.LogService.Log(logMesagge);
                                    throw new Exception(logMesagge);
                                }
                                else
                                {
                                    Log.LogService.Log("Actualizacion de Centro de Costos exitosa del empleado: " + NumEmpleado);
                                }

                                //Se cambia el UCos
                                objH_Valores_X_EmpUCos = CambioUnidadCostos(objH_Valores_X_EmpUCos, objEmpleadoQP);

                                if (objH_Valores_X_EmpUCos.Compania == null)
                                {
                                    string logMesagge = "Fallo la actualizacion de Unidad de Costos del empleado: " + NumEmpleado;
                                    Log.LogService.Log(logMesagge);
                                    throw new Exception(logMesagge);
                                }
                                else
                                {
                                    Log.LogService.Log("Actualizacion de Unidad de Costos exitosa del empleado: " + NumEmpleado);
                                }

                                //Se cambia el Sueldo
                                objH_Sueldos = CambioSueldo(objH_Sueldos, objEmpleadoQP);

                                if (objH_Sueldos.Fecha == default(DateTime))
                                {
                                    string logMesagge = "Fallo la actualizacion de Sueldo del empleado: " + NumEmpleado;
                                    Log.LogService.Log(logMesagge);
                                    throw new Exception(logMesagge);
                                }
                                else
                                {
                                    Log.LogService.Log("Actualizacion de Sueldo exitosa del empleado: " + NumEmpleado);
                                }

                                //Se llena el objeto de salida con los atributos que se cambiaron
                                objEmpleadoQP = new Entities.QProcess.Empleados.Movimientos();
                                objEmpleadoQP.Compania = objH_Valores_X_EmpCeco.Compania;
                                objEmpleadoQP.Empleado = objH_Valores_X_EmpCeco.numEmpleado;
                                objEmpleadoQP.CompaniaPasajes = objH_Valores_X_EmpCeco.companiaPasajes;
                                objEmpleadoQP.ClaveUCoNueva = objH_Valores_X_EmpUCos.Valor;
                                objEmpleadoQP.CentroCostoNuevo = objH_Valores_X_EmpCeco.Valor;
                                objEmpleadoQP.SueldoNuevo = objH_Sueldos.Sueldo;

                                break;

                            case (int)Entities.Kaizen.Enum.TipoCambio.Todos://TODOS

                                //Se cambia el Puesto
                                objH_Laboral = CambioPuesto(objH_Laboral, objEmpleadoQP);

                                if (objH_Laboral.Compania == null)
                                {
                                    string logMesagge = "Fallo la actualizacion de Puesto del empleado: " + NumEmpleado;
                                    Log.LogService.Log(logMesagge);
                                    throw new Exception(logMesagge);
                                }
                                else
                                {
                                    Log.LogService.Log("Actualizacion de Puesto exitosa del empleado: " + NumEmpleado);
                                }

                                //Se cambia el Ceco
                                objH_Valores_X_EmpCeco = CambioCentroCostos(objH_Valores_X_EmpCeco, objEmpleadoQP);

                                if (objH_Valores_X_EmpCeco.Compania == null)
                                {
                                    string logMesagge = "Fallo la actualizacion de Centro de Costos del empleado: " + NumEmpleado;
                                    Log.LogService.Log(logMesagge);
                                    throw new Exception(logMesagge);
                                }
                                else
                                {
                                    Log.LogService.Log("Actualizacion de Centro de Costos exitosa del empleado: " + NumEmpleado);
                                }

                                //Se cambia el UCos
                                objH_Valores_X_EmpUCos = CambioUnidadCostos(objH_Valores_X_EmpUCos, objEmpleadoQP);

                                if (objH_Valores_X_EmpUCos.Compania == null)
                                {
                                    string logMesagge = "Fallo la actualizacion de Unidad de Costos del empleado: " + NumEmpleado;
                                    Log.LogService.Log(logMesagge);
                                    throw new Exception(logMesagge);
                                }
                                else
                                {
                                    Log.LogService.Log("Actualizacion de Unidad de Costos exitosa del empleado: " + NumEmpleado);
                                }

                                //Se cambia el Sueldo
                                objH_Sueldos = CambioSueldo(objH_Sueldos, objEmpleadoQP);

                                if (objH_Sueldos.Fecha == default(DateTime))
                                {
                                    string logMesagge = "Fallo la actualizacion de Sueldo del empleado: " + NumEmpleado;
                                    Log.LogService.Log(logMesagge);
                                    throw new Exception(logMesagge);
                                }
                                else
                                {
                                    Log.LogService.Log("Actualizacion de Sueldo exitosa del empleado: " + NumEmpleado);
                                }

                                //Se llena el objeto de salida con los atributos que se cambiaron
                                objEmpleadoQP = new Entities.QProcess.Empleados.Movimientos();
                                objEmpleadoQP.Compania = objH_Laboral.Compania;
                                objEmpleadoQP.Empleado = objH_Laboral.numEmpleado;
                                objEmpleadoQP.CompaniaPasajes = objH_Laboral.companiaPasajes;
                                objEmpleadoQP.Accion = objH_Laboral.Accion;
                                objEmpleadoQP.Motivo = objH_Laboral.Motivo;
                                objEmpleadoQP.PuestoNuevo = objH_Laboral.Puesto;
                                objEmpleadoQP.ClaveUCoNueva = objH_Valores_X_EmpUCos.Valor;
                                objEmpleadoQP.CentroCostoNuevo = objH_Valores_X_EmpCeco.Valor;
                                objEmpleadoQP.SueldoNuevo = objH_Sueldos.Sueldo;

                                break;

                        }

                        break;

                    case (int)Entities.Kaizen.Enum.TipoMovimiento.CambioSituacionLaboral://Cambios de situacion laboral

                        switch (objEmpleadoQPInicial.IdCambio)
                        {
                            case (int)Entities.Kaizen.Enum.TipoCambio.Puesto://PUESTO

                                //Se cambia el Puesto
                                objH_Laboral = CambioPuesto(objH_Laboral, objEmpleadoQP);

                                if (objH_Laboral.Compania == null)
                                {
                                    string logMesagge = "Fallo la actualizacion de Puesto del empleado: " + NumEmpleado;
                                    Log.LogService.Log(logMesagge);
                                    throw new Exception(logMesagge);
                                }
                                else
                                {
                                    Log.LogService.Log("Actualizacion de Puesto exitosa del empleado: " + NumEmpleado);
                                }

                                //Se llena el objeto de salida con los atributos que se cambiaron
                                objEmpleadoQP = new Entities.QProcess.Empleados.Movimientos();
                                objEmpleadoQP.Compania = objH_Laboral.Compania;
                                objEmpleadoQP.Empleado = objH_Laboral.numEmpleado;
                                objEmpleadoQP.CompaniaPasajes = objH_Laboral.companiaPasajes;
                                objEmpleadoQP.Accion = objH_Laboral.Accion;
                                objEmpleadoQP.Motivo = objH_Laboral.Motivo;
                                objEmpleadoQP.PuestoNuevo = objH_Laboral.Puesto;

                                break;

                            case (int)Entities.Kaizen.Enum.TipoCambio.CentroCostos://CECO

                                //Se cambia el Ceco
                                objH_Valores_X_EmpCeco = CambioCentroCostos(objH_Valores_X_EmpCeco, objEmpleadoQP);

                                if (objH_Valores_X_EmpCeco.Compania == null)
                                {
                                    string logMesagge = "Fallo la actualizacion de Centro de Costos del empleado: " + NumEmpleado;
                                    Log.LogService.Log(logMesagge);
                                    throw new Exception(logMesagge);
                                }
                                else
                                {
                                    Log.LogService.Log("Actualizacion de Centro de Costos exitosa del empleado: " + NumEmpleado);
                                }

                                //Se llena el objeto de salida con los atributos que se cambiaron
                                objEmpleadoQP = new Entities.QProcess.Empleados.Movimientos();
                                objEmpleadoQP.Compania = objH_Valores_X_EmpCeco.Compania;
                                objEmpleadoQP.Empleado = objH_Valores_X_EmpCeco.numEmpleado;
                                objEmpleadoQP.CompaniaPasajes = objH_Valores_X_EmpCeco.companiaPasajes;
                                objEmpleadoQP.CentroCostoNuevo = objH_Valores_X_EmpCeco.Valor;

                                break;

                            case (int)Entities.Kaizen.Enum.TipoCambio.UnidadCostos://UCOS

                                //Se cambia el UCos
                                objH_Valores_X_EmpUCos = CambioUnidadCostos(objH_Valores_X_EmpUCos, objEmpleadoQP);

                                if (objH_Valores_X_EmpUCos.Compania == null)
                                {
                                    string logMesagge = "Fallo la actualizacion de Unidad de Costos del empleado: " + NumEmpleado;
                                    Log.LogService.Log(logMesagge);
                                    throw new Exception(logMesagge);
                                }
                                else
                                {
                                    Log.LogService.Log("Actualizacion de Unidad de Costos exitosa del empleado: " + NumEmpleado);
                                }

                                //Se llena el objeto de salida con los atributos que se cambiaron
                                objEmpleadoQP = new Entities.QProcess.Empleados.Movimientos();
                                objEmpleadoQP.Compania = objH_Valores_X_EmpUCos.Compania;
                                objEmpleadoQP.Empleado = objH_Valores_X_EmpUCos.numEmpleado;
                                objEmpleadoQP.CompaniaPasajes = objH_Valores_X_EmpUCos.companiaPasajes;
                                objEmpleadoQP.ClaveUCoNueva = objH_Valores_X_EmpUCos.Valor;

                                break;

                            case (int)Entities.Kaizen.Enum.TipoCambio.PuestoCentroCostos://PUESTO, CECO

                                //Se cambia el Puesto
                                objH_Laboral = CambioPuesto(objH_Laboral, objEmpleadoQP);

                                if (objH_Laboral.Compania == null)
                                {
                                    string logMesagge = "Fallo la actualizacion de Puesto del empleado: " + NumEmpleado;
                                    Log.LogService.Log(logMesagge);
                                    throw new Exception(logMesagge);
                                }
                                else
                                {
                                    Log.LogService.Log("Actualizacion de Puesto exitosa del empleado: " + NumEmpleado);
                                }

                                //Se cambia el Ceco
                                objH_Valores_X_EmpCeco = CambioCentroCostos(objH_Valores_X_EmpCeco, objEmpleadoQP);

                                if (objH_Valores_X_EmpCeco.Compania == null)
                                {
                                    string logMesagge = "Fallo la actualizacion de Centro de Costos del empleado: " + NumEmpleado;
                                    Log.LogService.Log(logMesagge);
                                    throw new Exception(logMesagge);
                                }
                                else
                                {
                                    Log.LogService.Log("Actualizacion de Centro de Costos exitosa del empleado: " + NumEmpleado);
                                }

                                //Se llena el objeto de salida con los atributos que se cambiaron
                                objEmpleadoQP = new Entities.QProcess.Empleados.Movimientos();
                                objEmpleadoQP.Compania = objH_Laboral.Compania;
                                objEmpleadoQP.Empleado = objH_Laboral.numEmpleado;
                                objEmpleadoQP.CompaniaPasajes = objH_Laboral.companiaPasajes;
                                objEmpleadoQP.Accion = objH_Laboral.Accion;
                                objEmpleadoQP.Motivo = objH_Laboral.Motivo;
                                objEmpleadoQP.PuestoNuevo = objH_Laboral.Puesto;
                                objEmpleadoQP.CentroCostoNuevo = objH_Valores_X_EmpCeco.Valor;

                                break;

                            case (int)Entities.Kaizen.Enum.TipoCambio.PuestoUnidadCostos://PUESTO, UCOS

                                //Se cambia el Puesto
                                objH_Laboral = CambioPuesto(objH_Laboral, objEmpleadoQP);

                                if (objH_Laboral.Compania == null)
                                {
                                    string logMesagge = "Fallo la actualizacion de Puesto del empleado: " + NumEmpleado;
                                    Log.LogService.Log(logMesagge);
                                    throw new Exception(logMesagge);
                                }
                                else
                                {
                                    Log.LogService.Log("Actualizacion de Puesto exitosa del empleado: " + NumEmpleado);
                                }

                                //Se cambia el UCos
                                objH_Valores_X_EmpUCos = CambioUnidadCostos(objH_Valores_X_EmpUCos, objEmpleadoQP);

                                if (objH_Valores_X_EmpUCos.Compania == null)
                                {
                                    string logMesagge = "Fallo la actualizacion de Unidad de Costos del empleado: " + NumEmpleado;
                                    Log.LogService.Log(logMesagge);
                                    throw new Exception(logMesagge);
                                }
                                else
                                {
                                    Log.LogService.Log("Actualizacion de Unidad de Costos exitosa del empleado: " + NumEmpleado);
                                }

                                //Se llena el objeto de salida con los atributos que se cambiaron
                                objEmpleadoQP = new Entities.QProcess.Empleados.Movimientos();
                                objEmpleadoQP.Compania = objH_Laboral.Compania;
                                objEmpleadoQP.Empleado = objH_Laboral.numEmpleado;
                                objEmpleadoQP.CompaniaPasajes = objH_Laboral.companiaPasajes;
                                objEmpleadoQP.Accion = objH_Laboral.Accion;
                                objEmpleadoQP.Motivo = objH_Laboral.Motivo;
                                objEmpleadoQP.PuestoNuevo = objH_Laboral.Puesto;
                                objEmpleadoQP.ClaveUCoNueva = objH_Valores_X_EmpUCos.Valor;

                                break;

                            case (int)Entities.Kaizen.Enum.TipoCambio.CentroCostosUnidadCostos://CECO, UCOS

                                //Se cambia el Ceco
                                objH_Valores_X_EmpCeco = CambioCentroCostos(objH_Valores_X_EmpCeco, objEmpleadoQP);

                                if (objH_Valores_X_EmpCeco.Compania == null)
                                {
                                    string logMesagge = "Fallo la actualizacion de Centro de Costos del empleado: " + NumEmpleado;
                                    Log.LogService.Log(logMesagge);
                                    throw new Exception(logMesagge);
                                }
                                else
                                {
                                    Log.LogService.Log("Actualizacion de Centro de Costos exitosa del empleado: " + NumEmpleado);
                                }

                                //Se cambia el UCos
                                objH_Valores_X_EmpUCos = CambioUnidadCostos(objH_Valores_X_EmpUCos, objEmpleadoQP);

                                if (objH_Valores_X_EmpUCos.Compania == null)
                                {
                                    string logMesagge = "Fallo la actualizacion de Unidad de Costos del empleado: " + NumEmpleado;
                                    Log.LogService.Log(logMesagge);
                                    throw new Exception(logMesagge);
                                }
                                else
                                {
                                    Log.LogService.Log("Actualizacion de Unidad de Costos exitosa del empleado: " + NumEmpleado);
                                }

                                //Se llena el objeto de salida con los atributos que se cambiaron
                                objEmpleadoQP = new Entities.QProcess.Empleados.Movimientos();
                                objEmpleadoQP.Compania = objH_Valores_X_EmpCeco.Compania;
                                objEmpleadoQP.Empleado = objH_Valores_X_EmpCeco.numEmpleado;
                                objEmpleadoQP.CompaniaPasajes = objH_Valores_X_EmpCeco.companiaPasajes;
                                objEmpleadoQP.ClaveUCoNueva = objH_Valores_X_EmpUCos.Valor;
                                objEmpleadoQP.CentroCostoNuevo = objH_Valores_X_EmpCeco.Valor;

                                break;

                            case (int)Entities.Kaizen.Enum.TipoCambio.PuestoCentroCostosUnidadCostos://PUESTO, CECO, UCOS

                                //Se cambia el Puesto
                                objH_Laboral = CambioPuesto(objH_Laboral, objEmpleadoQP);

                                if (objH_Laboral.Compania == null)
                                {
                                    string logMesagge = "Fallo la actualizacion de Puesto del empleado: " + NumEmpleado;
                                    Log.LogService.Log(logMesagge);
                                    throw new Exception(logMesagge);
                                }
                                else
                                {
                                    Log.LogService.Log("Actualizacion de Puesto exitosa del empleado: " + NumEmpleado);
                                }

                                //Se cambia el Ceco
                                objH_Valores_X_EmpCeco = CambioCentroCostos(objH_Valores_X_EmpCeco, objEmpleadoQP);

                                if (objH_Valores_X_EmpCeco.Compania == null)
                                {
                                    string logMesagge = "Fallo la actualizacion de Centro de Costos del empleado: " + NumEmpleado;
                                    Log.LogService.Log(logMesagge);
                                    throw new Exception(logMesagge);
                                }
                                else
                                {
                                    Log.LogService.Log("Actualizacion de Centro de Costos exitosa del empleado: " + NumEmpleado);
                                }

                                //Se cambia el UCos
                                objH_Valores_X_EmpUCos = CambioUnidadCostos(objH_Valores_X_EmpUCos, objEmpleadoQP);

                                if (objH_Valores_X_EmpUCos.Compania == null)
                                {
                                    string logMesagge = "Fallo la actualizacion de Unidad de Costos del empleado: " + NumEmpleado;
                                    Log.LogService.Log(logMesagge);
                                    throw new Exception(logMesagge);
                                }
                                else
                                {
                                    Log.LogService.Log("Actualizacion de Unidad de Costos exitosa del empleado: " + NumEmpleado);
                                }

                                //Se llena el objeto de salida con los atributos que se cambiaron
                                objEmpleadoQP = new Entities.QProcess.Empleados.Movimientos();
                                objEmpleadoQP.Compania = objH_Laboral.Compania;
                                objEmpleadoQP.Empleado = objH_Laboral.numEmpleado;
                                objEmpleadoQP.CompaniaPasajes = objEmpleadoQPInicial.CompaniaPasajes;
                                objEmpleadoQP.Accion = objH_Laboral.Accion;
                                objEmpleadoQP.Motivo = objH_Laboral.Motivo;
                                objEmpleadoQP.PuestoNuevo = objH_Laboral.Puesto;
                                objEmpleadoQP.ClaveUCoNueva = objH_Valores_X_EmpUCos.Valor;
                                objEmpleadoQP.CentroCostoNuevo = objH_Valores_X_EmpCeco.Valor;

                                break;

                        }

                        break;

                    case (int)Entities.Kaizen.Enum.TipoMovimiento.BajaEmpleado://Baja Kaizen

                        objEmpleadoKaizenInicial = Business.Kaizen.Empleados.Empleado.GetOne(objEmpleadoQP.Compania, objEmpleadoQP.Empleado);

                        objEmpleadoKaizen = Business.Kaizen.Empleados.Empleado.BajaEmpleado(objEmpleadoQP.Compania, objEmpleadoQP.Empleado, objEmpleadoQP.Motivo);

                        if (!objEmpleadoKaizen.estatus.Equals("99"))
                        {
                            string logMesagge = "Error en proceso de Baja de Empleado no se pudo cambiar su estatus en Kaizen del empleado: " + NumEmpleado;
                            Log.LogService.Log(logMesagge);
                            throw new Exception(logMesagge);
                        }
                        else
                        {
                            Log.LogService.Log("El estatus del empleado " + NumEmpleado + " se actualizo correctamente");
                        }

                        break;

                }

                //Se cambia EstatusProceso en QProcess
                switch (objEmpleadoQPInicial.idCatTipoMovimiento)
                {
                    case (int)Entities.Kaizen.Enum.TipoMovimiento.CambioSueldo:

                        if (!objH_Sueldos.Fecha.Equals(default(DateTime)))
                        {
                            objEmpleadoMovimientosQP = dataEmpleadoQP.UpdateEstatusProcesoMovimiento(NumEmpleado, IdRequisicionMovimiento, (int)Entities.Kaizen.Enum.EstatusProceso.Kaizen);

                            if (!objEmpleadoMovimientosQP.EstatusProceso.Equals((int)Entities.Kaizen.Enum.EstatusProceso.Kaizen))
                            {
                                string logMesagge = "Error en la actualización de Estatus Proceso Movimiento del empleado: " + NumEmpleado;
                                Log.LogService.Log(logMesagge);
                                throw new Exception(logMesagge);
                            }
                            else
                            {
                                Log.LogService.Log("Actualizacion de Estatus Proceso Movimiento exitosa del empleado: " + NumEmpleado);
                            }
                        }

                        break;

                    case (int)Entities.Kaizen.Enum.TipoMovimiento.CambioSituacionLaboral:

                        objEmpleadoMovimientosQP = dataEmpleadoQP.UpdateEstatusProcesoMovimiento(NumEmpleado, IdRequisicionMovimiento, (int)Entities.Kaizen.Enum.EstatusProceso.Kaizen);

                        if (!objEmpleadoMovimientosQP.EstatusProceso.Equals((int)Entities.Kaizen.Enum.EstatusProceso.Kaizen))
                        {
                            string logMesagge = "Error en la actualización de Estatus Proceso Movimiento del empleado: " + NumEmpleado;
                            Log.LogService.Log(logMesagge);
                            throw new Exception(logMesagge);
                        }
                        else
                        {
                            Log.LogService.Log("Actualizacion de Estatus Proceso Movimiento exitosa del empleado: " + NumEmpleado);
                        }

                        break;


                    case (int)Entities.Kaizen.Enum.TipoMovimiento.BajaEmpleado:

                        if (objEmpleadoKaizen.estatus.Equals("99"))
                        {
                            objEmpleadoQP = dataEmpleadoQP.UpdateEstatusProcesoMovimiento(objEmpleadoQP.Compania + objEmpleadoQP.Empleado, objEmpleadoQP.idRequisicionMovimiento, (int)Entities.Kaizen.Enum.EstatusProceso.Kaizen);

                            if (!objEmpleadoQP.EstatusProceso.Equals((int)Entities.Kaizen.Enum.EstatusProceso.Kaizen))
                            {
                                string logMesagge = "Error al actualizar el 'Estatus Proceso Movimiento' al terminar el proceso de baja en Integra del empleado: " + NumEmpleado;
                                Log.LogService.Log(logMesagge);
                                throw new Exception(logMesagge);
                            }
                            else
                            {
                                Log.LogService.Log("Actualizacion de Estatus Proceso Movimiento exitosa del empleado: " + NumEmpleado);
                            }
                        }

                        break;

                }

                return objEmpleadoQP;

            }

            catch (Exception ex)
            {
                switch (objEmpleadoQPInicial.idCatTipoMovimiento)
                {
                    case (int)Entities.Kaizen.Enum.TipoMovimiento.CambioSueldo://Cambio de Sueldo

                        switch (objEmpleadoQPInicial.IdCambio)
                        {
                            case (int)Entities.Kaizen.Enum.TipoCambio.Sueldo://Sueldo

                                if (!objH_Sueldos.Fecha.Equals(default(DateTime)))
                                {
                                    bool resultDropLastH_Sueldos = false;
                                    objH_Sueldos.companiaPasajes = "";
                                    resultDropLastH_Sueldos = Business.Kaizen.Empleados.H_Sueldos.DropLast(objH_Sueldos);

                                    if (resultDropLastH_Sueldos == false)
                                    {
                                        string logMesagge = "Rollback: El " + objH_Sueldos.Tipo_Sueldo + " de la compañia " + objEmpleadoQP.Compania + " empleado " + objEmpleadoQP.Empleado + " no fue borrado";
                                        Log.LogService.Log(logMesagge);
                                        throw new Exception(logMesagge);
                                    }
                                    else
                                    {
                                        Log.LogService.Log("Rollback: El " + objH_Sueldos.Tipo_Sueldo + " de la compañia " + objEmpleadoQP.Compania + " empleado " + objEmpleadoQP.Empleado + " fue borrado correctamente");
                                    }
                                }

                                break;

                            case (int)Entities.Kaizen.Enum.TipoCambio.PuestoSueldo://Puesto, Sueldo

                                if (!objH_Laboral.Puesto.Equals("") && !objH_Laboral.Puesto.Equals(null))
                                {
                                    Business.Kaizen.Empleados.H_Laboral.DropLast(objH_Laboral);
                                }

                                if (!objH_Sueldos.Fecha.Equals(default(DateTime)))
                                {
                                    objH_Sueldos.companiaPasajes = objEmpleadoQPInicial.CompaniaPasajes;
                                    Business.Kaizen.Empleados.H_Sueldos.DropLast(objH_Sueldos);
                                }

                                break;

                            case (int)Entities.Kaizen.Enum.TipoCambio.CentroCostosSueldo://CeCo, Sueldo

                                if (!objH_Valores_X_EmpCeco.Valor.Equals(null))
                                {
                                    objH_Valores_X_EmpCeco.companiaPasajes = objEmpleadoQPInicial.CompaniaPasajes;
                                    Business.Kaizen.Empleados.H_Valores_X_Emp.DropLast(objH_Valores_X_EmpCeco);
                                }

                                if (!objH_Sueldos.Fecha.Equals(default(DateTime)))
                                {
                                    objH_Sueldos.companiaPasajes = objEmpleadoQPInicial.CompaniaPasajes;
                                    Business.Kaizen.Empleados.H_Sueldos.DropLast(objH_Sueldos);
                                }

                                break;

                            case (int)Entities.Kaizen.Enum.TipoCambio.UnidadCostosSueldo://UCOS, SUELDO

                                if (!objH_Valores_X_EmpUCos.Valor.Equals(null))
                                {
                                    objH_Valores_X_EmpUCos.companiaPasajes = objEmpleadoQPInicial.CompaniaPasajes;
                                    Business.Kaizen.Empleados.H_Valores_X_Emp.DropLast(objH_Valores_X_EmpUCos);
                                }

                                if (!objH_Sueldos.Fecha.Equals(default(DateTime)))
                                {
                                    objH_Sueldos.companiaPasajes = objEmpleadoQPInicial.CompaniaPasajes;
                                    Business.Kaizen.Empleados.H_Sueldos.DropLast(objH_Sueldos);
                                }

                                break;

                            case (int)Entities.Kaizen.Enum.TipoCambio.PuestoCentroCostosSueldo://PUESTO, CECO, SUELDO

                                if (!objH_Laboral.Puesto.Equals("") && !objH_Laboral.Puesto.Equals(null))
                                {
                                    Business.Kaizen.Empleados.H_Laboral.DropLast(objH_Laboral);
                                }

                                if (!objH_Valores_X_EmpCeco.Valor.Equals(null))
                                {
                                    objH_Valores_X_EmpCeco.companiaPasajes = objEmpleadoQPInicial.CompaniaPasajes;
                                    Business.Kaizen.Empleados.H_Valores_X_Emp.DropLast(objH_Valores_X_EmpCeco);
                                }

                                if (!objH_Sueldos.Fecha.Equals(default(DateTime)))
                                {
                                    objH_Sueldos.companiaPasajes = objEmpleadoQPInicial.CompaniaPasajes;
                                    Business.Kaizen.Empleados.H_Sueldos.DropLast(objH_Sueldos);
                                }

                                break;

                            case (int)Entities.Kaizen.Enum.TipoCambio.PuestoUnidadCostosSueldo://PUESTO, UCOS, SUELDO

                                if (!objH_Laboral.Puesto.Equals("") && !objH_Laboral.Puesto.Equals(null))
                                {
                                    Business.Kaizen.Empleados.H_Laboral.DropLast(objH_Laboral);
                                }

                                if (objH_Valores_X_EmpUCos.Valor != null)
                                {
                                    objH_Valores_X_EmpUCos.companiaPasajes = objEmpleadoQPInicial.CompaniaPasajes;
                                    Business.Kaizen.Empleados.H_Valores_X_Emp.DropLast(objH_Valores_X_EmpUCos);
                                }

                                if (objH_Sueldos.Fecha != (default(DateTime)))
                                {
                                    objH_Sueldos.companiaPasajes = objEmpleadoQPInicial.CompaniaPasajes;
                                    Business.Kaizen.Empleados.H_Sueldos.DropLast(objH_Sueldos);
                                }

                                break;

                            case (int)Entities.Kaizen.Enum.TipoCambio.CentroCostosUnidadCostosSueldo://CECO, UCOS, SUELDO

                                if (!objH_Valores_X_EmpCeco.Valor.Equals(null))
                                {
                                    objH_Valores_X_EmpCeco.companiaPasajes = objEmpleadoQPInicial.CompaniaPasajes;
                                    Business.Kaizen.Empleados.H_Valores_X_Emp.DropLast(objH_Valores_X_EmpCeco);
                                }

                                if (!objH_Valores_X_EmpUCos.Valor.Equals(null))
                                {
                                    objH_Valores_X_EmpUCos.companiaPasajes = objEmpleadoQPInicial.CompaniaPasajes;
                                    Business.Kaizen.Empleados.H_Valores_X_Emp.DropLast(objH_Valores_X_EmpUCos);
                                }

                                if (!objH_Sueldos.Fecha.Equals(default(DateTime)))
                                {
                                    objH_Sueldos.companiaPasajes = objEmpleadoQPInicial.CompaniaPasajes;
                                    Business.Kaizen.Empleados.H_Sueldos.DropLast(objH_Sueldos);
                                }

                                break;

                            case (int)Entities.Kaizen.Enum.TipoCambio.Todos://TODOS

                                if (!objH_Laboral.Puesto.Equals("") && !objH_Laboral.Puesto.Equals(null))
                                {
                                    Business.Kaizen.Empleados.H_Laboral.DropLast(objH_Laboral);
                                }

                                if (!objH_Valores_X_EmpCeco.Valor.Equals(null))
                                {
                                    objH_Valores_X_EmpCeco.companiaPasajes = objEmpleadoQPInicial.CompaniaPasajes;
                                    Business.Kaizen.Empleados.H_Valores_X_Emp.DropLast(objH_Valores_X_EmpCeco);
                                }

                                if (!objH_Valores_X_EmpUCos.Valor.Equals(null))
                                {
                                    objH_Valores_X_EmpUCos.companiaPasajes = objEmpleadoQPInicial.CompaniaPasajes;
                                    Business.Kaizen.Empleados.H_Valores_X_Emp.DropLast(objH_Valores_X_EmpUCos);
                                }

                                if (!objH_Sueldos.Fecha.Equals(default(DateTime)))
                                {
                                    objH_Sueldos.companiaPasajes = objEmpleadoQPInicial.CompaniaPasajes;
                                    Business.Kaizen.Empleados.H_Sueldos.DropLast(objH_Sueldos);
                                }

                                break;
                        }

                        break;

                    case (int)Entities.Kaizen.Enum.TipoMovimiento.CambioSituacionLaboral://Cambios de situacion laboral
                        switch (objEmpleadoQPInicial.IdCambio)
                        {
                            case (int)Entities.Kaizen.Enum.TipoCambio.Puesto://PUESTO

                                if (!objH_Laboral.Puesto.Equals("") && !objH_Laboral.Puesto.Equals(null))
                                {
                                    Business.Kaizen.Empleados.H_Laboral.DropLast(objH_Laboral);
                                }

                                break;

                            case (int)Entities.Kaizen.Enum.TipoCambio.CentroCostos://CECO

                                if (!objH_Valores_X_EmpCeco.Valor.Equals(null))
                                {
                                    objH_Valores_X_EmpCeco.companiaPasajes = objEmpleadoQPInicial.CompaniaPasajes;
                                    Business.Kaizen.Empleados.H_Valores_X_Emp.DropLast(objH_Valores_X_EmpCeco);
                                }

                                break;

                            case (int)Entities.Kaizen.Enum.TipoCambio.UnidadCostos://UCOS

                                if (!objH_Valores_X_EmpUCos.Valor.Equals(null))
                                {
                                    objH_Valores_X_EmpUCos.companiaPasajes = objEmpleadoQPInicial.CompaniaPasajes;
                                    Business.Kaizen.Empleados.H_Valores_X_Emp.DropLast(objH_Valores_X_EmpUCos);
                                }

                                break;

                            case (int)Entities.Kaizen.Enum.TipoCambio.PuestoCentroCostos://PUESTO, CECO

                                if (!objH_Laboral.Puesto.Equals("") && !objH_Laboral.Puesto.Equals(null))
                                {
                                    Business.Kaizen.Empleados.H_Laboral.DropLast(objH_Laboral);
                                }

                                if (!objH_Valores_X_EmpCeco.Valor.Equals(null))
                                {
                                    objH_Valores_X_EmpCeco.companiaPasajes = objEmpleadoQPInicial.CompaniaPasajes;
                                    Business.Kaizen.Empleados.H_Valores_X_Emp.DropLast(objH_Valores_X_EmpCeco);
                                }

                                break;

                            case (int)Entities.Kaizen.Enum.TipoCambio.PuestoUnidadCostos://PUESTO, UCOS

                                if (!objH_Laboral.Puesto.Equals("") && !objH_Laboral.Puesto.Equals(null))
                                {
                                    Business.Kaizen.Empleados.H_Laboral.DropLast(objH_Laboral);
                                }

                                if (!objH_Valores_X_EmpUCos.Valor.Equals(null))
                                {
                                    objH_Valores_X_EmpUCos.companiaPasajes = objEmpleadoQPInicial.CompaniaPasajes;
                                    Business.Kaizen.Empleados.H_Valores_X_Emp.DropLast(objH_Valores_X_EmpUCos);
                                }

                                break;

                            case (int)Entities.Kaizen.Enum.TipoCambio.CentroCostosUnidadCostos://CECO, UCOS

                                if (!objH_Valores_X_EmpCeco.Valor.Equals(null))
                                {
                                    objH_Valores_X_EmpCeco.companiaPasajes = objEmpleadoQPInicial.CompaniaPasajes;
                                    Business.Kaizen.Empleados.H_Valores_X_Emp.DropLast(objH_Valores_X_EmpCeco);
                                }

                                if (!objH_Valores_X_EmpUCos.Valor.Equals(null))
                                {
                                    objH_Valores_X_EmpUCos.companiaPasajes = objEmpleadoQPInicial.CompaniaPasajes;
                                    Business.Kaizen.Empleados.H_Valores_X_Emp.DropLast(objH_Valores_X_EmpUCos);
                                }

                                break;

                            case (int)Entities.Kaizen.Enum.TipoCambio.PuestoCentroCostosUnidadCostos://PUESTO, CECO, UCOS

                                if (!objH_Laboral.Puesto.Equals("") && !objH_Laboral.Puesto.Equals(null))
                                {
                                    Business.Kaizen.Empleados.H_Laboral.DropLast(objH_Laboral);
                                }

                                if (!objH_Valores_X_EmpCeco.Valor.Equals(null))
                                {
                                    objH_Valores_X_EmpCeco.companiaPasajes = objEmpleadoQPInicial.CompaniaPasajes;
                                    Business.Kaizen.Empleados.H_Valores_X_Emp.DropLast(objH_Valores_X_EmpCeco);
                                }

                                if (!objH_Valores_X_EmpUCos.Valor.Equals(null))
                                {
                                    objH_Valores_X_EmpUCos.companiaPasajes = objEmpleadoQPInicial.CompaniaPasajes;
                                    Business.Kaizen.Empleados.H_Valores_X_Emp.DropLast(objH_Valores_X_EmpUCos);
                                }

                                break;

                        }

                        break;

                    case (int)Entities.Kaizen.Enum.TipoMovimiento.BajaEmpleado:

                        objH_LaboralInicial = new Entities.Kaizen.Empleados.H_Laboral();
                        objH_LaboralInicial.Compania = objEmpleadoQPInicial.Compania;
                        objH_LaboralInicial.companiaPasajes = objEmpleadoQPInicial.CompaniaPasajes;
                        objH_LaboralInicial.numEmpleado = objEmpleadoQPInicial.Empleado;
                        Business.Kaizen.Empleados.H_Laboral.DropLast(objH_LaboralInicial);

                        objEmpleadoKaizenInicial.companiaPasajes = objEmpleadoQP.CompaniaPasajes;
                        Business.Kaizen.Empleados.Empleado.Rollback(objEmpleadoKaizenInicial, (int)Entities.Kaizen.Enum.TipoRollback.Bajas);

                        break;

                }

                switch (objEmpleadoQPInicial.idCatTipoMovimiento)
                {
                    case (int)Entities.Kaizen.Enum.TipoMovimiento.CambioSueldo:

                        switch (objEmpleadoQPInicial.IdCambio)
                        {
                            case (int)Entities.Kaizen.Enum.TipoCambio.Sueldo:

                                if (objEmpleadoMovimientosQP.EstatusProceso.Equals((int)Entities.Kaizen.Enum.EstatusProceso.Kaizen))
                                {
                                    objEmpleadoQP = dataEmpleadoQP.UpdateEstatusProcesoMovimiento(NumEmpleado, IdRequisicionMovimiento, (int)Entities.Kaizen.Enum.EstatusProceso.QProcess);
                                }

                                if (objEmpleadoMovimientosQP.EstatusProceso.Equals((int)Entities.Kaizen.Enum.EstatusProceso.QProcess))
                                {
                                    throw new Exception("Rollback: El campo 'Estatus Proceso Movimiento' del empleado:" + NumEmpleado + " no se regreso a su punto de origen");
                                }
                                else
                                {
                                    Log.LogService.Log("Rollback: El campo 'Estatus Proceso Movimiento' del empleado:" + NumEmpleado + " se regreso a su punto de origen correctamente");
                                }


                                break;

                            default:

                                objEmpleadoQP = dataEmpleadoQP.UpdateEstatusProcesoMovimiento(NumEmpleado, IdRequisicionMovimiento, (int)Entities.Kaizen.Enum.EstatusProceso.Soluglob);

                                break;
                        }


                        break;

                    default:

                        objEmpleadoQP = dataEmpleadoQP.UpdateEstatusProcesoMovimiento(NumEmpleado, IdRequisicionMovimiento, (int)Entities.Kaizen.Enum.EstatusProceso.Soluglob);

                        break;

                }

                throw ex;
            }

        }

        public static Entities.Kaizen.Empleados.H_Sueldos CambioSueldo(Entities.Kaizen.Empleados.H_Sueldos objH_Sueldos, Entities.QProcess.Empleados.Movimientos objEmpleadoQP)
        {
            objH_Sueldos = new Entities.Kaizen.Empleados.H_Sueldos();
            objH_Sueldos.Compania = objEmpleadoQP.Compania;
            objH_Sueldos.numEmpleado = objEmpleadoQP.Empleado;
            objH_Sueldos.companiaPasajes = objEmpleadoQP.CompaniaPasajes;
            objH_Sueldos.Tipo_Sueldo = "SM";
            objH_Sueldos.Sueldo = objEmpleadoQP.SueldoNuevo;
            objH_Sueldos.Usuario = "LOMAS VERDES";
            objH_Sueldos.Ip = null;
            objH_Sueldos.Mac_Address = null;
            objH_Sueldos = Business.Kaizen.Empleados.H_Sueldos.Insert(objH_Sueldos);

            return objH_Sueldos;
        }

        public static Entities.Kaizen.Empleados.H_Laboral CambioPuesto(Entities.Kaizen.Empleados.H_Laboral objH_Laboral, Entities.QProcess.Empleados.Movimientos objEmpleadoQP)
        {
            objH_Laboral = new Entities.Kaizen.Empleados.H_Laboral();
            objH_Laboral.Compania = objEmpleadoQP.Compania;
            objH_Laboral.numEmpleado = objEmpleadoQP.Empleado;
            objH_Laboral.companiaPasajes = objEmpleadoQP.CompaniaPasajes;
            objH_Laboral.Accion = objEmpleadoQP.Accion;
            objH_Laboral.Motivo = objEmpleadoQP.Motivo;
            objH_Laboral.Puesto = objEmpleadoQP.PuestoNuevo;
            objH_Laboral = Business.Kaizen.Empleados.H_Laboral.UpdatePuesto(objH_Laboral);

            return objH_Laboral;
        }

        public static Entities.Kaizen.Empleados.H_Valores_X_Emp CambioCentroCostos(Entities.Kaizen.Empleados.H_Valores_X_Emp objH_Valores_X_EmpCeco, Entities.QProcess.Empleados.Movimientos objEmpleadoQP)
        {
            objH_Valores_X_EmpCeco = new Entities.Kaizen.Empleados.H_Valores_X_Emp();
            objH_Valores_X_EmpCeco.Compania = objEmpleadoQP.Compania;
            objH_Valores_X_EmpCeco.numEmpleado = objEmpleadoQP.Empleado;
            objH_Valores_X_EmpCeco.companiaPasajes = objEmpleadoQP.CompaniaPasajes;
            objH_Valores_X_EmpCeco.Valor = objEmpleadoQP.CentroCostoNuevo;
            objH_Valores_X_EmpCeco = Business.Kaizen.Empleados.H_Valores_X_Emp.UpdateCeco(objH_Valores_X_EmpCeco);

            return objH_Valores_X_EmpCeco;
        }

        public static Entities.Kaizen.Empleados.H_Valores_X_Emp CambioUnidadCostos(Entities.Kaizen.Empleados.H_Valores_X_Emp objH_Valores_X_EmpUCos, Entities.QProcess.Empleados.Movimientos objEmpleadoQP)
        {
            objH_Valores_X_EmpUCos = new Entities.Kaizen.Empleados.H_Valores_X_Emp();
            objH_Valores_X_EmpUCos.Compania = objEmpleadoQP.Compania;
            objH_Valores_X_EmpUCos.numEmpleado = objEmpleadoQP.Empleado;
            objH_Valores_X_EmpUCos.companiaPasajes = objEmpleadoQP.CompaniaPasajes;
            objH_Valores_X_EmpUCos.Valor = objEmpleadoQP.ClaveUCoNueva;
            objH_Valores_X_EmpUCos = Business.Kaizen.Empleados.H_Valores_X_Emp.UpdateUCo(objH_Valores_X_EmpUCos);

            return objH_Valores_X_EmpUCos;
        }

        //public static Entities.Kaizen.Empleados.Empleado BajaEmpleadoKaizen(string Compania, string NumEmpleado, string Motivo, int RequisicionMovimiento)
        //{
        //    Entities.Kaizen.Empleados.Empleado objEmpleado = new Entities.Kaizen.Empleados.Empleado();
        //    Entities.QProcess.Empleados.Movimientos objEmpleadoQP = new Entities.QProcess.Empleados.Movimientos();

        //    Data.QProcess.Empleado dataEmpleadoQP = new Data.QProcess.Empleado();

        //    try
        //    {
        //        objEmpleado = Business.Kaizen.Empleados.Empleado.BajaEmpleado(Compania, NumEmpleado, Motivo);

        //        if (objEmpleado.estatus == "99")
        //        {
        //            objEmpleadoQP = dataEmpleadoQP.UpdateEstatusProcesoMovimiento(Compania + NumEmpleado, RequisicionMovimiento, 2);

        //            if (objEmpleadoQP.EstatusProceso != 2)
        //            {
        //                throw new Exception("Error al actualizar el 'Estatus Proceso' al terminar el proceso de baja en Integra. El valor del campo 'Estatus Proceso' es " + objEmpleadoQP.EstatusProceso);
        //            }
        //        }

        //        return objEmpleado;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message.ToString());
        //    }

        //}

        //public static Entities.SoluglobAdministrativo.Personal BajaEmpleadoSG(string NumEmpleado, int RequisicionMovimiento)
        //{
        //    Entities.SoluglobAdministrativo.Personal objPersonal = new Entities.SoluglobAdministrativo.Personal();
        //    Entities.QProcess.Empleados.Movimientos objEmpleadoQP = new Entities.QProcess.Empleados.Movimientos();

        //    Data.QProcess.Empleado dataEmpleadoQP = new Data.QProcess.Empleado();

        //    try
        //    {
        //        objPersonal = Business.SoluglobAdministrativo.Personal.BajaEmpleado(Convert.ToInt32(NumEmpleado));

        //        if (objPersonal.Estatus == -1)
        //        {
        //            objEmpleadoQP = dataEmpleadoQP.UpdateEstatusProcesoMovimiento(NumEmpleado, RequisicionMovimiento, 1);

        //            if (objEmpleadoQP.EstatusProceso != 1)
        //            {
        //                throw new Exception("Error al actualizar el 'Estatus Proceso' al terminar el proceso de baja en Soluglob. El valor del campo 'Estatus Proceso' es " + objEmpleadoQP.EstatusProceso);
        //            }
        //        }

        //        return objPersonal;
        //    }
        //    catch (Exception ex)
        //    {

        //        throw new Exception(ex.Message.ToString()); ;
        //    }

        //}

        //public static Entities.QProcess.Empleados.AltaSoluglob GetOneByNumChecador(int numEmpleado)
        //{
        //    Entities.QProcess.Empleados.AltaSoluglob objEmpleadoQP = new Entities.QProcess.Empleados.AltaSoluglob();
        //    Entities.SoluglobAdministrativo.Personal objEmpleadoPersonal = new Entities.SoluglobAdministrativo.Personal();
        //    Entities.SoluglobAdministrativo.Vacantes objEmpleadoVacantes = new Entities.SoluglobAdministrativo.Vacantes();
        //    Entities.SoluglobChecador.Usuarios objEmpleadoUsuarios = new Entities.SoluglobChecador.Usuarios();

        //    Data.QProcess.Empleado dataEmpleadoQP = new Data.QProcess.Empleado();

        //    try
        //    {
        //        objEmpleadoPersonal = Business.SoluglobAdministrativo.Personal.GetOneByNumeroChecador(numEmpleado);
        //        objEmpleadoQP.Numero_Nominas = objEmpleadoPersonal.Num_Checador;
        //        objEmpleadoQP.Nombre = objEmpleadoPersonal.Nombre;
        //        objEmpleadoQP.Sueldo = objEmpleadoPersonal.Sueldo;
        //        objEmpleadoQP.Fechas_registro = objEmpleadoPersonal.FecReg;

        //        objEmpleadoUsuarios = Business.SoluglobChecador.Usuarios.GetOneByNumeroNominas(numEmpleado);
        //        objEmpleadoQP.Empresa = objEmpleadoUsuarios.Empresa;
        //        objEmpleadoQP.Puesto = objEmpleadoUsuarios.Puesto;
        //        objEmpleadoQP.Ubicacion_usuarios = objEmpleadoUsuarios.Ubicacion;
        //        objEmpleadoQP.Bono = objEmpleadoUsuarios.Bono;

        //        objEmpleadoVacantes = Business.SoluglobAdministrativo.Vacantes.GetOneByIdPer(objEmpleadoPersonal.Id_Per);
        //        objEmpleadoQP.idCatPuesto = Convert.ToInt32(objEmpleadoVacantes.Puesto);
        //        objEmpleadoQP.CeCo = objEmpleadoVacantes.CeCo;
        //        objEmpleadoQP.UCos = objEmpleadoVacantes.UCos;

        //        objEmpleadoQP = dataEmpleadoQP.MovimientosInsert(objEmpleadoQP);

        //        return objEmpleadoQP;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message.ToString()); ;
        //    }
        //}        

    }
}
