using System;
using System.Collections.Generic;
using System.Linq;
using AlquilaCocheras.Data;
using AlquilaCocheras.Negocio.Mapeos;
using AlquilaCocheras.Negocio.Servicios;
using AlquilaCocheras.Web.Extensiones;

namespace AlquilaCocheras.Web.clientes
{
    public partial class reservas : System.Web.UI.Page
    {
        #region Miembros
        private ReservasServicio _reservasServicio = new ReservasServicio();
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            var reservas = Master.Cliente.Reservas.OrderBy(x => x.FechaFin).ToList();
            TruncarUbicaciones(reservas);
            var reservasMapeadas = ReservaMap.ClienteReservasMap(reservas);
            rpReservas.DataSource = reservasMapeadas;
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


        private void TruncarUbicaciones(List<Reservas> reservas)
        {
            reservas.ForEach(x => x.Cocheras.Ubicacion = x.Cocheras.Ubicacion.Truncar(20));
        }
    }
}