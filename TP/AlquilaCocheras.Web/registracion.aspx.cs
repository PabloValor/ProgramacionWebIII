using System;
using AlquilaCocheras.Data;
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
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Email = txtEmail.Text,
                    Password = txtContrasenia.Text,
                    IdTipoPerfilUsuario = int.Parse(rblPerfil.SelectedItem.Value),
                    // Avatar = 
                };

                try
                {
                    _usuarioService.GuardarUsuario(usuario);
                }
                catch (Exception ex)
                {
                    lblResultado.Text = ex.Message;
                }

                lblResultado.Text = "Registración exitosa, diríjase al <a href='login.aspx'>Login</a>";
            }
        }
    }
}