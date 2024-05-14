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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            montotxt = new TextBox();
            nombretxt = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            fechatxt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(45, 455);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(857, 273);
            dataGridView1.TabIndex = 25;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(388, 357);
            button1.Name = "button1";
            button1.Size = new Size(144, 50);
            button1.TabIndex = 24;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // montotxt
            // 
            montotxt.Location = new Point(45, 298);
            montotxt.Name = "montotxt";
            montotxt.Size = new Size(337, 27);
            montotxt.TabIndex = 21;
            montotxt.TextChanged += montotxt_TextChanged;
            // 
            // nombretxt
            // 
            nombretxt.Location = new Point(45, 220);
            nombretxt.Multiline = true;
            nombretxt.Name = "nombretxt";
            nombretxt.Size = new Size(337, 27);
            nombretxt.TabIndex = 20;
            nombretxt.TextChanged += nombretxt_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Rockwell", 13F);
            label7.Location = new Point(462, 267);
            label7.Name = "label7";
            label7.Size = new Size(440, 25);
            label7.TabIndex = 19;
            label7.Text = "Fecha a alzancar objetivo (dd/mm/yyyy): ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Rockwell", 13F);
            label6.Location = new Point(462, 186);
            label6.Name = "label6";
            label6.Size = new Size(154, 25);
            label6.TabIndex = 18;
            label6.Text = "Tipo de meta:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Rockwell", 13F);
            label5.Location = new Point(45, 267);
            label5.Name = "label5";
            label5.Size = new Size(287, 25);
            label5.TabIndex = 17;
            label5.Text = "Monto objetivo de la meta:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell", 13F);
            label4.Location = new Point(45, 186);
            label4.Name = "label4";
            label4.Size = new Size(299, 25);
            label4.TabIndex = 16;
            label4.Text = "Nombre de meta financiera:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 15.75F);
            label2.Location = new Point(45, 117);
            label2.Name = "label2";
            label2.Size = new Size(356, 31);
            label2.TabIndex = 14;
            label2.Text = "Informacion para crear plan";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 15.75F);
            label1.Location = new Point(310, 42);
            label1.Name = "label1";
            label1.Size = new Size(306, 31);
            label1.TabIndex = 13;
            label1.Text = "Planificación Financiera";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(462, 220);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(337, 28);
            comboBox1.TabIndex = 26;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // fechatxt
            // 
            fechatxt.Location = new Point(462, 298);
            fechatxt.Name = "fechatxt";
            fechatxt.Size = new Size(337, 27);
            fechatxt.TabIndex = 23;
            fechatxt.TextChanged += fechatxt_TextChanged;
            // 
            // planificacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 896);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(fechatxt);
            Controls.Add(montotxt);
            Controls.Add(nombretxt);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
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
        private TextBox montotxt;
        private TextBox nombretxt;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private TextBox fechatxt;
    }
}