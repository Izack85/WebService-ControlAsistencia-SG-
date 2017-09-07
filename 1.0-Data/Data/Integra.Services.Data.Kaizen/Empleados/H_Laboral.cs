using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integra.Services.Data.Kaizen.Empleados
{
    public class H_Laboral
    {
        List<Entities.Kaizen.Empleados.H_Laboral> h_laboralCollection = null;
        Entities.Kaizen.Empleados.H_Laboral h_laboral = null;
        SqlDataReader dataReader = null;

        public Connection connection = null;

        public H_Laboral()
        {
            this.connection = Connection.Instance;
        }
        public H_Laboral(bool isTransaction)
        {
            this.connection = new Connection();
        }
        public H_Laboral(Connection connection)
        {
            this.connection = connection;
        }

        public Entities.Kaizen.Empleados.H_Laboral Insert(Entities.Kaizen.Empleados.H_Laboral objH_Laboral)
        {
            h_laboral = new Entities.Kaizen.Empleados.H_Laboral();
            //StringBuilder sb = new StringBuilder();
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                parameters.Add(new SqlParameter() { ParameterName = "Compania", Value = objH_Laboral.Compania });
                parameters.Add(new SqlParameter() { ParameterName = "companiaPasajes", Value = objH_Laboral.companiaPasajes });
                parameters.Add(new SqlParameter() { ParameterName = "Empleado", Value = objH_Laboral.numEmpleado });
                parameters.Add(new SqlParameter() { ParameterName = "Fecha", Value = objH_Laboral.Fecha });
                parameters.Add(new SqlParameter() { ParameterName = "Sec", Value = objH_Laboral.Sec });
                parameters.Add(new SqlParameter() { ParameterName = "Accion", Value = objH_Laboral.Accion });
                parameters.Add(new SqlParameter() { ParameterName = "Motivo", Value = objH_Laboral.Motivo });
                parameters.Add(new SqlParameter() { ParameterName = "Grupo_Pago", Value = objH_Laboral.Grupo_Pago });
                parameters.Add(new SqlParameter() { ParameterName = "Grupo_Pago_Pasajes", Value = objH_Laboral.Grupo_Pago_Pasajes });
                parameters.Add(new SqlParameter() { ParameterName = "Tipo_Contrato", Value = objH_Laboral.Tipo_Contrato });
                parameters.Add(new SqlParameter() { ParameterName = "Fecha_Ingreso", Value = objH_Laboral.Fecha_Ingreso });
                parameters.Add(new SqlParameter() { ParameterName = "Fecha_Antiguedad1", Value = objH_Laboral.Fecha_Antiguedad1 });
                parameters.Add(new SqlParameter() { ParameterName = "Fecha_Antiguedad2", Value = objH_Laboral.Fecha_Antiguedad2 });
                parameters.Add(new SqlParameter() { ParameterName = "Fecha_Antiguedad3", Value = objH_Laboral.Fecha_Antiguedad3 });
                parameters.Add(new SqlParameter() { ParameterName = "Duracion", Value = objH_Laboral.Duracion });
                parameters.Add(new SqlParameter() { ParameterName = "Fecha_Vento", Value = objH_Laboral.Fecha_Vento });
                parameters.Add(new SqlParameter() { ParameterName = "Fecha_Baja", Value = objH_Laboral.Fecha_Baja });
                parameters.Add(new SqlParameter() { ParameterName = "Tipo_Salario", Value = objH_Laboral.Tipo_Salario });
                parameters.Add(new SqlParameter() { ParameterName = "Tipo_Empleado", Value = objH_Laboral.Tipo_Empleado });
                parameters.Add(new SqlParameter() { ParameterName = "Localidad", Value = objH_Laboral.Localidad });
                parameters.Add(new SqlParameter() { ParameterName = "Departamento", Value = objH_Laboral.Departamento });
                parameters.Add(new SqlParameter() { ParameterName = "Puesto", Value = objH_Laboral.Puesto });
                parameters.Add(new SqlParameter() { ParameterName = "Dependencia", Value = objH_Laboral.Dependencia });
                parameters.Add(new SqlParameter() { ParameterName = "Cliente", Value = objH_Laboral.Cliente });
                parameters.Add(new SqlParameter() { ParameterName = "Tipo_De_Operacion", Value = objH_Laboral.Tipo_De_Operacion });
                parameters.Add(new SqlParameter() { ParameterName = "Region", Value = objH_Laboral.Region });
                parameters.Add(new SqlParameter() { ParameterName = "Sector", Value = objH_Laboral.Sector });
                parameters.Add(new SqlParameter() { ParameterName = "Usuario", Value = objH_Laboral.Usuario });
                parameters.Add(new SqlParameter() { ParameterName = "Sindicalizado", Value = objH_Laboral.Sindicalizado });
                parameters.Add(new SqlParameter() { ParameterName = "Ip", Value = objH_Laboral.Ip });
                parameters.Add(new SqlParameter() { ParameterName = "Mac_Address", Value = objH_Laboral.Mac_Address });

                using (dataReader = this.connection.ExcuteSP("prc_H_Laboral_Insert_SoluGlob", parameters))
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            h_laboral.Compania = dataReader.IsDBNull(dataReader.GetOrdinal("Compania")) ? null : dataReader["Compania"].ToString();
                            h_laboral.numEmpleado = dataReader.IsDBNull(dataReader.GetOrdinal("Empleado")) ? null : dataReader["Empleado"].ToString();
                            h_laboral.Fecha = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha")) ? default(DateTime) : DateTime.Parse(dataReader["Fecha"].ToString());
                            h_laboral.Sec = dataReader.IsDBNull(dataReader.GetOrdinal("Sec")) ? default(Int16) : Int16.Parse(dataReader["Sec"].ToString());
                            h_laboral.Accion = dataReader.IsDBNull(dataReader.GetOrdinal("Accion")) ? null : dataReader["Accion"].ToString();
                            h_laboral.Motivo = dataReader.IsDBNull(dataReader.GetOrdinal("Motivo")) ? null : dataReader["Motivo"].ToString();
                            h_laboral.Grupo_Pago = dataReader.IsDBNull(dataReader.GetOrdinal("Grupo_Pago")) ? null : dataReader["Grupo_Pago"].ToString();
                            h_laboral.Tipo_Contrato = dataReader.IsDBNull(dataReader.GetOrdinal("Tipo_Contrato")) ? default(Int16) : Int16.Parse(dataReader["Tipo_Contrato"].ToString());
                            h_laboral.Fecha_Ingreso = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Ingreso")) ? default(DateTime) : DateTime.Parse(dataReader["Fecha_Ingreso"].ToString());
                            h_laboral.Fecha_Antiguedad1 = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Antiguedad1")) ? default(DateTime) : DateTime.Parse(dataReader["Fecha_Antiguedad1"].ToString());
                            h_laboral.Fecha_Antiguedad2 = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Antiguedad2")) ? default(DateTime) : DateTime.Parse(dataReader["Fecha_Antiguedad2"].ToString());
                            h_laboral.Fecha_Antiguedad3 = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Antiguedad3")) ? default(DateTime) : DateTime.Parse(dataReader["Fecha_Antiguedad3"].ToString());
                            h_laboral.Duracion = dataReader.IsDBNull(dataReader.GetOrdinal("Duracion")) ? default(Int16) : Int16.Parse(dataReader["Duracion"].ToString());
                            h_laboral.Fecha_Vento = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Vento")) ? default(DateTime) : DateTime.Parse(dataReader["Fecha_Vento"].ToString());
                            h_laboral.Fecha_Baja = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Baja")) ? default(DateTime) : DateTime.Parse(dataReader["Fecha_Baja"].ToString());
                            h_laboral.Tipo_Salario = dataReader.IsDBNull(dataReader.GetOrdinal("Tipo_Salario")) ? default(Int16) : Int16.Parse(dataReader["Tipo_Salario"].ToString());
                            h_laboral.Tipo_Empleado = dataReader.IsDBNull(dataReader.GetOrdinal("Tipo_Empleado")) ? null : dataReader["Tipo_Empleado"].ToString();
                            h_laboral.Localidad = dataReader.IsDBNull(dataReader.GetOrdinal("Localidad")) ? null : dataReader["Localidad"].ToString();
                            h_laboral.Departamento = dataReader.IsDBNull(dataReader.GetOrdinal("Departamento")) ? null : dataReader["Departamento"].ToString();
                            h_laboral.Puesto = dataReader.IsDBNull(dataReader.GetOrdinal("Puesto")) ? null : dataReader["Puesto"].ToString();
                            h_laboral.Dependencia = dataReader.IsDBNull(dataReader.GetOrdinal("Dependencia")) ? null : dataReader["Dependencia"].ToString();
                            h_laboral.Cliente = dataReader.IsDBNull(dataReader.GetOrdinal("Cliente")) ? null : dataReader["Cliente"].ToString();
                            h_laboral.Tipo_De_Operacion = dataReader.IsDBNull(dataReader.GetOrdinal("Tipo_De_Operacion")) ? null : dataReader["Tipo_De_Operacion"].ToString();
                            h_laboral.Region = dataReader.IsDBNull(dataReader.GetOrdinal("Region")) ? null : dataReader["Region"].ToString();
                            h_laboral.Sector = dataReader.IsDBNull(dataReader.GetOrdinal("Sector")) ? null : dataReader["Sector"].ToString();
                            h_laboral.Usuario = dataReader.IsDBNull(dataReader.GetOrdinal("Usuario")) ? null : dataReader["Usuario"].ToString();
                            h_laboral.Sindicalizado = dataReader.IsDBNull(dataReader.GetOrdinal("Sindicalizado")) ? default(Int16) : Int16.Parse(dataReader["Sindicalizado"].ToString());
                            h_laboral.Ip = dataReader.IsDBNull(dataReader.GetOrdinal("Ip")) ? null : dataReader["Ip"].ToString();
                            h_laboral.Mac_Address = dataReader.IsDBNull(dataReader.GetOrdinal("Mac_Address")) ? null : dataReader["Mac_Address"].ToString();

                        }
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }

                return h_laboral;
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message.ToString());
            }
        }

        public Entities.Kaizen.Empleados.H_Laboral GetOne(string Compania, string NumEmpleado, string GrupoPago)
        {
            h_laboral = new Entities.Kaizen.Empleados.H_Laboral();

            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter() { ParameterName = "Compania", Value = Compania });
                parameters.Add(new SqlParameter() { ParameterName = "Empleado", Value = NumEmpleado });
                parameters.Add(new SqlParameter() { ParameterName = "Grupo_Pago", Value = GrupoPago });

                using (dataReader = this.connection.ExcuteSP("prc_H_Laboral_GetOne_SoluGlob", parameters))
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            h_laboral.Compania = dataReader.IsDBNull(dataReader.GetOrdinal("Compania")) ? null : dataReader["Compania"].ToString();
                            h_laboral.numEmpleado = dataReader.IsDBNull(dataReader.GetOrdinal("Empleado")) ? null : dataReader["Empleado"].ToString();
                            h_laboral.Fecha = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha")) ? default(DateTime) : DateTime.Parse(dataReader["Fecha"].ToString());
                            h_laboral.Sec = dataReader.IsDBNull(dataReader.GetOrdinal("Sec")) ? default(Int16) : Int16.Parse(dataReader["Sec"].ToString());
                            h_laboral.Accion = dataReader.IsDBNull(dataReader.GetOrdinal("Accion")) ? null : dataReader["Accion"].ToString();
                            h_laboral.Motivo = dataReader.IsDBNull(dataReader.GetOrdinal("Motivo")) ? null : dataReader["Motivo"].ToString();
                            h_laboral.Grupo_Pago = dataReader.IsDBNull(dataReader.GetOrdinal("Grupo_Pago")) ? null : dataReader["Grupo_Pago"].ToString();
                            h_laboral.Tipo_Contrato = dataReader.IsDBNull(dataReader.GetOrdinal("Tipo_Contrato")) ? default(Int16) : Int16.Parse(dataReader["Tipo_Contrato"].ToString());
                            h_laboral.Fecha_Ingreso = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Ingreso")) ? default(DateTime) : DateTime.Parse(dataReader["Fecha_Ingreso"].ToString());
                            h_laboral.Fecha_Antiguedad1 = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Antiguedad1")) ? default(DateTime) : DateTime.Parse(dataReader["Fecha_Antiguedad1"].ToString());
                            h_laboral.Fecha_Antiguedad2 = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Antiguedad2")) ? default(DateTime) : DateTime.Parse(dataReader["Fecha_Antiguedad2"].ToString());
                            h_laboral.Fecha_Antiguedad3 = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Antiguedad3")) ? default(DateTime) : DateTime.Parse(dataReader["Fecha_Antiguedad3"].ToString());
                            h_laboral.Duracion = dataReader.IsDBNull(dataReader.GetOrdinal("Duracion")) ? default(Int16) : Int16.Parse(dataReader["Duracion"].ToString());
                            h_laboral.Fecha_Vento = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Vento")) ? default(DateTime) : DateTime.Parse(dataReader["Fecha_Vento"].ToString());
                            h_laboral.Fecha_Baja = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Baja")) ? default(DateTime) : DateTime.Parse(dataReader["Fecha_Baja"].ToString());
                            h_laboral.Tipo_Salario = dataReader.IsDBNull(dataReader.GetOrdinal("Tipo_Salario")) ? default(Int16) : Int16.Parse(dataReader["Tipo_Salario"].ToString());
                            h_laboral.Tipo_Empleado = dataReader.IsDBNull(dataReader.GetOrdinal("Tipo_Empleado")) ? null : dataReader["Tipo_Empleado"].ToString();
                            h_laboral.Localidad = dataReader.IsDBNull(dataReader.GetOrdinal("Localidad")) ? null : dataReader["Localidad"].ToString();
                            h_laboral.Departamento = dataReader.IsDBNull(dataReader.GetOrdinal("Departamento")) ? null : dataReader["Departamento"].ToString();
                            h_laboral.Puesto = dataReader.IsDBNull(dataReader.GetOrdinal("Puesto")) ? null : dataReader["Puesto"].ToString();
                            h_laboral.Dependencia = dataReader.IsDBNull(dataReader.GetOrdinal("Dependencia")) ? null : dataReader["Dependencia"].ToString();
                            h_laboral.Cliente = dataReader.IsDBNull(dataReader.GetOrdinal("Cliente")) ? null : dataReader["Cliente"].ToString();
                            h_laboral.Tipo_De_Operacion = dataReader.IsDBNull(dataReader.GetOrdinal("Tipo_De_Operacion")) ? null : dataReader["Tipo_De_Operacion"].ToString();
                            h_laboral.Region = dataReader.IsDBNull(dataReader.GetOrdinal("Region")) ? null : dataReader["Region"].ToString();
                            h_laboral.Sector = dataReader.IsDBNull(dataReader.GetOrdinal("Sector")) ? null : dataReader["Sector"].ToString();
                            h_laboral.Usuario = dataReader.IsDBNull(dataReader.GetOrdinal("Usuario")) ? null : dataReader["Usuario"].ToString();
                            h_laboral.Sindicalizado = dataReader.IsDBNull(dataReader.GetOrdinal("Sindicalizado")) ? default(Int16) : Int16.Parse(dataReader["Sindicalizado"].ToString());
                            h_laboral.Ip = dataReader.IsDBNull(dataReader.GetOrdinal("Ip")) ? null : dataReader["Ip"].ToString();
                            h_laboral.Mac_Address = dataReader.IsDBNull(dataReader.GetOrdinal("Mac_Address")) ? null : dataReader["Mac_Address"].ToString();

                        }
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }

                return h_laboral;
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message.ToString());
            }
        }

        public List<Entities.Kaizen.Empleados.H_Laboral> GetAll()
        {
            h_laboralCollection = new List<Entities.Kaizen.Empleados.H_Laboral>();
            try
            {
                dataReader = this.connection.ExcuteSP("prc_H_Laboral_GetAll_SoluGlob", null);

                while (dataReader.Read())
                {
                    h_laboral = new Entities.Kaizen.Empleados.H_Laboral();
                    h_laboral.Compania = dataReader.IsDBNull(dataReader.GetOrdinal("Compania")) ? null : dataReader["Compania"].ToString();
                    h_laboral.numEmpleado = dataReader.IsDBNull(dataReader.GetOrdinal("Empleado")) ? null : dataReader["Empleado"].ToString();
                    h_laboral.Fecha = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha")) ? default(DateTime) : DateTime.Parse(dataReader["Fecha"].ToString());
                    h_laboral.Sec = dataReader.IsDBNull(dataReader.GetOrdinal("Sec")) ? default(Int16) : Int16.Parse(dataReader["Sec"].ToString());
                    h_laboral.Accion = dataReader.IsDBNull(dataReader.GetOrdinal("Accion")) ? null : dataReader["Accion"].ToString();
                    h_laboral.Motivo = dataReader.IsDBNull(dataReader.GetOrdinal("Motivo")) ? null : dataReader["Motivo"].ToString();
                    h_laboral.Grupo_Pago = dataReader.IsDBNull(dataReader.GetOrdinal("Grupo_Pago")) ? null : dataReader["Grupo_Pago"].ToString();
                    h_laboral.Tipo_Contrato = dataReader.IsDBNull(dataReader.GetOrdinal("Tipo_Contrato")) ? default(Int16) : Int16.Parse(dataReader["Tipo_Contrato"].ToString());
                    h_laboral.Fecha_Ingreso = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Ingreso")) ? default(DateTime) : DateTime.Parse(dataReader["Fecha_Ingreso"].ToString());
                    h_laboral.Fecha_Antiguedad1 = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Antiguedad1")) ? default(DateTime) : DateTime.Parse(dataReader["Fecha_Antiguedad1"].ToString());
                    h_laboral.Fecha_Antiguedad2 = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Antiguedad2")) ? default(DateTime) : DateTime.Parse(dataReader["Fecha_Antiguedad2"].ToString());
                    h_laboral.Fecha_Antiguedad3 = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Antiguedad3")) ? default(DateTime) : DateTime.Parse(dataReader["Fecha_Antiguedad3"].ToString());
                    h_laboral.Duracion = dataReader.IsDBNull(dataReader.GetOrdinal("Duracion")) ? default(Int16) : Int16.Parse(dataReader["Duracion"].ToString());
                    h_laboral.Fecha_Vento = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Vento")) ? default(DateTime) : DateTime.Parse(dataReader["Fecha_Vento"].ToString());
                    h_laboral.Fecha_Baja = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Baja")) ? default(DateTime) : DateTime.Parse(dataReader["Fecha_Baja"].ToString());
                    h_laboral.Tipo_Salario = dataReader.IsDBNull(dataReader.GetOrdinal("Tipo_Salario")) ? default(Int16) : Int16.Parse(dataReader["Tipo_Salario"].ToString());
                    h_laboral.Tipo_Empleado = dataReader.IsDBNull(dataReader.GetOrdinal("Tipo_Empleado")) ? null : dataReader["Tipo_Empleado"].ToString();
                    h_laboral.Localidad = dataReader.IsDBNull(dataReader.GetOrdinal("Localidad")) ? null : dataReader["Localidad"].ToString();
                    h_laboral.Departamento = dataReader.IsDBNull(dataReader.GetOrdinal("Departamento")) ? null : dataReader["Departamento"].ToString();
                    h_laboral.Puesto = dataReader.IsDBNull(dataReader.GetOrdinal("Puesto")) ? null : dataReader["Puesto"].ToString();
                    h_laboral.Dependencia = dataReader.IsDBNull(dataReader.GetOrdinal("Dependencia")) ? null : dataReader["Dependencia"].ToString();
                    h_laboral.Cliente = dataReader.IsDBNull(dataReader.GetOrdinal("Cliente")) ? null : dataReader["Cliente"].ToString();
                    h_laboral.Tipo_De_Operacion = dataReader.IsDBNull(dataReader.GetOrdinal("Tipo_De_Operacion")) ? null : dataReader["Tipo_De_Operacion"].ToString();
                    h_laboral.Region = dataReader.IsDBNull(dataReader.GetOrdinal("Region")) ? null : dataReader["Region"].ToString();
                    h_laboral.Sector = dataReader.IsDBNull(dataReader.GetOrdinal("Sector")) ? null : dataReader["Sector"].ToString();
                    h_laboral.Usuario = dataReader.IsDBNull(dataReader.GetOrdinal("Usuario")) ? null : dataReader["Usuario"].ToString();
                    h_laboral.Sindicalizado = dataReader.IsDBNull(dataReader.GetOrdinal("Sindicalizado")) ? default(Int16) : Int16.Parse(dataReader["Sindicalizado"].ToString());
                    h_laboral.Ip = dataReader.IsDBNull(dataReader.GetOrdinal("Ip")) ? null : dataReader["Ip"].ToString();
                    h_laboral.Mac_Address = dataReader.IsDBNull(dataReader.GetOrdinal("Mac_Address")) ? null : dataReader["Mac_Address"].ToString();
                    h_laboralCollection.Add(h_laboral);
                }
                dataReader.Close();
                dataReader.Dispose();

                return h_laboralCollection;
            }
            catch (Exception ex)
            {

                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message.ToString());
            }
        }


        public Entities.Kaizen.Empleados.H_Laboral Update(Entities.Kaizen.Empleados.H_Laboral objH_Laboral)
        {
            h_laboral = new Entities.Kaizen.Empleados.H_Laboral();
            //StringBuilder sb = new StringBuilder();
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                parameters.Add(new SqlParameter() { ParameterName = "Compania", Value = objH_Laboral.Compania });
                parameters.Add(new SqlParameter() { ParameterName = "Empleado", Value = objH_Laboral.numEmpleado });
                parameters.Add(new SqlParameter() { ParameterName = "Fecha", Value = objH_Laboral.Fecha });
                parameters.Add(new SqlParameter() { ParameterName = "Sec", Value = objH_Laboral.Sec });
                parameters.Add(new SqlParameter() { ParameterName = "Accion", Value = objH_Laboral.Accion });
                parameters.Add(new SqlParameter() { ParameterName = "Motivo", Value = objH_Laboral.Motivo });
                parameters.Add(new SqlParameter() { ParameterName = "Grupo_Pago", Value = objH_Laboral.Grupo_Pago });
                parameters.Add(new SqlParameter() { ParameterName = "Tipo_Contrato", Value = objH_Laboral.Tipo_Contrato });
                parameters.Add(new SqlParameter() { ParameterName = "Fecha_Ingreso", Value = objH_Laboral.Fecha_Ingreso });
                parameters.Add(new SqlParameter() { ParameterName = "Fecha_Antiguedad1", Value = objH_Laboral.Fecha_Antiguedad1 });
                parameters.Add(new SqlParameter() { ParameterName = "Fecha_Antiguedad2", Value = objH_Laboral.Fecha_Antiguedad2 });
                parameters.Add(new SqlParameter() { ParameterName = "Fecha_Antiguedad3", Value = objH_Laboral.Fecha_Antiguedad3 });
                parameters.Add(new SqlParameter() { ParameterName = "Duracion", Value = objH_Laboral.Duracion });
                parameters.Add(new SqlParameter() { ParameterName = "Fecha_Vento", Value = objH_Laboral.Fecha_Vento });
                parameters.Add(new SqlParameter() { ParameterName = "Fecha_Baja", Value = objH_Laboral.Fecha_Baja });
                parameters.Add(new SqlParameter() { ParameterName = "Tipo_Salario", Value = objH_Laboral.Tipo_Salario });
                parameters.Add(new SqlParameter() { ParameterName = "Tipo_Empleado", Value = objH_Laboral.Tipo_Empleado });
                parameters.Add(new SqlParameter() { ParameterName = "Localidad", Value = objH_Laboral.Localidad });
                parameters.Add(new SqlParameter() { ParameterName = "Departamento", Value = objH_Laboral.Departamento });
                parameters.Add(new SqlParameter() { ParameterName = "Puesto", Value = objH_Laboral.Puesto });
                parameters.Add(new SqlParameter() { ParameterName = "Dependencia", Value = objH_Laboral.Dependencia });
                parameters.Add(new SqlParameter() { ParameterName = "Cliente", Value = objH_Laboral.Cliente });
                parameters.Add(new SqlParameter() { ParameterName = "Tipo_De_Operacion", Value = objH_Laboral.Tipo_De_Operacion });
                parameters.Add(new SqlParameter() { ParameterName = "Region", Value = objH_Laboral.Region });
                parameters.Add(new SqlParameter() { ParameterName = "Sector", Value = objH_Laboral.Sector });
                parameters.Add(new SqlParameter() { ParameterName = "Usuario", Value = objH_Laboral.Usuario });
                parameters.Add(new SqlParameter() { ParameterName = "Sindicalizado", Value = objH_Laboral.Sindicalizado });
                parameters.Add(new SqlParameter() { ParameterName = "Ip", Value = objH_Laboral.Ip });
                parameters.Add(new SqlParameter() { ParameterName = "Mac_Address", Value = objH_Laboral.Mac_Address });

                using (dataReader = this.connection.ExcuteSP("prc_H_Laboral_Update_SoluGlob", parameters))
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            h_laboral.Compania = dataReader.IsDBNull(dataReader.GetOrdinal("Compania")) ? null : dataReader["Compania"].ToString();
                            h_laboral.numEmpleado = dataReader.IsDBNull(dataReader.GetOrdinal("Empleado")) ? null : dataReader["Empleado"].ToString();
                            h_laboral.Fecha = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha")) ? default(DateTime) : DateTime.Parse(dataReader["Fecha"].ToString());
                            h_laboral.Sec = dataReader.IsDBNull(dataReader.GetOrdinal("Sec")) ? default(Int16) : Int16.Parse(dataReader["Sec"].ToString());
                            h_laboral.Accion = dataReader.IsDBNull(dataReader.GetOrdinal("Accion")) ? null : dataReader["Accion"].ToString();
                            h_laboral.Motivo = dataReader.IsDBNull(dataReader.GetOrdinal("Motivo")) ? null : dataReader["Motivo"].ToString();
                            h_laboral.Grupo_Pago = dataReader.IsDBNull(dataReader.GetOrdinal("Grupo_Pago")) ? null : dataReader["Grupo_Pago"].ToString();
                            h_laboral.Tipo_Contrato = dataReader.IsDBNull(dataReader.GetOrdinal("Tipo_Contrato")) ? default(Int16) : Int16.Parse(dataReader["Tipo_Contrato"].ToString());
                            h_laboral.Fecha_Ingreso = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Ingreso")) ? default(DateTime) : DateTime.Parse(dataReader["Fecha_Ingreso"].ToString());
                            h_laboral.Fecha_Antiguedad1 = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Antiguedad1")) ? default(DateTime) : DateTime.Parse(dataReader["Fecha_Antiguedad1"].ToString());
                            h_laboral.Fecha_Antiguedad2 = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Antiguedad2")) ? default(DateTime) : DateTime.Parse(dataReader["Fecha_Antiguedad2"].ToString());
                            h_laboral.Fecha_Antiguedad3 = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Antiguedad3")) ? default(DateTime) : DateTime.Parse(dataReader["Fecha_Antiguedad3"].ToString());
                            h_laboral.Duracion = dataReader.IsDBNull(dataReader.GetOrdinal("Duracion")) ? default(Int16) : Int16.Parse(dataReader["Duracion"].ToString());
                            h_laboral.Fecha_Vento = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Vento")) ? default(DateTime) : DateTime.Parse(dataReader["Fecha_Vento"].ToString());
                            h_laboral.Fecha_Baja = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Baja")) ? default(DateTime) : DateTime.Parse(dataReader["Fecha_Baja"].ToString());
                            h_laboral.Tipo_Salario = dataReader.IsDBNull(dataReader.GetOrdinal("Tipo_Salario")) ? default(Int16) : Int16.Parse(dataReader["Tipo_Salario"].ToString());
                            h_laboral.Tipo_Empleado = dataReader.IsDBNull(dataReader.GetOrdinal("Tipo_Empleado")) ? null : dataReader["Tipo_Empleado"].ToString();
                            h_laboral.Localidad = dataReader.IsDBNull(dataReader.GetOrdinal("Localidad")) ? null : dataReader["Localidad"].ToString();
                            h_laboral.Departamento = dataReader.IsDBNull(dataReader.GetOrdinal("Departamento")) ? null : dataReader["Departamento"].ToString();
                            h_laboral.Puesto = dataReader.IsDBNull(dataReader.GetOrdinal("Puesto")) ? null : dataReader["Puesto"].ToString();
                            h_laboral.Dependencia = dataReader.IsDBNull(dataReader.GetOrdinal("Dependencia")) ? null : dataReader["Dependencia"].ToString();
                            h_laboral.Cliente = dataReader.IsDBNull(dataReader.GetOrdinal("Cliente")) ? null : dataReader["Cliente"].ToString();
                            h_laboral.Tipo_De_Operacion = dataReader.IsDBNull(dataReader.GetOrdinal("Tipo_De_Operacion")) ? null : dataReader["Tipo_De_Operacion"].ToString();
                            h_laboral.Region = dataReader.IsDBNull(dataReader.GetOrdinal("Region")) ? null : dataReader["Region"].ToString();
                            h_laboral.Sector = dataReader.IsDBNull(dataReader.GetOrdinal("Sector")) ? null : dataReader["Sector"].ToString();
                            h_laboral.Usuario = dataReader.IsDBNull(dataReader.GetOrdinal("Usuario")) ? null : dataReader["Usuario"].ToString();
                            h_laboral.Sindicalizado = dataReader.IsDBNull(dataReader.GetOrdinal("Sindicalizado")) ? default(Int16) : Int16.Parse(dataReader["Sindicalizado"].ToString());
                            h_laboral.Ip = dataReader.IsDBNull(dataReader.GetOrdinal("Ip")) ? null : dataReader["Ip"].ToString();
                            h_laboral.Mac_Address = dataReader.IsDBNull(dataReader.GetOrdinal("Mac_Address")) ? null : dataReader["Mac_Address"].ToString();
                        }
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }

                return h_laboral;
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

                this.connection.ExcuteScalar("prc_H_Laboral_Delete_SoluGlob", parameters);
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

                this.connection.ExcuteScalar("prc_H_Laboral_Drop_SoluGlob", parameters);
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message);
            }
        }

        public void DropLast(Entities.Kaizen.Empleados.H_Laboral objH_Laboral)
        {
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter() { ParameterName = "RegistroMovimientoId", Value = objH_Laboral.RegistroMovimientoId });
                parameters.Add(new SqlParameter() { ParameterName = "RegistroMovimientoIdPasajes", Value = objH_Laboral.RegistroMovimientoIdPasajes });

                this.connection.ExcuteScalar("prc_H_Laboral_DropLast_SoluGlob", parameters);
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message);
            }
        }

        public Entities.Kaizen.Empleados.H_Laboral UpdatePuesto(Entities.Kaizen.Empleados.H_Laboral objH_Laboral)
        {
            h_laboral = new Entities.Kaizen.Empleados.H_Laboral();

            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                parameters.Add(new SqlParameter() { ParameterName = "Compania", Value = objH_Laboral.Compania });
                parameters.Add(new SqlParameter() { ParameterName = "Empleado", Value = objH_Laboral.numEmpleado });
                parameters.Add(new SqlParameter() { ParameterName = "CompaniaPasajes", Value = objH_Laboral.companiaPasajes });
                parameters.Add(new SqlParameter() { ParameterName = "Accion", Value = objH_Laboral.Accion });
                parameters.Add(new SqlParameter() { ParameterName = "Motivo", Value = objH_Laboral.Motivo });
                parameters.Add(new SqlParameter() { ParameterName = "PuestoNuevo", Value = objH_Laboral.Puesto });

                //using (dataReader = this.connection.ExcuteSP("prc_H_Laboral_UpdatePuesto_Soluglob", parameters))
                dataReader = this.connection.ExcuteSP("prc_H_Laboral_UpdatePuesto_Soluglob", parameters);

                
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            h_laboral.Compania = dataReader.IsDBNull(dataReader.GetOrdinal("Compania")) ? null : dataReader["Compania"].ToString();
                            h_laboral.numEmpleado = dataReader.IsDBNull(dataReader.GetOrdinal("Empleado")) ? null : dataReader["Empleado"].ToString();
                            h_laboral.Fecha = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha")) ? default(DateTime) : DateTime.Parse(dataReader["Fecha"].ToString());
                            h_laboral.Sec = dataReader.IsDBNull(dataReader.GetOrdinal("Sec")) ? default(Int16) : Int16.Parse(dataReader["Sec"].ToString());
                            h_laboral.Accion = dataReader.IsDBNull(dataReader.GetOrdinal("Accion")) ? null : dataReader["Accion"].ToString();
                            h_laboral.Motivo = dataReader.IsDBNull(dataReader.GetOrdinal("Motivo")) ? null : dataReader["Motivo"].ToString();
                            h_laboral.Grupo_Pago = dataReader.IsDBNull(dataReader.GetOrdinal("Grupo_Pago")) ? null : dataReader["Grupo_Pago"].ToString();
                            h_laboral.Tipo_Contrato = dataReader.IsDBNull(dataReader.GetOrdinal("Tipo_Contrato")) ? default(Int16) : Int16.Parse(dataReader["Tipo_Contrato"].ToString());
                            h_laboral.Fecha_Ingreso = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Ingreso")) ? default(DateTime) : DateTime.Parse(dataReader["Fecha_Ingreso"].ToString());
                            h_laboral.Fecha_Antiguedad1 = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Antiguedad1")) ? default(DateTime) : DateTime.Parse(dataReader["Fecha_Antiguedad1"].ToString());
                            h_laboral.Fecha_Antiguedad2 = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Antiguedad2")) ? default(DateTime) : DateTime.Parse(dataReader["Fecha_Antiguedad2"].ToString());
                            h_laboral.Fecha_Antiguedad3 = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Antiguedad3")) ? default(DateTime) : DateTime.Parse(dataReader["Fecha_Antiguedad3"].ToString());
                            h_laboral.Duracion = dataReader.IsDBNull(dataReader.GetOrdinal("Duracion")) ? default(Int16) : Int16.Parse(dataReader["Duracion"].ToString());
                            h_laboral.Fecha_Vento = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Vento")) ? default(DateTime) : DateTime.Parse(dataReader["Fecha_Vento"].ToString());
                            h_laboral.Fecha_Baja = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Baja")) ? default(DateTime) : DateTime.Parse(dataReader["Fecha_Baja"].ToString());
                            h_laboral.Tipo_Salario = dataReader.IsDBNull(dataReader.GetOrdinal("Tipo_Salario")) ? default(Int16) : Int16.Parse(dataReader["Tipo_Salario"].ToString());
                            h_laboral.Tipo_Empleado = dataReader.IsDBNull(dataReader.GetOrdinal("Tipo_Empleado")) ? null : dataReader["Tipo_Empleado"].ToString();
                            h_laboral.Localidad = dataReader.IsDBNull(dataReader.GetOrdinal("Localidad")) ? null : dataReader["Localidad"].ToString();
                            h_laboral.Departamento = dataReader.IsDBNull(dataReader.GetOrdinal("Departamento")) ? null : dataReader["Departamento"].ToString();
                            h_laboral.Puesto = dataReader.IsDBNull(dataReader.GetOrdinal("Puesto")) ? null : dataReader["Puesto"].ToString();
                            h_laboral.Dependencia = dataReader.IsDBNull(dataReader.GetOrdinal("Dependencia")) ? null : dataReader["Dependencia"].ToString();
                            h_laboral.Cliente = dataReader.IsDBNull(dataReader.GetOrdinal("Cliente")) ? null : dataReader["Cliente"].ToString();
                            h_laboral.Tipo_De_Operacion = dataReader.IsDBNull(dataReader.GetOrdinal("Tipo_De_Operacion")) ? null : dataReader["Tipo_De_Operacion"].ToString();
                            h_laboral.Region = dataReader.IsDBNull(dataReader.GetOrdinal("Region")) ? null : dataReader["Region"].ToString();
                            h_laboral.Sector = dataReader.IsDBNull(dataReader.GetOrdinal("Sector")) ? null : dataReader["Sector"].ToString();
                            h_laboral.Usuario = dataReader.IsDBNull(dataReader.GetOrdinal("Usuario")) ? null : dataReader["Usuario"].ToString();
                            h_laboral.Sindicalizado = dataReader.IsDBNull(dataReader.GetOrdinal("Sindicalizado")) ? default(Int16) : Int16.Parse(dataReader["Sindicalizado"].ToString());
                            h_laboral.Ip = dataReader.IsDBNull(dataReader.GetOrdinal("Ip")) ? null : dataReader["Ip"].ToString();
                            h_laboral.Mac_Address = dataReader.IsDBNull(dataReader.GetOrdinal("Mac_Address")) ? null : dataReader["Mac_Address"].ToString();
                            h_laboral.RegistroMovimientoId = dataReader.IsDBNull(dataReader.GetOrdinal("RegistroMovimientoId")) ? default(int) : int.Parse(dataReader["RegistroMovimientoId"].ToString());
                            h_laboral.RegistroMovimientoIdPasajes = dataReader.IsDBNull(dataReader.GetOrdinal("RegistroMovimientoIdPasajes")) ? default(int) : int.Parse(dataReader["RegistroMovimientoIdPasajes"].ToString());
                        }
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                

                return h_laboral;
            }
            catch (Exception ex)
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                    dataReader.Dispose();
                }
                throw new Exception(ex.Message.ToString());
            }

        }
    }
}
