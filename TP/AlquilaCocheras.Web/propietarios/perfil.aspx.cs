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
            txtNombre.Text = Master.Propietario.Nombre;
            txtApellido.Text = Master.Propietario.Apellido;
            txtEmail.Text = Master.Propietario.Email;
            rblPerfil.SelectedValue = ((int)Master.Propietario.Perfil).ToString();
        }

        private void MapearUsuario()
        {
            Master.Propietario.Nombre = txtNombre.Text;
            Master.Propietario.Apellido = txtApellido.Text;
            Master.Propietario.Password = txtContrasenia.Text;
            Master.Propietario.Perfil = rblPerfil.SelectedItem.Text.Contains("cliente") ? TipoPerfilUsuario.Cliente : TipoPerfilUsuario.Propietario;
        }

        #endregion
    }
}