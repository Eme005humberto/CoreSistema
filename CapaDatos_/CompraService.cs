using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using CapaDatos;

namespace CapaDatos_
{
    public class CompraService
    {
        Conexion conexion = new Conexion();

        SqlDataReader leer;
        DataTable table = new DataTable();
        SqlCommand cmd = new SqlCommand();

        public void RealizarCompra(COMPRAS compra)
        {
            using (SqlConnection con = Conexion.Conectar())
            {
                SqlTransaction transaccion = con.BeginTransaction();

                try
                {
                    // 1. Insertar la compra
                    string queryCompra = @"
                INSERT INTO COMPRAS
                (IdProducto, Cantidad, Precio, Total, IdProveedor)
                VALUES
                (@IdProducto, @Cantidad, @Precio, @Total, @IdProveedor);

                SELECT SCOPE_IDENTITY();";

                    int idCompra;

                    using (SqlCommand cmdCompra = new SqlCommand(queryCompra, con, transaccion))
                    {
                        cmdCompra.Parameters.AddWithValue("@IdProducto", compra.oProductos.IdProducto);
                        cmdCompra.Parameters.AddWithValue("@Cantidad", compra.Cantidad);
                        cmdCompra.Parameters.AddWithValue("@Precio", compra.Precio);
                        cmdCompra.Parameters.AddWithValue("@Total", compra.Total);
                        cmdCompra.Parameters.AddWithValue("@IdProveedor", compra.IdProveedor);

                        idCompra = Convert.ToInt32(cmdCompra.ExecuteScalar());
                    }

                    // 2. Insertar el detalle de la compra
                    string queryDetalle = @"
                INSERT INTO DETALLE_COMPRA
                (IdCompra, IdProducto, PrecioUnitario, Cantidad, IdProveedor)
                VALUES
                (@IdCompra, @IdProducto, @PrecioUnitario, @Cantidad, @IdProveedor)";

                    using (SqlCommand cmdDetalle = new SqlCommand(queryDetalle, con, transaccion))
                    {
                        cmdDetalle.Parameters.AddWithValue("@IdCompra", idCompra);
                        cmdDetalle.Parameters.AddWithValue("@IdProducto", compra.oProductos.IdProducto);
                        cmdDetalle.Parameters.AddWithValue("@PrecioUnitario", compra.Precio);
                        cmdDetalle.Parameters.AddWithValue("@Cantidad", compra.Cantidad);
                        cmdDetalle.Parameters.AddWithValue("@IdProveedor", compra.IdProveedor);

                        cmdDetalle.ExecuteNonQuery();
                    }

                    // 3. Actualizar el stock
                    string queryStock = @"
                UPDATE PRODUCTOS
                SET Stock = Stock + @Cantidad
                WHERE IdProducto = @IdProducto";

                    using (SqlCommand cmdStock = new SqlCommand(queryStock, con, transaccion))
                    {
                        cmdStock.Parameters.AddWithValue("@Cantidad", compra.Cantidad);
                        cmdStock.Parameters.AddWithValue("@IdProducto", compra.oProductos.IdProducto);

                        cmdStock.ExecuteNonQuery();
                    }

                    // 4. Confirmar la transacción
                    transaccion.Commit();
                }
                catch (Exception ex)
                {
                    // Si algo falla, deshacemos todo
                    transaccion.Rollback();

                    throw new Exception("Error al realizar la compra: " + ex.Message);
                }
            }
        }
    }
}
