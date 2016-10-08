using System;
using AlquilaCocheras.Data.Entidades;
using AlquilaCocheras.Data.Enums;
using AlquilaCocheras.Negocio.Servicios;

namespace AlquilaCocheras.Web.propietarios
{
    public partial class cocheras : System.Web.UI.Page
    {
        #region Miembros

        private UsuarioService _usuarioService = new UsuarioService();
        private Usuario _usuario;

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            _usuario = _usuarioService.ObtenerUsuarioLogueado();
            if (_usuario == null || _usuario.Perfil != TipoPerfilUsuario.Propietario)
            {
                Response.Redirect("~/default.aspx");
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