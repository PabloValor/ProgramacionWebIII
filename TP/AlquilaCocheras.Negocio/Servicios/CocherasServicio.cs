using System.Collections.Generic;
using System.Linq;
using AlquilaCocheras.Data;
using AlquilaCocheras.Data.Repositorios;

namespace AlquilaCocheras.Negocio.Servicios
{
    public class CocherasServicio
    {
        #region Miembros

        private readonly CocherasRepositorio _cocherasRepositorio;

        #endregion

        #region Constructores

        public CocherasServicio()
        {
            _cocherasRepositorio = new CocherasRepositorio();
        }

        #endregion

        #region Métodos Publicos

        public List<Cocheras> ObtenerTodas()
        {
            var reservas = _cocherasRepositorio.Obtener();

            return reservas;
        }

        public List<Cocheras> ObtenerTodasDisponibles(string txtUbicacion, string txtFechaInicio, string txtFechaFin)
        {
            var cocherasDisponibles = _cocherasRepositorio.Obtener().ToList(); // (!) Hacer la validación correspondiente por ubicación y fechas
            return cocherasDisponibles;
        }

        public Cocheras ObtenerCocheraPorId(int id)
        {
            var cochera = _cocherasRepositorio.ObtenerCocheraPorId(id);
            return cochera;
        }

        public void Guardar(Cocheras cochera)
        {
            _cocherasRepositorio.Guardar(cochera);
        }

        //public void ActualizarDisponibilidad(int idCochera, bool disponibilidad)
        //{
        //    _cocherasRepositorio.ActualizarDisponibilidad(idCochera, disponibilidad);
        //}

        #endregion
    }
}
