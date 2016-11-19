using System;
using System.Linq;
using AlquilaCocheras.Negocio.Mapeos;
using AlquilaCocheras.Negocio.Servicios;

namespace AlquilaCocheras.Web.clientes
{
    public partial class reservas : System.Web.UI.Page
    {
        #region Miembros
        private ReservasServicio _reservasServicio = new ReservasServicio();
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            rpReservas.DataSource = ReservaMap.ClienteReservasMap(Master.Cliente.Reservas.OrderBy(x => x.FechaFin).ToList());
            rpReservas.DataBind();
        }

        protected void btnConfirmarPuntuacion_Click(object sender, EventArgs e)
        {
            try
            {
                _reservasServicio.PuntuarReserva(int.Parse(hdIdReserva.Value), int.Parse(ddlPuntuacion.SelectedValue));
            }
            catch (Exception ex)
            {
            }
        }
    }
}