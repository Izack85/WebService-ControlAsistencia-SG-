using System;
using System.Collections.Generic;
using System.IO;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Integra.Service.Test.Soluglob_Integra
{
    class Program
    {
        static void Main(string[] args)
        {      
            Test.svcSoluglob_Integra.Soluglob_IntegraClient svcSolIn = new svcSoluglob_Integra.Soluglob_IntegraClient();

            ////Prueba de SP Soluglob            
            ////DataSet dsIncidenciasSG = svcSolIn.GetIncidenciasSG(DateTime.Parse("2017-01-01"), Convert.ToDateTime("2017-01-30"));
            ////int tablesCount = dsIncidenciasSG.Tables.Count;


            ////INSERT EMPLEADO SG
            //#region Alta de Empleado
            //int NumeroEmpleado = svcSolIn.AltaEmpleadoSG(93);
            //#endregion Alta de Empleado

            ////GET ONE EMPLEADO SG
            //#region Get One Empleado
            ////bool resultGetEmpleado = svcSolIn.GetOneEmpleadoSG("1481007");
            //#endregion Get One Empleado

            ////UPDATE EMPLEADO SG
            //#region Update Empleado
            //bool resultMovimiento = svcSolIn.MovimientoEmpleadoSG("1481699", 54);
            //#endregion Update Empleado

            ////BAJA EMPLEADO SG
            //#region Baja Empleado
            ////bool resultMovimiento = svcSolIn.MovimientoEmpleadoSG("14823456", 28);
            //#endregion Delete Empleado          


            //Encrypt

            //Decrypt   

            //////////////string cadena = "admin1%";
            //////////////string key = "123";
            //////////////int nivel = 8;
            //////////////int nivelKey = 4;

            //////////////string strEncriptacion = default(string);

            //////////////for (int i = 1; i <= nivel; i++)
            //////////////{
            //////////////    if (i == 1)
            //////////////    {
            //////////////        strEncriptacion = Encrypt(cadena, key, CipherMode.CBC);
            //////////////        //Console.WriteLine(strEncriptacion);
            //////////////    }
            //////////////    else
            //////////////    {
            //////////////        strEncriptacion = Encrypt(strEncriptacion, key, CipherMode.CBC);
            //////////////        //Console.WriteLine(strEncriptacion);
            //////////////    }
            //////////////}

            //////////////Console.WriteLine("Cadena Encriptada = " + strEncriptacion);
            //////////////Console.WriteLine("Nivel de Encriptacion = " + nivel);

            //////////////string keyEncriptacion = default(string);

            //////////////for (int i = 1; i <= nivelKey; i++)
            //////////////{
            //////////////    if (i == 1)
            //////////////    {
            //////////////        keyEncriptacion = keyEncrypt(key, CipherMode.CBC);
            //////////////        //Console.WriteLine(keyEncriptacion);
            //////////////    }
            //////////////    else
            //////////////    {
            //////////////        keyEncriptacion = keyEncrypt(keyEncriptacion, CipherMode.CBC);
            //////////////        //Console.WriteLine(keyEncriptacion);
            //////////////    }
            //////////////}

            //////////////Console.WriteLine("Key Encriptada = " + keyEncriptacion);
            //////////////Console.WriteLine("Nivel de Encriptacion = " + nivelKey);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //////////////cadena = strEncriptacion;
            //////////////key = keyEncriptacion;            

            //////////////string strDesencriptacion = default(string);
            //////////////string keyDesencriptacion = default(string);

            //////////////for (int i = 1; i <= nivelKey; i++)
            //////////////{
            //////////////    if (i == 1)
            //////////////    {
            //////////////        keyDesencriptacion = keyDecrypt(key, CipherMode.CBC);
            //////////////        //Console.WriteLine(keyDesencriptacion);
            //////////////    }
            //////////////    else
            //////////////    {
            //////////////        keyDesencriptacion = keyDecrypt(keyDesencriptacion, CipherMode.CBC);
            //////////////        //Console.WriteLine(keyDesencriptacion);
            //////////////    }
            //////////////}            

            //////////////Console.WriteLine("Key Desencriptada = " + keyDesencriptacion);
            //////////////key = keyDesencriptacion;

            //////////////for (int i = 1; i <= nivel; i++)
            //////////////{
            //////////////    if (i == 1)
            //////////////    {
            //////////////        strDesencriptacion = Decrypt(cadena, key, CipherMode.CBC);
            //////////////        //Console.WriteLine(strDesencriptacion);
            //////////////    }
            //////////////    else
            //////////////    {
            //////////////        strDesencriptacion = Decrypt(strDesencriptacion, key, CipherMode.CBC);
            //////////////        //Console.WriteLine(strDesencriptacion);
            //////////////    }

            //////////////}

            //////////////Console.WriteLine("Cadena Desencriptada = " + strDesencriptacion);

            ////////////////string resultEncriptacion = Encrypt(cadena, key, CipherMode.CBC);
            ////////////////Console.WriteLine(resultEncriptacion);

            ////////////////string resultDesenciptacion = Decrypt(resultEncriptacion2, key, CipherMode.CBC);
            ////////////////Console.WriteLine(resultDesenciptacion);

        }

        public static string keyEncrypt(string textToEncrypt, CipherMode CyphMode)
        {
            RijndaelManaged rijndaelCipher = new RijndaelManaged();
            rijndaelCipher.Mode = CyphMode;
            rijndaelCipher.Padding = PaddingMode.PKCS7;

            rijndaelCipher.KeySize = 0x80;
            rijndaelCipher.BlockSize = 0x80;
            byte[] pwdBytes = Encoding.UTF8.GetBytes("0000");
            byte[] keyBytes = new byte[0x10];
            int len = pwdBytes.Length;
            if (len > keyBytes.Length)
            {
                len = keyBytes.Length;
            }
            Array.Copy(pwdBytes, keyBytes, len);
            rijndaelCipher.Key = keyBytes;
            rijndaelCipher.IV = keyBytes;
            ICryptoTransform transform = rijndaelCipher.CreateEncryptor();
            byte[] plainText = Encoding.UTF8.GetBytes(textToEncrypt);
            return Convert.ToBase64String(transform.TransformFinalBlock(plainText, 0, plainText.Length));
        }

        public static string keyDecrypt(string textToDecrypt, CipherMode CyphMode)
        {
            RijndaelManaged rijndaelCipher = new RijndaelManaged();
            rijndaelCipher.Mode = CyphMode;
            rijndaelCipher.Padding = PaddingMode.PKCS7;

            rijndaelCipher.KeySize = 0x80;
            rijndaelCipher.BlockSize = 0x80;
            byte[] encryptedData = Convert.FromBase64String(textToDecrypt);
            byte[] pwdBytes = Encoding.UTF8.GetBytes("0000");
            byte[] keyBytes = new byte[0x10];
            int len = pwdBytes.Length;
            if (len > keyBytes.Length)
            {
                len = keyBytes.Length;
            }
            Array.Copy(pwdBytes, keyBytes, len);
            rijndaelCipher.Key = keyBytes;
            rijndaelCipher.IV = keyBytes;
            byte[] plainText = rijndaelCipher.CreateDecryptor().TransformFinalBlock(encryptedData, 0, encryptedData.Length);
            return Encoding.UTF8.GetString(plainText);
        }

        public static string Encrypt(string textToEncrypt, string key, CipherMode CyphMode)
        {
            RijndaelManaged rijndaelCipher = new RijndaelManaged();
            rijndaelCipher.Mode = CyphMode;
            rijndaelCipher.Padding = PaddingMode.PKCS7;

            rijndaelCipher.KeySize = 0x80;
            rijndaelCipher.BlockSize = 0x80;
            byte[] pwdBytes = Encoding.UTF8.GetBytes(key);
            byte[] keyBytes = new byte[0x10];
            int len = pwdBytes.Length;
            if (len > keyBytes.Length)
            {
                len = keyBytes.Length;
            }
            Array.Copy(pwdBytes, keyBytes, len);
            rijndaelCipher.Key = keyBytes;
            rijndaelCipher.IV = keyBytes;
            ICryptoTransform transform = rijndaelCipher.CreateEncryptor();
            byte[] plainText = Encoding.UTF8.GetBytes(textToEncrypt);
            return Convert.ToBase64String(transform.TransformFinalBlock(plainText, 0, plainText.Length));
        }

        public static string Decrypt(string textToDecrypt, string key, CipherMode CyphMode)
        {
            RijndaelManaged rijndaelCipher = new RijndaelManaged();
            rijndaelCipher.Mode = CyphMode;
            rijndaelCipher.Padding = PaddingMode.PKCS7;

            rijndaelCipher.KeySize = 0x80;
            rijndaelCipher.BlockSize = 0x80;
            byte[] encryptedData = Convert.FromBase64String(textToDecrypt);
            byte[] pwdBytes = Encoding.UTF8.GetBytes(key);
            byte[] keyBytes = new byte[0x10];
            int len = pwdBytes.Length;
            if (len > keyBytes.Length)
            {
                len = keyBytes.Length;
            }
            Array.Copy(pwdBytes, keyBytes, len);
            rijndaelCipher.Key = keyBytes;
            rijndaelCipher.IV = keyBytes;
            byte[] plainText = rijndaelCipher.CreateDecryptor().TransformFinalBlock(encryptedData, 0, encryptedData.Length);
            return Encoding.UTF8.GetString(plainText);
        }

    }

}


