using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmCategorias : Form
    {
        public FrmCategorias()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (var form = new FrmAgregarCategoria())
            {
                form.ShowDialog(this);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            using (var form = new FrmModificarCategoria())
            {
                form.ShowDialog(this);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seleccione una categoria para eliminar", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
