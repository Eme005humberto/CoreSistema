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
            DataTable datos = dgvReporte.DataSource as DataTable;

            if (datos == null || datos.Rows.Count == 0)
            {
                MessageBox.Show(
                    "Genere el reporte antes de exportar",
                    "Reporte de Ventas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            using (SaveFileDialog dialogo = new SaveFileDialog())
            {
                dialogo.Filter = "Archivo PDF (*.pdf)|*.pdf";
                dialogo.FileName = "ReporteVentas_" + DateTime.Now.ToString("yyyyMMdd_HHmm") + ".pdf";

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
                        "IdDetalleVenta", "IdVenta", "Producto",
                        "PrecioUnitario", "Cantidad", "Total", "FechaDetalleVenta"
                    };

                    string[] encabezados =
                    {
                        "Id Detalle", "Id Venta", "Producto",
                        "P. Unitario", "Cant.", "Total", "Fecha"
                    };

                    string[] formatos =
                    {
                        null, null, null, "N2", "0", "N2", "dd/MM/yyyy HH:mm"
                    };

                    ReportePdf.Exportar(
                        "Reporte de Ventas",
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
                        "Reporte de Ventas",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }
    }
}