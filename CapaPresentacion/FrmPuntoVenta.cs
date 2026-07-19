using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmPuntoVenta : Form
    {
        private Form _formularioActual;

        public FrmPuntoVenta()
        {
            InitializeComponent();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvCarrito.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(38, 33, 92);
            dgvCarrito.ThemeStyle.HeaderStyle.ForeColor = Color.FromArgb(238, 237, 254);
            dgvCarrito.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvCarrito.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(230, 228, 250);
        }

        private void CerrarFormularioActual()
        {
            if (_formularioActual != null)
            {
                pnlContenido.Controls.Remove(_formularioActual);
                _formularioActual.Close();
                _formularioActual.Dispose();
                _formularioActual = null;
            }
        }

        private void AbrirFormulario(Form formulario)
        {
            CerrarFormularioActual();
            pnlVentas.Visible = false;

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            pnlContenido.Controls.Add(formulario);
            formulario.Show();

            _formularioActual = formulario;
        }

        private void MostrarVentas()
        {
            CerrarFormularioActual();
            pnlVentas.Visible = true;
            pnlVentas.BringToFront();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmInventario());
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            MostrarVentas();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmProveedores());
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmCategorias());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmReportes());
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmUsuarios());
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmCompras());
        }
    }
}
