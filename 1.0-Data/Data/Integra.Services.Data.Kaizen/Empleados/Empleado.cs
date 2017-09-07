using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Log = Integra.Services.Business.Log;

namespace Integra.Services.Data.Kaizen.Empleados
{
    public class Empleado
    {
        List<Entities.Kaizen.Empleados.Empleado> empleadoCollection = null;
        Entities.Kaizen.Empleados.Empleado empleado = null;
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

        public Entities.Kaizen.Empleados.Empleado Insert(Entities.Kaizen.Empleados.Empleado objEmpleado)
        {
            empleado = new Entities.Kaizen.Empleados.Empleado();
            //StringBuilder sb = new StringBuilder();
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                parameters.Add(new SqlParameter() { ParameterName = "compania", Value = objEmpleado.compania });
                parameters.Add(new SqlParameter() { ParameterName = "companiaPasajes", Value = objEmpleado.companiaPasajes });
                parameters.Add(new SqlParameter() { ParameterName = "empleado", Value = objEmpleado.numEmpleado });
                parameters.Add(new SqlParameter() { ParameterName = "apellido_paterno", Value = objEmpleado.apellido_paterno });
                parameters.Add(new SqlParameter() { ParameterName = "apellido_materno", Value = objEmpleado.apellido_materno });
                parameters.Add(new SqlParameter() { ParameterName = "nombres", Value = objEmpleado.nombres });
                parameters.Add(new SqlParameter() { ParameterName = "nombre", Value = objEmpleado.nombre });
                parameters.Add(new SqlParameter() { ParameterName = "path_foto", Value = objEmpleado.path_foto });
                parameters.Add(new SqlParameter() { ParameterName = "rfc", Value = objEmpleado.rfc });
                parameters.Add(new SqlParameter() { ParameterName = "curp", Value = objEmpleado.curp });
                parameters.Add(new SqlParameter() { ParameterName = "elector", Value = objEmpleado.elector });
                parameters.Add(new SqlParameter() { ParameterName = "cartilla", Value = objEmpleado.cartilla });
                parameters.Add(new SqlParameter() { ParameterName = "licencia", Value = objEmpleado.licencia });
                parameters.Add(new SqlParameter() { ParameterName = "numero_imss", Value = objEmpleado.numero_imss });
                parameters.Add(new SqlParameter() { ParameterName = "tipo_sangre", Value = objEmpleado.tipo_sangre });
                parameters.Add(new SqlParameter() { ParameterName = "sexo", Value = objEmpleado.sexo });
                parameters.Add(new SqlParameter() { ParameterName = "tratamiento", Value = objEmpleado.tratamiento });
                parameters.Add(new SqlParameter() { ParameterName = "nivel_estudio", Value = objEmpleado.nivel_estudio });
                parameters.Add(new SqlParameter() { ParameterName = "fecha_nac", Value = objEmpleado.fecha_nac });
                parameters.Add(new SqlParameter() { ParameterName = "lugar_nac", Value = objEmpleado.lugar_nac });
                parameters.Add(new SqlParameter() { ParameterName = "pais_nac", Value = objEmpleado.pais_nac });
                parameters.Add(new SqlParameter() { ParameterName = "estado_nac", Value = objEmpleado.estado_nac });
                parameters.Add(new SqlParameter() { ParameterName = "nombre_padre", Value = objEmpleado.nombre_padre });
                parameters.Add(new SqlParameter() { ParameterName = "nombre_madre", Value = objEmpleado.nombre_madre });
                parameters.Add(new SqlParameter() { ParameterName = "origen", Value = objEmpleado.origen });
                parameters.Add(new SqlParameter() { ParameterName = "nacionalidad", Value = objEmpleado.nacionalidad });
                parameters.Add(new SqlParameter() { ParameterName = "tipo_pago", Value = objEmpleado.tipo_pago });
                parameters.Add(new SqlParameter() { ParameterName = "banco", Value = objEmpleado.banco });
                parameters.Add(new SqlParameter() { ParameterName = "sucursal", Value = objEmpleado.sucursal });
                parameters.Add(new SqlParameter() { ParameterName = "cta_cheques", Value = objEmpleado.cta_cheques });
                parameters.Add(new SqlParameter() { ParameterName = "fuente", Value = objEmpleado.fuente });
                parameters.Add(new SqlParameter() { ParameterName = "tarjeta", Value = objEmpleado.tarjeta });
                parameters.Add(new SqlParameter() { ParameterName = "destajos", Value = objEmpleado.destajos });
                parameters.Add(new SqlParameter() { ParameterName = "turno", Value = objEmpleado.turno });
                parameters.Add(new SqlParameter() { ParameterName = "expediente", Value = objEmpleado.expediente });
                parameters.Add(new SqlParameter() { ParameterName = "infonavit", Value = objEmpleado.infonavit });
                parameters.Add(new SqlParameter() { ParameterName = "tipo_pago_infonavit", Value = objEmpleado.tipo_pago_infonavit });
                parameters.Add(new SqlParameter() { ParameterName = "factor", Value = objEmpleado.factor });
                parameters.Add(new SqlParameter() { ParameterName = "clabe", Value = objEmpleado.clabe });
                parameters.Add(new SqlParameter() { ParameterName = "banco_alt", Value = objEmpleado.banco_alt });
                parameters.Add(new SqlParameter() { ParameterName = "sucursal_alt", Value = objEmpleado.sucursal_alt });
                parameters.Add(new SqlParameter() { ParameterName = "cta_cheques_alt", Value = objEmpleado.cta_cheques_alt });
                parameters.Add(new SqlParameter() { ParameterName = "clabe_alt", Value = objEmpleado.clabe_alt });
                parameters.Add(new SqlParameter() { ParameterName = "tarjeta_vales", Value = objEmpleado.tarjeta_vales });
                parameters.Add(new SqlParameter() { ParameterName = "path_firma", Value = objEmpleado.path_firma });
                parameters.Add(new SqlParameter() { ParameterName = "estatus", Value = objEmpleado.estatus });
                parameters.Add(new SqlParameter() { ParameterName = "estado_civil", Value = objEmpleado.estado_civil });
                parameters.Add(new SqlParameter() { ParameterName = "ip", Value = objEmpleado.ip });
                parameters.Add(new SqlParameter() { ParameterName = "mac_address", Value = objEmpleado.mac_address });
                parameters.Add(new SqlParameter() { ParameterName = "usuario", Value = objEmpleado.usuario });
                parameters.Add(new SqlParameter() { ParameterName = "tarjeta_vales_ant", Value = objEmpleado.tarjeta_vales_ant });
                parameters.Add(new SqlParameter() { ParameterName = "Correo", Value = objEmpleado.Correo });
                parameters.Add(new SqlParameter() { ParameterName = "Tarjeta_VGasolina", Value = objEmpleado.Tarjeta_VGasolina });
                parameters.Add(new SqlParameter() { ParameterName = "entidadLaboral", Value = objEmpleado.entidadLaboral });
                


                using (dataReader = this.connection.ExcuteSP("prc_Empleados_Insert_SoluGlob", parameters))
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {                            
                            empleado.compania = dataReader.IsDBNull(dataReader.GetOrdinal("compania")) ? null : dataReader["compania"].ToString();                            
                            empleado.numEmpleado = dataReader.IsDBNull(dataReader.GetOrdinal("empleado")) ? null : dataReader["empleado"].ToString();
                            empleado.apellido_paterno = dataReader.IsDBNull(dataReader.GetOrdinal("apellido_paterno")) ? null : dataReader["apellido_paterno"].ToString();
                            empleado.apellido_materno = dataReader.IsDBNull(dataReader.GetOrdinal("apellido_materno")) ? null : dataReader["apellido_materno"].ToString();
                            empleado.nombres = dataReader.IsDBNull(dataReader.GetOrdinal("nombres")) ? null : dataReader["nombres"].ToString();
                            empleado.nombre = dataReader.IsDBNull(dataReader.GetOrdinal("nombre")) ? null : dataReader["nombre"].ToString();
                            empleado.path_foto = dataReader.IsDBNull(dataReader.GetOrdinal("path_foto")) ? null : dataReader["path_foto"].ToString();
                            empleado.rfc = dataReader.IsDBNull(dataReader.GetOrdinal("rfc")) ? null : dataReader["rfc"].ToString();
                            empleado.curp = dataReader.IsDBNull(dataReader.GetOrdinal("curp")) ? null : dataReader["curp"].ToString();
                            empleado.elector = dataReader.IsDBNull(dataReader.GetOrdinal("elector")) ? null : dataReader["elector"].ToString();
                            empleado.cartilla = dataReader.IsDBNull(dataReader.GetOrdinal("cartilla")) ? null : dataReader["cartilla"].ToString();
                            empleado.licencia = dataReader.IsDBNull(dataReader.GetOrdinal("licencia")) ? null : dataReader["licencia"].ToString();
                            empleado.numero_imss = dataReader.IsDBNull(dataReader.GetOrdinal("numero_imss")) ? null : dataReader["numero_imss"].ToString();
                            empleado.tipo_sangre = dataReader.IsDBNull(dataReader.GetOrdinal("tipo_sangre")) ? null : dataReader["tipo_sangre"].ToString();
                            empleado.sexo = dataReader.IsDBNull(dataReader.GetOrdinal("sexo")) ? default(Int16?) : Int16.Parse(dataReader["sexo"].ToString());
                            empleado.tratamiento = dataReader.IsDBNull(dataReader.GetOrdinal("tratamiento")) ? null : dataReader["tratamiento"].ToString();
                            empleado.nivel_estudio = dataReader.IsDBNull(dataReader.GetOrdinal("nivel_estudio")) ? null : dataReader["nivel_estudio"].ToString();
                            empleado.fecha_nac = dataReader.IsDBNull(dataReader.GetOrdinal("fecha_nac")) ? default(DateTime?) : DateTime.Parse(dataReader["fecha_nac"].ToString());
                            empleado.lugar_nac = dataReader.IsDBNull(dataReader.GetOrdinal("lugar_nac")) ? null : dataReader["lugar_nac"].ToString();
                            empleado.pais_nac = dataReader.IsDBNull(dataReader.GetOrdinal("pais_nac")) ? null : dataReader["pais_nac"].ToString();
                            empleado.estado_nac = dataReader.IsDBNull(dataReader.GetOrdinal("estado_nac")) ? null : dataReader["estado_nac"].ToString();
                            empleado.nombre_padre = dataReader.IsDBNull(dataReader.GetOrdinal("nombre_padre")) ? null : dataReader["nombre_padre"].ToString();
                            empleado.nombre_madre = dataReader.IsDBNull(dataReader.GetOrdinal("nombre_madre")) ? null : dataReader["nombre_madre"].ToString();
                            empleado.origen = dataReader.IsDBNull(dataReader.GetOrdinal("origen")) ? default(Int16?) : Int16.Parse(dataReader["origen"].ToString());
                            empleado.nacionalidad = dataReader.IsDBNull(dataReader.GetOrdinal("nacionalidad")) ? null : dataReader["nacionalidad"].ToString();
                            empleado.tipo_pago = dataReader.IsDBNull(dataReader.GetOrdinal("tipo_pago")) ? default(Int16?) : Int16.Parse(dataReader["tipo_pago"].ToString());
                            empleado.banco = dataReader.IsDBNull(dataReader.GetOrdinal("banco")) ? null : dataReader["banco"].ToString();
                            empleado.sucursal = dataReader.IsDBNull(dataReader.GetOrdinal("sucursal")) ? null : dataReader["sucursal"].ToString();
                            empleado.cta_cheques = dataReader.IsDBNull(dataReader.GetOrdinal("cta_cheques")) ? null : dataReader["cta_cheques"].ToString();
                            empleado.fuente = dataReader.IsDBNull(dataReader.GetOrdinal("fuente")) ? null : dataReader["fuente"].ToString();
                            empleado.tarjeta = dataReader.IsDBNull(dataReader.GetOrdinal("tarjeta")) ? default(Int16?) : Int16.Parse(dataReader["tarjeta"].ToString());
                            empleado.destajos = dataReader.IsDBNull(dataReader.GetOrdinal("destajos")) ? default(Int16?) : Int16.Parse(dataReader["destajos"].ToString());
                            empleado.turno = dataReader.IsDBNull(dataReader.GetOrdinal("turno")) ? null : dataReader["turno"].ToString();
                            empleado.expediente = dataReader.IsDBNull(dataReader.GetOrdinal("expediente")) ? null : dataReader["expediente"].ToString();
                            empleado.infonavit = dataReader.IsDBNull(dataReader.GetOrdinal("infonavit")) ? null : dataReader["infonavit"].ToString();
                            empleado.tipo_pago_infonavit = dataReader.IsDBNull(dataReader.GetOrdinal("tipo_pago_infonavit")) ? default(Int16?) : Int16.Parse(dataReader["tipo_pago_infonavit"].ToString());
                            empleado.factor = dataReader.IsDBNull(dataReader.GetOrdinal("factor")) ? default(Decimal?) : Decimal.Parse(dataReader["factor"].ToString());
                            empleado.clabe = dataReader.IsDBNull(dataReader.GetOrdinal("clabe")) ? null : dataReader["clabe"].ToString();
                            empleado.banco_alt = dataReader.IsDBNull(dataReader.GetOrdinal("banco_alt")) ? null : dataReader["banco_alt"].ToString();
                            empleado.sucursal_alt = dataReader.IsDBNull(dataReader.GetOrdinal("sucursal_alt")) ? null : dataReader["sucursal_alt"].ToString();
                            empleado.cta_cheques_alt = dataReader.IsDBNull(dataReader.GetOrdinal("cta_cheques_alt")) ? null : dataReader["cta_cheques_alt"].ToString();
                            empleado.clabe_alt = dataReader.IsDBNull(dataReader.GetOrdinal("clabe_alt")) ? null : dataReader["clabe_alt"].ToString();
                            empleado.tarjeta_vales = dataReader.IsDBNull(dataReader.GetOrdinal("tarjeta_vales")) ? null : dataReader["tarjeta_vales"].ToString();
                            empleado.path_firma = dataReader.IsDBNull(dataReader.GetOrdinal("path_firma")) ? null : dataReader["path_firma"].ToString();
                            empleado.estatus = dataReader.IsDBNull(dataReader.GetOrdinal("estatus")) ? null : dataReader["estatus"].ToString();
                            empleado.estado_civil = dataReader.IsDBNull(dataReader.GetOrdinal("estado_civil")) ? default(Int16?) : Int16.Parse(dataReader["estado_civil"].ToString());
                            empleado.ip = dataReader.IsDBNull(dataReader.GetOrdinal("ip")) ? null : dataReader["ip"].ToString();
                            empleado.mac_address = dataReader.IsDBNull(dataReader.GetOrdinal("mac_address")) ? null : dataReader["mac_address"].ToString();
                            empleado.usuario = dataReader.IsDBNull(dataReader.GetOrdinal("usuario")) ? null : dataReader["usuario"].ToString();
                            empleado.tarjeta_vales_ant = dataReader.IsDBNull(dataReader.GetOrdinal("tarjeta_vales_ant")) ? null : dataReader["tarjeta_vales_ant"].ToString();
                            empleado.Correo = dataReader.IsDBNull(dataReader.GetOrdinal("Correo")) ? null : dataReader["Correo"].ToString();
                            empleado.Tarjeta_VGasolina = dataReader.IsDBNull(dataReader.GetOrdinal("Tarjeta_VGasolina")) ? null : dataReader["Tarjeta_VGasolina"].ToString();
                            empleado.entidadLaboral = dataReader.IsDBNull(dataReader.GetOrdinal("entidadLaboral")) ? null : dataReader["entidadLaboral"].ToString();

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

        public Entities.Kaizen.Empleados.Empleado GetOne(string Compania, string NumEmpleado)
        {
            empleado = new Entities.Kaizen.Empleados.Empleado();

            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter() { ParameterName = "compania", Value = Compania });
                parameters.Add(new SqlParameter() { ParameterName = "empleado", Value = NumEmpleado });

                using (dataReader = this.connection.ExcuteSP("prc_Empleados_GetOne_SoluGlob", parameters))
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            empleado.compania = dataReader.IsDBNull(dataReader.GetOrdinal("compania")) ? null : dataReader["compania"].ToString();
                            empleado.numEmpleado = dataReader.IsDBNull(dataReader.GetOrdinal("empleado")) ? null : dataReader["empleado"].ToString();
                            empleado.apellido_paterno = dataReader.IsDBNull(dataReader.GetOrdinal("apellido_paterno")) ? null : dataReader["apellido_paterno"].ToString();
                            empleado.apellido_materno = dataReader.IsDBNull(dataReader.GetOrdinal("apellido_materno")) ? null : dataReader["apellido_materno"].ToString();
                            empleado.nombres = dataReader.IsDBNull(dataReader.GetOrdinal("nombres")) ? null : dataReader["nombres"].ToString();
                            empleado.nombre = dataReader.IsDBNull(dataReader.GetOrdinal("nombre")) ? null : dataReader["nombre"].ToString();
                            empleado.path_foto = dataReader.IsDBNull(dataReader.GetOrdinal("path_foto")) ? null : dataReader["path_foto"].ToString();
                            empleado.rfc = dataReader.IsDBNull(dataReader.GetOrdinal("rfc")) ? null : dataReader["rfc"].ToString();
                            empleado.curp = dataReader.IsDBNull(dataReader.GetOrdinal("curp")) ? null : dataReader["curp"].ToString();
                            empleado.elector = dataReader.IsDBNull(dataReader.GetOrdinal("elector")) ? null : dataReader["elector"].ToString();
                            empleado.cartilla = dataReader.IsDBNull(dataReader.GetOrdinal("cartilla")) ? null : dataReader["cartilla"].ToString();
                            empleado.licencia = dataReader.IsDBNull(dataReader.GetOrdinal("licencia")) ? null : dataReader["licencia"].ToString();
                            empleado.numero_imss = dataReader.IsDBNull(dataReader.GetOrdinal("numero_imss")) ? null : dataReader["numero_imss"].ToString();
                            empleado.tipo_sangre = dataReader.IsDBNull(dataReader.GetOrdinal("tipo_sangre")) ? null : dataReader["tipo_sangre"].ToString();
                            empleado.sexo = dataReader.IsDBNull(dataReader.GetOrdinal("sexo")) ? default(Int16?) : Int16.Parse(dataReader["sexo"].ToString());
                            empleado.tratamiento = dataReader.IsDBNull(dataReader.GetOrdinal("tratamiento")) ? null : dataReader["tratamiento"].ToString();
                            empleado.nivel_estudio = dataReader.IsDBNull(dataReader.GetOrdinal("nivel_estudio")) ? null : dataReader["nivel_estudio"].ToString();
                            empleado.fecha_nac = dataReader.IsDBNull(dataReader.GetOrdinal("fecha_nac")) ? default(DateTime?) : DateTime.Parse(dataReader["fecha_nac"].ToString());
                            empleado.lugar_nac = dataReader.IsDBNull(dataReader.GetOrdinal("lugar_nac")) ? null : dataReader["lugar_nac"].ToString();
                            empleado.pais_nac = dataReader.IsDBNull(dataReader.GetOrdinal("pais_nac")) ? null : dataReader["pais_nac"].ToString();
                            empleado.estado_nac = dataReader.IsDBNull(dataReader.GetOrdinal("estado_nac")) ? null : dataReader["estado_nac"].ToString();
                            empleado.nombre_padre = dataReader.IsDBNull(dataReader.GetOrdinal("nombre_padre")) ? null : dataReader["nombre_padre"].ToString();
                            empleado.nombre_madre = dataReader.IsDBNull(dataReader.GetOrdinal("nombre_madre")) ? null : dataReader["nombre_madre"].ToString();
                            empleado.origen = dataReader.IsDBNull(dataReader.GetOrdinal("origen")) ? default(Int16?) : Int16.Parse(dataReader["origen"].ToString());
                            empleado.nacionalidad = dataReader.IsDBNull(dataReader.GetOrdinal("nacionalidad")) ? null : dataReader["nacionalidad"].ToString();
                            empleado.tipo_pago = dataReader.IsDBNull(dataReader.GetOrdinal("tipo_pago")) ? default(Int16?) : Int16.Parse(dataReader["tipo_pago"].ToString());
                            empleado.banco = dataReader.IsDBNull(dataReader.GetOrdinal("banco")) ? null : dataReader["banco"].ToString();
                            empleado.sucursal = dataReader.IsDBNull(dataReader.GetOrdinal("sucursal")) ? null : dataReader["sucursal"].ToString();
                            empleado.cta_cheques = dataReader.IsDBNull(dataReader.GetOrdinal("cta_cheques")) ? null : dataReader["cta_cheques"].ToString();
                            empleado.fuente = dataReader.IsDBNull(dataReader.GetOrdinal("fuente")) ? null : dataReader["fuente"].ToString();
                            empleado.tarjeta = dataReader.IsDBNull(dataReader.GetOrdinal("tarjeta")) ? default(Int16?) : Int16.Parse(dataReader["tarjeta"].ToString());
                            empleado.destajos = dataReader.IsDBNull(dataReader.GetOrdinal("destajos")) ? default(Int16?) : Int16.Parse(dataReader["destajos"].ToString());
                            empleado.turno = dataReader.IsDBNull(dataReader.GetOrdinal("turno")) ? null : dataReader["turno"].ToString();
                            empleado.expediente = dataReader.IsDBNull(dataReader.GetOrdinal("expediente")) ? null : dataReader["expediente"].ToString();
                            empleado.infonavit = dataReader.IsDBNull(dataReader.GetOrdinal("infonavit")) ? null : dataReader["infonavit"].ToString();
                            empleado.tipo_pago_infonavit = dataReader.IsDBNull(dataReader.GetOrdinal("tipo_pago_infonavit")) ? default(Int16?) : Int16.Parse(dataReader["tipo_pago_infonavit"].ToString());
                            empleado.factor = dataReader.IsDBNull(dataReader.GetOrdinal("factor")) ? default(Decimal?) : Decimal.Parse(dataReader["factor"].ToString());
                            empleado.clabe = dataReader.IsDBNull(dataReader.GetOrdinal("clabe")) ? null : dataReader["clabe"].ToString();
                            empleado.banco_alt = dataReader.IsDBNull(dataReader.GetOrdinal("banco_alt")) ? null : dataReader["banco_alt"].ToString();
                            empleado.sucursal_alt = dataReader.IsDBNull(dataReader.GetOrdinal("sucursal_alt")) ? null : dataReader["sucursal_alt"].ToString();
                            empleado.cta_cheques_alt = dataReader.IsDBNull(dataReader.GetOrdinal("cta_cheques_alt")) ? null : dataReader["cta_cheques_alt"].ToString();
                            empleado.clabe_alt = dataReader.IsDBNull(dataReader.GetOrdinal("clabe_alt")) ? null : dataReader["clabe_alt"].ToString();
                            empleado.tarjeta_vales = dataReader.IsDBNull(dataReader.GetOrdinal("tarjeta_vales")) ? null : dataReader["tarjeta_vales"].ToString();
                            empleado.path_firma = dataReader.IsDBNull(dataReader.GetOrdinal("path_firma")) ? null : dataReader["path_firma"].ToString();
                            empleado.estatus = dataReader.IsDBNull(dataReader.GetOrdinal("estatus")) ? null : dataReader["estatus"].ToString();
                            empleado.estado_civil = dataReader.IsDBNull(dataReader.GetOrdinal("estado_civil")) ? default(Int16?) : Int16.Parse(dataReader["estado_civil"].ToString());
                            empleado.ip = dataReader.IsDBNull(dataReader.GetOrdinal("ip")) ? null : dataReader["ip"].ToString();
                            empleado.mac_address = dataReader.IsDBNull(dataReader.GetOrdinal("mac_address")) ? null : dataReader["mac_address"].ToString();
                            empleado.usuario = dataReader.IsDBNull(dataReader.GetOrdinal("usuario")) ? null : dataReader["usuario"].ToString();
                            empleado.tarjeta_vales_ant = dataReader.IsDBNull(dataReader.GetOrdinal("tarjeta_vales_ant")) ? null : dataReader["tarjeta_vales_ant"].ToString();
                            empleado.Correo = dataReader.IsDBNull(dataReader.GetOrdinal("Correo")) ? null : dataReader["Correo"].ToString();
                            empleado.Tarjeta_VGasolina = dataReader.IsDBNull(dataReader.GetOrdinal("Tarjeta_VGasolina")) ? null : dataReader["Tarjeta_VGasolina"].ToString();
                            empleado.entidadLaboral = dataReader.IsDBNull(dataReader.GetOrdinal("entidadLaboral")) ? null : dataReader["entidadLaboral"].ToString();

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

        public List<Entities.Kaizen.Empleados.Empleado> GetAll()
        {
            empleadoCollection = new List<Entities.Kaizen.Empleados.Empleado>();
            try
            {
                dataReader = this.connection.ExcuteSP("prc_Empleados_GetAll_SoluGlob", null);

                while (dataReader.Read())
                {
                    empleado = new Entities.Kaizen.Empleados.Empleado();   
                    empleado.compania = dataReader.IsDBNull(dataReader.GetOrdinal("compania")) ? null : dataReader["compania"].ToString();
                    empleado.numEmpleado = dataReader.IsDBNull(dataReader.GetOrdinal("empleado")) ? null : dataReader["empleado"].ToString();                    
                    empleado.apellido_paterno = dataReader.IsDBNull(dataReader.GetOrdinal("apellido_paterno")) ? null : dataReader["apellido_paterno"].ToString();
                    empleado.apellido_materno = dataReader.IsDBNull(dataReader.GetOrdinal("apellido_materno")) ? null : dataReader["apellido_materno"].ToString();
                    empleado.nombres = dataReader.IsDBNull(dataReader.GetOrdinal("nombres")) ? null : dataReader["nombres"].ToString();
                    empleado.nombre = dataReader.IsDBNull(dataReader.GetOrdinal("nombre")) ? null : dataReader["nombre"].ToString();
                    empleado.path_foto = dataReader.IsDBNull(dataReader.GetOrdinal("path_foto")) ? null : dataReader["path_foto"].ToString();
                    empleado.rfc = dataReader.IsDBNull(dataReader.GetOrdinal("rfc")) ? null : dataReader["rfc"].ToString();
                    empleado.curp = dataReader.IsDBNull(dataReader.GetOrdinal("curp")) ? null : dataReader["curp"].ToString();
                    empleado.elector = dataReader.IsDBNull(dataReader.GetOrdinal("elector")) ? null : dataReader["elector"].ToString();
                    empleado.cartilla = dataReader.IsDBNull(dataReader.GetOrdinal("cartilla")) ? null : dataReader["cartilla"].ToString();
                    empleado.licencia = dataReader.IsDBNull(dataReader.GetOrdinal("licencia")) ? null : dataReader["licencia"].ToString();
                    empleado.numero_imss = dataReader.IsDBNull(dataReader.GetOrdinal("numero_imss")) ? null : dataReader["numero_imss"].ToString();
                    empleado.tipo_sangre = dataReader.IsDBNull(dataReader.GetOrdinal("tipo_sangre")) ? null : dataReader["tipo_sangre"].ToString();
                    empleado.sexo = dataReader.IsDBNull(dataReader.GetOrdinal("sexo")) ? default(Int16?) : Int16.Parse(dataReader["sexo"].ToString());
                    empleado.tratamiento = dataReader.IsDBNull(dataReader.GetOrdinal("tratamiento")) ? null : dataReader["tratamiento"].ToString();
                    empleado.nivel_estudio = dataReader.IsDBNull(dataReader.GetOrdinal("nivel_estudio")) ? null : dataReader["nivel_estudio"].ToString();
                    empleado.fecha_nac = dataReader.IsDBNull(dataReader.GetOrdinal("fecha_nac")) ? default(DateTime?) : DateTime.Parse(dataReader["fecha_nac"].ToString());
                    empleado.lugar_nac = dataReader.IsDBNull(dataReader.GetOrdinal("lugar_nac")) ? null : dataReader["lugar_nac"].ToString();
                    empleado.pais_nac = dataReader.IsDBNull(dataReader.GetOrdinal("pais_nac")) ? null : dataReader["pais_nac"].ToString();
                    empleado.estado_nac = dataReader.IsDBNull(dataReader.GetOrdinal("estado_nac")) ? null : dataReader["estado_nac"].ToString();
                    empleado.nombre_padre = dataReader.IsDBNull(dataReader.GetOrdinal("nombre_padre")) ? null : dataReader["nombre_padre"].ToString();
                    empleado.nombre_madre = dataReader.IsDBNull(dataReader.GetOrdinal("nombre_madre")) ? null : dataReader["nombre_madre"].ToString();
                    empleado.origen = dataReader.IsDBNull(dataReader.GetOrdinal("origen")) ? default(Int16?) : Int16.Parse(dataReader["origen"].ToString());
                    empleado.nacionalidad = dataReader.IsDBNull(dataReader.GetOrdinal("nacionalidad")) ? null : dataReader["nacionalidad"].ToString();
                    empleado.tipo_pago = dataReader.IsDBNull(dataReader.GetOrdinal("tipo_pago")) ? default(Int16?) : Int16.Parse(dataReader["tipo_pago"].ToString());
                    empleado.banco = dataReader.IsDBNull(dataReader.GetOrdinal("banco")) ? null : dataReader["banco"].ToString();
                    empleado.sucursal = dataReader.IsDBNull(dataReader.GetOrdinal("sucursal")) ? null : dataReader["sucursal"].ToString();
                    empleado.cta_cheques = dataReader.IsDBNull(dataReader.GetOrdinal("cta_cheques")) ? null : dataReader["cta_cheques"].ToString();
                    empleado.fuente = dataReader.IsDBNull(dataReader.GetOrdinal("fuente")) ? null : dataReader["fuente"].ToString();
                    empleado.tarjeta = dataReader.IsDBNull(dataReader.GetOrdinal("tarjeta")) ? default(Int16?) : Int16.Parse(dataReader["tarjeta"].ToString());
                    empleado.destajos = dataReader.IsDBNull(dataReader.GetOrdinal("destajos")) ? default(Int16?) : Int16.Parse(dataReader["destajos"].ToString());
                    empleado.turno = dataReader.IsDBNull(dataReader.GetOrdinal("turno")) ? null : dataReader["turno"].ToString();
                    empleado.expediente = dataReader.IsDBNull(dataReader.GetOrdinal("expediente")) ? null : dataReader["expediente"].ToString();
                    empleado.infonavit = dataReader.IsDBNull(dataReader.GetOrdinal("infonavit")) ? null : dataReader["infonavit"].ToString();
                    empleado.tipo_pago_infonavit = dataReader.IsDBNull(dataReader.GetOrdinal("tipo_pago_infonavit")) ? default(Int16?) : Int16.Parse(dataReader["tipo_pago_infonavit"].ToString());
                    empleado.factor = dataReader.IsDBNull(dataReader.GetOrdinal("factor")) ? default(Decimal?) : Decimal.Parse(dataReader["factor"].ToString());
                    empleado.clabe = dataReader.IsDBNull(dataReader.GetOrdinal("clabe")) ? null : dataReader["clabe"].ToString();
                    empleado.banco_alt = dataReader.IsDBNull(dataReader.GetOrdinal("banco_alt")) ? null : dataReader["banco_alt"].ToString();
                    empleado.sucursal_alt = dataReader.IsDBNull(dataReader.GetOrdinal("sucursal_alt")) ? null : dataReader["sucursal_alt"].ToString();
                    empleado.cta_cheques_alt = dataReader.IsDBNull(dataReader.GetOrdinal("cta_cheques_alt")) ? null : dataReader["cta_cheques_alt"].ToString();
                    empleado.clabe_alt = dataReader.IsDBNull(dataReader.GetOrdinal("clabe_alt")) ? null : dataReader["clabe_alt"].ToString();
                    empleado.tarjeta_vales = dataReader.IsDBNull(dataReader.GetOrdinal("tarjeta_vales")) ? null : dataReader["tarjeta_vales"].ToString();
                    empleado.path_firma = dataReader.IsDBNull(dataReader.GetOrdinal("path_firma")) ? null : dataReader["path_firma"].ToString();
                    empleado.estatus = dataReader.IsDBNull(dataReader.GetOrdinal("estatus")) ? null : dataReader["estatus"].ToString();
                    empleado.estado_civil = dataReader.IsDBNull(dataReader.GetOrdinal("estado_civil")) ? default(Int16?) : Int16.Parse(dataReader["estado_civil"].ToString());
                    empleado.ip = dataReader.IsDBNull(dataReader.GetOrdinal("ip")) ? null : dataReader["ip"].ToString();
                    empleado.mac_address = dataReader.IsDBNull(dataReader.GetOrdinal("mac_address")) ? null : dataReader["mac_address"].ToString();
                    empleado.usuario = dataReader.IsDBNull(dataReader.GetOrdinal("usuario")) ? null : dataReader["usuario"].ToString();
                    empleado.tarjeta_vales_ant = dataReader.IsDBNull(dataReader.GetOrdinal("tarjeta_vales_ant")) ? null : dataReader["tarjeta_vales_ant"].ToString();
                    empleado.Correo = dataReader.IsDBNull(dataReader.GetOrdinal("Correo")) ? null : dataReader["Correo"].ToString();
                    empleado.Tarjeta_VGasolina = dataReader.IsDBNull(dataReader.GetOrdinal("Tarjeta_VGasolina")) ? null : dataReader["Tarjeta_VGasolina"].ToString();
                    empleado.entidadLaboral = dataReader.IsDBNull(dataReader.GetOrdinal("entidadLaboral")) ? null : dataReader["entidadLaboral"].ToString();
                    empleadoCollection.Add(empleado);
                }
                dataReader.Close();
                dataReader.Dispose();

                return empleadoCollection;
            }
            catch (Exception ex)
            {
                
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message.ToString());
            }
        }

        public Entities.Kaizen.Empleados.Empleado Update(Entities.Kaizen.Empleados.Empleado objEmpleado)
        {
            empleado = new Entities.Kaizen.Empleados.Empleado();
            //StringBuilder sb = new StringBuilder();
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                parameters.Add(new SqlParameter() { ParameterName = "compania", Value = objEmpleado.compania });
                parameters.Add(new SqlParameter() { ParameterName = "empleado", Value = objEmpleado.numEmpleado });
                parameters.Add(new SqlParameter() { ParameterName = "apellido_paterno", Value = objEmpleado.apellido_paterno });
                parameters.Add(new SqlParameter() { ParameterName = "apellido_materno", Value = objEmpleado.apellido_materno });
                parameters.Add(new SqlParameter() { ParameterName = "nombres", Value = objEmpleado.nombres });
                parameters.Add(new SqlParameter() { ParameterName = "nombre", Value = objEmpleado.nombre });
                parameters.Add(new SqlParameter() { ParameterName = "path_foto", Value = objEmpleado.path_foto });
                parameters.Add(new SqlParameter() { ParameterName = "rfc", Value = objEmpleado.rfc });
                parameters.Add(new SqlParameter() { ParameterName = "curp", Value = objEmpleado.curp });
                parameters.Add(new SqlParameter() { ParameterName = "elector", Value = objEmpleado.elector });
                parameters.Add(new SqlParameter() { ParameterName = "cartilla", Value = objEmpleado.cartilla });
                parameters.Add(new SqlParameter() { ParameterName = "licencia", Value = objEmpleado.licencia });
                parameters.Add(new SqlParameter() { ParameterName = "numero_imss", Value = objEmpleado.numero_imss });
                parameters.Add(new SqlParameter() { ParameterName = "tipo_sangre", Value = objEmpleado.tipo_sangre });
                parameters.Add(new SqlParameter() { ParameterName = "sexo", Value = objEmpleado.sexo });
                parameters.Add(new SqlParameter() { ParameterName = "tratamiento", Value = objEmpleado.tratamiento });
                parameters.Add(new SqlParameter() { ParameterName = "nivel_estudio", Value = objEmpleado.nivel_estudio });
                parameters.Add(new SqlParameter() { ParameterName = "fecha_nac", Value = objEmpleado.fecha_nac });
                parameters.Add(new SqlParameter() { ParameterName = "lugar_nac", Value = objEmpleado.lugar_nac });
                parameters.Add(new SqlParameter() { ParameterName = "pais_nac", Value = objEmpleado.pais_nac });
                parameters.Add(new SqlParameter() { ParameterName = "estado_nac", Value = objEmpleado.estado_nac });
                parameters.Add(new SqlParameter() { ParameterName = "nombre_padre", Value = objEmpleado.nombre_padre });
                parameters.Add(new SqlParameter() { ParameterName = "nombre_madre", Value = objEmpleado.nombre_madre });
                parameters.Add(new SqlParameter() { ParameterName = "origen", Value = objEmpleado.origen });
                parameters.Add(new SqlParameter() { ParameterName = "nacionalidad", Value = objEmpleado.nacionalidad });
                parameters.Add(new SqlParameter() { ParameterName = "tipo_pago", Value = objEmpleado.tipo_pago });
                parameters.Add(new SqlParameter() { ParameterName = "banco", Value = objEmpleado.banco });
                parameters.Add(new SqlParameter() { ParameterName = "sucursal", Value = objEmpleado.sucursal });
                parameters.Add(new SqlParameter() { ParameterName = "cta_cheques", Value = objEmpleado.cta_cheques });
                parameters.Add(new SqlParameter() { ParameterName = "fuente", Value = objEmpleado.fuente });
                parameters.Add(new SqlParameter() { ParameterName = "tarjeta", Value = objEmpleado.tarjeta });
                parameters.Add(new SqlParameter() { ParameterName = "destajos", Value = objEmpleado.destajos });
                parameters.Add(new SqlParameter() { ParameterName = "turno", Value = objEmpleado.turno });
                parameters.Add(new SqlParameter() { ParameterName = "expediente", Value = objEmpleado.expediente });
                parameters.Add(new SqlParameter() { ParameterName = "infonavit", Value = objEmpleado.infonavit });
                parameters.Add(new SqlParameter() { ParameterName = "tipo_pago_infonavit", Value = objEmpleado.tipo_pago_infonavit });
                parameters.Add(new SqlParameter() { ParameterName = "factor", Value = objEmpleado.factor });
                parameters.Add(new SqlParameter() { ParameterName = "clabe", Value = objEmpleado.clabe });
                parameters.Add(new SqlParameter() { ParameterName = "banco_alt", Value = objEmpleado.banco_alt });
                parameters.Add(new SqlParameter() { ParameterName = "sucursal_alt", Value = objEmpleado.sucursal_alt });
                parameters.Add(new SqlParameter() { ParameterName = "cta_cheques_alt", Value = objEmpleado.cta_cheques_alt });
                parameters.Add(new SqlParameter() { ParameterName = "clabe_alt", Value = objEmpleado.clabe_alt });
                parameters.Add(new SqlParameter() { ParameterName = "tarjeta_vales", Value = objEmpleado.tarjeta_vales });
                parameters.Add(new SqlParameter() { ParameterName = "path_firma", Value = objEmpleado.path_firma });
                parameters.Add(new SqlParameter() { ParameterName = "estatus", Value = objEmpleado.estatus });
                parameters.Add(new SqlParameter() { ParameterName = "estado_civil", Value = objEmpleado.estado_civil });
                parameters.Add(new SqlParameter() { ParameterName = "ip", Value = objEmpleado.ip });
                parameters.Add(new SqlParameter() { ParameterName = "mac_address", Value = objEmpleado.mac_address });
                parameters.Add(new SqlParameter() { ParameterName = "usuario", Value = objEmpleado.usuario });
                parameters.Add(new SqlParameter() { ParameterName = "tarjeta_vales_ant", Value = objEmpleado.tarjeta_vales_ant });
                parameters.Add(new SqlParameter() { ParameterName = "Correo", Value = objEmpleado.Correo });
                parameters.Add(new SqlParameter() { ParameterName = "Tarjeta_VGasolina", Value = objEmpleado.Tarjeta_VGasolina });
                parameters.Add(new SqlParameter() { ParameterName = "entidadLaboral", Value = objEmpleado.entidadLaboral });

                using (dataReader = this.connection.ExcuteSP("prc_Empleados_Update_SoluGlob", parameters))
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            empleado.compania = dataReader.IsDBNull(dataReader.GetOrdinal("compania")) ? null : dataReader["compania"].ToString();
                            empleado.numEmpleado = dataReader.IsDBNull(dataReader.GetOrdinal("empleado")) ? null : dataReader["empleado"].ToString();
                            empleado.apellido_paterno = dataReader.IsDBNull(dataReader.GetOrdinal("apellido_paterno")) ? null : dataReader["apellido_paterno"].ToString();
                            empleado.apellido_materno = dataReader.IsDBNull(dataReader.GetOrdinal("apellido_materno")) ? null : dataReader["apellido_materno"].ToString();
                            empleado.nombres = dataReader.IsDBNull(dataReader.GetOrdinal("nombres")) ? null : dataReader["nombres"].ToString();
                            empleado.nombre = dataReader.IsDBNull(dataReader.GetOrdinal("nombre")) ? null : dataReader["nombre"].ToString();
                            empleado.path_foto = dataReader.IsDBNull(dataReader.GetOrdinal("path_foto")) ? null : dataReader["path_foto"].ToString();
                            empleado.rfc = dataReader.IsDBNull(dataReader.GetOrdinal("rfc")) ? null : dataReader["rfc"].ToString();
                            empleado.curp = dataReader.IsDBNull(dataReader.GetOrdinal("curp")) ? null : dataReader["curp"].ToString();
                            empleado.elector = dataReader.IsDBNull(dataReader.GetOrdinal("elector")) ? null : dataReader["elector"].ToString();
                            empleado.cartilla = dataReader.IsDBNull(dataReader.GetOrdinal("cartilla")) ? null : dataReader["cartilla"].ToString();
                            empleado.licencia = dataReader.IsDBNull(dataReader.GetOrdinal("licencia")) ? null : dataReader["licencia"].ToString();
                            empleado.numero_imss = dataReader.IsDBNull(dataReader.GetOrdinal("numero_imss")) ? null : dataReader["numero_imss"].ToString();
                            empleado.tipo_sangre = dataReader.IsDBNull(dataReader.GetOrdinal("tipo_sangre")) ? null : dataReader["tipo_sangre"].ToString();
                            empleado.sexo = dataReader.IsDBNull(dataReader.GetOrdinal("sexo")) ? default(Int16?) : Int16.Parse(dataReader["sexo"].ToString());
                            empleado.tratamiento = dataReader.IsDBNull(dataReader.GetOrdinal("tratamiento")) ? null : dataReader["tratamiento"].ToString();
                            empleado.nivel_estudio = dataReader.IsDBNull(dataReader.GetOrdinal("nivel_estudio")) ? null : dataReader["nivel_estudio"].ToString();
                            empleado.fecha_nac = dataReader.IsDBNull(dataReader.GetOrdinal("fecha_nac")) ? default(DateTime?) : DateTime.Parse(dataReader["fecha_nac"].ToString());
                            empleado.lugar_nac = dataReader.IsDBNull(dataReader.GetOrdinal("lugar_nac")) ? null : dataReader["lugar_nac"].ToString();
                            empleado.pais_nac = dataReader.IsDBNull(dataReader.GetOrdinal("pais_nac")) ? null : dataReader["pais_nac"].ToString();
                            empleado.estado_nac = dataReader.IsDBNull(dataReader.GetOrdinal("estado_nac")) ? null : dataReader["estado_nac"].ToString();
                            empleado.nombre_padre = dataReader.IsDBNull(dataReader.GetOrdinal("nombre_padre")) ? null : dataReader["nombre_padre"].ToString();
                            empleado.nombre_madre = dataReader.IsDBNull(dataReader.GetOrdinal("nombre_madre")) ? null : dataReader["nombre_madre"].ToString();
                            empleado.origen = dataReader.IsDBNull(dataReader.GetOrdinal("origen")) ? default(Int16?) : Int16.Parse(dataReader["origen"].ToString());
                            empleado.nacionalidad = dataReader.IsDBNull(dataReader.GetOrdinal("nacionalidad")) ? null : dataReader["nacionalidad"].ToString();
                            empleado.tipo_pago = dataReader.IsDBNull(dataReader.GetOrdinal("tipo_pago")) ? default(Int16?) : Int16.Parse(dataReader["tipo_pago"].ToString());
                            empleado.banco = dataReader.IsDBNull(dataReader.GetOrdinal("banco")) ? null : dataReader["banco"].ToString();
                            empleado.sucursal = dataReader.IsDBNull(dataReader.GetOrdinal("sucursal")) ? null : dataReader["sucursal"].ToString();
                            empleado.cta_cheques = dataReader.IsDBNull(dataReader.GetOrdinal("cta_cheques")) ? null : dataReader["cta_cheques"].ToString();
                            empleado.fuente = dataReader.IsDBNull(dataReader.GetOrdinal("fuente")) ? null : dataReader["fuente"].ToString();
                            empleado.tarjeta = dataReader.IsDBNull(dataReader.GetOrdinal("tarjeta")) ? default(Int16?) : Int16.Parse(dataReader["tarjeta"].ToString());
                            empleado.destajos = dataReader.IsDBNull(dataReader.GetOrdinal("destajos")) ? default(Int16?) : Int16.Parse(dataReader["destajos"].ToString());
                            empleado.turno = dataReader.IsDBNull(dataReader.GetOrdinal("turno")) ? null : dataReader["turno"].ToString();
                            empleado.expediente = dataReader.IsDBNull(dataReader.GetOrdinal("expediente")) ? null : dataReader["expediente"].ToString();
                            empleado.infonavit = dataReader.IsDBNull(dataReader.GetOrdinal("infonavit")) ? null : dataReader["infonavit"].ToString();
                            empleado.tipo_pago_infonavit = dataReader.IsDBNull(dataReader.GetOrdinal("tipo_pago_infonavit")) ? default(Int16?) : Int16.Parse(dataReader["tipo_pago_infonavit"].ToString());
                            empleado.factor = dataReader.IsDBNull(dataReader.GetOrdinal("factor")) ? default(Decimal?) : Decimal.Parse(dataReader["factor"].ToString());
                            empleado.clabe = dataReader.IsDBNull(dataReader.GetOrdinal("clabe")) ? null : dataReader["clabe"].ToString();
                            empleado.banco_alt = dataReader.IsDBNull(dataReader.GetOrdinal("banco_alt")) ? null : dataReader["banco_alt"].ToString();
                            empleado.sucursal_alt = dataReader.IsDBNull(dataReader.GetOrdinal("sucursal_alt")) ? null : dataReader["sucursal_alt"].ToString();
                            empleado.cta_cheques_alt = dataReader.IsDBNull(dataReader.GetOrdinal("cta_cheques_alt")) ? null : dataReader["cta_cheques_alt"].ToString();
                            empleado.clabe_alt = dataReader.IsDBNull(dataReader.GetOrdinal("clabe_alt")) ? null : dataReader["clabe_alt"].ToString();
                            empleado.tarjeta_vales = dataReader.IsDBNull(dataReader.GetOrdinal("tarjeta_vales")) ? null : dataReader["tarjeta_vales"].ToString();
                            empleado.path_firma = dataReader.IsDBNull(dataReader.GetOrdinal("path_firma")) ? null : dataReader["path_firma"].ToString();
                            empleado.estatus = dataReader.IsDBNull(dataReader.GetOrdinal("estatus")) ? null : dataReader["estatus"].ToString();
                            empleado.estado_civil = dataReader.IsDBNull(dataReader.GetOrdinal("estado_civil")) ? default(Int16?) : Int16.Parse(dataReader["estado_civil"].ToString());
                            empleado.ip = dataReader.IsDBNull(dataReader.GetOrdinal("ip")) ? null : dataReader["ip"].ToString();
                            empleado.mac_address = dataReader.IsDBNull(dataReader.GetOrdinal("mac_address")) ? null : dataReader["mac_address"].ToString();
                            empleado.usuario = dataReader.IsDBNull(dataReader.GetOrdinal("usuario")) ? null : dataReader["usuario"].ToString();
                            empleado.tarjeta_vales_ant = dataReader.IsDBNull(dataReader.GetOrdinal("tarjeta_vales_ant")) ? null : dataReader["tarjeta_vales_ant"].ToString();
                            empleado.Correo = dataReader.IsDBNull(dataReader.GetOrdinal("Correo")) ? null : dataReader["Correo"].ToString();
                            empleado.Tarjeta_VGasolina = dataReader.IsDBNull(dataReader.GetOrdinal("Tarjeta_VGasolina")) ? null : dataReader["Tarjeta_VGasolina"].ToString();
                            empleado.entidadLaboral = dataReader.IsDBNull(dataReader.GetOrdinal("entidadLaboral")) ? null : dataReader["entidadLaboral"].ToString();

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

        public void Delete(string Compania, string NumEmpleado)
        {
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter() { ParameterName = "compania", Value = Compania });
                parameters.Add(new SqlParameter() { ParameterName = "empleado", Value = NumEmpleado });

                this.connection.ExcuteScalar("prc_Empleados_Delete_SoluGlob", parameters);
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message);
            }
        }

        public void Drop(string Compania, string NumEmpleado)
        {
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter() { ParameterName = "compania", Value = Compania });
                parameters.Add(new SqlParameter() { ParameterName = "empleado", Value = NumEmpleado });

                this.connection.ExcuteScalar("prc_Empleados_Drop_SoluGlob", parameters);                
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message);
            }
        }

        public Entities.Kaizen.Empleados.Empleado BajaEmpleado(string compania, string numEmpleado, string motivo)
        {
            string status = string.Empty;
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter() { ParameterName = "compania", Value = compania });
                parameters.Add(new SqlParameter() { ParameterName = "empleado", Value = numEmpleado });
                parameters.Add(new SqlParameter() { ParameterName = "motivo", Value = motivo });

                using (dataReader = this.connection.ExcuteSP("prc_Empleados_Baja_SoluGlob", parameters))
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            empleado = new Entities.Kaizen.Empleados.Empleado();
                            empleado.compania = dataReader.IsDBNull(dataReader.GetOrdinal("compania")) ? null : dataReader["compania"].ToString();
                            empleado.numEmpleado = dataReader.IsDBNull(dataReader.GetOrdinal("empleado")) ? null : dataReader["empleado"].ToString();
                            empleado.apellido_paterno = dataReader.IsDBNull(dataReader.GetOrdinal("apellido_paterno")) ? null : dataReader["apellido_paterno"].ToString();
                            empleado.apellido_materno = dataReader.IsDBNull(dataReader.GetOrdinal("apellido_materno")) ? null : dataReader["apellido_materno"].ToString();
                            empleado.nombres = dataReader.IsDBNull(dataReader.GetOrdinal("nombres")) ? null : dataReader["nombres"].ToString();
                            empleado.nombre = dataReader.IsDBNull(dataReader.GetOrdinal("nombre")) ? null : dataReader["nombre"].ToString();
                            empleado.path_foto = dataReader.IsDBNull(dataReader.GetOrdinal("path_foto")) ? null : dataReader["path_foto"].ToString();
                            empleado.rfc = dataReader.IsDBNull(dataReader.GetOrdinal("rfc")) ? null : dataReader["rfc"].ToString();
                            empleado.curp = dataReader.IsDBNull(dataReader.GetOrdinal("curp")) ? null : dataReader["curp"].ToString();
                            empleado.elector = dataReader.IsDBNull(dataReader.GetOrdinal("elector")) ? null : dataReader["elector"].ToString();
                            empleado.cartilla = dataReader.IsDBNull(dataReader.GetOrdinal("cartilla")) ? null : dataReader["cartilla"].ToString();
                            empleado.licencia = dataReader.IsDBNull(dataReader.GetOrdinal("licencia")) ? null : dataReader["licencia"].ToString();
                            empleado.numero_imss = dataReader.IsDBNull(dataReader.GetOrdinal("numero_imss")) ? null : dataReader["numero_imss"].ToString();
                            empleado.tipo_sangre = dataReader.IsDBNull(dataReader.GetOrdinal("tipo_sangre")) ? null : dataReader["tipo_sangre"].ToString();
                            empleado.sexo = dataReader.IsDBNull(dataReader.GetOrdinal("sexo")) ? default(Int16?) : Int16.Parse(dataReader["sexo"].ToString());
                            empleado.tratamiento = dataReader.IsDBNull(dataReader.GetOrdinal("tratamiento")) ? null : dataReader["tratamiento"].ToString();
                            empleado.nivel_estudio = dataReader.IsDBNull(dataReader.GetOrdinal("nivel_estudio")) ? null : dataReader["nivel_estudio"].ToString();
                            empleado.fecha_nac = dataReader.IsDBNull(dataReader.GetOrdinal("fecha_nac")) ? default(DateTime?) : DateTime.Parse(dataReader["fecha_nac"].ToString());
                            empleado.lugar_nac = dataReader.IsDBNull(dataReader.GetOrdinal("lugar_nac")) ? null : dataReader["lugar_nac"].ToString();
                            empleado.pais_nac = dataReader.IsDBNull(dataReader.GetOrdinal("pais_nac")) ? null : dataReader["pais_nac"].ToString();
                            empleado.estado_nac = dataReader.IsDBNull(dataReader.GetOrdinal("estado_nac")) ? null : dataReader["estado_nac"].ToString();
                            empleado.nombre_padre = dataReader.IsDBNull(dataReader.GetOrdinal("nombre_padre")) ? null : dataReader["nombre_padre"].ToString();
                            empleado.nombre_madre = dataReader.IsDBNull(dataReader.GetOrdinal("nombre_madre")) ? null : dataReader["nombre_madre"].ToString();
                            empleado.origen = dataReader.IsDBNull(dataReader.GetOrdinal("origen")) ? default(Int16?) : Int16.Parse(dataReader["origen"].ToString());
                            empleado.nacionalidad = dataReader.IsDBNull(dataReader.GetOrdinal("nacionalidad")) ? null : dataReader["nacionalidad"].ToString();
                            empleado.tipo_pago = dataReader.IsDBNull(dataReader.GetOrdinal("tipo_pago")) ? default(Int16?) : Int16.Parse(dataReader["tipo_pago"].ToString());
                            empleado.banco = dataReader.IsDBNull(dataReader.GetOrdinal("banco")) ? null : dataReader["banco"].ToString();
                            empleado.sucursal = dataReader.IsDBNull(dataReader.GetOrdinal("sucursal")) ? null : dataReader["sucursal"].ToString();
                            empleado.cta_cheques = dataReader.IsDBNull(dataReader.GetOrdinal("cta_cheques")) ? null : dataReader["cta_cheques"].ToString();
                            empleado.fuente = dataReader.IsDBNull(dataReader.GetOrdinal("fuente")) ? null : dataReader["fuente"].ToString();
                            empleado.tarjeta = dataReader.IsDBNull(dataReader.GetOrdinal("tarjeta")) ? default(Int16?) : Int16.Parse(dataReader["tarjeta"].ToString());
                            empleado.destajos = dataReader.IsDBNull(dataReader.GetOrdinal("destajos")) ? default(Int16?) : Int16.Parse(dataReader["destajos"].ToString());
                            empleado.turno = dataReader.IsDBNull(dataReader.GetOrdinal("turno")) ? null : dataReader["turno"].ToString();
                            empleado.expediente = dataReader.IsDBNull(dataReader.GetOrdinal("expediente")) ? null : dataReader["expediente"].ToString();
                            empleado.infonavit = dataReader.IsDBNull(dataReader.GetOrdinal("infonavit")) ? null : dataReader["infonavit"].ToString();
                            empleado.tipo_pago_infonavit = dataReader.IsDBNull(dataReader.GetOrdinal("tipo_pago_infonavit")) ? default(Int16?) : Int16.Parse(dataReader["tipo_pago_infonavit"].ToString());
                            empleado.factor = dataReader.IsDBNull(dataReader.GetOrdinal("factor")) ? default(Decimal?) : Decimal.Parse(dataReader["factor"].ToString());
                            empleado.clabe = dataReader.IsDBNull(dataReader.GetOrdinal("clabe")) ? null : dataReader["clabe"].ToString();
                            empleado.banco_alt = dataReader.IsDBNull(dataReader.GetOrdinal("banco_alt")) ? null : dataReader["banco_alt"].ToString();
                            empleado.sucursal_alt = dataReader.IsDBNull(dataReader.GetOrdinal("sucursal_alt")) ? null : dataReader["sucursal_alt"].ToString();
                            empleado.cta_cheques_alt = dataReader.IsDBNull(dataReader.GetOrdinal("cta_cheques_alt")) ? null : dataReader["cta_cheques_alt"].ToString();
                            empleado.clabe_alt = dataReader.IsDBNull(dataReader.GetOrdinal("clabe_alt")) ? null : dataReader["clabe_alt"].ToString();
                            empleado.tarjeta_vales = dataReader.IsDBNull(dataReader.GetOrdinal("tarjeta_vales")) ? null : dataReader["tarjeta_vales"].ToString();
                            empleado.path_firma = dataReader.IsDBNull(dataReader.GetOrdinal("path_firma")) ? null : dataReader["path_firma"].ToString();
                            empleado.estatus = dataReader.IsDBNull(dataReader.GetOrdinal("estatus")) ? null : dataReader["estatus"].ToString();
                            empleado.estado_civil = dataReader.IsDBNull(dataReader.GetOrdinal("estado_civil")) ? default(Int16?) : Int16.Parse(dataReader["estado_civil"].ToString());
                            empleado.ip = dataReader.IsDBNull(dataReader.GetOrdinal("ip")) ? null : dataReader["ip"].ToString();
                            empleado.mac_address = dataReader.IsDBNull(dataReader.GetOrdinal("mac_address")) ? null : dataReader["mac_address"].ToString();
                            empleado.usuario = dataReader.IsDBNull(dataReader.GetOrdinal("usuario")) ? null : dataReader["usuario"].ToString();
                            empleado.tarjeta_vales_ant = dataReader.IsDBNull(dataReader.GetOrdinal("tarjeta_vales_ant")) ? null : dataReader["tarjeta_vales_ant"].ToString();
                            empleado.Correo = dataReader.IsDBNull(dataReader.GetOrdinal("Correo")) ? null : dataReader["Correo"].ToString();
                            empleado.Tarjeta_VGasolina = dataReader.IsDBNull(dataReader.GetOrdinal("Tarjeta_VGasolina")) ? null : dataReader["Tarjeta_VGasolina"].ToString();
                            empleado.entidadLaboral = dataReader.IsDBNull(dataReader.GetOrdinal("entidadLaboral")) ? null : dataReader["entidadLaboral"].ToString();
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


    }
}
