using CapaDatos;
using CapaNegocio;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmModificarProveedor : Form
    {
        private int idProveedor = 0;
        ProveedorNegocio pr = new ProveedorNegocio();
        public FrmModificarProveedor()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContacto.Text))
            {
                MessageBox.Show("Ingrese el nombre del proveedor", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            pr.UpdateData(txtContacto.Text, txtTelefono.Text,idProveedor);
            MessageBox.Show("Proveedor modificado correctamente", "Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void FrmModificarProveedor_Load(object sender, EventArgs e)
        {

        }

        public void CargarDatosParaEdicion(int IdProveedor, string Proveedor, string Telefono)
        {
            idProveedor = IdProveedor;
            txtContacto.Text = Proveedor;
            txtTelefono.Text = Telefono;
        }
    }
}
