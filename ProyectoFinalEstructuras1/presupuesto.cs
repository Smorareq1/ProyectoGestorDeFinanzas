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
    public partial class presupuesto : Form
    {


        public presupuesto()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void presupuesto_Load(object sender, EventArgs e)
        {
            presupuestoLabel.Text = Transacciones.presupuestoActual.ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e) //Cambiar presupuesto
        {
            try
            {
                Transacciones.presupuestoActual = Convert.ToDouble(presupuestoTxt.Text);
                presupuestoLabel.Text = Convert.ToString(Transacciones.presupuestoActual);

                if (gastosIngresos.presupuestoLabel != null)
                { //Arregle modificando el designer

                    gastosIngresos.presupuestoLabel.Text = Convert.ToString(Transacciones.presupuestoActual);

                }

                presupuestoTxt.Text = "";
                MessageBox.Show("Presupuesto actualizado exitosamente.");
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido.");
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e) // Cambiar de correo
        {
            try
            {
                if (IsValidEmail(correoTxt.Text))
                {
                    Transacciones.correo = correoTxt.Text;
                    MessageBox.Show("Correo cambiado exitosamente.");
                    correoTxt.Text = "";
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un correo válido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }

        private bool IsValidEmail(string email) //validar si el correo es valido
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
