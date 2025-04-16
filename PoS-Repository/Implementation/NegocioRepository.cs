using Microsoft.Data.SqlClient;
using PoS_Repository.DB;
using PoS_Repository.Entities;
using PoS_Repository.Interfaces;
using System.Data;

namespace PoS_Repository.Implementation
{
    public class NegocioRepository : INegocioRepository
    {
        private readonly Connection _connection;

        public NegocioRepository(Connection connection)
        {
            _connection = connection;
        }

        public async Task<Negocio> Obtener()
        {
            Negocio objeto = new Negocio();
            using (var con = _connection.GetSQLConnection())
            {
                con.Open();
                var cmd = new SqlCommand("sp_obtenerNegocio", con);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    if (await dr.ReadAsync())
                    {
                        objeto = new Negocio
                        {
                            //Id_Negocio = Convert.ToInt32(dr["Id_Negocio"]),
                            RazonSocial = dr["RazonSocial"].ToString()!.Trim(),
                            RUC = dr["RUC"].ToString()!.Trim(),
                            Direccion = dr["Direccion"].ToString()!.Trim(),
                            Correo = dr["Correo"].ToString()!.Trim(),
                            Celular = dr["Celular"].ToString()!.Trim(),
                            Divisa = dr["Divisa"].ToString()!.Trim(),
                            NombreLogo = dr["NombreLogo"].ToString()!.Trim(),
                            UrlLogo = dr["UrlLogo"].ToString()!.Trim(),
                            //Activo = Convert.ToInt32(dr["Activo"]),
                            //RefMedida = new Medidas
                            //{
                            //    Id_Medida = Convert.ToInt32(dr["Id_Medida"]),
                            //    Nombre = dr["NombreMedida"].ToString()!.Trim(),
                            //}
                        };

                    }
                }

                return objeto;
            }
        }

        public async Task Editar(Negocio objeto)
        {
            using (var con = _connection.GetSQLConnection())
            {
                con.Open();
                var cmd = new SqlCommand("sp_editarNegocio", con);
                cmd.Parameters.AddWithValue("@RazonSocial", objeto.RazonSocial);
                cmd.Parameters.AddWithValue("@RUC", objeto.RUC);
                cmd.Parameters.AddWithValue("@Direccion", objeto.Direccion);
                cmd.Parameters.AddWithValue("@Correo", objeto.Correo);
                cmd.Parameters.AddWithValue("@Celular", objeto.Celular);
                cmd.Parameters.AddWithValue("@Divisa", objeto.Divisa);
                cmd.Parameters.AddWithValue("@NombreLogo", objeto.NombreLogo);
                cmd.Parameters.AddWithValue("@UrlLogo", objeto.UrlLogo);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    await cmd.ExecuteNonQueryAsync();

                }
                catch (Exception error)
                {
                    throw;
                }
            }
        }


    }
}
