namespace ProyectoFinalEstructuras1
{
    public partial class Form1 : Form
    {
        //Forms
        presupuesto formpresupuesto;
        historial formhistorial;
        reportes formreportes;
        gastosIngresos formgastosIngresos;
        programarPagos formprogramarPagos;
        planificacion formplanificacion;
        editarEliminar formeditarElimnar;
        Inversiones formInversiones;




        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e) //Cargar valores iniciales
        {
            Transacciones.presupuestoActual = GestorDeArchivos.GetPresupuestoInicial();

            Transacciones.transacciones = GestorDeArchivos.LeerTransaccionesEncriptadas();
            Transacciones.ordenarTransaccionesPorFecha();

            Transacciones.transaccionesProgramadas = GestorDeArchivos.LeerTransaccionesProgramadasEncriptadas();
            Transacciones.ordenarTransaccionesProgramadasPorFecha();

            Transacciones.correo = GestorDeArchivos.GetCorreoInicial();

            Transacciones.inversiones = GestorDeArchivos.LeerInversionesEncriptadas();

            Transacciones.recomendaciones = GestorDeArchivos.LeerRecomendacionesEncriptadas();

        }

        //=========================================== MENU ==================================================
        bool menuExpand = false;

        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuContainer.Height += 10;
                if (menuContainer.Height >= 218)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer.Height -= 10;
                if (menuContainer.Height <= 66)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void menu_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        bool sidebarExpand = true;

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 5;
                if (sidebar.Width <= 76)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();

                }
            }
            else
            {
                sidebar.Width += 5;
                if (sidebar.Width >= 241)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();

                }
            }
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }



        private void button2_Click(object sender, EventArgs e) //Presupuesto
        {
            if (formpresupuesto == null)
            {
                formpresupuesto = new presupuesto();
                formpresupuesto.FormClosed += presupuesto_FormClosed;
                formpresupuesto.MdiParent = this;
                formpresupuesto.Dock = DockStyle.Fill;

                formpresupuesto.ControlBox = false;
                formpresupuesto.AllowDrop = false;
                formpresupuesto.Text = "";

                formpresupuesto.Show();
            }
            else
            {
                formpresupuesto.Activate();
            }
        }
        private void presupuesto_FormClosed(object sender, FormClosedEventArgs e)
        {
            formpresupuesto = null;
        }

        private void btnHistorial_Click(object sender, EventArgs e) //Historial
        {
            if (formhistorial == null)
            {
                formhistorial = new historial();
                formhistorial.FormClosed += historial_FormClosed;
                formhistorial.MdiParent = this;
                formhistorial.Dock = DockStyle.Fill;

                formhistorial.ControlBox = false;
                formhistorial.AllowDrop = false;
                formhistorial.Text = "";

                formhistorial.Show();
            }
            else
            {
                formhistorial.Activate();
            }
        }

        private void historial_FormClosed(object sender, FormClosedEventArgs e)
        {
            formhistorial = null;
        }

        private void btnReportes_Click(object sender, EventArgs e) //Reportes
        {
            if (formreportes == null)
            {
                formreportes = new reportes();
                formreportes.FormClosed += reportes_FormClosed;
                formreportes.MdiParent = this;
                formreportes.Dock = DockStyle.Fill;

                formreportes.ControlBox = false;
                formreportes.AllowDrop = false;
                formreportes.Text = "";

                formreportes.Show();
            }
            else
            {
                formreportes.Activate();
            }
        }

        private void reportes_FormClosed(object sender, FormClosedEventArgs e)
        {
            formreportes = null;
        }

        private void button3_Click(object sender, EventArgs e) //Gastos e Ingresos
        {
            if (formgastosIngresos == null)
            {
                formgastosIngresos = new gastosIngresos();
                formgastosIngresos.FormClosed += gastosIngresos_FormClosed;
                formgastosIngresos.MdiParent = this;
                formgastosIngresos.Dock = DockStyle.Fill;

                formgastosIngresos.ControlBox = false;
                formgastosIngresos.AllowDrop = false;
                formgastosIngresos.Text = "";



                formgastosIngresos.Show();

            }
            else
            {
                formgastosIngresos.Activate();
            }
        }

        private void gastosIngresos_FormClosed(object sender, FormClosedEventArgs e)
        {
            formgastosIngresos = null;
        }

        private void button4_Click(object sender, EventArgs e) //Programar Pagos
        {
            if (formprogramarPagos == null)
            {
                formprogramarPagos = new programarPagos();
                formprogramarPagos.FormClosed += programarPagos_FormClosed;
                formprogramarPagos.MdiParent = this;
                formprogramarPagos.Dock = DockStyle.Fill;

                formprogramarPagos.ControlBox = false;
                formprogramarPagos.AllowDrop = false;
                formprogramarPagos.Text = "";

                formprogramarPagos.Show();
            }
            else
            {
                formprogramarPagos.Activate();
            }
        }

        private void programarPagos_FormClosed(object sender, FormClosedEventArgs e)
        {
            formprogramarPagos = null;
        }

        private void button8_Click(object sender, EventArgs e) //Planificacion
        {
            if (formplanificacion == null)
            {
                formplanificacion = new planificacion();
                formplanificacion.FormClosed += planificacion_FormClosed;
                formplanificacion.MdiParent = this;
                formplanificacion.Dock = DockStyle.Fill;

                formplanificacion.ControlBox = false;
                formplanificacion.AllowDrop = false;
                formplanificacion.Text = "";

                formplanificacion.Show();
            }
            else
            {
                formplanificacion.Activate();
            }
        }

        private void planificacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            formplanificacion = null;
        }

        private void button1_Click_1(object sender, EventArgs e) //Editar y eliminar
        {
            if (formeditarElimnar == null)
            {
                formeditarElimnar = new editarEliminar();
                formeditarElimnar.FormClosed += editarEliminar_FormClosed;
                formeditarElimnar.MdiParent = this;
                formeditarElimnar.Dock = DockStyle.Fill;

                formeditarElimnar.ControlBox = false;
                formeditarElimnar.AllowDrop = false;
                formeditarElimnar.Text = "";

                formeditarElimnar.Show();
            }
            else
            {
                formeditarElimnar.Activate();
            }
        }

        private void editarEliminar_FormClosed(object sender, FormClosedEventArgs e)
        {
            formeditarElimnar = null;
        }

        private void button6_Click(object sender, EventArgs e) //Inversiones
        {
            if (formInversiones == null)
            {
                formInversiones = new Inversiones();
                formInversiones.FormClosed += formInversiones_FormClosed;
                formInversiones.MdiParent = this;
                formInversiones.Dock = DockStyle.Fill;

                formInversiones.ControlBox = false;
                formInversiones.AllowDrop = false;
                formInversiones.Text = "";

                formInversiones.Show();
            }
            else
            {
                formInversiones.Activate();
            }
        }

        private void formInversiones_FormClosed(object sender, FormClosedEventArgs e)
        {
            formInversiones = null;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Guardar todos los datos que se hayan trabajado en la aplicacion
            GestorDeArchivos.SetPresupuestoInicial(Transacciones.presupuestoActual);

            Transacciones.ordenarTransaccionesPorFecha();
            GestorDeArchivos.GuardarTransaccionesEncriptadas(Transacciones.transacciones);

            GestorDeArchivos.SetCorreoInicial(Transacciones.correo);

            Transacciones.ordenarTransaccionesProgramadasPorFecha();
            GestorDeArchivos.GuardarTransaccionesProgramadasEncriptadas(Transacciones.transaccionesProgramadas);

            GestorDeArchivos.GuardarInversionesEncriptadas(Transacciones.inversiones);

            GestorDeArchivos.GuardarRecomendacionesEncriptadas(Transacciones.recomendaciones);

            //Mensaje de correo con los pagos 
            programarPagos.mandarProximos7Dias();

            //Salir
            Application.Exit();
        }

        



        //=======================================================================================================
    }
}
