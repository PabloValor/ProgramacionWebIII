using System;
using System.Collections.Generic;
using System.Linq;

namespace AlquilaCocheras.Data.Repositorios
{
    public class CocherasRepositorio
    {
        #region Miembros

        private readonly EstacionaloEntities _db;

        #endregion

        #region Constructores

        public CocherasRepositorio()
        {
            _db = new EstacionaloEntities();
        }

        #endregion

        #region Métodos Publicos

        public List<Cochera> Obtener()
        {
            var cocheras = _db.Cochera.ToList();
            return cocheras;
        }

        public Cochera ObtenerCocheraPorId(int id)
        {
            var cochera = _db.Cochera.FirstOrDefault(c => c.Id == id);
            return cochera;
        }

        public void Guardar(Cochera cochera)
        {
            try
            {
                _db.Cochera.Add(cochera);
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception("Error: no se ha podido guardar la cochera");
            }
        }

        #endregion

        #region Métodos Privados

        //private List<Cochera> ObtenerListadoCocherasMock()
        //{
        //    var cochera = new Cochera
        //    {
        //        Id = 123,
        //        Ubicacion = "Florencio Varela 1903, San Justo, Buenos Aires, AR",
        //        Latitud = "-34.670370",
        //        Longitud = "-58.563390",
        //        Imagen = "http://www.el1digital.com.ar/multimedia/imagen/56860_falcodesa2.jpg",
        //        Disponible = true,
        //        PrecioPorHora = 14,
        //        Puntaje = new Puntaje
        //        {
        //            CantidadVotos = 41,
        //            PuntajeTotal = 300
        //        },
        //        Propietario = new Propietario
        //        {
        //            Nombre = "Carlos",
        //            Apellido = "Lopez",
        //            Avatar = "https://image.freepik.com/iconos-gratis/user-avatar-fotografia-principal_318-85015.jpg",
        //            Email = "propietario@gmail.com",
        //            Password = "Password1",
        //            Id = 2,
        //            Perfil = TipoPerfilUsuario.Propietario
        //        }
        //    };

        //    for (var i = 0; i < 10; i++)
        //    {
        //        _cocheras.Add(cochera);
        //    }

        //    return _cocheras;
        //}
        #endregion
    }
}
