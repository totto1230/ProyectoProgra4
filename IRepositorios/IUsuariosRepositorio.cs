using ProyectoPrograCuatro.Models;

namespace ProyectoPrograCuatro.IRepositorios
{
    public interface IUsuariosRepositorio
    {
        public Usuarios ValidarUsuario(Usuarios usuario);

        public List<Usuarios> ListaUsuarios();

        public int InsertarUsuario(Usuarios usuario);

        public Usuarios ObtenerUsuario(int Codigo);

        public Usuarios ActualizarUsuario(Usuarios usuario);

        public int EliminarUsuario(int Codigo);
    }
}
