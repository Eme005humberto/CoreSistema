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
            // Extraemos los datos de la fila seleccionada del DataGridView
            int id = Convert.ToInt32(dgvProveedores.CurrentRow.Cells["IdProveedor"].Value);
            string proveedor = dgvProveedores.CurrentRow.Cells["Proveedor"].Value.ToString();
            string telefono = dgvProveedores.CurrentRow.Cells["Telefono"].Value.ToString();

            FrmModificarProveedor frm = new FrmModificarProveedor();
            frm.CargarDatosParaEdicion(id, proveedor,telefono);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                MostrarDatos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un proveedor para eliminar.");
                return;
            }

            int id = Convert.ToInt32(dgvProveedores.CurrentRow.Cells["IdProveedor"].Value);

            if (MessageBox.Show("¿Desea eliminar este proveedor?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                pr.DeleteData(id);
                MostrarDatos();
            }
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void MostrarDatos()
        {
            ProveedorNegocio pr = new ProveedorNegocio();
            dgvProveedores.DataSource = pr.MostrarProveedor();
        }
    }
}
