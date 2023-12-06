using Dapper;
using ProyectoPrograCuatro.IDapper;
using ProyectoPrograCuatro.IRepositorios;
using ProyectoPrograCuatro.Models;
using System.Data;

namespace ProyectoPrograCuatro.Repositorios
{
    public class UsuariosRepositorio : IUsuariosRepositorio
    {
        //Variable para conectarse a la base de datos
        private readonly IDapperContext _dapperContext;

        //Constructor para instanciar la variable
        public UsuariosRepositorio(IDapperContext dapperContext)
        {
            _dapperContext = dapperContext;
        }

        public Usuarios ActualizarUsuario(Usuarios usuarios)
        {
            throw new NotImplementedException();
        }

        public int EliminarUsuario(int Codigo)
        {
            throw new NotImplementedException();
        }

        public int InsertarUsuario(Usuarios usuarios)
        {
            throw new NotImplementedException();
        }

        public List<Usuarios> ListaUsuarios()
        {
            throw new NotImplementedException();
        }

        public Usuarios ObtenerUsuario(int Codigo)
        {
            throw new NotImplementedException();
        }

        public Usuarios ValidarUsuario(Usuarios usuarios)
        {
            try
            { 
                //Variable para pasar user and PW
                var param = new DynamicParameters();
                //ESTABLECEMOS LOS PARAMETROS usando el metodo add
                param.Add("@Usuario", usuarios.Usuario, DbType.String, ParameterDirection.Input);
                param.Add("@Contrasenia", usuarios.Contrasenia, DbType.String, ParameterDirection.Input);

                //Creamos la conexion, llamamos al metodo almacenado y le pasamos el modelo
                using (var conn = _dapperContext.CrearConexion())
                {
                    return conn.QuerySingleOrDefault<Usuarios>("validar_usuario", param, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
