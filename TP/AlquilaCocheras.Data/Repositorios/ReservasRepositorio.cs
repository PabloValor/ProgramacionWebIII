using System;
using System.Collections.Generic;
using System.Linq;
using AlquilaCocheras.Data.Entidades;

namespace AlquilaCocheras.Data.Repositorios
{
    public class ReservasRepositorio
    {
        #region Miembros

        private List<Reserva> _reservas;

        #endregion

        #region Constructores

        public ReservasRepositorio()
        {
            _reservas = new List<Reserva>();
        }

        #endregion

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

        public void Guardar(Reserva reserva)
        {
            _reservas.Add(reserva);
        }

        #endregion

        #region Métodos Privados

        private List<Reserva> ObtenerListadoReservasMock()
        {

            var reserva = new Reserva
            {
                Cochera = new Cochera
                {
                    Id = 123,
                    Ubicacion = "Florencio Varela 1903, San Justo, Buenos Aires, AR",
                    Latitud = "-34.670370",
                    Longitud = "-58.563390",
                    Imagen = "http://www.el1digital.com.ar/multimedia/imagen/56860_falcodesa2.jpg",
                    Puntaje = new Puntaje
                    {
                        CantidadVotos = 41,
                        PuntajeTotal = 300
                    },
                    PrecioPorHora = 5.5,
                    Propietario = new Propietario
                    {
                        Nombre = "José",
                        Apellido = "Perez"
                    }
                },
            };

            for (var i = 0; i < 10; i++)
            {
                _reservas.Add(reserva);
            }

            return _reservas;
        }
        #endregion
    }
}
