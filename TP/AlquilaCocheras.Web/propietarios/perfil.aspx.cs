using System;
using AlquilaCocheras.Data;

namespace AlquilaCocheras.Web.propietarios
{
    public partial class perfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CargarFormulioPerfil();
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                var propietario = Master.PropietariosServicio.ObtenerPropietarioLogueado();

                ActualizarPropietario(propietario);

                try
                {
                    Master.PropietariosServicio.ActualizarPropietario(propietario);
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

        private void ActualizarPropietario(Usuarios propietario)
        {
            propietario.Nombre = txtNombre.Text;
            propietario.Apellido = txtApellido.Text;
            propietario.Contrasenia = txtConfContrasenia.Text;
            propietario.Perfil = (short)int.Parse(rblPerfil.SelectedValue);
        }

        #endregion
    }
}