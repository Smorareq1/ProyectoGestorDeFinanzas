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

            //Llenar con meses
            for(int i = 1; i <= 12; i++)
            {
                PlazoComboBox.Items.Add(i);
            }
            
            //centrar
            registrarBtn.Location = new Point((this.Width - registrarBtn.Width) / 2, registrarBtn.Location.Y);
            guna2CustomGradientPanel1.Location = new Point((this.Width - guna2CustomGradientPanel1.Width) / 2, guna2CustomGradientPanel1.Location.Y);
            tasaInteresTxt.Location = new Point((this.Width - tasaInteresTxt.Width) / 2, tasaInteresTxt.Location.Y);
        }


    }
}
