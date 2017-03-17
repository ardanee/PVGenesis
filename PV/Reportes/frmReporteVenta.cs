using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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

        TextBox textBoxDgv1 = new TextBox();
        Label labelDgv1 = new Label();

        public FrmReporteVenta()
        {
            InitializeComponent();
        }


        public void frmReporteVenta_Load(object sender, EventArgs e)
        {
            try
            {
                cmbTipoVenta.Items.Add("Crédito - Contado");
                cmbTipoVenta.Items.Add("Contado");
                cmbTipoVenta.Items.Add("Crédito");
                cmbTipoVenta.SelectedIndex = 0;

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
                string forma = "";
                if (cmbTipoVenta.SelectedIndex > 0)
                    forma = cmbTipoVenta.SelectedItem.ToString();
                //MessageBox.Show("c: " + forma);
                dtResult = clsReporteVenta.ventasPorFecha(picFechaInicio.Value.ToShortDateString(), picFechaFin.Value.ToShortDateString(),forma);
                grdDatos.DataSource = dtResult;
                lblExistentes.Text = grdDatos.Rows.Count.ToString() + " Registro(s)";

                CalcularTotales();
            }
            catch (Exception)
            {

                throw;
            }
        }


        private void CalcularTotales()
        {
            try
            {/*
                if (this.dtResult.Rows.Count > 0)
                {
                   txtSumInversion.Text = double.Parse(dtResult.Compute("sum(inversion)", "").ToString()).ToString();
                    //dtResult.Compute("sum(inversion)","")
                    txtSumaVentas.Text = double.Parse(dtResult.Compute("sum(valor)", "").ToString()).ToString();
                   txtSumaRecuperado.Text = double.Parse(dtResult.Compute("sum(montoPagado)", "").ToString()).ToString();
                    txtSumaSaldos.Text = double.Parse(dtResult.Compute("sum(saldo)", "").ToString()).ToString();
                }else
                {
                    txtSumaRecuperado.Text = "0.00";
                    txtSumaSaldos.Text = "0.00";
                    txtSumaVentas.Text = "0.00";
                    txtSumInversion.Text = "0.00";
                }
                */

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
                string fileName = "Sales_" + this.picFechaInicio.Value.ToString("dd_MM_yyyy") + "_to_" + this.picFechaFin.Value.ToString("dd_MM_yyyy"); ;
                sfd.FileName = fileName;
               // MessageBox.Show("fecha: " + this.picFechaInicio.Value.ToString("dd-MM-yyyy"));
                sfd.RestoreDirectory = true;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (!String.IsNullOrEmpty(sfd.FileName))
                    {
                        //Exporting to Excel
                        fileName = sfd.FileName;
                        //if (!Directory.Exists(folderPath))
                        //{
                        //    Directory.CreateDirectory(folderPath);
                        //}
                        using (XLWorkbook wb = new XLWorkbook())
                        {
                            wb.Worksheets.Add(dtResult, "Ventas");
                            //wb.Worksheet("Ventas").Range(("D" + (dtResult.Rows.Count + 2).ToString())).Value = "Hello"; ;
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

        private void cmbTipoVenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                buscar();
            }catch(Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
        }
    }
}
