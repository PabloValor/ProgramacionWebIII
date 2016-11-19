using System;
using System.Collections.Generic;
using AlquilaCocheras.Data;
using AlquilaCocheras.Negocio.Mapeos;
using AlquilaCocheras.Negocio.Servicios;
using AlquilaCocheras.Web.Extensiones;

namespace AlquilaCocheras.Web.userControls
{
    public partial class UCFormularioBusqueda : System.Web.UI.UserControl
    {
        #region Miembros

        private Usuarios _usuario;
        private List<Cocheras> _listadoCocheras;
        private CocherasServicio _cocherasServicio = new CocherasServicio();
        private CocherasMap _cocherasMap = new CocherasMap();

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                _listadoCocheras = new List<Cocheras>();

                _listadoCocheras = _cocherasServicio.ObtenerTodasDisponibles(txtUbicacion.Text.ToLower(), txtFechaInicio.Text.ToDateTime(), txtFechaFin.Text.ToDateTime());

                CantidadCocherasDisponibles.Text = _listadoCocheras.Count > 0 ?
                    string.Format("Se han encontrado {0} cocheras disponibles", _listadoCocheras.Count)
                    : "No se encontraron resultados";

                CargarListaFiltradaCocherasDisponibles();
            }
        }

        #region Métodos Privados

        private void CargarListaFiltradaCocherasDisponibles()
        {
            rResultadoCocherasDisponiblesFiltradas.DataSource = _cocherasMap.MapearCocheraViewModel(_listadoCocheras);
            rResultadoCocherasDisponiblesFiltradas.DataBind();
        }

        #endregion
    }
}