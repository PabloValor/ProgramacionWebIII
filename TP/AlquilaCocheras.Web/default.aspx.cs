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

        private UsuarioService _usuarioService;
        private Usuario _usuario;
        private List<Cochera> _listadoCocherasDisponibles;

        #endregion

        public int CantidadCocherasDisponibles { get; set; }


        protected void Page_Load(object sender, EventArgs e)
        {
            var idUsuario = VariblesSesionManager.Obtener<int>(Constantes.USUARIO_LOGUEADO_ID);
            var _usuarioService = new UsuarioService();

            if (idUsuario != 0)
            {
                _usuario = _usuarioService.ObtenerUsuarioPorId(idUsuario);
                if (_usuario != null)
                {
                    Response.Redirect(_usuario.Perfil == TipoPerfilUsuario.Cliente ? "/clientes/reservas.aspx" : "/propietarios/reservas.aspx");
                }
            }
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            var cocherasServicio = new CocherasServicio();

            _listadoCocherasDisponibles = cocherasServicio.ObtenerTodasDisponibles(txtUbicacion.Text, txtFechaInicio.Text, txtFechaFin.Text);

            CantidadCocherasDisponibles = _listadoCocherasDisponibles.Count;

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