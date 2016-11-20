using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using AlquilaCocheras.Data;
using AlquilaCocheras.Negocio.Mapeos;
using AlquilaCocheras.Web.Extensiones;

namespace AlquilaCocheras.Web.propietarios
{
    public partial class reservas : System.Web.UI.Page
    {
        private readonly TP_20162CEntities _db = new TP_20162CEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            rpReservas.DataSource = ReservaMap.PropietarioReservasMap(ObtenerReservas());
            rpReservas.DataBind();
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid) {
            }
        }

        protected void CustomValidatorFecha_ServerValidate(object source, System.Web.UI.WebControls.ServerValidateEventArgs args)
        {
            DateTime txtMyDateInicio = DateTime.Parse(txtFechaInicio.Text);
            DateTime txtMyDateFin = DateTime.Parse(txtFechaFin.Text);

            args.IsValid = (txtMyDateFin - txtMyDateInicio).TotalDays < 90;

        }

        private List<Reservas> ObtenerReservas()
        {
            var listado = (from propietario in _db.Usuarios
                join cochera in _db.Cocheras on propietario.IdUsuario equals cochera.IdPropietario
                join reserva in _db.Reservas on cochera.IdCochera equals reserva.IdCochera
                select reserva).ToList();

            listado.ForEach(x => x.Cocheras.Ubicacion = x.Cocheras.Ubicacion.Truncar(20));

            return listado.OrderByDescending(x => x.FechaFin).ToList();
        } 
    }
}