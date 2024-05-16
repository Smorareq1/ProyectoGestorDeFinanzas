using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalEstructuras1
{
    internal class Transacciones
    {

        //Variables
        public static double presupuestoActual;
        public static List<Transaccion> transacciones = GestorDeArchivos.LeerTransaccionesEncriptadas();


        public static void mostrarTransacciones() //Prueba
        {
            foreach (var t in transacciones)
            {
                MessageBox.Show(t.Nombre + " " + t.Monto + " " + t.Fecha.ToString("dd/MM/yyyy") + " " + t.Categoria);
            }
        }


    }
}
