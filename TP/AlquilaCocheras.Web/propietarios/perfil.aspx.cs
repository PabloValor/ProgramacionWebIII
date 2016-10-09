using System;
using System.Web;
using System.Web.UI.WebControls;
using AlquilaCocheras.Data.Constantes;
using AlquilaCocheras.Data.Entidades;
using AlquilaCocheras.Data.Enums;
using AlquilaCocheras.Negocio.Managers;
using AlquilaCocheras.Negocio.Servicios;

namespace AlquilaCocheras.Web.propietarios
{
    public partial class perfil : System.Web.UI.Page
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

            CargarFormulioPerfil();
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                MapearUsuario();

                try
                {
                    _usuarioService.ActualizarUsuario(_usuario);
                    lblResultado.Text = "Operación exitosa";
                }
                catch (Exception ex)
                {

                    lblResultado.Text = ex.Message;
                }
            }
        }
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/default.aspx");
        }

        #region Métodos Privados

        private void CargarFormulioPerfil()
        {
            txtNombre.Text = _usuario.Nombre;
            txtApellido.Text = _usuario.Apellido;
            txtEmail.Text = _usuario.Email;
            rblPerfil.SelectedValue = ((int)_usuario.Perfil).ToString();
        }

        private void MapearUsuario()
        {
            _usuario.Nombre = txtNombre.Text;
            _usuario.Apellido = txtApellido.Text;
            _usuario.Password = txtContrasenia.Text;
            _usuario.Perfil = rblPerfil.SelectedItem.Text.Contains("cliente") ? TipoPerfilUsuario.Cliente : TipoPerfilUsuario.Propietario;
        }

        #endregion
    }
}