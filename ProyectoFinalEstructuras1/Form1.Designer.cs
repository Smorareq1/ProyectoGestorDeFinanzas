﻿namespace ProyectoFinalEstructuras1
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
            panel3 = new Panel();
            button2 = new Button();
            menuContainer = new FlowLayoutPanel();
            panel5 = new Panel();
            menu = new Button();
            panel2 = new Panel();
            button5 = new Button();
            button1 = new Button();
            panel6 = new Panel();
            button6 = new Button();
            panel4 = new Panel();
            button3 = new Button();
            panel8 = new Panel();
            button4 = new Button();
            panel9 = new Panel();
            button8 = new Button();
            panel7 = new Panel();
            button7 = new Button();
            menuTransition = new System.Windows.Forms.Timer(components);
            sidebarTransition = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHam).BeginInit();
            sidebar.SuspendLayout();
            panel3.SuspendLayout();
            menuContainer.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel7.SuspendLayout();
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
            panel1.Size = new Size(927, 33);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 9);
            label1.Name = "label1";
            label1.Size = new Size(138, 17);
            label1.TabIndex = 1;
            label1.Text = "GESTOR DE FINANZAS";
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
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(menuContainer);
            sidebar.Controls.Add(panel4);
            sidebar.Controls.Add(panel8);
            sidebar.Controls.Add(panel9);
            sidebar.Controls.Add(panel7);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 33);
            sidebar.Name = "sidebar";
            sidebar.Padding = new Padding(0, 30, 0, 0);
            sidebar.Size = new Size(241, 667);
            sidebar.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(button2);
            panel3.Location = new Point(3, 33);
            panel3.Name = "panel3";
            panel3.Size = new Size(321, 66);
            panel3.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSlateGray;
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-10, -9);
            button2.Name = "button2";
            button2.Padding = new Padding(25, 0, 0, 0);
            button2.Size = new Size(356, 86);
            button2.TabIndex = 2;
            button2.Text = "                 Editar Presupuesto";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
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
            panel2.Controls.Add(button1);
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
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-10, -9);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Padding = new Padding(25, 0, 0, 0);
            button1.Size = new Size(356, 86);
            button1.TabIndex = 2;
            button1.Text = "                 Historial";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.Controls.Add(button6);
            panel6.Location = new Point(3, 147);
            panel6.Name = "panel6";
            panel6.Size = new Size(321, 66);
            panel6.TabIndex = 9;
            // 
            // button6
            // 
            button6.BackColor = Color.DarkSlateGray;
            button6.ForeColor = Color.White;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(-10, -9);
            button6.Margin = new Padding(0);
            button6.Name = "button6";
            button6.Padding = new Padding(25, 0, 0, 0);
            button6.Size = new Size(356, 86);
            button6.TabIndex = 2;
            button6.Text = "                 Reportes";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(button3);
            panel4.Location = new Point(3, 171);
            panel4.Name = "panel4";
            panel4.Size = new Size(321, 66);
            panel4.TabIndex = 8;
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
            // 
            // panel8
            // 
            panel8.Controls.Add(button4);
            panel8.Location = new Point(3, 243);
            panel8.Name = "panel8";
            panel8.Size = new Size(321, 66);
            panel8.TabIndex = 10;
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
            // 
            // panel9
            // 
            panel9.Controls.Add(button8);
            panel9.Location = new Point(3, 315);
            panel9.Name = "panel9";
            panel9.Size = new Size(321, 66);
            panel9.TabIndex = 11;
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
            // 
            // panel7
            // 
            panel7.Controls.Add(button7);
            panel7.Location = new Point(3, 387);
            panel7.Name = "panel7";
            panel7.Size = new Size(321, 66);
            panel7.TabIndex = 9;
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
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 700);
            Controls.Add(sidebar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnHam).EndInit();
            sidebar.ResumeLayout(false);
            panel3.ResumeLayout(false);
            menuContainer.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox btnHam;
        private Label label1;
        private FlowLayoutPanel sidebar;
        private Panel panel3;
        private Button button2;
        private FlowLayoutPanel menuContainer;
        private Panel panel2;
        private Button button1;
        private Panel panel5;
        private Button menu;
        private Button button5;
        private Panel panel6;
        private Button button6;
        private Panel panel4;
        private Button button3;
        private Panel panel7;
        private Button button7;
        private System.Windows.Forms.Timer menuTransition;
        private Panel panel9;
        private Button button8;
        private Panel panel8;
        private Button button4;
        private System.Windows.Forms.Timer sidebarTransition;
    }
}
