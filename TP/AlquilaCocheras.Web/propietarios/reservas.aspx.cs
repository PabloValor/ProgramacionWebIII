using System;

namespace AlquilaCocheras.Web.propietarios
{
    public partial class reservas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid) {
            }
        }

        protected void CustomValidatorFecha_ServerValidate(object source, System.Web.UI.WebControls.ServerValidateEventArgs args)
        {
            DateTime txtMyDateInicio = DateTime.Parse(txtFechaInicio.Text);
            DateTime txtMyDateFin = DateTime.Parse(txtFechaFin.Text);

            args.IsValid = (txtMyDateFin - txtMyDateInicio).TotalDays < 90;

        }
    }
}