using System;
using AlquilaCocheras.Data.Constantes;
using AlquilaCocheras.Data.Entidades;
using AlquilaCocheras.Negocio.Managers;
using AlquilaCocheras.Negocio.Servicios;

namespace AlquilaCocheras.Web.MasterPages
{
    public partial class Clientes : System.Web.UI.MasterPage
    {
        #region Propiedades

        public Cliente Cliente { get; set; }

        #endregion

        #region Miembros

        private ClientesServicio _clientesServicio = new ClientesServicio();

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (SesionesManager.EsUsuarioLogueado())
            {
                Cliente = _clientesServicio.ObtenerClientePorId(VariblesSesionManager.Obtener<int>(Constantes.USUARIO_LOGUEADO_ID));
            }
        }
    }
}