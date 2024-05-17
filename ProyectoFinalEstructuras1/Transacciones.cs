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

        public static List<Transaccion> gastos = new List<Transaccion>();
        public static List<Transaccion> ingresos = new List<Transaccion>();


        public static void mostrarTransacciones() //Prueba
        {
            foreach (var t in transacciones)
            {
                MessageBox.Show(t.Nombre + " " + t.Monto + " " + t.Fecha.ToString("dd/MM/yyyy") + " " + t.Categoria);
            }
        }

        public static void ordenarTransaccionesPorFecha()
        {
            transacciones.Sort((x, y) => DateTime.Compare(x.Fecha, y.Fecha));
        }

        public static void ordenarGastosPorFecha()
        {
            gastos.Sort((x, y) => DateTime.Compare(x.Fecha, y.Fecha));
        }

        public static void ordenarIngresosPorFecha()
        {
            ingresos.Sort((x, y) => DateTime.Compare(x.Fecha, y.Fecha));
        }

        public static void agregarElemento(Transaccion transaccion)
        {
            
            //cambiar presupuesto actual
            if(transaccion.Monto < 0) //Gasto
            {
                presupuestoActual += transaccion.Monto;
                gastos.Add(transaccion);

            }
            else
            {
                presupuestoActual += transaccion.Monto;
                ingresos.Add(transaccion);
            }

            transacciones.Add(transaccion);
        }


    }
}
