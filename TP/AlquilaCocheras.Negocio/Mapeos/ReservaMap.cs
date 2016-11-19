using System;
using System.Collections.Generic;
using System.Linq;
using AlquilaCocheras.Data;
using AlquilaCocheras.Data.Mapeos;

namespace AlquilaCocheras.Negocio.Mapeos
{
    public static class ReservaMap
    {
        public static List<CocheraDisponibleMap> Mapear(IList<Reservas> reservas)
        {
            return reservas.Select(r =>
                new CocheraDisponibleMap
                {
                    Id = r.IdCochera,
                    NombrePropietario = r.Usuarios.Nombre,
                    ApellidoPropietario = r.Usuarios.Apellido,
                    Imagen = r.Cocheras.Imagen,
                    Latitud = r.Cocheras.Latitud,
                    Longitud = r.Cocheras.Longitud
                }
            ).ToList();
        }

        public static List<ClienteReservaMap> ClienteReservasMap(List<Reservas> reservas)
        {
            return reservas.Select(r =>
            new ClienteReservaMap
            {
                HorarioInicio = r.HoraInicio,
                HorarioFin = r.HoraFin,
                PrecioFinal = Math.Round(r.Cocheras.Precio * r.CantidadHoras, 1),
                Puntuacion = 1,
                FechaInicio = r.FechaInicio.ToString("dd/MM/yyyy"),
                FechaFin = r.FechaFin.ToString("dd/MM/yyyy"),
                EsReservaYaUtilizada = DateTime.Today > r.FechaFin ? "reserva-utilizada" : ""
            }
            ).ToList();
        }
    }
}
