using System;
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

        public static List<ClienteReservaMap> ClienteReservasMap(List<Reserva> reservas)
        {
            return reservas.Select(r =>
            new ClienteReservaMap
            {
                Horario = DateTime.Now.ToString("hh:mm"),
                PrecioFinal = r.Cochera.PrecioPorHora * r.CantidadHoras,
                Puntuacion = 1,
                FechaInicio = DateTime.Now.ToString("dd/MM/yyyy"),
                FechaFin = DateTime.Now.AddDays(1).ToString("dd/MM/yyyy"),
                EsReservaYaUtilizada = DateTime.Today.AddDays(1) > DateTime.Today ? "" : "gray"  // (!) Validación de fechas hardcodeada
            }
            ).ToList();
        }
    }
}
