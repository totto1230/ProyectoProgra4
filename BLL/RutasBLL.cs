﻿using ProyectoPrograCuatro.IBLL;
using ProyectoPrograCuatro.IRepositorios;
using ProyectoPrograCuatro.Models;
using ProyectoPrograCuatro.Repositorios;

namespace ProyectoPrograCuatro.BLL
{

    public class RutasBLL : IRutasBLL
    {
        private readonly IRutasRepositorio _rutasRepositorio;


        public RutasBLL(IRutasRepositorio rutasRepositorio) 
        {
               _rutasRepositorio = rutasRepositorio;
        
        }



        public int InsertarRuta(Rutas ruta)
        {
            throw new NotImplementedException();
        }

        public List<Rutas> ListaRutas()
        {
            throw new NotImplementedException();
        }

        public Rutas ObtenerRuta(int codigoruta)
        {
            throw new NotImplementedException();
        }
    }
}
