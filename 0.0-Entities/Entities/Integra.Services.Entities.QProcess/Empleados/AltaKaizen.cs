using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integra.Services.Entities.QProcess.Empleados
{
    public class AltaKaizen
    {
        //General
        public string Compania { get; set; }

        public string CompaniaPasajes { get; set; }

        public string numEmpleado { get; set; }

        public string Usuario { get; set; }

        public DateTime Fecha { get; set; }

        public string Ip { get; set; }

        public string Mac_Address { get; set; }       

        public string Unidad_de_Costos { get; set; }

        public string Centro_de_Costos { get; set; }


        //Empleados
        public string ApellidoPat { get; set; }

        public string ApellidoMat { get; set; }

        public string Nombres { get; set; }

        public string Nombre { get; set; }

        public string Path_Foto { get; set; }

        public string RFC { get; set; }

        public string CURP { get; set; }

        public string Elector { get; set; }

        public string Cartilla { get; set; }

        public string Licencia { get; set; }

        public string NSS { get; set; }

        public string TipoSangre { get; set; }

        public Int16? Sexo { get; set; }

        public string Tratamiento { get; set; }

        public string NivelEstudio { get; set; }

        public DateTime? FechaNacimiento { get; set; }

        public string Lugar_Nac { get; set; }

        public string PaisNacimiento { get; set; }

        public string Estado_Nac { get; set; }

        public string Nombre_Padre { get; set; }

        public string Nombre_Madre { get; set; }

        public Int16? Origen { get; set; }

        public string Nacionalidad { get; set; }

        public Int16? Tipo_Pago { get; set; }

        public string Banco { get; set; }

        public string Sucursal { get; set; }

        public string Cta_Cheques { get; set; }

        public string Fuente { get; set; }

        public Int16? Tarjeta { get; set; }

        public Int16? Destajos { get; set; }

        public string Turno { get; set; }

        public string Expediente { get; set; }

        public string NumCreditoInfonavit { get; set; }

        public Int16? Tipo_Pago_Infonavit { get; set; }

        public Decimal? Factor { get; set; }

        public string CLABE { get; set; }

        public string Banco_Alt { get; set; }

        public string Sucursal_Alt { get; set; }

        public string Cta_Cheques_Alt { get; set; }

        public string CLABE_Alt { get; set; }

        public string Tarjeta_Vales { get; set; }

        public string Path_Firma { get; set; }

        public string Estatus { get; set; }

        public string Tarjeta_Vales_Ant { get; set; }

        public string Correo { get; set; }

        public string Tarjeta_VGasolina { get; set; }

        public string EntidadLaboral { get; set; }



        //Tel Empleados

        public Int16 Tipo { get; set; }

        public Int16 Sec_Tel_Empleados { get; set; }

        public string Telefono { get; set; }


        //H_Personal 

        public string Direccion { get; set; }

        public string Poblacion { get; set; }

        public string Ciudad { get; set; }

        public string Colonia { get; set; }

        public string Cp { get; set; }

        public string Pais { get; set; }

        public string Estado { get; set; }

        public Int16? Estado_Civil { get; set; }

        public string Numero_Ext { get; set; }

        public string Numero_Int { get; set; }


                
        //H_Sueldos

        public string Tipo_Sueldo { get; set; }

        public Double SDI { get; set; }

        public Double SDN { get; set; }

        public Double SM { get; set; }



        //H_Laboral               

        public Int16  Sec_H_Laboral { get; set; }

        public string Accion { get; set; }

        public string Motivo { get; set; }

        public string Grupo_Pago { get; set; }

        public string Grupo_Pago_Pasajes { get; set; }

        public Int16? Tipo_Contrato { get; set; }

        public DateTime? Fecha_Ingreso { get; set; }

        public DateTime? Fecha_Antiguedad1 { get; set; }

        public DateTime? Fecha_Antiguedad2 { get; set; }

        public DateTime? Fecha_Antiguedad3 { get; set; }

        public Int16? Duracion { get; set; }

        public DateTime? Fecha_Vento { get; set; }

        public DateTime? Fecha_Baja { get; set; }

        public Int16? Tipo_Salario { get; set; }

        public string Tipo_Empleado { get; set; }

        public string Localidad { get; set; }

        public string Departamento { get; set; }

        public string Puesto { get; set; }

        public string Dependencia { get; set; }

        public string Cliente { get; set; }

        public string Tipo_De_Operacion { get; set; }

        public string Region { get; set; }

        public string Sector { get; set; }        

        public Int16? Sindicalizado { get; set; }
        


        //Valores por Empleado

        public string Nombre_H_Val_X_Emp { get; set; }

        public string Valor { get; set; }
            



        //Checador

        public int Numero_Nomina { get; set; }

        public int? Numero_Nominas { get; set; }

        public DateTime? FechaMod { get; set; }



        //Administrativo

        public int Id_Per { get; set; }

        public int? Num_Checador { get; set; }

        public int? Nomi_Camb { get; set; }       

        public int? User_Mod { get; set; }
        
       

    }
} 
