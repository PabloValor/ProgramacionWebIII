using System;
using AlquilaCocheras.Data.Constantes;
using AlquilaCocheras.Data.Enums;
using AlquilaCocheras.Negocio.Managers;
using AlquilaCocheras.Negocio.Servicios;

namespace AlquilaCocheras.Web
{
    public partial class login : System.Web.UI.Page
    {
        #region Propiedades

        public string MensajeError { get; private set; }

        #endregion

        #region Miembros

        private UsuarioService _usuarioService = new UsuarioService();

        #endregion


        protected void Page_Load(object sender, EventArgs e)
        {
            if (SesionesManager.EsUsuarioLogueado())
            {
                Response.Redirect("~/default.aspx");
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                var urlRetorno = string.Empty;

                try
                {
                    var usuario = _usuarioService.ObtenerUsuarioPorEmailYContrasena(txtEmail.Text, txtContrasenia.Text);

                    SesionesManager.LoguearUsuario(usuario);

                    urlRetorno = VariblesSesionManager.Obtener<string>(Constantes.URL_RETORNO);

                    if (!string.IsNullOrEmpty(urlRetorno))
                    {
                        VariblesSesionManager.Eliminar(Constantes.URL_RETORNO);
                        Response.Redirect(urlRetorno);
                    }
                    else
                    {
                        var urlRedirect = usuario.Perfil == (int)TipoPerfilUsuario.Cliente ? "~/clientes/reservas.aspx" : "~/propietarios/reservas.aspx";
                        Response.Redirect(urlRedirect);
                    }
                }
                catch (Exception ex)
                {
                    MensajeError = ex.Message;
                }
            }
            else
            {
                Response.Redirect("~/default.aspx");
            }
        }
    }
}