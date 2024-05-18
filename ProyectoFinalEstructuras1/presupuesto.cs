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
    }
}
