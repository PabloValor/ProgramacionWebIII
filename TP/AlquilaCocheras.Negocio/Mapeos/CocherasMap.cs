using System;
using System.Collections.Generic;
using System.Linq;
using AlquilaCocheras.Data;
using AlquilaCocheras.Data.Mapeos;

namespace AlquilaCocheras.Negocio.Mapeos
{
    public static class CocherasMap
    {
        public static List<CocheraDisponibleMap> Mapear(List<Cocheras> cocheras)
        {
            return cocheras.Select(r =>
                new CocheraDisponibleMap
                {
                    Id = r.IdCochera,
                    NombrePropietario = r.Usuarios.Nombre,
                    ApellidoPropietario = r.Usuarios.Apellido,
                    PrecioPorHora = r.Precio,
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
