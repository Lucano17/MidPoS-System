
using Microsoft.Data.SqlClient;
using PoS_Repository.DB;
using PoS_Repository.Entities;
using PoS_Service.Interfaces;
using System.Data;

namespace PoS_Repository.Implementation
{
    public class VentaRepository : IVentaRepository
    {
        private readonly Connection _connection;

        public VentaRepository(Connection connection)
        {
            _connection = connection;
        }
        public async Task<string> Registrar(string ventaXML)
        {
            string response = "";
            using (var con = _connection.GetSQLConnection())
            {
                con.Open();
                var cmd = new SqlCommand("sp_registrarVenta", con);
                cmd.Parameters.AddWithValue("@VentaXML", ventaXML);
                cmd.Parameters.Add("@NumeroVenta", SqlDbType.VarChar, 20).Direction = ParameterDirection.Output;
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    //
                    Console.WriteLine("VENTA XML ENVIADO:");
                    Console.WriteLine(ventaXML);

                    await cmd.ExecuteNonQueryAsync();
                    //
                    Console.WriteLine("NumeroVenta devuelto: " + Convert.ToString(cmd.Parameters["@NumeroVenta"].Value));

                    if (cmd.Parameters["@NumeroVenta"].Value == DBNull.Value || string.IsNullOrWhiteSpace(Convert.ToString(cmd.Parameters["@NumeroVenta"].Value)))
                    {
                        response = "Error(rp): No se pudo procesar la venta. El SP no devolvió un número de venta.";
                    }
                    else
                    {
                        try
                        {
                            response = Convert.ToString(cmd.Parameters["@NumeroVenta"].Value)!;
                        }
                        catch (SqlException ex)
                        {
                            Console.WriteLine(ex);
                        }
                    }
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                    response = "Error(rp): No se pudo procesar - " + error.Message;
                }

                return response;
            }
        }

        public async Task<Venta> Obtener(string numeroVenta)
        {
            Venta objeto = new Venta();
            using (var con = _connection.GetSQLConnection())
            {
                con.Open();
                var cmd = new SqlCommand("sp_obtenerVenta", con);
                cmd.Parameters.AddWithValue("@NumeroVenta", numeroVenta);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    if (await dr.ReadAsync())
                    {
                        objeto = new Venta
                        {
                            Id_Venta = Convert.ToInt32(dr["Id_Venta"].ToString()!.Trim()),
                            NumeroVenta = dr["NumeroVenta"].ToString()!.Trim(),
                            UsuarioRegistro = new Usuario
                            {
                                NombreUsuario = dr["NombreUsuario"].ToString()!.Trim(),
                            },
                            NombreCliente = dr["NombreCliente"].ToString()!.Trim(),
                            PrecioTotal = Convert.ToDecimal(dr["PrecioTotal"])!,
                            PagoCon = Convert.ToDecimal(dr["PagoCon"])!,
                            Cambio = Convert.ToDecimal(dr["Cambio"])!,
                            FechaRegistro = dr["FechaRegistro"].ToString()!.Trim(),
                        };

                    }
                }

                return objeto;
            }
        }

        public async Task<List<DetalleVenta>> ObtenerDetalle(string numeroVenta)
        {
            List<DetalleVenta> lista = new List<DetalleVenta>();
            using (var con = _connection.GetSQLConnection())
            {
                con.Open();
                var cmd = new SqlCommand("sp_detalleVenta", con);
                cmd.Parameters.AddWithValue("@NumeroVenta", numeroVenta);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        lista.Add(new DetalleVenta
                        {

                            RefProducto = new Productos()
                            {
                                Nombre = dr["Nombre"].ToString()!,
                                RefCategoria = new Categorias()
                                {
                                    RefMedida = new Medidas()
                                    {
                                        Abreviatura = dr["Abreviatura"].ToString()!,
                                        Valor = Convert.ToInt32(dr["Valor"]),
                                    }
                                }
                            },
                            Cantidad = Convert.ToInt32(dr["Cantidad"]),
                            PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"]),
                            PrecioTotal = Convert.ToDecimal(dr["PrecioTotal"]),
                        });

                    }
                }

                return lista;
            }
        }

        public async Task<List<Venta>> Lista(string fechaInicio, string fechaFin, string buscar = "")
        {
            List<Venta> lista = new List<Venta>();
            using (var con = _connection.GetSQLConnection())
            {
                con.Open();
                var cmd = new SqlCommand("sp_listaVenta", con);
                cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                cmd.Parameters.AddWithValue("@FechaFin", fechaFin);
                cmd.Parameters.AddWithValue("@Buscar", buscar);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        lista.Add(new Venta
                        {

                            NumeroVenta = dr["NumeroVenta"].ToString()!,
                            UsuarioRegistro = new Usuario()
                            {
                                NombreUsuario = dr["NombreUsuario"].ToString()!
                            },
                            NombreCliente = dr["NombreCliente"].ToString()!,
                            PrecioTotal = Convert.ToDecimal(dr["PrecioTotal"]),
                            PagoCon = Convert.ToDecimal(dr["PagoCon"]),
                            Cambio = Convert.ToDecimal(dr["Cambio"]),
                            FechaRegistro = dr["FechaRegistro"].ToString()!,
                        });

                    }
                }

                return lista;
            }
        }

        public async Task<List<DetalleVenta>> ReporteVenta(string fechaInicio, string fechaFin)
        {
            List<DetalleVenta> lista = new List<DetalleVenta>();
            using (var con = _connection.GetSQLConnection())
            {
                con.Open();
                var cmd = new SqlCommand("sp_reporteVenta", con);
                cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                cmd.Parameters.AddWithValue("@FechaFin", fechaFin);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        lista.Add(new DetalleVenta
                        {
                            RefVenta = new Venta
                            {
                                NumeroVenta = dr["NumeroVenta"].ToString()!,
                                UsuarioRegistro = new Usuario()
                                {
                                    NombreUsuario = dr["NombreUsuario"].ToString()!
                                },
                                FechaRegistro = dr["FechaRegistro"].ToString()!,
                            },
                            RefProducto = new Productos
                            {
                                Nombre = dr["Producto"].ToString()!,
                                PrecioCompra = Convert.ToDecimal(dr["PrecioCompra"]),
                            },
                            PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"]),
                            Cantidad = Convert.ToInt32(dr["Cantidad"]),
                            PrecioTotal = Convert.ToDecimal(dr["PrecioTotal"]),
                        });
                    }
                }
                return lista;
            }
        }
    }
}
