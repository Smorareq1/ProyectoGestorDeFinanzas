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
    public partial class Inversiones : Form
    {
        public Inversiones()
        {
            InitializeComponent();
        }

        private void Inversiones_Load(object sender, EventArgs e)
        {

            llenarDataGrid();

            //Llenar con meses
            for (int i = 1; i <= 12; i++)
            {
                PlazoComboBox.Items.Add(i);
            }

            //centrar
            registrarBtn.Location = new Point((this.Width - registrarBtn.Width) / 2, registrarBtn.Location.Y);
            guna2CustomGradientPanel1.Location = new Point((this.Width - guna2CustomGradientPanel1.Width) / 2, guna2CustomGradientPanel1.Location.Y);
            tasaInteresTxt.Location = new Point((this.Width - tasaInteresTxt.Width) / 2, tasaInteresTxt.Location.Y);
        }

        private void registrarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = nombretxt.Text;
                double monto = Convert.ToDouble(montoTxt.Text);
                double tasaInteres = Convert.ToDouble(tasaInteresTxt.Text);
                int plazo = Convert.ToInt32(PlazoComboBox.SelectedItem);
                string fecha = fechatxt.Text;


                //Convertir fecha a DateTime
                DateTime fechaDT = DateTime.ParseExact(fecha, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                Inversion nuevaInversion = new Inversion(nombre, monto, fechaDT, tasaInteres, plazo);

                //Agregar a la lista de inversiones
                Transacciones.inversiones.Add(nuevaInversion);

                //Vaciar campos de inversiones
                vaciarCampos();

                //Actualizar el DataGridView
                llenarDataGrid();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void vaciarCampos()
        {
            nombretxt.Text = "";
            montoTxt.Text = "";
            tasaInteresTxt.Text = "";
            fechatxt.Text = "";
            PlazoComboBox.SelectedIndex = -1;
        }

        private void llenarDataGrid()
        {
            //Ordenar inversiones
            Transacciones.ordenarInversionesPorFecha();

            gunaGastosIngresosGrid.Rows.Clear();
            gunaGastosIngresosGrid.Columns.Clear();

            //Agregar columnas  
            // Agregar las columnas al Guna2DataGridView
            gunaGastosIngresosGrid.Columns.Add("NombreColumn", "Nombre");
            gunaGastosIngresosGrid.Columns.Add("MontoColumn", "Monto");
            gunaGastosIngresosGrid.Columns.Add("TasaInteresColumn", "Tasa de interes %");
            gunaGastosIngresosGrid.Columns.Add("PlazoColumn", "Plazo (meses)");
            gunaGastosIngresosGrid.Columns.Add("FechaColumn", "Fecha");
            gunaGastosIngresosGrid.Columns.Add("ValorFinalColumn", "Valor Final");
            gunaGastosIngresosGrid.Columns.Add("RentabilidadColumn", "Rentabilidad");

            // Establecer el modo de ajuste de columna
            gunaGastosIngresosGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Recorrer la lista de inversiones
            foreach (var inversion in Transacciones.inversiones)
            {
                if (inversion != null)
                {
                    // Agregar una fila al Guna2DataGridView con los datos de la transacción
                    gunaGastosIngresosGrid.Rows.Add(inversion.Nombre, inversion.MontoInvertido, inversion.TasaInteres, inversion.Plazo, inversion.Fecha.ToString("dd/MM/yyyy"), inversion.ValorFinal, inversion.TasaRentabilidad);
                }
            }

        }

        private void refreshDataGrid_Click(object sender, EventArgs e)
        {
            llenarDataGrid();
        }
    }
}
