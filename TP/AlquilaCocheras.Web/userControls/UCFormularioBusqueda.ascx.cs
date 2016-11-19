using System;
using System.Collections.Generic;
using AlquilaCocheras.Data;
using AlquilaCocheras.Data.DTOs;
using AlquilaCocheras.Negocio.Mapeos;
using AlquilaCocheras.Negocio.Servicios;
using AlquilaCocheras.Web.Extensiones;
using AlquilaCocheras.Web.Servicios;

namespace AlquilaCocheras.Web.userControls
{
    public partial class UCFormularioBusqueda : System.Web.UI.UserControl
    {
        #region Miembros

        private Usuarios _usuario;
        private List<CocheraDTO> _listadoCocheras;
        private CocherasWebService _cocherasWebService = new CocherasWebService();

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                _listadoCocheras = new List<CocheraDTO>();

                _listadoCocheras = _cocherasWebService.ObtenerCocheras(txtUbicacion.Text.ToLower(),
                    txtFechaInicio.Text.ToDateTime(), txtFechaFin.Text.ToDateTime());

                CantidadCocherasDisponibles.Text = _listadoCocheras.Count > 0 ?
                    string.Format("Se han encontrado {0} cocheras disponibles", _listadoCocheras.Count)
                    : "No se encontraron resultados";

                CargarListaFiltradaCocherasDisponibles();
            }
        }

        #region Métodos Privados

        private void CargarListaFiltradaCocherasDisponibles()
        {
            rResultadoCocherasDisponiblesFiltradas.DataSource = _listadoCocheras;
            rResultadoCocherasDisponiblesFiltradas.DataBind();
        }

        #endregion
    }
}