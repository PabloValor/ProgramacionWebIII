﻿using System;
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
    }
}