using CapaNegocio;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmCargos : Form
    {
        CargoNegocio cn = new CargoNegocio();

        public FrmCargos()
        {
            InitializeComponent();
        }

        private void MostrarDatos()
        {
            dgvCargos.DataSource = cn.MostrarCargos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (var form = new FrmAgregarCargo())
            {
                form.ShowDialog(this);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            using (var form = new FrmModificarCargo())
            {
                form.ShowDialog(this);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seleccione un cargo para eliminar", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmCargos_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }
    }
}
