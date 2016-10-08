using System;
using System.Web;
using AlquilaCocheras.Data.Constantes;
using AlquilaCocheras.Data.Entidades;
using AlquilaCocheras.Data.Enums;
using AlquilaCocheras.Negocio.Managers;
using AlquilaCocheras.Negocio.Servicios;

namespace AlquilaCocheras.Web.clientes
{
    public partial class reservar : System.Web.UI.Page
    {
        #region Miembros

        private UsuarioService _usuarioService = new UsuarioService();
        private Usuario _usuario;

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!SesionesManager.EsUsuarioLogueado())
            {
                VariblesSesionManager.Guardar(Constantes.URL_RETORNO, HttpContext.Current.Request.Url.PathAndQuery);
                Response.Redirect("~/login.aspx");
            }

            _usuario = _usuarioService.ObtenerUsuarioLogueado();

            if (_usuario == null || _usuario.Perfil != TipoPerfilUsuario.Cliente)
            {
                Response.Redirect("~/default.aspx");
            }
        }
    }
}