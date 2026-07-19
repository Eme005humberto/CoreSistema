using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmInventario : Form
    {
        public FrmInventario()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (var form = new FrmAgregarProducto())
            {
                form.ShowDialog(this);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            using (var form = new FrmModificarProducto())
            {
                form.ShowDialog(this);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seleccione un producto para eliminar", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
