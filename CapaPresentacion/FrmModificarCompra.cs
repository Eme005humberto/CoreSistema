using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmModificarCompra : Form
    {
        public FrmModificarCompra()
        {
            InitializeComponent();
        }

        public void CargarDatos(string producto, string proveedor, int cantidad, decimal precio, DateTime fecha)
        {
            txtProducto.Text = producto;
            txtProveedor.Text = proveedor;
            txtCantidad.Value = cantidad;
            txtPrecio.Value = precio;
            dtpFecha.Value = fecha;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProducto.Text))
            {
                MessageBox.Show("Ingrese el producto", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
