﻿
using dotenv.net;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace PoS_Repository.DB
{
    public class Connection
    {
        private readonly IConfiguration _configuration;
        private readonly string _stringSql = null!;

        public Connection(IConfiguration configuration)
        {
            //DotEnv.Load();
            //_stringSql = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING")!;
            _configuration = configuration;
            _stringSql = _configuration.GetConnectionString("CadenaSql")!;
        }

        public SqlConnection GetSQLConnection()
        {
            return new SqlConnection(_stringSql);
        }

    }
}
