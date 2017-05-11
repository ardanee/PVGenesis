
using System;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.IO;
using System.Net.Mail;
using System.Windows.Forms;

namespace PV
{
    class ClsCorreo
    {
        public bool mailEnviado = false;
        private String mailEmisor;
        private String mailReceptor;
        private String nombreDe;
        private String apellidoDe;
        private SmtpClient cliente;
        private MailAddress mailDe;
        private MailAddress mailPara;
        private MailMessage mensaje;
        private string estado;
        private static string LogFilePath = Application.StartupPath + @"\logmail.txt";



        private string[] obtenerProtocolo(string correo)
        {
            char[] delimitador = {'@' };
            string[] dominios = correo.Split(delimitador);
            string[] resultado = {"","" }; 

            foreach(string elemento in dominios){
                if (elemento == "hotmail.com" || elemento == "live.com" || elemento == "outlook.com")
                {
                    resultado[0] = "smtp.live.com";
                    resultado[1] = "587";
                }
                else if (elemento == "yahoo.com")
                {
                    resultado[0] = "smtp.mail.yahoo.com";
                    resultado[1] = "587";
                }
                else if (elemento == "gmail.com")
                {
                    resultado[0] = "smtp.gmail.com";
                    resultado[1] = "587";

                }
            }


            return resultado;
        }

        public ClsCorreo(string correo, string nombreDe, string apellidoDe,string correoEnvia)
        {
            try
            {

                //MessageBox.Show(logFile);
                this.mailEmisor = correoEnvia;
                this.mailReceptor = correo;
                this.nombreDe = nombreDe;
                this.apellidoDe = apellidoDe;
                string[] d = obtenerProtocolo(correoEnvia);
                this.cliente = new SmtpClient(d[0],int.Parse(d[1]));
                //this.autenticar();
                this.mailDe = new MailAddress(this.mailEmisor, this.nombreDe + " " + this.apellidoDe, System.Text.Encoding.UTF8);
                this.mailPara = new MailAddress(this.mailReceptor);
                this.mensaje = new MailMessage(this.mailDe, this.mailPara);
                this.estado = "";
            }
            catch (Exception ex)
            {
                EscribirLog("Excepcion", ex.Message);

                //throw;
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
            catch (Exception ex)
            {
                EscribirLog("Excepcion", ex.Message);
                //throw;
            }


        }


       
        public bool enviarReporte()
        {
            try
            {
                PV.BL.ClsReportes clsReportes = new PV.BL.ClsReportes();

                DateTime hoy = DateTime.Parse(DateTime.Now.ToString());
                string html = "<div style=\"text-align:center;\"><h1 style=\"font-size:32px; display block;\">Reporte vehiculos " + hoy.ToString("f") +"</h1>" ;
                html += convertDataTableToHTML(clsReportes.RptDiarioVehiculos());
                html +="</div>";
                this.mensaje.Body = html;
                //String someArrows = new String(new char[] { '\u2190', '\u2191', '\u2192', '\u2193' });
                this.mensaje.IsBodyHtml = true;
                this.mensaje.Body += Environment.NewLine;
                this.mensaje.BodyEncoding = System.Text.Encoding.UTF8;
                this.mensaje.Subject = "Reporte vehiculos";
                //this.mensaje.Attachments.Add(this.generarReporte());
                this.mensaje.SubjectEncoding = System.Text.Encoding.UTF8;
                this.cliente.SendCompleted += new SendCompletedEventHandler(estadoEnvio);
                string UserState = "Mensaje";
                this.cliente.Send(this.mensaje);
                return true;
            }
            catch (Exception ex)
            {
                EscribirLog("Excepcion", ex.Message);
                return false;
//                throw;
            }
            //this.mensaje.Dispose();

        }


        public bool correoPrueba()
        {
            try
            {

                DateTime hoy = DateTime.Parse(DateTime.Now.ToString());
                string html = "<h1>Correo Prueba Importadora Genesis</h1>";
                this.mensaje.Body = html;
                this.mensaje.IsBodyHtml = true;
                this.mensaje.Body += Environment.NewLine;
                this.mensaje.BodyEncoding = System.Text.Encoding.UTF8;
                this.mensaje.Subject = "Correo Prueba";
                this.mensaje.SubjectEncoding = System.Text.Encoding.UTF8;
                this.cliente.SendCompleted += new SendCompletedEventHandler(estadoEnvio);
                string UserState = "correoPrueba";
                this.cliente.Send(mensaje);
                return true;
                //MessageBox.Show("Enviado");
            }
            catch (Exception ex)
            {
                return false;
                //MessageBox.Show("Error");
                //EscribirLog("Excepcion", ex.Message);
                //                throw;
            }
        }

        private string convertDataTableToHTML(DataTable dt){
            string tablaHtml = "";
            try
            {
                if (dt.Rows.Count <= 0)
                {
                    tablaHtml += "<h3>No hay Registros de Vehiculos, para venta</h3>";
                }
                else
                {
                    tablaHtml += "<table style=\" box-shadow: 0 10px 30px rgba(0, 0, 0, 0.2);animation: float 5s infinite; width: 100%;border-collapse: collapse;border: 1px solid #38678f;background: white;text-align:center;\">";
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
            }
            catch (Exception ex)
            {
                //EscribirLog("Exception correo: " + DateTime.Now.ToString("dd/MM/yyy hh:mm") + " " + ex.Message);
                //file.WriteLine("Exception correo: " + DateTime.Now.ToString("dd/MM/yyy hh:mm") + ex.Message);
                EscribirLog("Excepcion", ex.Message);
//                throw;
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
                    mailEnviado = false;
                    //EscribirLog("Mensaje correo: " + DateTime.Now.ToString("dd/MM/yyy hh:mm") + " Correo no enviado error");
                    //file.WriteLine("Mensaje correo: " + DateTime.Now.ToString("dd/MM/yyy hh:mm") + "Correo no enviado error");
                    EscribirLog("Mensaje", "Mensaje no enviado se cancelo el envio : ");


                }
                if (e.Error != null)
                {
                    //Error en el Envio
                    this.estado = "Error en el envio " + ficha + e.Error;
                    mailEnviado = false;
                    EscribirLog("Mensaje", "Mensaje no enviado se produjo un error : "+ e.Error.Message);

                    //EscribirLog("Mensaje correo: " + DateTime.Now.ToString("dd/MM/yyy hh:mm") + " Correo no enviado, error");
                    //file.WriteLine("Mensaje correo: " + DateTime.Now.ToString("dd/MM/yyy hh:mm") + "Correo no enviado, error");

                }
                else
                {
                    //Mensaje Enviado
                    this.estado = "Mensaje Enviado " + ficha;
                    mailEnviado = true;
                    
                    //MessageBox.Show(ficha);
                    //EscribirLog("Mensaje correo: " + DateTime.Now.ToString("dd/MM/yyy hh:mm") + " Correo enviado");
                    //file.WriteLine("Mensaje correo: " + DateTime.Now.ToString("dd/MM/yyy hh:mm") +"Correo enviado");

                }
                //MessageBox.Show(this.estado);
                //mailEnviado = true;
            }
            catch (Exception ex)
            {
                //EscribirLog("Exception Correo: " + DateTime.Now.ToString("dd/MM/yyy hh:mm") + " " +ex.Message);
                //file.WriteLine("Exception Correo: " + DateTime.Now.ToString("dd/MM/yyy hh:mm") + ex.Message);
                EscribirLog("Excepcion", ex.Message);

//                throw;
            }

        }

        

        private Attachment generarReporte()
        {
            //string file = System.IO.Path.GetFileName("C:\\Users\\Soporte\\Desktop\\19.02.2017.0.20.pdf");
            string file = "C:\\Users\\Soporte\\Desktop\\19.02.2017.0.20.pdf";
            return new Attachment(file);
        }


        private void EscribirLog(string tipo, string data)
        {

            try
            {
                string LogFilePath = Application.StartupPath + @"\logmail.txt";
                StreamWriter LogFile;
                if (File.Exists(LogFilePath))
                    LogFile = new StreamWriter(LogFilePath, true);
                else
                    LogFile = new StreamWriter(LogFilePath);
                LogFile.WriteLine(tipo + ": - " + DateTime.Now.ToString("dd/MM/yyy hh:mm") + "- "+ data);
                LogFile.Close();
            }
            catch (Exception)
            {

            }
        }
    }
}
