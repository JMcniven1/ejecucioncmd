using System;
using System.Diagnostics;

namespace ejecucioncmd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] args = new string[2];
            //args[0] = "C:\\Users\\Mcniven\\Desktop\\archivos\\herramienta\\ejecutar.cmd";
            //args[1] = "C:\\Users\\Mcniven\\Desktop\\archivos\\archivo_a _ejecutar\\ejemplo.cmd";
            //if (args.Length < 2)
            //{
            //    Console.WriteLine("Debes proporcionar dos rutas de archivo .cmd como parámetros.");
            //    return;
            //}

            //string rutaPrimerCmd = args[0];
            //string rutaSegundoCmd = args[1];
            //// Verificar si los archivos existen
            //if (!System.IO.File.Exists(rutaPrimerCmd))
            //{
            //    Console.WriteLine($"El archivo {rutaPrimerCmd} no existe.");
            //    return;
            //}

            //if (!System.IO.File.Exists(rutaSegundoCmd))
            //{
            //    Console.WriteLine($"El archivo {rutaSegundoCmd} no existe.");
            //    return;
            //}
            string rutaPrimerCmd = @"C:\\Users\\Mcniven\\Desktop\\archivos\\herramienta\\ejecutar.cmd";
            string rutaSegundoCmd = @"C:\\Users\\Mcniven\\Desktop\\archivos\\archivo_a _ejecutar\\ejemplo.cmd";
            // Construir el comando para ejecutar el primer archivo .cmd que a su vez ejecutará el segundo
            string comando = $"\"{rutaPrimerCmd}\" \"{rutaSegundoCmd}\"";

            // Ejecutar el primer archivo .cmd
            ProcessStartInfo psiPrimerCmd = new ProcessStartInfo
            {
                FileName = comando,
                UseShellExecute = false,
                CreateNoWindow = false // Cambiar a true si no se desea mostrar la ventana de comandos
            };

            Process primerCmdProcess = new Process
            {
                StartInfo = psiPrimerCmd
            };

            primerCmdProcess.Start();

            Console.WriteLine("Proceso .cmd iniciado.");

        }
    }
}