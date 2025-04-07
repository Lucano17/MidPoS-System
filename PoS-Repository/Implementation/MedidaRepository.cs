

using Microsoft.Data.SqlClient;
using PoS_Repository.DB;
using PoS_Repository.Entities;
using PoS_Repository.Interfaces;

namespace PoS_Repository.Implementation
{
    public class MedidaRepository : IMedidaRepository
    {
        private readonly Connection _connection;

        public MedidaRepository(Connection connection)
        {
            _connection = connection;
        }
        public async Task<List<Medidas>> Lista()
        {
            List<Medidas> list = new List<Medidas>();
            using (var con = _connection.GetSQLConnection())
            {
                con.Open();
                var cmd = new SqlCommand("sp_listaMedida", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        list.Add(new Medidas
                        {
                            Id_Medida = Convert.ToInt32(dr["Id_Medida"]),
                            Nombre = dr["Nombre"].ToString().Trim(),
                            Abreviatura = dr["Abreviatura"].ToString().Trim(),
                            Equivalente = dr["Equivalente"].ToString().Trim(),
                            Valor = Convert.ToInt32(dr["Valor"])
                        });

                    }
                }

                return list;
            }

        }
    }
}
