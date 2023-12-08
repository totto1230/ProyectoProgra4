using ProyectoPrograCuatro.Models;

namespace ProyectoPrograCuatro.IRepositorios
{
    public interface IUsuariosRepositorio
    {
        public Usuarios ValidarUsuario(Usuarios usuarios);

        public List<Usuarios> ListaUsuarios();

        public int InsertarUsuario(Usuarios usuarios);

        public Usuarios ObtenerUsuario(int idUsuario);

        public Usuarios ActualizarUsuario(Usuarios usuarios);

        public Usuarios EliminarUsuario(Usuarios usuarios);
    }
}
