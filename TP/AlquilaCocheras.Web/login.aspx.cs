using System;
using AlquilaCocheras.Data.Constantes;
using AlquilaCocheras.Negocio.Managers;

namespace AlquilaCocheras.Web
{
    public partial class login : System.Web.UI.Page
    {
        public string MensajeError { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                var urlRetorno = string.Empty;

                try
                {
                    SesionesManager.LoguearUsuario(txtEmail.Text, txtContrasenia.Text);

                    urlRetorno = VariblesSesionManager.Obtener<string>(Constantes.URL_RETORNO);

                    if (!string.IsNullOrEmpty(urlRetorno))
                    {
                        Response.Redirect(urlRetorno);
                    }
                    else
                    {
                        Response.Redirect("default.aspx");
                    }
                }
                catch (Exception ex)
                {
                    MensajeError = ex.Message;
                }
            }
            else
            {
                Response.Redirect("default.aspx");
            }
        }
    }
}