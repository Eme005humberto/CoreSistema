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
    public class VentaService
    {
        Conexion conexion = new Conexion();

        SqlDataReader leer;
        DataTable table = new DataTable();
        SqlCommand cmd = new SqlCommand();

        public void RealizarVenta(VENTAS venta)
        {
            using (SqlConnection con = Conexion.Conectar())
            {
                SqlTransaction transaccion = con.BeginTransaction();

                try
                {
                    // 1. Verificar que exista suficiente stock
                    string queryStock = @"
                SELECT Stock
                FROM PRODUCTOS
                WHERE IdProducto = @IdProducto";

                    int stockActual;

                    using (SqlCommand cmdStock = new SqlCommand(queryStock, con, transaccion))
                    {
                        cmdStock.Parameters.AddWithValue(
                            "@IdProducto",
                            venta.oProductos.IdProducto
                        );

                        object resultado = cmdStock.ExecuteScalar();

                        if (resultado == null)
                        {
                            throw new Exception("El producto no existe.");
                        }

                        stockActual = Convert.ToInt32(resultado);
                    }

                    if (stockActual < venta.Cantidad)
                    {
                        throw new Exception(
                            "Stock insuficiente. Stock disponible: " +
                            stockActual
                        );
                    }

                    // 2. Insertar la venta
                    string queryVenta = @"
                INSERT INTO VENTAS
                (IdProducto, Cantidad, Precio, Total)
                VALUES
                (@IdProducto, @Cantidad, @Precio, @Total);

                SELECT SCOPE_IDENTITY();";

                    int idVenta;

                    using (SqlCommand cmdVenta =
                           new SqlCommand(queryVenta, con, transaccion))
                    {
                        cmdVenta.Parameters.AddWithValue(
                            "@IdProducto",
                            venta.oProductos.IdProducto
                        );

                        cmdVenta.Parameters.AddWithValue(
                            "@Cantidad",
                            venta.Cantidad
                        );

                        cmdVenta.Parameters.AddWithValue(
                            "@Precio",
                            venta.Precio
                        );

                        cmdVenta.Parameters.AddWithValue(
                            "@Total",
                            venta.Total
                        );

                        idVenta = Convert.ToInt32(cmdVenta.ExecuteScalar());
                    }

                    // 3. Insertar el detalle de la venta
                    string queryDetalle = @"
                INSERT INTO DETALLE_VENTAS
                (IdVenta, IdProducto, PrecioUnitario, Cantidad)
                VALUES
                (@IdVenta, @IdProducto, @PrecioUnitario, @Cantidad)";

                    using (SqlCommand cmdDetalle =
                           new SqlCommand(queryDetalle, con, transaccion))
                    {
                        cmdDetalle.Parameters.AddWithValue(
                            "@IdVenta",
                            idVenta
                        );

                        cmdDetalle.Parameters.AddWithValue(
                            "@IdProducto",
                            venta.oProductos.IdProducto
                        );

                        cmdDetalle.Parameters.AddWithValue(
                            "@PrecioUnitario",
                            venta.Precio
                        );

                        cmdDetalle.Parameters.AddWithValue(
                            "@Cantidad",
                            venta.Cantidad
                        );

                        cmdDetalle.ExecuteNonQuery();
                    }

                    // 4. Reducir el stock
                    string queryActualizarStock = @"
                UPDATE PRODUCTOS
                SET Stock = Stock - @Cantidad
                WHERE IdProducto = @IdProducto";

                    using (SqlCommand cmdActualizarStock =
                           new SqlCommand(queryActualizarStock, con, transaccion))
                    {
                        cmdActualizarStock.Parameters.AddWithValue(
                            "@Cantidad",
                            venta.Cantidad
                        );

                        cmdActualizarStock.Parameters.AddWithValue(
                            "@IdProducto",
                            venta.oProductos.IdProducto
                        );

                        cmdActualizarStock.ExecuteNonQuery();
                    }

                    // 5. Confirmar la transacción
                    transaccion.Commit();
                }
                catch (Exception ex)
                {
                    transaccion.Rollback();

                    throw new Exception(
                        "Error al realizar la venta: " + ex.Message
                    );
                }
            }
        }

        public DataTable ReporteVentas(DateTime fechaInicio, DateTime fechaFin)
        {
            string query = @"
                SELECT
                    d.IdDetalleVenta,
                    d.IdVenta,
                    p.Producto,
                    d.PrecioUnitario,
                    d.Cantidad,
                    (d.PrecioUnitario * d.Cantidad) AS Total,
                    d.FechaDetalleVenta
                FROM DETALLE_VENTAS d
                INNER JOIN PRODUCTOS p ON p.IdProducto = d.IdProducto
                WHERE d.FechaDetalleVenta >= @FechaInicio
                  AND d.FechaDetalleVenta < @FechaFin
                ORDER BY d.FechaDetalleVenta DESC";

            using (SqlConnection con = Conexion.Conectar())
            using (SqlCommand cmdReporte = new SqlCommand(query, con))
            {
                cmdReporte.Parameters.AddWithValue("@FechaInicio", fechaInicio.Date);
                cmdReporte.Parameters.AddWithValue(
                    "@FechaFin",
                    fechaFin.Date.AddDays(1)
                );

                DataTable tabla = new DataTable();
                tabla.Load(cmdReporte.ExecuteReader());
                return tabla;
            }
        }
    }
}
