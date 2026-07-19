using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmReportes : Form
    {
        public FrmReportes()
        {
            InitializeComponent();
        }

        private void btnReporteVentas_Click(object sender, EventArgs e)
        {
            using (var form = new FrmReporteVentas())
            {
                form.ShowDialog(this);
            }
        }

        private void btnReporteCompras_Click(object sender, EventArgs e)
        {
            using (var form = new FrmReporteCompras())
            {
                form.ShowDialog(this);
            }
        }
    }
}
