using System.Collections.Generic;
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
