using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (var form = new FrmAgregarUsuario())
            {
                form.ShowDialog(this);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            using (var form = new FrmModificarUsuario())
            {
                form.ShowDialog(this);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seleccione un usuario para eliminar", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
