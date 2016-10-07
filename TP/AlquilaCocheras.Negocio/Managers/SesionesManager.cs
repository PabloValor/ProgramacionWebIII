using System;
using AlquilaCocheras.Data.Constantes;
using AlquilaCocheras.Negocio.Servicios;

namespace AlquilaCocheras.Negocio.Managers
{
    public static class SesionesManager
    {
        public static void LoguearUsuario(string mailUsuario, string contrasena)
        {
            var _usuarioService = new UsuarioService();

            var usuario = _usuarioService.ObtenerUsuarioPorEmailYContrasena(mailUsuario, contrasena);

            if (usuario != null)
            {
                VariblesSesionManager.Guardar(Constantes.USUARIO_LOGUEADO_ID, usuario.Id);
            }
            else
            {
                throw new Exception("Error: Email o contraseña incorrectos");
            }
        }

        public static bool EsUsuarioLogueado()
        {
            var idUsuario = VariblesSesionManager.Obtener<int>(Constantes.USUARIO_LOGUEADO_ID);

            return idUsuario != 0;
        }
    }
}