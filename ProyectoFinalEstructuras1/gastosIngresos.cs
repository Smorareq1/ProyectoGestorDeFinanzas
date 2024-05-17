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
            presupuestoLabel.Text = Transacciones.presupuestoActual.ToString();
            llenarDataGridView();

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


                Transacciones.agregarElemento(transaccion);
                vaciarCampos();
                MessageBox.Show("Transaccion registrada exitosamente.");


                llenarDataGridView();
                presupuestoLabel.Text = Transacciones.presupuestoActual.ToString();
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

        private void llenarDataGridView()
        {
            //Ordenar transacciones por fecha
            Transacciones.ordenarTransaccionesPorFecha();


            // Limpiar cualquier dato existente en el DataGridView
            gastosIngresosGrid.Rows.Clear();
            gastosIngresosGrid.Columns.Clear();

            // Agregar las columnas al DataGridView
            gastosIngresosGrid.Columns.Add("NombreColumn", "Nombre");
            gastosIngresosGrid.Columns.Add("CategoriaColumn", "Categoria");
            gastosIngresosGrid.Columns.Add("MontoColumn", "Monto");
            gastosIngresosGrid.Columns.Add("FechaColumn", "Fecha");

            // Establecer el modo de ajuste de columna
            gastosIngresosGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //centrar texto
            gastosIngresosGrid.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //sombras
            gastosIngresosGrid.EnableHeadersVisualStyles = false;
            gastosIngresosGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
            gastosIngresosGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gastosIngresosGrid.ColumnHeadersDefaultCellStyle.Font = new Font(gastosIngresosGrid.Font, FontStyle.Bold);


            // Recorrer la lista de productos


            foreach (var transaccion in Transacciones.transacciones)
            {
                if (transaccion != null)
                {
                    // Agregar una fila al DataGridView con los datos del producto
                    gastosIngresosGrid.Rows.Add(transaccion.Nombre, transaccion.Categoria, transaccion.Monto, transaccion.Fecha.ToString("dd/MM/yyyy"));
                }
            }

            // Opcional: Autoajustar las filas
            gastosIngresosGrid.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);

            // Opcional: Autoajustar las columnas en función del contenido
            gastosIngresosGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            // Opcional: Autoajustar todas las columnas para que se ajusten al ancho del DataGridView
            //gastosIngresosGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);
        }

    }
}
