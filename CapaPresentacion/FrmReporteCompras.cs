using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmReporteCompras : Form
    {
        public FrmReporteCompras()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reporte generado del " + dtpFechaInicio.Value.ToShortDateString() + " al " + dtpFechaFin.Value.ToShortDateString(), "Reporte de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExportarPDF_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exportando reporte de compras a PDF...", "Exportar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
