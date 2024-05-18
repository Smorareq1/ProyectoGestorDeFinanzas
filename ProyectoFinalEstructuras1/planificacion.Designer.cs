namespace ProyectoFinalEstructuras1
{
    partial class planificacion
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            nombretxt = new Guna.UI2.WinForms.Guna2TextBox();
            montotxt = new Guna.UI2.WinForms.Guna2TextBox();
            comboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            fechatxt = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(39, 396);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(750, 205);
            dataGridView1.TabIndex = 25;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(355, 312);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(126, 38);
            button1.TabIndex = 24;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 15.75F);
            label2.Location = new Point(39, 83);
            label2.Name = "label2";
            label2.Size = new Size(279, 23);
            label2.TabIndex = 14;
            label2.Text = "Informacion para crear plan";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 15.75F);
            label1.Location = new Point(308, 19);
            label1.Name = "label1";
            label1.Size = new Size(239, 23);
            label1.TabIndex = 13;
            label1.Text = "Planificación Financiera";
            // 
            // nombretxt
            // 
            nombretxt.CustomizableEdges = customizableEdges1;
            nombretxt.DefaultText = "";
            nombretxt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            nombretxt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            nombretxt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            nombretxt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            nombretxt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            nombretxt.Font = new Font("Segoe UI", 9F);
            nombretxt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            nombretxt.Location = new Point(39, 182);
            nombretxt.Name = "nombretxt";
            nombretxt.PasswordChar = '\0';
            nombretxt.PlaceholderText = "Nombre de la meta financiera";
            nombretxt.SelectedText = "";
            nombretxt.ShadowDecoration.CustomizableEdges = customizableEdges2;
            nombretxt.Size = new Size(295, 23);
            nombretxt.TabIndex = 27;
            // 
            // montotxt
            // 
            montotxt.CustomizableEdges = customizableEdges3;
            montotxt.DefaultText = "";
            montotxt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            montotxt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            montotxt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            montotxt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            montotxt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            montotxt.Font = new Font("Segoe UI", 9F);
            montotxt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            montotxt.Location = new Point(39, 241);
            montotxt.Name = "montotxt";
            montotxt.PasswordChar = '\0';
            montotxt.PlaceholderText = "Monto objetivo";
            montotxt.SelectedText = "";
            montotxt.ShadowDecoration.CustomizableEdges = customizableEdges4;
            montotxt.Size = new Size(295, 23);
            montotxt.TabIndex = 28;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.Transparent;
            comboBox1.CustomizableEdges = customizableEdges5;
            comboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FocusedColor = Color.FromArgb(94, 148, 255);
            comboBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            comboBox1.Font = new Font("Segoe UI", 10F);
            comboBox1.ForeColor = Color.FromArgb(68, 88, 112);
            comboBox1.ItemHeight = 20;
            comboBox1.Location = new Point(494, 179);
            comboBox1.Name = "comboBox1";
            comboBox1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            comboBox1.Size = new Size(295, 26);
            comboBox1.TabIndex = 23;
            // 
            // fechatxt
            // 
            fechatxt.CustomizableEdges = customizableEdges7;
            fechatxt.DefaultText = "";
            fechatxt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            fechatxt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            fechatxt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            fechatxt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            fechatxt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            fechatxt.Font = new Font("Segoe UI", 9F);
            fechatxt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            fechatxt.Location = new Point(494, 241);
            fechatxt.Name = "fechatxt";
            fechatxt.PasswordChar = '\0';
            fechatxt.PlaceholderText = "Fecha a cumplir Ej: dd/mm/yyyy";
            fechatxt.SelectedText = "";
            fechatxt.ShadowDecoration.CustomizableEdges = customizableEdges8;
            fechatxt.Size = new Size(295, 23);
            fechatxt.TabIndex = 30;
            // 
            // planificacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 672);
            Controls.Add(fechatxt);
            Controls.Add(comboBox1);
            Controls.Add(montotxt);
            Controls.Add(nombretxt);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "planificacion";
            Text = "planificacion";
            Load += planificacion_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox montotxt;
        private Guna.UI2.WinForms.Guna2TextBox nombretxt;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox1;
        private Guna.UI2.WinForms.Guna2TextBox fechatxt;
    }
}