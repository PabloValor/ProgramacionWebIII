using System;
using System.Collections.Generic;
using System.Linq;
using AlquilaCocheras.Data;
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
                    NombrePropietario = r.Propietario.Usuario.Nombre,
                    ApellidoPropietario = r.Propietario.Usuario.Apellido,
                    PrecioPorHora = (double)r.PrecioHora,
                    Imagen = r.Imagen,
                    Latitud = r.Latitud,
                    Longitud = r.Longitud,
                    Ubicacion = r.Ubicacion
                    //PuntajePromedioCochera = Math.Round((r.Puntaje.PuntajeTotal / r.Puntaje.CantidadVotos), 2)
                }
                ).ToList();
        }
    }
}
