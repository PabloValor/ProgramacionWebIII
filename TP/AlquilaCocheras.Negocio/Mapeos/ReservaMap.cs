using System.Collections.Generic;
using System.Linq;
using AlquilaCocheras.Data.Entidades;
using AlquilaCocheras.Data.Mapeos;

namespace AlquilaCocheras.Negocio.Mapeos
{
    public static class ReservaMap
    {
        public static List<CocheraDisponibleMap> Mapear(IList<Reserva> reservas)
        {
            return reservas.Select(r =>
                new CocheraDisponibleMap
                {
                    Id = r.Id,
                    NombrePropietario = r.Cochera.Propietario.Nombre,
                    ApellidoPropietario = r.Cochera.Propietario.Apellido,
                    Imagen = r.Cochera.Imagen,
                    Latitud = r.Cochera.Latitud,
                    Longitud = r.Cochera.Longitud
                }
            ).ToList();
        }
    }
}
