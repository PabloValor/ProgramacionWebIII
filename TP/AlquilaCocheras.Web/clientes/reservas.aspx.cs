using System;
using System.Linq;
using AlquilaCocheras.Negocio.Mapeos;

namespace AlquilaCocheras.Web.clientes
{
    public partial class reservas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            rpReservas.DataSource = ReservaMap.ClienteReservasMap(Master.Cliente.Reservas.ToList());
            rpReservas.DataBind();
        }
    }
}