﻿using System;
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
        public static double nuevoPresupuesto;

        public presupuesto()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e) //Cambiar presupuesto
        {
            try
            {
                nuevoPresupuesto = Convert.ToDouble(textBox1.Text);
                GestorDeArchivos.SetPresupuestoInicial(nuevoPresupuesto);
                presupuestoLabel.Text = Convert.ToString(nuevoPresupuesto);
                textBox1.Text = "";
                MessageBox.Show("Presupuesto actualizado exitosamente.");
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido.");
            }
            
        }

        private void presupuesto_Load(object sender, EventArgs e)
        {
            presupuestoLabel.Text = Convert.ToString(GestorDeArchivos.GetPresupuestoInicial());
        }
    }
}
