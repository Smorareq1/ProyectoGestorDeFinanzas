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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            definirRango = new Guna.UI2.WinForms.Guna2CircleButton();
            hastaFechaTxt = new Guna.UI2.WinForms.Guna2TextBox();
            desdeFechaTxt = new Guna.UI2.WinForms.Guna2TextBox();
            label4 = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart3).BeginInit();
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
            guna2CustomGradientPanel1.Location = new Point(229, 13);
            guna2CustomGradientPanel1.Margin = new Padding(3, 4, 3, 4);
            guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2CustomGradientPanel1.Size = new Size(722, 107);
            guna2CustomGradientPanel1.TabIndex = 0;
            guna2CustomGradientPanel1.Paint += guna2CustomGradientPanel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkSlateGray;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(17, 59);
            label2.Name = "label2";
            label2.Size = new Size(693, 21);
            label2.TabIndex = 1;
            label2.Text = "Se despliega informacion grafica del historial de transacciones atravez del tiempo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkSlateGray;
            label1.Font = new Font("Rockwell", 15.75F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(192, 15);
            label1.Name = "label1";
            label1.Size = new Size(337, 31);
            label1.TabIndex = 0;
            label1.Text = "Historial de Transacciones";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(50, 160);
            label3.Name = "label3";
            label3.Size = new Size(193, 23);
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
            definirRango.Location = new Point(1028, 160);
            definirRango.Margin = new Padding(3, 4, 3, 4);
            definirRango.Name = "definirRango";
            definirRango.ShadowDecoration.CustomizableEdges = customizableEdges3;
            definirRango.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            definirRango.Size = new Size(31, 33);
            definirRango.TabIndex = 12;
            definirRango.Click += definirRango_Click;
            // 
            // hastaFechaTxt
            // 
            hastaFechaTxt.Animated = true;
            hastaFechaTxt.AutoRoundedCorners = true;
            hastaFechaTxt.BorderRadius = 13;
            hastaFechaTxt.CustomizableEdges = customizableEdges4;
            hastaFechaTxt.DefaultText = "";
            hastaFechaTxt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            hastaFechaTxt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            hastaFechaTxt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            hastaFechaTxt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            hastaFechaTxt.FocusedState.BorderColor = Color.DarkSlateGray;
            hastaFechaTxt.Font = new Font("Segoe UI", 9F);
            hastaFechaTxt.HoverState.BorderColor = Color.DarkSlateGray;
            hastaFechaTxt.Location = new Point(661, 160);
            hastaFechaTxt.Margin = new Padding(3, 5, 3, 5);
            hastaFechaTxt.Name = "hastaFechaTxt";
            hastaFechaTxt.PasswordChar = '\0';
            hastaFechaTxt.PlaceholderText = "Hasta: dd/mm/yyyy";
            hastaFechaTxt.SelectedText = "";
            hastaFechaTxt.ShadowDecoration.CustomizableEdges = customizableEdges5;
            hastaFechaTxt.Size = new Size(229, 28);
            hastaFechaTxt.TabIndex = 15;
            // 
            // desdeFechaTxt
            // 
            desdeFechaTxt.Animated = true;
            desdeFechaTxt.AutoRoundedCorners = true;
            desdeFechaTxt.BorderRadius = 13;
            desdeFechaTxt.CustomizableEdges = customizableEdges6;
            desdeFechaTxt.DefaultText = "";
            desdeFechaTxt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            desdeFechaTxt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            desdeFechaTxt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            desdeFechaTxt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            desdeFechaTxt.FocusedState.BorderColor = Color.DarkSlateGray;
            desdeFechaTxt.Font = new Font("Segoe UI", 9F);
            desdeFechaTxt.HoverState.BorderColor = Color.DarkSlateGray;
            desdeFechaTxt.Location = new Point(310, 160);
            desdeFechaTxt.Margin = new Padding(3, 5, 3, 5);
            desdeFechaTxt.Name = "desdeFechaTxt";
            desdeFechaTxt.PasswordChar = '\0';
            desdeFechaTxt.PlaceholderText = "Desde: dd/mm/yyyy";
            desdeFechaTxt.SelectedText = "";
            desdeFechaTxt.ShadowDecoration.CustomizableEdges = customizableEdges7;
            desdeFechaTxt.Size = new Size(229, 28);
            desdeFechaTxt.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(592, 160);
            label4.Name = "label4";
            label4.Size = new Size(18, 23);
            label4.TabIndex = 17;
            label4.Text = "-";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            chart1.Location = new Point(50, 225);
            chart1.Margin = new Padding(3, 4, 3, 4);
            chart1.Name = "chart1";
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(1009, 302);
            chart1.TabIndex = 18;
            chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            chart2.ChartAreas.Add(chartArea2);
            legend1.Name = "Legend1";
            chart2.Legends.Add(legend1);
            chart2.Location = new Point(99, 556);
            chart2.Margin = new Padding(3, 4, 3, 4);
            chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart2.Series.Add(series2);
            chart2.Size = new Size(440, 269);
            chart2.TabIndex = 19;
            chart2.Text = "chart2";
            // 
            // chart3
            // 
            chartArea3.Name = "ChartArea1";
            chart3.ChartAreas.Add(chartArea3);
            legend2.Name = "Legend1";
            chart3.Legends.Add(legend2);
            chart3.Location = new Point(611, 556);
            chart3.Margin = new Padding(3, 4, 3, 4);
            chart3.Name = "chart3";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chart3.Series.Add(series3);
            chart3.Size = new Size(405, 269);
            chart3.TabIndex = 20;
            chart3.Text = "chart3";
            // 
            // historial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 849);
            Controls.Add(chart3);
            Controls.Add(chart2);
            Controls.Add(chart1);
            Controls.Add(label4);
            Controls.Add(desdeFechaTxt);
            Controls.Add(hastaFechaTxt);
            Controls.Add(definirRango);
            Controls.Add(label3);
            Controls.Add(guna2CustomGradientPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "historial";
            Text = "historial";
            Load += historial_Load;
            guna2CustomGradientPanel1.ResumeLayout(false);
            guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart2).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart3).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
    }
}