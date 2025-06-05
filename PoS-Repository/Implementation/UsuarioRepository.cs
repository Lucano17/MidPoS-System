
using Microsoft.Data.SqlClient;
using PoS_Repository.DB;
using PoS_Repository.Entities;
using PoS_Repository.Interfaces;
using System.Data;

namespace PoS_Repository.Implementation
{
    class UsuarioRepository : IUsuarioRepository
    {
        private readonly Connection _connection;

        public UsuarioRepository(Connection connection)
        {
            _connection = connection;
        }
        public async Task<List<Usuario>> Lista(string buscar = "")
        {
            List<Usuario> lista = new List<Usuario>();
            using (var con = _connection.GetSQLConnection())
            {
                con.Open();
                var cmd = new SqlCommand("sp_listaUsuario", con);
                cmd.Parameters.AddWithValue("@Buscar", buscar);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        lista.Add(new Usuario
                        {
                            Id_Usuario = Convert.ToInt32(dr["Id_Usuario"]),
                            Nombre = dr["Nombre"].ToString()!.Trim(),
                            Apellido = dr["Apellido"].ToString()!.Trim(),
                            Correo = dr["Correo"].ToString()!.Trim(),
                            NombreUsuario = dr["NombreUsuario"].ToString()!.Trim(),
                            Activo = Convert.ToInt32(dr["Activo"]),
                            RefRol = new Roles
                            {
                                Id_Rol = Convert.ToInt32(dr["Id_Rol"]),
                                Nombre = dr["NombreRol"].ToString()!.Trim(),
                            }
                        });

                    }
                }

                return lista;
            }
        }

        public async Task<string> Crear(Usuario objeto)
        {
            string response = "";
            using (var con = _connection.GetSQLConnection())
            {
                con.Open();
                var cmd = new SqlCommand("sp_crearUsuario", con);
                cmd.Parameters.AddWithValue("@Nombre", objeto.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", objeto.Apellido);
                cmd.Parameters.AddWithValue("@NombreUsuario", objeto.NombreUsuario);
                cmd.Parameters.AddWithValue("@Correo", objeto.Correo);
                cmd.Parameters.AddWithValue("@Clave", objeto.Clave);
                cmd.Parameters.AddWithValue("@Id_Rol", objeto.RefRol.Id_Rol);
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

        public async Task<string> Editar(Usuario objeto)
        {
            string response = "";
            using (var con = _connection.GetSQLConnection())
            {
                con.Open();
                var cmd = new SqlCommand("sp_editarUsuario", con);
                cmd.Parameters.AddWithValue("@Id_Usuario", objeto.Id_Usuario);
                cmd.Parameters.AddWithValue("@Nombre", objeto.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", objeto.Apellido);
                cmd.Parameters.AddWithValue("@NombreUsuario", objeto.NombreUsuario);
                cmd.Parameters.AddWithValue("@Correo", objeto.Correo);
                cmd.Parameters.AddWithValue("@Id_Rol", objeto.RefRol.Id_Rol);
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

        public async Task<Usuario> Login(string usuario, string clave)
        {

            Usuario objeto = new Usuario();
            using (var con = _connection.GetSQLConnection())
            {
                con.Open();
                var cmd = new SqlCommand("sp_login", con);
                cmd.Parameters.AddWithValue("@NombreUsuario", usuario);
                cmd.Parameters.AddWithValue("@Clave", clave);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    if (await dr.ReadAsync())
                    {
                        objeto = new Usuario()
                        {
                            Id_Usuario = Convert.ToInt32(dr["Id_Usuario"]),
                            Nombre = dr["Nombre"].ToString()!.Trim(),
                            Apellido = dr["Apellido"].ToString()!.Trim(),
                            RefRol = new Roles
                            {
                                Id_Rol = Convert.ToInt32(dr["Id_Rol"]),
                                Nombre = dr["NombreRol"].ToString()!.Trim(),
                            },
                            Correo = dr["Correo"].ToString()!.Trim(),
                            NombreUsuario = dr["NombreUsuario"].ToString()!.Trim(),
                            ResetearClave = Convert.ToInt32(dr["ResetearClave"]),
                            Activo = Convert.ToInt32(dr["Activo"]),
                        };

                    }
                }

                return objeto;
            }
        }

        public async Task<int> VerificarCorreo(string correo)
        {
            int idUsuario;
            using (var con = _connection.GetSQLConnection())
            {
                con.Open();
                var cmd = new SqlCommand("sp_verificarCorreo", con);
                cmd.Parameters.AddWithValue("@Correo", correo);
                cmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    await cmd.ExecuteNonQueryAsync();
                    idUsuario = Convert.ToInt32(cmd.Parameters["@IdUsuario"].Value)!;
                }
                catch
                {
                    idUsuario = 0;
                }


                return idUsuario;
            }
        }

        public async Task ActualizarClave(int idUsuario, string nuevaClave, int resetear)
        {
            using (var con = _connection.GetSQLConnection())
            {
                con.Open();
                var cmd = new SqlCommand("sp_actualizarClave", con);
                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                cmd.Parameters.AddWithValue("@NuevaClave", nuevaClave);
                cmd.Parameters.AddWithValue("@Resetear", resetear);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    await cmd.ExecuteNonQueryAsync();
                }
                catch
                {
                    throw;
                }
            }
        }
    }
}
