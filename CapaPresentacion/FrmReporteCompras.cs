using CapaNegocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmReporteCompras : Form
    {
        private readonly CompraNegocio compraNegocio = new CompraNegocio();

        public FrmReporteCompras()
        {
            InitializeComponent();
        }

        private void FrmReporteCompras_Load(object sender, EventArgs e)
        {
            dtpFechaFin.Value = DateTime.Today;
            dtpFechaInicio.Value = DateTime.Today.AddDays(-30);

            dgvReporte.AutoGenerateColumns = false;
            dgvReporte.Columns.Clear();
            dgvReporte.Columns.Add("IdDetalleCompra", "Id Detalle");
            dgvReporte.Columns["IdDetalleCompra"].DataPropertyName = "IdDetalleCompra";

            dgvReporte.Columns.Add("IdCompra", "Id Compra");
            dgvReporte.Columns["IdCompra"].DataPropertyName = "IdCompra";

            dgvReporte.Columns.Add("Proveedor", "Proveedor");
            dgvReporte.Columns["Proveedor"].DataPropertyName = "Proveedor";

            dgvReporte.Columns.Add("Producto", "Producto");
            dgvReporte.Columns["Producto"].DataPropertyName = "Producto";

            dgvReporte.Columns.Add("PrecioUnitario", "P. Unitario");
            dgvReporte.Columns["PrecioUnitario"].DataPropertyName = "PrecioUnitario";

            dgvReporte.Columns.Add("Cantidad", "Cant.");
            dgvReporte.Columns["Cantidad"].DataPropertyName = "Cantidad";

            dgvReporte.Columns.Add("Total", "Total");
            dgvReporte.Columns["Total"].DataPropertyName = "Total";

            dgvReporte.Columns.Add("FechaDetalleCompraa", "Fecha en la que se realizo la compra");
            dgvReporte.Columns["FechaDetalleCompraa"].DataPropertyName = "FechaDetalleCompraa";

            dgvReporte.Columns["FechaDetalleCompraa"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            dgvReporte.Columns["PrecioUnitario"].DefaultCellStyle.Format = "N2";
            dgvReporte.Columns["Total"].DefaultCellStyle.Format = "N2";
            dgvReporte.Columns["Cantidad"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dgvReporte.Columns["IdDetalleCompra"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dgvReporte.Columns["IdCompra"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (dtpFechaInicio.Value.Date > dtpFechaFin.Value.Date)
            {
                MessageBox.Show(
                    "La fecha de inicio no puede ser mayor a la fecha fin",
                    "Reporte de Compras",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            try
            {
                DataTable resultado = compraNegocio.ReporteCompras(
                    dtpFechaInicio.Value,
                    dtpFechaFin.Value
                );

                dgvReporte.DataSource = resultado;

                if (resultado.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "No hay compras en el rango seleccionado",
                        "Reporte de Compras",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo generar el reporte: " + ex.Message,
                    "Reporte de Compras",
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
                    "Reporte de Compras",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            MessageBox.Show(
                "Exportando reporte de compras a PDF...",
                "Exportar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}