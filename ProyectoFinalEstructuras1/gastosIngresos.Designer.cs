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
            presupuestoLabel = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            nombretxt = new TextBox();
            categoriatxt = new TextBox();
            montotxt = new TextBox();
            fechatxt = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 15.75F);
            label1.Location = new Point(344, 21);
            label1.Name = "label1";
            label1.Size = new Size(367, 31);
            label1.TabIndex = 0;
            label1.Text = "Registro de Gatos e Ingresos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 15.75F);
            label2.Location = new Point(55, 99);
            label2.Name = "label2";
            label2.Size = new Size(259, 31);
            label2.TabIndex = 1;
            label2.Text = "Presupuesto actual: ";
            // 
            // presupuestoLabel
            // 
            presupuestoLabel.AutoSize = true;
            presupuestoLabel.Font = new Font("Rockwell", 15.75F);
            presupuestoLabel.Location = new Point(603, 99);
            presupuestoLabel.Name = "presupuestoLabel";
            presupuestoLabel.Size = new Size(91, 31);
            presupuestoLabel.TabIndex = 2;
            presupuestoLabel.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell", 13F);
            label4.Location = new Point(55, 177);
            label4.Name = "label4";
            label4.Size = new Size(108, 25);
            label4.TabIndex = 3;
            label4.Text = "Nombre: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Rockwell", 13F);
            label5.Location = new Point(55, 249);
            label5.Name = "label5";
            label5.Size = new Size(127, 25);
            label5.TabIndex = 4;
            label5.Text = "Categoria: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Rockwell", 13F);
            label6.Location = new Point(602, 177);
            label6.Name = "label6";
            label6.Size = new Size(89, 25);
            label6.TabIndex = 5;
            label6.Text = "Monto: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Rockwell", 13F);
            label7.Location = new Point(479, 249);
            label7.Name = "label7";
            label7.Size = new Size(241, 25);
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
            categoriatxt.Size = new Size(217, 27);
            categoriatxt.TabIndex = 8;
            // 
            // montotxt
            // 
            montotxt.Location = new Point(715, 178);
            montotxt.Name = "montotxt";
            montotxt.Size = new Size(131, 27);
            montotxt.TabIndex = 9;
            // 
            // fechatxt
            // 
            fechatxt.Location = new Point(715, 250);
            fechatxt.Name = "fechatxt";
            fechatxt.Size = new Size(131, 27);
            fechatxt.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(410, 328);
            button1.Name = "button1";
            button1.Size = new Size(144, 50);
            button1.TabIndex = 11;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(55, 431);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(791, 229);
            dataGridView1.TabIndex = 12;
            // 
            // gastosIngresos
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(965, 672);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(fechatxt);
            Controls.Add(montotxt);
            Controls.Add(categoriatxt);
            Controls.Add(nombretxt);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(presupuestoLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "gastosIngresos";
            Text = "gastosIngresos";
            Load += gastosIngresos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox nombretxt;
        private TextBox categoriatxt;
        private TextBox montotxt;
        private TextBox fechatxt;
        private Button button1;
        private DataGridView dataGridView1;
        public static Label presupuestoLabel;
    }
}