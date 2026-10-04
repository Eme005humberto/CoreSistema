using CapaDatos;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmCompras : Form
    {
        private readonly ProductosNegocio productosNegocio = new ProductosNegocio();
        private readonly ProveedorNegocio proveedorNegocio = new ProveedorNegocio();
        private readonly CompraNegocio compraNegocio = new CompraNegocio();

        private DataTable dtCatalogo;
        private DataTable dtCarrito;
        private DataTable dtProveedoresActual;
        private readonly List<int> idsSugeridos = new List<int>();
        private readonly List<int> idsProveedores = new List<int>();

        private int idProductoSeleccionado;
        private int idProveedorSeleccionado;
        private bool suprimirBusqueda;

        public FrmCompras()
        {
            InitializeComponent();
        }

        #region Carga

        private void FrmCompras_Load(object sender, EventArgs e)
        {
            CrearCarrito();
            dgvCompras.DataSource = dtCarrito;
            ConfigurarColumnas();

            CargarCatalogo();
            OcultarSugerencias();
            CargarProveedores();
            OcultarListaProveedores();
            CalcularTotal();
        }

        private void CrearCarrito()
        {
            dtCarrito = new DataTable();
            dtCarrito.Columns.Add("IdProducto", typeof(int));
            dtCarrito.Columns.Add("Producto", typeof(string));
            dtCarrito.Columns.Add("Cantidad", typeof(int));
            dtCarrito.Columns.Add("Precio", typeof(decimal));
            dtCarrito.Columns.Add("Subtotal", typeof(decimal));
        }

        private void ConfigurarColumnas()
        {
            if (dgvCompras.Columns.Contains("IdProducto"))
                dgvCompras.Columns["IdProducto"].Visible = false;

            if (dgvCompras.Columns.Contains("Subtotal"))
                dgvCompras.Columns["Subtotal"].Visible = false;

            if (dgvCompras.Columns.Contains("Producto"))
                dgvCompras.Columns["Producto"].ReadOnly = true;

            if (dgvCompras.Columns.Contains("Cantidad"))
                dgvCompras.Columns["Cantidad"].ReadOnly = true;

            if (dgvCompras.Columns.Contains("Precio"))
            {
                dgvCompras.Columns["Precio"].ReadOnly = false;
                dgvCompras.Columns["Precio"].HeaderText = "Precio compra";
            }
        }

        private void FrmCompras_MouseDown(object sender, MouseEventArgs e)
        {
            Control control = this.GetChildAtPoint(e.Location);

            while (control != null)
            {
                if (control == pnlSugerencias || control == pnlProveedores)
                    return;

                control = control.Parent;
            }

            OcultarSugerencias();
            OcultarListaProveedores();
        }

        #endregion

        #region Catalogo y proveedores

        private void CargarCatalogo()
        {
            try
            {
                dtCatalogo = productosNegocio.MostrarInformacion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los productos: " + ex.Message,
                    "Compras", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FiltrarSugerencias();
        }

        private void CargarProveedores()
        {
            DataTable dtProveedores;

            try
            {
                dtProveedores = proveedorNegocio.MostrarProveedor();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los proveedores: " + ex.Message,
                    "Compras", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dtProveedores == null || dtProveedores.Rows.Count == 0)
            {
                MessageBox.Show("No hay proveedores registrados. Registre uno en el modulo de Proveedores.",
                    "Compras", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OcultarListaProveedores();
            OcultarSugerencias();
            dtProveedoresActual = dtProveedores;
            FiltrarProveedores();
        }

        #endregion

        #region Selector de proveedores

        private void OcultarListaProveedores()
        {
            pnlProveedores.Visible = false;
        }

        private void txtProveedor_MouseClick(object sender, MouseEventArgs e)
        {
            if (!pnlProveedores.Visible)
                FiltrarProveedores();
        }

        private void btnFlechaProveedor_Click(object sender, EventArgs e)
        {
            if (pnlProveedores.Visible)
            {
                OcultarListaProveedores();
                return;
            }

            OcultarSugerencias();
            FiltrarProveedores();

            if (lstProveedores.Items.Count > 0)
                pnlProveedores.Visible = true;
        }

        private void txtProveedor_TextChanged(object sender, EventArgs e)
        {
            FiltrarProveedores();
        }

        private void txtProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                OcultarListaProveedores();
                return;
            }

            if (e.KeyCode != Keys.Enter || lstProveedores.Items.Count == 0)
                return;

            e.SuppressKeyPress = true;

            int indice = lstProveedores.SelectedIndex >= 0
                ? lstProveedores.SelectedIndex
                : 0;

            SeleccionarProveedor(indice);
        }

        private void FiltrarProveedores()
        {
            if (dtProveedoresActual == null || suprimirBusqueda)
                return;

            string texto = txtProveedor.Text.Trim();

            lstProveedores.BeginUpdate();
            try
            {
                lstProveedores.Items.Clear();
                idsProveedores.Clear();

                foreach (DataRow fila in dtProveedoresActual.Rows)
                {
                    string nombre = fila["Proveedor"].ToString();

                    if (texto.Length > 0 &&
                        nombre.IndexOf(texto, StringComparison.OrdinalIgnoreCase) < 0)
                    {
                        continue;
                    }

                    lstProveedores.Items.Add(nombre);
                    idsProveedores.Add(Convert.ToInt32(fila["IdProveedor"]));
                }
            }
            finally
            {
                lstProveedores.EndUpdate();
            }

            if (lstProveedores.Items.Count > 0)
            {
                pnlProveedores.Visible = true;
                pnlProveedores.BringToFront();
            }
            else
            {
                OcultarListaProveedores();
            }
        }

        private void lstProveedores_MouseClick(object sender, MouseEventArgs e)
        {
            int indice = lstProveedores.IndexFromPoint(e.Location);
            if (indice < 0)
                return;

            SeleccionarProveedor(indice);
        }

        private void lstProveedores_DoubleClick(object sender, EventArgs e)
        {
            int indice = lstProveedores.SelectedIndex >= 0 ? lstProveedores.SelectedIndex : 0;
            SeleccionarProveedor(indice);
            txtBuscar.Focus();
        }

        private void SeleccionarProveedor(int indice)
        {
            if (indice < 0 || indice >= idsProveedores.Count)
                return;

            suprimirBusqueda = true;
            try
            {
                lstProveedores.SelectedIndex = indice;
                idProveedorSeleccionado = idsProveedores[indice];
                txtProveedor.Text = lstProveedores.Items[indice].ToString();
                txtProveedor.SelectionStart = txtProveedor.TextLength;
            }
            finally
            {
                suprimirBusqueda = false;
            }

            OcultarListaProveedores();
            txtBuscar.Focus();
        }

        #endregion

        #region Busqueda de productos

        private void OcultarSugerencias()
        {
            pnlSugerencias.Visible = false;
        }

        private void txtBuscar_MouseClick(object sender, MouseEventArgs e)
        {
            if (!pnlSugerencias.Visible)
                FiltrarSugerencias();
        }

        private void btnFlecha_Click(object sender, EventArgs e)
        {
            if (pnlSugerencias.Visible)
            {
                OcultarSugerencias();
                return;
            }

            OcultarListaProveedores();
            FiltrarSugerencias();

            if (lstSugerencias.Items.Count > 0)
                pnlSugerencias.Visible = true;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            FiltrarSugerencias();
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                OcultarSugerencias();
                return;
            }

            if (e.KeyCode != Keys.Enter || lstSugerencias.Items.Count == 0)
                return;

            e.SuppressKeyPress = true;
            AgregarAlCarrito();
        }

        private void FiltrarSugerencias()
        {
            if (dtCatalogo == null || suprimirBusqueda)
                return;

            string texto = txtBuscar.Text.Trim();

            lstSugerencias.BeginUpdate();
            try
            {
                lstSugerencias.Items.Clear();
                idsSugeridos.Clear();

                foreach (DataRow fila in dtCatalogo.Rows)
                {
                    string nombre = fila["Producto"].ToString();

                    if (texto.Length > 0 &&
                        nombre.IndexOf(texto, StringComparison.OrdinalIgnoreCase) < 0)
                    {
                        continue;
                    }

                    lstSugerencias.Items.Add(nombre);
                    idsSugeridos.Add(Convert.ToInt32(fila["IdProducto"]));
                }
            }
            finally
            {
                lstSugerencias.EndUpdate();
            }

            if (lstSugerencias.Items.Count > 0)
            {
                pnlSugerencias.Visible = true;
                pnlSugerencias.BringToFront();
            }
            else
            {
                OcultarSugerencias();
            }
        }

        private void lstSugerencias_MouseClick(object sender, MouseEventArgs e)
        {
            int indice = lstSugerencias.IndexFromPoint(e.Location);
            if (indice < 0 || indice >= idsSugeridos.Count)
                return;

            suprimirBusqueda = true;
            try
            {
                lstSugerencias.SelectedIndex = indice;
                idProductoSeleccionado = idsSugeridos[indice];
                txtBuscar.Text = lstSugerencias.Items[indice].ToString();
                txtBuscar.SelectionStart = txtBuscar.TextLength;
            }
            finally
            {
                suprimirBusqueda = false;
            }

            OcultarSugerencias();
        }

        private void lstSugerencias_DoubleClick(object sender, EventArgs e)
        {
            AgregarAlCarrito();
        }

        #endregion

        #region Carrito de compra

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarAlCarrito();
        }

        private void AgregarAlCarrito()
        {
            if (idProductoSeleccionado == 0 || dtCatalogo == null)
            {
                MessageBox.Show("Seleccione un producto de la lista", "Compras",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRow[] encontrado = dtCatalogo.Select("IdProducto = " + idProductoSeleccionado);
            if (encontrado.Length == 0)
            {
                MessageBox.Show("El producto ya no esta disponible", "Compras",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRow fila = encontrado[0];
            string nombre = fila["Producto"].ToString();
            decimal precio = Convert.ToDecimal(fila["Precio"]);
            int stock = Convert.ToInt32(fila["Stock"]);
            int cantidad = Convert.ToInt32(txtCantidad.Value);

            DataRow[] enCarrito = dtCarrito.Select("IdProducto = " + idProductoSeleccionado);

            if (enCarrito.Length > 0)
            {
                int cantidadActual = Convert.ToInt32(enCarrito[0]["Cantidad"]);
                int nuevaCantidad = cantidadActual + cantidad;

                enCarrito[0]["Cantidad"] = nuevaCantidad;
                enCarrito[0]["Subtotal"] = precio * nuevaCantidad;
            }
            else
            {
                dtCarrito.Rows.Add(idProductoSeleccionado, nombre, cantidad, precio, precio * cantidad);
            }

            CalcularTotal();
            LimpiarBuscador();
        }

        private void LimpiarBuscador()
        {
            suprimirBusqueda = true;
            try
            {
                txtBuscar.Text = "";
                lstSugerencias.Items.Clear();
                lstSugerencias.SelectedIndex = -1;
                idsSugeridos.Clear();
            }
            finally
            {
                suprimirBusqueda = false;
            }

            OcultarSugerencias();
            idProductoSeleccionado = 0;
            txtCantidad.Value = 1;
            txtBuscar.Focus();
        }

        private void dgvCompras_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            string nombre = dgvCompras.Rows[e.RowIndex].Cells["Producto"].Value.ToString();
            dtCarrito.Rows.RemoveAt(e.RowIndex);
            CalcularTotal();
            MessageBox.Show("Se quito " + nombre + " de la compra", "Compras",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvCompras_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || !dgvCompras.Columns[e.ColumnIndex].Name.Equals("Precio"))
                return;

            int cantidad = Convert.ToInt32(dtCarrito.Rows[e.RowIndex]["Cantidad"]);

            try
            {
                decimal precio = Convert.ToDecimal(dgvCompras.Rows[e.RowIndex].Cells["Precio"].Value);

                if (precio <= 0)
                    throw new FormatException();

                dtCarrito.Rows[e.RowIndex]["Precio"] = precio;
                dtCarrito.Rows[e.RowIndex]["Subtotal"] = precio * cantidad;
            }
            catch (Exception)
            {
                MessageBox.Show("El precio debe ser un numero mayor que cero", "Compras",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                dtCarrito.Rows[e.RowIndex]["Precio"] =
                    Convert.ToDecimal(dtCarrito.Rows[e.RowIndex]["Precio"]);
            }

            dgvCompras.CancelEdit();
            CalcularTotal();
        }

        private void CalcularTotal()
        {
            decimal total = 0;

            foreach (DataRow fila in dtCarrito.Rows)
                total += Convert.ToDecimal(fila["Subtotal"]);

            lblTotalValor.Text = total.ToString("N2");
            lblModo.Text = "Carrito (" + dtCarrito.Rows.Count + ")";
        }

        #endregion

        #region Registro de la compra

        private void btnComprar_Click(object sender, EventArgs e)
        {
            OcultarSugerencias();
            OcultarListaProveedores();

            if (idProveedorSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un proveedor", "Compras",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProveedor.Focus();
                return;
            }

            if (dtCarrito.Rows.Count == 0)
            {
                MessageBox.Show("Agregue al menos un producto a la compra", "Compras",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBuscar.Focus();
                return;
            }

            DialogResult resp = MessageBox.Show(
                "Desea registrar la compra por " + lblTotalValor.Text + " ?",
                "Compras", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resp != DialogResult.Yes)
                return;

            int registradas = 0;

            try
            {
                foreach (DataRow fila in dtCarrito.Rows)
                {
                    COMPRAS compra = new COMPRAS
                    {
                        oProductos = new PRODUCTOS { IdProducto = Convert.ToInt32(fila["IdProducto"]) },
                        Cantidad = Convert.ToInt32(fila["Cantidad"]),
                        Precio = Convert.ToDecimal(fila["Precio"]),
                        Total = Convert.ToDecimal(fila["Subtotal"]),
                        IdProveedor = idProveedorSeleccionado
                    };

                    compraNegocio.RealizarCompra(compra);
                    registradas++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Se registraron " + registradas + " de " + dtCarrito.Rows.Count +
                    " productos.\n\nDetalle: " + ex.Message, "Compras",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (registradas == dtCarrito.Rows.Count)
            {
                MessageBox.Show("Compra registrada correctamente", "Compras",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dtCarrito.Rows.Clear();
            CalcularTotal();
            LimpiarBuscador();
            CargarCatalogo();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            OcultarSugerencias();
            OcultarListaProveedores();

            if (dtCarrito.Rows.Count == 0)
                return;

            DialogResult resp = MessageBox.Show("Desea cancelar la compra actual?", "Compras",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resp != DialogResult.Yes)
                return;

            dtCarrito.Rows.Clear();
            CalcularTotal();
            LimpiarBuscador();
        }

        #endregion
    }
}