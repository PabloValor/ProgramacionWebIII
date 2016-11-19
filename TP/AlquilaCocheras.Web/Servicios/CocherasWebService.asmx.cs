using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Services;
using AlquilaCocheras.Data.DTOs;
using AlquilaCocheras.Data.Repositorios;
using AlquilaCocheras.Negocio.Servicios;

namespace AlquilaCocheras.Web.Servicios
{
    /// <summary>
    /// Summary description for CocherasWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CocherasWebService : System.Web.Services.WebService
    {
        #region Miembros

        private readonly ReservasServicio _reservasServicio = new ReservasServicio();
        private readonly CocherasRepositorio _cocherasRepositorio = new CocherasRepositorio();

        #endregion

        [WebMethod]
        public List<CocheraDTO> ObtenerCocheras(string ubicacion, DateTime fechaInicio, DateTime fechaFin)
        {
            var cocheras = _cocherasRepositorio.Obtener(ubicacion, fechaInicio, fechaFin).ToList();
            var listadoReservas = _reservasServicio.ObtenerTodas();

            var cocherasDTO = cocheras.Select(c => new CocheraDTO
            {
                NoDisponible = listadoReservas.Any(r => r.Cocheras.IdCochera == c.IdCochera),
                IdCochera = c.IdCochera,
                NombrePropietario = c.Usuarios.Nombre,
                ApellidoPropietario = c.Usuarios.Apellido,
                PrecioPorHora = c.Precio,
                Imagen = c.Imagen,
                Latitud = c.Latitud,
                Longitud = c.Longitud,
                Ubicacion = c.Ubicacion,
                PuntajePromedioCochera = ObtenerPromedioPuntuacion(c.IdCochera)
            }).ToList();

            return cocherasDTO;
        }


        private double ObtenerPromedioPuntuacion(int idCochera)
        {
            var promedioListadoPuntuaciones = _reservasServicio.ObtenerTodas().Where(r => r.IdCochera == idCochera).Select(r => r.Puntuacion).Average(s => s);
            return Math.Round(promedioListadoPuntuaciones, 1);
        }
    }
}
