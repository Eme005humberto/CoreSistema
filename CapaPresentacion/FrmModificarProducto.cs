using CapaNegocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmModificarProducto : Form
    {
        ProductosNegocio pr = new ProductosNegocio();
        private int IdProducto;
        public FrmModificarProducto()
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

            pr.updateData(producto, stock, idCategoria, precio, IdProducto);
            MessageBox.Show("Producto actualizado correctamente", "Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void FrmModificarProducto_Load(object sender, EventArgs e)
        {
            CargarCategorias();
        }
        public void CargarCategorias()
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

        public void CargarDatosParaEdicion(int idProducto, string Producto, decimal Precio, int Stock, int IdCategoria)
        {
            IdProducto = idProducto;
            txtProducto.Text = Producto;
            txtPrecio.Value = Precio;
            txtStock.Value = Stock;

            CargarCategorias();               // se recarga por si acaso (igual que CargarRoles en FrmAgregarUsuario)
            cboCategoria.SelectedValue = IdCategoria;
        }

    }
}
