namespace ProyectoFinalEstructuras1
{
    partial class presupuesto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            label4 = new Label();
            presupuestoLabel = new Label();
            label6 = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            presupuestoTxt = new Guna.UI2.WinForms.Guna2TextBox();
            correoTxt = new Guna.UI2.WinForms.Guna2TextBox();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(271, 37);
            label1.Name = "label1";
            label1.Size = new Size(442, 23);
            label1.TabIndex = 0;
            label1.Text = "Editar la cantidad de presupuesto disponible";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell", 15.75F);
            label4.Location = new Point(59, 150);
            label4.Name = "label4";
            label4.Size = new Size(288, 23);
            label4.TabIndex = 5;
            label4.Text = "Balance Actual de la Cuenta: ";
            // 
            // presupuestoLabel
            // 
            presupuestoLabel.AutoSize = true;
            presupuestoLabel.Font = new Font("Rockwell", 15.75F);
            presupuestoLabel.Location = new Point(701, 136);
            presupuestoLabel.Name = "presupuestoLabel";
            presupuestoLabel.Size = new Size(80, 23);
            presupuestoLabel.TabIndex = 6;
            presupuestoLabel.Text = "#####";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Rockwell", 15.75F);
            label6.Location = new Point(674, 136);
            label6.Name = "label6";
            label6.Size = new Size(21, 23);
            label6.TabIndex = 7;
            label6.Text = "$";
            // 
            // guna2Button1
            // 
            guna2Button1.Animated = true;
            guna2Button1.AutoRoundedCorners = true;
            guna2Button1.BorderRadius = 28;
            guna2Button1.CustomizableEdges = customizableEdges9;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.DarkSlateGray;
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(580, 447);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2Button1.Size = new Size(180, 58);
            guna2Button1.TabIndex = 8;
            guna2Button1.Text = "Guardar Presupuesto";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // presupuestoTxt
            // 
            presupuestoTxt.CustomizableEdges = customizableEdges11;
            presupuestoTxt.DefaultText = "";
            presupuestoTxt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            presupuestoTxt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            presupuestoTxt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            presupuestoTxt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            presupuestoTxt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            presupuestoTxt.Font = new Font("Segoe UI", 9F);
            presupuestoTxt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            presupuestoTxt.Location = new Point(302, 237);
            presupuestoTxt.Name = "presupuestoTxt";
            presupuestoTxt.PasswordChar = '\0';
            presupuestoTxt.PlaceholderText = "Nuevo Presupuesto Ej: 0.00";
            presupuestoTxt.SelectedText = "";
            presupuestoTxt.ShadowDecoration.CustomizableEdges = customizableEdges12;
            presupuestoTxt.Size = new Size(380, 36);
            presupuestoTxt.TabIndex = 9;
            // 
            // correoTxt
            // 
            correoTxt.CustomizableEdges = customizableEdges13;
            correoTxt.DefaultText = "";
            correoTxt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            correoTxt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            correoTxt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            correoTxt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            correoTxt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            correoTxt.Font = new Font("Segoe UI", 9F);
            correoTxt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            correoTxt.Location = new Point(302, 306);
            correoTxt.Name = "correoTxt";
            correoTxt.PasswordChar = '\0';
            correoTxt.PlaceholderText = "Correo Ej: correo@ejemplo.com";
            correoTxt.SelectedText = "";
            correoTxt.ShadowDecoration.CustomizableEdges = customizableEdges14;
            correoTxt.Size = new Size(380, 36);
            correoTxt.TabIndex = 10;
            // 
            // guna2Button2
            // 
            guna2Button2.Animated = true;
            guna2Button2.AutoRoundedCorners = true;
            guna2Button2.BorderRadius = 28;
            guna2Button2.CustomizableEdges = customizableEdges15;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.DarkSlateGray;
            guna2Button2.Font = new Font("Segoe UI", 9F);
            guna2Button2.ForeColor = Color.White;
            guna2Button2.Location = new Point(250, 447);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges16;
            guna2Button2.Size = new Size(188, 58);
            guna2Button2.TabIndex = 11;
            guna2Button2.Text = "Gaurdar Correo";
            // 
            // presupuesto
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(965, 672);
            Controls.Add(guna2Button2);
            Controls.Add(correoTxt);
            Controls.Add(presupuestoTxt);
            Controls.Add(guna2Button1);
            Controls.Add(label6);
            Controls.Add(presupuestoLabel);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "presupuesto";
            Text = "presupuesto";
            Load += presupuesto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label4;
        private Label presupuestoLabel;
        private Label label6;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox presupuestoTxt;
        private Guna.UI2.WinForms.Guna2TextBox correoTxt;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}