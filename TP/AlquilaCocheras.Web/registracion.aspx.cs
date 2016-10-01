using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace AlquilaCocheras.Web
{
    public partial class registracion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            if (Page.IsValid) {

                lblResultado.Text = "Registración exitosa, diríjase al <a href='#'>Login</a>";
            }
        }
    }
}