using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integra.Services.Data.SoluglobChecador
{
    public class Empleados
    {
        List<Entities.SoluglobChecador.Empleados> empleadosCollection = null;
        Entities.SoluglobChecador.Empleados empleados = null;
        SqlDataReader dataReader = null;

        public Connection connection = null;

        public Empleados()
        {
            this.connection = Connection.Instance;
        }
        public Empleados(bool isTransaction)
        {
            this.connection = new Connection();
        }
        public Empleados(Connection connection)
        {
            this.connection = connection;
        }

        public Entities.SoluglobChecador.Empleados Insert(Entities.SoluglobChecador.Empleados objEmpleados)
        {
            empleados = new Entities.SoluglobChecador.Empleados();
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                parameters.Add(new SqlParameter() { ParameterName = "Numero_Nomina", Value = objEmpleados.Numero_Nomina });
                parameters.Add(new SqlParameter() { ParameterName = "Nombres", Value = objEmpleados.Nombres });
                parameters.Add(new SqlParameter() { ParameterName = "Apellidos", Value = objEmpleados.Apellidos });
                parameters.Add(new SqlParameter() { ParameterName = "Puesto", Value = objEmpleados.Puesto });
                parameters.Add(new SqlParameter() { ParameterName = "Departamento", Value = objEmpleados.Departamento });
                parameters.Add(new SqlParameter() { ParameterName = "Telefono", Value = objEmpleados.Telefono });
                parameters.Add(new SqlParameter() { ParameterName = "Huella_Template", Value = objEmpleados.Huella_Template });
                parameters.Add(new SqlParameter() { ParameterName = "Huella_Img1", Value = objEmpleados.Huella_Img1 });
                parameters.Add(new SqlParameter() { ParameterName = "Huella_Img2", Value = objEmpleados.Huella_Img2 });
                parameters.Add(new SqlParameter() { ParameterName = "Huella_Img3", Value = objEmpleados.Huella_Img3 });
                parameters.Add(new SqlParameter() { ParameterName = "Huella_Img4", Value = objEmpleados.Huella_Img4 });
                parameters.Add(new SqlParameter() { ParameterName = "Estatus", Value = objEmpleados.Estatus });
                parameters.Add(new SqlParameter() { ParameterName = "Fecha_Alta", Value = objEmpleados.Fecha_Alta });
                parameters.Add(new SqlParameter() { ParameterName = "Fecha_Baja", Value = objEmpleados.Fecha_Baja });
                parameters.Add(new SqlParameter() { ParameterName = "Empresa", Value = objEmpleados.Empresa });
                parameters.Add(new SqlParameter() { ParameterName = "Ubicacion", Value = objEmpleados.Ubicacion });
                parameters.Add(new SqlParameter() { ParameterName = "MotivoBaja", Value = objEmpleados.MotivoBaja });
                parameters.Add(new SqlParameter() { ParameterName = "Caso_Especial", Value = objEmpleados.Caso_Especial });
                parameters.Add(new SqlParameter() { ParameterName = "msrepl_tran_version", Value = objEmpleados.msrepl_tran_version });
                parameters.Add(new SqlParameter() { ParameterName = "Registrado", Value = objEmpleados.Registrado });
                parameters.Add(new SqlParameter() { ParameterName = "Imss", Value = objEmpleados.Imss });
                parameters.Add(new SqlParameter() { ParameterName = "Dias_semana", Value = objEmpleados.Dias_Semana });
                parameters.Add(new SqlParameter() { ParameterName = "fecha_ingresos", Value = objEmpleados.Fecha_Ingresos });
                parameters.Add(new SqlParameter() { ParameterName = "pagos_hextras", Value = objEmpleados.Pagos_HExtras });
                parameters.Add(new SqlParameter() { ParameterName = "Fechas_registro", Value = objEmpleados.Fechas_Registro });
                parameters.Add(new SqlParameter() { ParameterName = "unidad_costos", Value = objEmpleados.Unidad_Costos });
                parameters.Add(new SqlParameter() { ParameterName = "Fecha_Reingreso", Value = objEmpleados.Fecha_Reingreso });
                parameters.Add(new SqlParameter() { ParameterName = "Centro_costos", Value = objEmpleados.Centro_Costos });
                parameters.Add(new SqlParameter() { ParameterName = "Numero_Nominas", Value = objEmpleados.Numero_Nominas });
                parameters.Add(new SqlParameter() { ParameterName = "Remuneracion", Value = objEmpleados.Remuneracion });
                parameters.Add(new SqlParameter() { ParameterName = "Fecha_Alta_Imss", Value = objEmpleados.Fecha_Alta_Imss });
                parameters.Add(new SqlParameter() { ParameterName = "Fecha_Baja_sistema", Value = objEmpleados.Fecha_Baja_Sistema });
                parameters.Add(new SqlParameter() { ParameterName = "Estatus_Edicion", Value = objEmpleados.Estatus_Edicion });
                parameters.Add(new SqlParameter() { ParameterName = "Fecha_Modificacion", Value = objEmpleados.Fecha_Modificacion });
                parameters.Add(new SqlParameter() { ParameterName = "Bono", Value = objEmpleados.Bono });
                parameters.Add(new SqlParameter() { ParameterName = "Responsable_Bono", Value = objEmpleados.Responsable_Bono });

                using (dataReader = this.connection.ExcuteSP("prc_Empleados_Insert", parameters))
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            empleados.Numero_Nomina = dataReader.IsDBNull(dataReader.GetOrdinal("Numero_Nomina")) ? default(int) : int.Parse(dataReader["Numero_Nomina"].ToString());
                            empleados.Nombres = dataReader.IsDBNull(dataReader.GetOrdinal("Nombres")) ? null : dataReader["Nombres"].ToString();
                            empleados.Apellidos = dataReader.IsDBNull(dataReader.GetOrdinal("Apellidos")) ? null : dataReader["Apellidos"].ToString();
                            empleados.Puesto = dataReader.IsDBNull(dataReader.GetOrdinal("Puesto")) ? null : dataReader["Puesto"].ToString();
                            empleados.Departamento = dataReader.IsDBNull(dataReader.GetOrdinal("Departamento")) ? null : dataReader["Departamento"].ToString();
                            empleados.Telefono = dataReader.IsDBNull(dataReader.GetOrdinal("Telefono")) ? null : dataReader["Telefono"].ToString();
                            //empleados.Huella_Template = dataReader.IsDBNull(dataReader.GetOrdinal("Huella_Template")) ? default(byte[]) : Encoding.UTF8.GetBytes(dataReader["Huella_Template"].ToString());
                            empleados.Huella_Template = dataReader.IsDBNull(dataReader.GetOrdinal("Huella_Template")) ? null : dataReader["Huella_Template"].ToString();
                            empleados.Huella_Img1 = dataReader.IsDBNull(dataReader.GetOrdinal("Huella_Img1")) ? null : dataReader["Huella_Img1"].ToString();
                            empleados.Huella_Img2 = dataReader.IsDBNull(dataReader.GetOrdinal("Huella_Img2")) ? null : dataReader["Huella_Img2"].ToString();
                            empleados.Huella_Img3 = dataReader.IsDBNull(dataReader.GetOrdinal("Huella_Img3")) ? null : dataReader["Huella_Img3"].ToString();
                            empleados.Huella_Img4 = dataReader.IsDBNull(dataReader.GetOrdinal("Huella_Img4")) ? null : dataReader["Huella_Img4"].ToString();
                            empleados.Estatus = dataReader.IsDBNull(dataReader.GetOrdinal("Estatus")) ? default(bool) : bool.Parse(dataReader["Estatus"].ToString());
                            empleados.Fecha_Alta = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Alta")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Alta"].ToString());
                            empleados.Fecha_Baja = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Baja")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Baja"].ToString());
                            empleados.Empresa = dataReader.IsDBNull(dataReader.GetOrdinal("Empresa")) ? null : dataReader["Empresa"].ToString();
                            empleados.Ubicacion = dataReader.IsDBNull(dataReader.GetOrdinal("Ubicacion")) ? null : dataReader["Ubicacion"].ToString();
                            empleados.MotivoBaja = dataReader.IsDBNull(dataReader.GetOrdinal("MotivoBaja")) ? null : dataReader["MotivoBaja"].ToString();
                            empleados.Caso_Especial = dataReader.IsDBNull(dataReader.GetOrdinal("Caso_Especial")) ? default(bool) : bool.Parse(dataReader["Caso_Especial"].ToString());
                            empleados.msrepl_tran_version = dataReader.IsDBNull(dataReader.GetOrdinal("msrepl_tran_version")) ? default(Guid?) : Guid.Parse(dataReader["msrepl_tran_version"].ToString());
                            empleados.Registrado = dataReader.IsDBNull(dataReader.GetOrdinal("Registrado")) ? default(int?) : int.Parse(dataReader["Registrado"].ToString());
                            empleados.Imss = dataReader.IsDBNull(dataReader.GetOrdinal("Imss")) ? null : dataReader["Imss"].ToString();
                            empleados.Dias_Semana = dataReader.IsDBNull(dataReader.GetOrdinal("Dias_Semana")) ? default(int?) : int.Parse(dataReader["Dias_Semana"].ToString());
                            empleados.Fecha_Ingresos = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Ingresos")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Ingresos"].ToString());
                            empleados.Pagos_HExtras = dataReader.IsDBNull(dataReader.GetOrdinal("Pagos_HExtras")) ? null : dataReader["Pagos_HExtras"].ToString();
                            empleados.Fechas_Registro = dataReader.IsDBNull(dataReader.GetOrdinal("Fechas_Registro")) ? default(DateTime?) : DateTime.Parse(dataReader["Fechas_Registro"].ToString());
                            empleados.Unidad_Costos = dataReader.IsDBNull(dataReader.GetOrdinal("Unidad_Costos")) ? null : dataReader["Unidad_Costos"].ToString();
                            empleados.Fecha_Reingreso = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Reingreso")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Reingreso"].ToString());
                            empleados.Centro_Costos = dataReader.IsDBNull(dataReader.GetOrdinal("Centro_Costos")) ? null : dataReader["Centro_Costos"].ToString();
                            empleados.Numero_Nominas = dataReader.IsDBNull(dataReader.GetOrdinal("Numero_Nominas")) ? default(int?) : int.Parse(dataReader["Numero_Nominas"].ToString());
                            empleados.Remuneracion = dataReader.IsDBNull(dataReader.GetOrdinal("Remuneracion")) ? null : dataReader["Remuneracion"].ToString();
                            empleados.Fecha_Alta_Imss = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Alta_Imss")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Alta_Imss"].ToString());
                            empleados.Fecha_Baja_Sistema = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Baja_Sistema")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Baja_Sistema"].ToString());
                            empleados.Estatus_Edicion = dataReader.IsDBNull(dataReader.GetOrdinal("Estatus_Edicion")) ? default(int?) : int.Parse(dataReader["Estatus_Edicion"].ToString());
                            empleados.Fecha_Modificacion = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Modificacion")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Modificacion"].ToString());
                            empleados.Bono = dataReader.IsDBNull(dataReader.GetOrdinal("Bono")) ? default(bool?) : bool.Parse(dataReader["Bono"].ToString());
                            empleados.Responsable_Bono = dataReader.IsDBNull(dataReader.GetOrdinal("Responsable_Bono")) ? null : dataReader["Responsable_Bono"].ToString();
                        }
                    }

                    dataReader.Close();
                    dataReader.Dispose();
                }

                return empleados;
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message.ToString());
            }
        }

        public Entities.SoluglobChecador.Empleados GetOne(int NumNomina)
        {
            empleados = new Entities.SoluglobChecador.Empleados();
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter() { ParameterName = "Numero_Nomina", Value = NumNomina });

                using (dataReader = this.connection.ExcuteSP("prc_Empleados_GetOne", parameters))
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            empleados.Numero_Nomina = dataReader.IsDBNull(dataReader.GetOrdinal("Numero_Nomina")) ? default(int) : int.Parse(dataReader["Numero_Nomina"].ToString());
                            empleados.Nombres = dataReader.IsDBNull(dataReader.GetOrdinal("Nombres")) ? null : dataReader["Nombres"].ToString();
                            empleados.Apellidos = dataReader.IsDBNull(dataReader.GetOrdinal("Apellidos")) ? null : dataReader["Apellidos"].ToString();
                            empleados.Puesto = dataReader.IsDBNull(dataReader.GetOrdinal("Puesto")) ? null : dataReader["Puesto"].ToString();
                            empleados.Departamento = dataReader.IsDBNull(dataReader.GetOrdinal("Departamento")) ? null : dataReader["Departamento"].ToString();
                            empleados.Telefono = dataReader.IsDBNull(dataReader.GetOrdinal("Telefono")) ? null : dataReader["Telefono"].ToString();
                            empleados.Huella_Template = dataReader.IsDBNull(dataReader.GetOrdinal("Huella_Template")) ? null : dataReader["Huella_Template"].ToString();
                            empleados.Huella_Img1 = dataReader.IsDBNull(dataReader.GetOrdinal("Huella_Img1")) ? null : dataReader["Huella_Img1"].ToString();
                            empleados.Huella_Img2 = dataReader.IsDBNull(dataReader.GetOrdinal("Huella_Img2")) ? null : dataReader["Huella_Img2"].ToString();
                            empleados.Huella_Img3 = dataReader.IsDBNull(dataReader.GetOrdinal("Huella_Img3")) ? null : dataReader["Huella_Img3"].ToString();
                            empleados.Huella_Img4 = dataReader.IsDBNull(dataReader.GetOrdinal("Huella_Img4")) ? null : dataReader["Huella_Img4"].ToString();
                            empleados.Estatus = dataReader.IsDBNull(dataReader.GetOrdinal("Estatus")) ? default(bool) : bool.Parse(dataReader["Estatus"].ToString());
                            empleados.Fecha_Alta = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Alta")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Alta"].ToString());
                            empleados.Fecha_Baja = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Baja")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Baja"].ToString());
                            empleados.Empresa = dataReader.IsDBNull(dataReader.GetOrdinal("Empresa")) ? null : dataReader["Empresa"].ToString();
                            empleados.Ubicacion = dataReader.IsDBNull(dataReader.GetOrdinal("Ubicacion")) ? null : dataReader["Ubicacion"].ToString();
                            empleados.MotivoBaja = dataReader.IsDBNull(dataReader.GetOrdinal("MotivoBaja")) ? null : dataReader["MotivoBaja"].ToString();
                            empleados.Caso_Especial = dataReader.IsDBNull(dataReader.GetOrdinal("Caso_Especial")) ? default(bool) : bool.Parse(dataReader["Caso_Especial"].ToString());
                            empleados.msrepl_tran_version = dataReader.IsDBNull(dataReader.GetOrdinal("msrepl_tran_version")) ? default(Guid?) : Guid.Parse(dataReader["msrepl_tran_version"].ToString());
                            empleados.Registrado = dataReader.IsDBNull(dataReader.GetOrdinal("Registrado")) ? default(int?) : int.Parse(dataReader["Registrado"].ToString());
                            empleados.Imss = dataReader.IsDBNull(dataReader.GetOrdinal("Imss")) ? null : dataReader["Imss"].ToString();
                            empleados.Dias_Semana = dataReader.IsDBNull(dataReader.GetOrdinal("Dias_Semana")) ? default(int?) : int.Parse(dataReader["Dias_Semana"].ToString());
                            empleados.Fecha_Ingresos = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Ingresos")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Ingresos"].ToString());
                            empleados.Pagos_HExtras = dataReader.IsDBNull(dataReader.GetOrdinal("Pagos_HExtras")) ? null : dataReader["Pagos_HExtras"].ToString();
                            empleados.Fechas_Registro = dataReader.IsDBNull(dataReader.GetOrdinal("Fechas_Registro")) ? default(DateTime?) : DateTime.Parse(dataReader["Fechas_Registro"].ToString());
                            empleados.Unidad_Costos = dataReader.IsDBNull(dataReader.GetOrdinal("Unidad_Costos")) ? null : dataReader["Unidad_Costos"].ToString();
                            empleados.Fecha_Reingreso = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Reingreso")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Reingreso"].ToString());
                            empleados.Centro_Costos = dataReader.IsDBNull(dataReader.GetOrdinal("Centro_Costos")) ? null : dataReader["Centro_Costos"].ToString();
                            empleados.Numero_Nominas = dataReader.IsDBNull(dataReader.GetOrdinal("Numero_Nominas")) ? default(int?) : int.Parse(dataReader["Numero_Nominas"].ToString());
                            empleados.Remuneracion = dataReader.IsDBNull(dataReader.GetOrdinal("Remuneracion")) ? null : dataReader["Remuneracion"].ToString();
                            empleados.Fecha_Alta_Imss = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Alta_Imss")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Alta_Imss"].ToString());
                            empleados.Fecha_Baja_Sistema = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Baja_Sistema")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Baja_Sistema"].ToString());
                            empleados.Estatus_Edicion = dataReader.IsDBNull(dataReader.GetOrdinal("Estatus_Edicion")) ? default(int?) : int.Parse(dataReader["Estatus_Edicion"].ToString());
                            empleados.Fecha_Modificacion = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Modificacion")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Modificacion"].ToString());
                            empleados.Bono = dataReader.IsDBNull(dataReader.GetOrdinal("Bono")) ? default(bool?) : bool.Parse(dataReader["Bono"].ToString());
                            empleados.Responsable_Bono = dataReader.IsDBNull(dataReader.GetOrdinal("Responsable_Bono")) ? null : dataReader["Responsable_Bono"].ToString();

                        }
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }

                return empleados;
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message.ToString());
            }

        }

        public List<Entities.SoluglobChecador.Empleados> GetAll()
        {
            empleadosCollection = new List<Entities.SoluglobChecador.Empleados>();
            try
            {
                dataReader = this.connection.ExcuteSP("prc_Empleados_GetAll", null);

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        empleados = new Entities.SoluglobChecador.Empleados();
                        empleados.Numero_Nomina = dataReader.IsDBNull(dataReader.GetOrdinal("Numero_Nomina")) ? default(int) : int.Parse(dataReader["Numero_Nomina"].ToString());
                        empleados.Nombres = dataReader.IsDBNull(dataReader.GetOrdinal("Nombres")) ? null : dataReader["Nombres"].ToString();
                        empleados.Apellidos = dataReader.IsDBNull(dataReader.GetOrdinal("Apellidos")) ? null : dataReader["Apellidos"].ToString();
                        empleados.Puesto = dataReader.IsDBNull(dataReader.GetOrdinal("Puesto")) ? null : dataReader["Puesto"].ToString();
                        empleados.Departamento = dataReader.IsDBNull(dataReader.GetOrdinal("Departamento")) ? null : dataReader["Departamento"].ToString();
                        empleados.Telefono = dataReader.IsDBNull(dataReader.GetOrdinal("Telefono")) ? null : dataReader["Telefono"].ToString();
                        empleados.Huella_Template = dataReader.IsDBNull(dataReader.GetOrdinal("Huella_Template")) ? null : dataReader["Huella_Template"].ToString();
                        empleados.Huella_Img1 = dataReader.IsDBNull(dataReader.GetOrdinal("Huella_Img1")) ? null : dataReader["Huella_Img1"].ToString();
                        empleados.Huella_Img2 = dataReader.IsDBNull(dataReader.GetOrdinal("Huella_Img2")) ? null : dataReader["Huella_Img2"].ToString();
                        empleados.Huella_Img3 = dataReader.IsDBNull(dataReader.GetOrdinal("Huella_Img3")) ? null : dataReader["Huella_Img3"].ToString();
                        empleados.Huella_Img4 = dataReader.IsDBNull(dataReader.GetOrdinal("Huella_Img4")) ? null : dataReader["Huella_Img4"].ToString();
                        empleados.Estatus = dataReader.IsDBNull(dataReader.GetOrdinal("Estatus")) ? default(bool) : bool.Parse(dataReader["Estatus"].ToString());
                        empleados.Fecha_Alta = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Alta")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Alta"].ToString());
                        empleados.Fecha_Baja = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Baja")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Baja"].ToString());
                        empleados.Empresa = dataReader.IsDBNull(dataReader.GetOrdinal("Empresa")) ? null : dataReader["Empresa"].ToString();
                        empleados.Ubicacion = dataReader.IsDBNull(dataReader.GetOrdinal("Ubicacion")) ? null : dataReader["Ubicacion"].ToString();
                        empleados.MotivoBaja = dataReader.IsDBNull(dataReader.GetOrdinal("MotivoBaja")) ? null : dataReader["MotivoBaja"].ToString();
                        empleados.Caso_Especial = dataReader.IsDBNull(dataReader.GetOrdinal("Caso_Especial")) ? default(bool) : bool.Parse(dataReader["Caso_Especial"].ToString());
                        empleados.msrepl_tran_version = dataReader.IsDBNull(dataReader.GetOrdinal("msrepl_tran_version")) ? default(Guid?) : Guid.Parse(dataReader["msrepl_tran_version"].ToString());
                        empleados.Registrado = dataReader.IsDBNull(dataReader.GetOrdinal("Registrado")) ? default(int?) : int.Parse(dataReader["Registrado"].ToString());
                        empleados.Imss = dataReader.IsDBNull(dataReader.GetOrdinal("Imss")) ? null : dataReader["Imss"].ToString();
                        empleados.Dias_Semana = dataReader.IsDBNull(dataReader.GetOrdinal("Dias_Semana")) ? default(int?) : int.Parse(dataReader["Dias_Semana"].ToString());
                        empleados.Fecha_Ingresos = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Ingresos")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Ingresos"].ToString());
                        empleados.Pagos_HExtras = dataReader.IsDBNull(dataReader.GetOrdinal("Pagos_HExtras")) ? null : dataReader["Pagos_HExtras"].ToString();
                        empleados.Fechas_Registro = dataReader.IsDBNull(dataReader.GetOrdinal("Fechas_Registro")) ? default(DateTime?) : DateTime.Parse(dataReader["Fechas_Registro"].ToString());
                        empleados.Unidad_Costos = dataReader.IsDBNull(dataReader.GetOrdinal("Unidad_Costos")) ? null : dataReader["Unidad_Costos"].ToString();
                        empleados.Fecha_Reingreso = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Reingreso")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Reingreso"].ToString());
                        empleados.Centro_Costos = dataReader.IsDBNull(dataReader.GetOrdinal("Centro_Costos")) ? null : dataReader["Centro_Costos"].ToString();
                        empleados.Numero_Nominas = dataReader.IsDBNull(dataReader.GetOrdinal("Numero_Nominas")) ? default(int?) : int.Parse(dataReader["Numero_Nominas"].ToString());
                        empleados.Remuneracion = dataReader.IsDBNull(dataReader.GetOrdinal("Remuneracion")) ? null : dataReader["Remuneracion"].ToString();
                        empleados.Fecha_Alta_Imss = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Alta_Imss")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Alta_Imss"].ToString());
                        empleados.Fecha_Baja_Sistema = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Baja_Sistema")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Baja_Sistema"].ToString());
                        empleados.Estatus_Edicion = dataReader.IsDBNull(dataReader.GetOrdinal("Estatus_Edicion")) ? default(int?) : int.Parse(dataReader["Estatus_Edicion"].ToString());
                        empleados.Fecha_Modificacion = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Modificacion")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Modificacion"].ToString());
                        empleados.Bono = dataReader.IsDBNull(dataReader.GetOrdinal("Bono")) ? default(bool?) : bool.Parse(dataReader["Bono"].ToString());
                        empleados.Responsable_Bono = dataReader.IsDBNull(dataReader.GetOrdinal("Responsable_Bono")) ? null : dataReader["Responsable_Bono"].ToString();
                        empleadosCollection.Add(empleados);

                    }
                }

                dataReader.Close();
                dataReader.Dispose();
                return empleadosCollection;
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message.ToString());
            }

        }

        public Entities.SoluglobChecador.Empleados Update(Entities.SoluglobChecador.Empleados objEmpleados)
        {
            empleados = new Entities.SoluglobChecador.Empleados();
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                parameters.Add(new SqlParameter() { ParameterName = "Numero_Nomina", Value = objEmpleados.Numero_Nomina });
                parameters.Add(new SqlParameter() { ParameterName = "Nombres", Value = objEmpleados.Nombres });
                parameters.Add(new SqlParameter() { ParameterName = "Apellidos", Value = objEmpleados.Apellidos });
                parameters.Add(new SqlParameter() { ParameterName = "Puesto", Value = objEmpleados.Puesto });
                parameters.Add(new SqlParameter() { ParameterName = "Departamento", Value = objEmpleados.Departamento });
                parameters.Add(new SqlParameter() { ParameterName = "Telefono", Value = objEmpleados.Telefono });
                parameters.Add(new SqlParameter() { ParameterName = "Huella_Template", Value = objEmpleados.Huella_Template });
                parameters.Add(new SqlParameter() { ParameterName = "Huella_Img1", Value = objEmpleados.Huella_Img1 });
                parameters.Add(new SqlParameter() { ParameterName = "Huella_Img2", Value = objEmpleados.Huella_Img2 });
                parameters.Add(new SqlParameter() { ParameterName = "Huella_Img3", Value = objEmpleados.Huella_Img3 });
                parameters.Add(new SqlParameter() { ParameterName = "Huella_Img4", Value = objEmpleados.Huella_Img4 });
                parameters.Add(new SqlParameter() { ParameterName = "Estatus", Value = objEmpleados.Estatus });
                parameters.Add(new SqlParameter() { ParameterName = "Fecha_Alta", Value = objEmpleados.Fecha_Alta });
                parameters.Add(new SqlParameter() { ParameterName = "Fecha_Baja", Value = objEmpleados.Fecha_Baja });
                parameters.Add(new SqlParameter() { ParameterName = "Empresa", Value = objEmpleados.Empresa });
                parameters.Add(new SqlParameter() { ParameterName = "Ubicacion", Value = objEmpleados.Ubicacion });
                parameters.Add(new SqlParameter() { ParameterName = "MotivoBaja", Value = objEmpleados.MotivoBaja });
                parameters.Add(new SqlParameter() { ParameterName = "Caso_Especial", Value = objEmpleados.Caso_Especial });
                parameters.Add(new SqlParameter() { ParameterName = "msrepl_tran_version", Value = objEmpleados.msrepl_tran_version });
                parameters.Add(new SqlParameter() { ParameterName = "Registrado", Value = objEmpleados.Registrado });
                parameters.Add(new SqlParameter() { ParameterName = "Imss", Value = objEmpleados.Imss });
                parameters.Add(new SqlParameter() { ParameterName = "Dias_semana", Value = objEmpleados.Dias_Semana });
                parameters.Add(new SqlParameter() { ParameterName = "fecha_ingresos", Value = objEmpleados.Fecha_Ingresos });
                parameters.Add(new SqlParameter() { ParameterName = "pagos_hextras", Value = objEmpleados.Pagos_HExtras });
                parameters.Add(new SqlParameter() { ParameterName = "Fechas_registro", Value = objEmpleados.Fechas_Registro });
                parameters.Add(new SqlParameter() { ParameterName = "unidad_costos", Value = objEmpleados.Unidad_Costos });
                parameters.Add(new SqlParameter() { ParameterName = "Fecha_Reingreso", Value = objEmpleados.Fecha_Reingreso });
                parameters.Add(new SqlParameter() { ParameterName = "Centro_costos", Value = objEmpleados.Centro_Costos });
                parameters.Add(new SqlParameter() { ParameterName = "Numero_Nominas", Value = objEmpleados.Numero_Nominas });
                parameters.Add(new SqlParameter() { ParameterName = "Remuneracion", Value = objEmpleados.Remuneracion });
                parameters.Add(new SqlParameter() { ParameterName = "Fecha_Alta_Imss", Value = objEmpleados.Fecha_Alta_Imss });
                parameters.Add(new SqlParameter() { ParameterName = "Fecha_Baja_sistema", Value = objEmpleados.Fecha_Baja_Sistema });
                parameters.Add(new SqlParameter() { ParameterName = "Estatus_Edicion", Value = objEmpleados.Estatus_Edicion });
                parameters.Add(new SqlParameter() { ParameterName = "Fecha_Modificacion", Value = objEmpleados.Fecha_Modificacion });
                parameters.Add(new SqlParameter() { ParameterName = "Bono", Value = objEmpleados.Bono });
                parameters.Add(new SqlParameter() { ParameterName = "Responsable_Bono", Value = objEmpleados.Responsable_Bono });

                using (dataReader = this.connection.ExcuteSP("prc_Empleados_Update", parameters))
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            empleados.Numero_Nomina = dataReader.IsDBNull(dataReader.GetOrdinal("Numero_Nomina")) ? default(int) : int.Parse(dataReader["Numero_Nomina"].ToString());
                            empleados.Nombres = dataReader.IsDBNull(dataReader.GetOrdinal("Nombres")) ? null : dataReader["Nombres"].ToString();
                            empleados.Apellidos = dataReader.IsDBNull(dataReader.GetOrdinal("Apellidos")) ? null : dataReader["Apellidos"].ToString();
                            empleados.Puesto = dataReader.IsDBNull(dataReader.GetOrdinal("Puesto")) ? null : dataReader["Puesto"].ToString();
                            empleados.Departamento = dataReader.IsDBNull(dataReader.GetOrdinal("Departamento")) ? null : dataReader["Departamento"].ToString();
                            empleados.Telefono = dataReader.IsDBNull(dataReader.GetOrdinal("Telefono")) ? null : dataReader["Telefono"].ToString();
                            empleados.Huella_Template = dataReader.IsDBNull(dataReader.GetOrdinal("Huella_Template")) ? null : dataReader["Huella_Template"].ToString();
                            empleados.Huella_Img1 = dataReader.IsDBNull(dataReader.GetOrdinal("Huella_Img1")) ? null : dataReader["Huella_Img1"].ToString();
                            empleados.Huella_Img2 = dataReader.IsDBNull(dataReader.GetOrdinal("Huella_Img2")) ? null : dataReader["Huella_Img2"].ToString();
                            empleados.Huella_Img3 = dataReader.IsDBNull(dataReader.GetOrdinal("Huella_Img3")) ? null : dataReader["Huella_Img3"].ToString();
                            empleados.Huella_Img4 = dataReader.IsDBNull(dataReader.GetOrdinal("Huella_Img4")) ? null : dataReader["Huella_Img4"].ToString();
                            empleados.Estatus = dataReader.IsDBNull(dataReader.GetOrdinal("Estatus")) ? default(bool) : bool.Parse(dataReader["Estatus"].ToString());
                            empleados.Fecha_Alta = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Alta")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Alta"].ToString());
                            empleados.Fecha_Baja = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Baja")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Baja"].ToString());
                            empleados.Empresa = dataReader.IsDBNull(dataReader.GetOrdinal("Empresa")) ? null : dataReader["Empresa"].ToString();
                            empleados.Ubicacion = dataReader.IsDBNull(dataReader.GetOrdinal("Ubicacion")) ? null : dataReader["Ubicacion"].ToString();
                            empleados.MotivoBaja = dataReader.IsDBNull(dataReader.GetOrdinal("MotivoBaja")) ? null : dataReader["MotivoBaja"].ToString();
                            empleados.Caso_Especial = dataReader.IsDBNull(dataReader.GetOrdinal("Caso_Especial")) ? default(bool) : bool.Parse(dataReader["Caso_Especial"].ToString());
                            empleados.msrepl_tran_version = dataReader.IsDBNull(dataReader.GetOrdinal("msrepl_tran_version")) ? default(Guid?) : Guid.Parse(dataReader["msrepl_tran_version"].ToString());
                            empleados.Registrado = dataReader.IsDBNull(dataReader.GetOrdinal("Registrado")) ? default(int?) : int.Parse(dataReader["Registrado"].ToString());
                            empleados.Imss = dataReader.IsDBNull(dataReader.GetOrdinal("Imss")) ? null : dataReader["Imss"].ToString();
                            empleados.Dias_Semana = dataReader.IsDBNull(dataReader.GetOrdinal("Dias_Semana")) ? default(int?) : int.Parse(dataReader["Dias_Semana"].ToString());
                            empleados.Fecha_Ingresos = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Ingresos")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Ingresos"].ToString());
                            empleados.Pagos_HExtras = dataReader.IsDBNull(dataReader.GetOrdinal("Pagos_HExtras")) ? null : dataReader["Pagos_HExtras"].ToString();
                            empleados.Fechas_Registro = dataReader.IsDBNull(dataReader.GetOrdinal("Fechas_Registro")) ? default(DateTime?) : DateTime.Parse(dataReader["Fechas_Registro"].ToString());
                            empleados.Unidad_Costos = dataReader.IsDBNull(dataReader.GetOrdinal("Unidad_Costos")) ? null : dataReader["Unidad_Costos"].ToString();
                            empleados.Fecha_Reingreso = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Reingreso")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Reingreso"].ToString());
                            empleados.Centro_Costos = dataReader.IsDBNull(dataReader.GetOrdinal("Centro_Costos")) ? null : dataReader["Centro_Costos"].ToString();
                            empleados.Numero_Nominas = dataReader.IsDBNull(dataReader.GetOrdinal("Numero_Nominas")) ? default(int?) : int.Parse(dataReader["Numero_Nominas"].ToString());
                            empleados.Remuneracion = dataReader.IsDBNull(dataReader.GetOrdinal("Remuneracion")) ? null : dataReader["Remuneracion"].ToString();
                            empleados.Fecha_Alta_Imss = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Alta_Imss")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Alta_Imss"].ToString());
                            empleados.Fecha_Baja_Sistema = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Baja_Sistema")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Baja_Sistema"].ToString());
                            empleados.Estatus_Edicion = dataReader.IsDBNull(dataReader.GetOrdinal("Estatus_Edicion")) ? default(int?) : int.Parse(dataReader["Estatus_Edicion"].ToString());
                            empleados.Fecha_Modificacion = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Modificacion")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Modificacion"].ToString());
                            empleados.Bono = dataReader.IsDBNull(dataReader.GetOrdinal("Bono")) ? default(bool?) : bool.Parse(dataReader["Bono"].ToString());
                            empleados.Responsable_Bono = dataReader.IsDBNull(dataReader.GetOrdinal("Responsable_Bono")) ? null : dataReader["Responsable_Bono"].ToString();
                        }
                    }

                    dataReader.Close();
                    dataReader.Dispose();
                }

                return empleados;
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message.ToString());
            }
        }

        public void Delete(int NumNomina, int Estatus)
        {
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter() { ParameterName = "Numero_Nomina", Value = NumNomina });
                parameters.Add(new SqlParameter() { ParameterName = "Estatus", Value = Estatus });

                this.connection.ExcuteScalar("prc_Empleados_Delete", parameters);
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message);
            }

        }

        public Entities.QProcess.Empleados.AltaSoluglob GetOneSG(int IdEntrevistaCandidato)
        {
            Entities.QProcess.Empleados.AltaSoluglob empleado = new Entities.QProcess.Empleados.AltaSoluglob();
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter() { ParameterName = "IdEntrevistaCandidato", Value = IdEntrevistaCandidato });
                using (dataReader = this.connection.ExcuteSP("Prc_GetLayoutSoluglob", parameters))
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            empleado.Id_Per = dataReader.IsDBNull(dataReader.GetOrdinal("Id_Per")) ? default(int) : int.Parse(dataReader["Id_Per"].ToString());
                            empleado.Num_Checador = dataReader.IsDBNull(dataReader.GetOrdinal("Num_Checador")) ? default(int) : int.Parse(dataReader["Num_Checador"].ToString());
                            empleado.Nomi_Camb = dataReader.IsDBNull(dataReader.GetOrdinal("Nomi_Camb")) ? default(int) : int.Parse(dataReader["Nomi_Camb"].ToString());
                            empleado.FecReg = dataReader.IsDBNull(dataReader.GetOrdinal("FecReg")) ? default(DateTime) : DateTime.Parse(dataReader["FecReg"].ToString());
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
                            empleado.FecMod = dataReader.IsDBNull(dataReader.GetOrdinal("FecMod")) ? default(DateTime) : DateTime.Parse(dataReader["FecMod"].ToString());
                            empleado.AplicaBono = dataReader.IsDBNull(dataReader.GetOrdinal("AplicaBono")) ? default(int) : int.Parse(dataReader["AplicaBono"].ToString());
                            empleado.Id_Vac = dataReader.IsDBNull(dataReader.GetOrdinal("Id_Vac")) ? default(int) : int.Parse(dataReader["Id_Vac"].ToString());
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
                            empleado.Fecha_Alta = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Alta")) ? default(DateTime) : DateTime.Parse(dataReader["Fecha_Alta"].ToString());
                            empleado.Fecha_Baja = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Baja")) ? default(DateTime) : DateTime.Parse(dataReader["Fecha_Baja"].ToString());
                            empleado.Empresa = dataReader.IsDBNull(dataReader.GetOrdinal("Empresa")) ? null : dataReader["Empresa"].ToString();
                            empleado.Ubicacion_usuarios = dataReader.IsDBNull(dataReader.GetOrdinal("Ubicacion_usuarios")) ? null : dataReader["Ubicacion_usuarios"].ToString();
                            empleado.MotivoBaja = dataReader.IsDBNull(dataReader.GetOrdinal("MotivoBaja")) ? null : dataReader["MotivoBaja"].ToString();
                            empleado.Caso_Especial = dataReader.IsDBNull(dataReader.GetOrdinal("Caso_Especial")) ? default(bool?) : bool.Parse(dataReader["Caso_Especial"].ToString());
                            empleado.msrepl_tran_version = dataReader.IsDBNull(dataReader.GetOrdinal("msrepl_tran_version")) ? default(Guid) : Guid.Parse(dataReader["msrepl_tran_version"].ToString());
                            empleado.Registrado = dataReader.IsDBNull(dataReader.GetOrdinal("Registrado")) ? default(int?) : int.Parse(dataReader["Registrado"].ToString());
                            empleado.Imss = dataReader.IsDBNull(dataReader.GetOrdinal("Imss")) ? null : dataReader["Imss"].ToString();
                            empleado.Dias_semana = dataReader.IsDBNull(dataReader.GetOrdinal("Dias_semana")) ? default(int?) : int.Parse(dataReader["Dias_semana"].ToString());
                            empleado.fecha_ingresos = dataReader.IsDBNull(dataReader.GetOrdinal("fecha_ingresos")) ? default(DateTime?) : DateTime.Parse(dataReader["fecha_ingresos"].ToString());
                            empleado.pagos_hextras = dataReader.IsDBNull(dataReader.GetOrdinal("pagos_hextras")) ? null : dataReader["pagos_hextras"].ToString();
                            empleado.Fechas_registro = dataReader.IsDBNull(dataReader.GetOrdinal("Fechas_registro")) ? default(DateTime?) : DateTime.Parse(dataReader["Fechas_registro"].ToString());
                            empleado.unidad_costos = dataReader.IsDBNull(dataReader.GetOrdinal("unidad_costos")) ? null : dataReader["unidad_costos"].ToString();
                            empleado.Fecha_Reingreso = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Reingreso")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Reingreso"].ToString());
                            empleado.Centro_costos = dataReader.IsDBNull(dataReader.GetOrdinal("Centro_Costos")) ? null : dataReader["Centro_Costos"].ToString();
                            empleado.Numero_Nominas = dataReader.IsDBNull(dataReader.GetOrdinal("Numero_Nominas")) ? default(int?) : int.Parse(dataReader["Numero_Nominas"].ToString());
                            empleado.Remuneracion = dataReader.IsDBNull(dataReader.GetOrdinal("Remuneracion")) ? null : dataReader["Remuneracion"].ToString();
                            empleado.Fecha_Alta_Imss = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Alta_Imss")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Alta_Imss"].ToString());
                            empleado.Fecha_Baja_sistema = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Baja_sistema")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Baja_sistema"].ToString());
                            empleado.Estatus_Edicion = dataReader.IsDBNull(dataReader.GetOrdinal("Estatus_Edicion")) ? default(int?) : int.Parse(dataReader["Estatus_Edicion"].ToString());
                            empleado.Fecha_Modificacion = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Modificacion")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Modificacion"].ToString());
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

    }
}
