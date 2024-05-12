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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(277, 248);
            label1.Name = "label1";
            label1.Size = new Size(99, 30);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // presupuesto
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(661, 616);
            Controls.Add(label1);
            Name = "presupuesto";
            Text = "presupuesto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}