using CapaDatos;
using CapaDatos_;
using CapaNegocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmModificarUsuario : Form
    {
        private UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
        private CargoService sr = new CargoService();
        private int idUsuario;
        private int idCargoSeleccionado;
        public FrmModificarUsuario()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el Nombre Completo del empleado", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("Ingrese el nombre del usuario", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtClave.Text))
            {
                MessageBox.Show("Ingrese la clave del usuario", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDUI.Text))
            {
                MessageBox.Show("Ingrese el DUI del Empleado", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                int idCargo = Convert.ToInt32(cboRol.SelectedValue);
                int activo = ChkActivo.Checked ? 1 : 0; // ajusta al control que uses

                if (idUsuario != 0)
                {
                    // ACTUALIZAR
                    usuarioNegocio.updateData(
                        idUsuario,
                        txtNombre.Text.Trim(),
                        txtDUI.Text.Trim(),
                        txtUsuario.Text.Trim(),
                        txtClave.Text.Trim(),
                        txtTelefono.Text.Trim(),
                        idCargo,
                        activo
                    );
                }
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void FrmModificarUsuario_Load(object sender, EventArgs e)
        {
            CargarRoles();//Cargamos el combo box

            if (idCargoSeleccionado > 0)
            {
                cboRol.SelectedValue = idCargoSeleccionado;
            }
        }

        //Metodo para cargar el combo box de los roles activos
        public void CargarRoles()
        {
            try
            {
                DataTable dt = sr.ObtenerCategorias();
                cboRol.DisplayMember = "Cargo";
                cboRol.ValueMember = "IdCargo";
                cboRol.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el combo box" + ex.Message);
            }
        }

        public void CargarDatosParaEdicion(int id, string nombre, string dui, string usuario, string clave, string telefono, int idCargo, int activo)
        {
            idUsuario = id;
            txtNombre.Text = nombre;
            txtDUI.Text = dui;
            txtUsuario.Text = usuario;
            txtClave.Text = clave;
            txtTelefono.Text = telefono;
            ChkActivo.Checked = activo == 1;

            idCargoSeleccionado = idCargo;
        }
    }
}
