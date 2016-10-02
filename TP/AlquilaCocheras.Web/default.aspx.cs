using System;
using AlquilaCocheras.Data.Constantes;
using AlquilaCocheras.Negocio.Servicios;

namespace AlquilaCocheras.Web
{
    public partial class _default : System.Web.UI.Page
    {
        private ReservasServicio _reservasServicio;


        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            _reservasServicio = new ReservasServicio();

            var reservas = _reservasServicio.ObtenerReservas(txtUbicacion.Text, new DateTime(), new DateTime());

            DLResultadosReservas.DataSource = reservas;

            DLResultadosReservas.DataBind();
        }
    }
}