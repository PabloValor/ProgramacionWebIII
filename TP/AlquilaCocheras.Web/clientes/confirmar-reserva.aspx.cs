using System;
using System.Web;
using AlquilaCocheras.Data.Constantes;
using AlquilaCocheras.Data;
using AlquilaCocheras.Negocio.Managers;
using AlquilaCocheras.Negocio.Servicios;

namespace AlquilaCocheras.Web.clientes
{
    public partial class confirmar_reserva : System.Web.UI.Page
    {
        #region Propiedades

        public string MensajeResultadoOperacion { get; private set; }
        public Cochera Cochera { get; set; }

        #endregion

        #region Miembros

        private ReservasServicio _reservasServicio = new ReservasServicio();
        private CocherasServicio _cocherasServicio = new CocherasServicio();
        private ClientesServicio _clienteService = new ClientesServicio();
        private Usuario _usuario;

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {

            var idCochera = int.Parse(HttpContext.Current.Request.QueryString.Get("idcochera")); // TODO: Validar que no metan cualquier cosa

            Cochera = _cocherasServicio.ObtenerCocheraPorId(Math.Abs(idCochera));
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            var idCliente = VariblesSesionManager.Obtener<int>(Constantes.USUARIO_LOGUEADO_ID);

            var cliente = _clienteService.ObtenerClientePorId(idCliente);

            try
            {
                _reservasServicio.GenerarReserva(cliente.Id, DateTime.Now, new DateTime().AddDays(1), 99, Cochera.Id); //  (!) Fechas hardcodeadas
            }
            catch (Exception ex)
            {
                MensajeResultadoOperacion = ex.Message;
            }

            MensajeResultadoOperacion = "La cochera se ha reservado con éxito";
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/default.aspx");
        }
    }
}