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
            label1.Text = "Presupuesto actual: " + Form1.presupuestoActual.ToString();
            
        }
    }
}
