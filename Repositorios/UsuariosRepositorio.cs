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


        // Método para obtener un usuario por su ID
        public Usuarios ObtenerUsuario(int idUsuario)
        {
            try
            {
                //Establecemos mlos parametros por medio del metodo Add.
                var param = new DynamicParameters();
                param.Add("@Codigo", idUsuario, DbType.Int32, ParameterDirection.Input);

                //Creamos la conexion, llamamos al metodo almacenado y le pasamos el modelo
                using (var conn = _dapperContext.CrearConexion())
                {
                    // Ejecuta un procedimiento almacenado llamado "obtener_usuario_porID"
                    // Pasando el parámetro de ID del usuario y espera obtener un solo usuario
                    var usuario = conn.QuerySingleOrDefault<Usuarios>("obtener_usuario_porID", param, commandType: CommandType.StoredProcedure);

                    // Retorna el usuario obtenido por el procedimiento almacenado
                    return usuario; 
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // Método para insertar un usuario
        public int InsertarUsuario(Usuarios usuarios)
        {
            try
            {
                //Establecemos mlos parametros por medio del metodo Add.
                var param = new DynamicParameters();
                param.Add("@Nombre", usuarios.Nombre, DbType.String, ParameterDirection.Input);
                param.Add("@Usuario", usuarios.Usuario, DbType.String, ParameterDirection.Input);
                param.Add("@Contrasenia", usuarios.Contrasenia, DbType.String, ParameterDirection.Input);
                param.Add("@Estado", usuarios.Estado, DbType.Int32, ParameterDirection.Input);
                using (var conn = _dapperContext.CrearConexion())
                {
                    // Ejecuta un procedimiento almacenado llamado "Inserta_usuario"
                    // Pasando el parámetro de ID del usuario y se espera obtener un id.
                    var id = conn.QuerySingle<int>("insertar_usuario", param, commandType: CommandType.StoredProcedure);

                    //Retorna el ID del usuario creado.
                    return id;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // Método para obtener una lista de usuarios
        public List<Usuarios> ListaUsuarios()
        {
            try
            {
                // Intenta abrir una conexión a la base de datos utilizando el contexto Dapper
                using (var conn = _dapperContext.CrearConexion())
                {
                    // Ejecuta un procedimiento almacenado llamado "obtener_usuarios"
                    // para obtener todos los usuarios de la base de datos
                    // y los convierte en una lista de objetos de tipo Usuarios
                    return conn.Query<Usuarios>("obtener_usuarios").ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // Método para actualizar un usuario.
        public Usuarios ActualizarUsuario(Usuarios usuarios)
        {
            try
            {
                //Establecemos mlos parametros por medio del metodo Add.
                var param = new DynamicParameters();
                param.Add("@Codigo",usuarios.Codigo, DbType.Int32, ParameterDirection.Input);
                param.Add("@Nombre", usuarios.Nombre, DbType.String, ParameterDirection.Input);
                param.Add("@Usuario", usuarios.Usuario, DbType.String, ParameterDirection.Input);
                param.Add("@Contrasenia", usuarios.Contrasenia, DbType.String, ParameterDirection.Input);
                param.Add("@Estado", usuarios.Estado, DbType.Int32, ParameterDirection.Input);
                using (var conn = _dapperContext.CrearConexion())
                {
                    // Ejecuta un procedimiento almacenado llamado "actualizar_usuario"
                    // para actualizar un  usuario de la base de datos
                    conn.Execute("actualizar_usuario", param, commandType: CommandType.StoredProcedure);

                    // Se retorna el objeto usuarios que fue pasado como parámetro al método.
                    return usuarios;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // Método para "eliminar" un usuario marcándolo como inactivo en la base de datos
        public Usuarios EliminarUsuario(Usuarios usuarios)
        {
            try
            {
                // Se crean parámetros para el procedimiento almacenado "eliminar_usuario" por me dio de .Add
                var param = new DynamicParameters();
                param.Add("@Codigo", usuarios.Codigo, DbType.Int32, ParameterDirection.Input);
                param.Add("@Estado", 0, DbType.Int32, ParameterDirection.Input);

                using (var conn = _dapperContext.CrearConexion())
                {
                    // Se ejecuta el procedimiento almacenado "eliminar_usuario"
                    // pasando los parámetros previamente creados para cambiar el estado del usuario a "eliminado" (Estado = 0)
                    conn.Execute("eliminar_usuario", param, commandType: CommandType.StoredProcedure);

                    // Se retorna el objeto usuarios que fue pasado como parámetro al método
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
