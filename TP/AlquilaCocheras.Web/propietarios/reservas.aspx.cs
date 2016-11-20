using System;
using AlquilaCocheras.Negocio.Mapeos;
using AlquilaCocheras.Negocio.Servicios;
using AlquilaCocheras.Web.Extensiones;

namespace AlquilaCocheras.Web.propietarios
{
    public partial class reservas : System.Web.UI.Page
    {
        private readonly ReservasServicio _reservasServicio = new ReservasServicio();

        protected void Page_Load(object sender, EventArgs e)
        {
            CargarTodas();
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                var listado = _reservasServicio.ObtenerReservasPorFechas(Master.Propietario.IdUsuario, txtFechaInicio.Text.ToDateTime(), txtFechaFin.Text.ToDateTime());
                rpReservas.DataSource = ReservaMap.PropietarioReservasMap(listado);
                rpReservas.DataBind();

                lblResultado.Text = listado.Count > 0 ? string.Format("Se encontraron {0} reservas en ese rango de fechas", listado.Count) : "No hay reservas de tus cocheras con ese rango de fechas";
            }
        }

        protected void btnVerTodas_Click(object sender, EventArgs e)
        {
            CargarTodas();
        }

        protected void CustomValidatorFecha_ServerValidate(object source, System.Web.UI.WebControls.ServerValidateEventArgs args)
        {
            DateTime txtMyDateInicio = DateTime.Parse(txtFechaInicio.Text);
            DateTime txtMyDateFin = DateTime.Parse(txtFechaFin.Text);

            args.IsValid = (txtMyDateFin - txtMyDateInicio).TotalDays < 90;
        }

        private void CargarTodas()
        {
            var listado = _reservasServicio.ObtenerReservas(Master.Propietario.IdUsuario);
            listado.ForEach(x => x.Cocheras.Ubicacion = x.Cocheras.Ubicacion.Truncar(20));

            rpReservas.DataSource = ReservaMap.PropietarioReservasMap(listado);
            rpReservas.DataBind();

            lblResultado.Text = listado.Count > 0 ? string.Format("Se encontraron {0} reservas de tus cocheras", listado.Count) : "No hay reservas de tus cocheras";   
        }
    }
}