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
                categoriaTxt.Text = transaccionSeleccionada.Categoria;
                montoTxt.Text = transaccionSeleccionada.Monto.ToString();
                fechaTxt.Text = transaccionSeleccionada.Fecha.ToString("dd/MM/yyyy");
            }
        }

        private void editarTransaccionBtn_Click(object sender, EventArgs e) //editar la transaccion seleccionada en el datagrid
        {
            // Verificar si hay una fila seleccionada
            if (indiceFilaSeleccionada != -1)
            {
                // Crear una nueva transacción con los datos editados
                Transaccion transaccionEditada = new Transaccion(nombreTxt.Text, Convert.ToDouble(montoTxt.Text), DateTime.ParseExact(fechaTxt.Text, "dd/MM/yyyy", null), categoriaTxt.Text);

                // Reemplazar la transacción anterior con la editada
                Transacciones.transacciones[indiceFilaSeleccionada] = transaccionEditada;

                // Limpiar el índice seleccionado
                indiceFilaSeleccionada = -1;

                // Limpiar los TextBox
                nombreTxt.Clear();
                categoriaTxt.Clear();
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

        private void eliminarTransaccionBtn_Click(object sender, EventArgs e) //Elimnar la transaccion selccionada
        {

            if (indiceFilaSeleccionada != -1)
            {

                Transacciones.transacciones.RemoveAt(indiceFilaSeleccionada);

                // Limpiar el índice seleccionado
                indiceFilaSeleccionada = -1;


                nombreTxt.Clear();
                categoriaTxt.Clear();
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
