using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PV
{

    public partial class FrmRptCientesAtrasados : Form
    {
        DataTable dtResult = new DataTable();
        public FrmRptCientesAtrasados()
        {
            InitializeComponent();
        }

        private void FrmRptCientesAtrasados_Load(object sender, EventArgs e)
        {
            BL.ClsReportes ClsReportes = new BL.ClsReportes();
            try
            {
                this.Cursor = Cursors.WaitCursor;
                dtResult = ClsReportes.clientesMorosos();
                grdDatos.DataSource = dtResult;
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

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            Boolean estado = true;
            try
            {
                if (grdDatos.SelectedRows.Count < 1)
                {
                    estado = false;
                }
                verEstadoDeCuentaToolStripMenuItem.Enabled = estado;
            }
            catch (Exception ex)
            {

                ClsHelper.erroLog(ex);
            }

        }

        private void verEstadoDeCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                BL.ClsReportes ClsReportes = new BL.ClsReportes();
                DataSet dts = new DataSet();
                FrmReporte FrmReporte = new FrmReporte();
                dts = ClsReportes.rptEstadoCuenta(grdDatos.SelectedRows[0].Cells["idVentaCol"].Value.ToString());
                FrmReporte.cargarReporte("RptEstadoCuenta", dts);
            }
            catch (Exception ex)
            {

                ClsHelper.erroLog(ex);
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtResult.Rows.Count < 1)
                {
                    ClsHelper.MensajeSistema("No hay datos para exportar");
                    return;
                }


                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "txt files (*.xlsx)|*.xlsx";
                sfd.FilterIndex = 2;
                sfd.RestoreDirectory = true;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (!String.IsNullOrEmpty(sfd.FileName))
                    {
                        //Exporting to Excel
                        string fileName = sfd.FileName;
                        //if (!Directory.Exists(folderPath))
                        //{
                        //    Directory.CreateDirectory(folderPath);
                        //}
                        using (XLWorkbook wb = new XLWorkbook())
                        {
                            wb.Worksheets.Add(dtResult, "Customers");
                            wb.SaveAs(fileName);
                            if(MessageBox.Show("Archivo guardado correctamente,¿Desea abrirlo?","Abrir Archivo",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
                            {
                                System.Diagnostics.Process.Start(fileName);
                            }
                        }

                    }
                }




            }
            catch (Exception ex)
            {

                ClsHelper.erroLog(ex);
            }
        }
    }
}
