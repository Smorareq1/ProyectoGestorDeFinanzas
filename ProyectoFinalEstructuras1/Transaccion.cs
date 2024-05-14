using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalEstructuras1
{
    internal class Transaccion
    {
        public string Nombre { get; set; }
        public double Monto { get; set; }
        public DateTime Fecha { get; set; }
        public string Categoria { get; set; }

        public Transaccion(string nombre, double monto, DateTime fecha, string categoria)
        {
            Nombre = nombre;
            Monto = monto;
            Fecha = fecha;
            Categoria = categoria;
            
        }



        


    }

}
