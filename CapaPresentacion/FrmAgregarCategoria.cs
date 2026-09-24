using CapaNegocio;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmAgregarCategoria : Form
    {
        CategoriaNegocio nc = new CategoriaNegocio();
        public FrmAgregarCategoria()
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
           

            nc.insertData(txtNombre.Text.Trim());
            MessageBox.Show("Cargo guardado correctamente", "Cargos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
