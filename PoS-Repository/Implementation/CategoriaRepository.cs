

using Microsoft.Data.SqlClient;
using System.Data;
using PoS_Repository.DB;
using PoS_Repository.Entities;
using PoS_Repository.Interfaces;

namespace PoS_Repository.Implementation
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly Connection _connection;

        public CategoriaRepository(Connection connection)
        {
            _connection = connection;
        }

        public async Task<string> Crear(Categorias objeto)
        {
            string response = "";
            using (var con = _connection.GetSQLConnection())
            {
                con.Open();
                var cmd = new SqlCommand("sp_crearCategoria", con);
                cmd.Parameters.AddWithValue("@Nombre", objeto.Nombre);
                cmd.Parameters.AddWithValue("@Id_Medida", objeto.RefMedida.Id_Medida);
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

        public async Task<string> Editar(Categorias objeto)
        {
            string response = "";
            using (var con = _connection.GetSQLConnection())
            {
                con.Open();
                var cmd = new SqlCommand("sp_editarCategoria", con);
                cmd.Parameters.AddWithValue("@Id_Categoria", objeto.Id_Categoria);
                cmd.Parameters.AddWithValue("@Nombre", objeto.Nombre);
                cmd.Parameters.AddWithValue("@Id_Medida", objeto.RefMedida.Id_Medida);
                cmd.Parameters.AddWithValue("@Activo", objeto.Activo);
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

        public async Task<List<Categorias>> Lista(string buscar = "")
        {
            List<Categorias> list = new List<Categorias>();
            using (var con = _connection.GetSQLConnection())
            {
                con.Open();
                var cmd = new SqlCommand("sp_listaCategoria", con);
                cmd.Parameters.AddWithValue("@Buscar", buscar);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        list.Add(new Categorias
                        {
                            Id_Categoria = Convert.ToInt32(dr["Id_Categoria"]),
                            Nombre = dr["Nombre"].ToString()!.Trim(),
                            Activo = Convert.ToInt32(dr["Activo"]),
                            RefMedida = new Medidas
                            {
                                Id_Medida = Convert.ToInt32(dr["Id_Medida"]),
                                Nombre = dr["NombreMedida"].ToString()!.Trim(),
                            }
                        });

                    }
                }

                return list;
            }
        }
    }
}
