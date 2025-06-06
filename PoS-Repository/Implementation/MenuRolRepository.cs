

using Microsoft.Data.SqlClient;
using PoS_Repository.DB;
using PoS_Repository.Entities;
using PoS_Repository.Interfaces;
using System.Data;

namespace PoS_Repository.Implementation
{
    public class MenuRolRepository : IMenuRolRepository
    {
        private readonly Connection _connection;

        public MenuRolRepository(Connection connection)
        {
            _connection = connection;
        }
        public async Task<List<MenuRol>> Lista(int idRol)
        {
            List<MenuRol> lista = new List<MenuRol>();
            using (var con = _connection.GetSQLConnection())
            {
                con.Open();
                var cmd = new SqlCommand("sp_obtenerMenus", con);
                cmd.Parameters.AddWithValue("@IdRol", idRol);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        lista.Add(new MenuRol
                        {
                            NombreMenu = dr["NombreMenu"].ToString()!.Trim(),
                            Id_MenuPadre = Convert.ToInt32(dr["Id_MenuPadre"]),
                            Activo = Convert.ToBoolean(dr["Activo"])
                        });
                    }
                }
                return lista;
            }
        }
    }
}
