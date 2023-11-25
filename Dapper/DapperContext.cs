using Progra4BD.IDapper;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Progra4BD.Dapper
{
    public class DapperContext : IDapperContext
    {
        private readonly IConfiguration _iConfiguration;
        private readonly string? _cadenaconexion;
        
        public DapperContext(IConfiguration iConfiguration)
        {
            _iConfiguration = iConfiguration;
            _cadenaconexion = _iConfiguration.GetConnectionString("progra4");
        }
        public IDbConnection CrearConexion()
        {
            return new SqlConnection(_cadenaconexion);
        }
    }
}
