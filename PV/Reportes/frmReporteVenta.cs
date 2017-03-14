using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PV
{
    public partial class FrmReporteVenta : Form
    {
        
        DataTable dtResult = new DataTable();
        public FrmReporteVenta()
        {
            InitializeComponent();
        }


        public void frmReporteVenta_Load(object sender, EventArgs e)
        {
            try
            {
                DateTime fecha = DateTime.Now;
                picFechaInicio.Value = new DateTime(DateTime.Now.Year,DateTime.Now.Month,1);
                buscar();
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
        }



        private void buscar()
        {
            try
            {
                BL.ClsReportes clsReporteVenta = new BL.ClsReportes();
                dtResult = clsReporteVenta.ventasPorFecha(picFechaInicio.Value.ToShortDateString(), picFechaFin.Value.ToShortDateString());
                grdDatos.DataSource = dtResult;
                lblExistentes.Text = grdDatos.Rows.Count.ToString() + " Registro(s)";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                buscar();
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
                            if (MessageBox.Show("Archivo guardado correctamente,¿Desea abrirlo?", "Abrir Archivo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
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
