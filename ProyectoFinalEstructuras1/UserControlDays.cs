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

        private void mostrarEvento()
        {
            //Mostrar eventos
            // Clear existing event labels
            foreach (var label in eventLabels)
            {
                this.Controls.Remove(label);
            }
            eventLabels.Clear();

            // Get the day number
            int dayNumber = int.Parse(lbDays.Text);
            DateTime currentDate = new DateTime(programarPagos.anioEstatico, programarPagos.mesEstatico, dayNumber);

            // Retrieve events for the current day
            List<TransaccionProgramada> eventosDelDia = Transacciones.transaccionesProgramadas
                .FindAll(evento => evento.Fecha.Date == currentDate.Date);

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

        //Crear un timer para mostrar automaticamente si se aniade un evento nuevo
        private void timer1_Tick(object sender, EventArgs e)
        {
            mostrarEvento();
        }



    }
}