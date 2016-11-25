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
                        Latitud = Convert.ToDecimal(txtLatitud.Text),
                        Longitud = Convert.ToDecimal(txtLongitud.Text),
                        MetrosCuadrados = int.Parse(txtMetrosCuadrados.Text),
                        Descripcion = txtDescripcion.Text,
                        Precio = Convert.ToDecimal(txtPrecioHora.Text),
                        FechaInicio = txtFechaInicio.Text.ToDateTime(txtHorarioInicio.Text),
                        FechaFin = txtFechaFin.Text.ToDateTime(txtHorarioFin.Text),
                        Imagen = fuFoto.Text,
                        HoraInicio = txtHorarioInicio.Text,
                        HoraFin = txtHorarioFin.Text
                    };

                    var cantidadTipoVehiculoSeleccionados = lbTipoVehiculo.GetSelectedIndices();

                    if (cantidadTipoVehiculoSeleccionados.Length > 1)
                    {
                        foreach (var tipoVehiculo in cantidadTipoVehiculoSeleccionados)
                        {
                            // guardar la cochera modificando la Descripción
                        }
                    }
                    else
                    {
                        // guardar normalmente
                    }

                    _cocherasServicio.Guardar(cochera);

                    lblResultado.Text = "Operación Exitosa";
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