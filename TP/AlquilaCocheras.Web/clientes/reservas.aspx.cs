using System;
using System.Web;
using AlquilaCocheras.Data.Constantes;
using AlquilaCocheras.Data.Entidades;
using AlquilaCocheras.Data.Enums;
using AlquilaCocheras.Negocio.Managers;
using AlquilaCocheras.Negocio.Mapeos;
using AlquilaCocheras.Negocio.Servicios;

namespace AlquilaCocheras.Web.clientes
{
    public partial class reservas : System.Web.UI.Page
    {
        #region Miembros

        private ClientesServicio _clientesServicio = new ClientesServicio();
        private Cliente _cliente;

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!SesionesManager.EsUsuarioLogueado())
            {
                VariblesSesionManager.Guardar(Constantes.URL_RETORNO, HttpContext.Current.Request.Url.PathAndQuery);
                Response.Redirect("~/login.aspx");
            }

            _cliente = _clientesServicio.ObtenerClienteLogueado();

            if (_cliente == null || _cliente.Perfil != TipoPerfilUsuario.Cliente)
            {
                Response.Redirect("~/default.aspx");
            }

            rpReservas.DataSource = ReservaMap.ClienteReservasMap(_cliente.Reservas);
            rpReservas.DataBind();
        }
    }
}