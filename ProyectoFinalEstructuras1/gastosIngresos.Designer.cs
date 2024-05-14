namespace ProyectoFinalEstructuras1
{
    partial class gastosIngresos
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            nombretxt = new TextBox();
            categoriatxt = new TextBox();
            montotxt = new TextBox();
            fechatxt = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 15.75F);
            label1.Location = new Point(344, 21);
            label1.Name = "label1";
            label1.Size = new Size(289, 23);
            label1.TabIndex = 0;
            label1.Text = "Registro de Gatos e Ingresos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 15.75F);
            label2.Location = new Point(55, 99);
            label2.Name = "label2";
            label2.Size = new Size(203, 23);
            label2.TabIndex = 1;
            label2.Text = "Presupuesto actual: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 15.75F);
            label3.Location = new Point(603, 99);
            label3.Name = "label3";
            label3.Size = new Size(69, 23);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell", 13F);
            label4.Location = new Point(55, 177);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 3;
            label4.Text = "Nombre: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Rockwell", 13F);
            label5.Location = new Point(55, 249);
            label5.Name = "label5";
            label5.Size = new Size(102, 20);
            label5.TabIndex = 4;
            label5.Text = "Categoria: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Rockwell", 13F);
            label6.Location = new Point(602, 177);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 5;
            label6.Text = "Monto: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Rockwell", 13F);
            label7.Location = new Point(479, 249);
            label7.Name = "label7";
            label7.Size = new Size(197, 20);
            label7.TabIndex = 6;
            label7.Text = "Fecha (dd/mm/yyyy): ";
            // 
            // nombretxt
            // 
            nombretxt.Location = new Point(215, 178);
            nombretxt.Multiline = true;
            nombretxt.Name = "nombretxt";
            nombretxt.Size = new Size(217, 40);
            nombretxt.TabIndex = 7;
            // 
            // categoriatxt
            // 
            categoriatxt.Location = new Point(215, 250);
            categoriatxt.Name = "categoriatxt";
            categoriatxt.Size = new Size(217, 23);
            categoriatxt.TabIndex = 8;
            // 
            // montotxt
            // 
            montotxt.Location = new Point(715, 178);
            montotxt.Name = "montotxt";
            montotxt.Size = new Size(131, 23);
            montotxt.TabIndex = 9;
            // 
            // fechatxt
            // 
            fechatxt.Location = new Point(715, 250);
            fechatxt.Name = "fechatxt";
            fechatxt.Size = new Size(131, 23);
            fechatxt.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(424, 331);
            button1.Name = "button1";
            button1.Size = new Size(122, 23);
            button1.TabIndex = 11;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // gastosIngresos
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(965, 672);
            Controls.Add(button1);
            Controls.Add(fechatxt);
            Controls.Add(montotxt);
            Controls.Add(categoriatxt);
            Controls.Add(nombretxt);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "gastosIngresos";
            Text = "gastosIngresos";
            Load += gastosIngresos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox nombretxt;
        private TextBox categoriatxt;
        private TextBox montotxt;
        private TextBox fechatxt;
        private Button button1;
    }
}