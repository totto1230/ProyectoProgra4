using System.Data;

namespace ProyectoPrograCuatro.IDapper
{
    public interface IDapperContext
    {
        public IDbConnection CrearConexion();
    }
}
