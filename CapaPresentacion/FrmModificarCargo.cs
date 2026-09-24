using CapaDatos;
using CapaNegocio;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmModificarCargo : Form
    {
        CargoNegocio cn = new CargoNegocio();
        private int idCargo = 0;
        public FrmModificarCargo()
        {
            InitializeComponent();
        }

        public void CargarDatos(int idCargo, string cargo)
        {
            idCargo.ToString();
            txtCargo.Text = cargo;
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCargo.Text))
            {
                MessageBox.Show("Ingrese el nombre del cargo", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            cn.updateData(idCargo, txtCargo.Text.Trim());
            MessageBox.Show("Cargo modificado correctamente", "Cargos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void FrmModificarCargo_Load(object sender, EventArgs e)
        {
           
        }

        public void CargarDatosParaEdicion(int IdCargo, string Cargo)
        {
            idCargo = IdCargo;
            txtCargo.Text = Cargo;
            txtIdCargo.Text = IdCargo.ToString();
        }
    }
}
