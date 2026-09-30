using CapaDatos;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmPuntoVenta : Form
    {
        private Form _formularioActual;
        private readonly ProductosNegocio productosNegocio = new ProductosNegocio();
        private readonly VentaNegocio ventaNegocio = new VentaNegocio();

        private DataTable dtCatalogo;
        private DataTable dtCarrito;
        private readonly List<int> idsCatalogo = new List<int>();
        private int idProductoSeleccionado;
        private bool suprimirBusqueda;

        public FrmPuntoVenta()
        {
            InitializeComponent();
        }

        #region Navegacion entre modulos

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

            CargarCatalogo();
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

        private void btnCargos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmCargos());
        }

        #endregion

        #region Busqueda de productos

        private void FrmPuntoVenta_Load(object sender, EventArgs e)
        {
            CrearCarrito();
            dgvCarrito.DataSource = dtCarrito;
            OcultarColumnasInternas();

            CargarCatalogo();
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

        private void CargarCatalogo()
        {
            try
            {
                dtCatalogo = productosNegocio.MostrarInformacion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los productos: " + ex.Message,
                    "Punto de Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CargarItemsCombo();
        }

        private void CargarItemsCombo()
        {
            suprimirBusqueda = true;
            try
            {
                lstSugerencias.Items.Clear();
                idsCatalogo.Clear();

                if (dtCatalogo == null)
                    return;

                foreach (DataRow fila in dtCatalogo.Rows)
                {
                    if (Convert.ToInt32(fila["Stock"]) <= 0)
                        continue;

                    lstSugerencias.Items.Add(fila["Producto"].ToString());
                    idsCatalogo.Add(Convert.ToInt32(fila["IdProducto"]));
                }
            }
            finally
            {
                suprimirBusqueda = false;
            }

            OcultarSugerencias();
            idProductoSeleccionado = 0;
        }

        private void OcultarSugerencias()
        {
            pnlSugerencias.Visible = false;
        }

        private void cboBuscarProducto_MouseClick(object sender, MouseEventArgs e)
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

            FiltrarSugerencias();

            if (lstSugerencias.Items.Count > 0)
                pnlSugerencias.Visible = true;
        }

        private void cboBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            FiltrarSugerencias();
        }

        private void FiltrarSugerencias()
        {
            if (dtCatalogo == null || suprimirBusqueda)
                return;

            string texto = cboBuscarProducto.Text.Trim();

            lstSugerencias.BeginUpdate();
            try
            {
                lstSugerencias.Items.Clear();
                idsCatalogo.Clear();

                foreach (DataRow fila in dtCatalogo.Rows)
                {
                    if (Convert.ToInt32(fila["Stock"]) <= 0)
                        continue;

                    string nombre = fila["Producto"].ToString();

                    if (texto.Length > 0 &&
                        nombre.IndexOf(texto, StringComparison.OrdinalIgnoreCase) < 0)
                    {
                        continue;
                    }

                    lstSugerencias.Items.Add(nombre);
                    idsCatalogo.Add(Convert.ToInt32(fila["IdProducto"]));
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
            if (indice < 0 || indice >= idsCatalogo.Count)
                return;

            suprimirBusqueda = true;
            try
            {
                lstSugerencias.SelectedIndex = indice;
                idProductoSeleccionado = idsCatalogo[indice];
                cboBuscarProducto.Text = lstSugerencias.Items[indice].ToString();
                cboBuscarProducto.SelectionStart = cboBuscarProducto.TextLength;
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

        private void ObtenerProductoSeleccionado(out string nombre, out int stock, out decimal precio)
        {
            nombre = null;
            stock = 0;
            precio = 0;

            if (idProductoSeleccionado == 0 || dtCatalogo == null)
                return;

            DataRow[] encontrado = dtCatalogo.Select("IdProducto = " + idProductoSeleccionado);
            if (encontrado.Length == 0)
                return;

            DataRow fila = encontrado[0];
            nombre = fila["Producto"].ToString();
            stock = Convert.ToInt32(fila["Stock"]);
            precio = Convert.ToDecimal(fila["Precio"]);
        }

        #endregion

        #region Carrito de venta

        private void OcultarColumnasInternas()
        {
            if (dgvCarrito.Columns.Contains("IdProducto"))
                dgvCarrito.Columns["IdProducto"].Visible = false;
            if (dgvCarrito.Columns.Contains("IdCategoria"))
                dgvCarrito.Columns["IdCategoria"].Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarAlCarrito();
        }

        private void AgregarAlCarrito()
        {
            string nombre;
            int stock;
            decimal precio;

            ObtenerProductoSeleccionado(out nombre, out stock, out precio);

            if (nombre == null)
            {
                MessageBox.Show("Seleccione un producto de la lista", "Punto de Venta",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (stock <= 0)
            {
                MessageBox.Show("El producto no tiene stock disponible", "Punto de Venta",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int cantidad = Convert.ToInt32(txtCantidad.Value);
            DataRow[] enCarrito = dtCarrito.Select("IdProducto = " + idProductoSeleccionado);

            if (enCarrito.Length > 0)
            {
                int cantidadActual = Convert.ToInt32(enCarrito[0]["Cantidad"]);
                if (cantidadActual + cantidad > stock)
                {
                    MessageBox.Show("Stock insuficiente. Disponible: " + stock, "Punto de Venta",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int nuevaCantidad = cantidadActual + cantidad;
                enCarrito[0]["Cantidad"] = nuevaCantidad;
                enCarrito[0]["Subtotal"] = precio * nuevaCantidad;
            }
            else
            {
                if (cantidad > stock)
                {
                    MessageBox.Show("Stock insuficiente. Disponible: " + stock, "Punto de Venta",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

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
                cboBuscarProducto.Text = "";
                lstSugerencias.Items.Clear();
                lstSugerencias.SelectedIndex = -1;
                idsCatalogo.Clear();
            }
            finally
            {
                suprimirBusqueda = false;
            }

            OcultarSugerencias();
            idProductoSeleccionado = 0;
            txtCantidad.Value = 1;
            cboBuscarProducto.Focus();
        }

        private void dgvCarrito_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            string nombre = dgvCarrito.Rows[e.RowIndex].Cells["Producto"].Value.ToString();
            dtCarrito.Rows.RemoveAt(e.RowIndex);
            CalcularTotal();
            MessageBox.Show("Se quito " + nombre + " del carrito", "Punto de Venta",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CalcularTotal()
        {
            decimal total = 0;
            foreach (DataRow fila in dtCarrito.Rows)
                total += Convert.ToDecimal(fila["Subtotal"]);

            lblTotalValor.Text = total.ToString("N2");
            lblModo.Text = "Carrito (" + dtCarrito.Rows.Count + ")";
        }

        private void btnCancelarVenta_Click(object sender, EventArgs e)
        {
            if (dtCarrito.Rows.Count == 0)
                return;

            DialogResult resp = MessageBox.Show("Desea cancelar la venta actual?", "Punto de Venta",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resp != DialogResult.Yes)
                return;

            dtCarrito.Rows.Clear();
            CalcularTotal();
            LimpiarBuscador();
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (dtCarrito.Rows.Count == 0)
            {
                MessageBox.Show("El carrito esta vacio", "Punto de Venta",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal total = 0;
            foreach (DataRow fila in dtCarrito.Rows)
                total += Convert.ToDecimal(fila["Subtotal"]);

            using (var cobro = new FrmCobro(total))
            {
                if (cobro.ShowDialog(this) != DialogResult.OK)
                    return;

                try
                {
                    foreach (DataRow fila in dtCarrito.Rows)
                    {
                        VENTAS venta = new VENTAS
                        {
                            oProductos = new PRODUCTOS { IdProducto = Convert.ToInt32(fila["IdProducto"]) },
                            Cantidad = Convert.ToInt32(fila["Cantidad"]),
                            Precio = Convert.ToDecimal(fila["Precio"]),
                            Total = Convert.ToDecimal(fila["Subtotal"])
                        };

                        ventaNegocio.RealizarVenta(venta);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo registrar la venta: " + ex.Message,
                        "Punto de Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CargarCatalogo();
                    return;
                }

                MessageBox.Show("Venta registrada correctamente" + Environment.NewLine +
                    "Total: " + total.ToString("C2") + Environment.NewLine +
                    "Recibido: " + cobro.MontoRecibido.ToString("C2") + Environment.NewLine +
                    "Cambio: " + cobro.Cambio.ToString("C2"),
                    "Punto de Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dtCarrito.Rows.Clear();
                CalcularTotal();
                CargarCatalogo();
            }
        }

        #endregion
    }
}
