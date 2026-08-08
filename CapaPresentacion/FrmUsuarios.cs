
using CapaNegocio;
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
            using (var form = new FrmModificarUsuario())
            {
                form.ShowDialog(this);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seleccione un usuario para eliminar", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }
    }
}
