using System.Collections.Generic;
using System.Linq;
using AlquilaCocheras.Data.Entidades;
using AlquilaCocheras.Data.Mapeos;

namespace AlquilaCocheras.Negocio.Mapeos
{
    public static class CocherasMap
    {
        public static List<CocheraDisponibleMap> Mapear(List<Cochera> cocheras)
        {
            return cocheras.Select(r =>
                new CocheraDisponibleMap
                {
                    Id = r.Id,
                    NombrePropietario = r.Propietario.Nombre,
                    ApellidoPropietario = r.Propietario.Apellido,
                    Imagen = r.Imagen,
                    Latitud = r.Latitud,
                    Longitud = r.Longitud
                }
                ).ToList();
        }
    }
}
