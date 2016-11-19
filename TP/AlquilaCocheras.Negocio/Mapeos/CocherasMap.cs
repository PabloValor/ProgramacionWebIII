using System;
using System.Collections.Generic;
using System.Linq;
using AlquilaCocheras.Data;
using AlquilaCocheras.Negocio.Servicios;
using AlquilaCocheras.Negocio.ViewModels;

namespace AlquilaCocheras.Negocio.Mapeos
{
    public class CocherasMap
    {
        #region Miembros
        private readonly ReservasServicio _reservasServicio;
        #endregion

        public CocherasMap()
        {
            _reservasServicio = new ReservasServicio();
        }

        public List<CocheraViewModel> MapearCocheraViewModel(List<Cocheras> cocheras)
        {
            
            var listadoReservas = _reservasServicio.ObtenerTodas();

            var cocherasViewModel = cocheras.Select(c => new CocheraViewModel
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

            return cocherasViewModel;
        }

        private double ObtenerPromedioPuntuacion(int idCochera)
        {
            var promedioListadoPuntuaciones = _reservasServicio.ObtenerTodas().Where(r => r.IdCochera == idCochera).Select(r => r.Puntuacion).Average(s => s);
            return Math.Round(promedioListadoPuntuaciones, 1);
        }
    }
}
