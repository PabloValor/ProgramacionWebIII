﻿using System;
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
                Horario = DateTime.Now.ToString("hh:mm"),
                PrecioFinal = r.Cocheras.Precio * r.CantidadHoras,
                Puntuacion = 1,
                FechaInicio = DateTime.Now.ToString("dd/MM/yyyy"),
                FechaFin = DateTime.Now.AddDays(1).ToString("dd/MM/yyyy"),
                EsReservaYaUtilizada = DateTime.Today.AddDays(1) > DateTime.Today ? "" : "gray"  // (!) Validación de fechas hardcodeada
            }
            ).ToList();
        }
    }
}
