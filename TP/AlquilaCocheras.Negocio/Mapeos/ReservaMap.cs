using System;
using System.Collections.Generic;
using System.Linq;
using AlquilaCocheras.Data;
using AlquilaCocheras.Data.Mapeos;
using AlquilaCocheras.Negocio.Servicios;

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
            ReservasServicio _reservasServicio = new ReservasServicio();

            return reservas.Select(r =>
            new ClienteReservaMap
            {
                IdReserva = r.IdReserva,
                HorarioInicio = r.HoraInicio,
                HorarioFin = r.HoraFin,
                PrecioFinal = Math.Round(r.Cocheras.Precio * r.CantidadHoras, 1),
                Puntuacion = _reservasServicio.ObtenerPuntuacionPromedio(r.IdReserva),
                FechaInicio = r.FechaInicio.ToString("dd/MM/yyyy"),
                FechaFin = r.FechaFin.ToString("dd/MM/yyyy"),
                EsReservaYaUtilizada = DateTime.Today > r.FechaFin,
                Ubicacion = r.Cocheras.Ubicacion
            }
            ).ToList();
        }

        public static List<PropietarioReservaMap> PropietarioReservasMap(List<Reservas> reservas)
        {
            return reservas.Select(r =>
            new PropietarioReservaMap
            {
                PrecioCobrado = r.Precio,
                Puntuacion = r.Puntuacion,
                FechaInicio = r.FechaInicio.ToString("dd/MM/yyyy"),
                FechaFin = r.FechaFin.ToString("dd/MM/yyyy"),
                EsReservaYaUtilizada = DateTime.Today > r.FechaFin,
                Ubicacion = r.Cocheras.Ubicacion,
                CantidadHoras = (int)r.CantidadHoras
            }
            ).ToList();
        }
    }
}
