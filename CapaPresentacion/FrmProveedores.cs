using CapaNegocio;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmProveedores : Form
    {
        ProveedorNegocio pr = new ProveedorNegocio();
        public FrmProveedores()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (var form = new FrmAgregarProveedor())
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    MostrarDatos(); // refresca el grid después de agregar
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            using (var form = new FrmModificarProveedor())
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    MostrarDatos(); // refresca el grid después de agregar
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seleccione un proveedor para eliminar", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void MostrarDatos()
        {
            CargoNegocio cn = new CargoNegocio();
            dgvProveedores.DataSource = pr.MostrarProveedor();
        }
    }
}
