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
    public partial class UserControlDays : UserControl
    {
        //Variables estaticas
        public static string diaEstatico;
        private List<Label> eventLabels = new List<Label>();

        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }

        public void Dias(int numeroDeDia)
        {
            lbDays.Text = numeroDeDia + "";
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            diaEstatico = lbDays.Text;
            //Comenzar timer
            timer1.Start();

            //Mostrar formulario de eventos
            EventForm eventForm = new EventForm();
            eventForm.Show();
        }

        public void mostrarEvento()
        {
            // Clear existing event labels
            foreach (var label in eventLabels)
            {
                this.Controls.Remove(label);
            }
            eventLabels.Clear();

            // Get the day number
            if (!int.TryParse(lbDays.Text, out int dayNumber))
            {
                return; // If the day number is not valid, exit the method
            }

            DateTime currentDate = new DateTime(programarPagos.anioEstatico, programarPagos.mesEstatico, dayNumber);

            // Retrieve events for the current day
            List<TransaccionProgramada> eventosDelDia = Transacciones.transaccionesProgramadas
                .Where(evento => evento.Fecha.Date == currentDate.Date ||
                                 (evento.RepetirMensualmente && IsRepeatingEventForMonth(evento, currentDate)))
                .ToList();

            // Display each event in a new label
            foreach (var evento in eventosDelDia)
            {
                Label eventLabel = new Label
                {
                    Text = evento.Nombre,
                    AutoSize = true,
                    ForeColor = Color.Black
                };
                eventLabels.Add(eventLabel);
                this.Controls.Add(eventLabel);
            }

            // Position the labels
            int yPosition = lbDays.Bottom + 5;
            foreach (var label in eventLabels)
            {
                label.Location = new Point(lbDays.Left, yPosition);
                yPosition += label.Height + 5;
            }
        }

        private bool IsRepeatingEventForMonth(TransaccionProgramada evento, DateTime currentDate)
        {
            DateTime eventDate = evento.Fecha;

            // Check if the event repeats monthly for the next 12 months
            for (int i = 0; i < 12; i++)
            {
                DateTime repeatingDate = eventDate.AddMonths(i);
                if (repeatingDate.Year == currentDate.Year && repeatingDate.Month == currentDate.Month && repeatingDate.Day == currentDate.Day)
                {
                    return true;
                }
            }
            return false;
        }





        //Crear un timer para mostrar automaticamente si se aniade un evento nuevo
        private void timer1_Tick(object sender, EventArgs e)
        {
            mostrarEvento();
        }



    }
}