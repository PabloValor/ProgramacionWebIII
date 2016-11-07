using System.Collections.Generic;
using System.Linq;
using AlquilaCocheras.Data;
using AlquilaCocheras.Negocio.Servicios;
using AlquilaCocheras.Negocio.ViewModels;

namespace AlquilaCocheras.Negocio.Mapeos
{
    public static class CocherasMap
    {
        public static List<CocheraViewModel> MapearCocheraViewModel(List<Cocheras> cocheras)
        {
            var reservasServicio = new ReservasServicio();
            var listadoReservas = reservasServicio.ObtenerTodas();

            var cocherasViewModel = cocheras.Select(c => new CocheraViewModel
            {
                Disponible = listadoReservas.All(r => r.IdCochera != c.IdCochera),
                IdCochera = c.IdCochera,
                NombrePropietario = c.Usuarios.Nombre,
                ApellidoPropietario = c.Usuarios.Apellido,
                PrecioPorHora = c.Precio,
                Imagen = c.Imagen,
                Latitud = c.Latitud,
                Longitud = c.Longitud,
                Ubicacion = c.Ubicacion
            }).ToList();

            return cocherasViewModel;
        }
    }
}
