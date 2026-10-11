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
            DataTable datos = dgvReporte.DataSource as DataTable;

            if (datos == null || datos.Rows.Count == 0)
            {
                MessageBox.Show(
                    "Genere el reporte antes de exportar",
                    "Reporte de Compras",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            using (SaveFileDialog dialogo = new SaveFileDialog())
            {
                dialogo.Filter = "Archivo PDF (*.pdf)|*.pdf";
                dialogo.FileName = "ReporteCompras_" + DateTime.Now.ToString("yyyyMMdd_HHmm") + ".pdf";

                if (dialogo.ShowDialog(this) != DialogResult.OK)
                {
                    return;
                }

                try
                {
                    string rango = dtpFechaInicio.Value.ToString("dd/MM/yyyy")
                        + " - "
                        + dtpFechaFin.Value.ToString("dd/MM/yyyy");

                    string[] columnas =
                    {
                        "IdDetalleCompra", "IdCompra", "Proveedor", "Producto",
                        "PrecioUnitario", "Cantidad", "Total", "FechaDetalleCompraa"
                    };

                    string[] encabezados =
                    {
                        "Id Detalle", "Id Compra", "Proveedor", "Producto",
                        "P. Unitario", "Cant.", "Total", "Fecha"
                    };

                    string[] formatos =
                    {
                        null, null, null, null, "N2", "0", "N2", "dd/MM/yyyy HH:mm"
                    };

                    ReportePdf.Exportar(
                        "Reporte de Compras",
                        rango,
                        datos,
                        columnas,
                        encabezados,
                        formatos,
                        dialogo.FileName
                    );

                    if (MessageBox.Show(
                            "Reporte exportado correctamente.\n\nDesea abrirlo?",
                            "Exportar",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(dialogo.FileName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "No se pudo exportar el PDF: " + ex.Message,
                        "Reporte de Compras",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }
    }
}