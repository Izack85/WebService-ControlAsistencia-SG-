using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integra.Services.Data.SoluglobChecador
{
    public class Usuarios
    {
        List<Entities.SoluglobChecador.Usuarios> usuariosCollection = null;
        Entities.SoluglobChecador.Usuarios usuarios = null;
        SqlDataReader dataReader = null;

        public Connection connection = null;

        public Usuarios()
        {
            this.connection = Connection.Instance;
        }
        public Usuarios(bool isTransaction)
        {
            this.connection = new Connection();
        }
        public Usuarios(Connection connection)
        {
            this.connection = connection;
        }

        public Entities.SoluglobChecador.Usuarios Insert(Entities.SoluglobChecador.Usuarios objUsuarios)
        {
            usuarios = new Entities.SoluglobChecador.Usuarios();
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                parameters.Add(new SqlParameter() { ParameterName = "Numero_Nomina", Value = objUsuarios.Numero_Nomina });
                parameters.Add(new SqlParameter() { ParameterName = "Nombres", Value = objUsuarios.Nombres });
                parameters.Add(new SqlParameter() { ParameterName = "Apellidos", Value = objUsuarios.Apellidos });
                parameters.Add(new SqlParameter() { ParameterName = "Puesto", Value = objUsuarios.Puesto });
                parameters.Add(new SqlParameter() { ParameterName = "Departamento", Value = objUsuarios.Departamento });
                parameters.Add(new SqlParameter() { ParameterName = "Telefono", Value = objUsuarios.Telefono });
                parameters.Add(new SqlParameter() { ParameterName = "Huella_Bin1", Value = objUsuarios.Huella_Bin1 });
                parameters.Add(new SqlParameter() { ParameterName = "Huella_Img1", Value = objUsuarios.Huella_Img1 });
                parameters.Add(new SqlParameter() { ParameterName = "Huella_Bin2", Value = objUsuarios.Huella_Bin2 });
                parameters.Add(new SqlParameter() { ParameterName = "Huella_Bin3", Value = objUsuarios.Huella_Bin3 });
                parameters.Add(new SqlParameter() { ParameterName = "Huella_Bin4", Value = objUsuarios.Huella_Bin4 });
                parameters.Add(new SqlParameter() { ParameterName = "Estatus", Value = objUsuarios.Estatus });
                parameters.Add(new SqlParameter() { ParameterName = "Fecha_Alta", Value = objUsuarios.Fecha_Alta });
                parameters.Add(new SqlParameter() { ParameterName = "Fecha_Baja", Value = objUsuarios.Fecha_Baja });
                parameters.Add(new SqlParameter() { ParameterName = "Empresa", Value = objUsuarios.Empresa });
                parameters.Add(new SqlParameter() { ParameterName = "Ubicacion", Value = objUsuarios.Ubicacion });
                parameters.Add(new SqlParameter() { ParameterName = "MotivoBaja", Value = objUsuarios.MotivoBaja });
                parameters.Add(new SqlParameter() { ParameterName = "Caso_Especial", Value = objUsuarios.Caso_Especial });
                parameters.Add(new SqlParameter() { ParameterName = "msrepl_tran_version", Value = objUsuarios.msrepl_tran_version });
                parameters.Add(new SqlParameter() { ParameterName = "Registrado", Value = objUsuarios.Registrado });
                parameters.Add(new SqlParameter() { ParameterName = "Imss", Value = objUsuarios.Imss });
                parameters.Add(new SqlParameter() { ParameterName = "Dias_semana", Value = objUsuarios.Dias_semana });
                parameters.Add(new SqlParameter() { ParameterName = "fecha_ingresos", Value = objUsuarios.fecha_ingresos });
                parameters.Add(new SqlParameter() { ParameterName = "pagos_hextras", Value = objUsuarios.pagos_hextras });
                parameters.Add(new SqlParameter() { ParameterName = "Fechas_registro", Value = objUsuarios.Fechas_registro });
                parameters.Add(new SqlParameter() { ParameterName = "unidad_costos", Value = objUsuarios.unidad_costos });
                parameters.Add(new SqlParameter() { ParameterName = "Fecha_Reingreso", Value = objUsuarios.Fecha_Reingreso });
                parameters.Add(new SqlParameter() { ParameterName = "Centro_costos", Value = objUsuarios.Centro_costos });
                parameters.Add(new SqlParameter() { ParameterName = "Numero_Nominas", Value = objUsuarios.Numero_Nominas });
                parameters.Add(new SqlParameter() { ParameterName = "Remuneracion", Value = objUsuarios.Remuneracion });
                parameters.Add(new SqlParameter() { ParameterName = "Fecha_Alta_Imss", Value = objUsuarios.Fecha_Alta_Imss });
                parameters.Add(new SqlParameter() { ParameterName = "Fecha_Baja_sistema", Value = objUsuarios.Fecha_Baja_sistema });
                parameters.Add(new SqlParameter() { ParameterName = "Estatus_Edicion", Value = objUsuarios.Estatus_Edicion });
                parameters.Add(new SqlParameter() { ParameterName = "Fecha_Modificacion", Value = objUsuarios.Fecha_Modificacion });
                parameters.Add(new SqlParameter() { ParameterName = "Bono", Value = objUsuarios.Bono });
                parameters.Add(new SqlParameter() { ParameterName = "Responsable_Bono", Value = objUsuarios.Responsable_Bono });

                using (dataReader = this.connection.ExcuteSP("prc_Usuarios_Insert", parameters))
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            usuarios.Numero_Nomina = dataReader.IsDBNull(dataReader.GetOrdinal("Numero_Nomina")) ? default(int) : int.Parse(dataReader["Numero_Nomina"].ToString());
                            usuarios.Nombres = dataReader.IsDBNull(dataReader.GetOrdinal("Nombres")) ? null : dataReader["Nombres"].ToString();
                            usuarios.Apellidos = dataReader.IsDBNull(dataReader.GetOrdinal("Apellidos")) ? null : dataReader["Apellidos"].ToString();
                            usuarios.Puesto = dataReader.IsDBNull(dataReader.GetOrdinal("Puesto")) ? null : dataReader["Puesto"].ToString();
                            usuarios.Departamento = dataReader.IsDBNull(dataReader.GetOrdinal("Departamento")) ? null : dataReader["Departamento"].ToString();
                            usuarios.Telefono = dataReader.IsDBNull(dataReader.GetOrdinal("Telefono")) ? null : dataReader["Telefono"].ToString();
                            usuarios.Huella_Bin1 = dataReader.IsDBNull(dataReader.GetOrdinal("Huella_Bin1")) ? null : dataReader["Huella_Bin1"].ToString();
                            usuarios.Huella_Img1 = dataReader.IsDBNull(dataReader.GetOrdinal("Huella_Img1")) ? null : dataReader["Huella_Img1"].ToString();
                            usuarios.Huella_Bin2 = dataReader.IsDBNull(dataReader.GetOrdinal("Huella_Bin2")) ? null : dataReader["Huella_Bin2"].ToString();
                            usuarios.Huella_Bin3 = dataReader.IsDBNull(dataReader.GetOrdinal("Huella_Bin3")) ? null : dataReader["Huella_Bin3"].ToString();
                            usuarios.Huella_Bin4 = dataReader.IsDBNull(dataReader.GetOrdinal("Huella_Bin4")) ? null : dataReader["Huella_Bin4"].ToString();
                            usuarios.Estatus = dataReader.IsDBNull(dataReader.GetOrdinal("Estatus")) ? default(bool) : bool.Parse(dataReader["Estatus"].ToString());
                            usuarios.Fecha_Alta = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Alta")) ? default(DateTime) : DateTime.Parse(dataReader["Fecha_Alta"].ToString());
                            usuarios.Fecha_Baja = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Baja")) ? default(DateTime) : DateTime.Parse(dataReader["Fecha_Baja"].ToString());
                            usuarios.Empresa = dataReader.IsDBNull(dataReader.GetOrdinal("Empresa")) ? null : dataReader["Empresa"].ToString();
                            usuarios.Ubicacion = dataReader.IsDBNull(dataReader.GetOrdinal("Ubicacion")) ? null : dataReader["Ubicacion"].ToString();
                            usuarios.MotivoBaja = dataReader.IsDBNull(dataReader.GetOrdinal("MotivoBaja")) ? null : dataReader["MotivoBaja"].ToString();
                            usuarios.Caso_Especial = dataReader.IsDBNull(dataReader.GetOrdinal("Caso_Especial")) ? default(bool) : bool.Parse(dataReader["Caso_Especial"].ToString());
                            usuarios.msrepl_tran_version = dataReader.IsDBNull(dataReader.GetOrdinal("msrepl_tran_version")) ? default(Guid?) : Guid.Parse(dataReader["msrepl_tran_version"].ToString());
                            usuarios.Registrado = dataReader.IsDBNull(dataReader.GetOrdinal("Registrado")) ? default(int?) : int.Parse(dataReader["Registrado"].ToString());
                            usuarios.Imss = dataReader.IsDBNull(dataReader.GetOrdinal("Imss")) ? null : dataReader["Imss"].ToString();
                            usuarios.Dias_semana = dataReader.IsDBNull(dataReader.GetOrdinal("Dias_semana")) ? default(int?) : int.Parse(dataReader["Dias_semana"].ToString());
                            usuarios.fecha_ingresos = dataReader.IsDBNull(dataReader.GetOrdinal("fecha_ingresos")) ? default(DateTime) : DateTime.Parse(dataReader["fecha_ingresos"].ToString());
                            usuarios.pagos_hextras = dataReader.IsDBNull(dataReader.GetOrdinal("pagos_hextras")) ? null : dataReader["pagos_hextras"].ToString();
                            usuarios.Fechas_registro = dataReader.IsDBNull(dataReader.GetOrdinal("Fechas_registro")) ? default(DateTime) : DateTime.Parse(dataReader["Fechas_registro"].ToString());
                            usuarios.unidad_costos = dataReader.IsDBNull(dataReader.GetOrdinal("unidad_costos")) ? null : dataReader["unidad_costos"].ToString();
                            usuarios.Fecha_Reingreso = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Reingreso")) ? default(DateTime) : DateTime.Parse(dataReader["Fecha_Reingreso"].ToString());
                            usuarios.Centro_costos = dataReader.IsDBNull(dataReader.GetOrdinal("Centro_costos")) ? null : dataReader["Centro_costos"].ToString();
                            usuarios.Numero_Nominas = dataReader.IsDBNull(dataReader.GetOrdinal("Numero_Nominas")) ? default(int?) : int.Parse(dataReader["Numero_Nominas"].ToString());
                            usuarios.Remuneracion = dataReader.IsDBNull(dataReader.GetOrdinal("Remuneracion")) ? null : dataReader["Remuneracion"].ToString();
                            usuarios.Fecha_Alta_Imss = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Alta_Imss")) ? default(DateTime) : DateTime.Parse(dataReader["Fecha_Alta_Imss"].ToString());
                            usuarios.Fecha_Baja_sistema = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Baja_sistema")) ? default(DateTime) : DateTime.Parse(dataReader["Fecha_Baja_sistema"].ToString());
                            usuarios.Estatus_Edicion = dataReader.IsDBNull(dataReader.GetOrdinal("Estatus_Edicion")) ? default(int?) : int.Parse(dataReader["Estatus_Edicion"].ToString());
                            usuarios.Fecha_Modificacion = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Modificacion")) ? default(DateTime) : DateTime.Parse(dataReader["Fecha_Modificacion"].ToString());
                            usuarios.Bono = dataReader.IsDBNull(dataReader.GetOrdinal("Bono")) ? default(bool?) : bool.Parse(dataReader["Bono"].ToString());
                            usuarios.Responsable_Bono = dataReader.IsDBNull(dataReader.GetOrdinal("Responsable_Bono")) ? null : dataReader["Responsable_Bono"].ToString();
                        }
                    }

                    dataReader.Close();
                    dataReader.Dispose();
                }

                return usuarios;
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message.ToString());
            }
        }

        public Entities.SoluglobChecador.Usuarios GetOne(int NumNomina)
        {
            usuarios = new Entities.SoluglobChecador.Usuarios();
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter() { ParameterName = "Numero_Nomina", Value = NumNomina });

                using (dataReader = this.connection.ExcuteSP("prc_Usuarios_GetOne", parameters))
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            usuarios.Numero_Nomina = dataReader.IsDBNull(dataReader.GetOrdinal("Numero_Nomina")) ? default(int) : int.Parse(dataReader["Numero_Nomina"].ToString());
                            usuarios.Nombres = dataReader.IsDBNull(dataReader.GetOrdinal("Nombres")) ? null : dataReader["Nombres"].ToString();
                            usuarios.Apellidos = dataReader.IsDBNull(dataReader.GetOrdinal("Apellidos")) ? null : dataReader["Apellidos"].ToString();
                            usuarios.Puesto = dataReader.IsDBNull(dataReader.GetOrdinal("Puesto")) ? null : dataReader["Puesto"].ToString();
                            usuarios.Departamento = dataReader.IsDBNull(dataReader.GetOrdinal("Departamento")) ? null : dataReader["Departamento"].ToString();
                            usuarios.Telefono = dataReader.IsDBNull(dataReader.GetOrdinal("Telefono")) ? null : dataReader["Telefono"].ToString();
                            usuarios.Huella_Bin1 = dataReader.IsDBNull(dataReader.GetOrdinal("Huella_Bin1")) ? null : dataReader["Huella_Bin1"].ToString();
                            usuarios.Huella_Img1 = dataReader.IsDBNull(dataReader.GetOrdinal("Huella_Img1")) ? null : dataReader["Huella_Img1"].ToString();
                            usuarios.Huella_Bin2 = dataReader.IsDBNull(dataReader.GetOrdinal("Huella_Bin2")) ? null : dataReader["Huella_Bin2"].ToString();
                            usuarios.Huella_Bin3 = dataReader.IsDBNull(dataReader.GetOrdinal("Huella_Bin3")) ? null : dataReader["Huella_Bin3"].ToString();
                            usuarios.Huella_Bin4 = dataReader.IsDBNull(dataReader.GetOrdinal("Huella_Bin4")) ? null : dataReader["Huella_Bin4"].ToString();
                            usuarios.Estatus = dataReader.IsDBNull(dataReader.GetOrdinal("Estatus")) ? default(bool) : bool.Parse(dataReader["Estatus"].ToString());
                            usuarios.Fecha_Alta = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Alta")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Alta"].ToString());
                            usuarios.Fecha_Baja = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Baja")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Baja"].ToString());
                            usuarios.Empresa = dataReader.IsDBNull(dataReader.GetOrdinal("Empresa")) ? null : dataReader["Empresa"].ToString();
                            usuarios.Ubicacion = dataReader.IsDBNull(dataReader.GetOrdinal("Ubicacion")) ? null : dataReader["Ubicacion"].ToString();
                            usuarios.MotivoBaja = dataReader.IsDBNull(dataReader.GetOrdinal("MotivoBaja")) ? null : dataReader["MotivoBaja"].ToString();
                            usuarios.Caso_Especial = dataReader.IsDBNull(dataReader.GetOrdinal("Caso_Especial")) ? default(bool) : bool.Parse(dataReader["Caso_Especial"].ToString());
                            usuarios.msrepl_tran_version = dataReader.IsDBNull(dataReader.GetOrdinal("msrepl_tran_version")) ? default(Guid?) : Guid.Parse(dataReader["msrepl_tran_version"].ToString());
                            usuarios.Registrado = dataReader.IsDBNull(dataReader.GetOrdinal("Registrado")) ? default(int?) : int.Parse(dataReader["Registrado"].ToString());
                            usuarios.Imss = dataReader.IsDBNull(dataReader.GetOrdinal("Imss")) ? null : dataReader["Imss"].ToString();
                            usuarios.Dias_semana = dataReader.IsDBNull(dataReader.GetOrdinal("Dias_semana")) ? default(int?) : int.Parse(dataReader["Dias_semana"].ToString());
                            usuarios.fecha_ingresos = dataReader.IsDBNull(dataReader.GetOrdinal("fecha_ingresos")) ? default(DateTime?) : DateTime.Parse(dataReader["fecha_ingresos"].ToString());
                            usuarios.pagos_hextras = dataReader.IsDBNull(dataReader.GetOrdinal("pagos_hextras")) ? null : dataReader["pagos_hextras"].ToString();
                            usuarios.Fechas_registro = dataReader.IsDBNull(dataReader.GetOrdinal("Fechas_registro")) ? default(DateTime?) : DateTime.Parse(dataReader["Fechas_registro"].ToString());
                            usuarios.unidad_costos = dataReader.IsDBNull(dataReader.GetOrdinal("unidad_costos")) ? null : dataReader["unidad_costos"].ToString();
                            usuarios.Fecha_Reingreso = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Reingreso")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Reingreso"].ToString());
                            usuarios.Centro_costos = dataReader.IsDBNull(dataReader.GetOrdinal("Centro_costos")) ? null : dataReader["Centro_costos"].ToString();
                            usuarios.Numero_Nominas = dataReader.IsDBNull(dataReader.GetOrdinal("Numero_Nominas")) ? default(int?) : int.Parse(dataReader["Numero_Nominas"].ToString());
                            usuarios.Remuneracion = dataReader.IsDBNull(dataReader.GetOrdinal("Remuneracion")) ? null : dataReader["Remuneracion"].ToString();
                            usuarios.Fecha_Alta_Imss = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Alta_Imss")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Alta_Imss"].ToString());
                            usuarios.Fecha_Baja_sistema = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Baja_sistema")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Baja_sistema"].ToString());
                            usuarios.Estatus_Edicion = dataReader.IsDBNull(dataReader.GetOrdinal("Estatus_Edicion")) ? default(int?) : int.Parse(dataReader["Estatus_Edicion"].ToString());
                            usuarios.Fecha_Modificacion = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Modificacion")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Modificacion"].ToString());
                            usuarios.Bono = dataReader.IsDBNull(dataReader.GetOrdinal("Bono")) ? default(bool?) : bool.Parse(dataReader["Bono"].ToString());
                            usuarios.Responsable_Bono = dataReader.IsDBNull(dataReader.GetOrdinal("Responsable_Bono")) ? null : dataReader["Responsable_Bono"].ToString();

                        }
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }

                return usuarios;
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message.ToString());
            }

        }

        public List<Entities.SoluglobChecador.Usuarios> GetAll()
        {
            usuariosCollection = new List<Entities.SoluglobChecador.Usuarios>();
            try
            {
                dataReader = this.connection.ExcuteSP("prc_Usuarios_GetAll", null);

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        usuarios = new Entities.SoluglobChecador.Usuarios();
                        usuarios.Numero_Nomina = dataReader.IsDBNull(dataReader.GetOrdinal("Numero_Nomina")) ? default(int) : int.Parse(dataReader["Numero_Nomina"].ToString());
                        usuarios.Nombres = dataReader.IsDBNull(dataReader.GetOrdinal("Nombres")) ? null : dataReader["Nombres"].ToString();
                        usuarios.Apellidos = dataReader.IsDBNull(dataReader.GetOrdinal("Apellidos")) ? null : dataReader["Apellidos"].ToString();
                        usuarios.Puesto = dataReader.IsDBNull(dataReader.GetOrdinal("Puesto")) ? null : dataReader["Puesto"].ToString();
                        usuarios.Departamento = dataReader.IsDBNull(dataReader.GetOrdinal("Departamento")) ? null : dataReader["Departamento"].ToString();
                        usuarios.Telefono = dataReader.IsDBNull(dataReader.GetOrdinal("Telefono")) ? null : dataReader["Telefono"].ToString();
                        usuarios.Huella_Bin1 = dataReader.IsDBNull(dataReader.GetOrdinal("Huella_Bin1")) ? null : dataReader["Huella_Bin1"].ToString();
                        usuarios.Huella_Img1 = dataReader.IsDBNull(dataReader.GetOrdinal("Huella_Img1")) ? null : dataReader["Huella_Img1"].ToString();
                        usuarios.Huella_Bin2 = dataReader.IsDBNull(dataReader.GetOrdinal("Huella_Bin2")) ? null : dataReader["Huella_Bin2"].ToString();
                        usuarios.Huella_Bin3 = dataReader.IsDBNull(dataReader.GetOrdinal("Huella_Bin3")) ? null : dataReader["Huella_Bin3"].ToString();
                        usuarios.Huella_Bin4 = dataReader.IsDBNull(dataReader.GetOrdinal("Huella_Bin4")) ? null : dataReader["Huella_Bin4"].ToString();
                        usuarios.Estatus = dataReader.IsDBNull(dataReader.GetOrdinal("Estatus")) ? default(bool) : bool.Parse(dataReader["Estatus"].ToString());
                        usuarios.Fecha_Alta = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Alta")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Alta"].ToString());
                        usuarios.Fecha_Baja = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Baja")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Baja"].ToString());
                        usuarios.Empresa = dataReader.IsDBNull(dataReader.GetOrdinal("Empresa")) ? null : dataReader["Empresa"].ToString();
                        usuarios.Ubicacion = dataReader.IsDBNull(dataReader.GetOrdinal("Ubicacion")) ? null : dataReader["Ubicacion"].ToString();
                        usuarios.MotivoBaja = dataReader.IsDBNull(dataReader.GetOrdinal("MotivoBaja")) ? null : dataReader["MotivoBaja"].ToString();
                        usuarios.Caso_Especial = dataReader.IsDBNull(dataReader.GetOrdinal("Caso_Especial")) ? default(bool) : bool.Parse(dataReader["Caso_Especial"].ToString());
                        usuarios.msrepl_tran_version = dataReader.IsDBNull(dataReader.GetOrdinal("msrepl_tran_version")) ? default(Guid?) : Guid.Parse(dataReader["msrepl_tran_version"].ToString());
                        usuarios.Registrado = dataReader.IsDBNull(dataReader.GetOrdinal("Registrado")) ? default(int?) : int.Parse(dataReader["Registrado"].ToString());
                        usuarios.Imss = dataReader.IsDBNull(dataReader.GetOrdinal("Imss")) ? null : dataReader["Imss"].ToString();
                        usuarios.Dias_semana = dataReader.IsDBNull(dataReader.GetOrdinal("Dias_semana")) ? default(int?) : int.Parse(dataReader["Dias_semana"].ToString());
                        usuarios.fecha_ingresos = dataReader.IsDBNull(dataReader.GetOrdinal("fecha_ingresos")) ? default(DateTime?) : DateTime.Parse(dataReader["fecha_ingresos"].ToString());
                        usuarios.pagos_hextras = dataReader.IsDBNull(dataReader.GetOrdinal("pagos_hextras")) ? null : dataReader["pagos_hextras"].ToString();
                        usuarios.Fechas_registro = dataReader.IsDBNull(dataReader.GetOrdinal("Fechas_registro")) ? default(DateTime?) : DateTime.Parse(dataReader["Fechas_registro"].ToString());
                        usuarios.unidad_costos = dataReader.IsDBNull(dataReader.GetOrdinal("unidad_costos")) ? null : dataReader["unidad_costos"].ToString();
                        usuarios.Fecha_Reingreso = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Reingreso")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Reingreso"].ToString());
                        usuarios.Centro_costos = dataReader.IsDBNull(dataReader.GetOrdinal("Centro_costos")) ? null : dataReader["Centro_costos"].ToString();
                        usuarios.Numero_Nominas = dataReader.IsDBNull(dataReader.GetOrdinal("Numero_Nominas")) ? default(int?) : int.Parse(dataReader["Numero_Nominas"].ToString());
                        usuarios.Remuneracion = dataReader.IsDBNull(dataReader.GetOrdinal("Remuneracion")) ? null : dataReader["Remuneracion"].ToString();
                        usuarios.Fecha_Alta_Imss = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Alta_Imss")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Alta_Imss"].ToString());
                        usuarios.Fecha_Baja_sistema = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Baja_sistema")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Baja_sistema"].ToString());
                        usuarios.Estatus_Edicion = dataReader.IsDBNull(dataReader.GetOrdinal("Estatus_Edicion")) ? default(int?) : int.Parse(dataReader["Estatus_Edicion"].ToString());
                        usuarios.Fecha_Modificacion = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Modificacion")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Modificacion"].ToString());
                        usuarios.Bono = dataReader.IsDBNull(dataReader.GetOrdinal("Bono")) ? default(bool?) : bool.Parse(dataReader["Bono"].ToString());
                        usuarios.Responsable_Bono = dataReader.IsDBNull(dataReader.GetOrdinal("Responsable_Bono")) ? null : dataReader["Responsable_Bono"].ToString();
                        usuariosCollection.Add(usuarios);

                    }
                }

                dataReader.Close();
                dataReader.Dispose();
                return usuariosCollection;
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message.ToString());
            }

        }

        public Entities.SoluglobChecador.Usuarios Update(Entities.SoluglobChecador.Usuarios objUsuarios)
        {
            usuarios = new Entities.SoluglobChecador.Usuarios();
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                parameters.Add(new SqlParameter() { ParameterName = "Numero_Nomina", Value = objUsuarios.Numero_Nomina });
                parameters.Add(new SqlParameter() { ParameterName = "Nombres", Value = objUsuarios.Nombres });
                parameters.Add(new SqlParameter() { ParameterName = "Apellidos", Value = objUsuarios.Apellidos });
                parameters.Add(new SqlParameter() { ParameterName = "Puesto", Value = objUsuarios.Puesto });
                parameters.Add(new SqlParameter() { ParameterName = "Departamento", Value = objUsuarios.Departamento });
                parameters.Add(new SqlParameter() { ParameterName = "Telefono", Value = objUsuarios.Telefono });
                parameters.Add(new SqlParameter() { ParameterName = "Huella_Bin1", Value = objUsuarios.Huella_Bin1 });
                parameters.Add(new SqlParameter() { ParameterName = "Huella_Img1", Value = objUsuarios.Huella_Img1 });
                parameters.Add(new SqlParameter() { ParameterName = "Huella_Bin2", Value = objUsuarios.Huella_Bin2 });
                parameters.Add(new SqlParameter() { ParameterName = "Huella_Bin3", Value = objUsuarios.Huella_Bin3 });
                parameters.Add(new SqlParameter() { ParameterName = "Huella_Bin4", Value = objUsuarios.Huella_Bin4 });
                parameters.Add(new SqlParameter() { ParameterName = "Estatus", Value = objUsuarios.Estatus });
                parameters.Add(new SqlParameter() { ParameterName = "Fecha_Alta", Value = objUsuarios.Fecha_Alta });
                parameters.Add(new SqlParameter() { ParameterName = "Fecha_Baja", Value = objUsuarios.Fecha_Baja });
                parameters.Add(new SqlParameter() { ParameterName = "Empresa", Value = objUsuarios.Empresa });
                parameters.Add(new SqlParameter() { ParameterName = "Ubicacion", Value = objUsuarios.Ubicacion });
                parameters.Add(new SqlParameter() { ParameterName = "MotivoBaja", Value = objUsuarios.MotivoBaja });
                parameters.Add(new SqlParameter() { ParameterName = "Caso_Especial", Value = objUsuarios.Caso_Especial });
                parameters.Add(new SqlParameter() { ParameterName = "msrepl_tran_version", Value = objUsuarios.msrepl_tran_version });
                parameters.Add(new SqlParameter() { ParameterName = "Registrado", Value = objUsuarios.Registrado });
                parameters.Add(new SqlParameter() { ParameterName = "Imss", Value = objUsuarios.Imss });
                parameters.Add(new SqlParameter() { ParameterName = "Dias_semana", Value = objUsuarios.Dias_semana });
                parameters.Add(new SqlParameter() { ParameterName = "fecha_ingresos", Value = objUsuarios.fecha_ingresos });
                parameters.Add(new SqlParameter() { ParameterName = "pagos_hextras", Value = objUsuarios.pagos_hextras });
                parameters.Add(new SqlParameter() { ParameterName = "Fechas_registro", Value = objUsuarios.Fechas_registro });
                parameters.Add(new SqlParameter() { ParameterName = "unidad_costos", Value = objUsuarios.unidad_costos });
                parameters.Add(new SqlParameter() { ParameterName = "Fecha_Reingreso", Value = objUsuarios.Fecha_Reingreso });
                parameters.Add(new SqlParameter() { ParameterName = "Centro_costos", Value = objUsuarios.Centro_costos });
                parameters.Add(new SqlParameter() { ParameterName = "Numero_Nominas", Value = objUsuarios.Numero_Nominas });
                parameters.Add(new SqlParameter() { ParameterName = "Remuneracion", Value = objUsuarios.Remuneracion });
                parameters.Add(new SqlParameter() { ParameterName = "Fecha_Alta_Imss", Value = objUsuarios.Fecha_Alta_Imss });
                parameters.Add(new SqlParameter() { ParameterName = "Fecha_Baja_sistema", Value = objUsuarios.Fecha_Baja_sistema });
                parameters.Add(new SqlParameter() { ParameterName = "Estatus_Edicion", Value = objUsuarios.Estatus_Edicion });
                parameters.Add(new SqlParameter() { ParameterName = "Fecha_Modificacion", Value = objUsuarios.Fecha_Modificacion });
                parameters.Add(new SqlParameter() { ParameterName = "Bono", Value = objUsuarios.Bono });
                parameters.Add(new SqlParameter() { ParameterName = "Responsable_Bono", Value = objUsuarios.Responsable_Bono });

                using (dataReader = this.connection.ExcuteSP("prc_Usuarios_Update", parameters))
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            usuarios.Numero_Nomina = dataReader.IsDBNull(dataReader.GetOrdinal("Numero_Nomina")) ? default(int) : int.Parse(dataReader["Numero_Nomina"].ToString());
                            usuarios.Nombres = dataReader.IsDBNull(dataReader.GetOrdinal("Nombres")) ? null : dataReader["Nombres"].ToString();
                            usuarios.Apellidos = dataReader.IsDBNull(dataReader.GetOrdinal("Apellidos")) ? null : dataReader["Apellidos"].ToString();
                            usuarios.Puesto = dataReader.IsDBNull(dataReader.GetOrdinal("Puesto")) ? null : dataReader["Puesto"].ToString();
                            usuarios.Departamento = dataReader.IsDBNull(dataReader.GetOrdinal("Departamento")) ? null : dataReader["Departamento"].ToString();
                            usuarios.Telefono = dataReader.IsDBNull(dataReader.GetOrdinal("Telefono")) ? null : dataReader["Telefono"].ToString();
                            usuarios.Huella_Bin1 = dataReader.IsDBNull(dataReader.GetOrdinal("Huella_Bin1")) ? null : dataReader["Huella_Bin1"].ToString();
                            usuarios.Huella_Img1 = dataReader.IsDBNull(dataReader.GetOrdinal("Huella_Img1")) ? null : dataReader["Huella_Img1"].ToString();
                            usuarios.Huella_Bin2 = dataReader.IsDBNull(dataReader.GetOrdinal("Huella_Bin2")) ? null : dataReader["Huella_Bin2"].ToString();
                            usuarios.Huella_Bin3 = dataReader.IsDBNull(dataReader.GetOrdinal("Huella_Bin3")) ? null : dataReader["Huella_Bin3"].ToString();
                            usuarios.Huella_Bin4 = dataReader.IsDBNull(dataReader.GetOrdinal("Huella_Bin4")) ? null : dataReader["Huella_Bin4"].ToString();
                            usuarios.Estatus = dataReader.IsDBNull(dataReader.GetOrdinal("Estatus")) ? default(bool) : bool.Parse(dataReader["Estatus"].ToString());
                            usuarios.Fecha_Alta = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Alta")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Alta"].ToString());
                            usuarios.Fecha_Baja = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Baja")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Baja"].ToString());
                            usuarios.Empresa = dataReader.IsDBNull(dataReader.GetOrdinal("Empresa")) ? null : dataReader["Empresa"].ToString();
                            usuarios.Ubicacion = dataReader.IsDBNull(dataReader.GetOrdinal("Ubicacion")) ? null : dataReader["Ubicacion"].ToString();
                            usuarios.MotivoBaja = dataReader.IsDBNull(dataReader.GetOrdinal("MotivoBaja")) ? null : dataReader["MotivoBaja"].ToString();
                            usuarios.Caso_Especial = dataReader.IsDBNull(dataReader.GetOrdinal("Caso_Especial")) ? default(bool) : bool.Parse(dataReader["Caso_Especial"].ToString());
                            usuarios.msrepl_tran_version = dataReader.IsDBNull(dataReader.GetOrdinal("msrepl_tran_version")) ? default(Guid?) : Guid.Parse(dataReader["msrepl_tran_version"].ToString());
                            usuarios.Registrado = dataReader.IsDBNull(dataReader.GetOrdinal("Registrado")) ? default(int?) : int.Parse(dataReader["Registrado"].ToString());
                            usuarios.Imss = dataReader.IsDBNull(dataReader.GetOrdinal("Imss")) ? null : dataReader["Imss"].ToString();
                            usuarios.Dias_semana = dataReader.IsDBNull(dataReader.GetOrdinal("Dias_semana")) ? default(int?) : int.Parse(dataReader["Dias_semana"].ToString());
                            usuarios.fecha_ingresos = dataReader.IsDBNull(dataReader.GetOrdinal("fecha_ingresos")) ? default(DateTime?) : DateTime.Parse(dataReader["fecha_ingresos"].ToString());
                            usuarios.pagos_hextras = dataReader.IsDBNull(dataReader.GetOrdinal("pagos_hextras")) ? null : dataReader["pagos_hextras"].ToString();
                            usuarios.Fechas_registro = dataReader.IsDBNull(dataReader.GetOrdinal("Fechas_registro")) ? default(DateTime?) : DateTime.Parse(dataReader["Fechas_registro"].ToString());
                            usuarios.unidad_costos = dataReader.IsDBNull(dataReader.GetOrdinal("unidad_costos")) ? null : dataReader["unidad_costos"].ToString();
                            usuarios.Fecha_Reingreso = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Reingreso")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Reingreso"].ToString());
                            usuarios.Centro_costos = dataReader.IsDBNull(dataReader.GetOrdinal("Centro_costos")) ? null : dataReader["Centro_costos"].ToString();
                            usuarios.Numero_Nominas = dataReader.IsDBNull(dataReader.GetOrdinal("Numero_Nominas")) ? default(int?) : int.Parse(dataReader["Numero_Nominas"].ToString());
                            usuarios.Remuneracion = dataReader.IsDBNull(dataReader.GetOrdinal("Remuneracion")) ? null : dataReader["Remuneracion"].ToString();
                            usuarios.Fecha_Alta_Imss = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Alta_Imss")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Alta_Imss"].ToString());
                            usuarios.Fecha_Baja_sistema = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Baja_sistema")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Baja_sistema"].ToString());
                            usuarios.Estatus_Edicion = dataReader.IsDBNull(dataReader.GetOrdinal("Estatus_Edicion")) ? default(int?) : int.Parse(dataReader["Estatus_Edicion"].ToString());
                            usuarios.Fecha_Modificacion = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Modificacion")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Modificacion"].ToString());
                            usuarios.Bono = dataReader.IsDBNull(dataReader.GetOrdinal("Bono")) ? default(bool?) : bool.Parse(dataReader["Bono"].ToString());
                            usuarios.Responsable_Bono = dataReader.IsDBNull(dataReader.GetOrdinal("Responsable_Bono")) ? null : dataReader["Responsable_Bono"].ToString();
                        }
                    }

                    dataReader.Close();
                    dataReader.Dispose();
                }

                return usuarios;
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

                this.connection.ExcuteScalar("prc_Usuarios_Delete", parameters);
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message);
            }

        }

        public void Drop(int NumNomina)
        {
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter() { ParameterName = "Numero_Nomina", Value = NumNomina });

                this.connection.ExcuteScalar("prc_Usuarios_Drop", parameters);
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message);
            }
        }

        public Entities.SoluglobChecador.Usuarios UpdateNumeroNominas(Entities.SoluglobChecador.Usuarios objUsuarios)
        {
            usuarios = new Entities.SoluglobChecador.Usuarios();
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                parameters.Add(new SqlParameter() { ParameterName = "Numero_Nomina", Value = objUsuarios.Numero_Nomina });
                parameters.Add(new SqlParameter() { ParameterName = "Numero_Nominas", Value = objUsuarios.Numero_Nominas });

                using (dataReader = this.connection.ExcuteSP("prc_Usuarios_UpdateNumeroNominas", parameters))
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            usuarios.Numero_Nomina = dataReader.IsDBNull(dataReader.GetOrdinal("Numero_Nomina")) ? default(int) : int.Parse(dataReader["Numero_Nomina"].ToString());
                            usuarios.Nombres = dataReader.IsDBNull(dataReader.GetOrdinal("Nombres")) ? null : dataReader["Nombres"].ToString();
                            usuarios.Apellidos = dataReader.IsDBNull(dataReader.GetOrdinal("Apellidos")) ? null : dataReader["Apellidos"].ToString();
                            usuarios.Puesto = dataReader.IsDBNull(dataReader.GetOrdinal("Puesto")) ? null : dataReader["Puesto"].ToString();
                            usuarios.Departamento = dataReader.IsDBNull(dataReader.GetOrdinal("Departamento")) ? null : dataReader["Departamento"].ToString();
                            usuarios.Telefono = dataReader.IsDBNull(dataReader.GetOrdinal("Telefono")) ? null : dataReader["Telefono"].ToString();
                            usuarios.Huella_Bin1 = dataReader.IsDBNull(dataReader.GetOrdinal("Huella_Bin1")) ? null : dataReader["Huella_Bin1"].ToString();
                            usuarios.Huella_Img1 = dataReader.IsDBNull(dataReader.GetOrdinal("Huella_Img1")) ? null : dataReader["Huella_Img1"].ToString();
                            usuarios.Huella_Bin2 = dataReader.IsDBNull(dataReader.GetOrdinal("Huella_Bin2")) ? null : dataReader["Huella_Bin2"].ToString();
                            usuarios.Huella_Bin3 = dataReader.IsDBNull(dataReader.GetOrdinal("Huella_Bin3")) ? null : dataReader["Huella_Bin3"].ToString();
                            usuarios.Huella_Bin4 = dataReader.IsDBNull(dataReader.GetOrdinal("Huella_Bin4")) ? null : dataReader["Huella_Bin4"].ToString();
                            usuarios.Estatus = dataReader.IsDBNull(dataReader.GetOrdinal("Estatus")) ? default(bool) : bool.Parse(dataReader["Estatus"].ToString());
                            usuarios.Fecha_Alta = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Alta")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Alta"].ToString());
                            usuarios.Fecha_Baja = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Baja")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Baja"].ToString());
                            usuarios.Empresa = dataReader.IsDBNull(dataReader.GetOrdinal("Empresa")) ? null : dataReader["Empresa"].ToString();
                            usuarios.Ubicacion = dataReader.IsDBNull(dataReader.GetOrdinal("Ubicacion")) ? null : dataReader["Ubicacion"].ToString();
                            usuarios.MotivoBaja = dataReader.IsDBNull(dataReader.GetOrdinal("MotivoBaja")) ? null : dataReader["MotivoBaja"].ToString();
                            usuarios.Caso_Especial = dataReader.IsDBNull(dataReader.GetOrdinal("Caso_Especial")) ? default(bool) : bool.Parse(dataReader["Caso_Especial"].ToString());
                            usuarios.msrepl_tran_version = dataReader.IsDBNull(dataReader.GetOrdinal("msrepl_tran_version")) ? default(Guid?) : Guid.Parse(dataReader["msrepl_tran_version"].ToString());
                            usuarios.Registrado = dataReader.IsDBNull(dataReader.GetOrdinal("Registrado")) ? default(int?) : int.Parse(dataReader["Registrado"].ToString());
                            usuarios.Imss = dataReader.IsDBNull(dataReader.GetOrdinal("Imss")) ? null : dataReader["Imss"].ToString();
                            usuarios.Dias_semana = dataReader.IsDBNull(dataReader.GetOrdinal("Dias_semana")) ? default(int?) : int.Parse(dataReader["Dias_semana"].ToString());
                            usuarios.fecha_ingresos = dataReader.IsDBNull(dataReader.GetOrdinal("fecha_ingresos")) ? default(DateTime?) : DateTime.Parse(dataReader["fecha_ingresos"].ToString());
                            usuarios.pagos_hextras = dataReader.IsDBNull(dataReader.GetOrdinal("pagos_hextras")) ? null : dataReader["pagos_hextras"].ToString();
                            usuarios.Fechas_registro = dataReader.IsDBNull(dataReader.GetOrdinal("Fechas_registro")) ? default(DateTime?) : DateTime.Parse(dataReader["Fechas_registro"].ToString());
                            usuarios.unidad_costos = dataReader.IsDBNull(dataReader.GetOrdinal("unidad_costos")) ? null : dataReader["unidad_costos"].ToString();
                            usuarios.Fecha_Reingreso = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Reingreso")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Reingreso"].ToString());
                            usuarios.Centro_costos = dataReader.IsDBNull(dataReader.GetOrdinal("Centro_costos")) ? null : dataReader["Centro_costos"].ToString();
                            usuarios.Numero_Nominas = dataReader.IsDBNull(dataReader.GetOrdinal("Numero_Nominas")) ? default(int?) : int.Parse(dataReader["Numero_Nominas"].ToString());
                            usuarios.Remuneracion = dataReader.IsDBNull(dataReader.GetOrdinal("Remuneracion")) ? null : dataReader["Remuneracion"].ToString();
                            usuarios.Fecha_Alta_Imss = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Alta_Imss")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Alta_Imss"].ToString());
                            usuarios.Fecha_Baja_sistema = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Baja_sistema")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Baja_sistema"].ToString());
                            usuarios.Estatus_Edicion = dataReader.IsDBNull(dataReader.GetOrdinal("Estatus_Edicion")) ? default(int?) : int.Parse(dataReader["Estatus_Edicion"].ToString());
                            usuarios.Fecha_Modificacion = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Modificacion")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Modificacion"].ToString());
                            usuarios.Bono = dataReader.IsDBNull(dataReader.GetOrdinal("Bono")) ? default(bool?) : bool.Parse(dataReader["Bono"].ToString());
                            usuarios.Responsable_Bono = dataReader.IsDBNull(dataReader.GetOrdinal("Responsable_Bono")) ? null : dataReader["Responsable_Bono"].ToString();
                        }
                    }

                    dataReader.Close();
                    dataReader.Dispose();
                }

                return usuarios;
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message.ToString());
            }
        }
        #region Inicia Obtiene Max
        public int GetMaxId()
        {
            usuarios = new Entities.SoluglobChecador.Usuarios();
            try
            {

                using (dataReader = this.connection.ExcuteSP("prc_Usuarios_GetMaxId", null))
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            usuarios.Numero_Nomina = dataReader.IsDBNull(dataReader.GetOrdinal("Numero_Nomina")) ? default(int) : int.Parse(dataReader["Numero_Nomina"].ToString());
                        }
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }

                return usuarios.Numero_Nomina;
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message.ToString());
            }

        }
        #endregion Inicia Obtiene Max

        public Entities.SoluglobChecador.Usuarios GetOneByNumeroNominas(int NumNominas)
        {
            usuarios = new Entities.SoluglobChecador.Usuarios();
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter() { ParameterName = "Numero_Nominas", Value = NumNominas });

                using (dataReader = this.connection.ExcuteSP("prc_Usuarios_GetOneByNumeroNominas", parameters))
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            usuarios.Numero_Nomina = dataReader.IsDBNull(dataReader.GetOrdinal("Numero_Nomina")) ? default(int) : int.Parse(dataReader["Numero_Nomina"].ToString());
                            usuarios.Nombres = dataReader.IsDBNull(dataReader.GetOrdinal("Nombres")) ? null : dataReader["Nombres"].ToString();
                            usuarios.Apellidos = dataReader.IsDBNull(dataReader.GetOrdinal("Apellidos")) ? null : dataReader["Apellidos"].ToString();
                            usuarios.Puesto = dataReader.IsDBNull(dataReader.GetOrdinal("Puesto")) ? null : dataReader["Puesto"].ToString();
                            usuarios.Departamento = dataReader.IsDBNull(dataReader.GetOrdinal("Departamento")) ? null : dataReader["Departamento"].ToString();
                            usuarios.Telefono = dataReader.IsDBNull(dataReader.GetOrdinal("Telefono")) ? null : dataReader["Telefono"].ToString();
                            usuarios.Huella_Bin1 = dataReader.IsDBNull(dataReader.GetOrdinal("Huella_Bin1")) ? null : dataReader["Huella_Bin1"].ToString();
                            usuarios.Huella_Img1 = dataReader.IsDBNull(dataReader.GetOrdinal("Huella_Img1")) ? null : dataReader["Huella_Img1"].ToString();
                            usuarios.Huella_Bin2 = dataReader.IsDBNull(dataReader.GetOrdinal("Huella_Bin2")) ? null : dataReader["Huella_Bin2"].ToString();
                            usuarios.Huella_Bin3 = dataReader.IsDBNull(dataReader.GetOrdinal("Huella_Bin3")) ? null : dataReader["Huella_Bin3"].ToString();
                            usuarios.Huella_Bin4 = dataReader.IsDBNull(dataReader.GetOrdinal("Huella_Bin4")) ? null : dataReader["Huella_Bin4"].ToString();
                            usuarios.Estatus = dataReader.IsDBNull(dataReader.GetOrdinal("Estatus")) ? default(bool) : bool.Parse(dataReader["Estatus"].ToString());
                            usuarios.Fecha_Alta = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Alta")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Alta"].ToString());
                            usuarios.Fecha_Baja = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Baja")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Baja"].ToString());
                            usuarios.Empresa = dataReader.IsDBNull(dataReader.GetOrdinal("Empresa")) ? null : dataReader["Empresa"].ToString();
                            usuarios.Ubicacion = dataReader.IsDBNull(dataReader.GetOrdinal("Ubicacion")) ? null : dataReader["Ubicacion"].ToString();
                            usuarios.MotivoBaja = dataReader.IsDBNull(dataReader.GetOrdinal("MotivoBaja")) ? null : dataReader["MotivoBaja"].ToString();
                            usuarios.Caso_Especial = dataReader.IsDBNull(dataReader.GetOrdinal("Caso_Especial")) ? default(bool) : bool.Parse(dataReader["Caso_Especial"].ToString());
                            usuarios.msrepl_tran_version = dataReader.IsDBNull(dataReader.GetOrdinal("msrepl_tran_version")) ? default(Guid?) : Guid.Parse(dataReader["msrepl_tran_version"].ToString());
                            usuarios.Registrado = dataReader.IsDBNull(dataReader.GetOrdinal("Registrado")) ? default(int?) : int.Parse(dataReader["Registrado"].ToString());
                            usuarios.Imss = dataReader.IsDBNull(dataReader.GetOrdinal("Imss")) ? null : dataReader["Imss"].ToString();
                            usuarios.Dias_semana = dataReader.IsDBNull(dataReader.GetOrdinal("Dias_semana")) ? default(int?) : int.Parse(dataReader["Dias_semana"].ToString());
                            usuarios.fecha_ingresos = dataReader.IsDBNull(dataReader.GetOrdinal("fecha_ingresos")) ? default(DateTime?) : DateTime.Parse(dataReader["fecha_ingresos"].ToString());
                            usuarios.pagos_hextras = dataReader.IsDBNull(dataReader.GetOrdinal("pagos_hextras")) ? null : dataReader["pagos_hextras"].ToString();
                            usuarios.Fechas_registro = dataReader.IsDBNull(dataReader.GetOrdinal("Fechas_registro")) ? default(DateTime?) : DateTime.Parse(dataReader["Fechas_registro"].ToString());
                            usuarios.unidad_costos = dataReader.IsDBNull(dataReader.GetOrdinal("unidad_costos")) ? null : dataReader["unidad_costos"].ToString();
                            usuarios.Fecha_Reingreso = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Reingreso")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Reingreso"].ToString());
                            usuarios.Centro_costos = dataReader.IsDBNull(dataReader.GetOrdinal("Centro_costos")) ? null : dataReader["Centro_costos"].ToString();
                            usuarios.Numero_Nominas = dataReader.IsDBNull(dataReader.GetOrdinal("Numero_Nominas")) ? default(int?) : int.Parse(dataReader["Numero_Nominas"].ToString());
                            usuarios.Remuneracion = dataReader.IsDBNull(dataReader.GetOrdinal("Remuneracion")) ? null : dataReader["Remuneracion"].ToString();
                            usuarios.Fecha_Alta_Imss = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Alta_Imss")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Alta_Imss"].ToString());
                            usuarios.Fecha_Baja_sistema = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Baja_sistema")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Baja_sistema"].ToString());
                            usuarios.Estatus_Edicion = dataReader.IsDBNull(dataReader.GetOrdinal("Estatus_Edicion")) ? default(int?) : int.Parse(dataReader["Estatus_Edicion"].ToString());
                            usuarios.Fecha_Modificacion = dataReader.IsDBNull(dataReader.GetOrdinal("Fecha_Modificacion")) ? default(DateTime?) : DateTime.Parse(dataReader["Fecha_Modificacion"].ToString());
                            usuarios.Bono = dataReader.IsDBNull(dataReader.GetOrdinal("Bono")) ? default(bool?) : bool.Parse(dataReader["Bono"].ToString());
                            usuarios.Responsable_Bono = dataReader.IsDBNull(dataReader.GetOrdinal("Responsable_Bono")) ? null : dataReader["Responsable_Bono"].ToString();

                        }
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }

                return usuarios;
            }
            catch (Exception ex)
            {
                dataReader.Close();
                dataReader.Dispose();
                throw new Exception(ex.Message.ToString());
            }

        }       
        
        public void EnvioCorreo(int NumChecador, int Id_VacMin)
        {
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter() { ParameterName = "Numero_Nomina", Value = NumChecador });
                parameters.Add(new SqlParameter() { ParameterName = "Id_Vac", Value = Id_VacMin });

                this.connection.ExcuteScalar("EnvioCorreoAltaUsusario", parameters);
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
