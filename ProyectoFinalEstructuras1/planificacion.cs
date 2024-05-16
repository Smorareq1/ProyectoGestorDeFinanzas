﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalEstructuras1
{  
    public partial class planificacion : Form
    {

        public class FinancialGoal
        {
            public string Name { get; set; }
            public decimal TargetAmount { get; set; }
            public string GoalType { get; set; }
            public DateTime TargetDate { get; set; }
        }

        public planificacion()
        {
            InitializeComponent();
        }

        private Dictionary<string, List<string>> SpecificRecommendations = new Dictionary<string, List<string>>
        {
            {"Ahorro", new List<string>
        {
            "Establece un presupuesto mensual detallado y sigue un plan de gastos disciplinado.",
            "Automatiza tus ahorros mediante transferencias automáticas a una cuenta de ahorros separada.",
            "Considera abrir una cuenta de ahorro de alto rendimiento para maximizar tus ganancias.",
            "Revisa tus suscripciones y membresías recurrentes para eliminar aquellas que no sean esenciales.",
            "Busca oportunidades de ingresos adicionales, como trabajos freelance o ventas en línea, para aumentar tu capacidad de ahorro.",
            "Haz una lista de tus objetivos de ahorro a corto, mediano y largo plazo para mantener el enfoque y la motivación.",
            "Prioriza tus gastos según su importancia y elimina los gastos superfluos para aumentar tus ahorros.",
            "Evita las compras impulsivas y toma decisiones de compra informadas después de comparar precios y evaluar necesidades versus deseos.",
            "Revisa tus facturas mensuales, como servicios públicos y suscripciones, para identificar áreas de ahorro potencial.",
            "Establece un fondo de emergencia con suficiente dinero para cubrir al menos tres a seis meses de gastos fijos."
        }
            },
            {"Inversión", new List<string>
        {
            "Diversifica tu cartera de inversiones para reducir el riesgo y maximizar el potencial de retorno.",
            "Considera la posibilidad de invertir en acciones de empresas sólidas con historiales de crecimiento estable.",
            "Investiga sobre inversiones alternativas, como bienes raíces o materias primas, para diversificar aún más tu cartera.",
            "Mantén un horizonte de inversión a largo plazo y evita tomar decisiones basadas en las fluctuaciones del mercado a corto plazo.",
            "Consulta a un asesor financiero certificado para obtener orientación personalizada sobre estrategias de inversión.",
            "Revisa regularmente el rendimiento de tu cartera de inversiones y ajusta tu estrategia según sea necesario.",
            "Considera la posibilidad de reinvertir los dividendos generados por tus inversiones para aumentar tu patrimonio a largo plazo.",
            "Participa en programas de inversión educativa para mejorar tus habilidades y conocimientos en el mercado financiero.",
            "Mantén un enfoque disciplinado y evita las emociones al tomar decisiones de inversión, basándote en la lógica y el análisis.",
            "Haz un seguimiento de los eventos económicos y geopolíticos que puedan afectar los mercados financieros globales y ajusta tu estrategia en consecuencia."
        }
            },
            {"Gasto Planeado", new List<string>
        {
            "Crea un presupuesto detallado que incluya todos tus gastos mensuales, y revisa regularmente tu progreso para asegurarte de que estás en camino.",
            "Prioriza tus gastos según tus necesidades básicas y objetivos financieros a largo plazo.",
            "Utiliza herramientas de seguimiento de gastos para identificar áreas donde puedes reducir o eliminar gastos innecesarios.",
            "Evita las compras impulsivas y toma decisiones de compra informadas después de evaluar cuidadosamente tus necesidades y prioridades.",
            "Considera la posibilidad de utilizar cupones, ofertas y descuentos para maximizar el valor de tus compras y reducir los costos.",
            "Planifica tus compras importantes con anticipación y busca las mejores ofertas disponibles antes de realizar una compra.",
            "Busca formas de reducir tus gastos de ocio y entretenimiento sin sacrificar la calidad de vida.",
            "Evita acumular deudas innecesarias y busca pagar tus deudas existentes de manera sistemática para evitar cargos por intereses.",
            "Establece límites de gasto mensuales para categorías específicas, como comida fuera de casa o entretenimiento, y adhiérete a ellos.",
            "Revisa periódicamente tu presupuesto y ajusta tus gastos según sea necesario para mantener un equilibrio financiero saludable."
        }
            }
        };

        private string GetRandomRecommendation(List<string> sourceList)
        {
            Random random = new Random();
            int index = random.Next(sourceList.Count);
            return sourceList[index];
        }

        private List<string> GenerateRecommendations(FinancialGoal goal)
        {
            List<string> recommendations = new List<string>();

            if (SpecificRecommendations.ContainsKey(goal.GoalType))
            {
                recommendations.Add(GetRandomRecommendation(SpecificRecommendations[goal.GoalType]));
            }

            int months = ((goal.TargetDate.Year - DateTime.Now.Year) * 12) + goal.TargetDate.Month - DateTime.Now.Month;
            decimal monthlySavings = goal.TargetAmount / Math.Max(months, 1);

            recommendations.Add($"Deberás ahorrar una cantidad aproximada de {monthlySavings:C} por mes para alcanzar tu meta en el tiempo previsto.");
            if (months <= 6)
            {
                recommendations.Add($"Deberás esforzarte para alcanzar tu meta en tan poco tiempo.");
            }
            else if (months <= 12)
            {
                recommendations.Add($"Haz un esfuerzo adicional para aumentar tus ahorros mensuales, ya que el tiempo es limitado.");
            }
            else
            {
                recommendations.Add($"Tienes suficiente tiempo para alcanzar tu meta, pero sigue siendo importante ahorrar de manera constante.");
            }

            return recommendations;
        }



        private void nombretxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void planificacion_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Name", "Nombre de la Meta");
            dataGridView1.Columns.Add("Amount", "Monto Objetivo");
            dataGridView1.Columns.Add("Type", "Tipo de Meta");
            dataGridView1.Columns.Add("Date", "Fecha Objetivo");

            comboBox1.Items.Add("Inversión");
            comboBox1.Items.Add("Ahorro");
            comboBox1.Items.Add("Gasto Planeado");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nombretxt.Text) ||
                string.IsNullOrWhiteSpace(montotxt.Text) ||
                comboBox1.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(fechatxt.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(montotxt.Text, out decimal targetAmount))
            {
                MessageBox.Show("Ingrese un monto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!DateTime.TryParseExact(fechatxt.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime targetDate))
            {
                MessageBox.Show("Por favor, ingrese una fecha en formato dd/MM/yyyy.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FinancialGoal newGoal = new FinancialGoal()
            {
                Name = nombretxt.Text,
                TargetAmount = targetAmount,
                GoalType = comboBox1.SelectedItem.ToString(),
                TargetDate = targetDate
            };

            int index = dataGridView1.Rows.Add();
            dataGridView1.Rows[index].Cells["Name"].Value = newGoal.Name;
            dataGridView1.Rows[index].Cells["Amount"].Value = newGoal.TargetAmount;
            dataGridView1.Rows[index].Cells["Type"].Value = newGoal.GoalType;
            dataGridView1.Rows[index].Cells["Date"].Value = newGoal.TargetDate.ToShortDateString();

            List<string> advice = GenerateRecommendations(newGoal);
            StringBuilder message = new StringBuilder();
            message.AppendLine("Recomendaciones para alcanzar tu meta:");
            foreach (string recommendation in advice)
            {
                message.AppendLine("- " + recommendation);
            }

            MessageBox.Show(message.ToString(), "Recomendaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void montotxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fechatxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
