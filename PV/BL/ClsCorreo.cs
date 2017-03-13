
using System;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Net.Mail;
using System.Windows.Forms;

namespace PV.BL
{
    class Correo
    {
        //static bool mailEnviado = false;
        private String mailEmisor;
        private String mailReceptor;
        private String nombreDe;
        private String apellidoDe;
        private SmtpClient cliente;
        private MailAddress mailDe;
        private MailAddress mailPara;
        private MailMessage mensaje;
        private string estado;


        public Correo(string correo, string nombreDe, string apellidoDe)
        {
            try
            {

                this.mailEmisor = correo;
                this.mailReceptor = correo;
                this.nombreDe = nombreDe;
                this.apellidoDe = apellidoDe;
                this.cliente = new SmtpClient("smtp.gmail.com", 587);
                //this.autenticar();
                this.mailDe = new MailAddress(this.mailEmisor, this.nombreDe + " " + this.apellidoDe, System.Text.Encoding.UTF8);
                this.mailPara = new MailAddress(this.mailReceptor);
                this.mensaje = new MailMessage(this.mailDe, this.mailPara);
                this.estado = "";
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void autenticar(string mail,string pass)
        {
            try
            {
                this.cliente.Credentials = new System.Net.NetworkCredential(mail, pass);
                this.cliente.EnableSsl = true;
                this.cliente.DeliveryMethod = SmtpDeliveryMethod.Network;
                this.cliente.Timeout = 10000;
            }
            catch (Exception)
            {
                throw;
            }


        }


       
        public void enviar()
        {
            try
            {
                BL.ClsReportes clsReportes = new ClsReportes();

                DateTime hoy = DateTime.Parse(DateTime.Now.ToString());
               string html = "<div style=\"text-align:center;\"><h1 style=\"font-size:32px; display block;\">Reporte vehiculos " + hoy.ToString("f") +"</h1>" ;
               html += convertDataTableToHTML(clsReportes.RptDiarioVehiculos());
                html +="</div>";
                this.mensaje.Body = html;
                //String someArrows = new String(new char[] { '\u2190', '\u2191', '\u2192', '\u2193' });
                this.mensaje.IsBodyHtml = true;
                this.mensaje.Body += Environment.NewLine;
                this.mensaje.BodyEncoding = System.Text.Encoding.UTF8;
                this.mensaje.Subject = "Reporte vehiculos diario";
                //this.mensaje.Attachments.Add(this.generarReporte());
                this.mensaje.SubjectEncoding = System.Text.Encoding.UTF8;
                this.cliente.SendCompleted += new SendCompletedEventHandler(estadoEnvio);

                string UserState = "Mensaje";
                this.cliente.SendAsync(this.mensaje, UserState);
            }
            catch (Exception)
            {
                throw;
            }
            //this.mensaje.Dispose();

        }

        
        private string convertDataTableToHTML(DataTable dt){
            string tablaHtml;
            try
            {
                tablaHtml = "<table style=\" box-shadow: 0 10px 30px rgba(0, 0, 0, 0.2);animation: float 5s infinite; width: 100%;border-collapse: collapse;border: 1px solid #38678f;background: white;text-align:center;\">";
                tablaHtml += "<thead><tr style=\"border-bottom: 1px solid #cccccc;\">";
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    tablaHtml += "<th style=\" background: steelblue;height: 54px;font-weight: lighter;text-shadow: 0 1px 0 #38678f;color: white;border: 1px solid #38678f;box-shadow: inset 0px 1px 2px #568ebd;\">" + dt.Columns[i].ColumnName.ToString() + "</th>";
                }
                tablaHtml += "</tr></thead>";
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    tablaHtml += "<tr style=\"border-bottom: 1px solid #cccccc;\">";
                    for (int j = 0; j < dt.Columns.Count; j++)
                        tablaHtml += "<td style=\"border-right: 1px solid #cccccc; padding:7px\">" + dt.Rows[i][j].ToString() + "</td>";
                    tablaHtml += "<tr>";
                }
                tablaHtml += "</table>";
            }
            catch (Exception)
            {
                throw;
            }
                return tablaHtml;
        }

        private void estadoEnvio(object sender,AsyncCompletedEventArgs e)
        {
            try
            {
                String ficha = (String)e.UserState;

                if (e.Cancelled)
                {
                    //Mesnaje Cancelado
                    this.estado = "Mensaje cancelado " + ficha + e.Error;
                }
                if (e.Error != null)
                {
                    //Error en el Envio
                    this.estado = "Error en el envio " + ficha + e.Error;

                }
                else
                {
                    //Mensaje Enviado
                    this.estado = "Mensaje Enviado " + ficha;

                }
                MessageBox.Show(this.estado);
                //mailEnviado = true;
            }
            catch (Exception)
            {
                throw;
            }

        }

        

        private Attachment generarReporte()
        {
            //string file = System.IO.Path.GetFileName("C:\\Users\\Soporte\\Desktop\\19.02.2017.0.20.pdf");
            string file = "C:\\Users\\Soporte\\Desktop\\19.02.2017.0.20.pdf";
            return new Attachment(file);
        }

    }
}
