using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using System;
using System.Data;
using System.Globalization;

namespace CapaPresentacion
{
    internal static class ReportePdf
    {
        public static void Exportar(
            string titulo,
            string rango,
            DataTable datos,
            string[] columnas,
            string[] encabezados,
            string[] formatos,
            string ruta)
        {
            Document documento = new Document();
            documento.Info.Title = titulo;
            documento.Info.Author = "Core Sistema";

            Section seccion = documento.AddSection();
            seccion.PageSetup.PageFormat = PageFormat.A4;
            seccion.PageSetup.Orientation = Orientation.Landscape;
            seccion.PageSetup.TopMargin = Unit.FromCentimeter(1.5);
            seccion.PageSetup.BottomMargin = Unit.FromCentimeter(1.5);
            seccion.PageSetup.LeftMargin = Unit.FromCentimeter(1.5);
            seccion.PageSetup.RightMargin = Unit.FromCentimeter(1.5);

            Paragraph encabezadoTitulo = seccion.AddParagraph(titulo);
            encabezadoTitulo.Format.Font.Size = 16;
            encabezadoTitulo.Format.Font.Bold = true;
            encabezadoTitulo.Format.Alignment = ParagraphAlignment.Center;
            encabezadoTitulo.Format.SpaceAfter = Unit.FromCentimeter(0.2);

            Paragraph encabezadoRango = seccion.AddParagraph("Periodo: " + rango);
            encabezadoRango.Format.Font.Size = 10;
            encabezadoRango.Format.Alignment = ParagraphAlignment.Center;
            encabezadoRango.Format.SpaceAfter = Unit.FromCentimeter(0.6);

            Table tabla = seccion.AddTable();
            tabla.Borders.Width = 0.5;
            tabla.Borders.Color = Colors.Gray;

            foreach (string columna in columnas)
            {
                tabla.AddColumn(ColumnWidth(columna));
            }

            Row filaEncabezado = tabla.AddRow();
            filaEncabezado.HeadingFormat = true;
            filaEncabezado.Shading.Color = Colors.LightGray;
            filaEncabezado.Format.Font.Bold = true;

            for (int i = 0; i < encabezados.Length; i++)
            {
                Paragraph celda = filaEncabezado.Cells[i].AddParagraph(encabezados[i]);
                celda.Format.Font.Size = 9;
                celda.Format.Alignment = ParagraphAlignment.Center;
            }

            foreach (DataRow fila in datos.Rows)
            {
                Row filaDatos = tabla.AddRow();

                for (int i = 0; i < columnas.Length; i++)
                {
                    string texto = Formatear(fila[columnas[i]], formatos[i]);
                    Paragraph celda = filaDatos.Cells[i].AddParagraph(texto);
                    celda.Format.Font.Size = 9;

                    if (EsNumerica(columnas[i]))
                    {
                        celda.Format.Alignment = ParagraphAlignment.Right;
                    }
                }
            }

            AgregarTotal(tabla, datos, columnas, encabezados);

            PdfDocumentRenderer renderizador = new PdfDocumentRenderer(true);
            renderizador.Document = documento;
            renderizador.RenderDocument();
            renderizador.PdfDocument.Save(ruta);
        }

        private static void AgregarTotal(Table tabla, DataTable datos, string[] columnas, string[] encabezados)
        {
            int indiceTotal = Array.IndexOf(columnas, "Total");

            if (indiceTotal < 0)
            {
                return;
            }

            decimal total = 0;
            foreach (DataRow fila in datos.Rows)
            {
                if (fila["Total"] != DBNull.Value)
                {
                    total += Convert.ToDecimal(fila["Total"], CultureInfo.CurrentCulture);
                }
            }

            Row filaTotal = tabla.AddRow();
            filaTotal.Format.Font.Bold = true;
            filaTotal.Shading.Color = Colors.Gainsboro;

            for (int i = 0; i < columnas.Length; i++)
            {
                Paragraph celda;

                if (i == 0)
                {
                    celda = filaTotal.Cells[i].AddParagraph("TOTAL");
                }
                else if (i == indiceTotal)
                {
                    celda = filaTotal.Cells[i].AddParagraph(total.ToString("N2", CultureInfo.CurrentCulture));
                }
                else
                {
                    celda = filaTotal.Cells[i].AddParagraph(string.Empty);
                }

                celda.Format.Font.Size = 9;
                celda.Format.Font.Bold = true;

                if (EsNumerica(columnas[i]))
                {
                    celda.Format.Alignment = ParagraphAlignment.Right;
                }
            }
        }

        private static string Formatear(object valor, string formato)
        {
            if (valor == null || valor == DBNull.Value)
            {
                return string.Empty;
            }

            IFormattable formateable = valor as IFormattable;

            if (!string.IsNullOrEmpty(formato) && formateable != null)
            {
                return formateable.ToString(formato, CultureInfo.CurrentCulture);
            }

            return Convert.ToString(valor, CultureInfo.CurrentCulture);
        }

        private static bool EsNumerica(string columna)
        {
            return columna == "PrecioUnitario" || columna == "Cantidad" || columna == "Total";
        }

        private static string ColumnWidth(string columna)
        {
            switch (columna)
            {
                case "Producto":
                case "Proveedor":
                    return "6cm";
                case "FechaDetalleVenta":
                case "FechaDetalleCompraa":
                    return "4cm";
                case "Total":
                case "PrecioUnitario":
                    return "3cm";
                default:
                    return "2.2cm";
            }
        }
    }
}