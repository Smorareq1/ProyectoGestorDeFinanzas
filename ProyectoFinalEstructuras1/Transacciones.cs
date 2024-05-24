using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProyectoFinalEstructuras1.planificacion;

namespace ProyectoFinalEstructuras1
{
    internal class Transacciones
    {

        //Variables
        public static double presupuestoActual;
        


        public static string correo;
        public static List<Transaccion> transacciones = GestorDeArchivos.LeerTransaccionesEncriptadas();
        public static List<TransaccionProgramada> transaccionesProgramadas = GestorDeArchivos.LeerTransaccionesProgramadasEncriptadas();
        public static List<Inversion> inversiones = GestorDeArchivos.LeerInversionesEncriptadas();
        public static List<FinancialGoal> recomendaciones = GestorDeArchivos.LeerRecomendacionesEncriptadas();

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

        public static void ordenarInversionesPorFecha()
        {
            inversiones.Sort((x, y) => DateTime.Compare(x.Fecha, y.Fecha));
        }   

        public static void ordenarTransaccionesProgramadasPorFecha()
        {
            transaccionesProgramadas.Sort((x, y) => DateTime.Compare(x.Fecha, y.Fecha));
        }

        public static void agregarElemento(Transaccion transaccion)
        {
            
            //cambiar presupuesto actual
            if(transaccion.Monto < 0) //Gasto
            {
                presupuestoActual += transaccion.Monto;
               

            }
            else
            {
                presupuestoActual += transaccion.Monto;
               
            }

            transacciones.Add(transaccion);
        }


    }
}
