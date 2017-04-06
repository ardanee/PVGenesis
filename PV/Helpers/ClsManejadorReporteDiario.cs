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
        //private StreamReader file;
        private int intervalo = 300000;
        private int intentos = 1;

        public ClsManejadorReporteDiario()
        {
            try
            {
                this.clsParametros = new BL.ClsParametros();
            }
            catch (Exception ex)
            {
                EscribirLog("Excepcion", ex.Message);
                //EscribirLog("Exepcion ManejadorCorreo: " + DateTime.Now.ToString("dd/MM/yyy hh:mm") + ex.Message);
            }
        }

        public void DoWork()
        {
            try
            {
                while (!_shouldStop)
                {
                    DataTable dt = clsParametros.seleccionarValorCorreo();
                    string dia = dt.Rows[0]["dia"].ToString();
                    if (dia == DateTime.Now.Day.ToString())
                    {
                        this.RequestStop();
                        intervalo = 0;
                        //EscribirLog("Mensaje ManejadorCorreo: " + DateTime.Now.ToString("dd/MM/yyy hh:mm") + "Correo ya Enviado");
                    }
                    else
                    {
                        this.clsCorreo = new ClsCorreo("roonmorton@gmail.com", "Importadora", "Génesis");
                        clsCorreo.autenticar("ronquevedo77@gmail.com", "680cfb8dac2016");
                        clsCorreo.enviarReporte();
                        if (this.clsCorreo.mailEnviado)
                        {
                            this.RequestStop();
                            intervalo = 1;
                        }
                        if (intentos == 10)
                        {
                            this.RequestStop();
                            intervalo = 1;
                        }
                        
                    }
                    intentos++;
                    Thread.Sleep(intervalo);
                }
            }
            catch (Exception ex)
            {
               // Thread.Sleep(500000);
                //ClsHelper.erroLog(ex);
                EscribirLog("Excepcion",ex.Message);
                //EscribirLog("Excepcion ManejadorCorreo: " +  + ex.Message);
                throw;
            }
        }

        public void RequestStop()
        {
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

