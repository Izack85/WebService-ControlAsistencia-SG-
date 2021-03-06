﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integra.Services.Data.QProcess
{
    public class Empleado
    {
        //List<Entities.QProcess.Empleado> empleadoCollection = null;
        Entities.QProcess.Empleados.AltaKaizen empleado = null;
        SqlDataReader dataReader = null;

        public Connection connection = null;

        public Empleado()
        {
            this.connection = Connection.Instance;
        }

        public Empleado(bool isTransaction)
        {
            this.connection = new Connection();
        }

        public Empleado(Connection connection)
        {
            this.connection = connection;
        }        

        public Entities.QProcess.Empleados.AltaKaizen GetLayoutKaizen(int idLayout)
        {
            empleado = new Entities.QProcess.Empleados.AltaKaizen();

            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter() { ParameterName = "NumeroEmpleado", Value = idLayout });

                using (dataReader = this.connection.ExcuteSP("prc_GetLayoutKaizen", parameters))
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            //Generales
                            empleado.Compania = dataReader.IsDBNull(dataReader.GetOrdinal("Compania")) ? null : dataReader["Compania"].ToString();
                            empleado.CompaniaPasajes = dataReader.IsDBNull(dataReader.GetOrdinal("CompaniaPasajes")) ? null : dataReader["CompaniaPasajes"].ToString();
                            empleado.numEmpleado = dataReader.IsDBNull(dataReader.GetOrdinal("NumeroEmpleado")) ? null : dataReader["NumeroEmpleado"].ToString();
                            empleado.Usuario = dataReader.IsDBNull(dataReader.GetOrdinal("Usuario")) ? null : dataReader["Usuario"].ToString();
                            empleado.Fecha = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha")) ? default(DateTime) : DateTime.Parse(dataReader["Fecha"].ToString());
                            empleado.Ip = dataReader.IsDBNull(dataReader.GetOrdinal("Ip")) ? null : dataReader["Ip"].ToString();
                            empleado.Mac_Address = dataReader.IsDBNull(dataReader.GetOrdinal("Mac_Address")) ? null : dataReader["Mac_Address"].ToString();

                            //Empleados                           
                            empleado.ApellidoPat = dataReader.IsDBNull(dataReader.GetOrdinal("ApellidoPat")) ? null : dataReader["ApellidoPat"].ToString();
                            empleado.ApellidoMat = dataReader.IsDBNull(dataReader.GetOrdinal("ApellidoMat")) ? null : dataReader["ApellidoMat"].ToString();
                            empleado.Nombres = dataReader.IsDBNull(dataReader.GetOrdinal("Nombres")) ? null : dataReader["Nombres"].ToString();
                            empleado.Nombre = dataReader.IsDBNull(dataReader.GetOrdinal("Nombre")) ? null : dataReader["Nombre"].ToString();
                            empleado.Path_Foto = dataReader.IsDBNull(dataReader.GetOrdinal("Path_Foto")) ? null : dataReader["Path_Foto"].ToString();
                            empleado.RFC = dataReader.IsDBNull(dataReader.GetOrdinal("RFC")) ? null : dataReader["RFC"].ToString();
                            empleado.CURP = dataReader.IsDBNull(dataReader.GetOrdinal("CURP")) ? null : dataReader["CURP"].ToString();
                            empleado.Elector = dataReader.IsDBNull(dataReader.GetOrdinal("Elector")) ? null : dataReader["Elector"].ToString();
                            empleado.Cartilla = dataReader.IsDBNull(dataReader.GetOrdinal("Cartilla")) ? null : dataReader["Cartilla"].ToString();
                            empleado.Licencia = dataReader.IsDBNull(dataReader.GetOrdinal("Licencia")) ? null : dataReader["Licencia"].ToString();
                            empleado.NSS = dataReader.IsDBNull(dataReader.GetOrdinal("NSS")) ? null : dataReader["NSS"].ToString();
                            empleado.TipoSangre = dataReader.IsDBNull(dataReader.GetOrdinal("TipoSangre")) ? null : dataReader["TipoSangre"].ToString();
                            empleado.Sexo = dataReader.IsDBNull(dataReader.GetOrdinal("Sexo")) ? default(Int16?) : Int16.Parse(dataReader["Sexo"].ToString());
                            empleado.Tratamiento = dataReader.IsDBNull(dataReader.GetOrdinal("Tratamiento")) ? null : dataReader["Tratamiento"].ToString();
                            empleado.NivelEstudio = dataReader.IsDBNull(dataReader.GetOrdinal("NivelEstudio")) ? null : dataReader["NivelEstudio"].ToString();
                            empleado.FechaNacimiento = dataReader.IsDBNull(dataReader.GetOrdinal("FechaNacimiento")) ? default(DateTime?) : DateTime.Parse(dataReader["FechaNacimiento"].ToString());
                            empleado.Lugar_Nac = dataReader.IsDBNull(dataReader.GetOrdinal("Lugar_Nac")) ? null : dataReader["Lugar_Nac"].ToString();
                            empleado.PaisNacimiento = dataReader.IsDBNull(dataReader.GetOrdinal("PaisNacimiento")) ? null : dataReader["PaisNacimiento"].ToString();
                            empleado.Estado_Nac = dataReader.IsDBNull(dataReader.GetOrdinal("Estado_Nac")) ? null : dataReader["Estado_Nac"].ToString();
                            empleado.Nombre_Padre = dataReader.IsDBNull(dataReader.GetOrdinal("Nombre_Padre")) ? null : dataReader["Nombre_Padre"].ToString();
                            empleado.Nombre_Madre = dataReader.IsDBNull(dataReader.GetOrdinal("Nombre_Madre")) ? null : dataReader["Nombre_Madre"].ToString();
                            empleado.Origen = dataReader.IsDBNull(dataReader.GetOrdinal("Origen")) ? default(Int16?) : Int16.Parse(dataReader["Origen"].ToString());
                            empleado.Nacionalidad = dataReader.IsDBNull(dataReader.GetOrdinal("Nacionalidad")) ? null : dataReader["Nacionalidad"].ToString();
                            empleado.Tipo_Pago = dataReader.IsDBNull(dataReader.GetOrdinal("Tipo_Pago")) ? default(Int16?) : Int16.Parse(dataReader["Tipo_Pago"].ToString());
                            empleado.Banco = dataReader.IsDBNull(dataReader.GetOrdinal("Banco")) ? null : dataReader["Banco"].ToString();
                            empleado.Sucursal = dataReader.IsDBNull(dataReader.GetOrdinal("Sucursal")) ? null : dataReader["Sucursal"].ToString();
                            empleado.Cta_Cheques = dataReader.IsDBNull(dataReader.GetOrdinal("Cta_Cheques")) ? null : dataReader["Cta_Cheques"].ToString();
                            empleado.Fuente = dataReader.IsDBNull(dataReader.GetOrdinal("Fuente")) ? null : dataReader["Fuente"].ToString();
                            empleado.Tarjeta = dataReader.IsDBNull(dataReader.GetOrdinal("Tarjeta")) ? default(Int16?) : Int16.Parse(dataReader["Tarjeta"].ToString());
                            empleado.Destajos = dataReader.IsDBNull(dataReader.GetOrdinal("Destajos")) ? default(Int16?) : Int16.Parse(dataReader["Destajos"].ToString());
                            empleado.Turno = dataReader.IsDBNull(dataReader.GetOrdinal("Turno")) ? null : dataReader["Turno"].ToString();
                            empleado.Expediente = dataReader.IsDBNull(dataReader.GetOrdinal("Expediente")) ? null : dataReader["Expediente"].ToString();
                            empleado.NumCreditoInfonavit = dataReader.IsDBNull(dataReader.GetOrdinal("NumCreditoInfonavit")) ? null : dataReader["NumCreditoInfonavit"].ToString();
                            empleado.Tipo_Pago_Infonavit = dataReader.IsDBNull(dataReader.GetOrdinal("Tipo_Pago_Infonavit")) ? default(Int16?) : Int16.Parse(dataReader["Tipo_Pago_Infonavit"].ToString());
                            empleado.Factor = dataReader.IsDBNull(dataReader.GetOrdinal("Factor")) ? default(Decimal?) : Decimal.Parse(dataReader["Factor"].ToString());
                            empleado.CLABE = dataReader.IsDBNull(dataReader.GetOrdinal("CLABE")) ? null : dataReader["CLABE"].ToString();
                            empleado.Banco_Alt = dataReader.IsDBNull(dataReader.GetOrdinal("Banco_Alt")) ? null : dataReader["Banco_Alt"].ToString();
                            empleado.Sucursal_Alt = dataReader.IsDBNull(dataReader.GetOrdinal("Sucursal_Alt")) ? null : dataReader["Sucursal_Alt"].ToString();
                            empleado.Cta_Cheques_Alt = dataReader.IsDBNull(dataReader.GetOrdinal("Cta_Cheques_Alt")) ? null : dataReader["Cta_Cheques_Alt"].ToString();
                            empleado.CLABE_Alt = dataReader.IsDBNull(dataReader.GetOrdinal("CLABE_Alt")) ? null : dataReader["CLABE_Alt"].ToString();
                            empleado.Tarjeta_Vales = dataReader.IsDBNull(dataReader.GetOrdinal("Tarjeta_Vales")) ? null : dataReader["Tarjeta_Vales"].ToString();
                            empleado.Path_Firma = dataReader.IsDBNull(dataReader.GetOrdinal("Path_Firma")) ? null : dataReader["Path_Firma"].ToString();
                            empleado.Estatus = dataReader.IsDBNull(dataReader.GetOrdinal("Estatus")) ? null : dataReader["Estatus"].ToString();
                            empleado.Tarjeta_Vales_Ant = dataReader.IsDBNull(dataReader.GetOrdinal("Tarjeta_Vales_Ant")) ? null : dataReader["Tarjeta_Vales_Ant"].ToString();
                            empleado.Correo = dataReader.IsDBNull(dataReader.GetOrdinal("Correo")) ? null : dataReader["Correo"].ToString();
                            empleado.Tarjeta_VGasolina = dataReader.IsDBNull(dataReader.GetOrdinal("Tarjeta_VGasolina")) ? null : dataReader["Tarjeta_VGasolina"].ToString();
                            empleado.EntidadLaboral = dataReader.IsDBNull(dataReader.GetOrdinal("EntidadLaboral")) ? null : dataReader["EntidadLaboral"].ToString();

                            //Tel Empleados
                            empleado.Tipo = dataReader.IsDBNull(dataReader.GetOrdinal("Tipo")) ? default(Int16) : Int16.Parse(dataReader["Tipo"].ToString());
                            empleado.Sec_Tel_Empleados = dataReader.IsDBNull(dataReader.GetOrdinal("Sec_Tel_Empleados")) ? default(Int16) : Int16.Parse(dataReader["Sec_Tel_Empleados"].ToString());
                            empleado.Telefono = dataReader.IsDBNull(dataReader.GetOrdinal("Telefono")) ? null : dataReader["Telefono"].ToString();

                            //H_Personal 
                            empleado.Direccion = dataReader.IsDBNull(dataReader.GetOrdinal("Direccion")) ? null : dataReader["Direccion"].ToString();
                            empleado.Poblacion = dataReader.IsDBNull(dataReader.GetOrdinal("Poblacion")) ? null : dataReader["Poblacion"].ToString();
                            empleado.Ciudad = dataReader.IsDBNull(dataReader.GetOrdinal("Ciudad")) ? null : dataReader["Ciudad"].ToString();
                            empleado.Colonia = dataReader.IsDBNull(dataReader.GetOrdinal("Colonia")) ? null : dataReader["Colonia"].ToString();
                            empleado.Cp = dataReader.IsDBNull(dataReader.GetOrdinal("Cp")) ? null : dataReader["Cp"].ToString();
                            empleado.Pais = dataReader.IsDBNull(dataReader.GetOrdinal("Pais")) ? null : dataReader["Pais"].ToString();
                            empleado.Estado = dataReader.IsDBNull(dataReader.GetOrdinal("Estado")) ? null : dataReader["Estado"].ToString();
                            empleado.Estado_Civil = dataReader.IsDBNull(dataReader.GetOrdinal("Estado_Civil")) ? default(Int16?) : Int16.Parse(dataReader["Estado_Civil"].ToString());
                            empleado.Usuario = dataReader.IsDBNull(dataReader.GetOrdinal("Usuario")) ? null : dataReader["Usuario"].ToString();
                            empleado.Numero_Ext = dataReader.IsDBNull(dataReader.GetOrdinal("Numero_Ext")) ? null : dataReader["Numero_Ext"].ToString();
                            empleado.Numero_Int = dataReader.IsDBNull(dataReader.GetOrdinal("Numero_Int")) ? null : dataReader["Numero_Int"].ToString();

                            //H_Sueldos
                            empleado.Tipo_Sueldo = dataReader.IsDBNull(dataReader.GetOrdinal("Tipo_Sueldo")) ? null : dataReader["Tipo_Sueldo"].ToString();
                            empleado.SDI = dataReader.IsDBNull(dataReader.GetOrdinal("SDI")) ? default(Double) : Double.Parse(dataReader["SDI"].ToString());
                            empleado.SDN = dataReader.IsDBNull(dataReader.GetOrdinal("SDN")) ? default(Double) : Double.Parse(dataReader["SDN"].ToString());
                            empleado.SM = dataReader.IsDBNull(dataReader.GetOrdinal("SM")) ? default(Double) : Double.Parse(dataReader["SM"].ToString());

                            //H_Laboral                            
                            empleado.Sec_H_Laboral = dataReader.IsDBNull(dataReader.GetOrdinal("Sec_H_Laboral")) ? default(Int16) : Int16.Parse(dataReader["Sec_H_Laboral"].ToString());
                            empleado.Accion = dataReader.IsDBNull(dataReader.GetOrdinal("Accion")) ? null : dataReader["Accion"].ToString();
                            empleado.Motivo = dataReader.IsDBNull(dataReader.GetOrdinal("Motivo")) ? null : dataReader["Motivo"].ToString();
                            empleado.Grupo_Pago = dataReader.IsDBNull(dataReader.GetOrdinal("Grupo_Pago")) ? null : dataReader["Grupo_Pago"].ToString();
                            empleado.Grupo_Pago_Pasajes = dataReader.IsDBNull(dataReader.GetOrdinal("Grupo_Pago_Pasajes")) ? null : dataReader["Grupo_Pago_Pasajes"].ToString();
                            empleado.Tipo_Contrato = dataReader.IsDBNull(dataReader.GetOrdinal("Tipo_Contrato")) ? default(Int16?) : Int16.Parse(dataReader["Tipo_Contrato"].ToString());
                            empleado.Fecha_Ingreso = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Ingreso")) ? default(DateTime) : DateTime.Parse(dataReader["Fecha_Ingreso"].ToString());
                            empleado.Fecha_Antiguedad1 = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Antiguedad1")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Antiguedad1"].ToString());
                            empleado.Fecha_Antiguedad2 = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Antiguedad2")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Antiguedad2"].ToString());
                            empleado.Fecha_Antiguedad3 = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Antiguedad3")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Antiguedad3"].ToString());
                            empleado.Duracion = dataReader.IsDBNull(dataReader.GetOrdinal("Duracion")) ? default(Int16?) : Int16.Parse(dataReader["Duracion"].ToString());
                            empleado.Fecha_Vento = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Vento")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Vento"].ToString());
                            empleado.Fecha_Baja = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Baja")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Baja"].ToString());
                            empleado.Tipo_Salario = dataReader.IsDBNull(dataReader.GetOrdinal("Tipo_Salario")) ? default(Int16?) : Int16.Parse(dataReader["Tipo_Salario"].ToString());
                            empleado.Tipo_Empleado = dataReader.IsDBNull(dataReader.GetOrdinal("Tipo_Empleado")) ? null : dataReader["Tipo_Empleado"].ToString();
                            empleado.Localidad = dataReader.IsDBNull(dataReader.GetOrdinal("Localidad")) ? null : dataReader["Localidad"].ToString();
                            empleado.Departamento = dataReader.IsDBNull(dataReader.GetOrdinal("Departamento")) ? null : dataReader["Departamento"].ToString();
                            empleado.Puesto = dataReader.IsDBNull(dataReader.GetOrdinal("Puesto")) ? null : dataReader["Puesto"].ToString();
                            empleado.Dependencia = dataReader.IsDBNull(dataReader.GetOrdinal("Dependencia")) ? null : dataReader["Dependencia"].ToString();
                            empleado.Cliente = dataReader.IsDBNull(dataReader.GetOrdinal("Cliente")) ? null : dataReader["Cliente"].ToString();
                            empleado.Tipo_De_Operacion = dataReader.IsDBNull(dataReader.GetOrdinal("Tipo_De_Operacion")) ? null : dataReader["Tipo_De_Operacion"].ToString();
                            empleado.Region = dataReader.IsDBNull(dataReader.GetOrdinal("Region")) ? null : dataReader["Region"].ToString();
                            empleado.Sector = dataReader.IsDBNull(dataReader.GetOrdinal("Sector")) ? null : dataReader["Sector"].ToString();
                            empleado.Sindicalizado = dataReader.IsDBNull(dataReader.GetOrdinal("Sindicalizado")) ? default(Int16?) : Int16.Parse(dataReader["Sindicalizado"].ToString());

                            //Valores por Empleado                            
                            empleado.Centro_de_Costos = dataReader.IsDBNull(dataReader.GetOrdinal("Centro_de_Costos")) ? null : dataReader["Centro_de_Costos"].ToString();
                            empleado.Unidad_de_Costos = dataReader.IsDBNull(dataReader.GetOrdinal("Unidad_de_Costos")) ? null : dataReader["Unidad_de_Costos"].ToString();

                            //Checador                            
                            empleado.Numero_Nomina = dataReader.IsDBNull(dataReader.GetOrdinal("Numero_Nomina")) ? default(int) : int.Parse(dataReader["Numero_Nomina"].ToString());
                            //empleado.Numero_Nominas = dataReader.IsDBNull(dataReader.GetOrdinal("Numero_Nominas")) ? default(Int16?) : Int16.Parse(dataReader["Numero_Nominas"].ToString());
                            //empleado.FechaMod = dataReader.IsDBNull(dataReader.GetOrdinal("FechaMod")) ? default(DateTime?) : DateTime.Parse(dataReader["FechaMod"].ToString());

                            //Administrativo
                            empleado.Id_Per = dataReader.IsDBNull(dataReader.GetOrdinal("Id_Per")) ? default(int) : int.Parse(dataReader["Id_Per"].ToString());
                            //empleado.Num_Checador = dataReader.IsDBNull(dataReader.GetOrdinal("Numero_Nomina")) ? default(Int16?) : Int16.Parse(dataReader["Numero_Nomina"].ToString());
                            //empleado.Nomi_Camb = dataReader.IsDBNull(dataReader.GetOrdinal("Nomi_Camb")) ? default(Int16?) : Int16.Parse(dataReader["Nomi_Camb"].ToString());
                            //empleado.User_Mod = dataReader.IsDBNull(dataReader.GetOrdinal("User_Mod")) ? default(Int16?) : Int16.Parse(dataReader["User_Mod"].ToString());

                        }
                    }

                    dataReader.Close();
                    dataReader.Dispose();
                }

                return empleado;
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message);
            }
        }

        public Entities.QProcess.Empleados.AltaSoluglob GetLayoutSoluglob(int IdEntrevistaCandidato, int id_Per, int Numero_Nomina)
        {
            Entities.QProcess.Empleados.AltaSoluglob empleado = new Entities.QProcess.Empleados.AltaSoluglob();
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter() { ParameterName = "IdEntrevistaCandidato", Value = IdEntrevistaCandidato });
                parameters.Add(new SqlParameter() { ParameterName = "ID_PER", Value = id_Per });
                parameters.Add(new SqlParameter() { ParameterName = "Numero_Nomina", Value = Numero_Nomina });

                using (dataReader = this.connection.ExcuteSP("Prc_GetLayoutSoluglob", parameters))
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            empleado.Id_Per = dataReader.IsDBNull(dataReader.GetOrdinal("Id_Per")) ? default(int) : int.Parse(dataReader["Id_Per"].ToString());
                            empleado.Num_Checador = dataReader.IsDBNull(dataReader.GetOrdinal("Num_Checador")) ? default(int) : int.Parse(dataReader["Num_Checador"].ToString());
                            empleado.Nomi_Camb = dataReader.IsDBNull(dataReader.GetOrdinal("Nomi_Camb")) ? default(int) : int.Parse(dataReader["Nomi_Camb"].ToString());
                            empleado.FecReg = dataReader.IsDBNull(dataReader.GetOrdinal("FecReg")) ? (DateTime?) null : DateTime.Parse(dataReader["FecReg"].ToString());
                            empleado.Nombre = dataReader.IsDBNull(dataReader.GetOrdinal("Nombre")) ? null : dataReader["Nombre"].ToString();
                            empleado.Sexo = dataReader.IsDBNull(dataReader.GetOrdinal("Sexo")) ? default(int) : int.Parse(dataReader["Sexo"].ToString());
                            empleado.Edad = dataReader.IsDBNull(dataReader.GetOrdinal("Edad")) ? default(int) : int.Parse(dataReader["Edad"].ToString());
                            empleado.NSS = dataReader.IsDBNull(dataReader.GetOrdinal("NSS")) ? null : dataReader["NSS"].ToString();
                            empleado.CURP = dataReader.IsDBNull(dataReader.GetOrdinal("CURP")) ? null : dataReader["CURP"].ToString();
                            empleado.Calle = dataReader.IsDBNull(dataReader.GetOrdinal("Calle")) ? null : dataReader["Calle"].ToString();
                            empleado.Numero = dataReader.IsDBNull(dataReader.GetOrdinal("Numero")) ? null : dataReader["Numero"].ToString();
                            empleado.Mz = dataReader.IsDBNull(dataReader.GetOrdinal("Mz")) ? null : dataReader["Mz"].ToString();
                            empleado.Lt = dataReader.IsDBNull(dataReader.GetOrdinal("Lt")) ? null : dataReader["Lt"].ToString();
                            empleado.Colonia = dataReader.IsDBNull(dataReader.GetOrdinal("colonia")) ? null : dataReader["colonia"].ToString();
                            empleado.Municipio = dataReader.IsDBNull(dataReader.GetOrdinal("Municipio")) ? null : dataReader["Municipio"].ToString();
                            empleado.Ciudad = dataReader.IsDBNull(dataReader.GetOrdinal("Ciudad")) ? null : dataReader["Ciudad"].ToString();
                            empleado.Estado = dataReader.IsDBNull(dataReader.GetOrdinal("Estado")) ? null : dataReader["Estado"].ToString();
                            empleado.Tel = dataReader.IsDBNull(dataReader.GetOrdinal("Tel")) ? null : dataReader["Tel"].ToString();
                            empleado.Cel = dataReader.IsDBNull(dataReader.GetOrdinal("Cel")) ? null : dataReader["Cel"].ToString();
                            empleado.Email = dataReader.IsDBNull(dataReader.GetOrdinal("Email")) ? null : dataReader["Email"].ToString();
                            empleado.Sueldo = dataReader.IsDBNull(dataReader.GetOrdinal("Sueldo")) ? default(decimal) : decimal.Parse(dataReader["Sueldo"].ToString());
                            empleado.Jefe = dataReader.IsDBNull(dataReader.GetOrdinal("Jefe")) ? default(int) : int.Parse(dataReader["Jefe"].ToString());
                            empleado.Horario = dataReader.IsDBNull(dataReader.GetOrdinal("Horario")) ? null : dataReader["Horario"].ToString();
                            empleado.Estatus = dataReader.IsDBNull(dataReader.GetOrdinal("Estatus")) ? default(int) : int.Parse(dataReader["Estatus"].ToString());
                            empleado.User_Mod = dataReader.IsDBNull(dataReader.GetOrdinal("User_MOd")) ? default(int) : int.Parse(dataReader["User_MOd"].ToString());
                            empleado.FecMod = dataReader.IsDBNull(dataReader.GetOrdinal("FecMod")) ? (DateTime?)null : DateTime.Parse(dataReader["FecMod"].ToString());
                            empleado.AplicaBono = dataReader.IsDBNull(dataReader.GetOrdinal("AplicaBono")) ? default(int) : int.Parse(dataReader["AplicaBono"].ToString());
                            empleado.Desc_Vacante = dataReader.IsDBNull(dataReader.GetOrdinal("Desc_Vacante")) ? null : dataReader["Desc_Vacante"].ToString();
                            empleado.CeCo = dataReader.IsDBNull(dataReader.GetOrdinal("Ceco")) ? default(int) : int.Parse(dataReader["Ceco"].ToString());
                            empleado.UCos = dataReader.IsDBNull(dataReader.GetOrdinal("UCOS")) ? null : dataReader["UCOS"].ToString();
                            empleado.Estatus_Vacante = dataReader.IsDBNull(dataReader.GetOrdinal("Estatus_Vacante")) ? default(int) : int.Parse(dataReader["Estatus_Vacante"].ToString());
                            empleado.Segmento = dataReader.IsDBNull(dataReader.GetOrdinal("Segmento")) ? default(int) : int.Parse(dataReader["Segmento"].ToString());
                            empleado.Gerencia = dataReader.IsDBNull(dataReader.GetOrdinal("Gerencia")) ? default(int) : int.Parse(dataReader["Gerencia"].ToString());
                            empleado.idCatPuesto = dataReader.IsDBNull(dataReader.GetOrdinal("idCatPuesto")) ? default(int) : int.Parse(dataReader["idCatPuesto"].ToString());
                            empleado.Puesto = dataReader.IsDBNull(dataReader.GetOrdinal("Puesto")) ? null :  dataReader["Puesto"].ToString();
                            empleado.Verificacion = dataReader.IsDBNull(dataReader.GetOrdinal("Verificacion")) ? null : dataReader["Verificacion"].ToString();
                            empleado.Depto = dataReader.IsDBNull(dataReader.GetOrdinal("Depto")) ? null : dataReader["Depto"].ToString();
                            empleado.Lunes_Entrada = dataReader.IsDBNull(dataReader.GetOrdinal("Lunes_Entrada")) ? null : dataReader["Lunes_Entrada"].ToString();
                            empleado.Lunes_Salida = dataReader.IsDBNull(dataReader.GetOrdinal("Lunes_Salida")) ? null : dataReader["Lunes_Salida"].ToString();
                            empleado.Martes_Entrada = dataReader.IsDBNull(dataReader.GetOrdinal("Martes_Entrada")) ? null : dataReader["Martes_Entrada"].ToString();
                            empleado.Martes_Salida = dataReader.IsDBNull(dataReader.GetOrdinal("Martes_Salida")) ? null : dataReader["Martes_Salida"].ToString();
                            empleado.Miercoles_Entrada = dataReader.IsDBNull(dataReader.GetOrdinal("Miercoles_Entrada")) ? null : dataReader["Miercoles_Entrada"].ToString();
                            empleado.Miercoles_Salida = dataReader.IsDBNull(dataReader.GetOrdinal("Miercoles_Salida")) ? null : dataReader["Miercoles_Salida"].ToString();
                            empleado.Jueves_Entrada = dataReader.IsDBNull(dataReader.GetOrdinal("Jueves_Entrada")) ? null : dataReader["Jueves_Entrada"].ToString();
                            empleado.Jueves_Salida = dataReader.IsDBNull(dataReader.GetOrdinal("Jueves_Salida")) ? null : dataReader["Jueves_Salida"].ToString();
                            empleado.Viernes_Entrada = dataReader.IsDBNull(dataReader.GetOrdinal("Viernes_Entrada")) ? null : dataReader["Viernes_Entrada"].ToString();
                            empleado.Viernes_Salida = dataReader.IsDBNull(dataReader.GetOrdinal("Viernes_Salida")) ? null : dataReader["Viernes_Salida"].ToString();
                            empleado.Sabado_Entrada = dataReader.IsDBNull(dataReader.GetOrdinal("Sabado_Entrada")) ? null : dataReader["Sabado_Entrada"].ToString();
                            empleado.Sabado_Salida = dataReader.IsDBNull(dataReader.GetOrdinal("Sabado_Salida")) ? null : dataReader["Sabado_Salida"].ToString();
                            empleado.Domingo_Entrada = dataReader.IsDBNull(dataReader.GetOrdinal("Domingo_Entrada")) ? null : dataReader["Domingo_Entrada"].ToString();
                            empleado.Domingo_Salida = dataReader.IsDBNull(dataReader.GetOrdinal("Domingo_Salida")) ? null : dataReader["Domingo_Salida"].ToString();
                            empleado.Fecha_Modificacion = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Modificacion")) ? (DateTime?)null : DateTime.Parse(dataReader["Fecha_Modificacion"].ToString());
                            empleado.Numero_Nomina = dataReader.IsDBNull(dataReader.GetOrdinal("Numero_Nomina")) ? default(int) : int.Parse(dataReader["Numero_Nomina"].ToString());
                            empleado.Nombres = dataReader.IsDBNull(dataReader.GetOrdinal("Nombres")) ? null : dataReader["Nombres"].ToString();
                            empleado.Apellidos = dataReader.IsDBNull(dataReader.GetOrdinal("Apellidos")) ? null : dataReader["Apellidos"].ToString();
                            empleado.Departamento = dataReader.IsDBNull(dataReader.GetOrdinal("Departamento")) ? null : dataReader["Departamento"].ToString();
                            empleado.Telefono = dataReader.IsDBNull(dataReader.GetOrdinal("Telefono")) ? null : dataReader["Telefono"].ToString();
                            empleado.Huella_Bin1 = dataReader.IsDBNull(dataReader.GetOrdinal("Huella_Bin1")) ? null : dataReader["Huella_Bin1"].ToString();
                            empleado.Huella_Img1 = dataReader.IsDBNull(dataReader.GetOrdinal("Huella_Img1")) ? null : dataReader["Huella_Img1"].ToString();
                            empleado.Huella_Bin2 = dataReader.IsDBNull(dataReader.GetOrdinal("Huella_Bin2")) ? null : dataReader["Huella_Bin2"].ToString();
                            empleado.Huella_Bin3 = dataReader.IsDBNull(dataReader.GetOrdinal("Huella_Bin3")) ? null : dataReader["Huella_Bin3"].ToString();
                            empleado.Huella_Bin4 = dataReader.IsDBNull(dataReader.GetOrdinal("Huella_Bin4")) ? null : dataReader["Huella_Bin4"].ToString();
                            empleado.Fecha_Alta = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Alta")) ? (DateTime?)null : DateTime.Parse(dataReader["Fecha_Alta"].ToString());
                            empleado.Fecha_Baja = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Baja")) ? (DateTime?)null : DateTime.Parse(dataReader["Fecha_Baja"].ToString());
                            empleado.Empresa = dataReader.IsDBNull(dataReader.GetOrdinal("Empresa")) ? null : dataReader["Empresa"].ToString();
                            empleado.Ubicacion_usuarios = dataReader.IsDBNull(dataReader.GetOrdinal("Ubicacion_usuarios")) ? null : dataReader["Ubicacion_usuarios"].ToString();
                            empleado.MotivoBaja = dataReader.IsDBNull(dataReader.GetOrdinal("MotivoBaja")) ? null : dataReader["MotivoBaja"].ToString();
                            empleado.Caso_Especial = dataReader.IsDBNull(dataReader.GetOrdinal("Caso_Especial")) ? default(bool?) : bool.Parse(dataReader["Caso_Especial"].ToString());
                            empleado.msrepl_tran_version = dataReader.IsDBNull(dataReader.GetOrdinal("msrepl_tran_version")) ? default(Guid) : Guid.Parse(dataReader["msrepl_tran_version"].ToString());
                            empleado.Registrado = dataReader.IsDBNull(dataReader.GetOrdinal("Registrado")) ? default(int?) : int.Parse(dataReader["Registrado"].ToString());
                            empleado.Imss = dataReader.IsDBNull(dataReader.GetOrdinal("Imss")) ? null : dataReader["Imss"].ToString();
                            empleado.Dias_semana = dataReader.IsDBNull(dataReader.GetOrdinal("Dias_semana")) ? default(int?) : int.Parse(dataReader["Dias_semana"].ToString());
                            empleado.fecha_ingresos = dataReader.IsDBNull(dataReader.GetOrdinal("fecha_ingresos")) ? (DateTime?)null : DateTime.Parse(dataReader["fecha_ingresos"].ToString());
                            empleado.pagos_hextras = dataReader.IsDBNull(dataReader.GetOrdinal("pagos_hextras")) ? null : dataReader["pagos_hextras"].ToString();
                            empleado.Fechas_registro = dataReader.IsDBNull(dataReader.GetOrdinal("Fechas_registro")) ? (DateTime?)null : DateTime.Parse(dataReader["Fechas_registro"].ToString());
                            empleado.unidad_costos = dataReader.IsDBNull(dataReader.GetOrdinal("unidad_costos")) ? null : dataReader["unidad_costos"].ToString();
                            empleado.Fecha_Reingreso = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Reingreso")) ? (DateTime?)null : DateTime.Parse(dataReader["Fecha_Reingreso"].ToString());
                            empleado.Centro_costos = dataReader.IsDBNull(dataReader.GetOrdinal("Centro_Costos")) ? null : dataReader["Centro_Costos"].ToString();
                            empleado.Numero_Nominas = dataReader.IsDBNull(dataReader.GetOrdinal("Numero_Nominas")) ? default(int?) : int.Parse(dataReader["Numero_Nominas"].ToString());
                            empleado.Remuneracion = dataReader.IsDBNull(dataReader.GetOrdinal("Remuneracion")) ? null : dataReader["Remuneracion"].ToString();
                            empleado.Fecha_Alta_Imss = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Alta_Imss")) ? (DateTime?)null : DateTime.Parse(dataReader["Fecha_Alta_Imss"].ToString());
                            empleado.Fecha_Baja_sistema = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Baja_sistema")) ? (DateTime?)null : DateTime.Parse(dataReader["Fecha_Baja_sistema"].ToString());
                            empleado.Estatus_Edicion = dataReader.IsDBNull(dataReader.GetOrdinal("Estatus_Edicion")) ? default(int?) : int.Parse(dataReader["Estatus_Edicion"].ToString());
                            empleado.Fecha_Modificacion = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Modificacion")) ? (DateTime?) null : DateTime.Parse(dataReader["Fecha_Modificacion"].ToString());
                            empleado.Bono = dataReader.IsDBNull(dataReader.GetOrdinal("Bono")) ? default(bool?) : bool.Parse(dataReader["Bono"].ToString());
                            empleado.Responsable_Bono = dataReader.IsDBNull(dataReader.GetOrdinal("Responsable_Bono")) ? null : dataReader["Responsable_Bono"].ToString();
                        }
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }
                return empleado;
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message.ToString());
            }
        }

        public int UpdateEstatusProceso(int NumeroNomina, int EstatusProceso)
        {
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                parameters.Add(new SqlParameter() { ParameterName = "NumeroNomina", Value = NumeroNomina });
                parameters.Add(new SqlParameter() { ParameterName = "EstatusProceso", Value = EstatusProceso });
                this.connection.ExcuteScalar("prc_UpdateEstatusProceso", parameters);
                return NumeroNomina;
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message.ToString());
            }
        }

        public Entities.QProcess.Empleados.AltaSoluglob MovimientosInsert(Entities.QProcess.Empleados.AltaSoluglob objEmpleadoQP)
        {
            Entities.QProcess.Empleados.AltaSoluglob empleadoSG = new Entities.QProcess.Empleados.AltaSoluglob();
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                parameters.Add(new SqlParameter() { ParameterName = "NumeroEmpleado", Value = objEmpleadoQP.Numero_Nominas });
                parameters.Add(new SqlParameter() { ParameterName = "Nombre", Value = objEmpleadoQP.Nombre });
                parameters.Add(new SqlParameter() { ParameterName = "Empresa", Value = objEmpleadoQP.Empresa });
                parameters.Add(new SqlParameter() { ParameterName = "CeCo", Value = objEmpleadoQP.CeCo });
                parameters.Add(new SqlParameter() { ParameterName = "UCOS", Value = objEmpleadoQP.UCos });
                parameters.Add(new SqlParameter() { ParameterName = "Puesto", Value = objEmpleadoQP.Puesto });
                parameters.Add(new SqlParameter() { ParameterName = "idPuesto", Value = objEmpleadoQP.idCatPuesto });
                parameters.Add(new SqlParameter() { ParameterName = "Ubicacion", Value = objEmpleadoQP.Ubicacion_usuarios });
                parameters.Add(new SqlParameter() { ParameterName = "Sueldo", Value = objEmpleadoQP.Sueldo });
                parameters.Add(new SqlParameter() { ParameterName = "Bono", Value = objEmpleadoQP.Bono });

                using (dataReader = this.connection.ExcuteSP("prc_Empleado_Movimientos_Insert", parameters))
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            empleadoSG.Numero_Nominas = dataReader.IsDBNull(dataReader.GetOrdinal("NumeroEmpleado")) ? default(int) : int.Parse(dataReader["NumeroEmpleado"].ToString());
                            empleadoSG.Nombre = dataReader.IsDBNull(dataReader.GetOrdinal("Nombre")) ? null : dataReader["Nombre"].ToString();
                            empleadoSG.Empresa = dataReader.IsDBNull(dataReader.GetOrdinal("Empresa")) ? null : dataReader["Empresa"].ToString();
                            empleadoSG.CeCo = dataReader.IsDBNull(dataReader.GetOrdinal("CeCo")) ? default(int) : int.Parse(dataReader["CeCo"].ToString());
                            empleadoSG.UCos = dataReader.IsDBNull(dataReader.GetOrdinal("UCOS")) ? null : dataReader["UCOS"].ToString();
                            empleadoSG.Puesto = dataReader.IsDBNull(dataReader.GetOrdinal("Puesto")) ? null : dataReader["Puesto"].ToString();
                            empleadoSG.idCatPuesto = dataReader.IsDBNull(dataReader.GetOrdinal("idPuesto")) ? default(int) : int.Parse(dataReader["idPuesto"].ToString());
                            empleadoSG.Ubicacion_usuarios = dataReader.IsDBNull(dataReader.GetOrdinal("Ubicacion")) ? null : dataReader["Ubicacion"].ToString();
                            empleadoSG.Sueldo = dataReader.IsDBNull(dataReader.GetOrdinal("Sueldo")) ? default(decimal?) : decimal.Parse(dataReader["Sueldo"].ToString());
                            empleadoSG.Bono = dataReader.IsDBNull(dataReader.GetOrdinal("Bono")) ? default(bool?) : bool.Parse(dataReader["Bono"].ToString());
                        }
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }

                return empleadoSG;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
            
        }

        public Entities.QProcess.Empleados.Movimientos GetLayoutMovimientos(string NumEmpleado, int IdRequisicionMovimiento)
        {
            Entities.QProcess.Empleados.Movimientos empleado = new Entities.QProcess.Empleados.Movimientos();

            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter() { ParameterName = "NumeroEmpleado", Value = NumEmpleado });
                parameters.Add(new SqlParameter() { ParameterName = "IdRequisicionMovimiento", Value = IdRequisicionMovimiento });

                using (dataReader = this.connection.ExcuteSP("prc_Empleado_LayoutMovimientos", parameters))
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            empleado.idRequisicionMovimiento = dataReader.IsDBNull(dataReader.GetOrdinal("idRequisicionMovimiento")) ? default(int) : int.Parse(dataReader["idRequisicionMovimiento"].ToString());
                            empleado.idCatTipoMovimiento = dataReader.IsDBNull(dataReader.GetOrdinal("idCatTipoMovimiento")) ? default(int) : int.Parse(dataReader["idCatTipoMovimiento"].ToString());
                            empleado.Accion = dataReader.IsDBNull(dataReader.GetOrdinal("Accion")) ? null : dataReader["Accion"].ToString();
                            empleado.idTipoBaja = dataReader.IsDBNull(dataReader.GetOrdinal("idTipoBaja")) ? default(int) : int.Parse(dataReader["idTipoBaja"].ToString());
                            empleado.TipoBaja = dataReader.IsDBNull(dataReader.GetOrdinal("TipoBaja")) ? null : dataReader["TipoBaja"].ToString();
                            empleado.NumeroEmpleado = dataReader.IsDBNull(dataReader.GetOrdinal("NumeroEmpleado")) ? null : dataReader["NumeroEmpleado"].ToString();
                            empleado.Compania = dataReader.IsDBNull(dataReader.GetOrdinal("Compania")) ? null : dataReader["Compania"].ToString();
                            empleado.Empleado = dataReader.IsDBNull(dataReader.GetOrdinal("Empleado")) ? null : dataReader["Empleado"].ToString();
                            empleado.CompaniaPasajes = dataReader.IsDBNull(dataReader.GetOrdinal("CompaniaPasajes")) ? null : dataReader["CompaniaPasajes"].ToString();
                            empleado.GrupoPagoPasajes = dataReader.IsDBNull(dataReader.GetOrdinal("GrupoPagoPasajes")) ? null : dataReader["GrupoPagoPasajes"].ToString();
                            empleado.GrupoPago = dataReader.IsDBNull(dataReader.GetOrdinal("GrupoPago")) ? null : dataReader["GrupoPago"].ToString();
                            empleado.idCatPuesto = dataReader.IsDBNull(dataReader.GetOrdinal("idCatPuesto")) ? default(int) : int.Parse(dataReader["idCatPuesto"].ToString());
                            empleado.NombrePuesto = dataReader.IsDBNull(dataReader.GetOrdinal("NombrePuesto")) ? null : dataReader["NombrePuesto"].ToString();
                            empleado.Puesto = dataReader.IsDBNull(dataReader.GetOrdinal("Puesto")) ? null : dataReader["Puesto"].ToString();
                            empleado.idCatPuestoNuevo = dataReader.IsDBNull(dataReader.GetOrdinal("idCatPuestoNuevo")) ? default(int) : int.Parse(dataReader["idCatPuestoNuevo"].ToString());
                            empleado.NombrePuestoNuevo = dataReader.IsDBNull(dataReader.GetOrdinal("NombrePuestoNuevo")) ? null : dataReader["NombrePuestoNuevo"].ToString();
                            empleado.PuestoNuevo = dataReader.IsDBNull(dataReader.GetOrdinal("PuestoNuevo")) ? null : dataReader["PuestoNuevo"].ToString();
                            empleado.idCeCo = dataReader.IsDBNull(dataReader.GetOrdinal("idCeCo")) ? default(int) : int.Parse(dataReader["idCeCo"].ToString());
                            empleado.CentroCosto = dataReader.IsDBNull(dataReader.GetOrdinal("CentroCosto")) ? null : dataReader["CentroCosto"].ToString();
                            empleado.idCeCoNuevo = dataReader.IsDBNull(dataReader.GetOrdinal("idCeCoNuevo")) ? default(int) : int.Parse(dataReader["idCeCoNuevo"].ToString());
                            empleado.CentroCostoNuevo = dataReader.IsDBNull(dataReader.GetOrdinal("CentroCostoNuevo")) ? null : dataReader["CentroCostoNuevo"].ToString();
                            empleado.CodigoCeCo = dataReader.IsDBNull(dataReader.GetOrdinal("CodigoCeCo")) ? null : dataReader["CodigoCeCo"].ToString();
                            empleado.idUCos = dataReader.IsDBNull(dataReader.GetOrdinal("idUCos")) ? default(int) : int.Parse(dataReader["idUCos"].ToString());
                            empleado.ClaveUCo = dataReader.IsDBNull(dataReader.GetOrdinal("ClaveUCo")) ? null : dataReader["ClaveUCo"].ToString();
                            empleado.idUCosNuevo = dataReader.IsDBNull(dataReader.GetOrdinal("idUCosNuevo")) ? default(int) : int.Parse(dataReader["idUCosNuevo"].ToString());
                            empleado.ClaveUCoNueva = dataReader.IsDBNull(dataReader.GetOrdinal("ClaveUCoNueva")) ? null : dataReader["ClaveUCoNueva"].ToString();
                            empleado.CodigoUCos = dataReader.IsDBNull(dataReader.GetOrdinal("CodigoUCos")) ? null : dataReader["CodigoUCos"].ToString();
                            empleado.Nombre = dataReader.IsDBNull(dataReader.GetOrdinal("Nombre")) ? null : dataReader["Nombre"].ToString();
                            empleado.Cliente = dataReader.IsDBNull(dataReader.GetOrdinal("Cliente")) ? null : dataReader["Cliente"].ToString();                            
                            empleado.TipoMovimiento = dataReader.IsDBNull(dataReader.GetOrdinal("TipoMovimiento")) ? null : dataReader["TipoMovimiento"].ToString();                            
                            empleado.idMotivo = dataReader.IsDBNull(dataReader.GetOrdinal("idMotivo")) ? default(int) : int.Parse(dataReader["idMotivo"].ToString());                            
                            empleado.Motivo = dataReader.IsDBNull(dataReader.GetOrdinal("Motivo")) ? null : dataReader["Motivo"].ToString();
                            empleado.NombreMotivo = dataReader.IsDBNull(dataReader.GetOrdinal("NombreMotivo")) ? null : dataReader["NombreMotivo"].ToString();
                            empleado.FechaBaja = dataReader.IsDBNull(dataReader.GetOrdinal("FechaBaja")) ? default(DateTime) : DateTime.Parse(dataReader["FechaBaja"].ToString());
                            empleado.FechaAplicacionCambio = dataReader.IsDBNull(dataReader.GetOrdinal("FechaAplicacionCambio")) ? default(DateTime) : DateTime.Parse(dataReader["FechaAplicacionCambio"].ToString());
                            empleado.Ubicacion = dataReader.IsDBNull(dataReader.GetOrdinal("Ubicacion")) ? null : dataReader["Ubicacion"].ToString();
                            empleado.Sueldo = dataReader.IsDBNull(dataReader.GetOrdinal("Sueldo")) ? default(Double) : Double.Parse(dataReader["Sueldo"].ToString());
                            empleado.Bono = dataReader.IsDBNull(dataReader.GetOrdinal("Bono")) ? default(Double) : Double.Parse(dataReader["Bono"].ToString());
                            empleado.SueldoNuevo = dataReader.IsDBNull(dataReader.GetOrdinal("SueldoNuevo")) ? default(Double) : Double.Parse(dataReader["SueldoNuevo"].ToString());
                            empleado.BonoNuevo = dataReader.IsDBNull(dataReader.GetOrdinal("BonoNuevo")) ? default(Double) : Double.Parse(dataReader["BonoNuevo"].ToString());
                            empleado.EstatusProceso = dataReader.IsDBNull(dataReader.GetOrdinal("EstatusProceso")) ? default(int) : int.Parse(dataReader["EstatusProceso"].ToString());
                            empleado.NumChecador = dataReader.IsDBNull(dataReader.GetOrdinal("NumChecador")) ? default(int) : int.Parse(dataReader["NumChecador"].ToString());
                            //empleado.Id_Vac = dataReader.IsDBNull(dataReader.GetOrdinal("Id_Vac")) ? default(int) : int.Parse(dataReader["Id_Vac"].ToString());
                            empleado.IdCambio = dataReader.IsDBNull(dataReader.GetOrdinal("IdCambio")) ? default(int) : int.Parse(dataReader["IdCambio"].ToString());
                            empleado.DescripcionCambio = dataReader.IsDBNull(dataReader.GetOrdinal("DescripcionCambio")) ? null : dataReader["DescripcionCambio"].ToString();

                        }
                       
                    }

                    dataReader.Close();
                    dataReader.Dispose();
                }
                                
                return empleado;
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message);
            }
        }       

        public Entities.QProcess.Empleados.Movimientos UpdateEstatusProcesoMovimiento(string NumeroEmpleado, int RequisicionMovimiento, int EstatusProceso)
        {
            Entities.QProcess.Empleados.Movimientos empleado = new Entities.QProcess.Empleados.Movimientos();
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                parameters.Add(new SqlParameter() { ParameterName = "NumeroEmpleado", Value = NumeroEmpleado });
                parameters.Add(new SqlParameter() { ParameterName = "IdRequisicionMovimiento", Value = RequisicionMovimiento });
                parameters.Add(new SqlParameter() { ParameterName = "EstatusProceso", Value = EstatusProceso });

                using (dataReader = this.connection.ExcuteSP("prc_RequisicionMovimiento_UpdateEstatusProceso", parameters))
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            empleado.idRequisicionMovimiento = dataReader.IsDBNull(dataReader.GetOrdinal("idRequisicionMovimiento")) ? default(int) : int.Parse(dataReader["idRequisicionMovimiento"].ToString());                            
                            empleado.Compania = dataReader.IsDBNull(dataReader.GetOrdinal("Compania")) ? null : dataReader["Compania"].ToString();
                            empleado.Empleado = dataReader.IsDBNull(dataReader.GetOrdinal("Empleado")) ? null : dataReader["Empleado"].ToString();   
                            empleado.idCatTipoMovimiento = dataReader.IsDBNull(dataReader.GetOrdinal("idCatTipoMovimiento")) ? default(int) : int.Parse(dataReader["idCatTipoMovimiento"].ToString());                            
                            empleado.EstatusProceso = dataReader.IsDBNull(dataReader.GetOrdinal("EstatusProceso")) ? default(int) : int.Parse(dataReader["EstatusProceso"].ToString());
                        }
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }

                return empleado;
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message.ToString());
            }
        }

    }
}
