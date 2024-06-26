﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Security.Cryptography;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Globalization;
using static ProyectoFinalEstructuras1.planificacion;

namespace ProyectoFinalEstructuras1
{
    internal class GestorDeArchivos
    {

        private static string clave = "a1b2c3d4e5f6g7h8"; // Clave de encriptación


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

       
        private static string GetJsonFilePath(string fileName)
        {
            string jsonDirectory = Path.Combine(Environment.CurrentDirectory, "ArchivosJson");
            if (!Directory.Exists(jsonDirectory))
            {
                Directory.CreateDirectory(jsonDirectory);
            }
            return Path.Combine(jsonDirectory, fileName);
        }

        // ================================== PRESUPUESTO ==================================

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

        // ================================== CORREO ==================================

        public static string GetCorreoInicial()
        {
            string fileName = "correo.json";
            string filePath = GetJsonFilePath(fileName);

            if (!File.Exists(filePath))
            {
                // Crea el archivo con un correo inicial vacío
                SetCorreoInicial(string.Empty);
            }

            // Lee el JSON cifrado desde el archivo
            string jsonData = File.ReadAllText(filePath);
            string decryptedData = Decrypt(jsonData);
            var correoInicial = JsonConvert.DeserializeObject<dynamic>(decryptedData);
            return (string)correoInicial.Correo;
        }

        public static void SetCorreoInicial(string correo)
        {
            string fileName = "correo.json";
            string filePath = GetJsonFilePath(fileName);

            // Crea un objeto anónimo con el correo inicial
            var correoInicial = new { Correo = correo };

            // Serializa el objeto anónimo a formato JSON y lo encripta
            string jsonData = JsonConvert.SerializeObject(correoInicial, Formatting.Indented);
            string encryptedData = Encrypt(jsonData);

            // Escribe el JSON cifrado en el archivo
            File.WriteAllText(filePath, encryptedData);
        }

        // ================================== TRANSACCIONES ==================================

        public static void GuardarTransaccionesEncriptadas(List<Transaccion> transacciones)
        {
            string fileName = "transaccionesEncriptadas.json";
            string filePath = GetJsonFilePath(fileName);

            // Serializa las transacciones a formato JSON usando Newtonsoft.Json
            string jsonData = JsonConvert.SerializeObject(transacciones, Formatting.Indented);
            // Encripta el JSON serializado
            string encryptedData = Encrypt(jsonData);

            // Escribe el JSON encriptado en el archivo
            File.WriteAllText(filePath, encryptedData);
        }

        public static List<Transaccion> LeerTransaccionesEncriptadas()
        {
            string fileName = "transaccionesEncriptadas.json";
            string filePath = GetJsonFilePath(fileName);

            if (!File.Exists(filePath))
            {
                return new List<Transaccion>(); // Devuelve una lista vacía si el archivo no existe
            }

            try
            {
                // Lee el JSON encriptado desde el archivo
                string encryptedData = File.ReadAllText(filePath);

                // Desencripta el JSON
                string jsonData = Decrypt(encryptedData);

                // Deserializa el JSON a una lista de transacciones
                List<Transaccion> transacciones = JsonConvert.DeserializeObject<List<Transaccion>>(jsonData);
                return transacciones;
            }
            catch (Exception ex)
            {
                // Manejo básico de excepciones al deserializar el JSON
                Console.WriteLine("Error al leer transacciones encriptadas: " + ex.Message);
                return new List<Transaccion>(); // Devuelve una lista vacía en caso de error
            }
        }

        // ================================== TRANSACCIONES PROGRAMADAS ==================================

        public static void GuardarTransaccionesProgramadasEncriptadas(List<TransaccionProgramada> transaccionesProgramadas)
        {
            string fileName = "transaccionesProgramadasEncriptadas.json";
            string filePath = GetJsonFilePath(fileName);

            // Serializa las transacciones a formato JSON usando Newtonsoft.Json
            string jsonData = JsonConvert.SerializeObject(transaccionesProgramadas, Formatting.Indented);
            // Encripta el JSON serializado
            string encryptedData = Encrypt(jsonData);

            // Escribe el JSON encriptado en el archivo
            File.WriteAllText(filePath, encryptedData);
        }

        public static List<TransaccionProgramada> LeerTransaccionesProgramadasEncriptadas()
        {
            string fileName = "transaccionesProgramadasEncriptadas.json";
            string filePath = GetJsonFilePath(fileName);

            if (!File.Exists(filePath))
            {
                return new List<TransaccionProgramada>(); // Devuelve una lista vacía si el archivo no existe
            }

            try
            {
                // Lee el JSON encriptado desde el archivo
                string encryptedData = File.ReadAllText(filePath);

                // Desencripta el JSON
                string jsonData = Decrypt(encryptedData);

                // Deserializa el JSON a una lista de transacciones
                List<TransaccionProgramada> transaccionesProgramadas = JsonConvert.DeserializeObject<List<TransaccionProgramada>>(jsonData);
                return transaccionesProgramadas;
            }
            catch (Exception ex)
            {
                // Manejo básico de excepciones al deserializar el JSON
                Console.WriteLine("Error al leer transacciones encriptadas: " + ex.Message);
                return new List<TransaccionProgramada>(); // Devuelve una lista vacía en caso de error
            }
        }

        // ================================== INVERSIONES ==================================

        public static void GuardarInversionesEncriptadas(List<Inversion> inversionesRealizadas)
        {
            string fileName = "Inversiones.json";
            string filePath = GetJsonFilePath(fileName);

            // Serializa las transacciones a formato JSON usando Newtonsoft.Json
            string jsonData = JsonConvert.SerializeObject(inversionesRealizadas, Formatting.Indented);
            // Encripta el JSON serializado
            string encryptedData = Encrypt(jsonData);

            // Escribe el JSON encriptado en el archivo
            File.WriteAllText(filePath, encryptedData);
        }

        public static List<Inversion> LeerInversionesEncriptadas()
        {
            string fileName = "Inversiones.json";
            string filePath = GetJsonFilePath(fileName);

            if (!File.Exists(filePath))
            {
                return new List<Inversion>(); // Devuelve una lista vacía si el archivo no existe
            }

            try
            {
                // Lee el JSON encriptado desde el archivo
                string encryptedData = File.ReadAllText(filePath);

                // Desencripta el JSON
                string jsonData = Decrypt(encryptedData);

                // Deserializa el JSON a una lista de transacciones
                List<Inversion> inversionesRealizadas = JsonConvert.DeserializeObject<List<Inversion>>(jsonData);
                return inversionesRealizadas;
            }
            catch (Exception ex)
            {
                // Manejo básico de excepciones al deserializar el JSON
                Console.WriteLine("Error al leer transacciones encriptadas: " + ex.Message);
                return new List<Inversion>(); // Devuelve una lista vacía en caso de error
            }
        }

        // ================================== PLANIFICACION ==================================

        public static void GuardarRecomendacionesEncriptadas(List<FinancialGoal> recomendaciones)
        {
            string fileName = "Recomendaciones.json";
            string filePath = GetJsonFilePath(fileName);

            // Serializa las transacciones a formato JSON usando Newtonsoft.Json
            string jsonData = JsonConvert.SerializeObject(recomendaciones, Formatting.Indented);
            // Encripta el JSON serializado
            string encryptedData = Encrypt(jsonData);

            // Escribe el JSON encriptado en el archivo
            File.WriteAllText(filePath, encryptedData);
        }

        public static List<FinancialGoal> LeerRecomendacionesEncriptadas()
        {
            string fileName = "Recomendaciones.json";
            string filePath = GetJsonFilePath(fileName);

            if (!File.Exists(filePath))
            {
                return new List<FinancialGoal>(); // Devuelve una lista vacía si el archivo no existe
            }

            try
            {
                // Lee el JSON encriptado desde el archivo
                string encryptedData = File.ReadAllText(filePath);

                // Desencripta el JSON
                string jsonData = Decrypt(encryptedData);

                // Deserializa el JSON a una lista de transacciones
                List<FinancialGoal> inversionesRealizadas = JsonConvert.DeserializeObject<List<FinancialGoal>>(jsonData);
                return inversionesRealizadas;
            }
            catch (Exception ex)
            {
                // Manejo básico de excepciones al deserializar el JSON
                Console.WriteLine("Error al leer transacciones encriptadas: " + ex.Message);
                return new List<FinancialGoal>(); // Devuelve una lista vacía en caso de error
            }
        }

    }
}
