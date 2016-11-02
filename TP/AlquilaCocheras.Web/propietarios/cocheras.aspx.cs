using System;
using System.Collections.Generic;
using AlquilaCocheras.Data;
using AlquilaCocheras.Negocio.Servicios;

namespace AlquilaCocheras.Web.propietarios
{
    public partial class cocheras : System.Web.UI.Page
    {

        #region Miembros

        private PropietariosServicio _propietariosServicio = new PropietariosServicio();
        private Propietario _propietario;
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
                    var cochera = new Cochera
                    {
                        IdPropietario = _propietario.Id,
                        Ubicacion = txtUbicacion.Text,
                        Latitud = txtLatitud.Text,
                        Longitud = txtLongitud.Text,
                        SuperficieM2 = int.Parse(txtMetrosCuadrados.Text),
                        Descripcion = txtDescripcion.Text,
                        Disponible = true,
                        PrecioHora = int.Parse(txtPrecioHora.Text)
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