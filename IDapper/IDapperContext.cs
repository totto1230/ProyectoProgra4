using System.Data;

namespace Progra4BD.IDapper
{
    public interface IDapperContext
    {
        public IDbConnection CrearConexion();
    }
}
