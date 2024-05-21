using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProyectoFinalEstructuras1
{
    public partial class EventForm : Form
    {


        public EventForm()
        {
            InitializeComponent();
        }

        private void guardarBtxt_Click(object sender, EventArgs e)
        {
            try
            {
                string Nombre = nombreTxt.Text;
                double monto = Convert.ToDouble(montoTxt.Text);
                string fecha = fechaTxt.Text;

                //Convertir fecha a DateTime
                DateTime fechaDT = DateTime.ParseExact(fecha, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                string categoria = categoriaTxt.Text;

                bool repetir = repetirCheck.Checked;

                //Crear la transaccion
                TransaccionProgramada transaccion = new TransaccionProgramada(Nombre, monto, fechaDT, categoria, repetir);
                Transacciones.transaccionesProgramadas.Add(transaccion);

                MessageBox.Show("Evento guardado exitosamente.");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el evento: " + ex.Message);
            }
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            string fechaActual = UserControlDays.diaEstatico.PadLeft(2, '0') + "/" +
                                     programarPagos.mesEstatico.ToString().PadLeft(2, '0') + "/" +
                                     programarPagos.anioEstatico;

            fechaTxt.Text = fechaActual;
        }
    }
}
