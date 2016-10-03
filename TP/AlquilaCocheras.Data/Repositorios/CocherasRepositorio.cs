using System.Collections.Generic;
using System.Linq;
using AlquilaCocheras.Data.Entidades;

namespace AlquilaCocheras.Data.Repositorios
{
    public class CocherasRepositorio
    {
        #region Miembros

        private readonly List<Cochera> _cocheras;

        #endregion

        #region Constructores

        public CocherasRepositorio()
        {
            _cocheras = new List<Cochera>();
        }

        #endregion

        #region Métodos Publicos

        public List<Cochera> Obtener()
        {
            var cocheras = ObtenerListadoCocherasMock();
            return cocheras;
        }

        public Cochera ObtenerCocheraPorId(int id)
        {
            var cochera = ObtenerListadoCocherasMock().FirstOrDefault(c => c.Id == id);
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
                Puntaje = new Puntaje
                {
                    CantidadVotos = 41,
                    PuntajeTotal = 300
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
