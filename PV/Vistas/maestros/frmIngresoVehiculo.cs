using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PV.Vistas.maestros
{
    public partial class frmIngresoVehiculo : Form
    {
        public frmIngresoVehiculo()
        {
            InitializeComponent();
            cargarComboTipoVehiculo();
        }

        private void cargarComboTipoVehiculo()
        {
            BL.ClsTipoVehiculo clsMarca = new BL.ClsTipoVehiculo();
            //DataTable dt = clsMarca.seleccionar("");
            cargarCombos(clsMarca.seleccionar(""), cmbTipoVehiculo," tipo de vehiculo");
        }


        private void cargarComboMarca()
        {
            BL.ClsMarcaV clsMarca = new BL.ClsMarcaV();
            //DataTable dt = clsMarca.seleccionar("");
            cargarCombos(clsMarca.seleccionar(""), cmbMarca,"marca");
        }

        private void cargarCombos(DataTable dataTable, ComboBox combo, string extra)
        {
            Dictionary<int, String> dicTipoVehiculo = new Dictionary<int, string>();
            dicTipoVehiculo.Add(0, "Seleccione " + extra + "...");
            foreach (DataRow row in dataTable.Rows)
            {
                dicTipoVehiculo.Add(Int32.Parse(row[0].ToString()), row[1].ToString());
            }
            combo.DisplayMember = "Value";
            combo.ValueMember = "Key";
            combo.DataSource = dicTipoVehiculo.ToArray();
        }
        
    }
}
