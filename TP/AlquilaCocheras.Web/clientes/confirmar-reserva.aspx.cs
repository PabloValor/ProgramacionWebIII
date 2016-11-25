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
                var fechaInicio = txtFechaInicio.Text.ToDateTime(txtHorarioInicio.Text);
                var fechaFin = txtFechaFin.Text.ToDateTime(txtHorarioFin.Text);

                var reserva = new Reservas
                {
                    IdCliente = cliente.IdUsuario,
                    IdCochera = Cochera.IdCochera,
                    FechaInicio = fechaInicio,
                    FechaFin = fechaFin,
                    CantidadHoras = Convert.ToDecimal((fechaFin - fechaInicio).TotalHours),
                    FechaCarga = DateTime.Now,
                    HoraInicio = string.Format("{0}:{1}", fechaInicio.Hour, fechaInicio.Minute),
                    HoraFin = string.Format("{0}:{1}", fechaFin.Hour, fechaFin.Minute),
                    Precio = Cochera.Precio * Convert.ToDecimal((fechaFin - fechaInicio).TotalHours)
                };

                if (_reservasServicio.EsReservaDisponible(reserva))
                {
                    _reservasServicio.GenerarReserva(reserva);   
                }
                else
                {
                    throw new Exception("Error: La cochera no está disponible en ese rango de horarios");
                }
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