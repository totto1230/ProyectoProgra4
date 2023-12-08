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

        public Usuarios ObtenerUsuario(int idUsuario)
        {
            try
            {
                var param = new DynamicParameters();
                param.Add("@Codigo", idUsuario, DbType.Int32, ParameterDirection.Input);
                using (var conn = _dapperContext.CrearConexion())
                {
                    var usuario = conn.QuerySingleOrDefault<Usuarios>("obtener_usuario_porID", param, commandType: CommandType.StoredProcedure);
                    return usuario;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int InsertarUsuario(Usuarios usuarios)
        {
            try
            {
                var param = new DynamicParameters();
                param.Add("@Nombre", usuarios.Nombre, DbType.String, ParameterDirection.Input);
                param.Add("@Usuario", usuarios.Usuario, DbType.String, ParameterDirection.Input);
                param.Add("@Contrasenia", usuarios.Contrasenia, DbType.String, ParameterDirection.Input);
                param.Add("@Estado", usuarios.Estado, DbType.Int32, ParameterDirection.Input);
                using (var conn = _dapperContext.CrearConexion())
                {
                    var id = conn.QuerySingle<int>("insertar_usuario", param, commandType: CommandType.StoredProcedure);
                    return id;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Usuarios> ListaUsuarios()
        {
            try
            {
                using (var conn = _dapperContext.CrearConexion())
                {
                    return conn.Query<Usuarios>("obtener_usuarios").ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        public Usuarios ActualizarUsuario(Usuarios usuarios)
        {
            try
            {
                var param = new DynamicParameters();
                param.Add("@Codigo",usuarios.Codigo, DbType.Int32, ParameterDirection.Input);
                param.Add("@Nombre", usuarios.Nombre, DbType.String, ParameterDirection.Input);
                param.Add("@Usuario", usuarios.Usuario, DbType.String, ParameterDirection.Input);
                param.Add("@Contrasenia", usuarios.Contrasenia, DbType.String, ParameterDirection.Input);
                param.Add("@Estado", usuarios.Estado, DbType.Int32, ParameterDirection.Input);
                using (var conn = _dapperContext.CrearConexion())
                {
                    conn.Execute("actualizar_usuario", param, commandType: CommandType.StoredProcedure);
                    return usuarios;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Usuarios EliminarUsuario(Usuarios usuarios)
        {
            try
            {
                var param = new DynamicParameters();
                param.Add("@Codigo", usuarios.Codigo, DbType.Int32, ParameterDirection.Input);
                param.Add("@Estado", 0, DbType.Int32, ParameterDirection.Input);

                using (var conn = _dapperContext.CrearConexion())
                {
                    conn.Execute("eliminar_usuario", param, commandType: CommandType.StoredProcedure);
                    return usuarios;
                }
            }
            catch (Exception)
            {

                throw;
            }
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
