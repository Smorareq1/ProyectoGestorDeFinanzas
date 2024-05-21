namespace ProyectoFinalEstructuras1
{
    partial class UserControlDays
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lbDays = new Label();
            lbEvent1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lbDays
            // 
            lbDays.AutoSize = true;
            lbDays.Font = new Font("Century Gothic", 7F);
            lbDays.Location = new Point(5, 5);
            lbDays.Name = "lbDays";
            lbDays.Size = new Size(19, 15);
            lbDays.TabIndex = 0;
            lbDays.Text = "00";
            // 
            // lbEvent1
            // 
            lbEvent1.AutoSize = true;
            lbEvent1.Font = new Font("Century Gothic", 7F);
            lbEvent1.Location = new Point(23, 20);
            lbEvent1.Name = "lbEvent1";
            lbEvent1.Size = new Size(0, 15);
            lbEvent1.TabIndex = 1;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // UserControlDays
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lbEvent1);
            Controls.Add(lbDays);
            Name = "UserControlDays";
            Size = new Size(128, 76);
            Load += UserControlDays_Load;
            Click += UserControlDays_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbDays;
        private Label lbEvent1;
        private System.Windows.Forms.Timer timer1;
    }
}
