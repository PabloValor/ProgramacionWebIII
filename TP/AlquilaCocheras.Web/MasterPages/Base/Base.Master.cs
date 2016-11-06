using System;
using AlquilaCocheras.Data.Constantes;
using AlquilaCocheras.Data;
using AlquilaCocheras.Negocio.Managers;
using AlquilaCocheras.Negocio.Servicios;
using System.Web;

namespace AlquilaCocheras.Web.MasterPages
{
    public partial class Base : System.Web.UI.MasterPage
    {
        #region Propiedades

        public Usuarios Usuario { get; set; }

        #endregion

        #region Miembros

        private UsuarioService _usuarioService = new UsuarioService();

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (SesionesManager.EsUsuarioLogueado())
            {
                Usuario =
                    _usuarioService.ObtenerUsuarioPorId(VariblesSesionManager.Obtener<int>(Constantes.USUARIO_LOGUEADO_ID));
            }
        }

        //Cambiar de lugar despues
        public String getPageName()
        {
            string[] arrResult = HttpContext.Current.Request.RawUrl.Split('/');
            String result = arrResult[arrResult.GetUpperBound(0)];
            arrResult = result.Split('?');
            return arrResult[arrResult.GetLowerBound(0)];
        }

        public void btnSalir(object sender, EventArgs e)
        {
            VariblesSesionManager.Eliminar(Constantes.USUARIO_LOGUEADO_ID);
            Usuario = null;


            if (getPageName() == "default.aspx") {
                Response.Redirect("default.aspx");
            } else {
                Response.Redirect("../default.aspx");
            }
        }
    }
}