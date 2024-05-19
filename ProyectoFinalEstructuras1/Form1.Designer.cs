namespace ProyectoFinalEstructuras1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label1 = new Label();
            btnHam = new PictureBox();
            sidebar = new FlowLayoutPanel();
            pnPresupuesto = new Panel();
            button2 = new Button();
            menuContainer = new FlowLayoutPanel();
            panel5 = new Panel();
            menu = new Button();
            panel2 = new Panel();
            button5 = new Button();
            btnHistorial = new Button();
            panel6 = new Panel();
            btnReportes = new Button();
            pnGastosIngresos = new Panel();
            button3 = new Button();
            pnProgramarPagos = new Panel();
            button4 = new Button();
            pnPlanificacion = new Panel();
            button8 = new Button();
            panel3 = new Panel();
            button1 = new Button();
            pnSalir = new Panel();
            button7 = new Button();
            menuTransition = new System.Windows.Forms.Timer(components);
            sidebarTransition = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHam).BeginInit();
            sidebar.SuspendLayout();
            pnPresupuesto.SuspendLayout();
            menuContainer.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            pnGastosIngresos.SuspendLayout();
            pnProgramarPagos.SuspendLayout();
            pnPlanificacion.SuspendLayout();
            panel3.SuspendLayout();
            pnSalir.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnHam);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1240, 33);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 10F);
            label1.Location = new Point(45, 9);
            label1.Name = "label1";
            label1.Size = new Size(109, 18);
            label1.TabIndex = 1;
            label1.Text = "Finanzas-Pro";
            // 
            // btnHam
            // 
            btnHam.Image = (Image)resources.GetObject("btnHam.Image");
            btnHam.Location = new Point(12, 3);
            btnHam.Name = "btnHam";
            btnHam.Size = new Size(27, 27);
            btnHam.SizeMode = PictureBoxSizeMode.CenterImage;
            btnHam.TabIndex = 0;
            btnHam.TabStop = false;
            btnHam.Click += btnHam_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.DarkSlateGray;
            sidebar.Controls.Add(pnPresupuesto);
            sidebar.Controls.Add(menuContainer);
            sidebar.Controls.Add(pnGastosIngresos);
            sidebar.Controls.Add(pnProgramarPagos);
            sidebar.Controls.Add(pnPlanificacion);
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(pnSalir);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 33);
            sidebar.Name = "sidebar";
            sidebar.Padding = new Padding(0, 30, 0, 0);
            sidebar.Size = new Size(241, 731);
            sidebar.TabIndex = 1;
            // 
            // pnPresupuesto
            // 
            pnPresupuesto.Controls.Add(button2);
            pnPresupuesto.Location = new Point(3, 33);
            pnPresupuesto.Name = "pnPresupuesto";
            pnPresupuesto.Size = new Size(321, 66);
            pnPresupuesto.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSlateGray;
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-10, -11);
            button2.Name = "button2";
            button2.Padding = new Padding(25, 0, 0, 0);
            button2.Size = new Size(356, 86);
            button2.TabIndex = 2;
            button2.Text = "                 Editar Presupuesto";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // menuContainer
            // 
            menuContainer.BackColor = Color.DarkSlateGray;
            menuContainer.Controls.Add(panel5);
            menuContainer.Controls.Add(panel2);
            menuContainer.Controls.Add(panel6);
            menuContainer.Location = new Point(0, 102);
            menuContainer.Margin = new Padding(0);
            menuContainer.Name = "menuContainer";
            menuContainer.Size = new Size(321, 66);
            menuContainer.TabIndex = 6;
            // 
            // panel5
            // 
            panel5.Controls.Add(menu);
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(321, 66);
            panel5.TabIndex = 8;
            // 
            // menu
            // 
            menu.BackColor = Color.DarkSlateGray;
            menu.ForeColor = Color.White;
            menu.Image = (Image)resources.GetObject("menu.Image");
            menu.ImageAlign = ContentAlignment.MiddleLeft;
            menu.Location = new Point(-10, -9);
            menu.Margin = new Padding(0);
            menu.Name = "menu";
            menu.Padding = new Padding(25, 0, 0, 0);
            menu.Size = new Size(356, 86);
            menu.TabIndex = 2;
            menu.Text = "                 Opciones";
            menu.TextAlign = ContentAlignment.MiddleLeft;
            menu.UseVisualStyleBackColor = false;
            menu.Click += menu_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button5);
            panel2.Controls.Add(btnHistorial);
            panel2.Location = new Point(3, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(321, 66);
            panel2.TabIndex = 7;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkSlateGray;
            button5.ForeColor = Color.White;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(0, 144);
            button5.Margin = new Padding(0);
            button5.Name = "button5";
            button5.Padding = new Padding(25, 0, 0, 0);
            button5.Size = new Size(356, 86);
            button5.TabIndex = 3;
            button5.Text = "                 Opciones";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            // 
            // btnHistorial
            // 
            btnHistorial.BackColor = Color.DarkSlateGray;
            btnHistorial.ForeColor = Color.White;
            btnHistorial.Image = (Image)resources.GetObject("btnHistorial.Image");
            btnHistorial.ImageAlign = ContentAlignment.MiddleLeft;
            btnHistorial.Location = new Point(-10, -9);
            btnHistorial.Margin = new Padding(0);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Padding = new Padding(25, 0, 0, 0);
            btnHistorial.Size = new Size(356, 86);
            btnHistorial.TabIndex = 2;
            btnHistorial.Text = "                 Historial";
            btnHistorial.TextAlign = ContentAlignment.MiddleLeft;
            btnHistorial.UseVisualStyleBackColor = false;
            btnHistorial.Click += btnHistorial_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnReportes);
            panel6.Location = new Point(3, 147);
            panel6.Name = "panel6";
            panel6.Size = new Size(321, 66);
            panel6.TabIndex = 9;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.DarkSlateGray;
            btnReportes.ForeColor = Color.White;
            btnReportes.Image = (Image)resources.GetObject("btnReportes.Image");
            btnReportes.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportes.Location = new Point(-10, -9);
            btnReportes.Margin = new Padding(0);
            btnReportes.Name = "btnReportes";
            btnReportes.Padding = new Padding(25, 0, 0, 0);
            btnReportes.Size = new Size(356, 86);
            btnReportes.TabIndex = 2;
            btnReportes.Text = "                 Reportes";
            btnReportes.TextAlign = ContentAlignment.MiddleLeft;
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += btnReportes_Click;
            // 
            // pnGastosIngresos
            // 
            pnGastosIngresos.Controls.Add(button3);
            pnGastosIngresos.Location = new Point(3, 171);
            pnGastosIngresos.Name = "pnGastosIngresos";
            pnGastosIngresos.Size = new Size(321, 66);
            pnGastosIngresos.TabIndex = 8;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkSlateGray;
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(-10, -9);
            button3.Name = "button3";
            button3.Padding = new Padding(25, 0, 0, 0);
            button3.Size = new Size(356, 86);
            button3.TabIndex = 2;
            button3.Text = "                 Gastos e Ingresos";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pnProgramarPagos
            // 
            pnProgramarPagos.Controls.Add(button4);
            pnProgramarPagos.Location = new Point(3, 243);
            pnProgramarPagos.Name = "pnProgramarPagos";
            pnProgramarPagos.Size = new Size(321, 66);
            pnProgramarPagos.TabIndex = 10;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkSlateGray;
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(-10, -9);
            button4.Name = "button4";
            button4.Padding = new Padding(25, 0, 0, 0);
            button4.Size = new Size(356, 86);
            button4.TabIndex = 2;
            button4.Text = "                 Programar Pagos";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // pnPlanificacion
            // 
            pnPlanificacion.Controls.Add(button8);
            pnPlanificacion.Location = new Point(3, 315);
            pnPlanificacion.Name = "pnPlanificacion";
            pnPlanificacion.Size = new Size(321, 66);
            pnPlanificacion.TabIndex = 11;
            // 
            // button8
            // 
            button8.BackColor = Color.DarkSlateGray;
            button8.ForeColor = Color.White;
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(-10, -9);
            button8.Name = "button8";
            button8.Padding = new Padding(25, 0, 0, 0);
            button8.Size = new Size(356, 86);
            button8.TabIndex = 2;
            button8.Text = "                 Planificacion";
            button8.TextAlign = ContentAlignment.MiddleLeft;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(button1);
            panel3.Location = new Point(3, 387);
            panel3.Name = "panel3";
            panel3.Size = new Size(321, 66);
            panel3.TabIndex = 12;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-10, -9);
            button1.Name = "button1";
            button1.Padding = new Padding(25, 0, 0, 0);
            button1.Size = new Size(356, 86);
            button1.TabIndex = 2;
            button1.Text = "                 Editar o Eliminar";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // pnSalir
            // 
            pnSalir.Controls.Add(button7);
            pnSalir.Location = new Point(3, 459);
            pnSalir.Name = "pnSalir";
            pnSalir.Size = new Size(321, 66);
            pnSalir.TabIndex = 9;
            // 
            // button7
            // 
            button7.BackColor = Color.DarkSlateGray;
            button7.ForeColor = Color.White;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(-10, -9);
            button7.Name = "button7";
            button7.Padding = new Padding(25, 0, 0, 0);
            button7.Size = new Size(356, 86);
            button7.TabIndex = 2;
            button7.Text = "                 Salir";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // menuTransition
            // 
            menuTransition.Interval = 10;
            menuTransition.Tick += menuTransition_Tick;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1240, 764);
            Controls.Add(sidebar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnHam).EndInit();
            sidebar.ResumeLayout(false);
            pnPresupuesto.ResumeLayout(false);
            menuContainer.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            pnGastosIngresos.ResumeLayout(false);
            pnProgramarPagos.ResumeLayout(false);
            pnPlanificacion.ResumeLayout(false);
            panel3.ResumeLayout(false);
            pnSalir.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox btnHam;
        private Label label1;
        private FlowLayoutPanel sidebar;
        private Panel pnPresupuesto;
        private Button button2;
        private FlowLayoutPanel menuContainer;
        private Panel panel2;
        private Button btnHistorial;
        private Panel panel5;
        private Button menu;
        private Button button5;
        private Panel panel6;
        private Button btnReportes;
        private Panel pnGastosIngresos;
        private Button button3;
        private Panel pnSalir;
        private Button button7;
        private System.Windows.Forms.Timer menuTransition;
        private Panel pnPlanificacion;
        private Button button8;
        private Panel pnProgramarPagos;
        private Button button4;
        private System.Windows.Forms.Timer sidebarTransition;
        private Panel panel3;
        private Button button1;
    }
}
