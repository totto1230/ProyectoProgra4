﻿using ProyectoPrograCuatro.BLL;
using ProyectoPrograCuatro.Models;

namespace ProyectoPrograCuatro.IRepositorios
{
    public interface IClientesRepositorio
    {
        public List<Clientes> ListaClientes();
        public int InsertarCliente(Clientes cliente);
        public Clientes ObtenerCliente(int idcliente);

        public Clientes ActualizarCliente(Clientes cliente);
        public int EliminarCliente(int idcliente);

    }
}
