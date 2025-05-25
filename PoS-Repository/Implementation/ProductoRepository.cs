

using Microsoft.Data.SqlClient;
using PoS_Repository.DB;
using PoS_Repository.Entities;
using PoS_Repository.Interfaces;
using System.Data;

namespace PoS_Repository.Implementation
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly Connection _connection;

        public ProductoRepository(Connection connection)
        {
            _connection = connection;
        }
        public async Task<List<Productos>> Lista(string buscar = "")
        {
            List<Productos> list = new List<Productos>();
            using (var con = _connection.GetSQLConnection())
            {
                con.Open();
                var cmd = new SqlCommand("sp_listaProducto", con);
                cmd.Parameters.AddWithValue("@Buscar", buscar);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        list.Add(new Productos
                        {
                            Id_Producto = Convert.ToInt32(dr["Id_Producto"]),
                            Nombre = dr["Nombre"].ToString()!.Trim(),
                            RefCategoria = new Categorias
                            {
                                Id_Categoria = Convert.ToInt32(dr["Id_Categoria"]),
                                Nombre = dr["NombreCategoria"].ToString()!.Trim(),
                            },
                            Codigo = dr["Codigo"].ToString()!.Trim(),
                            Descripcion = dr["Descripcion"].ToString()!.Trim(),
                            PrecioCompra = Convert.ToDecimal(dr["PrecioCompra"]),
                            PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"]),
                            Stock = Convert.ToInt32(dr["Stock"]),
                            Activo = Convert.ToInt32(dr["Activo"]),
                        });

                    }
                }

                return list;
            }
        }
        public async Task<string> Crear(Productos objeto)
        {
            string response = "";
            using (var con = _connection.GetSQLConnection())
            {
                con.Open();
                var cmd = new SqlCommand("sp_crearProducto", con);
                cmd.Parameters.AddWithValue("@Codigo", objeto.Codigo);
                cmd.Parameters.AddWithValue("@Nombre", objeto.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", objeto.Descripcion);
                cmd.Parameters.AddWithValue("@PrecioCompra", objeto.PrecioCompra);
                cmd.Parameters.AddWithValue("@PrecioVenta", objeto.PrecioVenta);
                cmd.Parameters.AddWithValue("@Stock", objeto.Stock);
                cmd.Parameters.AddWithValue("@Id_Categoria", objeto.RefCategoria.Id_Categoria);
                cmd.Parameters.Add("@MsjError", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    await cmd.ExecuteNonQueryAsync();
                    response = Convert.ToString(cmd.Parameters["@MsjError"].Value)!;
                }
                catch (Exception error)
                {
                    response = "Error(rp): No se pudo procesar" + error.Message;
                }


                return response;
            }
        }

        public async Task<string> Editar(Productos objeto)
        {
            string response = "";
            using (var con = _connection.GetSQLConnection())
            {
                con.Open();
                var cmd = new SqlCommand("sp_editarProducto", con);
                cmd.Parameters.AddWithValue("@Id_Producto", objeto.Id_Producto);
                cmd.Parameters.AddWithValue("@Codigo", objeto.Codigo);
                cmd.Parameters.AddWithValue("@Nombre", objeto.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", objeto.Descripcion);
                cmd.Parameters.AddWithValue("@PrecioCompra", objeto.PrecioCompra);
                cmd.Parameters.AddWithValue("@PrecioVenta", objeto.PrecioVenta);
                cmd.Parameters.AddWithValue("@Stock", objeto.Stock);
                cmd.Parameters.AddWithValue("@Activo", objeto.Activo);
                cmd.Parameters.AddWithValue("@Id_Categoria", objeto.RefCategoria.Id_Categoria);
                cmd.Parameters.Add("@MsjError", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    await cmd.ExecuteNonQueryAsync();
                    response = Convert.ToString(cmd.Parameters["@MsjError"].Value)!;
                }
                catch (Exception error)
                {
                    response = "Error(rp): No se pudo procesar" + error.Message;
                }


                return response;
            }
        }

        public async Task<Productos> Obtener(string codigo)
        {
            Productos objeto = new Productos();
            using (var con = _connection.GetSQLConnection())
            {
                con.Open();
                var cmd = new SqlCommand("sp_obtenerProducto", con);
                cmd.Parameters.AddWithValue("@Codigo", codigo);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    if (await dr.ReadAsync())
                    {
                        objeto = new Productos
                        {
                            Id_Producto = Convert.ToInt32(dr["Id_Producto"]),
                            Nombre = dr["NombreProducto"].ToString()!.Trim(),
                            RefCategoria = new Categorias
                            {
                                Nombre = dr["NombreCategoria"].ToString()!.Trim(),
                                RefMedida = new Medidas
                                {
                                    Equivalente = dr["Equivalente"].ToString()!.Trim(),
                                    Valor = Convert.ToInt32(dr["Valor"]),
                                }
                            },
                            Codigo = dr["Codigo"].ToString()!.Trim(),
                            PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"]),
                            Stock = Convert.ToInt32(dr["Stock"]),
                        };

                    }
                }

                return objeto;
            }
        }
    }
}
