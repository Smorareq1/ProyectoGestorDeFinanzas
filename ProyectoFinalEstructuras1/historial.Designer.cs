namespace ProyectoFinalEstructuras1
{
    partial class historial
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(historial));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            definirRango = new Guna.UI2.WinForms.Guna2CircleButton();
            hastaFechaTxt = new Guna.UI2.WinForms.Guna2TextBox();
            desdeFechaTxt = new Guna.UI2.WinForms.Guna2TextBox();
            label4 = new Label();
            guna2CustomGradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            guna2CustomGradientPanel1.BorderRadius = 20;
            guna2CustomGradientPanel1.Controls.Add(label2);
            guna2CustomGradientPanel1.Controls.Add(label1);
            guna2CustomGradientPanel1.CustomizableEdges = customizableEdges1;
            guna2CustomGradientPanel1.FillColor = Color.DarkSlateGray;
            guna2CustomGradientPanel1.FillColor2 = Color.DarkSlateGray;
            guna2CustomGradientPanel1.FillColor3 = Color.DarkSlateGray;
            guna2CustomGradientPanel1.FillColor4 = Color.DarkSlateGray;
            guna2CustomGradientPanel1.Location = new Point(203, 23);
            guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2CustomGradientPanel1.Size = new Size(575, 80);
            guna2CustomGradientPanel1.TabIndex = 0;
            guna2CustomGradientPanel1.Paint += guna2CustomGradientPanel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkSlateGray;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(21, 46);
            label2.Name = "label2";
            label2.Size = new Size(540, 17);
            label2.TabIndex = 1;
            label2.Text = "Se despliega informacion grafica del historial de transacciones atravez del tiempo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkSlateGray;
            label1.Font = new Font("Rockwell", 15.75F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(172, 11);
            label1.Name = "label1";
            label1.Size = new Size(265, 23);
            label1.TabIndex = 0;
            label1.Text = "Historial de Transacciones";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(44, 120);
            label3.Name = "label3";
            label3.Size = new Size(153, 21);
            label3.TabIndex = 1;
            label3.Text = "Seleccione rango: ";
            // 
            // definirRango
            // 
            definirRango.Animated = true;
            definirRango.BackgroundImage = (Image)resources.GetObject("definirRango.BackgroundImage");
            definirRango.DisabledState.BorderColor = Color.DarkGray;
            definirRango.DisabledState.CustomBorderColor = Color.DarkGray;
            definirRango.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            definirRango.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            definirRango.FillColor = Color.Transparent;
            definirRango.Font = new Font("Segoe UI", 9F);
            definirRango.ForeColor = Color.White;
            definirRango.Location = new Point(837, 120);
            definirRango.Name = "definirRango";
            definirRango.ShadowDecoration.CustomizableEdges = customizableEdges3;
            definirRango.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            definirRango.Size = new Size(27, 29);
            definirRango.TabIndex = 12;
            definirRango.Click += definirRango_Click;
            // 
            // hastaFechaTxt
            // 
            hastaFechaTxt.CustomizableEdges = customizableEdges4;
            hastaFechaTxt.DefaultText = "";
            hastaFechaTxt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            hastaFechaTxt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            hastaFechaTxt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            hastaFechaTxt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            hastaFechaTxt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            hastaFechaTxt.Font = new Font("Segoe UI", 9F);
            hastaFechaTxt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            hastaFechaTxt.Location = new Point(578, 120);
            hastaFechaTxt.Name = "hastaFechaTxt";
            hastaFechaTxt.PasswordChar = '\0';
            hastaFechaTxt.PlaceholderText = "Hasta: dd/mm/yyyy";
            hastaFechaTxt.SelectedText = "";
            hastaFechaTxt.ShadowDecoration.CustomizableEdges = customizableEdges5;
            hastaFechaTxt.Size = new Size(200, 21);
            hastaFechaTxt.TabIndex = 15;
            // 
            // desdeFechaTxt
            // 
            desdeFechaTxt.CustomizableEdges = customizableEdges6;
            desdeFechaTxt.DefaultText = "";
            desdeFechaTxt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            desdeFechaTxt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            desdeFechaTxt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            desdeFechaTxt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            desdeFechaTxt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            desdeFechaTxt.Font = new Font("Segoe UI", 9F);
            desdeFechaTxt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            desdeFechaTxt.Location = new Point(271, 120);
            desdeFechaTxt.Name = "desdeFechaTxt";
            desdeFechaTxt.PasswordChar = '\0';
            desdeFechaTxt.PlaceholderText = "Desde: dd/mm/yyyy";
            desdeFechaTxt.SelectedText = "";
            desdeFechaTxt.ShadowDecoration.CustomizableEdges = customizableEdges7;
            desdeFechaTxt.Size = new Size(200, 21);
            desdeFechaTxt.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(515, 120);
            label4.Name = "label4";
            label4.Size = new Size(16, 19);
            label4.TabIndex = 17;
            label4.Text = "-";
            // 
            // historial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 672);
            Controls.Add(label4);
            Controls.Add(desdeFechaTxt);
            Controls.Add(hastaFechaTxt);
            Controls.Add(definirRango);
            Controls.Add(label3);
            Controls.Add(guna2CustomGradientPanel1);
            Name = "historial";
            Text = "historial";
            Load += historial_Load;
            guna2CustomGradientPanel1.ResumeLayout(false);
            guna2CustomGradientPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Guna.UI2.WinForms.Guna2CircleButton definirRango;
        private Guna.UI2.WinForms.Guna2TextBox hastaFechaTxt;
        private Guna.UI2.WinForms.Guna2TextBox desdeFechaTxt;
        private Label label4;
    }
}