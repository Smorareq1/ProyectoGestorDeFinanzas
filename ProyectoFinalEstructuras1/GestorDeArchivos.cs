using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Security.Cryptography;

namespace ProyectoFinalEstructuras1
{
    internal class GestorDeArchivos
    {

        private static string clave = "a1b2c3d4e5f6g7h8"; // Clave de encriptación

        private static string GetJsonFilePath(string fileName)
        {
            string jsonDirectory = Path.Combine(Environment.CurrentDirectory, "ArchivosJson");
            if (!Directory.Exists(jsonDirectory))
            {
                Directory.CreateDirectory(jsonDirectory);
            }
            return Path.Combine(jsonDirectory, fileName);
        }

        public static double GetPresupuestoInicial()
        {
            string fileName = "presupuesto.json";
            string filePath = GetJsonFilePath(fileName);

            if (!File.Exists(filePath))
            {
                // Crea el archivo con un valor de presupuesto inicial
                SetPresupuestoInicial(0.00);
            }

            // Lee el JSON cifrado desde el archivo
            string jsonData = File.ReadAllText(filePath);
            string decryptedData = Decrypt(jsonData);
            var presupuestoInicial = JsonConvert.DeserializeObject<dynamic>(decryptedData);
            return (double)presupuestoInicial.Presupuesto;
        }

        public static void SetPresupuestoInicial(double presupuesto)
        {
            string fileName = "presupuesto.json";
            string filePath = GetJsonFilePath(fileName);

            // Crea un objeto anónimo con el valor del presupuesto inicial
            var presupuestoInicial = new { Presupuesto = presupuesto };

            // Serializa el objeto anónimo a formato JSON y lo encripta
            string jsonData = JsonConvert.SerializeObject(presupuestoInicial, Formatting.Indented);
            string encryptedData = Encrypt(jsonData);

            // Escribe el JSON cifrado en el archivo
            File.WriteAllText(filePath, encryptedData);
        }

        private static string Encrypt(string input)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(clave);
                aes.IV = Encoding.UTF8.GetBytes(clave);

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(input);
                        }
                        return Convert.ToBase64String(msEncrypt.ToArray());
                    }
                }
            }
        }

        private static string Decrypt(string encryptedInput)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(clave);
                aes.IV = Encoding.UTF8.GetBytes(clave);

                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
                using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(encryptedInput)))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            return srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
        }


    }
}
