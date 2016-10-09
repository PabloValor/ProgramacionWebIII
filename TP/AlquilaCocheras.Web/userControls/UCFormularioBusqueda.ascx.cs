using System;
using System.Collections.Generic;
using AlquilaCocheras.Data.Entidades;
using AlquilaCocheras.Negocio.Mapeos;
using AlquilaCocheras.Negocio.Servicios;

namespace AlquilaCocheras.Web.userControls
{
    public partial class UCFormularioBusqueda : System.Web.UI.UserControl
    {
        #region Miembros

        private Usuario _usuario;
        private List<Cochera> _listadoCocherasDisponibles;

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            var cocherasServicio = new CocherasServicio();

            _listadoCocherasDisponibles = cocherasServicio.ObtenerTodasDisponibles(txtUbicacion.Text, txtFechaInicio.Text, txtFechaFin.Text);

            CantidadCocherasDisponibles.Text = _listadoCocherasDisponibles.Count > 0 ?
                string.Format("Se han encontrado {0} cocheras disponibles", _listadoCocherasDisponibles.Count)
                : "No se encontraron resultados";

            CargarListaFiltradaCocherasDisponibles();
        }

        #region Métodos Privados

        private void CargarListaFiltradaCocherasDisponibles()
        {
            rResultadoCocherasDisponiblesFiltradas.DataSource = CocherasMap.Mapear(_listadoCocherasDisponibles);
            rResultadoCocherasDisponiblesFiltradas.DataBind();
        }

        #endregion
    }
}