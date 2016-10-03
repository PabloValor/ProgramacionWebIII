using System;
using System.Collections.Generic;
using AlquilaCocheras.Data.Constantes;
using AlquilaCocheras.Data.Entidades;
using AlquilaCocheras.Negocio.Managers;
using AlquilaCocheras.Negocio.Mapeos;
using AlquilaCocheras.Negocio.Servicios;

namespace AlquilaCocheras.Web
{
    public partial class _default : System.Web.UI.Page
    {
        public int CantidadCocherasDisponibles { get; set; }

        List<Reserva> _listadoReservas;

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            var reservasServicio = new ReservasServicio();
            _listadoReservas = reservasServicio.ObtenerReservas(txtUbicacion.Text, new DateTime(), new DateTime());

            CantidadCocherasDisponibles = _listadoReservas.Count;

            CargarListaFiltradaReservasDisponibles();
        }

        private void CargarListaFiltradaReservasDisponibles()
        {
            rResultadoReservasFiltradas.DataSource = ReservaMap.Mapear(_listadoReservas);
            rResultadoReservasFiltradas.DataBind();
        }

        public void ConfirmarReserva(object sender, EventArgs e)
        {
            if (!SesionesManager.EsUsuarioLogueado())
            {
                VariblesSesionManager.Guardar<string>(Constantes.URL_RETORNO, "/clientes/confirmar-reserva.aspx?idcochera=123");
                Response.Redirect("login.aspx");
            }
            else
            {
                Response.Redirect("/clientes/confirmar-reserva.aspx?idcochera=123");
            }
        }
    }
}