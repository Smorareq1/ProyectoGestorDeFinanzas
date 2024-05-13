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
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            presupuestoLabel = new Label();
            label6 = new Label();
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
            // textBox1
            // 
            textBox1.Location = new Point(650, 329);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(157, 52);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(389, 467);
            button1.Name = "button1";
            button1.Size = new Size(181, 58);
            button1.TabIndex = 2;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 15.75F);
            label2.Location = new Point(59, 326);
            label2.Name = "label2";
            label2.Size = new Size(263, 23);
            label2.TabIndex = 3;
            label2.Text = "Ingrese la cantidad nueva ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 15.75F);
            label3.Location = new Point(112, 349);
            label3.Name = "label3";
            label3.Size = new Size(172, 23);
            label3.TabIndex = 4;
            label3.Text = "de presupuesto: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell", 15.75F);
            label4.Location = new Point(59, 187);
            label4.Name = "label4";
            label4.Size = new Size(288, 23);
            label4.TabIndex = 5;
            label4.Text = "Balance Actual de la Cuenta: ";
            // 
            // presupuestoLabel
            // 
            presupuestoLabel.AutoSize = true;
            presupuestoLabel.Font = new Font("Rockwell", 15.75F);
            presupuestoLabel.Location = new Point(700, 187);
            presupuestoLabel.Name = "presupuestoLabel";
            presupuestoLabel.Size = new Size(80, 23);
            presupuestoLabel.TabIndex = 6;
            presupuestoLabel.Text = "#####";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Rockwell", 15.75F);
            label6.Location = new Point(673, 187);
            label6.Name = "label6";
            label6.Size = new Size(21, 23);
            label6.TabIndex = 7;
            label6.Text = "$";
            // 
            // presupuesto
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(965, 672);
            Controls.Add(label6);
            Controls.Add(presupuestoLabel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "presupuesto";
            Text = "presupuesto";
            Load += presupuesto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label presupuestoLabel;
        private Label label6;
    }
}