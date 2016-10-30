using System;
using System.Web;
using AlquilaCocheras.Data.Constantes;
using AlquilaCocheras.Data;
using AlquilaCocheras.Data.Enums;
using AlquilaCocheras.Negocio.Managers;
using AlquilaCocheras.Negocio.Servicios;

namespace AlquilaCocheras.Web.MasterPages
{
    public partial class Propietarios : System.Web.UI.MasterPage
    {
        #region Propiedades

        public Propietario Propietario { get; set; }
        public PropietariosServicio PropietariosServicio { get; set; }

        #endregion

        protected void Page_Init(object sender, EventArgs e)
        {
            if (!SesionesManager.EsUsuarioLogueado())
            {
                VariblesSesionManager.Guardar(Constantes.URL_RETORNO, HttpContext.Current.Request.Url.PathAndQuery);
                Response.Redirect("~/login.aspx");
            }

            PropietariosServicio = new PropietariosServicio();

            Propietario = PropietariosServicio.ObtenerPropietarioLogueado();

            if (Propietario == null || Propietario.Usuario.IdTipoPerfilUsuario != (int)Data.Enums.TipoPerfilUsuario.Propietario)
            {
                Response.Redirect("~/default.aspx");
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }
    }
}