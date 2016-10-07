using System;
using AlquilaCocheras.Data.Constantes;
using AlquilaCocheras.Data.Entidades;
using AlquilaCocheras.Data.Enums;
using AlquilaCocheras.Negocio.Managers;
using AlquilaCocheras.Negocio.Servicios;

namespace AlquilaCocheras.Web.propietarios
{
    public partial class cocheras : System.Web.UI.Page
    {
        #region Miembros

        private UsuarioService _usuarioService;
        private Usuario _usuario;

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            var idUsuario = VariblesSesionManager.Obtener<int>(Constantes.USUARIO_LOGUEADO_ID);
            var _usuarioService = new UsuarioService();

            if (idUsuario != 0)
            {
                _usuario = _usuarioService.ObtenerUsuarioPorId(idUsuario);
                if (_usuario == null || _usuario.Perfil != TipoPerfilUsuario.Propietario)
                {
                    Response.Redirect("../default.aspx");
                }
            }
        }

        protected void btnCrearCochera_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                lblResultado.Text = "Operacion Exitosa";


            }
        }
    }
}