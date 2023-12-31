﻿using Dapper;
using ProyectoPrograCuatro.Dapper;
using ProyectoPrograCuatro.IDapper;
using ProyectoPrograCuatro.IRepositorios;
using ProyectoPrograCuatro.Models;
using System.Data;


namespace ProyectoPrograCuatro.Repositorios
{
    public class RutasRepositorio : IRutasRepositorio
    {

        private readonly IDapperContext _dapperContext;

        public RutasRepositorio (IDapperContext dapperContext)
        {
            _dapperContext = dapperContext;
        }


        public int InsertarRuta(Rutas ruta)
        {
            try
            {
                var param = new DynamicParameters();
                param.Add("@CodigoClientes", ruta.CodigoClientes, DbType.Int32, ParameterDirection.Input);
                param.Add("@CodigoChoferes", ruta.CodigoChoferes, DbType.Int32, ParameterDirection.Input);
                param.Add("@CodigoCamiones", ruta.CodigoCamiones, DbType.Int32, ParameterDirection.Input);
                param.Add("@DireccionEntrega", ruta.DireccionEntrega, DbType.String, ParameterDirection.Input);
                param.Add("@FechaCreacion", ruta.FechaCreacion, DbType.DateTime, ParameterDirection.Input);
                param.Add("@Estado", ruta.Estado, DbType.Int32, ParameterDirection.Input);


                using (var conn = _dapperContext.CrearConexion())
                {
                    var codigo = conn.QuerySingle<int>("insertar_ruta", param, commandType: CommandType.StoredProcedure);
                    return codigo;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error al crear la ruta: " + ex.Message);
                throw;
            }
        }

        public List<Rutas> ListaRutas()
        {
            try
            {

                using (var conn = _dapperContext.CrearConexion())
                {
                    return conn.Query<Rutas>("obtener_rutas").ToList();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Rutas ObtenerRuta(int codigoRuta)
        {
            try
            {
                var param = new DynamicParameters();
                param.Add("@Codigo", codigoRuta, DbType.Int32, ParameterDirection.Input);
                using (var conn = _dapperContext.CrearConexion())
                {
                    var ruta = conn.QuerySingleOrDefault<Rutas>("obtener_ruta_porID", param, commandType: CommandType.StoredProcedure);

                    return ruta;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Rutas ActualizarRuta(Rutas ruta)
        {

            try
            {

                // Actualizar la fecha de cambio de estado
                ruta.FechaCreacion = DateTime.Now;

                // Realizar la actualización en la base de datos o en el almacenamiento correspondiente
                var param = new DynamicParameters();
                param.Add("@CodigoRuta", ruta.Codigo, DbType.Int32, ParameterDirection.Input);
                param.Add("@NuevoEstado", ruta.Estado, DbType.Int32, ParameterDirection.Input);
                param.Add("@NuevaFechaCreacion", ruta.FechaCreacion, DbType.DateTime, ParameterDirection.Input);

                using (var conn = _dapperContext.CrearConexion())
                {
                    conn.Execute("cambiarestado_ruta", param, commandType: CommandType.StoredProcedure);
                    return ruta;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar la ruta: " + ex.Message);
                throw;
            }
        }
    }
}
