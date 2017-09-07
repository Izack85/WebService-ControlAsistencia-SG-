using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Integra.Services.Test.Integra_Soluglob
{
    class Program
    {
        static void Main(string[] args)
        {
            //HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create("http://192.168.14.12/svcSoluglobIntegra/Soluglob_Integra.svc");
            //Console.WriteLine("\nThe timeout time of the request before setting the property is  {0}  milliSeconds.", myHttpWebRequest.Timeout);
            //myHttpWebRequest.Timeout = 10;
            //Console.WriteLine("\nThe timeout time of the request after setting the timeout is {0}  milliSeconds.", myHttpWebRequest.Timeout);            
            //HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();

            svcIntegra_Soluglob.Integra_SoluglobClient svcInt_Sol = new svcIntegra_Soluglob.Integra_SoluglobClient();

            //INSERT EMPLEADO KAIZEN
            #region Alta de Empleado
            bool resultAlta = svcInt_Sol.AltaEmpleado(1700);
            #endregion Alta de Empleado

            //UPDATE EMPLEADO KAIZEN
            #region Update Empleado
            //string path = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            //bool resultCambio = svcInt_Sol.MovimientoEmpleadoKaizen("1481699", 55);
            #endregion Update Empleado

            //BAJA EMPLEADO KAIZEN
            #region Baja Empleado
            //bool resultCambio = svcInt_Sol.MovimientoEmpleadoKaizen("14823456", 28);
            #endregion Baja Empleado
            
            //Program.CalcularNumeros("Diccionario");
            //Program.UploadUniqueFileOnServer( )
        }

        public static bool UploadUniqueFileOnServer(Uri serverUri, string fileName)
        {
            // The URI described by serverUri should use the ftp:// scheme.
            // It contains the name of the directory on the server.
            // Example: ftp://contoso.com.
            // 
            // The fileName parameter identifies the file containing the data to be uploaded.

            if (serverUri.Scheme != Uri.UriSchemeFtp)
            {
                return false;
            }
            // Get the object used to communicate with the server.
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(serverUri);
            request.Method = WebRequestMethods.Ftp.UploadFileWithUniqueName;
            // Set a time limit for the operation to complete.
            request.Timeout = 600000;

            // Copy the file contents to the request stream.
            const int bufferLength = 2048;
            byte[] buffer = new byte[bufferLength];
            int count = 0;
            int readBytes = 0;
            FileStream stream = File.OpenRead(fileName);
            Stream requestStream = request.GetRequestStream();
            do
            {
                readBytes = stream.Read(buffer, 0, bufferLength);
                requestStream.Write(buffer, 0, bufferLength);
                count += readBytes;
            }
            while (readBytes != 0);

            Console.WriteLine("Writing {0} bytes to the stream.", count);
            // IMPORTANT: Close the request stream before sending the request.
            requestStream.Close();
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            Console.WriteLine("Upload status: {0}, {1}", response.StatusCode, response.StatusDescription);
            Console.WriteLine("File name: {0}", response.ResponseUri);
            response.Close();
            return true;
        }



        //static int[] CalcularNumeros()
        static int[] CalcularNumeros(string nombreArchivo)        
        {
            int[] numeros = new int[1000000];
            Random r = new Random();

            int auxiliar = 0;
            int contador = 0;

            for (int i = 0; i < 1000000; i++)
            {
                auxiliar = r.Next(10000000, 99999999);
                bool continuar = false;

                while (!continuar)
                {
                    for (int j = 0; j <= contador; j++)
                    {
                        if (auxiliar == numeros[j])
                        {
                            continuar = true;
                            j = contador;
                        }
                    }

                    if (continuar)
                    {
                        auxiliar = r.Next(10000000, 99999999);
                        continuar = false;
                    }
                    else
                    {
                        continuar = true;
                        numeros[contador] = auxiliar;
                        contador++;
                    }
                }

                System.IO.StreamWriter file = new System.IO.StreamWriter("c:\\" + nombreArchivo + ".lst", true);
                file.WriteLine(auxiliar);
                file.Close();
            }

            return numeros;
        }

    }
}
