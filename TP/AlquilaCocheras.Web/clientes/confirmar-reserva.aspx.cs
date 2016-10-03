using System;
using System.Web;
using AlquilaCocheras.Data.Entidades;
using AlquilaCocheras.Negocio.Managers;
using AlquilaCocheras.Negocio.Servicios;

namespace AlquilaCocheras.Web.clientes
{
    public partial class confirmar_reserva : System.Web.UI.Page
    {
        #region Atributos

        public string MensajeError { get; set; }
        public Cochera Cochera { get; set; }

        #endregion 

        #region Miembros

        private ReservasServicio _reservasServicio = new ReservasServicio();
        private CocherasServicio _cocherasServicio = new CocherasServicio();
        private UsuarioService _usuarioService = new UsuarioService();
        private int _idCochera;

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!SesionesManager.EsUsuarioLogueado())
            {
                Response.RedirectPermanent("/login.aspx");
            }

            _idCochera = int.Parse(HttpContext.Current.Request.QueryString.Get("idcochera")); // TODO: Validar que un usuario no vea una cochera que no le corresponde

            Cochera = _cocherasServicio.ObtenerCocheraPorId(_idCochera);
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            var cliente = _usuarioService.ObtenerClientePorId(123); //TODO: Cuando este EF, se le va a pasar el Id del usuario que se está guardando en sesion (actualmente se guarda el email solo para pruebas)

            try
            {
                _reservasServicio.GenerarReserva(cliente, Cochera, DateTime.Now, new DateTime().AddDays(1));
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
            }
        }
    }
}