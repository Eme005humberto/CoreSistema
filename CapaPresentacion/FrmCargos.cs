using CapaDatos;
using CapaNegocio;
using DevExpress.XtraRichEdit.Model;
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
            CargoNegocio cn = new CargoNegocio();
            dgvCargos.DataSource = cn.MostrarCargos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (var form = new FrmAgregarCargo())
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
            int id = Convert.ToInt32(dgvCargos.CurrentRow.Cells["IdCargo"].Value);
            string cargo = dgvCargos.CurrentRow.Cells["Cargo"].Value.ToString();

            FrmModificarCargo frm = new FrmModificarCargo();
            frm.CargarDatosParaEdicion(id,cargo);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                MostrarDatos();
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCargos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un usuario para eliminar.");
                return;
            }

            int id = Convert.ToInt32(dgvCargos.CurrentRow.Cells["IdCargo"].Value);

            if (MessageBox.Show("¿Desea eliminar este usuario?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cn.deleteData(id);
                MostrarDatos();
            }
        }

        private void FrmCargos_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }
    }
}
