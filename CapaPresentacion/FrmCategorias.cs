using CapaNegocio;
using System;
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
                    MostrarDatos(); // refresca el grid después de agregar
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una categoría para modificar.");
                return;
            }

            int id = Convert.ToInt32(dgvCategorias.CurrentRow.Cells["IdCategoria"].Value);
            string categoria = dgvCategorias.CurrentRow.Cells["Categoria"].Value.ToString();

            using (var form = new FrmModificarCategoria())
            {
                form.CargarDatosParaEdicion(id, categoria);

                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    MostrarDatos(); // refresca el grid después de modificar
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seleccione una categoria para eliminar", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            MostrarDatos(); //Invocamos el metodo para cargar las categorias 
        }

        private void MostrarDatos()
        {
            CargoNegocio cn = new CargoNegocio();
            dgvCategorias.DataSource = nc.MostrarCategorias();
        }
    }
}
