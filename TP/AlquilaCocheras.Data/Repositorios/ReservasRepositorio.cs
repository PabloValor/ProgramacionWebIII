using System;
using System.Collections.Generic;
using System.Linq;
using AlquilaCocheras.Data.Entidades;

namespace AlquilaCocheras.Data.Repositorios
{
    public class ReservasRepositorio
    {
        #region Métodos Publicos

        public List<Reserva> Obtener()
        {
            var reservas = ObtenerListadoReservasMock();
            return reservas;
        }

        public List<Reserva> Obtener(string ubicacion, DateTime fechaInicio, DateTime fechaFin)
        {
            var reservas = ObtenerListadoReservasMock();
            return reservas;
        }

        #endregion

        #region Métodos Privados

        private List<Reserva> ObtenerListadoReservasMock()
        {
            var reservas = new List<Reserva>();

            var reserva = new Reserva
            {
                Cochera = new Cochera
                {
                    Ubicacion = "Florencio Varela 1903, San Justo, Buenos Aires, AR",
                    Latitud = "-34.670370",
                    Longitud = "-58.563390",
                    Foto = "http://www.el1digital.com.ar/multimedia/imagen/56860_falcodesa2.jpg",
                    PuntajePromedio = 7.6
                },
                Propietario = new Propietario
                {
                    Nombre = "José",
                    Apellido = "Perez"
                },
                PrecioPorHora = 5.5,
                CantidadHoras = 4
            };

            for (var i = 0; i < 10; i++)
            {
                reservas.Add(reserva);
            }

            return reservas;
        }
        #endregion
    }
}
