using System;
using System.Collections.Generic;
using AlquilaCocheras.Data.Constantes;
using AlquilaCocheras.Data.Entidades;
using AlquilaCocheras.Data.Enums;
using AlquilaCocheras.Negocio.Managers;
using AlquilaCocheras.Negocio.Mapeos;
using AlquilaCocheras.Negocio.Servicios;

namespace AlquilaCocheras.Web
{
    public partial class _default : System.Web.UI.Page
    {

        #region Miembros

        private UsuarioService _usuarioService = new UsuarioService();
        private Usuario _usuario;
        private List<Cochera> _listadoCocherasDisponibles;

        #endregion


        protected void Page_Load(object sender, EventArgs e)
        {
            _usuario = _usuarioService.ObtenerUsuarioLogueado();

            if (_usuario != null)
            {
                Response.Redirect(_usuario.Perfil == TipoPerfilUsuario.Cliente ? "/clientes/reservas.aspx" : "/propietarios/reservas.aspx");
            }
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            var cocherasServicio = new CocherasServicio();

            _listadoCocherasDisponibles = cocherasServicio.ObtenerTodasDisponibles(txtUbicacion.Text, txtFechaInicio.Text, txtFechaFin.Text);

            CantidadCocherasDisponibles.Text = _listadoCocherasDisponibles.Count > 0 ? string.Format("Se han encontrado {0} cocheras disponibles", _listadoCocherasDisponibles.Count) : "No se han encontrado cocheras";

            CargarListaFiltradaCocherasDisponibles();
        }

        private void CargarListaFiltradaCocherasDisponibles()
        {
            rResultadoCocherasDisponiblesFiltradas.DataSource = CocherasMap.Mapear(_listadoCocherasDisponibles);
            rResultadoCocherasDisponiblesFiltradas.DataBind();
        }

        public void ConfirmarReserva(object sender, EventArgs e)
        {
            if (!SesionesManager.EsUsuarioLogueado())
            {
                VariblesSesionManager.Guardar(Constantes.URL_RETORNO, "/clientes/confirmar-reserva.aspx?idcochera=123");
                Response.Redirect("login.aspx");
            }
            else
            {
                Response.Redirect("/clientes/confirmar-reserva.aspx?idcochera=123");
            }
        }
    }
}