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
                try
                {
                    if (_usuarioService.YaExisteEmail(txtEmail.Text))
                    {
                        throw new Exception("Error: el email que ingresó ya se encuentra en uso. Por favor, elegí otro");
                    }

                    var usuario = new Usuarios
                    {
                        Nombre = txtNombre.Text,
                        Apellido = txtApellido.Text,
                        Email = txtEmail.Text,
                        Contrasenia = txtContrasenia.Text,
                        Perfil = (short)int.Parse(rblPerfil.SelectedItem.Value),
                        // Avatar = 
                    };

                    _usuarioService.GuardarUsuario(usuario);
                }
                catch (Exception ex)
                {
                    lblResultado.CssClass = "registro-usuario-error";
                    lblResultado.Text = ex.Message;
                    return;
                }

                lblResultado.CssClass = "registro-usuario-exito";
                lblResultado.Text = "Registración exitosa";
            }
        }
    }
}