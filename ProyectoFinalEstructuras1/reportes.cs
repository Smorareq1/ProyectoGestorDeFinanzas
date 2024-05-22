using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using ProyectoFinalEstructuras1;
using System.Drawing.Imaging;




namespace ProyectoFinalEstructuras1
{
    public partial class reportes : Form
    {
        historial historialForm;

        public reportes()
        {
            InitializeComponent();
            historialForm = new historial(); // Crear una instancia de historial

        }

        private void btnGenerarPDF_Click(object sender, EventArgs e)
        {
            try
            {
                string fechaInicio = desdeFechaTxt.Text;
                string fechaFinal = hastaFechaTxt.Text;

                if (fechaInicio == "" || fechaFinal == "")
                {
                    MessageBox.Show("Por favor, seleccione un rango de fechas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    DateTime fechaInicialDateTime = DateTime.ParseExact(fechaInicio, "dd/MM/yyyy", null);
                    DateTime fechaFinalDateTime = DateTime.ParseExact(fechaFinal, "dd/MM/yyyy", null);

                    historialForm.ActualizarGraficas(fechaInicialDateTime, fechaFinalDateTime);


                    GuardarPDF(GenerarReportePDF(fechaInicialDateTime, fechaFinalDateTime));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el PDF: " + ex.Message);
            }


        }

        private byte[] GenerarReportePDF(DateTime fechaInicial, DateTime fechaFinal)
        {
            Document doc = new Document();
            MemoryStream stream = new MemoryStream();

            try
            {
                PdfWriter.GetInstance(doc, stream);
                doc.Open();

                // Agregar texto del reporte
                doc.Add(new iTextSharp.text.Paragraph("Reporte de Transacciones"));
                doc.Add(new iTextSharp.text.Paragraph($"Fecha de inicio: {fechaInicial.ToShortDateString()}"));
                doc.Add(new iTextSharp.text.Paragraph($"Fecha final: {fechaFinal.ToShortDateString()}"));
                doc.Add(new iTextSharp.text.Paragraph(" "));

                // Agregar tabla de transacciones
                PdfPTable table = new PdfPTable(4);
                float[] comlumnas = { 30, 30, 20, 20 };
                table.SetWidths(comlumnas);
                table.AddCell("Nombre");
                table.AddCell("Categoría");
                table.AddCell("Monto");
                table.AddCell("Fecha");

                var transaccionesEnRango = Transacciones.transacciones
                    .Where(t => t.Fecha >= fechaInicial && t.Fecha <= fechaFinal)
                    .ToList();

                foreach (var transaccion in transaccionesEnRango)
                {
                    table.AddCell(transaccion.Nombre);
                    table.AddCell(transaccion.Categoria);
                    table.AddCell(transaccion.Monto.ToString());
                    table.AddCell(transaccion.Fecha.ToShortDateString());
                }

                doc.Add(table);
                doc.Add(new Paragraph(" "));

                // Agregar gráficos al reporte
                doc.Add(new Paragraph("Transacciones Completas"));
                doc.Add(new Paragraph(" "));
                doc.Add(AgregarImagenAlPDF(historialForm.GetChart1()));
                doc.Add(new Paragraph(" "));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el PDF: " + ex.Message);
            }
            finally
            {
                doc.Close();
            }

            return stream.ToArray();
        }

        private iTextSharp.text.Image AgregarImagenAlPDF(Chart chart)
        {
            // Renderizar el chart como una imagen y obtener los bytes
            byte[] chartImageBytes = RenderizarChartComoImagen(chart);

            // Crear una imagen de iTextSharp a partir de los bytes
            iTextSharp.text.Image chartImage = iTextSharp.text.Image.GetInstance(chartImageBytes);

            // Ajustar el tamaño de la imagen al tamaño del documento
            chartImage.ScaleToFit(PageSize.A4.Width - 50, PageSize.A4.Height - 50);

            return chartImage;
        }
        
        private byte[] RenderizarChartComoImagen(Chart chart)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                chart.SaveImage(ms, ChartImageFormat.Png);
                return ms.ToArray();
            }
        }


        private void GuardarPDF(byte[] pdfData)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivo PDF (*.pdf)|*.pdf";
            saveFileDialog.Title = "Guardar reporte PDF";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                File.WriteAllBytes(saveFileDialog.FileName, pdfData);
                MessageBox.Show("El reporte PDF se ha guardado correctamente.", "Guardar PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGenerarPDFGastos_Click(object sender, EventArgs e)
        {
            string fechaInicio = desdeFechaTxt.Text;
            string fechaFinal = hastaFechaTxt.Text;

            DateTime fechaInicialDateTime = DateTime.ParseExact(fechaInicio, "dd/MM/yyyy", null);
            DateTime fechaFinalDateTime = DateTime.ParseExact(fechaFinal, "dd/MM/yyyy", null);

            GuardarPDF(GenerarReportePDFGastos(fechaInicialDateTime, fechaFinalDateTime));
        }

        private byte[] GenerarReportePDFGastos(DateTime fechaInicial, DateTime fechaFinal)
        {
            Document doc = new Document();
            MemoryStream stream = new MemoryStream();

            try
            {
                PdfWriter.GetInstance(doc, stream);
                doc.Open();

                doc.Add(new Paragraph("Reporte de Gastos"));
                doc.Add(new Paragraph($"Fecha de inicio: {fechaInicial.ToShortDateString()}"));
                doc.Add(new Paragraph($"Fecha final: {fechaFinal.ToShortDateString()}"));
                doc.Add(new Paragraph($" "));

                PdfPTable table = new PdfPTable(4);
                float[] comlumnas = { 30, 30, 20, 20 };
                table.SetWidths(comlumnas);
                table.AddCell("Nombre");
                table.AddCell("Categoría");
                table.AddCell("Monto");
                table.AddCell("Fecha");

                var transaccionesGastosEnRango = Transacciones.transacciones
                    .Where(t => t.Fecha >= fechaInicial && t.Fecha <= fechaFinal && t.Monto < 0)
                    .ToList();

                foreach (var transaccion in transaccionesGastosEnRango)
                {
                    table.AddCell(transaccion.Nombre);
                    table.AddCell(transaccion.Categoria);
                    table.AddCell(transaccion.Monto.ToString());
                    table.AddCell(transaccion.Fecha.ToShortDateString());
                }

                doc.Add(table);
                doc.Add(new Paragraph(" "));

                // Agregar gráfico de gastos por categoría
                doc.Add(new Paragraph("Gastos por Categoría"));
                doc.Add(new Paragraph(" "));
                doc.Add(AgregarImagenAlPDF(historialForm.GetChart2()));
                doc.Add(new Paragraph(" "));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el PDF de gastos: " + ex.Message);
            }
            finally
            {
                doc.Close();
            }

            return stream.ToArray();
        }

        private void btnGenerarPDFIngresos_Click(object sender, EventArgs e)
        {
            string fechaInicio = desdeFechaTxt.Text;
            string fechaFinal = hastaFechaTxt.Text;

            DateTime fechaInicialDateTime = DateTime.ParseExact(fechaInicio, "dd/MM/yyyy", null);
            DateTime fechaFinalDateTime = DateTime.ParseExact(fechaFinal, "dd/MM/yyyy", null);

            GuardarPDF(GenerarReportePDFIngresos(fechaInicialDateTime, fechaFinalDateTime));
        }

        private byte[] GenerarReportePDFIngresos(DateTime fechaInicial, DateTime fechaFinal)
        {
            Document doc = new Document();
            MemoryStream stream = new MemoryStream();

            try
            {
                PdfWriter.GetInstance(doc, stream);
                doc.Open();

                doc.Add(new Paragraph("Reporte de Ingresos"));
                doc.Add(new Paragraph($"Fecha de inicio: {fechaInicial.ToShortDateString()}"));
                doc.Add(new Paragraph($"Fecha final: {fechaFinal.ToShortDateString()}"));
                doc.Add(new Paragraph($" "));

                PdfPTable table = new PdfPTable(4);
                float[] comlumnas = { 30, 30, 20, 20 };
                table.SetWidths(comlumnas);
                table.AddCell("Nombre");
                table.AddCell("Categoría");
                table.AddCell("Monto");
                table.AddCell("Fecha");

                var transaccionesIngresosEnRango = Transacciones.transacciones
                    .Where(t => t.Fecha >= fechaInicial && t.Fecha <= fechaFinal && t.Monto > 0)
                    .ToList();

                foreach (var transaccion in transaccionesIngresosEnRango)
                {
                    table.AddCell(transaccion.Nombre);
                    table.AddCell(transaccion.Categoria);
                    table.AddCell(transaccion.Monto.ToString());
                    table.AddCell(transaccion.Fecha.ToShortDateString());
                }

                doc.Add(table);
                doc.Add(new Paragraph(" "));

                // Agregar gráfico de ingresos por categoría
                doc.Add(new Paragraph("Ingresos por Categoría"));
                doc.Add(new Paragraph(" "));
                doc.Add(AgregarImagenAlPDF(historialForm.GetChart3()));
                doc.Add(new Paragraph(" "));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el PDF de ingresos: " + ex.Message);
            }
            finally
            {
                doc.Close();
            }

            return stream.ToArray();
        }

        private void definirRango_Click(object sender, EventArgs e)
        {

        }
    }
}