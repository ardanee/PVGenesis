using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace PV
{
    public partial class FrmCrearBackup : Form
    {
        public FrmCrearBackup()
        {
            InitializeComponent();
        }

        private void btnCrearCopia_Click(object sender, EventArgs e)
        {
            ClsDb ClsDb = new ClsDb();
            String consulta;
            String dbName;
            SqlConnectionStringBuilder cn;
            try

            {
                this.Cursor = Cursors.WaitCursor;
                if (String.IsNullOrEmpty(txtRuta.Text))
                {
                    ClsHelper.MensajeSistema("Debe seleccionar la ruta donde guardará la copia");
                    return;
                }
                //if(!File.Exists(txtRuta.Text))
                //{
                //    File.Create(txtRuta.Text);
                //    if (!File.Exists(txtRuta.Text))
                //    {
                //        ClsHelper.MensajeSistema("La ruta especificada no existe, por favor seleccione otra");
                //    }
                //}
                cn = new SqlConnectionStringBuilder(ConfigurationManager.ConnectionStrings["cnDefault"].ConnectionString);
                dbName = cn.InitialCatalog;
                consulta = "BACKUP DATABASE " + dbName
                            +" TO DISK = N'" + txtRuta.Text + "\\" + dbName + DateTime.Now.Day.ToString()
                            + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString() + "-" + DateTime.Now.Hour.ToString() + "." + DateTime.Now.Minute.ToString() + "." + DateTime.Now.Second.ToString()
                            +".bak' WITH NOFORMAT, NOINIT, NAME =N'" + dbName 
                            +"-Full Database Backup',SKIP, STATS = 10";
                cn.InitialCatalog = "Master";
                ClsDb.ejecutarConsulta(consulta, new SqlConnection(cn.ConnectionString));
                ClsHelper.MensajeSistema("Copia realizada correctamente");
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }


        }

        private void btnRuta_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog fd = new FolderBrowserDialog();
                fd.ShowDialog();
                txtRuta.Text = fd.SelectedPath;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void FrmCrearBackup_Load(object sender, EventArgs e)
        {

        }
    }
}
