using System.Collections.Generic;
using System.Linq;
using AlquilaCocheras.Data.Entidades;
using AlquilaCocheras.Data.Enums;

namespace AlquilaCocheras.Data.Repositorios
{
    public class CocherasRepositorio
    {
        #region Miembros

        private readonly List<Cochera> _cocheras = new List<Cochera>();

        #endregion

        #region Constructores

        public CocherasRepositorio()
        {
            _cocheras = ObtenerListadoCocherasMock();
        }

        #endregion

        #region Métodos Publicos

        public List<Cochera> Obtener()
        {
            return _cocheras;
        }

        public Cochera ObtenerCocheraPorId(int id)
        {
            var cochera = _cocheras.FirstOrDefault(c => c.Id == id);
            return cochera;
        }

        //public List<Cochera> Obtener(string ubicacion, DateTime fechaInicio, DateTime fechaFin)
        //{
        //    var cocheras = ObtenerListadoCocherasMock();
        //    return cocheras;
        //}

        public void Guardar(Cochera cochera)
        {
            _cocheras.Add(cochera);
        }

        #endregion

        #region Métodos Privados

        private List<Cochera> ObtenerListadoCocherasMock()
        {
            var cochera = new Cochera
            {
                Id = 123,
                Ubicacion = "Florencio Varela 1903, San Justo, Buenos Aires, AR",
                Latitud = "-34.670370",
                Longitud = "-58.563390",
                Imagen = "http://www.el1digital.com.ar/multimedia/imagen/56860_falcodesa2.jpg",
                Disponible = true,
                Puntaje = new Puntaje
                {
                    CantidadVotos = 41,
                    PuntajeTotal = 300
                },
                Propietario = new Propietario
                {
                    Nombre = "Carlos",
                    Apellido = "Lopez",
                    Avatar = "https://image.freepik.com/iconos-gratis/user-avatar-fotografia-principal_318-85015.jpg",
                    Email = "propietario@gmail.com",
                    Password = "Password1",
                    Id = 2,
                    Perfil = TipoPerfilUsuario.Propietario
                }
            };

            for (var i = 0; i < 10; i++)
            {
                _cocheras.Add(cochera);
            }

            return _cocheras;
        }
        #endregion
    }
}
