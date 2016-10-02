using System;
using System.Collections.Generic;
using System.IO;
using AlquilaCocheras.Data.Entidades;
using AlquilaCocheras.Negocio.Mapeos;
using AlquilaCocheras.Negocio.Servicios;
using AlquilaCocheras.Web.clientes;

namespace AlquilaCocheras.Web
{
    public partial class _default : System.Web.UI.Page
    {
        public string CantidadReservas
        {       
            get
            {
                return _listadoReservas.Count > 0 ?
                    string.Format("Se encontraron {0} reservas", _listadoReservas.Count) :
                    "No se han encontrado reservas con esos criterios";
            }
        }


        List<Reserva> _listadoReservas;


        protected void Page_Load(object sender, EventArgs e)
        {
            var reservasServicio = new ReservasServicio();
            _listadoReservas = reservasServicio.ObtenerReservas(txtUbicacion.Text, new DateTime(), new DateTime());
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            CargarListaFiltradaReservasDisponibles();
        }

        private void CargarListaFiltradaReservasDisponibles()
        {

            rResultadoReservasFiltradas.DataSource = ReservaMap.Mapear(_listadoReservas);

            rResultadoReservasFiltradas.DataBind();
        }
    }
}