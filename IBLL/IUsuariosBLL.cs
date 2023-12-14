using ProyectoPrograCuatro.Models; // Importa el espacio de nombres Models


namespace ProyectoPrograCuatro.IBLL
{
    // Interfaz que define las operaciones disponibles en un repositorio de usuarios
    public interface IUsuariosBLL
    {
        // Método para validar un usuario
        public Usuarios ValidarUsuario(Usuarios usuarios);

        // Método para obtener una lista de usuarios
        public List<Usuarios> ListaUsuarios();

        // Método para insertar un nuevo usuario
        public int InsertarUsuario(Usuarios usuarios);

        // Método para obtener un usuario por su ID
        public Usuarios ObtenerUsuario(int idUsuario);

        // Método para actualizar la información de un usuario existente
        public Usuarios ActualizarUsuario(Usuarios usuarios);

        // Método para eliminar lógicamente un usuario (cambiar su estado, por ejemplo, a inactivo)
        public Usuarios EliminarUsuario(Usuarios usuarios);
    }
}
