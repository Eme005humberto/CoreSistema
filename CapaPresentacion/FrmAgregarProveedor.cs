using CapaNegocio;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmAgregarProveedor : Form
    {
        ProveedorNegocio pr = new ProveedorNegocio();
        public FrmAgregarProveedor()
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

            pr.insertData(txtContacto.Text, txtTelefono.Text);
            MessageBox.Show("Proveedor guardado correctamente", "Cargos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void FrmAgregarProveedor_Load(object sender, EventArgs e)
        {

        }
    }
}
