using System;
using System.Web;
using AlquilaCocheras.Data.Constantes;
using AlquilaCocheras.Data.Entidades;
using AlquilaCocheras.Data.Enums;
using AlquilaCocheras.Negocio.Managers;
using AlquilaCocheras.Negocio.Servicios;

namespace AlquilaCocheras.Web.propietarios
{
    public partial class reservas : System.Web.UI.Page
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

            if (_usuario == null || _usuario.Perfil != TipoPerfilUsuario.Propietario)
            {
                Response.Redirect("~/default.aspx");
            }
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
    }
}