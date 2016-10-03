using System;
using AlquilaCocheras.Data.Constantes;
using AlquilaCocheras.Data.Entidades;
using AlquilaCocheras.Negocio.Managers;
using AlquilaCocheras.Negocio.Servicios;

namespace AlquilaCocheras.Web.MasterPages
{
    public partial class Base : System.Web.UI.MasterPage
    {
        #region Propiedades

        public Usuario Usuario { get; set; }

        #endregion

        #region Miembros

        private UsuarioService _usuarioService = new UsuarioService();

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario = new Usuario();

            if (SesionesManager.EsUsuarioLogueado())
            {
                Usuario = _usuarioService.ObtenerUsuarioPorId(VariblesSesionManager.Obtener<int>(Constantes.USUARIO_LOGUEADO_ID));
            }
        }
    }
}