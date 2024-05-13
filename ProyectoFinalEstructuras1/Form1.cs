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

        //Variables
        public static double presupuestoInicial;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

        private void button7_Click(object sender, EventArgs e)
        {
            //Guardar todos los datos que se hayan trabajado en la aplicacion
            //... Pendiente

            //Salir
            Application.Exit();
        }

        //=======================================================================================================
    }
}
