using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ProyectoFinalEstructuras1
{
    internal class GestorDeArchivos
    {

        private static string GetJsonFilePath(string fileName)
        {
            // Obtiene la ruta completa de la carpeta ArchivosJson
            string jsonDirectory = Path.Combine(Environment.CurrentDirectory, "ArchivosJson");

            // Verifica si la carpeta no existe, y si es así, la crea
            if (!Directory.Exists(jsonDirectory))
            {
                Directory.CreateDirectory(jsonDirectory);
            }

            // Combina la ruta de la carpeta con el nombre del archivo
            string filePath = Path.Combine(jsonDirectory, fileName);
            return filePath;
        }



        public static double GetPresupuestoInicial()
        {
            string fileName = "presupuesto.json";
            string filePath = GetJsonFilePath(fileName);

            if (!File.Exists(filePath))
            {
                // Si el archivo no existe, crea un nuevo archivo JSON con un valor de presupuesto inicial 0
                var presupuestoInicial = new { Presupuesto = 0.00 };
                string jsonData = JsonConvert.SerializeObject(presupuestoInicial, Formatting.Indented);
                File.WriteAllText(filePath, jsonData);

                return presupuestoInicial.Presupuesto;
            }
            else
            {
                // Si el archivo existe, lee el valor del presupuesto inicial desde el archivo JSON
                string jsonData = File.ReadAllText(filePath);
                var presupuestoInicial = JsonConvert.DeserializeObject<dynamic>(jsonData);
                return (double)presupuestoInicial.Presupuesto;
            }
        }

        public static void SetPresupuestoInicial(double presupuesto)
        {
            string fileName = "presupuesto.json";
            string filePath = GetJsonFilePath(fileName);

            // Crea un objeto anónimo con el valor del presupuesto inicial
            var presupuestoInicial = new { Presupuesto = presupuesto };

            // Serializa el objeto anónimo a formato JSON
            string jsonData = JsonConvert.SerializeObject(presupuestoInicial, Formatting.Indented);

            // Escribe el JSON en el archivo
            File.WriteAllText(filePath, jsonData);
        }


    }
}
