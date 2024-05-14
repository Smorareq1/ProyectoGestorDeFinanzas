using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalEstructuras1
{
    public partial class gastosIngresos : Form
    {

        public gastosIngresos()
        {
            InitializeComponent();
        }

        private void gastosIngresos_Load(object sender, EventArgs e)
        {
            presupuestoLabel.Text = "$ " + Transacciones.presupuestoActual.ToString();

        }

        private void button1_Click(object sender, EventArgs e) //Registrar gasto
        {
            try
            {
                string nombre = nombretxt.Text;
                double monto = Convert.ToDouble(montotxt.Text);
                string fecha = fechatxt.Text;
                string categoria = categoriatxt.Text;

                //Convertir fecha a DateTime
                DateTime fechaDT = DateTime.ParseExact(fecha, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                Transaccion transaccion = new Transaccion(nombre, monto, fechaDT, categoria);
                
                
                Transacciones.transacciones.Add(transaccion);
                vaciarCampos();
                MessageBox.Show("Transaccion registrada exitosamente.");


                GestorDeArchivos.GuardarTransaccionesSinEncriptar(Transacciones.transacciones);
            }
            catch
            {
                MessageBox.Show("Por favor, ingrese valores validos.");
            }

        }

        private void vaciarCampos()
        {
            nombretxt.Text = "";
            montotxt.Text = "";
            fechatxt.Text = "";
            categoriatxt.Text = "";
        }
    }
}
