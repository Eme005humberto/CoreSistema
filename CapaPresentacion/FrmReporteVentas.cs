using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmReporteVentas : Form
    {
        public FrmReporteVentas()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reporte generado del " + dtpFechaInicio.Value.ToShortDateString() + " al " + dtpFechaFin.Value.ToShortDateString(), "Reporte de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExportarPDF_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exportando reporte de ventas a PDF...", "Exportar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
