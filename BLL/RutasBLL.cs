using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ProyectoPrograCuatro.IBLL;
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

        public Rutas ActualizarRuta(Rutas ruta)
        {
            try
            {
                return _rutasRepositorio.ActualizarRuta(ruta);
            }
            catch (Exception)
            {

                throw;
            }
        }




        //public Rutas GenerarReporte(int codigoCliente, DateTime fechaInicio, DateTime fechaFinal)
        //{
        //    try
        //    {
        //        return _rutasRepositorio.GenerarReporte(codigoCliente, fechaInicio, fechaFinal);
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

        public int InsertarRuta(Rutas ruta)
        {
            try
            {
                return _rutasRepositorio.InsertarRuta(ruta);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Rutas> ListaRutas()
        {
            try
            {
                return _rutasRepositorio.ListaRutas();
            }
            catch (Exception)
            {

                throw;
            }
        }

        

        public Rutas ObtenerRuta(int codigoruta)
        {
            try
            {
                return _rutasRepositorio.ObtenerRuta(codigoruta);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
