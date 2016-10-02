using System.Collections.Generic;
using System.Linq;
using AlquilaCocheras.Data.Entidades;
using AlquilaCocheras.Data.Mapeos;

namespace AlquilaCocheras.Negocio.Mapeos
{
    public static class ReservaMap
    {
        public static List<ReservaMapeada> Mapear(IList<Reserva> reservas)
        {
            return reservas.Select(r =>
                new ReservaMapeada
                {
                    Id = r.Id,
                    NombrePropietario = r.Propietario.Nombre,
                    ApellidoPropietario = r.Propietario.Apellido,
                    Imagen = r.Cochera.Imagen,
                    Latitud = r.Cochera.Latitud,
                    Longitud = r.Cochera.Longitud,
                    PrecioPorHora = r.PrecioPorHora
                }
            ).ToList();
        }
    }
}
