using Microsoft.Data.SqlClient;
using PoS_Repository.DB;
using PoS_Repository.Entities;
using PoS_Repository.Interfaces;

namespace PoS_Repository.Implementation
{
    public class RolesRepository : IRolesRepository
    {
        private readonly Connection _connection;

        public RolesRepository(Connection connection)
        {
            _connection = connection;
        }
        public async Task<List<Roles>> Lista()
        {
            List<Roles> list = new List<Roles>();
            using (var con = _connection.GetSQLConnection())
            {
                con.Open();
                var cmd = new SqlCommand("sp_listaRol", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        list.Add(new Roles
                        {
                            Id_Rol = Convert.ToInt32(dr["Id_Rol"]),
                            Nombre = dr["Nombre"].ToString().Trim(),
                        });

                    }
                }

                return list;
            }
        }
    }
}
