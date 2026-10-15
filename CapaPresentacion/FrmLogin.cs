using CapaNegocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmLogin : Form
    {
        private readonly UsuarioNegocio usuarioNegocio = new UsuarioNegocio();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string clave = txtClave.Text;

            if (string.IsNullOrWhiteSpace(usuario))
            {
                MessageBox.Show("Ingrese el usuario", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(clave))
            {
                MessageBox.Show("Ingrese la clave", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClave.Focus();
                return;
            }

            try
            {
                DataTable resultado = usuarioNegocio.Login(usuario, clave);

                if (resultado.Rows.Count > 0)
                {
                    DataRow fila = resultado.Rows[0];
                    Sesion.IdUsuario = Convert.ToInt32(fila["IdUsuario"]);
                    Sesion.NombreCompleto = Convert.ToString(fila["NombreCompleto"]);
                    Sesion.IdCargo = Convert.ToInt32(fila["IdCargo"]);
                    Sesion.Cargo = Convert.ToString(fila["Cargo"]);

                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show(
                        "Usuario o clave incorrectos, o el usuario esta inactivo.",
                        "Acceso denegado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    txtClave.Clear();
                    txtClave.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo validar el acceso: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtClave.Focus();
            }
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnIngresar.PerformClick();
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }
    }
}