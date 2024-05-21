using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalEstructuras1
{
    internal class TransaccionProgramada
    {   
        public string Nombre { get; set; }
        public double Monto { get; set; }
        public DateTime Fecha { get; set; }
        public string Categoria { get; set; }

        public bool RepetirMensualmente { get; set; }

        public TransaccionProgramada(string nombre, double monto, DateTime fecha, string categoria, bool repetir)
        {
            Nombre = nombre;
            Monto = monto;
            Fecha = fecha;
            Categoria = categoria;
            RepetirMensualmente = repetir;
        }
    }
}
