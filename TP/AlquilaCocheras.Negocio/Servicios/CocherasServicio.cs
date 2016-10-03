using System.Collections.Generic;
using System.Linq;
using AlquilaCocheras.Data.Entidades;
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

        public List<Cochera> ObtenerTodas()
        {
            var reservas = _cocherasRepositorio.Obtener();

            return reservas;
        }

        public List<Cochera> ObtenerTodasDisponibles(string txtUbicacion, string txtFechaInicio, string txtFechaFin)
        {
            var cocherasDisponibles = _cocherasRepositorio.Obtener().Where(c => c.Disponible).ToList(); // (!) Hacer la validación correspondiente por ubicación y fechas
            return cocherasDisponibles;
        }

        public Cochera ObtenerCocheraPorId(int id)
        {
            var cochera = _cocherasRepositorio.ObtenerCocheraPorId(id);
            return cochera;
        }

        public void Guardar(Cochera reserva)
        {
            _cocherasRepositorio.Guardar(reserva);
        }

        #endregion
    }
}
