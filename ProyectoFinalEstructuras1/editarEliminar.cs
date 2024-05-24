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
    public partial class editarEliminar : Form
    {
        private int indiceFilaSeleccionada = -1;

        public editarEliminar()
        {
            InitializeComponent();
            gunaGastosIngresosGrid.CellClick += gunaGastosIngresosGrid_CellClick;
        }

        private void editarEliminar_Load(object sender, EventArgs e) //load
        {
            llenarDataGridView();
            llenarComboBoxCategorias();
            llenarComoboBox();


            
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


        private void refreshDataGrid_Click(object sender, EventArgs e) //refrescar
        {
            llenarDataGridView();
        }

        private void llenarComboBoxCategorias()
        {
            categoriaComboBox.Items.Clear();

            // Obtener las categorías distintas de las transacciones
            var categorias = Transacciones.transacciones
                .Select(t => t.Categoria)
                .Distinct()
                .ToList();

            // Agregar las categorías al ComboBox
            categoriaComboBox.Items.AddRange(categorias.ToArray());

        }

        private void gunaGastosIngresosGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se ha seleccionado una fila válida
            if (e.RowIndex >= 0)
            {
                // Obtener el índice de la fila seleccionada
                indiceFilaSeleccionada = e.RowIndex;

                // Obtener la transacción seleccionada
                var transaccionSeleccionada = Transacciones.transacciones[indiceFilaSeleccionada];

                // Colocar los valores de la transacción en los TextBox
                nombreTxt.Text = transaccionSeleccionada.Nombre;
                categoriatxt.Text = transaccionSeleccionada.Categoria;
                montoTxt.Text = transaccionSeleccionada.Monto.ToString();
                fechaTxt.Text = transaccionSeleccionada.Fecha.ToString("dd/MM/yyyy");
            }
        }

        private void editarTransaccionBtn_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada
            if (indiceFilaSeleccionada != -1)
            {
                try
                {
                    // Crear una nueva transacción con los datos editados
                    Transaccion transaccionEditada = new Transaccion(
                        nombreTxt.Text,
                        Convert.ToDouble(montoTxt.Text),
                        DateTime.ParseExact(fechaTxt.Text, "dd/MM/yyyy", null),
                        categoriatxt.Text
                    );

                    // Obtener el monto original y el nuevo monto
                    double montoOriginal = Transacciones.transacciones[indiceFilaSeleccionada].Monto;
                    double nuevoMonto = transaccionEditada.Monto;

                    // Calcular la diferencia y ajustar el presupuesto
                    double diferencia = CalcularDiferencia(montoOriginal, nuevoMonto);
                    AjustarPresupuesto(montoOriginal, nuevoMonto);

                    // Reemplazar la transacción anterior con la editada
                    Transacciones.transacciones[indiceFilaSeleccionada] = transaccionEditada;

                    // Limpiar el índice seleccionado
                    indiceFilaSeleccionada = -1;

                    // Limpiar los TextBox
                    nombreTxt.Clear();
                    categoriatxt.SelectedIndex = -1;
                    montoTxt.Clear();
                    fechaTxt.Clear();

                    // Actualizar el DataGridView
                    llenarDataGridView();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Por favor, ingrese datos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una transacción para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double CalcularDiferencia(double montoOriginal, double nuevoMonto)
        {
            // Si ambos montos son negativos o ambos son positivos, simplemente resta
            if ((montoOriginal < 0 && nuevoMonto < 0) || (montoOriginal > 0 && nuevoMonto > 0))
            {
                return nuevoMonto - montoOriginal;
            }
            else
            {
                // Si uno es positivo y el otro negativo, suma los valores absolutos
                return nuevoMonto + montoOriginal;
            }
        }

        private void AjustarPresupuesto(double montoOriginal, double nuevoMonto)
        {
            double diferencia = CalcularDiferencia(montoOriginal, nuevoMonto);

            // Ajustar el presupuesto considerando el signo del monto
            if (montoOriginal < 0 && nuevoMonto >= 0) // Cambio de gasto a ingreso
            {
                Transacciones.presupuestoActual += Math.Abs(montoOriginal) + nuevoMonto;
            }
            else if (montoOriginal >= 0 && nuevoMonto < 0) // Cambio de ingreso a gasto
            {
                Transacciones.presupuestoActual -= montoOriginal + Math.Abs(nuevoMonto);
            }
            else if (montoOriginal < 0 && nuevoMonto < 0) // Ambos son gastos
            {
                Transacciones.presupuestoActual += diferencia;
            }
            else if (montoOriginal >= 0 && nuevoMonto >= 0) // Ambos son ingresos
            {
                Transacciones.presupuestoActual += diferencia;
            }

            if (gastosIngresos.presupuestoLabel != null)
            { //Arregle modificando el designer
                gastosIngresos.presupuestoLabel.Text = Transacciones.presupuestoActual.ToString();

            }
            if(presupuesto.presupuestoLabel != null)
            {
                presupuesto.presupuestoLabel.Text = Transacciones.presupuestoActual.ToString();
            }
            
        }

        private void eliminarTransaccionBtn_Click(object sender, EventArgs e) //Elimnar la transaccion selccionada
        {

            if (indiceFilaSeleccionada != -1)
            {

                Transacciones.transacciones.RemoveAt(indiceFilaSeleccionada);

                // Limpiar el índice seleccionado
                indiceFilaSeleccionada = -1;


                nombreTxt.Clear();
                categoriatxt.SelectedIndex = -1;
                montoTxt.Clear();
                fechaTxt.Clear();

                // Actualizar el DataGridView
                llenarDataGridView();
            }
            else
            {
                MessageBox.Show("Seleccione una transacción para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buscarNombre_Click(object sender, EventArgs e) //Buscar Transaccion por Nombre
        {
            string nombreTransaccionObjetivo = busquedaNombreTxt.Text;


            if (!string.IsNullOrWhiteSpace(nombreTransaccionObjetivo))
            {

                gunaGastosIngresosGrid.Rows.Clear();


                var transaccionesFiltradas = Transacciones.transacciones
                    .Where(t => t.Nombre.IndexOf(nombreTransaccionObjetivo, StringComparison.OrdinalIgnoreCase) >= 0)
                    .ToList();

                // Verificar si se encontraron transacciones
                if (transaccionesFiltradas.Count > 0)
                {

                    if (gunaGastosIngresosGrid.Columns.Count == 0)
                    {
                        gunaGastosIngresosGrid.Columns.Add("NombreColumn", "Nombre");
                        gunaGastosIngresosGrid.Columns.Add("CategoriaColumn", "Categoria");
                        gunaGastosIngresosGrid.Columns.Add("MontoColumn", "Monto");
                        gunaGastosIngresosGrid.Columns.Add("FechaColumn", "Fecha");
                        gunaGastosIngresosGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }


                    foreach (var transaccion in transaccionesFiltradas)
                    {
                        gunaGastosIngresosGrid.Rows.Add(transaccion.Nombre, transaccion.Categoria, transaccion.Monto, transaccion.Fecha.ToString("dd/MM/yyyy"));
                    }


                    busquedaNombreTxt.Clear();
                }
                else
                {
                    MessageBox.Show("No se encontraron transacciones con ese nombre.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un nombre para buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buscarCategoria_Click(object sender, EventArgs e) //Buscar Transaccion por Categoria
        {
            string categoriaTransaccionObjetivo = categoriaComboBox.Text;

            if (!string.IsNullOrWhiteSpace(categoriaTransaccionObjetivo))
            {
                
                gunaGastosIngresosGrid.Rows.Clear();

                // Filtrar las transacciones que coinciden con la categoría seleccionada
                var transaccionesFiltradas = Transacciones.transacciones
                    .Where(t => t.Categoria.Equals(categoriaTransaccionObjetivo, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                // Verificar si se encontraron transacciones
                if (transaccionesFiltradas.Count > 0)
                {
                    
                    if (gunaGastosIngresosGrid.Columns.Count == 0)
                    {
                        gunaGastosIngresosGrid.Columns.Add("NombreColumn", "Nombre");
                        gunaGastosIngresosGrid.Columns.Add("CategoriaColumn", "Categoria");
                        gunaGastosIngresosGrid.Columns.Add("MontoColumn", "Monto");
                        gunaGastosIngresosGrid.Columns.Add("FechaColumn", "Fecha");
                        gunaGastosIngresosGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }

                    
                    foreach (var transaccion in transaccionesFiltradas)
                    {
                        gunaGastosIngresosGrid.Rows.Add(transaccion.Nombre, transaccion.Categoria, transaccion.Monto, transaccion.Fecha.ToString("dd/MM/yyyy"));
                    }

                    // Limpiar el ComboBox de categorías
                    categoriaComboBox.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("No se encontraron transacciones con esa categoría.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una categoría para buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
