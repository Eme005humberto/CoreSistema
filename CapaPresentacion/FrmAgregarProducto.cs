using CapaNegocio;
using DevExpress.XtraPrinting;
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmAgregarProducto : Form
    {
        ProductosNegocio pr = new ProductosNegocio();
        public FrmAgregarProducto()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProducto.Text))
            {
                MessageBox.Show("Ingrese el nombre del producto", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string producto = txtProducto.Text.Trim();
            decimal precio = txtPrecio.Value;                     // Guna2NumericUpDown.Value ya es decimal
            int stock = (int)txtStock.Value;                      // Guna2NumericUpDown.Value también es decimal, castealo a int si tu columna es entera
            int idCategoria = Convert.ToInt32(cboCategoria.SelectedValue); // asumiendo que ValueMember = "IdCategoria"

            pr.insertData(producto, stock, idCategoria, precio);
            MessageBox.Show("Producto guardado correctamente", "Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public void CargarProductos()
        {
            try
            {
                DataTable dt = pr.MostrarCategorias();
                cboCategoria.DisplayMember = "Categoria";
                cboCategoria.ValueMember = "IdCategoria";
                cboCategoria.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el combo box" + ex.Message);
            }
        }

        private void FrmAgregarProducto_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }
    }
}
