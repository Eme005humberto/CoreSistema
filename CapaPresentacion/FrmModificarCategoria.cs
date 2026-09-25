using CapaDatos;
using CapaNegocio;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmModificarCategoria : Form
    {
        CategoriaNegocio cn = new CategoriaNegocio();
        private int idCategoria = 0;
        public FrmModificarCategoria()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)   
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre de la categoria", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            cn.updateData(idCategoria,txtNombre.Text);
            MessageBox.Show("Cargo modificado correctamente", "Cargos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
        }

        public void CargarDatosParaEdicion(int IdCategoria, string Categoria)
        {
            idCategoria = IdCategoria;
            txtNombre.Text = Categoria;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
