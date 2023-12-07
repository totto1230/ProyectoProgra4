using ProyectoPrograCuatro.IBLL;
using ProyectoPrograCuatro.IRepositorios;
using ProyectoPrograCuatro.Models;

namespace ProyectoPrograCuatro.BLL
{
    public class UsuariosBLL : IUsuariosBLL
    {
       
        private readonly IUsuariosRepositorio _usuariosRepositorio;

        //Constructor para instanciar la variable
        public UsuariosBLL(IUsuariosRepositorio usuariosRepositorio)
        {
            _usuariosRepositorio = usuariosRepositorio;
        }

        public Usuarios ActualizarUsuario(Usuarios usuarios)
        {
            throw new NotImplementedException();
        }

        public int EliminarUsuario(int idUsuario)
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

        public Usuarios ObtenerUsuario(int idUsuario)
        {
            throw new NotImplementedException();
        }

        public Usuarios ValidarUsuario(Usuarios usuarios)
        {
            try
            {
                return _usuariosRepositorio.ValidarUsuario(usuarios);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
