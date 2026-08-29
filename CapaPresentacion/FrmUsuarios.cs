
using CapaNegocio;
using DevExpress.XtraPrinting;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmUsuarios : Form
    {
        private string id = null;
        private bool editar = false;
        UsuarioNegocio us = new UsuarioNegocio();
        public void MostrarDatos()
        {
            UsuarioNegocio pr = new UsuarioNegocio();
            dgvUsuarios.DataSource = pr.MostrarInformacion();
        }

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
            //Validamos si hemos seleccionado un registro
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un usuario para editar.");
                return;
            }

            // Extraemos los datos de la fila seleccionada del DataGridView
            int id = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["IdUsuario"].Value);
            string nombre = dgvUsuarios.CurrentRow.Cells["NombreCompleto"].Value.ToString();
            string dui = dgvUsuarios.CurrentRow.Cells["DUI"].Value.ToString();
            string usuario = dgvUsuarios.CurrentRow.Cells["Usuario"].Value.ToString();
            string clave = dgvUsuarios.CurrentRow.Cells["Clave"].Value.ToString();
            string telefono = dgvUsuarios.CurrentRow.Cells["Telefono"].Value.ToString();
            int idCargo = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["IdCargo"].Value);
            int activo = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["Activo"].Value);

            FrmModificarUsuario frm = new FrmModificarUsuario();
            frm.CargarDatosParaEdicion(id, nombre, dui, usuario, clave, telefono, idCargo, activo);

            if(frm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Usuario modificado correctamente.");
                MostrarDatos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un usuario para eliminar.");
                return;
            }

            int id = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["IdUsuario"].Value);

            if (MessageBox.Show("¿Desea eliminar este usuario?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                us.deleteData(id);
                MostrarDatos();
            }
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }
    }
}
