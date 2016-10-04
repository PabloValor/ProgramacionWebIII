using System;
using AlquilaCocheras.Data.Entidades;
using AlquilaCocheras.Data.Enums;
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

                    switch (usuario.Perfil)
                    {
                        case TipoPerfilUsuario.Cliente:
                            Response.Redirect("clientes/reservas.aspx");
                            break;

                        case TipoPerfilUsuario.Propietario:
                            Response.Redirect("propietarios/reservas.aspx");
                            break;

                        default:
                            Response.Redirect("default.aspx");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    lblResultado.Text = "Algo salió mal en la registración de usuario";
                }

                lblResultado.Text = "Registración exitosa, diríjase al <a href='#'>Login</a>";
            }
        }
    }
}