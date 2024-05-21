using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalEstructuras1
{
    public partial class programarPagos : Form
    {
        int mes, anio;

        //Variables estaticas para pasar de forms a forms
        public static int mesEstatico, anioEstatico;

        public programarPagos()
        {
            InitializeComponent();
        }

        private void programarPagos_Load(object sender, EventArgs e)
        {
            mostrarDias();
        }

        private void mostrarDias()
        {
            DateTime now = DateTime.Now;
            mes = now.Month;
            anio = now.Year;


            String mesNombre = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(mes);
            //Hacer mayuscula la primera letra
            mesNombre = char.ToUpper(mesNombre[0]) + mesNombre.Substring(1);
            dateLabel.Text = mesNombre + " " + anio;


            //Dar valor a las variables estaticas
            mesEstatico = mes;
            anioEstatico = anio;

            //Inicio de mes
            DateTime inicioMes = new DateTime(anio, mes, 1);


            //Dias del mes
            int diasMes = DateTime.DaysInMonth(anio, mes);

            //Convertir el inicio de mes a int
            int diaDeLaSemana = Convert.ToInt32(inicioMes.DayOfWeek.ToString("d")) + 1;

            //Blank control
            for (int i = 1; i < diaDeLaSemana; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                dayContainer.Controls.Add(ucblank);
            }

            //Days control
            for (int i = 1; i <= diasMes; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.Dias(i);
                dayContainer.Controls.Add(ucDays);
                ucDays.mostrarEvento();
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            //Limpiar controles
            dayContainer.Controls.Clear();

            if (mes == 1)
            {
                mes = 12;
                anio--;
            }
            else
            {
                mes--;
            }


            String mesNombre = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(mes);
            //Hacer mayuscula la primera letra
            mesNombre = char.ToUpper(mesNombre[0]) + mesNombre.Substring(1);
            dateLabel.Text = mesNombre + " " + anio;

            //Dar valor a las variables estaticas
            mesEstatico = mes;
            anioEstatico = anio;

            //Inicio de mes
            DateTime inicioMes = new DateTime(anio, mes, 1);

            //Dias del mes
            int diasMes = DateTime.DaysInMonth(anio, mes);

            //Convertir el inicio de mes a int
            int diaDeLaSemana = Convert.ToInt32(inicioMes.DayOfWeek.ToString("d")) + 1;

            //Blank control
            for (int i = 1; i < diaDeLaSemana; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                dayContainer.Controls.Add(ucblank);
            }

            //Days control
            for (int i = 1; i <= diasMes; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.Dias(i);
                dayContainer.Controls.Add(ucDays);
                ucDays.mostrarEvento();
            }


        }

        private void btnSiguiente_Click_1(object sender, EventArgs e)
        {
            //Limpiar controles
            dayContainer.Controls.Clear();


            if (mes == 12)
            {
                mes = 1;
                anio++;
            }
            else
            {
                mes++;
            }


            String mesNombre = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(mes);
            //Hacer mayuscula la primera letra
            mesNombre = char.ToUpper(mesNombre[0]) + mesNombre.Substring(1);
            dateLabel.Text = mesNombre + " " + anio;


            //Dar valor a las variables estaticas
            mesEstatico = mes;
            anioEstatico = anio;

            //Inicio de mes
            DateTime inicioMes = new DateTime(anio, mes, 1);

            //Dias del mes
            int diasMes = DateTime.DaysInMonth(anio, mes);

            //Convertir el inicio de mes a int
            int diaDeLaSemana = Convert.ToInt32(inicioMes.DayOfWeek.ToString("d")) + 1;

            //Blank control
            for (int i = 1; i < diaDeLaSemana; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                dayContainer.Controls.Add(ucblank);
            }

            //Days control
            for (int i = 1; i <= diasMes; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.Dias(i);
                dayContainer.Controls.Add(ucDays);
                ucDays.mostrarEvento();

            }
        }

        private void mandarMensajeBtn_Click(object sender, EventArgs e)
        {
            // Obtener el rango del mes actual
            DateTime inicioMes = new DateTime(anioEstatico, mesEstatico, 1);
            DateTime finMes = inicioMes.AddMonths(1).AddDays(-1);

            // Filtrar las transacciones programadas para el mes actual
            var eventosDelMes = Transacciones.transaccionesProgramadas
                .Where(evento =>
                    (evento.Fecha >= inicioMes && evento.Fecha <= finMes) ||
                    (evento.RepetirMensualmente &&
                     evento.Fecha.Day >= 1 && evento.Fecha.Day <= DateTime.DaysInMonth(anioEstatico, mesEstatico)))
                .ToList();

            // Filtrar las transacciones repetidas mensualmente para ajustarlas al mes actual
            var eventosRepetidosMensualmente = eventosDelMes
                .Where(evento => evento.RepetirMensualmente)
                .Select(evento => new TransaccionProgramada(evento.Nombre, evento.Monto, new DateTime(anioEstatico, mesEstatico, evento.Fecha.Day), evento.Categoria, evento.RepetirMensualmente))
                .ToList();

            // Combinar ambas listas de eventos, excluyendo duplicados
            var eventosFinalesDelMes = eventosDelMes
                .Where(evento => !evento.RepetirMensualmente)
                .Concat(eventosRepetidosMensualmente)
                .OrderBy(evento => evento.Fecha)
                .ToList();

            // Crear el mensaje a mostrar
            StringBuilder mensaje = new StringBuilder();
            mensaje.AppendLine("Próximos pagos del mes:");

            foreach (var evento in eventosFinalesDelMes)
            {
                mensaje.AppendLine($"{evento.Fecha:dd/MM/yyyy} - {evento.Nombre}");
            }

            // Mostrar el mensaje
            MessageBox.Show(mensaje.ToString(), "Próximos Pagos");

            // Configurar los detalles del correo electrónico
            string remitente = "finanzaspro00@gmail.com"; // Cambia esto a tu correo de Gmail o Outlook
            string contrasena = "idcx kbyz fuoc vlnq"; // Cambia esto a tu contraseña o a una contraseña de aplicación
            string destinatario = Transacciones.correo;
            string asunto = "Próximos Pagos del Mes";
            string cuerpo = mensaje.ToString();

            try
            {
                // Configurar el cliente SMTP
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587) // Cambia el host y puerto si usas Outlook
                {
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(remitente, contrasena),
                    EnableSsl = true
                };

                // Crear el mensaje de correo
                MailMessage mailMessage = new MailMessage(remitente, destinatario, asunto, cuerpo)
                {
                    IsBodyHtml = false
                };

                // Enviar el correo
                smtpClient.Send(mailMessage);
                MessageBox.Show("Correo enviado exitosamente", "Éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al enviar el correo: {ex.Message}", "Error");
            }
        }

        public static void mandarProximos7Dias()
        {
            // Obtener el rango de los próximos 7 días
            DateTime inicioSemana = DateTime.Now;
            DateTime finSemana = inicioSemana.AddDays(7);

            // Filtrar las transacciones programadas para los próximos 7 días
            var eventosDeLaSemana = Transacciones.transaccionesProgramadas
                .Where(evento =>
                    (evento.Fecha >= inicioSemana && evento.Fecha <= finSemana) ||
                    (evento.RepetirMensualmente &&
                     evento.Fecha.Day >= inicioSemana.Day && evento.Fecha.Day <= finSemana.Day))
                .ToList();

            // Filtrar las transacciones repetidas mensualmente para ajustarlas a los próximos 7 días
            var eventosRepetidosMensualmente = eventosDeLaSemana
                .Where(evento => evento.RepetirMensualmente)
                .Select(evento => new TransaccionProgramada(evento.Nombre, evento.Monto, new DateTime(DateTime.Now.Year, DateTime.Now.Month, evento.Fecha.Day), evento.Categoria, evento.RepetirMensualmente))
                .ToList();

            // Combinar ambas listas de eventos, excluyendo duplicados
            var eventosFinalesDeLaSemana = eventosDeLaSemana
                .Where(evento => !evento.RepetirMensualmente)
                .Concat(eventosRepetidosMensualmente)
                .OrderBy(evento => evento.Fecha)
                .ToList();

            // Crear el mensaje a mostrar
            StringBuilder mensaje = new StringBuilder();
            mensaje.AppendLine("Próximos pagos de los próximos 7 días:");

            foreach (var evento in eventosFinalesDeLaSemana)
            {
                mensaje.AppendLine($"{evento.Fecha:dd/MM/yyyy} - {evento.Nombre}");
            }

            // Configurar los detalles del correo electrónico
            string remitente = "finanzaspro00@gmail.com"; // Cambia esto a tu correo de Gmail o Outlook
            string contrasena = "idcx kbyz fuoc vlnq"; // Cambia esto a tu contraseña o a una contraseña de aplicación
            string destinatario = Transacciones.correo;
            string asunto = "Próximos Pagos de los Próximos 7 Días";
            string cuerpo = mensaje.ToString();

            try
            {
                // Configurar el cliente SMTP
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587) // Cambia el host y puerto si usas Outlook
                {
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(remitente, contrasena),
                    EnableSsl = true
                };

                // Crear el mensaje de correo
                MailMessage mailMessage = new MailMessage(remitente, destinatario, asunto, cuerpo)
                {
                    IsBodyHtml = false
                };

                // Enviar el correo
                smtpClient.Send(mailMessage);
                MessageBox.Show("Correo enviado exitosamente", "Éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al enviar el correo: {ex.Message}", "Error");
            }
        }


    }

}
