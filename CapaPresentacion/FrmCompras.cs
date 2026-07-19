using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmCompras : Form
    {
        public FrmCompras()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (var form = new FrmAgregarCompra())
            {
                form.ShowDialog(this);
            }
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compra realizada correctamente", "Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dgvCompras.Rows.Clear();
        }
    }
}
