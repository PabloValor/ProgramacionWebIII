using System;
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

        private UsuarioService _usuarioService;
        private Usuario _usuario;

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            //_usuario = _usuarioService.ObtenerUsuarioPorId(VariblesSesionManager.Obtener<int>(Constantes.USUARIO_LOGUEADO_ID));

            //if (_usuario.Perfil != TipoPerfilUsuario.Propietario)
            //{
            //    Response.RedirectPermanent("/default.aspx");
            //}
        }
    }
}