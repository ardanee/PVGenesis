using Microsoft.Reporting.WinForms;
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
    public partial class FrmReporte : Form
    {
        public string idReporte;
        public FrmReporte()
        {
            InitializeComponent();
        }

        private void FrmReporte_Load(object sender, EventArgs e)
        {

            this.rw1.RefreshReport();
        }

        public void cargarReporte(string nombreReporte, Object origenDatos)
        {
            try
            {
                switch (nombreReporte)
                {
                    case "RptRecibo":
                        {
                            rw1.LocalReport.ReportPath = @"Reportes\RptRecibo.rdlc";
                            rw1.LocalReport.DataSources.Clear();
                            rw1.LocalReport.DataSources.Add(new ReportDataSource("DtsRecibo", (DataTable)origenDatos));

                            break;
                        }
                    case "RptEstadoCuenta":
                        {
                            rw1.LocalReport.ReportPath = @"Reportes\RptEstadoCuenta.rdlc";
                            rw1.LocalReport.DataSources.Clear();
                            rw1.LocalReport.DataSources.Add(new ReportDataSource("DtsEstadoCuenta", ((DataSet)origenDatos).Tables[0]));
                            rw1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", ((DataSet)origenDatos).Tables[1]));
                            break;
                        }
                    case "RptCotizacion":
                        {
                            rw1.LocalReport.ReportPath = @"Reportes\RptCotizacion.rdlc";
                            rw1.LocalReport.DataSources.Clear();
                            rw1.LocalReport.DataSources.Add(new ReportDataSource("dtsCotizacion",(DataTable)origenDatos));
                            break;
                        }
                    case "RptVenta":
                        {
                            rw1.LocalReport.ReportPath = @"Reportes\RptVenta.rdlc";
                            rw1.LocalReport.DataSources.Clear();
                            rw1.LocalReport.DataSources.Add(new ReportDataSource("dtsVenta", (DataTable)origenDatos));
                            break;
                        }
                }

                this.rw1.RefreshReport();
                this.ShowDialog();
            }
            catch (Exception ex)
            {

                ClsHelper.erroLog(ex);
            }
        }
    }
}
