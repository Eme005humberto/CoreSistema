using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmProveedores : Form
    {
        public FrmProveedores()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (var form = new FrmAgregarProveedor())
            {
                form.ShowDialog(this);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            using (var form = new FrmModificarProveedor())
            {
                form.ShowDialog(this);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seleccione un proveedor para eliminar", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
