
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
                var cmd = new SqlCommand("sp_registarVenta", con);
                cmd.Parameters.AddWithValue("@VentaXML", ventaXML);
                cmd.Parameters.Add("@NumeroVenta", SqlDbType.VarChar, 10).Direction = ParameterDirection.Output;
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    await cmd.ExecuteNonQueryAsync();
                    response = Convert.ToString(cmd.Parameters["@NumeroVenta"].Value)!;
                }
                catch (Exception error)
                {
                    response = "Error(rp): No se pudo procesar" + error.Message;
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
                var cmd = new SqlCommand("sp_obtenerVenta", con);
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
                                Nombre = dr["Nombre"].ToString()!.Trim(),
                                RefCategoria = new Categorias()
                                {
                                    RefMedida = new Medidas()
                                    {
                                        Abreviatura = dr["Abreviatura"].ToString()!.Trim(),
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

    }
}
