using System;
using System.Collections.Generic;
using AlquilaCocheras.Data;
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
            if (Page.IsValid)
            {
                _listadoCocherasDisponibles = new List<Cochera>();
                var cocherasServicio = new CocherasServicio();

                if (txtUbicacion.Text.ToLower() == "haedo")
                {
                    _listadoCocherasDisponibles = cocherasServicio.ObtenerTodasDisponibles(txtUbicacion.Text, txtFechaInicio.Text, txtFechaFin.Text);

                    CantidadCocherasDisponibles.Text = _listadoCocherasDisponibles.Count > 0 ?
                        string.Format("Se han encontrado {0} cocheras disponibles", _listadoCocherasDisponibles.Count)
                        : "No se encontraron resultados";

                    CargarListaFiltradaCocherasDisponibles();
                }
                else
                {
                    CantidadCocherasDisponibles.Text = "No se encontraron resultados";
                    rResultadoCocherasDisponiblesFiltradas.DataSource = CocherasMap.Mapear(_listadoCocherasDisponibles);
                    rResultadoCocherasDisponiblesFiltradas.DataBind();

                }

            }
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