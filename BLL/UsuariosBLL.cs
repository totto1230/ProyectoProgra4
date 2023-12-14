// Los namespaces proporcionados se usan para importar las interfaces y modelos necesarios
using ProyectoPrograCuatro.IBLL;
using ProyectoPrograCuatro.IRepositorios;
using ProyectoPrograCuatro.Models;

namespace ProyectoPrograCuatro.BLL
{
    // Clase que implementa la lógica de negocio para usuarios
    public class UsuariosBLL : IUsuariosBLL
    {
       
        private readonly IUsuariosRepositorio _usuariosRepositorio;

        //Constructor para instanciar la variable
        public UsuariosBLL(IUsuariosRepositorio usuariosRepositorio)
        {
            _usuariosRepositorio = usuariosRepositorio;
        }

        // Implementación de los métodos de la interfaz IUsuariosBLL

        public Usuarios ObtenerUsuario(int idUsuario)
        {
            try
            {
                return _usuariosRepositorio.ObtenerUsuario(idUsuario);
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
                return _usuariosRepositorio.InsertarUsuario(usuarios);
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
                return _usuariosRepositorio.ListaUsuarios();
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
                return _usuariosRepositorio.ActualizarUsuario(usuarios);
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
                return _usuariosRepositorio.EliminarUsuario(usuarios);
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
                return _usuariosRepositorio.ValidarUsuario(usuarios);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
