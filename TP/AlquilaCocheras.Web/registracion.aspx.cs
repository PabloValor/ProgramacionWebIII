using System;
using AlquilaCocheras.Data.Entidades;
using AlquilaCocheras.Data.Enums;
using AlquilaCocheras.Negocio.Managers;
using AlquilaCocheras.Negocio.Servicios;


namespace AlquilaCocheras.Web
{
    public partial class registracion : System.Web.UI.Page
    {
        #region Propiedades

        private UsuarioService _usuarioService = new UsuarioService();

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {

                var usuario = new Usuario
                {
                    Id = 99,
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Email = txtEmail.Text,
                    Password = txtContrasenia.Text,
                    Perfil =
                        rblPerfil.Text == TipoPerfilUsuario.Cliente.ToString()
                            ? TipoPerfilUsuario.Cliente
                            : TipoPerfilUsuario.Propietario
                };

                try
                {
                    _usuarioService.GuardarUsuario(usuario);
                }
                catch (Exception)
                {
                    lblResultado.Text = "Algo salió mal en la registración de usuario";
                }

                lblResultado.Text = "Registración exitosa, diríjase al <a href='login.aspx'>Login</a>";
            }
        }
    }
}