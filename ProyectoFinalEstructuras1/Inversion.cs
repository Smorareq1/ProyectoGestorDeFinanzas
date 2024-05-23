using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalEstructuras1
{
    internal class Inversion
    {
        public string Nombre { get; set; }
        public double MontoInvertido { get; set; }
        public DateTime Fecha { get; set; }
        public double TasaInteres { get; set; }
        public int Plazo { get; set; } //Plazo en meses

        public double ValorFinal { get; set; }
        public double TasaRentabilidad { get; set; }


        public Inversion(string nombre, double montoInvertido, DateTime fecha, double tasaInteres, int plazo)
        {
            Nombre = nombre;
            MontoInvertido = montoInvertido;
            Fecha = fecha;
            TasaInteres = tasaInteres;
            Plazo = plazo;
            ValorFinal = CalcularValorFinal();
            TasaRentabilidad = CalcularTasaRentabilidad();
        }

        public double CalcularValorFinal()
        {
            // Ejemplo sencillo de cálculo de interés compuesto
            return MontoInvertido * Math.Pow(1 + TasaInteres / 100, Plazo);
        }

        public double CalcularTasaRentabilidad()
        {
            return ((ValorFinal - MontoInvertido) / MontoInvertido) * 100;
        }



    }
}
