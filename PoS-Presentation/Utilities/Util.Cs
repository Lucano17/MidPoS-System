
using PoS_Repository.Entities;
using System.Security.Cryptography;
using System.Text;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace PoS_Presentation.Utilities
{
    public static class Util
    {
        public static string GenerateCode()
        {
            var guid = Guid.NewGuid().ToString("N").Substring(0, 6);
            return guid;
        }

        public static string ConvertToSha256(string texto)
        {
            using (SHA256 sha256hash = SHA256.Create())
            {
                // Convertir la cadena de entrada en un array de bytes
                byte[] bytes = sha256hash.ComputeHash(Encoding.UTF8.GetBytes(texto));

                // Construir el string del hash
                StringBuilder builder = new();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public static byte[] GeneratePDFVenta(Negocio oNegocio, Venta oVenta, Stream ImagenLogo)
        {
            QuestPDF.Settings.License = LicenseType.Community;
            var arrayPDF = Document.Create(document =>
            {
                document.Page(page =>
                {
                    page.Margin(30);
                    page.Header().ShowOnce().Row(row =>
                    {
                        row.AutoItem().Height(60).Image(ImagenLogo, ImageScaling.FitArea);
                        row.RelativeItem().Column(col =>
                        {
                            col.Item().AlignCenter().Text(oNegocio.RazonSocial).Bold().FontSize(14);
                            col.Item().AlignCenter().Text(oNegocio.Direccion).FontSize(9);
                            col.Item().AlignCenter().Text(oNegocio.Celular).FontSize(9);
                            col.Item().AlignCenter().Text(oNegocio.Correo).FontSize(9);
                        });
                        row.ConstantItem(140).Column(col =>
                        {
                            col.Item().Border(1).BorderColor("#634883").AlignCenter().Text($"RUC {oNegocio.RUC}");
                            col.Item().Background("#634883").Border(1).BorderColor("#634883").AlignCenter().Text($"Boleta de Venta").FontColor("#fff");
                            col.Item().Border(1).BorderColor("#634883").AlignCenter().Text($"{oVenta.NumeroVenta}");

                        });
                    });
                    page.Content().PaddingVertical(15).Column(col1 =>
                    {
                        col1.Spacing(10);
                        col1.Item().LineHorizontal(0.5f);
                        col1.Item().Row(row =>
                        {
                            row.RelativeItem().Text(txt =>
                            {
                                txt.Span("Cliente: ").SemiBold().FontSize(10);
                            }); row.RelativeItem().Text(txt =>
                            {
                                txt.Span(oVenta.NombreCliente).SemiBold().FontSize(10);
                            });

                            row.RelativeItem().Text(txt =>
                            {
                                txt.Span("Fecha de emisión: ").SemiBold().FontSize(10);
                            }); row.RelativeItem().Text(txt =>
                            {
                                txt.Span(oVenta.FechaRegistro).SemiBold().FontSize(10);
                            });
                            col1.Item().LineHorizontal(0.5f);
                            col1.Item().Table(table =>
                            {
                                table.ColumnsDefinition(columns =>
                                {
                                    columns.RelativeColumn(3);
                                    columns.RelativeColumn();
                                    columns.RelativeColumn();
                                    columns.RelativeColumn();
                                });
                                table.Header(header =>
                                {
                                    header.Cell().Background("#634883").Padding(2).Text("Producto").FontColor("#fff");
                                    header.Cell().Background("#634883").Padding(2).Text("Precio unit").FontColor("#fff");
                                    header.Cell().Background("#634883").Padding(2).Text("Cantidad").FontColor("#fff");
                                    header.Cell().Background("#634883").Padding(2).Text("Total").FontColor("#fff");
                                });

                                foreach (DetalleVenta item in oVenta.RefDetalleVenta)
                                {
                                    decimal cantidad =
                                        Convert.ToDecimal(item.Cantidad) / Convert.ToDecimal(item.RefProducto.RefCategoria.RefMedida.Valor);
                                    string abreviatura = item.RefProducto.RefCategoria.RefMedida.Abreviatura;

                                    table.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9").Padding(2)
                                        .Text(item.RefProducto.Nombre).FontSize(10);

                                    table.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9").Padding(2)
                                        .Text($"{oNegocio.Divisa} {item.PrecioVenta.ToString("0.00")}").FontSize(10);

                                    table.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9").Padding(2)
                                        .Text($"{cantidad.ToString()} {abreviatura}").FontSize(10);

                                    table.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9").Padding(2)
                                        .Text($"{oNegocio.Divisa} {item.PrecioTotal.ToString("0.00")}").FontSize(10);
                                }
                            });
                        });
                        col1.Item().AlignRight().Text($"{oNegocio.Divisa} {oVenta.PrecioTotal.ToString("0.00")}");
                    });

                    page.Footer().AlignRight().Text(txt =>
                    {
                        txt.Span("Página ").FontSize(10);
                        txt.CurrentPageNumber().FontSize(10);
                        txt.Span(" de ").FontSize(10);
                        txt.TotalPages().FontSize(10);
                    });
                });
            }).GeneratePdf();

            return arrayPDF;
        }
    }
}
