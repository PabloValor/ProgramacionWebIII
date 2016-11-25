using System;
using System.Web;
using AlquilaCocheras.Data;
using AlquilaCocheras.Negocio.Servicios;
using AlquilaCocheras.Web.Extensiones;

namespace AlquilaCocheras.Web.clientes
{
    public partial class confirmar_reserva : System.Web.UI.Page
    {
        #region Propiedades

        public string MensajeResultadoOperacion { get; private set; }
        public Cocheras Cochera { get; set; }

        #endregion

        #region Miembros

        private ReservasServicio _reservasServicio = new ReservasServicio();
        private CocherasServicio _cocherasServicio = new CocherasServicio();
        private Usuarios _usuario;

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {

            var idCochera = int.Parse(HttpContext.Current.Request.QueryString.Get("idcochera"));

            Cochera = _cocherasServicio.ObtenerCocheraPorId(Math.Abs(idCochera));
            hdPrecioHora.Value = Cochera.Precio.ToString();
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            var cliente = Master.Cliente;

            try
            {
                _reservasServicio.GenerarReserva(cliente.IdUsuario, txtFechaInicio.Text.ToDateTime(txtHorarioInicio.Text), txtFechaFin.Text.ToDateTime(txtHorarioFin.Text), Cochera.IdCochera);
            }
            catch (Exception ex)
            {
                MensajeResultadoOperacion = ex.Message;
                return;
            }

            MensajeResultadoOperacion = "La cochera se ha reservado con éxito";
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/default.aspx");
        }
    }
}