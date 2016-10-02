using System;
using System.Collections.Generic;
using AlquilaCocheras.Data.Entidades;
using AlquilaCocheras.Negocio.Mapeos;
using AlquilaCocheras.Negocio.Servicios;

namespace AlquilaCocheras.Web
{
    public partial class _default : System.Web.UI.Page
    {

        List<Reserva> _listadoReservas;

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            var reservasServicio = new ReservasServicio();
            _listadoReservas = reservasServicio.ObtenerReservas(txtUbicacion.Text, new DateTime(), new DateTime());
            CargarListaFiltradaReservasDisponibles();
        }

        private void CargarListaFiltradaReservasDisponibles()
        {
            rResultadoReservasFiltradas.DataSource = ReservaMap.Mapear(_listadoReservas);

            rResultadoReservasFiltradas.DataBind();
        }
    }
}