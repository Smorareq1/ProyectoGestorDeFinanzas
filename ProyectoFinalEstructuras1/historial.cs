using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.WinForms.Suite.Descriptions;

using System.Windows.Forms.DataVisualization.Charting;





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
            // Limpiar series existentes en el chart
            LimpiarChart();

            // Ajustar las propiedades del área del gráfico
            chart1.ChartAreas.Add(new ChartArea());
            chart1.ChartAreas[0].AxisX.Interval = 1; // Espaciado entre las barras
            chart1.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 8); // Tamaño de fuente para las etiquetas en el eje X

            // Remover las líneas de la cuadrícula
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

            // Remover las líneas de los ejes
            chart1.ChartAreas[0].AxisX.LineColor = Color.Transparent;
            chart1.ChartAreas[0].AxisY.LineColor = Color.Transparent;

            // Filtrar las transacciones dentro del rango de fechas
            var transaccionesEnRango = Transacciones.transacciones
                .Where(t => t.Fecha >= fechaInicial && t.Fecha <= fechaFinal)
                .ToList();

            // Crear una serie para el gráfico de barras
            Series serie = new Series();
            serie.ChartType = SeriesChartType.Column;
            serie["PointWidth"] = "0.2";

            // Contador para la posición en el eje X
            int posicionX = 0;

            // Agregar cada transacción como una barra en la serie
            foreach (var transaccion in transaccionesEnRango)
            {
                DataPoint punto = new DataPoint();
                punto.SetValueXY(posicionX, Math.Abs(transaccion.Monto)); // Usar el valor absoluto del monto
                punto.Color = transaccion.Monto > 0 ? Color.Blue : Color.Red; // Color azul para ingresos, rojo para gastos
                punto.Label = Math.Abs(transaccion.Monto).ToString(); // Establecer el label como el monto
                punto.Tag = transaccion.Nombre + " - " + transaccion.Categoria; // Almacenar nombre y categoría como Tag del punto
                serie.Points.Add(punto);

                // Establecer la etiqueta personalizada para el eje X
                chart1.ChartAreas[0].AxisX.CustomLabels.Add(posicionX - 0.5, posicionX + 0.5, transaccion.Fecha.ToShortDateString());

                // Incrementar la posición en el eje X
                posicionX++;
            }

            // Agregar la serie al gráfico
            chart1.Series.Add(serie);

            // Agregar el manejador de evento para el clic en el gráfico
            chart1.MouseClick += Chart1_MouseClick;

            // Mostrar el gráfico
            chart1.DataBind(); // Actualiza los datos en el gráfico
        }

        private void LimpiarChart()
        {
            int width = chart1.Width;
            int height = chart1.Height;

            int x = chart1.Location.X;
            int y = chart1.Location.Y;


            // Limpia todas las series del chart
            chart1.Series.Clear();

            // Limpia todas las áreas del chart
            chart1.ChartAreas.Clear();

            // Elimina el chart del formulario
            Controls.Remove(chart1);

            // Limpia los controles del formulario
            chart1.Dispose();

            // Crea un nuevo chart
            chart1 = new Chart();

            // Agrega el chart al formulario
            Controls.Add(chart1);

            // Configura el tamaño y la posición del chart
            chart1.Size = new Size(width, height);
            chart1.Location = new Point(x,y);
        }


        private void Chart1_MouseClick(object sender, MouseEventArgs e)
        {
            // Obtener la información de la transacción desde el punto de datos
            var hit = chart1.HitTest(e.X, e.Y);
            if (hit.ChartElementType == ChartElementType.DataPoint)
            {
                var punto = hit.Series.Points[hit.PointIndex];
                string nombreCategoria = punto.Tag.ToString();
                MessageBox.Show(nombreCategoria, "Nombre y Categoría de la Transacción");
            }
        }




        private void historial_Load(object sender, EventArgs e)
        {

        }
    }
}
