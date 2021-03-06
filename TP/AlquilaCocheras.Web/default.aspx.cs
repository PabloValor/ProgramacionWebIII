﻿using System;
using System.Collections.Generic;
using AlquilaCocheras.Data;
using AlquilaCocheras.Negocio.Servicios;

namespace AlquilaCocheras.Web
{
    public partial class _default : System.Web.UI.Page
    {

        #region Miembros

        private UsuarioService _usuarioService = new UsuarioService();
        private Usuarios _usuario;
        private List<Cocheras> _listadoCocherasDisponibles;

        #endregion


        protected void Page_Load(object sender, EventArgs e)
        {
            _usuario = _usuarioService.ObtenerUsuarioLogueado();

            if (_usuario != null)
            {
                Response.Redirect(_usuario.Perfil == (int)Data.Enums.TipoPerfilUsuario.Cliente ? "/clientes/reservas.aspx" : "/propietarios/reservas.aspx");
            }
        }
    }
}