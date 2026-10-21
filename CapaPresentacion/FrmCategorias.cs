using CapaNegocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmCategorias : Form
    {
        CategoriaNegocio nc = new CategoriaNegocio();
        public FrmCategorias()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (var form = new FrmAgregarCategoria())
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    MostrarDatos(); // refresca el grid despu�s de agregar
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una categor�a para modificar.");
                return;
            }

            int id = Convert.ToInt32(dgvCategorias.CurrentRow.Cells["IdCategoria"].Value);
            string categoria = dgvCategorias.CurrentRow.Cells["Categoria"].Value.ToString();

            using (var form = new FrmModificarCategoria())
            {
                form.CargarDatosParaEdicion(id, categoria);

                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    MostrarDatos(); // refresca el grid despu�s de modificar
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una categoria para eliminar.");
                return;
            }

            int id = Convert.ToInt32(dgvCategorias.CurrentRow.Cells["IdCategoria"].Value);

            if (MessageBox.Show("�Desea eliminar esta categoria?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                nc.deleteData(id);
                MostrarDatos();
            }
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            MostrarDatos(); //Invocamos el metodo para cargar las categorias 
        }

        private void MostrarDatos()
        {
            CargoNegocio cn = new CargoNegocio();
            dgvCategorias.DataSource = nc.MostrarCategorias();
            FiltrarCategorias();
        }

        private void txtBuscarCategoria_TextChanged(object sender, EventArgs e)
        {
            FiltrarCategorias();
        }

        private void FiltrarCategorias()
        {
            DataTable dt = dgvCategorias.DataSource as DataTable;
            if (dt == null) return;

            string texto = txtBuscarCategoria.Text.Trim().Replace("'", "''");
            dt.DefaultView.RowFilter = texto.Length == 0
                ? string.Empty
                : $"Categoria LIKE '%{texto}%'";
        }
    }
}
