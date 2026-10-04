using CapaNegocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmReporteVentas : Form
    {
        private readonly VentaNegocio ventaNegocio = new VentaNegocio();

        public FrmReporteVentas()
        {
            InitializeComponent();
        }

        private void FrmReporteVentas_Load(object sender, EventArgs e)
        {
            dtpFechaFin.Value = DateTime.Today;
            dtpFechaInicio.Value = DateTime.Today.AddDays(-30);

            dgvReporte.AutoGenerateColumns = false;
            dgvReporte.Columns.Clear();

            dgvReporte.Columns.Add("IdDetalleVenta", "Id Detalle");
            dgvReporte.Columns["IdDetalleVenta"].DataPropertyName = "IdDetalleVenta";

            dgvReporte.Columns.Add("IdVenta", "Id Venta");
            dgvReporte.Columns["IdVenta"].DataPropertyName = "IdVenta";

            dgvReporte.Columns.Add("Producto", "Producto");
            dgvReporte.Columns["Producto"].DataPropertyName = "Producto";

            dgvReporte.Columns.Add("PrecioUnitario", "P. Unitario");
            dgvReporte.Columns["PrecioUnitario"].DataPropertyName = "PrecioUnitario";

            dgvReporte.Columns.Add("Cantidad", "Cant.");
            dgvReporte.Columns["Cantidad"].DataPropertyName = "Cantidad";

            dgvReporte.Columns.Add("Total", "Total");
            dgvReporte.Columns["Total"].DataPropertyName = "Total";

            dgvReporte.Columns.Add("FechaDetalleVenta", "Fecha en la que se realizo la venta");
            dgvReporte.Columns["FechaDetalleVenta"].DataPropertyName = "FechaDetalleVenta";
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (dtpFechaInicio.Value.Date > dtpFechaFin.Value.Date)
            {
                MessageBox.Show(
                    "La fecha de inicio no puede ser mayor a la fecha fin",
                    "Reporte de Ventas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            try
            {
                DataTable resultado = ventaNegocio.ReporteVentas(
                    dtpFechaInicio.Value,
                    dtpFechaFin.Value
                );

                dgvReporte.DataSource = resultado;

                if (resultado.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "No hay ventas en el rango seleccionado",
                        "Reporte de Ventas",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo generar el reporte: " + ex.Message,
                    "Reporte de Ventas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnExportarPDF_Click(object sender, EventArgs e)
        {
            if (dgvReporte.Rows.Count == 0)
            {
                MessageBox.Show(
                    "Genere el reporte antes de exportar",
                    "Reporte de Ventas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            MessageBox.Show(
                "Exportando reporte de ventas a PDF...",
                "Exportar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}