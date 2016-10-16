﻿using System;
using System.Web;
using AlquilaCocheras.Data.Constantes;
using AlquilaCocheras.Data.Entidades;
using AlquilaCocheras.Data.Enums;
using AlquilaCocheras.Negocio.Managers;
using AlquilaCocheras.Negocio.Servicios;

namespace AlquilaCocheras.Web.MasterPages
{
    public partial class Clientes : System.Web.UI.MasterPage
    {
        #region Propiedades

        public Cliente Cliente { get; set; }
        public ClientesServicio ClientesServicio { get; set; }

        #endregion

        protected void Page_Init(object sender, EventArgs e)
        {
            if (!SesionesManager.EsUsuarioLogueado())
            {
                VariblesSesionManager.Guardar(Constantes.URL_RETORNO, HttpContext.Current.Request.Url.PathAndQuery);
                Response.Redirect("~/login.aspx");
            }

            ClientesServicio = new ClientesServicio();
            Cliente = ClientesServicio.ObtenerClienteLogueado();

            if (Cliente == null || Cliente.Perfil != TipoPerfilUsuario.Cliente)
            {
                Response.Redirect("~/default.aspx");
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }
    }
}