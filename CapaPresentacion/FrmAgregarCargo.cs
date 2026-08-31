using CapaDatos;
using CapaNegocio;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmAgregarCargo : Form
    {
        CargoNegocio cn = new CargoNegocio();
        private int idCargo = 0;
        public FrmAgregarCargo()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCargo.Text))
            {
                MessageBox.Show("Ingrese el nombre del cargo", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cn.insertData(txtCargo.Text.Trim());
            MessageBox.Show("Cargo guardado correctamente", "Cargos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void FrmAgregarCargo_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCargo.Text))
            {
                MessageBox.Show("Ingrese un cargo", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (idCargo == 0)
                {
                    // INSERTAR
                    cn.insertData(
                        txtCargo.Text.Trim()
                        );
                }
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        
    }
}
