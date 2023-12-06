﻿using ProyectoPrograCuatro.Models;

namespace ProyectoPrograCuatro.IBLL
{
    public interface IUsuariosBLL
    {
        public Usuarios ValidarUsuario(Usuarios usuarios);

        public List<Usuarios> ListaUsuarios();

        public int InsertarUsuario(Usuarios usuarios);

        public Usuarios ObtenerUsuario(int Codigo);

        public Usuarios ActualizarUsuario(Usuarios usuarios);

        public int EliminarUsuario(int Codigo);
    }
}
