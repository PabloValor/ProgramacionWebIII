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
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarFormulioPerfil();
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                MapearUsuario();

                try
                {
                    Master.PropietariosServicio.ActualizarPropietario(Master.Propietario);
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
            txtNombre.Text = Master.Propietario.Usuario.Nombre;
            txtApellido.Text = Master.Propietario.Usuario.Apellido;
            txtEmail.Text = Master.Propietario.Usuario.Email;
            rblPerfil.SelectedValue = ((int)Master.Propietario.Usuario.IdTipoPerfilUsuario).ToString();
        }

        private void MapearUsuario()
        {
            Master.Propietario.Usuario.Nombre = txtNombre.Text;
            Master.Propietario.Usuario.Apellido = txtApellido.Text;
            Master.Propietario.Usuario.Password = txtContrasenia.Text;
            Master.Propietario.Usuario.IdTipoPerfilUsuario = rblPerfil.SelectedItem.Text.Contains("cliente") ? (int)Data.Enums.TipoPerfilUsuario.Cliente : (int)Data.Enums.TipoPerfilUsuario.Propietario;
        }

        #endregion
    }
}