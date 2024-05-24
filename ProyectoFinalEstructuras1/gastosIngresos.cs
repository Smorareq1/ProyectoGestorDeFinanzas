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

            llenarComoboBox();

            //centrar
            registrarBtn.Location = new Point((this.Width - registrarBtn.Width) / 2, registrarBtn.Location.Y);

        }

        private void llenarComoboBox()
        {
            categoriatxt.Items.Add("Alimentacion");
            categoriatxt.Items.Add("Transporte");
            categoriatxt.Items.Add("Salud");
            categoriatxt.Items.Add("Educacion");
            categoriatxt.Items.Add("Entretenimiento");
            categoriatxt.Items.Add("Otros");
        }

        private void button1_Click(object sender, EventArgs e) 
        {

        }

        private void vaciarCampos()
        {
            nombretxt.Text = "";
            montotxt.Text = "";
            fechatxt.Text = "";
            categoriatxt.SelectedIndex = -1;
        }

        private void llenarDataGridView()
        {
            // Ordenar transacciones por fecha
            Transacciones.ordenarTransaccionesPorFecha();

            // Limpiar cualquier dato existente en el Guna2DataGridView
            gunaGastosIngresosGrid.Rows.Clear();
            gunaGastosIngresosGrid.Columns.Clear();

            // Agregar las columnas al Guna2DataGridView
            gunaGastosIngresosGrid.Columns.Add("NombreColumn", "Nombre");
            gunaGastosIngresosGrid.Columns.Add("CategoriaColumn", "Categoria");
            gunaGastosIngresosGrid.Columns.Add("MontoColumn", "Monto");
            gunaGastosIngresosGrid.Columns.Add("FechaColumn", "Fecha");

            // Establecer el modo de ajuste de columna
            gunaGastosIngresosGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Recorrer la lista de transacciones
            foreach (var transaccion in Transacciones.transacciones)
            {
                if (transaccion != null)
                {
                    // Agregar una fila al Guna2DataGridView con los datos de la transacción
                    gunaGastosIngresosGrid.Rows.Add(transaccion.Nombre, transaccion.Categoria, transaccion.Monto, transaccion.Fecha.ToString("dd/MM/yyyy"));
                }
            }

            // Suscribirse al evento CellFormatting para cambiar el color del texto
            gunaGastosIngresosGrid.CellFormatting += gunaGastosIngresosGrid_CellFormatting;
        }

        private void gunaGastosIngresosGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Verificar si la columna actual es la columna de monto
            if (gunaGastosIngresosGrid.Columns[e.ColumnIndex].Name == "MontoColumn")
            {
                // Obtener el valor del monto
                if (e.Value != null && double.TryParse(e.Value.ToString(), out double monto))
                {
                    // Cambiar el color del texto basado en el valor del monto
                    if (monto < 0)
                    {
                        e.CellStyle.ForeColor = Color.Red;
                    }
                    else
                    {
                        e.CellStyle.ForeColor = Color.Blue;
                    }
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e) //Registrar gasto
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
    }
}
