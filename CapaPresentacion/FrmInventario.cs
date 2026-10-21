using CapaNegocio;
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
    public partial class FrmInventario : Form
    {
        ProductosNegocio pr = new ProductosNegocio();
        public FrmInventario()
        {
            InitializeComponent();
        }

        private void MostrarDatos()
        {
            ProductosNegocio pr = new ProductosNegocio();
            dgvInventario.DataSource = pr.MostrarInformacion();
            FiltrarProductos();
        }

        private void txtBuscarInventario_TextChanged(object sender, EventArgs e)
        {
            FiltrarProductos();
        }

        private void FiltrarProductos()
        {
            DataTable dt = dgvInventario.DataSource as DataTable;
            if (dt == null) return;

            string texto = txtBuscarInventario.Text.Trim().Replace("'", "''");
            dt.DefaultView.RowFilter = texto.Length == 0
                ? string.Empty
                : $"Producto LIKE '%{texto}%'";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (var form = new FrmAgregarProducto())
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    MostrarDatos(); // refresca el grid después de agregar
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvInventario.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un producto para modificar.");
                return;
            }

            int id = Convert.ToInt32(dgvInventario.CurrentRow.Cells["IdProducto"].Value);
            string nombre = dgvInventario.CurrentRow.Cells["Producto"].Value.ToString();
            decimal precio = Convert.ToDecimal(dgvInventario.CurrentRow.Cells["Precio"].Value);
            int stock = Convert.ToInt32(dgvInventario.CurrentRow.Cells["Stock"].Value);
            int idCategoria = Convert.ToInt32(dgvInventario.CurrentRow.Cells["IdCategoria"].Value);

            using (var form = new FrmModificarProducto())
            {
                form.CargarDatosParaEdicion(id, nombre, precio, stock, idCategoria);

                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    MostrarDatos(); // refresca el grid después de modificar
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvInventario.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un producto para eliminar.");
                return;
            }

            int id = Convert.ToInt32(dgvInventario.CurrentRow.Cells["IdProducto"].Value);

            if (MessageBox.Show("¿Desea eliminar este Producto?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                pr.deleteData(id);
                MostrarDatos();
            }
        }

        private void FrmInventario_Load(object sender, EventArgs e)
        {
            MostrarDatos();
            if (dgvInventario.Columns.Contains("IdCategoria"))
                dgvInventario.Columns["IdCategoria"].Visible = false;
            if (dgvInventario.Columns.Contains("Categoria"))
                dgvInventario.Columns["Categoria"].HeaderText = "Categoria";
        }
    }
}
