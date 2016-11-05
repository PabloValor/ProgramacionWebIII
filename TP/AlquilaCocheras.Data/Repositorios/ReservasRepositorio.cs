using System;
using System.Collections.Generic;
using System.Linq;

namespace AlquilaCocheras.Data.Repositorios
{
    public class ReservasRepositorio
    {

        #region Miembros

        private readonly EstacionaloEntities _db;

        #endregion

        #region Constructores

        public ReservasRepositorio()
        {
            _db = new EstacionaloEntities();
        }

        #endregion

        #region Métodos Publicos

        public List<Reserva> Obtener()
        {
            var reservas = _db.Reserva.ToList();
            return reservas;
        }

        public List<Reserva> Obtener(string ubicacion, DateTime fechaInicio, DateTime fechaFin)
        {
            var reservas = (from r in _db.Reserva
                join co in _db.Cochera on r.IdCochera equals co.Id
                where co.Ubicacion == ubicacion && r.FechaInicio == fechaInicio && r.FechaFin == fechaFin
                select new {r}).Select(x => x.r).ToList();

            return reservas;
        }

        public void Guardar(Reserva reserva)
        {
            try
            {
                _db.Reserva.Add(reserva);
                _db.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Error: No se pudo generar la reserva. Intente de nuevo");
            }
        }

        #endregion

        //#region Métodos Privados

        //private List<Reserva> ObtenerListadoReservasMock()
        //{
        //    var reserva = new Reserva
        //    {
        //        Cochera = new Cochera
        //        {
        //            Id = 123,
        //            Ubicacion = "Florencio Varela 1903, San Justo, Buenos Aires, AR",
        //            Latitud = "-34.670370",
        //            Longitud = "-58.563390",
        //            Imagen = "http://www.el1digital.com.ar/multimedia/imagen/56860_falcodesa2.jpg",
        //            Puntaje = new Puntaje
        //            {
        //                CantidadVotos = 41,
        //                PuntajeTotal = 300
        //            },
        //            PrecioPorHora = 5.5,
        //            Propietario = new Propietario()
        //            {
        //                Nombre = "Carlos",
        //                Apellido = "Lopez",
        //                Avatar = "https://image.freepik.com/iconos-gratis/user-avatar-fotografia-principal_318-85015.jpg",
        //                Email = "propietario@gmail.com",
        //                Password = "Password1",
        //                Id = 2,
        //                Perfil = TipoPerfilUsuario.Propietario
        //            }
        //        },
        //    };

        //    for (var i = 0; i < 10; i++)
        //    {
        //        _reservas.Add(reserva);
        //    }

        //    return _reservas;
        //}
        //#endregion
    }
}
