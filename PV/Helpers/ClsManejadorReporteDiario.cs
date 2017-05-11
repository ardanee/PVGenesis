using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PV
{
    class ClsManejadorReporteDiario
    {
        private volatile bool _shouldStop;
        private BL.ClsParametros clsParametros;
        private ClsCorreo clsCorreo;
        public int intervalo = 300000;
        private int intentos = 1;
        private BL.ClsMail clsMail = new BL.ClsMail();

        public ClsManejadorReporteDiario()
        {
            try
            {
                this.clsParametros = new BL.ClsParametros();
            }
            catch (Exception ex)
            {
                EscribirLog("Excepcion", ex.Message);
            }
        }

        public void DoWork()
        {
            try
            {
                while (!_shouldStop)
                {

                    DataTable dtMail = clsMail.seleccionar("");
                    DataTable dt = clsParametros.seleccionarValorCorreo();
                    string dia = dt.Rows[0]["dia"].ToString();
                    if (dia == DateTime.Now.Day.ToString() && dtMail.Rows[0]["correoDestino"].ToString() == dt.Rows[0]["correo"].ToString() )
                    {
                        RequestStop();
                    }
                    else
                    {
                        if (dt.Rows.Count > 0)
                        {
                            this.clsCorreo = new ClsCorreo(dtMail.Rows[0]["correoDestino"].ToString(), 
                                "Importadora", "Génesis", dtMail.Rows[0]["correoOrigen"].ToString());
                            clsCorreo.autenticar(dtMail.Rows[0]["correoOrigen"].ToString(), 
                                dtMail.Rows[0]["contrasena"].ToString());
                            if (clsCorreo.enviarReporte())
                            {
                                //BL.ClsParametros clsParametros = new BL.ClsParametros();
                                clsParametros.grabarModificarPCorreo(DateTime.Now.Day.ToString(), dtMail.Rows[0]["correoDestino"].ToString());
                                EscribirLog("Mensaje", "Mensje Enviado a: " + dtMail.Rows[0]["correoDestino"].ToString());
                                RequestStop();
                            }
                            if (intentos == 10)
                            {
                                RequestStop();
                            }
                        }
                        else
                        {
                            RequestStop();
                        }
                        
                    }
                    intentos++;
                    Thread.Sleep(intervalo);
                }
            }
            catch (Exception ex)
            {
                EscribirLog("Excepcion",ex.Message);
                throw;
            }
        }

        public void RequestStop()
        {
            intervalo = 1;
            intentos = 10;
            _shouldStop = true;

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
                LogFile.WriteLine(tipo + ": - " + DateTime.Now.ToString("dd/MM/yyy hh:mm") + " - " +data);
                LogFile.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        
    }
}

