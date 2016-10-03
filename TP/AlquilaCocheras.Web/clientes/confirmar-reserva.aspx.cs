using System;
using System.Web;
using AlquilaCocheras.Data.Constantes;
using AlquilaCocheras.Data.Entidades;
using AlquilaCocheras.Negocio.Managers;
using AlquilaCocheras.Negocio.Servicios;

namespace AlquilaCocheras.Web.clientes
{
    public partial class confirmar_reserva : System.Web.UI.Page
    {
        #region Propiedades

        public string MensajeExito { get; set; }
        public string MensajeError { get; set; }
        public Cochera Cochera { get; set; }

        #endregion 

        #region Miembros

        private ReservasServicio _reservasServicio = new ReservasServicio();
        private CocherasServicio _cocherasServicio = new CocherasServicio();
        private UsuarioService _usuarioService = new UsuarioService();

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!SesionesManager.EsUsuarioLogueado())
            {
                Response.RedirectPermanent("/login.aspx");
            }

            var idCochera = int.Parse(HttpContext.Current.Request.QueryString.Get("idcochera")); // TODO: Validar que no metan cualquier cosa

            Cochera = _cocherasServicio.ObtenerCocheraPorId(Math.Abs(idCochera));
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            var idCliente = VariblesSesionManager.Obtener<int>(Constantes.USUARIO_LOGUEADO_ID);

            var cliente = _usuarioService.ObtenerClientePorId(idCliente);

            try
            {
                _reservasServicio.GenerarReserva(cliente, Cochera, DateTime.Now, new DateTime().AddDays(1)); //  (!) Fechas hardcodeadas
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
            }

            MensajeExito = "La cochera se ha reservado con éxito";
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/default.aspx");
        }
    }
}