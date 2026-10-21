
using CapaNegocio;
using DevExpress.XtraPrinting;
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmUsuarios : Form
    {
        
        UsuarioNegocio us = new UsuarioNegocio();
        private void MostrarDatos()
        {
            UsuarioNegocio pr = new UsuarioNegocio();
            dgvUsuarios.DataSource = pr.MostrarInformacion();
            FiltrarUsuarios();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            FiltrarUsuarios();
        }

        private void FiltrarUsuarios()
        {
            DataTable dt = dgvUsuarios.DataSource as DataTable;
            if (dt == null) return;

            string texto = txtBuscar.Text.Trim().Replace("'", "''");
            dt.DefaultView.RowFilter = texto.Length == 0
                ? string.Empty
                : $"NombreCompleto LIKE '%{texto}%' OR Usuario LIKE '%{texto}%'";
        }

        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (var form = new FrmAgregarUsuario())
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    MostrarDatos(); // refresca el grid despu�s de agregar
                }
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

            if (MessageBox.Show("�Desea eliminar este usuario?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                us.deleteData(id);
                MostrarDatos();
            }
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            MostrarDatos();
            if (dgvUsuarios.Columns.Contains("IdCargo"))
                dgvUsuarios.Columns["IdCargo"].Visible = false;
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
