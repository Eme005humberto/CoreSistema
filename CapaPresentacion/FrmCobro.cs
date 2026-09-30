using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmCobro : Form
    {
        public decimal Total { get; private set; }
        public decimal MontoRecibido { get; private set; }
        public decimal Cambio { get; private set; }

        public FrmCobro(decimal total)
        {
            InitializeComponent();
            Total = total;
            lblTotal.Text = total.ToString("C2");
            numRecibido.Value = total;
            CalcularCambio();
        }

        private void CalcularCambio()
        {
            decimal recibido = numRecibido.Value;
            Cambio = recibido - Total;
            lblCambio.Text = Cambio < 0 ? "Insuficiente" : Cambio.ToString("C2");
            btnCobrar.Enabled = recibido >= Total;
        }

        private void numRecibido_ValueChanged(object sender, EventArgs e)
        {
            CalcularCambio();
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (numRecibido.Value < Total)
            {
                MessageBox.Show("El monto recibido es menor al total", "Cobro",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MontoRecibido = numRecibido.Value;
            Cambio = MontoRecibido - Total;
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
