using System;
using AlquilaCocheras.Data;
using AlquilaCocheras.Negocio.Servicios;
using AlquilaCocheras.Web.Extensiones;

namespace AlquilaCocheras.Web.propietarios
{
    public partial class cocheras : System.Web.UI.Page
    {

        #region Miembros

        private PropietariosServicio _propietariosServicio = new PropietariosServicio();
        private Usuarios _propietario;
        private CocherasServicio _cocherasServicio;

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            _propietario = _propietariosServicio.ObtenerPropietarioLogueado();
            _cocherasServicio = new CocherasServicio();
        }

        protected void btnCrearCochera_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                try
                {
                    var cochera = new Cocheras
                    {
                        IdPropietario = _propietario.IdUsuario,
                        Ubicacion = txtUbicacion.Text,
                        Latitud = int.Parse(txtLatitud.Text),
                        Longitud = int.Parse(txtLongitud.Text),
                        MetrosCuadrados = int.Parse(txtMetrosCuadrados.Text),
                        Descripcion = txtDescripcion.Text,
                        Precio = int.Parse(txtPrecioHora.Text),
                        FechaInicio = txtFechaInicio.Text.ToDateTime(),
                        FechaFin = txtFechaFin.Text.ToDateTime(),
                        Imagen = fuFoto.FileName,
                        HoraInicio = txtHorarioInicio.Text,
                        HoraFin = txtHorarioFin.Text
                    };

                    _cocherasServicio.Guardar(cochera);

                    lblResultado.Text = "Operacion Exitosa";
                }
                catch (Exception ex)
                {
                    lblResultado.Text = ex.Message;
                }
            }
            else
            {
                lblResultado.Text = "Algo salió mal...";
            }
        }
    }
}