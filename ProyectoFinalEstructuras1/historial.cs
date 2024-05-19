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
    public partial class historial : Form
    {
        public historial()
        {
            InitializeComponent();

            
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        



        private void definirRango_Click(object sender, EventArgs e) //Boton para cargar los graficos
        {
            string fechaInicio = desdeFechaTxt.Text;
            string fechaFinal = hastaFechaTxt.Text;

            DateTime fechaInicialDateTime = DateTime.ParseExact(fechaInicio, "dd/MM/yyyy", null);
            DateTime fechaFinalDateTime = DateTime.ParseExact(fechaFinal, "dd/MM/yyyy", null);

            cargarGraficoBarras(fechaInicialDateTime, fechaFinalDateTime);
        }

        private void cargarGraficoBarras(DateTime fechaInicial, DateTime fechaFinal)
        {

        }

        private void historial_Load(object sender, EventArgs e)
        {

        }
    }
}
